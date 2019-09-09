using Newtonsoft.Json;

namespace Chart.Mvc.Charts.Scales
{
    public class LogarithmicScaleOptions : ScaleOptions
    {
        public override string Type => "logarithmic";

        public override TickOptions Ticks { get; } = new LogarithmicTickOptions();

        [JsonIgnore]
        public LogarithmicTickOptions LogarithmicTicks => this.Ticks as LogarithmicTickOptions;
    }
}
