using System.Collections.Generic;

namespace Chart.Mvc.Charts
{
    /// <summary>
    /// The complex dataset.
    /// </summary>
    public class ComplexDataset<TData>
    {
        public ComplexDataset()
        {
        }

        public ComplexDataset(IEnumerable<TData> data)
        {
            this.Data = new List<TData>(data);
        }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        public string Label
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the fill value.
        /// </summary>
        public bool Fill
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the fill color.
        /// </summary>
        public string BackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the stroke color.
        /// </summary>
        public string BorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the point color.
        /// </summary>
        public string PointBackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the point stroke color.
        /// </summary>
        public string PointBorderColor
        {
            get;
            set;
        }

        public string YAxisID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public IList<TData> Data { get; } = new List<TData>();
    }
}