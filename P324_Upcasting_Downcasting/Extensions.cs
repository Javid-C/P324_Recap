using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Upcasting_Downcasting
{
    static class Extensions
    {
        //public static bool customContains(this string word, string search)
        //{
        //    string text = string.Empty;
        //    for (int i = 0; i <= word.Length - search.Length; i++)
        //    {
        //        text = word.Substring(i, search.Length);
        //        if (text.ToLower() == search.ToLower())
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public static bool customContains(this string word, string search)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i <= word.Length - search.Length; i++)
            {
                for (int j = i; j < search.Length + i; j++)
                {
                    stringBuilder.Append(word[j]);
                }

                if(stringBuilder.ToString().ToLower() == search.ToLower())
                {
                    return true;
                }
                stringBuilder.Clear();
            }

            //Console.WriteLine(stringBuilder);
            return false;
        }
    }
}
