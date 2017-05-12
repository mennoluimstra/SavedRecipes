namespace SavedRecipes.Migrations
{
    using SavedRecipes.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SavedRecipes.Models.SavedRecipesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SavedRecipes.Models.SavedRecipesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Recipes.AddOrUpdate(
                r => r.Id,
                    new Recipe { Description = "This is recipe 1!", Ingredients = new List<Ingredient> { new Ingredient { Description = "Wortel", Unit = Unit.pieces, Quantity = 1 } } }
                    );
        }
    }
}
