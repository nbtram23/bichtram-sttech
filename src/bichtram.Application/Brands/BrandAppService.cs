using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using bichtram.Brands.Dto;

using Abp.Authorization;
using bichtram.Authorization;

namespace bichtram.Brands
{
    [AbpAuthorize(PermissionNames.Pages_Brands)]
    public class BrandAppService : AsyncCrudAppService<Brand, BrandDto, int, PagedAndSortedResultRequestDto, CreateBrandDto, UpdateBrandDto>, IBrandAppService
    {
        public BrandAppService(IRepository<Brand, int> repository)
            : base(repository)
        {
        }
    }
}