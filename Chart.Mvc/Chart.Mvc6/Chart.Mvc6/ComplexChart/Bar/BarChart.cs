namespace Chart.Mvc.Charts
{
    /// <summary>
    /// The bar chart.
    /// </summary>
    public class BarChart : ChartBase<BarChartOptions, double>
    {
        private readonly BarChartOptions chartOptions = new BarChartOptions();

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public override ComplexChartType ChartType
        {
            get
            {
                return ComplexChartType.Bar;
            }
        }

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public override BarChartOptions ChartConfiguration
        {
            get
            {
                return chartOptions;
            }
        }
    }
}
