using System.Collections.Generic;
using System.Linq;

namespace First_non_repeating_character
{
    public static class Kata
    {
         public static string FirstNonRepeatingLetter(string s)
        {
            int capasity = s.Length;
            string res_str = s.ToLower();
            Dictionary<char, entity> dict = new Dictionary<char, entity>(capasity);
            for (int i = 0; i < capasity; i++)
            {
                bool succes_add = dict.TryAdd(res_str[i], new entity(res_str[i], 1, i));
                int cur_count = 0;
                int index = 0;
                if (!succes_add) { cur_count = dict[res_str[i]].count; index = dict[res_str[i]].index; dict[res_str[i]] = new entity(res_str[i], cur_count + 1, index); }
            }
            var res = dict.Where(e => e.Value.count == 1).ToList();
            return res == null || res.Count == 0 ? "" : s[res.Min(e => e.Value.index)].ToString();
        }
    }
}