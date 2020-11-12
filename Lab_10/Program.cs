using Lab_10.Collections;
using Lab_10.Models;
using System;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer MyComp1 = new Computer("Dimavm1","Asus","Asus");
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
    }
}
