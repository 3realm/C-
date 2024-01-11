using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_work_07
{
    class Stringmanipulation
    {
        public static int NumberLetters(char[] s)
        {
            int k = 0;
            foreach (char el in s)
            {
                if (Char.IsLetter(el) == true)
                {
                    k++;
                }
            }
            return k;
        }

        public static double AverageLength(string s)
        {
            s = s.Trim(new char[] { ',', '.' });
            string[] WordMay = s.Split(new char[] { ' ' });
            return (double)Stringmanipulation.NumberLetters(s.ToCharArray()) / WordMay.Length;
        }

        public static string ChangeWord(string s, string given, string ret)
        {
            string result = "";
            s = s.ToLower();
            s = s.Trim(new char[] { ',', '.' });
            string[] WordMay = s.Split(new char[] { ' ' });

            for (int i = 0; i < WordMay.Length; i++)
            {
                if (string.Compare(given, WordMay[i]) == 0)
                {
                    WordMay[i] = ret;
                }
            }

            for (int i = 0; i < WordMay.Length; i++)
            {
                result += WordMay[i] + " ";
            }
            return result;
        }

        public static int CountWords(string s, string find)
        {
            int count = 0;
            s = s.ToLower();
            s = s.Trim(new char[] { ',', '.' });
            string[] WordMay = s.Split(new char[] { ' ' });
            for (int i = 0; i < WordMay.Length; i++)
            {
                for (int j = 0; j < WordMay[i].Length - find.Length + 1; j++)
                {
                    if (string.Compare(find, WordMay[i].Substring(j, find.Length)) == 0)
                        count++;
                }
            }
            return count;
        }

        public static string Polyndrom(string s)
        {
            string p = "";
            s = s.ToLower();

            s = s.Replace(".", ""); s = s.Replace(" ", ""); s = s.Replace(",", "");
            s = s.Replace("?", ""); s = s.Replace("!", ""); s = s.Replace("'", "");
            s = s.Replace("-", ""); s = s.Replace(")", ""); s = s.Replace("(", "");

            for (int i = 0; i < s.Length; i++)
            {
                p += s[s.Length - i - 1];
            }

            if (string.Compare(p, s) == 0)
                return "является полиндромом";
            else
                return "не является полиндромом";
        }
        public static string Date(string s)
        {
            bool count = true;
            string[] WordMay = s.Split(new char[] { '.' });

            if (WordMay.Length == 3)
            {
                if (Convert.ToInt32(WordMay[0]) < 1 || Convert.ToInt32(WordMay[0]) > 31)
                    count = false;
                else
                {
                    if (Convert.ToInt32(WordMay[1]) < 1 || Convert.ToInt32(WordMay[1]) > 12 || WordMay[1].Length != 2)
                        count = false;
                    else
                    {
                        if (Convert.ToInt32(WordMay[2]) < 1 || (WordMay[2].Length != 2 && WordMay[2].Length != 4))
                            count = false;
                        else
                            count = true;
                    }
                }
            }
            else
                count = false;

            if (count == true)
                return "является датой";
            else
                return "не является датой";
        }
    }
}
 