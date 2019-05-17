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
            if (Count == Capacity)
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
        public static CustomList<T> operator +(CustomList<T> baseList, CustomList<T> listToAdd)
        {
            CustomList<T> addedList = new CustomList<T>();
            for (int i = 0; i < baseList.Count; i++)
            {
                addedList.Add(baseList[i]);
            }
            for (int i = 0; i < listToAdd.Count; i++)
            {
                addedList.Add(listToAdd[i]);
            }
            return addedList;
        }
        public static CustomList<T> operator -(CustomList<T> baseList, CustomList<T> listToSubtract)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < baseList.count; i++)
            {
                newList.Add(baseList[i]);
            }
            for (int i = 0; i < listToSubtract.count; i++)
            {
                newList.Remove(listToSubtract[i]);
            }
            return newList;
        }
        public CustomList<T> Zip(CustomList<T> otherList)
        {
            return Zipper(this, otherList);
        }
        public static CustomList<T> Zipper(CustomList <T> mainList, CustomList<T> otherList)
        {
            CustomList<T> newList = new CustomList<T>();
            if (mainList.Count >= otherList.Count)
            {
                for (int i = 0; i < mainList.Count; i++)
                {
                    newList.Add(mainList.baseArray[i]);
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
                    if (i < mainList.Count)
                    {
                        newList.Add(mainList.baseArray[i]);
                    }
                    newList.Add(otherList[i]);
                }
            }
            return newList;
        }
        //public static void Zip(CustomList<T> mainList, CustomList<T> otherList)
        //{
        //    if (mainList.Count >= otherList.Count)
        //    {
        //        int i = 0;
        //        int j = i;
        //        for (; i < mainList.Count; i++)
        //        {
        //            if (i < otherList.Count)
        //            {
        //                T temp = mainList[i + 1];
        //                mainList[i + 1] = otherList[j];
        //                mainList
        //            }
        //            else
        //            {

        //            }
        //        }
        //    }
        //    else
        //    {
        //        for (int i = 0; i < otherList.Count; i++)
        //        {
        //            if (i < Count)
        //            {
        //                newList.Add(baseArray[i]);
        //            }
        //            newList.Add(otherList[i]);
        //        }
        //    }
        //    return newList;
        //}
        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < Count; index++)
            {
                yield return baseArray[index];
            }
        }
        public void Sort()
        {
            for (int i = 0; i < Count - 1; i++)
            {
                for (int j = 0; j < Count - 1; j++)
                {
                    if (Comparer<T>.Default.Compare(baseArray[j], baseArray[j + 1]) > 0)
                    {
                        T temp = baseArray[j];
                        baseArray[j] = baseArray[j + 1];
                        baseArray[j + 1] = temp;
                    }
                }
            }
        }
    }
}
//I want to zip two lists together.
//I want to take the first value of list2 and add it in after the first value of list one.
//This will shift all of list1 forward by one.
//The new list will be as long as the two lists combined.
//
