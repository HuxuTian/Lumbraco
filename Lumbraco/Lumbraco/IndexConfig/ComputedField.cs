﻿using Lumbraco.IndexService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Lumbraco.IndexConfig
{
    public class ComputedField : ComputedFieldIndexer, IField
    {
        [XmlAttribute("FieldName")]
        public string FieldName { get; set; }

        [XmlAttribute("IndexType")]
        public string IndexType { get; set; }

        [XmlAttribute("StorageType")]
        public string StorageType { get; set; }

        [XmlAttribute("TermVector")]
        public string TermVector { get; set; }

        [XmlAttribute("FieldType")]
        public string FieldType { get; set; }

        [XmlIgnoreAttribute]
        public string Value { get; set; }
    }
}