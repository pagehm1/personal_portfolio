namespace Hunter_Page.Shared
{
    internal class AddressMode
    {
        public string Name { get; set; }

        public string Bits { get; set; }

        public string Description { get; set; }

        public AddressMode() 
        { 
            Name = string.Empty;
            Bits = string.Empty;    
            Description = string.Empty;
        }
    }
}
