using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using bichtram.Brands;

namespace bichtram.Brands.Dto
{

    [AutoMapFrom(typeof(Brand))]
    public class BrandDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}