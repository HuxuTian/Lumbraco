using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lumbraco.Core.IndexConfig
{
    public abstract class BaseField
    {
        [XmlAttribute("FieldName")]
        public virtual string FieldName { get; set; }

        [XmlAttribute("IndexType")]
        public virtual string IndexType { get; set; }

        [XmlAttribute("StorageType")]
        public virtual string StorageType { get; set; }

        [XmlAttribute("TermVector")]
        public virtual string TermVector { get; set; }

        [XmlAttribute("FieldType")]
        public virtual string FieldType { get; set; }

    }
}
