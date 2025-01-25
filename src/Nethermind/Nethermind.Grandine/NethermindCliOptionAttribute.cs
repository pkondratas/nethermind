using System;

namespace Nethermind.Grandine
{
    public class NethermindCliOptionAttribute : Attribute
    {
        public required string OptionName { get; set; }
        public bool IsFlag { get; set; }
    }
}