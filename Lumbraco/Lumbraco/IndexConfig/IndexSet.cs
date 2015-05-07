using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Lumbraco.IndexConfig
{
    public class IndexSet
    {
        [XmlAttribute]
        public string DocumentType { get; set; }

        public IndexField[] IndexFields { get; set; }

    }
}
