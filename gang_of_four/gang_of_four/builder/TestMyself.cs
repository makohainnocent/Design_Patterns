using System;

namespace gang_of_four.builder
{
    internal class TestMyself_builder
    {
        public static void cooking()
        {
            IRecipeBuilder recipeBuilder = new RecipeBuilder();
            Cook riceCooker = new Cook(recipeBuilder);

            // Construct a recipe
            riceCooker.PrepareRecipe();

            // Get the final recipe
            Recipe finalRecipe = recipeBuilder.GetRecipe();
            Console.WriteLine(finalRecipe);
        }
    }

    // Product
    public class Recipe
    {
        public string Title { get; set; }
        public int Servings { get; set; }
        public string Ingredients { get; set; }
        public string CookingTime { get; set; }
        public string Steps { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, Servings: {Servings}, Ingredients: {Ingredients}, CookingTime: {CookingTime}, Steps: {Steps}";
        }
    }

    // Abstract Builder
    public interface IRecipeBuilder
    {
        void BuildTitle(string title);
        void BuildServings(int servings);
        void BuildIngredients(string ingredients);
        void BuildCookingTime(string cookingTime);
        void BuildSteps(string steps);
        Recipe GetRecipe();
    }

    // Concrete Builder
    public class RecipeBuilder : IRecipeBuilder
    {
        private Recipe recipe = new Recipe();

        public void BuildTitle(string title)
        {
            recipe.Title = title;
        }

        public void BuildServings(int servings)
        {
            recipe.Servings = servings;
        }

        public void BuildIngredients(string ingredients)
        {
            recipe.Ingredients = ingredients;
        }

        public void BuildCookingTime(string cookingTime)
        {
            recipe.CookingTime = cookingTime;
        }

        public void BuildSteps(string steps)
        {
            recipe.Steps = steps;
        }

        public Recipe GetRecipe()
        {
            return recipe;
        }
    }

    // Director
    public class Cook
    {
        private IRecipeBuilder recipeBuilder;

        public Cook(IRecipeBuilder builder)
        {
            recipeBuilder = builder;
        }

        public void PrepareRecipe()
        {
            recipeBuilder.BuildTitle("Boiled Rice");
            recipeBuilder.BuildServings(1);
            recipeBuilder.BuildIngredients("Water, Seasoning, Onions, Curry Powder");
            recipeBuilder.BuildCookingTime("20 minutes");
            recipeBuilder.BuildSteps("Boil the water, fry the onions, add the boiled water, add the rice");
        }
    }
}
