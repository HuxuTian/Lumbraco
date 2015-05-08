using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.IndexService
{
    public class TypeFieldIndexer<T> : IIndexable<T>
    {
        public Lucene.Net.Documents.Field GetField(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
