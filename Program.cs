using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main()
    {
        string data = File.ReadAllText(@"E:\data.txt ");
        Console.Write(data);
        int vowelCount = 0;
        int consonantCount = 0;
        int integerCount = 0;
        int specialCharacter = 0;
        //int i = 0;
        data.Replace("MARK", "SIGN");
        {
            Console.WriteLine(data);
        }

        string s1 = data.ToLower();
        foreach (char temp in s1)
        {
            if (temp == 'a' || temp == 'e' || temp == 'i' || temp == 'o' || temp == 'u')
                vowelCount++;
            else if (temp >= 'b' && temp <= 'z')
                consonantCount++;
            else if (temp >= '0' && temp <= '9')
                integerCount++;
            else
                specialCharacter++;
        }
        Console.WriteLine("Total number of vowel are : " + vowelCount);
        Console.WriteLine("Total number of consonant are : " + consonantCount);
        Console.WriteLine("Total numbers of integers are : " + integerCount);
        Console.WriteLine("Total numbers of special characters are : " + specialCharacter);

        //File.Copy(@"E:\data.txt", @"E:\data4.txt");

    }
}
