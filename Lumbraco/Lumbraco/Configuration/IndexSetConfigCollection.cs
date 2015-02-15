using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Configuration
{
    [ConfigurationCollection(typeof(IndexSetConfig), AddItemName = "IndexSet")]
    public class IndexSetConfigCollection : ConfigurationElementCollection, IEnumerable<IndexSetConfig>
    {
        public IndexSetConfig this[int index]
        {
            get
            {
                return base.BaseGet(index) as IndexSetConfig;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new IndexSetConfig();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((IndexSetConfig)element).DocumentType;
        }

        IEnumerator<IndexSetConfig> IEnumerable<IndexSetConfig>.GetEnumerator()
        {
            return Enumerable.Range(0, this.Count).Select(i => this[i]).GetEnumerator();
        }
    }
}
