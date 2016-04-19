using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EPiServerTrainingSite.Models.Pages
{
    [ContentType(DisplayName = "LandingPage", GUID = "1faca2fa-5456-46e4-b55a-12549949f4b4", Description = "")]
    public class LandingPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main content area",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual ContentArea MainContentArea { get; set; }

    }
}