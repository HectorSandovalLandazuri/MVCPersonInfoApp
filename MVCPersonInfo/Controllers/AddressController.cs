using Microsoft.AspNetCore.Mvc;
using MVCPersonInfo.Models;

namespace MVCPersonInfo.Controllers
{
    public class AddressController : Controller
    {

        private readonly ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }


        // GET: AddressController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddressController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressModel data)
        {
            if  (!ModelState.IsValid) {
                _logger.LogWarning("The user submitted invalid Address");
            }
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


    }
}
