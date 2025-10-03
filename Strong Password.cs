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
     * Complete the 'minimumNumber' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING password
     */

    public static int minimumNumber(int n, string password)
    {
    // Return the minimum number of characters to make the password strong
    
        string numbers = "0123456789";
        string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string specialCharacters = "!@#$%^&*()-+";

        bool hasNumber = password.Any(c => numbers.Contains(c));
        bool hasLower = password.Any(c => lowerCase.Contains(c));
        bool hasUpper = password.Any(c => upperCase.Contains(c));
        bool hasSpecial = password.Any(c => specialCharacters.Contains(c));

        int missingTypes = 0;
        if (!hasNumber) missingTypes++;
        if (!hasLower) missingTypes++;
        if (!hasUpper) missingTypes++;
        if (!hasSpecial) missingTypes++;

        return Math.Max(missingTypes, 6 - n);
   
}

    }


class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
