using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class DataPipeline<T>
    {
        private List<Func<IEnumerable<T>, IEnumerable<T>>> filters = new List<Func<IEnumerable<T>, IEnumerable<T>>>();
        private Func<T, object> transformation;

        public DataPipeline<T> AddFilter(Func<IEnumerable<T>, IEnumerable<T>> filter)
        {
            filters.Add(filter);
            return this;
        }

        public DataPipeline<T> SetTransformation(Func<T, object> transformation)
        {
            this.transformation = transformation;
            return this;
        }

        public IEnumerable<TResult> Process<TResult>(IEnumerable<T> input)
        {
            IEnumerable<T> filteredData = input;
            foreach (var filter in filters)
            {
                filteredData = filter(filteredData);
            }

            IEnumerable<TResult> transformedData;
            if (transformation != null)
            {
                transformedData = filteredData.Select(item => (TResult)transformation(item)).OfType<TResult>();
            }
            else
            {
                transformedData = filteredData.OfType<TResult>();
            }

            return transformedData;
        }
    }
}