using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunck
{
    public class Functions<T> where T : IComparable<T>
    {


        //public static int FindLargest(List<int> listOfInt)
        //{
        //    int LargestNumber = listOfInt[0];
        //    foreach (int i in listOfInt)
        //    {
        //        if (LargestNumber < i)
        //            LargestNumber = i;
        //    }

        //    return LargestNumber;

        //}
        public static T FindLargest(List<T> list)
        {
            T Largest = list[0];
            foreach (T i in list)
            {
                if (Largest.CompareTo(i) < 0)
                    Largest = i;
            }

            return Largest;

        }

    }
}
