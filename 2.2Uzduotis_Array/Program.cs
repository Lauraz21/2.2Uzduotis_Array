using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace _2._2Uzduotis_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            Console.WriteLine(GetFirstLetter(sentence));
        }
        public static char GetFirstLetter (string sentence)
        {
            char[] chars = sentence.ToCharArray();
            return chars[0];
        }
    } 
}


