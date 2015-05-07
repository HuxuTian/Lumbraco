using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco
{
    public interface IComputedIndexField
    {

    }

    public interface IComputedIndexField<T> : IComputedIndexField
    {
        string ComputeFieldValue(T item);
    }
}
