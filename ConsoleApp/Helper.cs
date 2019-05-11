using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Helper
    {
        public static int[] ChangeArray(string contentArray)
        {
            string [] array = contentArray.TrimEnd(',').Trim().Split(',');
            int[] arrayResult = Array.ConvertAll(array, s => int.Parse(s));

            return arrayResult;
        }
    }
}
