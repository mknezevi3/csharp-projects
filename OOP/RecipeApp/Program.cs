using RecipeApp.Data;
using RecipeApp.Models;

Console.WriteLine("Create a new cookie recipe! Available ingredients are:");

foreach(Ingredient ingredient in IngredientsCatalog.All)
{
    Console.WriteLine($"{ingredient.ID}.{ingredient.Name}");
}



Recipe recipe = new Recipe();

while (true)
{
    Console.WriteLine("Choose ingredients:");
    string input = Console.ReadLine();

    if(int.TryParse(input,out int number) && number >= 1 && number <= 8)
    {
        recipe.Ingredients.Add(IngredientsCatalog.All[number - 1]);
    }
    else
    {
        break;
    }

    

}

if (recipe.Ingredients.Count == 0)
{
    Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
}
else
{
    Console.WriteLine("Recipe added:");
    foreach (var ingredient in recipe.Ingredients)
    {
        Console.WriteLine(ingredient.Name + ingredient.Instruction);
    }
    string recipeLine = string.Join(",", recipe.Ingredients.Select(i => i.ID));

    File.AppendAllText("recipes.txt", recipeLine + Environment.NewLine);
}










Console.ReadKey();