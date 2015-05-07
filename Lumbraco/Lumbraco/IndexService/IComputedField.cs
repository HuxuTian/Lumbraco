using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.IndexService
{
    public interface IComputedIndexField
    {

    }

    public interface IComputedIndexField<T> : IComputedIndexField, IIndexable
    {
        string ComputeFieldValue(T item);
    }
}
