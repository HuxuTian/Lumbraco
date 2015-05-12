using EPiServer.Core;
using Lucene.Net.Documents;
using Lumbraco.Core.IndexService;
using Lumbraco.IndexService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lumbraco.EPi.IndexService
{
    public class DateFieldIndexer : IIndexable<ContentData>
    {
        public FieldData<ContentData> FieldData { get; set; }

        public Lucene.Net.Documents.Field GetField(ContentData item)
        {
            var value = GetValue(item);
            return new Lucene.Net.Documents.Field(FieldData.FieldName, value.ToString(), FieldData.StorageType, FieldData.IndexType, FieldData.TermVector);
        }

        public object GetValue(ContentData item)
        {
            var prop = item.Property[FieldData.PropertyName];
            return prop.Value;
        }
    }

    public class ABC
    {
        public void build(ContentData data)
        {
            var doc = new Document();
            foreach (var prop in data.Property)
            {
                IIndexable<ContentData> indexer = IndexerFactory.GetIndexer(prop.Name, prop.Type.ToString());
                var field = indexer.GetField(data);
                doc.Add(field);
            }
            var computedFields = (List<IComputedIndexField<ContentData>>)HttpContext.Current.Application["ComputedFields"];
            foreach (IComputedIndexField<ContentData> cf in computedFields)
            {
                var value = cf.ComputeFieldValue(data);
                IIndexable<ContentData> indexer = IndexerFactory.GetIndexer(cf.FieldName, cf.FieldType);
                var field = indexer.GetField(data);
                doc.Add(field);
            }
        }
    }

    public static class IndexerFactory
    {
        public static IIndexable<ContentData> GetIndexer(string name, string type)
        {
            return null;
        }
    }
}
