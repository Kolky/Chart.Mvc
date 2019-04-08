namespace Chart.Mvc.Charts.Scales
{
    public class LinearTickOptions : TickOptions
    {
        public bool? BeginAtZero { get; set; }
        public double? Min { get; set; }
        public double? Max { get; set; }
        public double? MaxTicksLimit { get; set; }
        public double? Precision { get; set; }
        public double? StepSize { get; set; }
        public double? SuggestedMin { get; set; }
        public double? SuggestedMax { get; set; }
    }
}
