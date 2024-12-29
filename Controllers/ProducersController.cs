using eCommerce.Data;
using eCommerce.Data.Services;
using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Controllers
{
	public class ProducersController : Controller
	{
		private readonly IProducersService _service;
		public ProducersController(IProducersService service)
		{
			_service = service;
		}
		public async Task<IActionResult> Index()
		{
			var allProducers = await _service.GetAllAsync();
			return View(allProducers);
		}

        //Get: Producers/details/1
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);

            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

		//Get: Producers/create
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,Bio")] Producer producer)
		{

			if (string.IsNullOrEmpty(producer.FullName))
			{
				TempData["ErrorMessage"] = "Actor name is required.";
				return View(producer);
			}
			if (string.IsNullOrEmpty(producer.Bio))
			{
				TempData["ErrorMessage"] = "Bio is required.";
				return View(producer);
			}
			if (string.IsNullOrEmpty(producer.ProfilePictureUrl))
			{
				TempData["ErrorMessage"] = "Profile picture is required.";
				return View(producer);
			}
			await _service.AddAsync(producer);

			return RedirectToAction(nameof(Index));

		}

		//Get: Producers/create
		public async Task<IActionResult> Edit(int id)
		{
			var producersDetails= await _service.GetByIdAsync(id);
			if (producersDetails == null) return View("NotFound");
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, [Bind("Id, FullName,ProfilePictureUrl,Bio")] Producer producer)
		{

			if (string.IsNullOrEmpty(producer.FullName))
			{
				TempData["ErrorMessage"] = "Actor name is required.";
				return View(producer);
			}
			if (string.IsNullOrEmpty(producer.Bio))
			{
				TempData["ErrorMessage"] = "Bio is required.";
				return View(producer);
			}
			if (string.IsNullOrEmpty(producer.ProfilePictureUrl))
			{
				TempData["ErrorMessage"] = "Profile picture is required.";
				return View(producer);
			}

			if(id == producer.Id)
			{
				await _service.UpdateAsync(id, producer);

				return RedirectToAction(nameof(Index));
			}
			return View("producer");	

		}

		//Get: Actors/Delete
		public async Task<IActionResult> Delete(int id)
		{
			var producerDetails = await _service.GetByIdAsync(id);
			if (producerDetails == null) return View("NotFound");
			return View(producerDetails);
		}

		[HttpPost, ActionName("Delete")]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var producerDetails = await _service.GetByIdAsync(id);
			if (producerDetails == null) return View("NotFound");

			await _service.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}


	}
}
