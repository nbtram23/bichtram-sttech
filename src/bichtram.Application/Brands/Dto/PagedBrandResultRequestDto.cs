using Abp.Application.Services.Dto;

namespace bichtram.Brands.Dto
{
    public class PagedBrandResultRequestDto : PagedAndSortedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}