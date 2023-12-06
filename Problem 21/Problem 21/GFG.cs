using System;

namespace Problem_21
{
    //class GFG
    //{
    //    private static string[] powerSetReturn = new string[16]; 
    //    // str : Stores input string
    //    // curr : Stores current subset
    //    // index : Index in current subset, curr
    //    public static void powerSet(string str, int index, int indedTwo,
    //        string curr)
    //    {
    //        //string[] powerSetReturn = new string[Convert.ToInt32(Math.Pow(2,str.Length))];
    //        int n = str.Length;

    //        // base case
    //        if (index == n)
    //        {
    //            return powerSetReturn;
    //        }

    //        // First print current subset
    //        Console.WriteLine(curr);
    //        powerSetReturn.SetValue(curr, indedTwo);
    //        indedTwo++;

    //        // Try appending remaining characters
    //        // to current subset
    //        for (int i = index + 1; i < n; i++)
    //        {
    //            curr += str[i];
    //            powerSet(str, i, indedTwo, curr);

    //            // Once all subsets beginning with
    //            // initial "curr" are printed, remove
    //            // last character to consider a different
    //            // prefix of subsets.
    //            curr = curr.Substring(0, curr.Length - 1);
    //        }


    //    }
    //}
}