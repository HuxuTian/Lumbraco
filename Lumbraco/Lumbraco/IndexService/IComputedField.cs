using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Core.IndexService
{
    public interface IComputedIndexField<T>
    {
        string FieldName { get; set; }
        string FieldType { get; set; }
        object ComputeFieldValue(T item);
    }
}
