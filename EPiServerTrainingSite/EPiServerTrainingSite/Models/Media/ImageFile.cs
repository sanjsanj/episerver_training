using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EPiServerTrainingSite.Models.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "2b7c2d10-6064-4ea2-8eab-af02442badd4", Description = "")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,gif,png")]
    public class ImageFile : ImageData
    {
        
        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Image file",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Description { get; set; }

    }
}