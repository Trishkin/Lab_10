﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Lab_10.Models
{
    
    public class Computer : ISet<int>
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }

        public Computer(string name, string publisher, string developer)
        {
            Name = name;
            Publisher = publisher;
            Developer = developer;
        }

        public void Info()
        {
            Console.WriteLine($"Название: {Name} Издатель: {Publisher} Разработчик: {Developer}");
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public bool Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public void ExceptWith(IEnumerable<int> other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void IntersectWith(IEnumerable<int> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<int> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<int> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<int> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSupersetOf(IEnumerable<int> other)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(IEnumerable<int> other)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        public bool SetEquals(IEnumerable<int> other)
        {
            throw new NotImplementedException();
        }

        public void SymmetricExceptWith(IEnumerable<int> other)
        {
            throw new NotImplementedException();
        }

        public void UnionWith(IEnumerable<int> other)
        {
            throw new NotImplementedException();
        }

        void ICollection<int>.Add(int item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
