using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;
using bichtram.Brands;

namespace bichtram.Brands.Dto
{
    [AutoMapTo(typeof(Brand))]
    public class UpdateBrandDto : EntityDto<int>
    {
        [Required]
        [StringLength(Brand.MaxNameLength)]
        public string Name { get; set; }

        [StringLength(Brand.MaxDescriptionLength)]
        public string Description { get; set; }
    }
}