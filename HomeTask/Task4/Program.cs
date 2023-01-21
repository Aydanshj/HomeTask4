using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace Hometask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1: Verilmiş string dəyərindəki ilk sözü tapan metod.
            string first = "Tiffany & Co case study is hard to analyse";
            var result = FirstWord(first);
            Console.WriteLine(result);
            #endregion
        }
        static string FirstWord(string first)
        {
            string newString = "";
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != ' ')
                {
                    newString = newString + first[i];
                }
                if (first[i] == ' ')
                {
                    newString = newString + " ";
                    break;

                }
                return newString;

            }
        }
        #region Task2 Verilmiş string dəyərindəki sözlərin sayını tapan metod.
        Console.Writeline("Enter the word");
        string str = Console.ReadLine();
        int count = 1;
        Console.Writeline(FindNumber (str, count));

       #endregion

            static int FindNumber(string str, int count)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }

       
    }
   
}

        


   
