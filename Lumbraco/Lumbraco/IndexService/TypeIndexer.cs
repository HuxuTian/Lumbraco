using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.IndexService
{
    public class TypeIndexer : IIndexable
    {
        public Lucene.Net.Documents.Field GetField<TObject>(TObject obj)
        {
            throw new NotImplementedException();
        }
    }
}
