using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EPiServerTrainingSite.Models.Blocks
{
    [ContentType(DisplayName = "HeroBlock", GUID = "0a2f6bc6-f161-4c60-8136-b511e7a0e05e", Description = "")]
    public class HeroBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Hero block",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Name { get; set; }

    }
}