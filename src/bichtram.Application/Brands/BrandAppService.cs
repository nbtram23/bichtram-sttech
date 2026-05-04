using System.Linq; 
using Abp.Linq.Extensions; 
using Abp.Application.Services;
using Abp.Domain.Repositories;
using bichtram.Brands.Dto;
using Abp.Authorization;
using bichtram.Authorization;

namespace bichtram.Brands
{
    [AbpAuthorize(PermissionNames.Pages_Brands)]
    public class BrandAppService : AsyncCrudAppService<Brand, BrandDto, int, PagedBrandResultRequestDto, CreateBrandDto, UpdateBrandDto>, IBrandAppService
    {
        public BrandAppService(IRepository<Brand, int> repository)
            : base(repository)
        {
        }

        protected override IQueryable<Brand> CreateFilteredQuery(PagedBrandResultRequestDto input)
        {
            return Repository.GetAll()
                .WhereIf(!string.IsNullOrWhiteSpace(input.Keyword),
                    x => x.Name.Contains(input.Keyword) || x.Description.Contains(input.Keyword));
        }
    }
}