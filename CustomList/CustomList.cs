﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>/* where T : IComparable, IComparable<T>, IEquatable<T>*/
    {
        //member variables (HAS A)
        public T[] baseArray;
        private int capacity;
        private int count;
        public int Capacity
        {
            get
            {
                return capacity;
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
                if (index <= Count)
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
                if (index <= Count)
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
                baseArray = new T[Capacity + Capacity];
                capacity += capacity;
                for (int i = 0; i < swapCapacity; i++)
                {
                    baseArray[i] = swapArray[i];
                }
            }
            int j = Count;
            baseArray[j] = item;
            count++;
        }
        //public void Remove(T item)
        //{
        //    for (int i = 0; i < Count; i++)
        //    { 
        //        if (Equals(item, baseArray[i]))
        //        {
        //            for (int j = i; j < Count; j++)
        //            {
        //                baseArray[j] = baseArray[j + 1];
        //            }
        //            count--;
        //            break;
        //        }
        //    }
        //}
        public void Remove(T item)
        {
            for (int k = 0; k < Count; k++)
            {
                if (Equals(item, baseArray[k]))
                {
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
                            count--;
                        }
                        else
                        {
                            tempArray[j] = baseArray[i];
                            j++;
                        }
                    }
                    baseArray = tempArray;
                    break;
                }
            }
        }
        public override string ToString()
        {
            string newString = "";
            for(int i = 0; i < Count; i++)
            {
                newString += baseArray[i];
            }
            return newString;
        }

    }
}

