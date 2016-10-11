namespace Chart.Mvc.Charts.Scales
{
    public abstract class ScaleOptions
    {
        public abstract string Type { get; }
        public bool? Display { get; set; }
        public string Position { get; set; }
        public string Id { get; set; }
    }
}
