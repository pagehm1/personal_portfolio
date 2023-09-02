namespace Hunter_Page.Shared
{
    public class DonutChart_Git : DonutChart
    {
        /// <summary>
        /// holds github languages and stats
        /// </summary>
        public Dictionary<string, int> LanguageAmts { get; set; }

        /// <summary>
        /// total number of kilobytes from github repos
        /// </summary>
        public int Kilobytes { get; set; }

        /// <summary>
        /// language being highlighted
        /// </summary>
        public string SelectedLanguage { get; set; }

        public DonutChart_Git()
        {
            LanguageAmts = new Dictionary<string, int>();
            Kilobytes = 0;
            SelectedLanguage = "Total";
            ChartIndex = -1;
        }

        /// <summary>
        /// pulls dictionary values into individual arrays and sets the kilobyte size
        /// </summary>
        /// <param name="languageAmts">Dictionary to be parsed</param>
        public void GetDonutValues(Dictionary<string, int> languageAmts)
        {
            ChartData = Array.ConvertAll(languageAmts.Values.ToArray(), new System.Converter<int, double>(x => (double)x));
            ChartLabels = LanguageAmts.Keys.ToArray();
            ChartLabels = LanguageAmts.Keys.ToArray();
            SetKB();
        }

        /// <summary>
        /// converts the bytes gathered from github repos into kb
        /// </summary>
        public void SetKB()
        {
            if (ChartData is not null && ChartLabels is not null)
            {
                if(ChartIndex == -1)
                {
                    Kilobytes = Convert.ToInt32(ChartData.Sum()) / 1000;
                    return;
                }

                Kilobytes = Convert.ToInt32(ChartData[ChartIndex]) / 1000;
                SelectedLanguage = ChartLabels[ChartIndex];
            }

        }
    }
}
