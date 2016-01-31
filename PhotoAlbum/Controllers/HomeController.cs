using System.Web.Mvc;

namespace PhotoAlbum.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        } 
    }
}