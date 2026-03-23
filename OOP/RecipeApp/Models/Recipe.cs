using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Models;

public class Recipe
{
    public List<Ingredient> Ingredients { get; } = new();
}

