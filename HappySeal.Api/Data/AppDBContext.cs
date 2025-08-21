using HappySeal.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace HappySeal.Api.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Cuisene> Cuisenes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Menu> Menu { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            //Seed Menu
            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                MenuId = 1
            });
            //Seed Cuiesens
            modelBuilder.Entity<Cuisene>().HasData(new Cuisene
            {
                CuiseneId = 1,
                Name = "Korean"
            });
            modelBuilder.Entity<Cuisene>().HasData(new Cuisene
            {
                CuiseneId = 2,
                Name = "Irish"
            });
            modelBuilder.Entity<Cuisene>().HasData(new Cuisene
            {
                CuiseneId = 3,
                Name = "Australian"
            });


            ////Sead Ingredients
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 1,
                Name = "Oil"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 2,
                Name = "Egg plant"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 3,
                Name = "Soy sause"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 4,
                Name = "Rice wine vinegar"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 5,
                Name = "Mapel syrip"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 6,
                Name = "Garlic"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 7,
                Name = "Ginger"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 8,
                Name = "Gochujang"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 9,
                Name = "Bacon"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 10,
                Name = "Mushrooms"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 11,
                Name = "Peppers"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 12,
                Name = "Cream"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 13,
                Name = "Spaghetti"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 14,
                Name = "Soft crust pastory"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 15,
                Name = "BeefStock"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 16,
                Name = "Beef"
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient
            {
                IngredientId = 17,
                Name = "Red wine"
            });

            ////Seed Components
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 1, RecipeId = 1, amount = 5, Measurement = "ml", IngredientId = 1 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 2, RecipeId = 1, amount = 2, Measurement = "small", IngredientId = 2 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 3, RecipeId = 1, amount = 2, Measurement = "tbsp", IngredientId = 3 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 4, RecipeId = 1, amount = 4, Measurement = "tbs", IngredientId = 4 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 5, RecipeId = 1, amount = 1, Measurement = "tbsp", IngredientId = 5 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 6, RecipeId = 1, amount = 1, Measurement = "small ", IngredientId = 6 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 7, RecipeId = 1, amount = 1, Measurement = "tbs", IngredientId = 7 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 8, RecipeId = 1, amount = 3, Measurement = "tsp", IngredientId = 8 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 9, RecipeId = 2, amount = 2, Measurement = "Packs", IngredientId = 9 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 10, RecipeId = 2, amount = 2, Measurement = "Packs", IngredientId = 10 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 11, RecipeId = 2, amount = 3, Measurement = "Medium", IngredientId = 11 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 12, RecipeId = 2, amount = 2, Measurement = "Cups", IngredientId = 12 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 13, RecipeId = 2, amount = 100, Measurement = "g", IngredientId = 13 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 14, RecipeId = 2, amount = 2, Measurement = "Sheets", IngredientId = 14 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 15, RecipeId = 2, amount = 2, Measurement = "Cups", IngredientId = 15 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 16, RecipeId = 2, amount = 1, Measurement = "Kg", IngredientId = 16 });
            modelBuilder.Entity<Component>().HasData(new Component { ComponentId = 17, RecipeId = 2, amount = 1, Measurement = "Cup", IngredientId = 17 });

            ////Seed Recipes

            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                RecipeId = 1,
                MealId = 1,
                
            });
            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                RecipeId = 2,
                MealId = 2,
                
            });
            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                RecipeId = 3,
                MealId = 3,
                
            });

            //Seed Meals
            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 1,
                Instructions = "1: Cut eggplant into 2 ince triangles; 2: Fry/Steam till soft; 3: Make sause; 4: Fry all together",
                Name = "gochujang eggplant",
                CookingTime = 40,
                Spicyness = 2,
                Difficulty = 2,
                Discription = "Lightly spicy Korien chilly, soft eggplant side dish",
                ImageSmall = "",
                Image = "",
                CuiseneId = 1,
            });
            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 2,
                Instructions = "1: Make Daddies Spaghetti. 2: Eat Daddies spaghetti",
                Name = "Daddies spaghetti",
                CookingTime = 80,
                Spicyness = 1,
                Difficulty = 2,
                Discription = "Ritch creemy pastasause with bacon, mushrooms and peppers",
                ImageSmall = "",
                Image = "",
                CuiseneId = 2,
            });
            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 3,
                Instructions = "1: Sprinkle beef with 1/2 tsp salt and pepper. 2: Heat 1 tbsp oil in a large heavy based pot over high heat. 3:Add 1/3 of the beef and brown aggressively all over, then remove. 4: Repeat with remaining beef, adding more oil if needed. 5: Turn stove down to medium high. 6: Add garlic and onion, cook 3 minutes. 7: Add flour, stir through. 8: Slowly add beef stock while stirring constantly. 9: Once flour is dissolved, add wine, tomato paste, Worcestershire, pepper and bay leaves. 10: Return beef into pot, cover with lid, adjust heat so it’s simmering gently. 11: Simmer 1 hr 45 minutes. Remove lid, increase heat slightly and simmer 30 – 45 minutes, stirring regularly, or until beef is fork tender and liquid reduces down to a thickish gravy, just about covering beef (see video). Do not reduce liquid too much – thickens more as it cools & in pie. 12: Remove from stove, cover and cool filling (I usually leave overnight).",
                Name = "Auzzy meat pies",
                CookingTime = 240,
                Spicyness = 0,
                Difficulty = 3,
                Discription = "Flaky ritch pie snacks with a deep meaty beef flavor",
                ImageSmall = "",
                Image = "",
                CuiseneId = 3,
            });


            //Seed MenuItems
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = 1,
                MenuId = 1,
                MealId = 1,
                //DateLastUsed = DateTime.Now
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = 2,
                MenuId = 1,
                MealId = 2,
                //DateLastUsed = DateTime.Now
            });
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                MenuItemId = 3,
                MenuId = 1,
                MealId = 3,
                //DateLastUsed = DateTime.Now
            });
        }
    }
}
