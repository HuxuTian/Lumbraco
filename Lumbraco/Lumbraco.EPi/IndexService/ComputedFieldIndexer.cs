using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lumbraco.Core.IndexService;
using EPiServer.Core;
using Lumbraco.Core.IndexConfig;

namespace Lumbraco.IndexService
{
    public class ComputedFieldIndexer : IIndexable<IField>, IComputedIndexField<ContentData>
    {
        public Lucene.Net.Documents.Field GetField(IField item)
        {
            return null; ;// return new Lucene.Net.Documents.Field(item.Name, item.Value, item.StorageType, item.IndexType, item.TermVector);
        }

        public string ComputeFieldValue(ContentData item)
        {
            return string.Empty;
        }
    }
}
