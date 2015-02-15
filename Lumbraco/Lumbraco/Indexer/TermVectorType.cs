using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Indexer
{
    public enum TermVectorType
    {
        YES = 0,
        WITH_POSITIONS = 1,
        WITH_OFFSETS = 2,
        WITH_POSITIONS_OFFETS = 3,
        NO = 4
    }
}
