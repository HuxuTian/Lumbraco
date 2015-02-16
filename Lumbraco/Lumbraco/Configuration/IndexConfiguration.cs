using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Configuration
{
    public class IndexConfiguration : ConfigurationSection
    {
        private static string sectionName = "LumbracoIndexSet";
        private static string configFilePath = System.Web.HttpContext.Current.Server.MapPath("~/Config/LumbracoIndex.config");

        public static IndexConfiguration GetConfig()
        {
            var fileMap = new ConfigurationFileMap(configFilePath);
            var config = ConfigurationManager.OpenMappedMachineConfiguration(fileMap);
            //var config2 = config.GetSection(sectionName);
            return (IndexConfiguration)config.GetSection(sectionName) ?? new IndexConfiguration();
        }

        [ConfigurationProperty("IndexSets", IsRequired = true)]
        public IndexSetConfigCollection IndexSets
        {
            get
            {
                var set = this["IndexSets"];
                return (IndexSetConfigCollection)this["IndexSets"] ?? new IndexSetConfigCollection();
            }
        }
    }
}
