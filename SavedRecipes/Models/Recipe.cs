using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SavedRecipes.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int NumberOfPersons { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Step> Preparation { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public string Source { get; set; }
        public string ImagePath { get; set; }
    }
}