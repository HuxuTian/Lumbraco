using EPiServer.Core;
using Lumbraco.Core.IndexConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.EPi
{
    public class FieldBase : PropertyData, IField
    {
        public string FieldName { get; set; }
        public Type FieldType { get; set; }

        public override PropertyData ParseToObject(string value)
        {
            throw new NotImplementedException();
        }

        public override void ParseToSelf(string value)
        {
            throw new NotImplementedException();
        }

        public override Type PropertyValueType
        {
            get { throw new NotImplementedException(); }
        }

        protected override void SetDefaultValue()
        {
            throw new NotImplementedException();
        }

        public override PropertyDataType Type
        {
            get { throw new NotImplementedException(); }
        }

        public override object Value
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
