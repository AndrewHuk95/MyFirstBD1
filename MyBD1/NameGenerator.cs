using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstBd1
{
    public static class NameGenerator
    {
        static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        const int MaxLengthName = 10;
        const int MinLengthName = 3;
        
        public static string CreateName()
        {
            Random random = new Random();
            int lengthName = random.Next(MinLengthName, MaxLengthName);
            string name = string.Empty;
            int alpCount = alphabet.Length;
            for (int i = 0; i < lengthName; i++)
            {
                Random value = new Random();
                name += alphabet[value.Next(0, alphabet.Length)];
                if (i == 0)
                {
                    name = name.ToUpper();
                }
                
            }
            return name;
        }



    }
}
