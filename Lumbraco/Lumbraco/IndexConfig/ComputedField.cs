using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Lumbraco.Core.IndexConfig
{
    public class ComputedField : BaseField
    {
        [XmlIgnoreAttribute]
        public string Value { get; set; }
    }
}
