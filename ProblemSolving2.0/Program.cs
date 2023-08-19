using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        // check for palindrome SARAS GARRAG POM
        // factorial 9! = 9 * 8 * 7 * 6 * 5 * 4 * 3 * 2 * 1
        // fepponanchy 1 1 2 3 5 8 13 21 34

        //string stringInput = "GARAG";
        //bool stringResult = IsPalindrome(stringInput);

        int factorialInput = 5;
        long factorialResult1 = GetFactorialRecursion(factorialInput);
        long factorialResult2 = GetFactorial(factorialInput);

        //int fepponanchyLength = 5;
        //long fepponanchyResult = GetFepponanchy(factorialInput);
    }

    //private static long GetFepponanchy(int factorialInput)
    //{

    //}

    private static long GetFactorialRecursion(int factorialInput)
    {
        if (factorialInput == 1)
            return 1;
        var result = GetFactorialRecursion(factorialInput - 1);
        return factorialInput * result;
    }

    private static long GetFactorial(int factorialInput)
    {
        long result = 1;

        while (factorialInput > 0)
        {
            result *= factorialInput;
            factorialInput -= 1;
        }
        return result;

        long Result = factorialInput;
        for (int i = factorialInput - 1; i > 0; i--)
        {
            Result = Result * i;
        }
        return Result;
    }

    //private static bool IsPalindrome(string input)
    //{
    //    // logic garag
    //    string reverse = "";
    //    for (int i = input.Length - 1; i >= 0; i--)
    //    {
    //        reverse = reverse + input[i];
    //    }
    //    return reverse == input;

    //    for (int i = 0; i < input.Length / 2; i++)
    //    {
    //        if (input[i] != input[input.Length - 1 - i])
    //            return false;
    //    }

    //    return true;
    //}
}