using System;
using ASP.Net_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Task.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Slider> Sliders{ get; set; }
		public DbSet<SliderImage> SliderImages{ get; set; }

	}
}

