namespace Chart.Mvc6.ComplexChart
{
    /// <summary>
    /// Legend options for Charts.
    /// </summary>
    public class LegendOptions
    {
        /// <summary>
        /// Gets or sets whether to display the legend.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Gets or sets the position of the legend; 'top', 'left', 'bottom', 'right'.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets whether to use the full width.
        /// </summary>
        public bool FullWidth { get; set; }

        /// <summary>
        /// Gets or sets whether to order the dataset in reverse.
        /// </summary>
        public bool Reverse { get; set; }
    }
}
