namespace Chart.Mvc.Charts.Scales
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class TimeScaleParameters
    {
        public TimeDisplayFormat DisplayFormats { get; set; }
        public bool? IsoWeekDay { get; set; }
        public DateTime? Max { get; set; }
        public DateTime? Min { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TimeUnit? Round { get; set; }
        public string TooltipFormat { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TimeUnit? Unit { get; set; }
        public int? UnitStepSize { get; set; }
        public string MinUnit { get; set; }
    }
}
