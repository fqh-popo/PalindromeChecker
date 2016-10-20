using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class Program
    {
        private static bool IsPalindrome2(string s)
        {
            //Null, empty or the string only has one character, is not a palindrome
            if (s == null || s.Length < 2)
            {
                return false;
            }
            //Change all capital letters to lowercase
            string str = s.ToLower();
            
            //Remove all the space, punctuation, and word dividers
            string[] separator = { " ", ",", ".", "?", "!",";", ":", 
                                 "(", ")", "\'", "\"", "’", "‘", "”", "“", 
                                 "-", "_", "—" };

            foreach (var a in separator)
            {
                str = str.Replace(a, "");
            }

            //Recheck empty or only has one character after clean
            if (str.Length < 2)
            {
                return false;
            }

            //Get the reverse string
            var temp1 = str.ToCharArray();
            Array.Reverse(temp1);
            string reversedString = new string(temp1);

            return str == reversedString;
        }


        private static bool IsPalindrome(string s)
        {
            //Null, empty or the string only has one character, is not a palindrome
            if (s == null || s.Length < 2)
            {
                return false;
            }

            //Change all capital letters to lowercase
            string str = s.ToLower();

            //Remove all the space, punctuation, and word dividers
            char[] separator = { ' ', ',', '.', '?', '!',';', ':', 
                                 '(', ')', '\'', '\"', '’', '‘', '”', '“', 
                                 '-', '_', '—' };
            string[] str1 = str.Split(separator);
            str = "";

            for (var i = 0; i < str1.Length; i++)
            {
                str += str1[i];
            }

            //Recheck empty or only has one character after remove the space, punctuation, and word dividers
            if (str.Length < 2)
            {
                return false;
            }

            //Check characters of the treated str from forward with backward
            int mid = str.Length / 2;
            for (var i = 0; i < mid; i++)
            {
                if (str.Substring(i, 1) != str.Substring((str.Length - 1 - i), 1))
                {
                    return false;
                }
            }
            return true;
        }

        static void Check(string s, bool shouldBePalindrome)
        {
            Console.WriteLine(IsPalindrome2(s) == shouldBePalindrome ? "pass" : "FAIL");
        }

        static void Main()
        {
            Check("abcba", true);
            Check("abcde", false);
            Check("Mr owl ate my metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);
            Check("Never, Odd Or Even!", true);
            Check("A man, a plan, a canal, Panama!", true);
            Check("Amor, \"Roma\"", true);
            Check("step on 'no' pets ", true);
            Check("Was it a (car) or a cat I saw?", true);
            Check("Are we not pure? \"No sir!\" Panama's moody Noriega brags. \"It is garbage!\" Irony dooms a man; a prisoner up to new era.", true);
            Check("I’m a pup, am I?", true);
            Console.ReadLine();
        }
    }
}
