using System.ComponentModel.DataAnnotations;

namespace DongolOfLegends.API.Models.Models.Items
{
    public class ItemTags
    {
        [Key]
        public long Id { get; set; }
        public string Tag { get; set; }
    }
}