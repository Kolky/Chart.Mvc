namespace Chart.Mvc.Charts
{
    public class BubbleChart : ChartBase<BubbleChartOptions, BubbleChartData>
    {
        private readonly BubbleChartOptions chartOptions = new BubbleChartOptions();

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override ComplexChartType ChartType
        {
            get
            {
                return ComplexChartType.Bubble;
            }
        }

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public override BubbleChartOptions ChartConfiguration
        {
            get
            {
                return chartOptions;
            }
        }
    }
}
