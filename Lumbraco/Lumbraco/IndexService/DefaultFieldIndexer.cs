using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.IndexService
{
    public class DefaultFieldIndexer : IIndexable
    {
        public Lucene.Net.Documents.Field GetField<T>(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
