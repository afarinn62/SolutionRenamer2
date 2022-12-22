using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SolutionRenamer
{
    public static  class Extentions
    {

        public static string ReplaceIgnoreCaseSensetive(this string txt, string from, string to)
        {
            var regex = new Regex(from, RegexOptions.IgnoreCase);
            var newtxt = regex.Replace(txt, to);
            return newtxt;
        }
    }
}
