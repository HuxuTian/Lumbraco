using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Lumbraco.EPiServer.Demo.Models.Pages;

namespace Lumbraco.EPiServer.Demo.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            DataFactory.Instance.PublishingContent += Instance_PublishingContent;
            return View(currentPage);
        }

        void Instance_PublishingContent(object sender, ContentEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}