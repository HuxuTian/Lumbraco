using Lucene.Net.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco
{
    public interface IIndexable { }

    public interface IIndexable<TObject> : IIndexable
    {
        Field GetField(TObject obj);
    }
}
