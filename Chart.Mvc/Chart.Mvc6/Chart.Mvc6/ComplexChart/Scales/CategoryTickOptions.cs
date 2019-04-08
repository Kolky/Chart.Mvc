namespace Chart.Mvc.Charts.Scales
{
    using System.Collections.Generic;

    public class CategoryTickOptions : TickOptions
    {
        public IList<string> Labels { get; } = new List<string>();
        public string Min { get; set; }
        public string Max { get; set; }
    }
}
