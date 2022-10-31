using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_characters_in_given_string
{
    internal class Sorting_characters
    {
       static void Main(string[] args)
        {
             string inputs = "bdfcasx";
            Console.WriteLine(sortString(inputs));
        }
        //public static string test(string text)
        //{
        //    bool flag=string.IsNullOrEmpty(text);
        //    if (flag)
        //        return "String is Blank";

        //    var text_nums=text.Where(char.IsDigit).OrderBy(e1 => e1).ToList();
        //    var text_chars = text.Where(char.IsLetter)
        //        .Select(e1 => new { 1_char = char.ToLower(e1), _char => e1 })
        //        .OrderByDescending(e1 => e1._char)
        //        .ToList();

        //    return new string(text_chars.Select(e1 => e1._char).Concat(text_nums).ToArray());
        //}



        public static string sortString(string inputs)
        {
            char[] temp=inputs.ToCharArray();
            Array.Sort(temp);
            return new string(temp);
        }
    }
}
