using System;
namespace Scramblies
{
    public static class Scramblie
    {
        public static bool Scramble(string str1, string str2)
        {
            if(str1.Length < str2.Length) return false;
            if(String.IsNullOrWhiteSpace(str1) && String.IsNullOrWhiteSpace(str2)) return true;
            char[] res1 = str1.ToCharArray();
            char[] res2 = str2.ToCharArray();
            Array.Sort(res1);
            Array.Sort(res2);

            bool result = true;
            for(int i = 0;i < res2.Length; i++)
            {
                if(res2[i] != res1[i])
                {
                    int counter = i; 
                    while(counter < res1.Length )
                    {
                       result =  res2[i] == res1[counter];
                       while(i < res2.Length - 1 && res2[i] == res2[i + 1] && res2[i] == res1[i])
                       {
                           i++;
                       }
                       if(result) break;
                       counter++;  
                    }
                }
            }
            return result;
        }
    }
}
