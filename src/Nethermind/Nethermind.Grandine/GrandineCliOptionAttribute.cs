using System;

namespace Nethermind.Grandine
{
    public class GrandineCliOptionAttribute : Attribute
    {
        public required string OptionName { get; set; }
    }
}