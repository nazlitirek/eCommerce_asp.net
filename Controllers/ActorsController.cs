using eCommerce.Data;
using eCommerce.Data.Services;
using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
	public class ActorsController : Controller
	{
		private readonly IActorsService _service;
		public ActorsController(IActorsService service)
		{
			_service = service;
		}
	
		public async Task<IActionResult> Index()
		{
			var data = await _service.GetAll() ;
			return View(data);
		}
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,Bio")] Actor actor)
        {
            if (string.IsNullOrEmpty(actor.FullName))
            {
                TempData["ErrorMessage"] = "Actor name is required.";
                return View(actor);
            }
            if (string.IsNullOrEmpty(actor.Bio))
            {
                TempData["ErrorMessage"] = "Bio is required.";
                return View(actor);
            }
            if (string.IsNullOrEmpty(actor.ProfilePictureUrl))
            {
                TempData["ErrorMessage"] = "Profile picture is required.";
                return View(actor);
            }
            _service.Add(actor);

            if (_service.isAdded(actor) == 0)
            {
                Console.WriteLine("Actor could not be added.");
            }
            else
            {
                Console.WriteLine("Actor added successfully.");
            }
            return RedirectToAction(nameof(Index));
            
        }
    }
}
