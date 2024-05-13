using System;
using ASP.Net_Task.Data;
using ASP.Net_Task.Models;
using ASP.Net_Task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Task.Controllers
{
	public class HomeController:Controller
	{
		private readonly AppDbContext _context;

		public HomeController(AppDbContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> Index()
		{
			List<Slider> sliders = await _context.Sliders.ToListAsync();

			ViewBag.sliderImage = (await _context.SliderImages.FirstOrDefaultAsync()).Image;

			return View(sliders);
		}
	}
}

