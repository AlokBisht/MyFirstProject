using AspNetMvcHelloWorld.Models;
using System.Web.Mvc;

namespace AspNetMvcHelloWorld.Controllers
{
    public class MessageController : Controller
    {
        private readonly IRepository repo;

        public MessageController()
        {
            repo = new InMemoryRepository();
        }

        public MessageController(IRepository repo)
        {
            this.repo = repo;
        }

        public ActionResult Index()
        {
            var vm = repo.GetMessage();
            return View(vm);
        }
    }
}
