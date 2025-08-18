using HappySeal.Shared.Domain;

namespace HappySeal.App.Models
{
    public class MockDataService
    {
        private static Menu? _menu { get; set; }
        private static List<MenuItem> _menuItems { get; set; }
        private static List<Meal> _meals { get; set; }
        

        public static Menu? Menu
        {
            get
            {
                _meals ??= InitializeMockMeals();
                _menuItems ??= InitializeMockMenuItems();
                _menu ??= InitializeMockMenue();

                return _menu;
            }
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
                ImageSmall ="",
                Image = ""
            };
            var meal2 = new Meal
            {
                MealId = 2,
                Instructions = "",
                Name = "Daddies spaghetti",
                CookingTime = 80,
                Spicyness = 1,
                Difficulty = 2,
                Discription = "Ritch creemy pastasause with bacon, mushrooms and peppers",
                ImageSmall = "",
                Image = ""
            };
            var meal3 = new Meal
            {
                MealId = 3,
                Instructions = "",
                Name = "Auzzy meat pies",
                CookingTime = 240,
                Spicyness = 0,
                Difficulty = 3,
                Discription = "Flaky ritch pie snacks with a deep meaty beef flavor",
                ImageSmall ="",
                Image =""
            };

            return new List<Meal> { meal1, meal2, meal3 };
        }

        //TODO add Cuisene's Recipes and ingredients
    }
}
