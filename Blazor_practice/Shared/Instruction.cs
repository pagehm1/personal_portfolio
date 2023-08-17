using System.Text.Json;

namespace Hunter_Page.Shared
{
    public class Instruction
    {
        public string Bits { get; set; }

        public string[] AddressingModes { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Example { get; set; }

        public Instruction() 
        {
            Bits = string.Empty;
            AddressingModes = new string[0];
            Name = string.Empty;
            Description = string.Empty;
            Example = string.Empty;
        }

        public string PrintAddressingModes()
        {
            string modes = string.Empty;
            foreach (string argument in AddressingModes)
            {
                modes += argument + ",\t";
            }

            return modes;
        }
    }
}
