namespace Chart.Mvc.Charts.Scales
{
    public abstract class ScaleOptions
    {
        public abstract string Type { get; }
        public string Position { get; set; }
        public bool? Offset { get; set; }
        public string Id { get; set; }
        public abstract TickOptions Ticks { get; }
    }
}
