// Aaron Shumway | Section 3-3
// Description: defines a class that simulates rolling two dice a specified
// number of times and returns an array counting how often each possible total occurs.
namespace Mission2Dice;

public class DiceRoller
{
    public int[] RollDice(int numRolls)
    {
        int[] rollCounts = new int[13];
        Random rand = new Random();
        for (int i = 0; i < numRolls; i++)
        {
            int die1 = rand.Next(1, 7);
            int die2 = rand.Next(1, 7);
            int sum = die1 + die2;
            rollCounts[sum]++;
        }
        return rollCounts;
    }
}