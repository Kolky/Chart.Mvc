using Chart.Mvc.Charts;

namespace Chart.Mvc6.TagHelpers
{
    public class LineChartTagHelper : ChartTagHelperBase<LineChartOptions, double> {}
    public class BarChartTagHelper : ChartTagHelperBase<BarChartOptions, double> { }
    public class RadarChartTagHelper : ChartTagHelperBase<RadarChartOptions, double> { }
    public class PolarChartTagHelper : ChartTagHelperBase<PolarAreaOptions, double> { }
    public class PieChartTagHelper : ChartTagHelperBase<PieChartOptions, double> { }
    public class DoughnutChartTagHelper : ChartTagHelperBase<DoughnutChartOptions, double> { }
    public class BubbleChartTagHelper : ChartTagHelperBase<BubbleChartOptions, BubbleChartData> { }
}
