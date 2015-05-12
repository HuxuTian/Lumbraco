using Lucene.Net.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Core.IndexService
{
    public class FieldData<T>
    {
        public string FieldName { get; set; }

        public string PropertyName { get; set; }

        public string PropertyType { get; set; }

        public Field.Store StorageType { get; set; }

        public Field.Index IndexType { get; set; }

        public Field.TermVector TermVector { get; set; }

        public Field.Index GetFieldIndexType(string indexType)
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

        public Field.Store GetFieldStoreType(string storageType)
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

        public Field.TermVector GetTermVector(string termVector)
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
