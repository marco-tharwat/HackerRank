class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string period = s.Substring(s.Length - 2);
        int hours = int.Parse(s.Substring(0, 2)); 
        string rest = s.Substring(2, 6);          

        if (period == "AM")
        {
            if (hours == 12)
            {
                return "00" + rest;
            }
            return hours.ToString("D2") + rest;
        }
        else 
        {
            if (hours == 12)
            {
                return "12" + rest;
            }
            hours += 12;
            return hours.ToString("D2") + rest; 
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
