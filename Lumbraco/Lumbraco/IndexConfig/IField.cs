using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.IndexConfig
{
    public interface IField
    {
        string FieldName { get; set; }
        string IndexType { get; set; }
        string StorageType { get; set; }
        string TermVector { get; set; }
        string Value { get; set; }
    }
}
