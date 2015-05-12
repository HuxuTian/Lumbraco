using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lumbraco.Core.IndexService;
using EPiServer.Core;
using Lumbraco.Core.IndexConfig;
using Lumbraco.EPi;

namespace Lumbraco.IndexService
{
    public class ComputedField : IComputedIndexField<ContentData>
    {
        public string FieldName { get; set; }

        public string FieldType { get; set; }

        public object ComputeFieldValue(ContentData item)
        {
            throw new NotImplementedException();
        }
    }
}
