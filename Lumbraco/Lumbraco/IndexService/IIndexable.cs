using Lucene.Net.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Core.IndexService
{
    public interface IIndexable<T>
    {
        FieldData<T> FieldData { get; set; }
        Field GetField(T item);
        object GetValue(T item);
    }
}
