namespace Chart.Mvc.Charts
{
    using Chart.Mvc.Charts.Scales;
    using Chart.Mvc6.ComplexChart;

    /// <summary>
    /// The complex chart options.
    /// </summary>
    public abstract class ChartOptions : GlobalChartOptions
    {
        /// <summary>
        /// Gets or sets the legend template.
        /// </summary>
        public string LegendTemplate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the legend options.
        /// </summary>
        public LegendOptions Legend
        {
            get;
            set;
        }

        public ScalesType Scales { get; } = new ScalesType();
    }
}
