using Microsoft.AspNetCore.Mvc;
using ACMWeb.Models;
using ACM.BL.Interfaces;

namespace ACMWeb.Controllers
{
    public class ProductController : Controller
    {

        private IAcmRepository repository;

        public ProductController(IAcmRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View(repository.Products);
        }
    }
}
