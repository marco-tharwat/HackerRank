using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        StringBuilder binaryConversion = new StringBuilder();

while (n > 0)
{
    binaryConversion.Append(n % 2 == 0 ? "0" : "1");
    n /= 2;
}

char[] binaryArray = binaryConversion.ToString().ToCharArray();
Array.Reverse(binaryArray);
string binaryString = new string(binaryArray);

StringBuilder finalBinary = new StringBuilder();
for (int i = 0; i < 32 - binaryString.Length; i++)
{
    finalBinary.Append("0");
}

finalBinary.Append(binaryString);

for (int i = 0; i < finalBinary.Length; i++)
{
    finalBinary[i] = finalBinary[i] == '0' ? '1' : '0';
}

double result = 0;

for (int i = 0; i < finalBinary.Length; i++)
{
    if (finalBinary[i] == '1')
    {
        result += Math.Pow(2, 32 - i - 1);
    }
}

return (long)result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
