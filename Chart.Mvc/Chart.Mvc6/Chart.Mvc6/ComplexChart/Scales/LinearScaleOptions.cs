namespace Chart.Mvc.Charts.Scales
{
    public class LinearScaleOptions : ScaleOptions
    {
        public override string Type => "linear";

        public override TickOptions Ticks => new LinearTickOptions();
    }
}
