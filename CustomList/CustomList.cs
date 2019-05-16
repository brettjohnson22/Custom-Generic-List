using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> //: IEnumerator<T>, IEnumerable<T>
    {
        //member variables (HAS A)
        public T[] baseArray;
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
            //stringbuilder
            string newString = "";
            for(int i = 0; i < Count; i++)
            {
                newString += baseArray[i];
            }
            return newString;
        }
        public static CustomList<T> operator+ (CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> addedList = new CustomList<T>();
            for(int i = 0; i < a.Count; i++)
            {
                addedList.Add(a[i]);
            }
            for(int i = 0; i < b.Count; i++)
            {
                addedList.Add(b[i]);
            }
            return addedList;
        }
        public static CustomList<T> operator- (CustomList<T>a, CustomList<T> b)
        {
            CustomList<T> newList = new CustomList<T>();
            for(int i = 0; i < a.count; i++)
            {
                newList.Add(a[i]);
            }
            for(int i = 0; i < b.count; i++)
            {
                newList.Remove(b[i]);
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

    }
}

