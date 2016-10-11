namespace Chart.Mvc.Charts.Scales
{
    using System;
    using System.Collections.Generic;

    public class TimeScaleOptions : ScaleOptions
    {
        public override string Type
        {
            get { return "time"; }
        }

        public TimeScaleParameters Time { get; } = new TimeScaleParameters();
    }
}
