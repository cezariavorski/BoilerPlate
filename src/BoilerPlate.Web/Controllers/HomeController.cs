using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace BoilerPlate.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BoilerPlateControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}