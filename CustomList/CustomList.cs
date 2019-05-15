using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
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
                return baseArray[index];
            }
            set
            {
                baseArray[index] = value;
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
                int swapCap = Capacity;
                T[] swapArray = baseArray;
                baseArray = new T[Capacity + Capacity];
                capacity += capacity;
                for (int i = 0; i < swapCap; i++)
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
        //    foreach (T arrayItem in baseArray)
        //    {
                
        //    }
        //}

    }
}

//I want the constructor to generate an array of 4 index values.
//I need to put item in an array at the zero value.
//I need to put item in an array at the first empty value.

    //If count > capacity, increase capacity.

    //I need to find the count, which is the number of actual items in the list. Do I 