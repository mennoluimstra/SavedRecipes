using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SavedRecipes.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Unit Unit { get; set; }
        public string Description { get; set; }
    }
}