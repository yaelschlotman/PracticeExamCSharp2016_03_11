using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExamCSharp2016_3_11
{
    public static class Tools
    {
        public static void InterateThroughList<T>(List<T> ListName)
        {
            foreach (T listItem in ListName)
            {
                Console.WriteLine(listItem);
            }
        }
    }
}
