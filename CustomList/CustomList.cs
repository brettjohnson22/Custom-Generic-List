using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable where T : IComparable
    {
        //member variables (HAS A)
        private T[] baseArray;
        private int capacity;
        private int count;
        //private int position = -1;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }

        }
        public int Count
        {
            get
            { 
                return count;
            }
         }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                {
                    return baseArray[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < Count)
                {
                    baseArray[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        //constructor (SPAWNER)
        public CustomList()
        {
            count = 0;
            capacity = 4;
            baseArray = new T[capacity];
        }
        //member methods (CAN DO)
        public void Add(T item)
        {
            if(Count == Capacity)
            {
                int swapCapacity = Capacity;
                T[] swapArray = baseArray;
                Capacity += Capacity;
                baseArray = new T[Capacity];
                for (int i = 0; i < swapCapacity; i++)
                {
                    baseArray[i] = swapArray[i];
                }
            }
            int j = Count;
            baseArray[j] = item;
            count++;
        }
        public bool Remove(T item)
        {
            bool removed = false;
            T[] tempArray = new T[Count];
            int i = 0;
            int j = i;
            for (; j < Count; i++)
            {
                if (!Equals(item, baseArray[i]))
                {
                    tempArray[j] = baseArray[i];
                    j++;
                }
                else if (i == j && Equals(item, baseArray[i]))
                {
                    removed = true;
                }
                else
                {
                    tempArray[j] = baseArray[i];
                    j++;
                }
            }
            if (removed)
            {
                count--;
                baseArray = tempArray;
            }
            return removed;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("[ ");
            for (int i = 0; i < Count; i++)
            {
                builder.Append(baseArray[i] + ", ");
            } 
            builder.Length--;
            builder.Length--;
            builder.Append(" ]");
            string newString = builder.ToString();
            return newString;
        }
        public static CustomList<T> operator+ (CustomList<T> baseList, CustomList<T> listToAdd)
        {
            CustomList<T> addedList = new CustomList<T>();
            for(int i = 0; i < baseList.Count; i++)
            {
                addedList.Add(baseList[i]);
            }
            for(int i = 0; i < listToAdd.Count; i++)
            {
                addedList.Add(listToAdd[i]);
            }
            return addedList;
        }
        public static CustomList<T> operator- (CustomList<T> baseList, CustomList<T> listToSubtract)
        {
            CustomList<T> newList = new CustomList<T>();
            for(int i = 0; i < baseList.count; i++)
            {
                newList.Add(baseList[i]);
            }
            for(int i = 0; i < listToSubtract.count; i++)
            {
                newList.Remove(listToSubtract[i]);
            }
            return newList;
        }
        public CustomList<T> Zip(CustomList<T> otherList)
        {
            CustomList<T> newList = new CustomList<T>();
            if (Count >= otherList.Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    newList.Add(baseArray[i]);
                    if (i < otherList.Count)
                    {
                        newList.Add(otherList[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < otherList.Count; i++)
                {
                    if (i < Count)
                    {
                        newList.Add(baseArray[i]);
                    }
                    newList.Add(otherList[i]);
                }
            }
            return newList;
        }
        public IEnumerator GetEnumerator()
        {
            for(int index = 0; index < Count; index++)
            {
                yield return baseArray[index];
            }
        }

    }
}

