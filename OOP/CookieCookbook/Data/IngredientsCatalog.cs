using CookieCookbook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookieCookbook.Data;


public static class IngredientsCatalog
{
    public static List<Ingredient> All { get; } =
    [
        new Ingredient(1, "Wheat flour.", "Sieve. Add to other ingredients."),
        new Ingredient(2, "Coconut flour.", "Sieve. Add to other ingredients."),
        new Ingredient(3, "Butter.", "Melt on low heat. Add to other ingredients."),
        new Ingredient(4, "Chocolate.", "Melt in a water bath. Add to other ingredients."),
        new Ingredient(5, "Sugar.", "Add to other ingredients."),
        new Ingredient(6, "Cardamom.", "Take half a teaspoon. Add to other ingredients."),
        new Ingredient(7, "Cinnamon.", "Take half a teaspoon. Add to other ingredients."),
        new Ingredient(8, "Cocoa powder.", "Add to other ingredients.")
    ];
}