using System.Collections.Generic;

namespace Chart.Mvc.Charts
{
    /// <summary>
    /// The complex data.
    /// </summary>
    public class ComplexData<TData>
    {
        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        public IList<string> Labels { get; } = new List<string>();

        /// <summary>
        /// Gets or sets the datasets.
        /// </summary>
        public IList<ComplexDataset<TData>> Datasets { get; } = new List<ComplexDataset<TData>>();
    }
}