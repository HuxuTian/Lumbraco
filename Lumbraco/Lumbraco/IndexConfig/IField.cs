using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Core.IndexConfig
{
    public interface IField
    {
        string FieldName { get; set; }
        Type FieldType { get; set; }
    }
}
