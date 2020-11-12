using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10.Controller
{
    public static class ListController
    {
        public static void Info(List<object> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static object Find(List<object> collection, object item)
        {
            foreach (object item1 in collection)
            {
                if (item1.Equals(item))
                {
                    Console.WriteLine(item);
                    return item;
                }
            }
            return null;
        }
    }
}
