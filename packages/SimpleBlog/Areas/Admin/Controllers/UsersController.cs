using SimpleBlog.Infrastructure;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("users")]
    public class UsersController: Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}