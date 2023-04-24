using System;
using System.ComponentModel.DataAnnotations;

namespace FinalPrep.Models
{
	public class Recipe
	{
		[Key]
		[Required]
		public int RecipeID { get; set; }
		public string RecipeTitle { get; set; }
		public int RecipeClassID { get; set; }
		public string Preparation { get; set; }
        public string Notes { get; set; }
    }
}

