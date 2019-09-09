using Newtonsoft.Json;

namespace Chart.Mvc.Charts.Scales
{
    public class LinearScaleOptions : ScaleOptions
    {
        public override string Type => "linear";

        public override TickOptions Ticks { get; } = new LinearTickOptions();

        [JsonIgnore]
        public LinearTickOptions LinearTicks => this.Ticks as LinearTickOptions;
    }
}
