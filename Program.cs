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
        Console.WriteLine("Please provide a number to divide " + numSeven + " by. There will be no decimals or remainders for this operation.");
        string numEightString = Console.ReadLine();
        int numEight = int.Parse (numEightString);
        int quotient = (numSeven / numEight);
        Console.WriteLine("Your quotient is " + quotient + ".");
        //break
        Console.WriteLine("Please provide another number.");
        string numNineString = Console.ReadLine();
        float numNine = float.Parse (numNineString);
        Console.WriteLine("Please provide a number to divide " + numNine + " by. This operation will output decimals.");
        string numTenString = Console.ReadLine();
        float numTen = float.Parse (numTenString);
        float decQuotient = (numNine / numTen);
        Console.WriteLine("Your quotient is " + decQuotient + ".");
        //break
        Console.WriteLine("Please provide another number.");
        string numElevenString = Console.ReadLine();
        float numEleven = float.Parse (numElevenString);
        Console.WriteLine("Please provide a number to divide " + numEleven + " by. This operation takes the remainder of the numbers.");
        string numTwelveString = Console.ReadLine();
        float numTwelve = float.Parse (numTwelveString);
        float remainder = (numEleven % numTwelve);
        Console.WriteLine("Your remainder is " + remainder + ".");
        Console.WriteLine("Finished program");
    }
}