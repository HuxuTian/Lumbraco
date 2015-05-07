using Lucene.Net.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco
{
    public interface IIndexable
    {
        Field GetField<TObject>(TObject obj);
    }
}
