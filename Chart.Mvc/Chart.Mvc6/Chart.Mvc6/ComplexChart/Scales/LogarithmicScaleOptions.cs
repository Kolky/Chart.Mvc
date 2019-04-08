namespace Chart.Mvc.Charts.Scales
{
    public class LogarithmicScaleOptions : ScaleOptions
    {
        public override string Type => "logarithmic";

        public override TickOptions Ticks => new LogarithmicTickOptions();
    }
}
