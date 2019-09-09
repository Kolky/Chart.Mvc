namespace Chart.Mvc.Charts.Scales
{
    public class CategoryScaleOptions : ScaleOptions
    {
        public override string Type => "category";

        public override TickOptions Ticks { get; } = new CategoryTickOptions();
    }
}
