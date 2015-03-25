using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace Lumbraco.Index
{
    public static class Configuration
    {
        public static LumbracoIndexSet ReadConfiguration(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(LumbracoIndexSet));
            LumbracoIndexSet indexSet = new LumbracoIndexSet();
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    indexSet = (LumbracoIndexSet)serializer.Deserialize(fs);
                }               
            }
            return indexSet;
        }

        public static void WriteConfiguration(string path, object o)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(LumbracoIndexSet));
            using (StreamWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, o);
            }
        }
    }
}
