using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Pig_Latin
{
    public class Program
    {
        const string suff = "ay";
        static int Main(string[] args)
        {
            //problem
            //https://www.codewars.com/kata/520b9d2ad5c005041100000f/train/csharp
            return -1;
        }
        public static string PigIt(string str)
        {
          throw new NotImplementedException();
        //  return new string(get_word_and_swap(str).ToArray());
        }
        private static List<char> get_word_and_swap(string str)
        {
            List<char> char_list = new List<char>();
            int first = 0;
            int last = 0;
            for(int i = 0; i < str.Length; i++)
            {
                while(is_symbol(str[i]))
                {
                    char_list.Add(str[i]);
                    i++;
                    if(i == str.Length - 1) break;
                }
                char_list.Add(str[i]);
            }
            return char_list == null ? throw new NullReferenceException() : char_list; 
        }
        private static bool is_symbol(char c)
        {
            byte b = (byte)c;
            bool result = b >= 65 && b <= 90 ? true : b >= 97 && b <= 122;
            return result;
        }
    }
}
