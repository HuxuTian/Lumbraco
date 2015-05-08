using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lumbraco.Demo.Masterpages
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var path = System.Web.Hosting.HostingEnvironment.MapPath("~/Config/LumbracoIndex.config");
            //var if1 = new ComputedField() { Name = "productName", IndexType = "NOT_ANALYZED", StorageType = "YES", TermVector = "NO", FieldType = "System.String" };
            //var if2 = new ComputedField() { Name = "casName", IndexType = "NOT_ANALYZED", StorageType = "YES", TermVector = "NO", FieldType = "System.String" };
            //var is1 = new IndexSet() { DocumentType = "Product", IndexFields = new ComputedField[] { if1, if2 } };
            //var is2 = new IndexSet() { DocumentType = "Flower", IndexFields = new ComputedField[] { if1, if2 } };
            //var i1 = new LumbracoIndexSet() { IndexSets = new IndexSet[] { is1, is2 } };
            //IndexConfiguration.WriteConfiguration(path, i1);
            //var config = Configuration.ReadConfiguration(path);
        }
    }
}