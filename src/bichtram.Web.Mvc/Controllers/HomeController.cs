using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using bichtram.Controllers;

namespace bichtram.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : bichtramControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
