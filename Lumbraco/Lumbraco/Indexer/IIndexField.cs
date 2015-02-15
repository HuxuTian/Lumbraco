using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Indexer
{
    /// <summary>
    /// Represent one field and index options
    /// </summary>
    public interface IIndexField
    {
        /// <summary>
        /// Field Name
        /// </summary>
        string FieldName { get; }

        /// <summary>
        /// Field Value
        /// </summary>
        string Value { get; }

        /// <summary>
        /// Field options for indexing
        /// </summary>
        FieldIndexType IndexType { get; }

        /// <summary>
        /// Whether store this field or not
        /// </summary>
        bool StorageType { get; }

        /// <summary>
        /// 
        /// </summary>
        TermVectorType TermVector { get; }

        float? Boost { get; }

        Type FieldType { get; }

        string SettingType { get; }
    }
}
