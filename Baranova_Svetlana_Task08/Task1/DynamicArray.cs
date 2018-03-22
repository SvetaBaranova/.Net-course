using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DynamicArray<T>
    {
        public T[] arr;
        private int length;

        public DynamicArray()
        {
            arr = new T[8];
            length = 0;
        }

        public DynamicArray(int length)
        {
            arr = new T[length];
            length = 0;
        }

        public DynamicArray(T[] mas)
        {
            arr = mas;
            length = mas.Length;
        }

        public DynamicArray<T> Add(T element)
        {
            if (Length == Capacity)
            {
                DynamicArray<T> arrayNew = new DynamicArray<T>(Length * 2);
                arr.CopyTo(arrayNew.arr, 0);
                arrayNew.length += Length;
                arrayNew[arrayNew.Length] = element;
                length++;
                return arrayNew;
            }
            else
            {
                arr[Length] = element;
                length++;
                return this;
            }
        }

        public DynamicArray<T> AddRange(T[] element)
        {
            if (Length + element.Length > Capacity)
            {
                DynamicArray<T> arrayNew = new DynamicArray<T>(Length + element.Length);
                arr.CopyTo(arrayNew.arr, 0);
                arrayNew.length += Length;
                element.CopyTo(arrayNew.arr, arrayNew.Length);
                arrayNew.length += element.Length;
                return arrayNew;
            }
            else
            {
                arr = element;
                length += element.Length;
                return this;
            }
        }

        public bool Remove(int index)
        {
            if (index >= Length)
            {
                return false;
            }
            for (int i = index; i < Length; i++)
            {
                arr[i-1] = arr[i];
            }
            length--;
            arr[Length]=arr.ElementAtOrDefault(Capacity);
            return true;
        }

        public DynamicArray<T> Insert(T element, int index)
        {
            if (index > Length)
            {
                throw new ArgumentOutOfRangeException("Wrong index");
            }
            DynamicArray<T> arrayNew;
            if (Length == Capacity)
            {
                arrayNew = new DynamicArray<T>(Length * 2);
            }
            else
            {
                arrayNew = new DynamicArray<T>();
            }
            for (int i = 0; i < Length + 1; i++)
            {
                if (i == index)
                {
                    arrayNew[i] = element;
                }
                else if (i < index)
                {
                    arrayNew[i] = arr[i];
                }
                else
                {
                    arrayNew[i] = arr[i - 1];
                }
            }
            arrayNew.length = Length + 1;
            return arrayNew;
        }

        public int Length
        {
            get
            {
                return length;
            }
        }

        public int Capacity
        {
            get
            {
                return arr.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= Capacity)
                {
                    throw new ArgumentOutOfRangeException("Wrong index");
                }
                return arr[index];
            }
            set
            {
                if (index >= Capacity)
                {
                    throw new ArgumentOutOfRangeException("Wrong index");
                }
                if (index >= Length)
                {
                    length++;
                }
                arr[index] = value;
            }
        }
    }
}
