namespace Chart.Mvc.Charts.Scales
{
    public class TimeScaleOptions : ScaleOptions
    {
        public override string Type
        {
            get { return "time"; }
        }

        public string Distribution { get; set; }
        public string Bounds { get; set; }

        public TimeScaleParameters Time { get; } = new TimeScaleParameters();

        public override TickOptions Ticks => new TimeTickOptions();
    }
}
