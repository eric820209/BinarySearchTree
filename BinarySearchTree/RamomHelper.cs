using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    public  class RamomHelper
    {
        public static List<int> InitTestArray(int ArrayLenth, int Max)
        {
            var Arr = new int[ArrayLenth];
            var Random = new Random();
            List<int> randomList = Enumerable.Range(1, Max).OrderBy(x => Random.Next()).Take(ArrayLenth).ToList();
            return randomList;
        }
    }
}
