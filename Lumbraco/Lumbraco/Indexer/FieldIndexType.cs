using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Indexer
{
    public enum FieldIndexType
    {
        NO = 0,
        NOT_ANALYZED = 1,
        NOT_ANALYZED_NO_NORMS = 2,
        ANALYZED = 3,
        ANALYZED_NO_NORMS = 4
    }
}
