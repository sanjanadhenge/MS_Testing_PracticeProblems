using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Test_Practice
{
    public class SwapCondition
    {
        public string CheckRearrangement(string str1, string str2)
        {
           List<char>list1= str1.ToList();
           list1.Sort();
           List<char> list2= str2.ToList();
           list2.Sort();

            string word1 = string.Join("", list1);
            string word2 = string.Join("", list2);
            if(word1.Equals(word2))
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
