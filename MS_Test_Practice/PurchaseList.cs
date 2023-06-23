using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Test_Practice
{
    public class PurchaseList
    {
       public int once = 0;
       public int SoldOnce(int [] arr)
        {
            List<int> list = new List<int>();
            int n = arr.Length;
            int j = 0, i = 0, k = 0, ctr = 0;

            int[] b = new int[arr.Length];

            Console.Write("\nThe unique elements found in the array are : \n");
            for (i = 0; i < n; i++)
            {
                ctr = 0;

                for (j = 0; j < i - 1; j++)
                {

                    if (arr[i] == arr[j])
                    {
                        ctr++;
                    }
                }

                for (k = i + 1; k < n; k++)
                {

                    if (arr[i] == arr[k])
                    {
                        ctr++;
                    }

                    if (arr[i] == arr[i + 1])
                    {
                        i++;
                    }
                }
                if (ctr == 0)
                {
                    list.Add(arr[i]);
                }
            }

            return list[0];
        }
        public int SoldMore(int[] arr)
        {
            if (arr[0]==once)
            {
                return arr[1];
            }
            else
            {
                return arr[0];
            }
        }
    }
}
