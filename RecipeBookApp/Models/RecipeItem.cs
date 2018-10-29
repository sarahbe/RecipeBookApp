using System;
namespace RecipeBookApp.Models
{
    public class RecipeItem
    {
        public int RecipeItemId { get; set; }
        public int RecipeId { get; set; }
        public string Item { get; set; }
        public decimal Quantity { get; set; }
        public Unit Unit {get; set;}

        public Recipe Recipe { get; set; }
    }
}
