using System;
using Microsoft.EntityFrameworkCore;

namespace FinalPrep.Models
{
	public class RecipesDbContext : DbContext
	{
		public RecipesDbContext(DbContextOptions<RecipesDbContext> options) : base(options)
		{

		}

		public DbSet<Recipe> Recipes { get; set; }

	}
}

