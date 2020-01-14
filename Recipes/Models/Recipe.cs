using System;
namespace Recipes.Models
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Ingrident { get; set; }
        public string Direction { get; set; }
        public string Description { get; set; }
    }
}
