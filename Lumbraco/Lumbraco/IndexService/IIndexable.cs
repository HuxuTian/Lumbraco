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
        Field GetField(T item);
    }
}
