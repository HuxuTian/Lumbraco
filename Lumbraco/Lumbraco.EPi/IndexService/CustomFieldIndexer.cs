using EPiServer.Core;
using Lumbraco.Core.IndexConfig;
using Lumbraco.Core.IndexService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.IndexService
{
    public class CustomFieldIndexer : IIndexable<IField>
    {
        public Lucene.Net.Documents.Field GetField(IField item)
        {
            return null; //return new Lucene.Net.Documents.Field(item.Name, item.Value, item.StorageType, item.IndexType, item.TermVector);
        }
    }
}
