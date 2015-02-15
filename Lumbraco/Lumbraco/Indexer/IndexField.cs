using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Indexer
{
    public class IndexField : IIndexField
    {
        public string FieldName { get; set; }

        public string Value { get; set; }

        public FieldIndexType IndexType { get; set; }

        public bool StorageType { get; set; }

        public TermVectorType TermVector { get; set; }

        public float? Boost { get; set; }

        public Type FieldType { get; set; }

        public string SettingType { get; set; }

        public IndexField()
        {

        }
    }
}
