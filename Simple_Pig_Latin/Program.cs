using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Pig_Latin
{
    //problem
    //https://www.codewars.com/kata/520b9d2ad5c005041100000f/train/csharp

    public class Program
    {
        const string suff = "ay";
        static int Main(string[] args)
        {
            string res = PigIt("hello workd !");
            return 0;
        }
        public static string PigIt(string str)
        {
            // throw new NotImplementedException();
            return new string(get_word_and_swap(str).ToArray());
        }
        private static List<char> get_word_and_swap(string str)
        {
            List<char> char_list = new List<char>();
            Queue<char> char_buff = new Queue<char>();
            for (int i = 0; i < str.Length; i++)
            {
                while (is_symbol(str[i]))
                {
                    char_buff.Enqueue(str[i]);
                    i++;
                    if (i == str.Length) break;
                }
                swap_last_and_first(char_buff, ref char_list);
                if (i == str.Length) break;
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
        private static void swap_last_and_first(Queue<char> coll, ref List<char> list)
        {
            if (coll.Count == 0) return;
            int queue_count = coll.Count;
            char buff = coll.Dequeue();
            for (int i = 0; i < queue_count - 1; i++)
                list.Add(coll.Dequeue());
            list.Add(buff);
            list.AddRange(suff);
        }
    }
}
