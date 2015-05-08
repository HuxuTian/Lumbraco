using EPiServer.Core;
using Lumbraco.Core.IndexConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lumbraco.Core.IndexService;

namespace Lumbraco.EPi
{
    public class FieldData : FieldBase
    {
        public FieldData(PropertyData propertyData)
        {
            FieldName = propertyData.Name;
            FieldType = propertyData.PropertyValueType;
        }
    }
}
