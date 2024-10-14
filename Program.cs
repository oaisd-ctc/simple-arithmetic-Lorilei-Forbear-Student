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
    }
}