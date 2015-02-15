using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Configuration
{
    public class IndexSetConfig : ConfigurationElement
    {
        [ConfigurationProperty("DocumentType", IsRequired = false)]
        public string DocumentType
        {
            get
            {
                return this["DocumentType"] as string;
            }
        }

        [ConfigurationProperty("IndexFields", IsRequired = true)]
        public IndexFieldConfigCollection IndexFields
        {
            get
            {
                return (IndexFieldConfigCollection)this["IndexFields"] ?? new IndexFieldConfigCollection();
            }
        }
    }
}
