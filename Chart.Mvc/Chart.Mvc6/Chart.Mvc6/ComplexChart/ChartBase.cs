namespace Chart.Mvc.Charts
{
    /// <summary>
    /// The chart base.
    /// </summary>
    public abstract class ChartBase<TChartOptions, TChartData>
        where TChartOptions : ChartOptions
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public ComplexData<TChartData> ComplexData { get; } = new ComplexData<TChartData>();

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public abstract ComplexChartType ChartType
        {
            get;
        }

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public abstract TChartOptions ChartConfiguration
        {
            get;
        }
    }
}