using EPiServer.Core;
using Lumbraco.IndexService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lumbraco.EPiServer.Demo.Models
{
    public class CustomField : IComputedIndexField<ContentData>, IIndexable<ContentData>
    {
        public string ComputeFieldValue(ContentData item)
        {
            return "CustomFieldTestValue";
        }

        public Lucene.Net.Documents.Field GetField(ContentData obj)
        {
            throw new NotImplementedException();
        }
    }
}