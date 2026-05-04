using Abp.Application.Services;
using Abp.Application.Services.Dto;
using bichtram.Brands.Dto;

namespace bichtram.Brands
{
    public interface IBrandAppService : IAsyncCrudAppService<BrandDto, int, PagedBrandResultRequestDto, CreateBrandDto, UpdateBrandDto>
    {
    }
}