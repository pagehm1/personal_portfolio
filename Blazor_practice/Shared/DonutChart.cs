namespace Hunter_Page.Shared
{
    /// <summary>
    /// values needed for a mudblazor donut chart
    /// </summary>
    public class DonutChart
    {
        /// <summary>
        /// tracks index of donut chart
        /// </summary>
        public int ChartIndex { get; set; }

        /// <summary>
        /// data for the donut chart from github api
        /// </summary>
        public double[]? ChartData;
        public string[]? ChartLabels;

        public DonutChart()
        {
            ChartIndex = -1;
        }
    }
}
