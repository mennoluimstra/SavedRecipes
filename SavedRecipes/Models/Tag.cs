﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SavedRecipes.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}