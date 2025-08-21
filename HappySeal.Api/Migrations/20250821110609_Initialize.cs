using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HappySeal.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuisenes",
                columns: table => new
                {
                    CuiseneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuisenes", x => x.CuiseneId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuiseneId = table.Column<int>(type: "int", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CookingTime = table.Column<int>(type: "int", nullable: false),
                    Spicyness = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<int>(type: "int", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageSmall = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealId);
                    table.ForeignKey(
                        name: "FK_Meals_Cuisenes_CuiseneId",
                        column: x => x.CuiseneId,
                        principalTable: "Cuisenes",
                        principalColumn: "CuiseneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    MenuItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    DateLastUsed = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.MenuItemId);
                    table.ForeignKey(
                        name: "FK_MenuItems_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "MealId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItems_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipes_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "MealId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    ComponentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    Measurement = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_Components_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Components_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cuisenes",
                columns: new[] { "CuiseneId", "Name" },
                values: new object[,]
                {
                    { 1, "Korean" },
                    { 2, "Irish" },
                    { 3, "Australian" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Name" },
                values: new object[,]
                {
                    { 1, "Oil" },
                    { 2, "Egg plant" },
                    { 3, "Soy sause" },
                    { 4, "Rice wine vinegar" },
                    { 5, "Mapel syrip" },
                    { 6, "Garlic" },
                    { 7, "Ginger" },
                    { 8, "Gochujang" },
                    { 9, "Bacon" },
                    { 10, "Mushrooms" },
                    { 11, "Peppers" },
                    { 12, "Cream" },
                    { 13, "Spaghetti" },
                    { 14, "Soft crust pastory" },
                    { 15, "BeefStock" },
                    { 16, "Beef" },
                    { 17, "Red wine" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                column: "MenuId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealId", "CookingTime", "CuiseneId", "Difficulty", "Discription", "Image", "ImageSmall", "Instructions", "Name", "Spicyness" },
                values: new object[,]
                {
                    { 1, 40, 1, 2, "Lightly spicy Korien chilly, soft eggplant side dish", "", "", "1: Cut eggplant into 2 ince triangles; 2: Fry/Steam till soft; 3: Make sause; 4: Fry all together", "gochujang eggplant", 2 },
                    { 2, 80, 2, 2, "Ritch creemy pastasause with bacon, mushrooms and peppers", "", "", "1: Make Daddies Spaghetti. 2: Eat Daddies spaghetti", "Daddies spaghetti", 1 },
                    { 3, 240, 3, 3, "Flaky ritch pie snacks with a deep meaty beef flavor", "", "", "1: Sprinkle beef with 1/2 tsp salt and pepper. 2: Heat 1 tbsp oil in a large heavy based pot over high heat. 3:Add 1/3 of the beef and brown aggressively all over, then remove. 4: Repeat with remaining beef, adding more oil if needed. 5: Turn stove down to medium high. 6: Add garlic and onion, cook 3 minutes. 7: Add flour, stir through. 8: Slowly add beef stock while stirring constantly. 9: Once flour is dissolved, add wine, tomato paste, Worcestershire, pepper and bay leaves. 10: Return beef into pot, cover with lid, adjust heat so it’s simmering gently. 11: Simmer 1 hr 45 minutes. Remove lid, increase heat slightly and simmer 30 – 45 minutes, stirring regularly, or until beef is fork tender and liquid reduces down to a thickish gravy, just about covering beef (see video). Do not reduce liquid too much – thickens more as it cools & in pie. 12: Remove from stove, cover and cool filling (I usually leave overnight).", "Auzzy meat pies", 0 }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "DateLastUsed", "MealId", "MenuId" },
                values: new object[,]
                {
                    { 1, null, 1, 1 },
                    { 2, null, 2, 1 },
                    { 3, null, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "MealId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "ComponentId", "IngredientId", "Measurement", "RecipeId", "amount" },
                values: new object[,]
                {
                    { 1, 1, "ml", 1, 5 },
                    { 2, 2, "small", 1, 2 },
                    { 3, 3, "tbsp", 1, 2 },
                    { 4, 4, "tbs", 1, 4 },
                    { 5, 5, "tbsp", 1, 1 },
                    { 6, 6, "small ", 1, 1 },
                    { 7, 7, "tbs", 1, 1 },
                    { 8, 8, "tsp", 1, 3 },
                    { 9, 9, "Packs", 2, 2 },
                    { 10, 10, "Packs", 2, 2 },
                    { 11, 11, "Medium", 2, 3 },
                    { 12, 12, "Cups", 2, 2 },
                    { 13, 13, "g", 2, 100 },
                    { 14, 14, "Sheets", 2, 2 },
                    { 15, 15, "Cups", 2, 2 },
                    { 16, 16, "Kg", 2, 1 },
                    { 17, 17, "Cup", 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Components_IngredientId",
                table: "Components",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Components_RecipeId",
                table: "Components",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_CuiseneId",
                table: "Meals",
                column: "CuiseneId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_MealId",
                table: "MenuItems",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_MenuId",
                table: "MenuItems",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_MealId",
                table: "Recipes",
                column: "MealId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Cuisenes");
        }
    }
}
