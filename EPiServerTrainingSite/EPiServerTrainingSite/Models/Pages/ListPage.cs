using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EPiServerTrainingSite.Models.Pages
{
    [ContentType(DisplayName = "ListPage", GUID = "292f929c-5313-4599-aa12-5f335edd21b5", Description = "")]
    public class ListPage : PageData
    {
        [Required]
        [Range(0, 10, ErrorMessage = "Select a value between 0 and 10")]
        public virtual int NumberOfItems { get; set; }

        [Display(Name = "List root page")]
        public virtual ContentReference ListRootPage { get; set; }
    }
}