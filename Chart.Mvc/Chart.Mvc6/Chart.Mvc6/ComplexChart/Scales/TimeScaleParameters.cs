namespace Chart.Mvc.Charts.Scales
{
    using System;

    public class TimeScaleParameters
    {
        public TimeDisplayFormat DisplayFormats { get; set; }
        public bool? IsoWeekDay { get; set; }
        public DateTime? Max { get; set; }
        public DateTime? Min { get; set; }

        public TimeUnit? Round { get; set; }
        public string TooltipFormat { get; set; }

        public TimeUnit? Unit { get; set; }
        public int? UnitStepSize { get; set; }
        public string MinUnit { get; set; }
    }
}
