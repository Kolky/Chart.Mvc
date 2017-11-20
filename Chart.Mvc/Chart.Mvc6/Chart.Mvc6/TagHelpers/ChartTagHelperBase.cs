using Chart.Mvc.Charts;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Text;
using System.Threading.Tasks;
using Chart.Mvc.Extensions;

namespace Chart.Mvc6.TagHelpers
{
    public abstract class ChartTagHelperBase<TChartOptions, TChartData> : TagHelper 
        where TChartOptions : ChartOptions
    {
        public string Id { get; set; }
        public ChartBase<TChartOptions, TChartData> Chart { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var chartData = this.GetChartData();
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("<script type='text/javascript'>");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.AppendFormat("var ctx = document.getElementById(\"{0}\").getContext(\"2d\");", this.Id);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.AppendFormat("var data = JSON.parse('{0}');", chartData.Item1);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.AppendFormat("var options = JSON.parse('{0}');", chartData.Item2);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("var " + this.Id.Replace('-', '_') + "_chart = new Chart(ctx, { type: '" + chartData.Item3.ToCamelCase() + "', data: data, options: options });");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("</script>");

            output.TagName = "canvas";
            output.Attributes.Add("id", this.Id);
            output.Attributes.Add("width", this.Width);
            output.Attributes.Add("height", this.Height);

            output.PostElement.AppendHtml(stringBuilder.ToString());

            await Task.CompletedTask;
        }

        private Tuple<string, string, string> GetChartData()
        {
            string chartType = this.Chart.ChartType.ToString();
            string jsonData = this.Chart.ComplexData.ToJson();
            string jsonOptions = this.Chart.ChartConfiguration.ToJson();

            return new Tuple<string, string, string>(jsonData, jsonOptions, chartType);
        }
    }
}
