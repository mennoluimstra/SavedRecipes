﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SavedRecipes.Models
{
    public class Step
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public string Description { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}