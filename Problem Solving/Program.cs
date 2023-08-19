class Result
{

    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int simpleArraySum(List<int> ar)
    {
        int sum = 0;
        for (int i = 0; i < ar.Count; i++)
        {
            sum += ar[i];
        }
        return sum;
    }


}

internal class Program
{

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> result = new List<int>(2) { 0, 0 };
        for (int x = 0; x < a.Count && x < b.Count; x++)
        {
            if (a[x] > b[x])
            {
                result[0]++;
            }
            else if (a[x] < b[x])
            {
                result[1]++;
            }
        }
        return result;
    }


private static void Main(string[] args)
{
    //if // else
    // switch
    // for
    // while
    // do while


    List<string> audiance = new List<string>() { "Nawar",/* "Amola", "nonos", "yasso" */};
    int y = 0;
    do
    {
        Console.WriteLine($"my name is {audiance[y]}");
        y++;
    }
    while (false);

    int[] arr = new int[10] { 1, 2, 5, 5, 4, 8, 8, 8, 9, 6 };

    int j = -1;
    while (j < arr.Length)
    {
        Console.WriteLine(arr[++j]);
    }




    int Count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            Count++;
        }
    }
    Console.WriteLine(Count);

    string[] weekdays = new string[7]
    {
            "sunday",
            "thursday",
            "tuesday",
            "monday",
            "wednesday",
            "saturday",
            "friday",
    };

    for (int i = 0; i < weekdays.Length; i++)
    {
        if (weekdays[i] == "wednesday")
            Console.WriteLine($"yes i am {i}");
    }

    string day = Console.ReadLine();

    switch (day)
    {
        case "sunday":
        case "monday":
        case "tuesday":
        case "wednesday":
        case "thursday":
            Console.WriteLine("this is a working day");
            break;
        case "friday":
        case "saturday":
            Console.WriteLine("this is a vacation");
            break;

        default:
            Console.WriteLine("da5al 7aga 3edla ya 7omar");
            break;
    }

    int[] integrers = new int[4] { 1, 2, 3, 4 };

    //integers[5] out of boundary error

    for (int i = 0; i < integrers.Length; i++)
    {
        int x = integrers[i];
        Console.WriteLine(x);
    }

}
}