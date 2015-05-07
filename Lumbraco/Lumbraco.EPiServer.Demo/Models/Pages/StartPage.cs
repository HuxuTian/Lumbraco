using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using EPiServer;

namespace Lumbraco.EPiServer.Demo.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "e012d0a5-dd54-465a-a677-bb56fdb50379", Description = "")]
    public class StartPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Top News Promo Content",
            Description = "Top News Promo Content Area",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual ContentArea TopNewsContentArea { get; set; }

        [Editable(true)]
        [Display(
            Name = "Headline",
            Description = "A short headline for the article",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual string Headline { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Lead Image",
            Description = "Lead image that will be displayed in the article list and article detail page",
            GroupName = SystemTabNames.Content,
            Order = 250)]
        [UIHint(UIHint.Image)]
        public virtual Url LeadImage { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Show Summary In Article",
            Description = "Show the article summary in article view.",
            GroupName = SystemTabNames.Content,
            Order = 800)]
        public virtual bool ShowSummaryInArticle { get; set; }

        [Editable(true)]
        [Display(
            Name = "Utility Top Navigation",
            Description = "The top navigation items taht show up in all pages",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual LinkItemCollection UtilityNavigation { get; set; }
    }
}