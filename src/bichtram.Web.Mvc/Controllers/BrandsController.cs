using Microsoft.AspNetCore.Mvc;
using bichtram.Controllers;
using bichtram.Authorization;
using Abp.AspNetCore.Mvc.Authorization;
using bichtram.Brands;

namespace bichtram.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Brands)] 
    public class BrandsController : bichtramControllerBase
    {
        private readonly IBrandAppService _brandAppService;

        public BrandsController(IBrandAppService brandAppService)
        {
            _brandAppService = brandAppService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}