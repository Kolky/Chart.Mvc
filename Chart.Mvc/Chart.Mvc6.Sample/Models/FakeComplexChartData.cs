﻿using System.Collections.Generic;
using Chart.Mvc.Charts;

namespace Chart.Mvc.Sample.Models
{
    public static class FakeComplexChartData
    {
        public static IEnumerable<string> Labels
        {
            get
            {
                return new[]
                {
                    "January", 
                    "February", 
                    "March", 
                    "April", 
                    "May", 
                    "June", 
                    "July"
                };
            }
        }

        public static IEnumerable<ComplexDataset<double>> Datasets
        {
            get
            {
                return new List<ComplexDataset<double>>
                {
                    new ComplexDataset<double>(new List<double> { 65, 59, 80, 81, 56, 55, 40 })
                    {
                        Label = "My First dataset",
                        BackgroundColor = "rgba(220,220,220,0.2)",
                        BorderColor = "rgba(220,220,220,1)",
                        PointBackgroundColor = "rgba(220,220,220,1)",
                        PointBorderColor = "#fff"
                    }, 
                    new ComplexDataset<double>(new List<double> { 28, 48, 40, 19, 86, 27, 90 })
                    {
                        Label = "My Second dataset",
                        BackgroundColor = "rgba(151,187,205,0.2)",
                        BorderColor = "rgba(151,187,205,1)",
                        PointBackgroundColor = "rgba(151,187,205,1)",
                        PointBorderColor = "#fff"
                    }
                };
            }
        }

        public static IEnumerable<ComplexDataset<BubbleChartData>> BubbleDatasets
        {
            get
            {
                return new List<ComplexDataset<BubbleChartData>>
                {
                    new ComplexDataset<BubbleChartData>(
                        new List<BubbleChartData>
                        {
                            new BubbleChartData { x = 1, y = 1, r = 5 },
                            new BubbleChartData { x = 1, y = 9, r = 5 },
                            new BubbleChartData { x = 5, y = 5, r = 5 },
                            new BubbleChartData { x = 9, y = 9, r = 5 },
                            new BubbleChartData { x = 9, y = 1, r = 5 }
                        })
                    {
                        Label = "My First dataset",
                        Fill = true,
                        BackgroundColor = "rgba(220,220,220,0.2)",
                        BorderColor = "rgba(220,220,220,1)",
                        PointBackgroundColor = "rgba(220,220,220,1)",
                        PointBorderColor = "#fff"
                    }
                };
            }
        }
    }
}
