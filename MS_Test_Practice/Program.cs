using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Test_Practice
{
    public class Program
    {
       public static void Main(string[] args)
        {
           SwapCondition swapCondition = new SwapCondition();
           string result = swapCondition.CheckRearrangement("noon", "moon");
            Console.WriteLine(result);

        }
    }
}
