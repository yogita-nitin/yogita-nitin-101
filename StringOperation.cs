using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StringOperation
{
public class FormatString
{
public void stringFormat()
{ 

		Console.Writeline("Enter a string");
		string str = Console.ReadLine();
            string oldString = "";
            string newString = "";
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    oldString += c.ToString();
                }
            }
            for (int i = 0; i < oldString.Length; i++)
            {
                if (count == 3)
                {
                    i = i - 1;
                    newString += "-";
                    count = 0;
                }
                else
                {
                    newString += oldString[i];
                    count++;
                }
            }
Console.WriteLine(newString);
Console.ReadLine();
}
}
}