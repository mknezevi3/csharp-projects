using System;

namespace DiceRollGame;

class Dice
{
    private int _number;

    private readonly Random _random = new Random();


    public int Roll() => return DiceRoll();


    private int DiceRoll() => return _number = _random.Next(1, 7);
    

}
