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
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        Dictionary<char, int> alphabet = new();
        for (int i = 'a'; i <= 'z'; i++)
        {
            alphabet[(char)i] = 0;
        }
        alphabet[' '] = 0;
        for (int i = 0; i < s.Length; i++)
        {
            alphabet[char.ToLower(s[i])]++;
        }
        foreach (var item in alphabet)
        {
            if (item.Value == 0 && item.Key != ' ')
            {
                return "not pangram";
            }
        }
        return "pangram";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
