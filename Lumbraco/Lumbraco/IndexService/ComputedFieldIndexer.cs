using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.IndexService
{
    public class ComputedFieldIndexer : IIndexable, IComputedIndexField
    {
        public Lucene.Net.Documents.Field GetField<T>(T obj)
        {
            throw new NotImplementedException();
        }

        public string ComputeFieldValue<T>(T item)
        {
            throw new NotImplementedException();
        }
    }
}
