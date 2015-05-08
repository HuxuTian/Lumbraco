using Lucene.Net.Documents;
using Lucene.Net.Index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.IndexService
{
    public class IndexService<T>
    {
        private static void addToIndex(T obj, IndexWriter writer)
        {
            var document = new Document();

            // Get available fields for the document

            writer.AddDocument(document);
        }
    }
}
