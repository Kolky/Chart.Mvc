namespace Chart.Mvc.Charts.Scales
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TimeUnit
    {
        [EnumMember(Value = "milisecond")]
        Milisecond,
        [EnumMember(Value = "second")]
        Second,
        [EnumMember(Value ="minute")]
        Minute,
        [EnumMember(Value = "hour")]
        Hour,
        [EnumMember(Value = "day")]
        Day,
        [EnumMember(Value = "week")]
        Week,
        [EnumMember(Value = "month")]
        Month,
        [EnumMember(Value = "quarter")]
        Quarter,
        [EnumMember(Value = "year")]
        Year
    }
}
