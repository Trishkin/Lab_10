using Lab_10.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10.Collections
{
    public class ObservableCollection<T> where T : Computer
    {
        public delegate void CollectionChange(string message);
        public event CollectionChange Notify;

        List<T> collectionList = new List<T>();
        public void Add(T node)
        {
            collectionList.Add(node);
            Notify?.Invoke($"Добавлен новый элемент");
        }
        public void Remove(T node)
        {
            collectionList.Remove(node);
            Notify?.Invoke($"Удален элемент");
        }

        public void Info()
        {
            foreach (Computer item in collectionList)
            {
                item.Info();
            }
            Notify?.Invoke($"Произведён просмотр элементов");
        }
    }
}
