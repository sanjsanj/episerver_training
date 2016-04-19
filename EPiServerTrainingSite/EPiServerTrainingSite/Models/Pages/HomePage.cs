using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace EPiServerTrainingSite.Models.Pages
{
    [ContentType(DisplayName = "HomePage", GUID = "2365453b-1b19-4b22-9215-f2c5a217ba07", Description = "")]
    [AvailableContentTypes(Availability.Specific, Include = new[] { typeof(LandingPage) })]
    public class HomePage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main image",
            Description = "The main image will be shown in the main content area of the page.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference MainImage { get; set; }

    }
}