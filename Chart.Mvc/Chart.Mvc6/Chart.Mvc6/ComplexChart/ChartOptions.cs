namespace Chart.Mvc.Charts
{
    using Chart.Mvc.Charts.Scales;

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

        public ScalesType Scales { get; } = new ScalesType();
    }
}
