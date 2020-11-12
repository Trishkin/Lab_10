using Lab_10.Collections;
using Lab_10.Controller;
using Lab_10.Models;
using System;
using System.Collections.Generic;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1();
            //Part2();
            Part3();
        }

        static void Part1()
        {
            Computer MyComp1 = new Computer("Dimavm1", "Asus", "Asus");
            Computer MyComp2 = new Computer("Dimavm2", "Asis", "Asis");
            Computer MyComp3 = new Computer("Dimavm3", "As", "As");
            ListOfComputers MyList = new ListOfComputers();
            MyList.Add(MyComp1);
            MyList.Add(MyComp2);
            MyList.Add(MyComp3);
            MyList.Info();
            Console.WriteLine("__________________________________________________");
            MyList.Remove(MyComp2);
            MyList.Info();
            Console.WriteLine("__________________________________________________");
            MyList.FindByName("Dimavm3");
        }
        static void Part2()
        {
            HashSet<object> Collection = new HashSet<object>();

            HashSetController.Add(Collection, 11);
            HashSetController.Add(Collection, 'a');
            HashSetController.Add(Collection, 11.11);
            HashSetController.Add(Collection, "asdasd");

            HashSetController.Info(Collection);
            Console.WriteLine("__________________________________________________");
            HashSetController.RemoveAt(Collection, 3);
            HashSetController.Info(Collection);
            Console.WriteLine("__________________________________________________");
            HashSetController.Add(Collection, 78);
            HashSetController.Add(Collection, 24.44);
            HashSetController.Add(Collection, 'd');
            HashSetController.Info(Collection);

            Console.WriteLine("__________________________________________________");
            List<object> CollectionList = new List<object>();
            HashSetController.CopyTo(Collection, CollectionList);
            ListController.Info(CollectionList);
            Console.WriteLine("__________________________________________________");
            ListController.Find(CollectionList, 78);
        }

        static void Part3()
        {

            Computer MyComp1 = new Computer("Dimavm1", "Asus", "Asus");
            Computer MyComp2 = new Computer("Dimavm2", "Asis", "Asis");
            Computer MyComp3 = new Computer("Dimavm3", "As", "As");
            ObservableCollection<Computer> MyList = new ObservableCollection<Computer>();
            MyList.Notify += DisplayMessage;
            MyList.Add(MyComp1);
            MyList.Add(MyComp2);
            MyList.Add(MyComp3);
            MyList.Info();
            Console.WriteLine("__________________________________________________");
            MyList.Remove(MyComp2);
            MyList.Info();

            static void DisplayMessage(string message)
            {
                Console.WriteLine(message);
            }

        }
    }
}
