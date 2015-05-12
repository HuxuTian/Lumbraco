using Lucene.Net.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Core.IndexService
{
    public static class FieldHelper
    {
        public static Field GetField(Lumbraco.Core.IndexConfig.ComputedField field, string fieldValue)
        {
            var fieldName = field.FieldName;

            //var indexField = new Field(field.Name, fieldValue, field.StorageType, )
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

        public static Field.TermVector GetTermVector(string termVector)
        {
            switch (termVector)
            {
                case "NO":
                    return Field.TermVector.NO;
                case "YES":
                    return Field.TermVector.YES;
                case "WITH_POSITIONS":
                    return Field.TermVector.WITH_POSITIONS;
                case "WITH_OFFSETS":
                    return Field.TermVector.WITH_OFFSETS;
                case "WITH_POSITIONS_OFFSETS":
                    return Field.TermVector.WITH_POSITIONS_OFFSETS;
                default:
                    return Field.TermVector.NO;
            }
        }
    }
}
