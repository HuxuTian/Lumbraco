using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Lumbraco.Configuration
{
    /// <summary>
    /// Map the attributes elements in the config file to this class
    /// Represents the <add/> element.
    /// </summary>
    public class IndexFieldConfig : ConfigurationElement
    {
        [ConfigurationProperty("FieldName", IsRequired = true)]
        public string FieldName { get { return this["FieldName"] as string; } }

        [ConfigurationProperty("IndexType", IsRequired = true)]
        public string IndexType { get { return this["IndexType"] as string; } }

        [ConfigurationProperty("StorageType", IsRequired = true)]
        public string StorageType { get { return this["StorageType"] as string; } }

        [ConfigurationProperty("TermVector", IsRequired = true)]
        public string TermVector { get { return this["TermVector"] as string; } }

        [ConfigurationProperty("Boost", IsRequired = false)]
        public string Boost { get { return this["Boost"] as string; } }

        [ConfigurationProperty("FieldType", IsRequired = true)]
        public string FieldType { get { return this["FieldType"] as string; } }

        [ConfigurationProperty("SettingType", IsRequired = false)]
        public string SettingType { get { return this["SettingType"] as string; } }

    }
}
