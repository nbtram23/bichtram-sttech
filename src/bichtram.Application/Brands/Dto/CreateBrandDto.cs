using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;
using bichtram.Brands;

namespace bichtram.Brands.Dto
{

    [AutoMapTo(typeof(Brand))]
    public class CreateBrandDto
    {
        [Required]
        [StringLength(Brand.MaxNameLength)] // Tái sử dụng hằng số chuẩn từ Entity
        public string Name { get; set; }

        [StringLength(Brand.MaxDescriptionLength)]
        public string Description { get; set; }
    }
}