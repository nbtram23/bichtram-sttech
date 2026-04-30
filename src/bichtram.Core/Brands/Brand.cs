using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bichtram.Brands
{

    [Table("Brands")]
    public class Brand : FullAuditedEntity<int>
    {

        public const int MaxNameLength = 256;
        public const int MaxDescriptionLength = 2000;

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } 

        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; } 
    }
}