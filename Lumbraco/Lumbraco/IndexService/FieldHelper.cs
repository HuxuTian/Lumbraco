using Lucene.Net.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.IndexService
{
    public static class FieldHelper
    {
        public static Field GetField(Lumbraco.IndexConfig.IndexField field, string fieldValue)
        {
            var fieldName = field.FieldName;

            //var indexField = new Field(field.FieldName, fieldValue, field.StorageType, )
            return null;
        }

        public static Field.Index GetFieldIndexType(string indexType)
        {
            switch (indexType)
            {
                case "ANALYZED":
                    return Field.Index.ANALYZED;
                case "ANALYZED_NO_NORMS":
                    return Field.Index.ANALYZED_NO_NORMS;
                case "NOT_ANALYZED":
                    return Field.Index.NOT_ANALYZED;
                case "NOT_ANALYZED_NO_NORMS":
                    return Field.Index.NOT_ANALYZED_NO_NORMS;
                case "NO":
                    return Field.Index.NO;
                default:
                    return Field.Index.ANALYZED;
            }
        }

        public static Field.Store GetFieldStoreType(string storageType)
        {
            bool storeYes;
            var storeType = Field.Store.NO;
            if (bool.TryParse(storageType, out storeYes))
            {
                if (storeYes)
                {
                    return Field.Store.YES;
                }
            }
            return storeType;
        }

        public static string GetFieldValue<T>(string fieldType, T data)
        {
            var type = Type.GetType(fieldType);
            return null;
        }
    }
}
