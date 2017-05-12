using SavedRecipes.Models;
using SavedRecipies.Data;
using SavedRecipies.Data.Implementation;
using System;

namespace SavedRecipes.Data
{
    public class UnitOfWork : IDisposable
    {
        private SavedRecipesContext context = new SavedRecipesContext();
        private IGenericRepository<Recipe> recipeRepository;

        public IGenericRepository<Recipe> RecipeRepository
        {
            get
            {

                if (this.recipeRepository == null)
                {
                    this.recipeRepository = new GenericRepository<Recipe>(context);
                }
                return recipeRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
