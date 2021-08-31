using System;
using System.Collections.Generic;
using System.Text;

namespace StrukturaStos
{
    public class Stos<T> : IStos<T>
    {
        private List<T> list;
        public T Peek
        {
            get
            {
                if (list.Count == 0) throw new StosEmptyException();
                return list[list.Count - 1];
            }
        }
        public int Count
        {
            get => list.Count;
        }
        public bool IsEmpty
        {
            get
            {
                if (list.Count == 0) return true;
                else return false;
            }
        }
        public Stos()
        {
            list = new List<T>();
        }
        public void Push(T value)
        {
            list.Add(value);
        }
        public T Pop()
        {
            if (IsEmpty == true) throw new StosEmptyException();
            var lastElement = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return lastElement;
        }
        public void Clear()
        {
            list.RemoveRange(0, list.Count - 1);
        }
        public T[] ToArray()
        {
            return list.ToArray();
        }
    }
}
