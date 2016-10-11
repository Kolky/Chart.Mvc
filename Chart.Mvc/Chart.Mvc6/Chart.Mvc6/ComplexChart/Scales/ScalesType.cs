namespace Chart.Mvc.Charts.Scales
{
    using System.Collections.Generic;

    public class ScalesType
    {
        public IList<ScaleOptions> xAxes { get; } = new List<ScaleOptions>();
        public IList<ScaleOptions> yAxes { get; } = new List<ScaleOptions>();
    }
}
