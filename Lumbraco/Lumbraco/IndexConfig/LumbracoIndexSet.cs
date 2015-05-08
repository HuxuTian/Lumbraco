using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lumbraco.Core.IndexConfig
{
    public class LumbracoIndexSet
    {
        public DefaultField DefaultField { get; set; }
        public ComputedField[] ComputedFields { get; set; }

        public TypeField[] TypeFields { get; set; }
        public CustomField[] CustomFields { get; set; }
    }
}
