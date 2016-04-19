using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EPiServerTrainingSite.Models.Blocks
{
    [ContentType(DisplayName = "OtherBlock", GUID = "5bc4d25c-04d2-48db-9bdb-11b4cf7b9946", Description = "")]
    public class OtherBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Name { get; set; }

    }
}