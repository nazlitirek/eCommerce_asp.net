using eCommerce.Data;
using eCommerce.Data.Services;
using eCommerce.Models;
using Microsoft.AspNetCore.Authorization;
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
			var data = await _service.GetAllAsync() ;
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
            await _service.AddAsync(actor);

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
        
        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }
        //Get: Actors/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureUrl,Bio")] Actor actor)
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
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

    }
}


