using System;
using System.Collections.Generic;

namespace Task2
{
    class UserCollection<T>
    {
        private List<T> data = new List<T>();

        public T this[int Index]
        {
            get { return data[Index]; }
            set { data[Index] = value; }
        }

        public void FillList(params T[] items)
        {
            foreach (var datum in items)
            {
                data.Add(datum);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var datum in data)
            {
                yield return datum;
            }
        }
    }
}
