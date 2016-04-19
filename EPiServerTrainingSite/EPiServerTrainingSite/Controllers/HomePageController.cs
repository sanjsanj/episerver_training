using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EPiServerTrainingSite.Models.Pages;

namespace EPiServerTrainingSite.Controllers
{
    public class HomePageController : PageController<HomePage>
    {
        public ActionResult Index(HomePage currentPage)
        {
            return View(currentPage);
        }
    }
}