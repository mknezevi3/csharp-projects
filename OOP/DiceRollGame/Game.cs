using System;

namespace DiceRollGame;

class Game
{
    private Dice _dice = new Dice();

    private int _diceRolled;

    private int _userGuess;


    public void Start()
    {
        _diceRolled = _dice.Roll();
        Console.WriteLine("Dice rolled.Guess what number it shows in 3 tries.");
    }

    public void PlayerGuess()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            int.TryParse(input, out _userGuess);
            if (_userGuess != _diceRolled)
            {
                Console.WriteLine("Wrong number.");
            }
            else
            {
                Console.WriteLine("You win!");
                break;
            }
        }
    }
}
