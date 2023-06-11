using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfChars_BITC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "absbgbffbogfadksoaitnfacfskfma";
            string symbols = "";
            int count = 0, maxCount = 0;
            char symbMaxCount = '0';
            for (int i = 0; i < s.Length; i++)
            {
                if (symbols.Contains(s[i]))
                    continue;
                count = 1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[j] == s[i])
                        count++;
                }
                symbols += s[i];
                Console.WriteLine($"{s[i]} : {count}");
                if (maxCount < count)
                {
                    symbMaxCount = s[i];
                    maxCount = count;
                }
            }
            Console.WriteLine("------Max Count------");
            Console.WriteLine($"{symbMaxCount} : {maxCount}");
        }
    }
}
