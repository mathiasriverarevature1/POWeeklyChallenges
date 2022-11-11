internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Interview(new int [] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120));//q
        Console.WriteLine(Interview(new int [] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64));//q
        Console.WriteLine(Interview(new int [] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120));//d
        Console.WriteLine(Interview(new int [] { 5, 5, 10, 10, 15, 15, 20 }, 120));//d
        Console.WriteLine(Interview(new int [] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130));//d


    }

    static string Interview(int[] times, int totalTime)
    {
        string qualification = "qualified";
        if(times.Count()<8)//questions answered
        {
            qualification = "disqualified";
        }
        else if(totalTime>120)
        {
            qualification = "disqualified";
        }
        else if(times[0]>5 || times[1]>5)//very easy
        {
            qualification = "disqualified";
        }
        else if(times[2]>10 || times[3]>10)//easy
        {
            qualification = "disqualified";
        }
        else if(times[4]>15 || times[5]>15)//medium
        {
            qualification = "disqualified";
        }
        else if(times[6]>20 || times[7]>20)//hard
        {
            qualification = "disqualified";
        }

        return qualification;
    }
}