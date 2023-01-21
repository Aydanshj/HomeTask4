using System;
using System.Net.WebSockets;

namespace Hometask4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 2, -4, 5, -6, 7, 8 };
            var result1 = PositiveNumbers(nums);

            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
        }
        static int[] PositiveNumbers(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    counter++;

                }
  
            }
            int[] result = new int[counter];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    result[count] = arr[i];
                    count++;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            string[] words = { "Hello", "Hi", "How2", "Hell7", "Hel", "Low" };
            int[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Console.WriteLine(FindNum(words, arr));
        }
          static int FindNum(string[] words, int[] arr)
          {
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    for (int a = 0; a < arr.Length; a++)
                    {
                        if (words[i][j] == arr[a])
                        {
                            count++;
                        }
                    }
                }
            }
            if (count == 0)
            {
                return 0;
            }
            return count;
          }
        static void Main(string[] args)
        {
            string theWord = "";
            for(int n = 0; n < theWord.Length; n++)
            {
                if (theWord[n] != ' ')
                {
                    newWord = newWord + theWord[n];
                    break;
                }
            }
            return newWord;
        }
        static string NoSpaceInString(string word)
        {
            string updated = "";
            bool foundCharacter = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    foundCharacter = true;
                    updated += word[i];
                }
                if (word[i] == ' ' && foundCharacter == true)
                {
                    updated += word[i];
                }
            }
            return updated;

        }
    }
}
