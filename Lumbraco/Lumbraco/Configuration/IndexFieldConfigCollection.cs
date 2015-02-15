using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Configuration
{
    [ConfigurationCollection(typeof(IndexFieldConfig), AddItemName = "IndexField")]
    public class IndexFieldConfigCollection : ConfigurationElementCollection, IEnumerable<IndexFieldConfig>
    {
        public IndexFieldConfig this[int index]
        {
            get
            {
                return base.BaseGet(index) as IndexFieldConfig;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new IndexFieldConfig();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((IndexFieldConfig)element).FieldName;
        }


        IEnumerator<IndexFieldConfig> IEnumerable<IndexFieldConfig>.GetEnumerator()
        {
            return Enumerable.Range(0, this.Count).Select(i => this[i]).GetEnumerator();
        }

    }
}
