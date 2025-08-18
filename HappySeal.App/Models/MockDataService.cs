using HappySeal.Shared.Domain;
using System.IO;
using System.Xml.Linq;

namespace HappySeal.App.Models
{
    public class MockDataService
    {
        private static Menu? _menu { get; set; }
        private static List<MenuItem> _menuItems { get; set; }
        private static List<Meal> _meals { get; set; }
        private static List<Cuisene> _cuisens { get; set; }
        private static List<Ingredient> _ingredients { get; set; }
        private static List<Recipe> _recipe { get; set; }
        
        public static Menu? Menu
        {
            get
            {
                _ingredients ??= InitializeMockIngredients();
                _recipe ??= InitializeMockRecipes();
                _cuisens ??= InitializeMockCuisenes();
                _meals ??= InitializeMockMeals();
                _menuItems ??= InitializeMockMenuItems();
                _menu ??= InitializeMockMenue();
                return _menu;
            }
        }

        public static Meal GetMealById(String meailId)
        {
            return _meals.Where(x => x.MealId == int.Parse(meailId)).FirstOrDefault(); 
        }


        private static Menu InitializeMockMenue()
        {
            Menu menu = new Menu
            {
                MenueId = 1,
                MenueItems = _menuItems
            };

            return menu;
        }

        private static List<MenuItem> InitializeMockMenuItems()
        {
            var menuItem1 = new MenuItem
            {
                MenuItemId = 1,
                MenuId = 1,
                Meal = _meals[0],
                DateLastUsed = DateTime.Now
            };

            var menuItem2 = new MenuItem
            {
                MenuItemId = 2,
                MenuId = 2,
                Meal = _meals[1],
                DateLastUsed = DateTime.Now
            };

            var menuItem3 = new MenuItem
            {
                MenuItemId = 3,
                MenuId = 3,
                Meal = _meals[2],
                DateLastUsed = DateTime.Now
            };
            return new List<MenuItem> { menuItem1, menuItem2, menuItem3 };
        }

        private static List<Meal> InitializeMockMeals()
        {
            var meal1 = new Meal
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
                Cuisene = _cuisens[0],
                Recipe = _recipe[0]
            };
            var meal2 = new Meal
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
                Cuisene = _cuisens[1],
                Recipe = _recipe[1]
            };
            var meal3 = new Meal
            {
                MealId = 3,
                Instructions = "1: Sprinkle beef with 1/2 tsp salt and pepper. 2: Heat 1 tbsp oil in a large heavy based pot over high heat. 3:Add 1/3 of the beef and brown aggressively all over, then remove. 4: Repeat with remaining beef, adding more oil if needed. 5: Turn stove down to medium high. 6: Add garlic and onion, cook 3 minutes. 7: Add flour, stir through. 8: Slowly add beef stock while stirring constantly. 9: Once flour is dissolved, add wine, tomato paste, Worcestershire, pepper and bay leaves. 10: Return beef into pot, cover with lid, adjust heat so it’s simmering gently. 11: Simmer 1 hr 45 minutes. Remove lid, increase heat slightly and simmer 30 – 45 minutes, stirring regularly, or until beef is fork tender and liquid reduces down to a thickish gravy, just about covering beef (see video). Do not reduce liquid too much – thickens more as it cools & in pie. 12: Remove from stove, cover and cool filling (I usually leave overnight).",
                Name = "Auzzy meat pies",
                CookingTime = 240,
                Spicyness = 0,
                Difficulty = 3,
                Discription = "Flaky ritch pie snacks with a deep meaty beef flavor",
                ImageSmall ="",
                Image ="",
                Cuisene = _cuisens[2],
                Recipe = _recipe[2]
            };

