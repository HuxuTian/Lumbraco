using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lumbraco.Core.IndexConfig
{
    public class CustomField : BaseField
    {
        [XmlIgnoreAttribute]
        public string Value { get; set; }
    }
}
