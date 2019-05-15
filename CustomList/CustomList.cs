using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>/* where T : IComparable, IComparable<T>, IEquatable<T>*/
    {
        //member variables (HAS A)
        public T[] baseArray = new T[4];
        private int capacity;
        private int count;
        public int Capacity
        {
            get
            {
                capacity = 0;
                foreach (T item in baseArray)
                {
                    capacity++;
                }
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
                if (index <= Count)
                {
                    return baseArray[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
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
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        //constructor (SPAWNER)
        public CustomList()
        {
            count = 0;
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
        public void Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            { 
                if (Equals(item, baseArray[i]))
                {
                    for (int j = i; j < Count; j++)
                    {
                        baseArray[j] = baseArray[j + 1];
                    }
                    count--;
                    break;
                }
            }
        }

    }
}

//I want the constructor to generate an array of 4 index values.
//I need to put item in an array at the zero value.
//I need to put item in an array at the first empty value.

    //If count > capacity, increase capacity.

    //I need to find the count, which is the number of actual items in the list. Do I 