using System;
using System.Collections;

namespace Smart_Arrays
{
    public class SmartArray : IEnumerable
    {
        public int size;
        public int last = -1;
        public int[] array;

        public SmartArray(int size)
        {
            this.size = size;
            array = new int[size];
        }

        public int Length => last + 1;

        public void Add(int item)
        {
            if (last == (size - 1))
            {
                Array resized = Array.CreateInstance(typeof(int), size * 2);
                Array.Copy(array, resized, size);
                array = (int[])resized;
                size = array.Length;
            }
            array[++last] = item;
        }

        public void Remove(int item)
        {
            int index = Array.IndexOf(array, item, 0, last + 1);
            if (index == -1) return;

            for (int i = index; i < last; i++)
            {
                array[i] = array[i + 1];
            }
            array[last] = 0;
            last--;
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            return new SmartEnumerator(this);
        }

        private class SmartEnumerator : IEnumerator, IDisposable
        {
            private int index = -1;
            private SmartArray smarty;

            public SmartEnumerator(SmartArray smarty)
            {
                this.smarty = smarty;
            }

            public bool MoveNext()
            {
                index++;
                return index < smarty.Length;
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }

            public object Current => smarty.array[index];

            public void Dispose() { }
        }
    }
}
