using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nethermind.Grandine
{
    public sealed class Grandine
    {
        public Grandine()
        {
        }

        public unsafe static Task RunGrandine(Dictionary<string, List<string>> grandineConfig, CancellationToken cancellationToken)
        {
            return Task.Run(() => 
            {
                var options = new List<byte[]>();
                foreach ((string key, List<string> value) in grandineConfig)
                {
                    if (value.Count == 0)
                    {
                        options.Add(Encoding.UTF8.GetBytes(key));
                    }
                    else if (key == "--features")
                    {
                        var encodedKey = Encoding.UTF8.GetBytes(key);
                        value.ForEach(o => options.AddRange([ encodedKey, Encoding.UTF8.GetBytes(o) ]));
                    }
                    else
                    {
                        options.AddRange([ Encoding.UTF8.GetBytes(key), ..value.Select(o => Encoding.UTF8.GetBytes(o)) ]);
                    }
                }
                byte*[] ptrArray = new byte*[options.Count];
                for (var i = 0; i < options.Count; ++i)
                {
                    fixed (byte* ptr = options[i])
                    {
                        ptrArray[i] = ptr;
                    }
                }

                fixed (byte** ptrToPtr = &ptrArray[0])
                {
                    NativeMethods.grandine_run((ulong)options.Count, ptrToPtr);
                }
            }, cancellationToken);
        }

        public static (string[], Dictionary<string, List<string>>) ConfigureGrandine(string[] args)
        {
            var grandineConfig = new GrandineConfig();
            var grandineArgs = new Dictionary<string, List<string>>();
            var argsList = new List<string>();
            IEnumerable<(string, bool, string, Type)> properties = grandineConfig
                .GetType()
                .GetProperties()
                .Select(p => (
                    p.GetCustomAttribute<NethermindCliOptionAttribute>().OptionName,
                    p.GetCustomAttribute<NethermindCliOptionAttribute>().IsFlag, 
                    p.GetCustomAttribute<GrandineCliOptionAttribute>().OptionName, 
                    p.PropertyType)
                );

            var i = 0;
            while (i < args.Length)
            {
                (string nethermindCli, bool isFlag, string grandineCli, Type type) = properties.FirstOrDefault(p => p.Item1 == args[i]);
                
                // patikrinti
                if (nethermindCli == "--Grandine.Features")
                {
                    if (!grandineArgs.TryAdd(grandineCli, [ args[i] ]))
                    {
                        grandineArgs[grandineCli].Add(args[i]);
                    }
                    i += 1;
                }
                else if (nethermindCli is not null && !isFlag)
                {
                    grandineArgs.Add(grandineCli, []);
                    i += 1;
                    while (i < args.Length && !args[i].StartsWith("--"))
                    {
                        grandineArgs[grandineCli].Add(args[i]);
                        i += 1;
                    }

                    if ((type != typeof(List<string>) && grandineArgs[grandineCli].Count > 1) || grandineArgs[grandineCli].Count == 0)
                    {
                        throw new Exception($"Incorrect argument count for {nethermindCli}.");
                    }
                }
                else if (nethermindCli is not null)
                {
                    grandineArgs.Add(grandineCli, []);
                    i += 1;
                }
                else
                {
                    argsList.Add(args[i]);
                    i += 1;
                }
            }
            
            return (argsList.ToArray(), grandineArgs);
        }
    }
}

