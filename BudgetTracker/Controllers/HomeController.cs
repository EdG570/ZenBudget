using System.Web.Mvc;

namespace BudgetTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}