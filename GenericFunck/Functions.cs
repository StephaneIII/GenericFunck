using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunck
{
    public class Functions
    {


        public static int FindLargest(List<int> listOfInt)
        {
            int LargestNumber = listOfInt[0];
            foreach (int i in listOfInt)
            {
                if (LargestNumber < i)
                    LargestNumber = i;
            }

            return LargestNumber;

        }

    }
}
