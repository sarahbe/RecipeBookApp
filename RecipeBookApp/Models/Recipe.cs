using System;
namespace RecipeBookApp.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
    }
}
