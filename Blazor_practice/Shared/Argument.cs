namespace Blazor_practice.Shared
{
    public class Argument
    {
        public List<string> ArgumentLetters { get; set; }

        public string ArgumentWord { get; set; }

        public bool Required { get; set; }

        public string Description { get; set; }

        public string? DefaultValue { get; set; }


        public Argument(List<string> argumentLetters, string argumentWord, bool required, string description, string? defaultValue) 
        {
            ArgumentLetters = argumentLetters;
            ArgumentWord  = argumentWord;
            Required = required;
            Description = description;
            DefaultValue = defaultValue;
        }

        public string PrintArgumentLetters()
        {
            string letters = string.Empty;
            foreach(string argument in ArgumentLetters)
            {
                letters += argument+"\t";
            }

            return letters;
        }

    }
}
