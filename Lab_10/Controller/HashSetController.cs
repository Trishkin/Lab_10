using Lab_10.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10.Controller
{
    public static class HashSetController
    {
        public static void Add(HashSet<object> collection, object node)
        {
            collection.Add(node);
        }

        public static void Info(HashSet<object> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static void RemoveAt(HashSet<object> collection, int count)
        {
            object[] toRemove = new object[64];
            int count1 = 0;
            foreach (var item in collection)
            {
                if (count1 < count)
                {
                    toRemove[count1] = item;
                }
                count1++;
            }
            for (int i = 0; i < count; i++)
            {
                collection.Remove(toRemove[i]);
            }
        }

        public static void CopyTo(HashSet<object> collection, List<object> listCollection)
        {
            foreach (var item in collection)
            {
                listCollection.Add(item);
            }
        }
    }
}
