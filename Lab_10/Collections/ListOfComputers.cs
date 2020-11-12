using Lab_10.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab_10.Collections
{
    public class ListOfComputers
    {
        List<Computer> myList = new List<Computer>();
        public void Add(Computer computer)
        {
             myList.Add(computer);
        }
        public void Remove(Computer computer)
        {
             myList.Remove(computer);
        }
        public Computer FindByName(string nameComputer)
        {
            if ((myList.Find(Computer => Computer.Name == nameComputer)) != null)
            {
                (myList.Find(Computer => Computer.Name == nameComputer)).Info();
                return myList.Find(Computer => Computer.Name == nameComputer);
            }
            else
            {
                Console.WriteLine($"Такого именени нет в списке");
                return null;
            }

        }
        public void Info()
        {
            foreach (Computer comp in myList)
            {
                comp.Info();
            }
        }
    }
}
