using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApp.Models;

public class Ingredient
{
    public int ID   { get; init; }

    public string Name { get; init; }

    public string Instruction { get; init; }

    public Ingredient(int id,string name,string instruction)
    {
        ID = id;
        Name = name;
        Instruction = instruction;
    }
}
