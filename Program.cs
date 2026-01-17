// See https://aka.ms/new-console-template for more information
// Aaron Shumway | Section 3-3
// Description: Simulate rolling dice and show how often each number is rolled
using Mission2Dice;

Console.WriteLine("Welcome to the dice rolling game.");

Console.WriteLine("How many times would you like to roll? ");

string input = Console.ReadLine();

int numRolls = int.Parse(input);

Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
Console.WriteLine("Each * represents 1% of the total number of rolls.\n");

Console.WriteLine($"Total number of rolls = {numRolls}");
Console.WriteLine();

DiceRoller roller = new DiceRoller();
int[] rollCounts = roller.RollDice(numRolls);

for (int i = 2; i <= 12; i++)
{
    double percentage = (double)rollCounts[i] / numRolls * 100;
    int stars = (int)Math.Round(percentage);
    string bar = new string('*', stars);
    Console.WriteLine($"{i}: {bar}");
}

Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");



