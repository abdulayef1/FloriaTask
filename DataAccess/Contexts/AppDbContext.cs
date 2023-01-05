using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts;

public  class AppDbContext:DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}

	public DbSet<SliderBackround> SliderBackrounds { get; set; }
	public DbSet<SliderText> SliderTexts { get; set; }
}
