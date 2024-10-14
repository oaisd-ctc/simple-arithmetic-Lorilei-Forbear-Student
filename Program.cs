using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please provide a number.");
        string numOneString = Console.ReadLine();
        float numOne = float.Parse (numOneString);
        Console.WriteLine("Please provide another number to add to " + numOne + ".");
        string numTwoString = Console.ReadLine();
        float numTwo = float.Parse (numTwoString);
        float sum = (numOne + numTwo);
        Console.WriteLine("Your sum is " + sum + ".");
        //break
        Console.WriteLine("Please provide another number.");
        string numThreeString = Console.ReadLine();
        float numThree = float.Parse (numThreeString);
        Console.WriteLine("Please provide a number to subtract from " + numThree + ".");
        string numFourString = Console.ReadLine();
        float numFour = float.Parse (numFourString);
        float difference = (numThree - numFour);
        Console.WriteLine("Your difference is " + difference + ".");
        //break
        Console.WriteLine("Please provide another number.");
        string numFiveString = Console.ReadLine();
        float numFive = float.Parse (numFiveString);
        Console.WriteLine("Please provide a number to multiply " + numFive + " by.");
        string numSixString = Console.ReadLine();
        float numSix = float.Parse (numSixString);
        float product = (numFive * numSix);
        Console.WriteLine("Your product is " + product + ".");
        //break
        Console.WriteLine("Please provide another number.");
        string numSevenString = Console.ReadLine();
        int numSeven = int.Parse (numSevenString);
        Console.WriteLine("Please provide a number to divide " + numSeven + " by.");
        string numEightString = Console.ReadLine();
        int numEight = int.Parse (numEightString);
        int quotient = (numSeven / numEight);
        Console.WriteLine("Your quotient is " + quotient + ".");
    }
}