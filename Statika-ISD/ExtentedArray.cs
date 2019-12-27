using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statika_ISD
{
    public enum SortWay { 
    asc, 
    desc
    }
    public static class ExtentedArray
    {

        public static void SortExtendedArray(this int[] arr, SortWay way)
        {
            Array.Sort(arr);
            if (way == SortWay.desc)
            {
                Array.Reverse(arr);
            }
        }

        public static void SortExtendedArray(this int[] arr, bool way)
        {
            arr.SortExtendedArray(way ? SortWay.asc : SortWay.desc);
        }
    }
}