            return new List<Meal> { meal1, meal2, meal3 };
        }

        private static List<Cuisene> InitializeMockCuisenes()
        {
            var cuisene1 = new Cuisene
            {
                CuiseneId = 1,
                Name = "Korean"
            }; var cuisene2 = new Cuisene
            {
                CuiseneId = 1,
                Name = "irish"
            }; var cuisene3 = new Cuisene
            {
                CuiseneId = 1,
                Name = "australian"
            };

            return new List<Cuisene> { cuisene1, cuisene2, cuisene3 };
        }
        private static List<Ingredient> InitializeMockIngredients()
        {
            var Ingredient1 = new Ingredient
            {
                IngredientId = 1,
                Name = "Oil"
            };
            var Ingredient2 = new Ingredient
            {
                IngredientId = 2,
                Name = "Egg plant"
            };
            var Ingredient3 = new Ingredient
            {
                IngredientId = 3,
                Name = "Soy sause"
            };
            var Ingredient4= new Ingredient
            {
                IngredientId = 4,
                Name = "Rice wine vinegar"
            };
            var Ingredient5 = new Ingredient
            {
                IngredientId = 5,
                Name = "Mapel syrip"
            };
            var Ingredient6 = new Ingredient
            {
                IngredientId = 6,
                Name = "Garlic"
            }; 
            var Ingredient7 = new Ingredient
            {
                IngredientId = 7,
                Name = "Ginger"
            };
            var Ingredient8 = new Ingredient
            {
                IngredientId = 8,
                Name = "Gochujang"
            };
            var Ingredient9 = new Ingredient
            {
                IngredientId = 9,
                Name = "Bacon"
            };
            var Ingredient10 = new Ingredient
            {
                IngredientId = 10,
                Name = "Mushrooms"
            };
            var Ingredient11 = new Ingredient
            {
                IngredientId = 11,
                Name = "Peppers"
            };
            var Ingredient12 = new Ingredient
            {
                IngredientId = 12,
                Name = "Cream"
            };
            var Ingredient13 = new Ingredient
            {
                IngredientId = 13,
                Name = "Spaghetti"
            };
            var Ingredient14 = new Ingredient
            {
                IngredientId = 14,
                Name = "Soft crust pastory"
            };
            var Ingredient15 = new Ingredient
            {
                IngredientId = 15,
                Name = "BeefStock"
            };
            var Ingredient16 = new Ingredient
            {
                IngredientId = 16,
                Name = "Beef"
            };
            var Ingredient17 = new Ingredient
            {
                IngredientId = 17,
                Name = "Red wine"
            };

            return new List<Ingredient> { Ingredient1, Ingredient2, Ingredient3, Ingredient4, Ingredient5, Ingredient6, Ingredient7, Ingredient8, Ingredient9, 
                Ingredient10, Ingredient11, Ingredient12, Ingredient13, Ingredient14, Ingredient15, Ingredient16, Ingredient17 };
        }

        private static List<Recipe> InitializeMockRecipes()
        {
            var Recipe1 = new Recipe
            {
                RecipeId = 1,
                MealId = 1,
                Components = new List<Component>
                {
                    new Component{ComponentId = 1, RecipeId = 1, amount = 5, Measurement = "ml", Ingredient = _ingredients[0]},
                    new Component{ComponentId = 2, RecipeId = 1, amount = 2, Measurement = "small", Ingredient = _ingredients[1]},
                    new Component{ComponentId = 3, RecipeId = 1, amount = 2, Measurement = "tbsp", Ingredient = _ingredients[2]},
                    new Component{ComponentId = 4, RecipeId = 1, amount = 4, Measurement = "tbs", Ingredient = _ingredients[3]},
                    new Component{ComponentId = 5, RecipeId = 1, amount = 1, Measurement = "tbsp", Ingredient = _ingredients[4]},
                    new Component{ComponentId = 6, RecipeId = 1, amount = 1, Measurement = "small ", Ingredient = _ingredients[5]},
                    new Component{ComponentId = 7, RecipeId = 1, amount = 1, Measurement = "tbs", Ingredient = _ingredients[6]},
                    new Component{ComponentId = 8, RecipeId = 1, amount = 3, Measurement = "tsp", Ingredient = _ingredients[7]}
                }

            };

            var Recipe2 = new Recipe
            {
                RecipeId = 2,
                MealId = 2,
                Components = new List<Component>
                {
                    new Component{ComponentId = 9, RecipeId = 2, amount = 2, Measurement = "Packs", Ingredient = _ingredients[8]},
                    new Component{ComponentId = 10, RecipeId = 2, amount = 2, Measurement = "Packs", Ingredient = _ingredients[9]},
                    new Component{ComponentId = 11, RecipeId = 2, amount = 3, Measurement = "Medium", Ingredient = _ingredients[10]},
                    new Component{ComponentId = 12, RecipeId = 2, amount = 2, Measurement = "Cups", Ingredient = _ingredients[11]},
                    new Component{ComponentId = 13, RecipeId = 2, amount = 100, Measurement = "g", Ingredient = _ingredients[12]}

                }

            };

            var Recipe3 = new Recipe
            {
                RecipeId = 3,
                MealId = 3,
                Components = new List<Component>
                {
                    new Component{ComponentId = 14, RecipeId = 2, amount = 2, Measurement = "Sheets", Ingredient = _ingredients[13]},
                    new Component{ComponentId = 15, RecipeId = 2, amount = 2, Measurement = "Cups", Ingredient = _ingredients[14]},
                    new Component{ComponentId = 16, RecipeId = 2, amount = 1, Measurement = "Kg", Ingredient = _ingredients[15]},
                    new Component{ComponentId = 17, RecipeId = 2, amount = 1, Measurement = "Cup", Ingredient = _ingredients[16]}


                }
            };

            return new List<Recipe> { Recipe1, Recipe2, Recipe3 };

        }
    }
}
