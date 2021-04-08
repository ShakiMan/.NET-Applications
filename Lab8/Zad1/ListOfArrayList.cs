using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

//Radosław Ścigała, 246997

namespace Zad1
{
    class ListOfArrayList<T> : IEnumerable<T>, IList<T>
    {

        private List<T[]> listOfArrays;
        private int arraySize;
        int firstBlankIndex;


        public ListOfArrayList(int size)
        {
            arraySize = size;

            listOfArrays = new List<T[]>();
            listOfArrays.Add(new T[size]);

            firstBlankIndex = 0;
        }

        //Zadanie 2

        public static ListOfArrayList<T> operator +(ListOfArrayList<T> arraysList, IEnumerable<T> collection)
        {
            ListOfArrayList<T> newListOfArrayList = new ListOfArrayList<T>(arraysList.arraySize);

            for (int i = 0; i < arraysList.Count; i++)
            {
                newListOfArrayList.Add(arraysList[i]);
            }

            IEnumerator<T> enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                newListOfArrayList.Add(enumerator.Current);
            }

            return newListOfArrayList;
        }


        // IList<T> implementation:

        public T this[int index]
        {
            get
            {
                if (index < firstBlankIndex)
                {
                    return listOfArrays[getArrayIndex(index)][index % arraySize];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index < firstBlankIndex)
                {
                    listOfArrays[getArrayIndex(index)][index % arraySize] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public int Count => firstBlankIndex;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            int currentIndex = firstBlankIndex;
            bool added = false;

            foreach (T[] table in listOfArrays)
            {
                if (currentIndex < table.Length)
                {
                    table[currentIndex] = item;
                    firstBlankIndex += 1;
                    added = true;
                }
                else
                {
                    currentIndex -= table.Length;
                }
            }

            if (!added)
            {
                listOfArrays.Add(new T[arraySize]);
                listOfArrays[listOfArrays.Count - 1][0] = item;
                firstBlankIndex += 1;
            }
        }

        public void Clear()
        {
            listOfArrays.Clear();
            firstBlankIndex = 0;
        }

        public bool Contains(T item)
        {
            foreach (T[] table in listOfArrays)
            {
                foreach (T elem in table)
                {
                    if (elem != null)
                    {
                        if (elem.Equals(item) == true) 
                            return true;
                    }
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            int itemIndex = 0;
            foreach (T[] table in listOfArrays)
            {
                foreach (T elem in table)
                {
                    if (elem != null && elem.Equals(item) == true) 
                        return itemIndex;
                    else 
                        itemIndex += 1;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            if (this.Contains(item))
            {
                int currentIndex = this.IndexOf(item);
                this.RemoveAt(currentIndex);
                return true;
            }
            else return false;
        }

        public void RemoveAt(int index)
        {
            int arrayIndex = getArrayIndex(index);
            int currentIndex = index;
            if (arrayIndex != -1 && currentIndex < firstBlankIndex)
            {
                for (int i = arrayIndex; i < listOfArrays.Count; i++)
                {
                    for (int j = currentIndex % arraySize; j < listOfArrays[i].Length; j++)
                    {
                        currentIndex = currentIndex % arraySize;
                        if (currentIndex + 1 < listOfArrays[i].Length) listOfArrays[i][currentIndex] = listOfArrays[i][currentIndex + 1];
                        else if (i + 1 < listOfArrays.Count) listOfArrays[i][currentIndex] = listOfArrays[i + 1][0];

                        currentIndex += 1;
                    }
                    arrayIndex += 1;
                }
                listOfArrays[arrayIndex - 1][currentIndex - 1] = default;
                firstBlankIndex -= 1;
            }
        }

        //IEnumerator implementation: 

        public IEnumerator<T> Enumerator => throw new NotImplementedException();

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Enumerator;
        }

        //Rest of methods:

        public void Trim()
        {
            int index = 0;
            bool foundLastFilledTable = false;
            for (int i = 0; i < listOfArrays.Count; i++)
            {
                if (!foundLastFilledTable)
                {
                    for (int j = 0; j < listOfArrays[i].Length; j++)
                    {
                        if (index == (firstBlankIndex - 1))
                        {
                            foundLastFilledTable = true;
                            break;
                        }
                        index++;
                    }
                }
                else
                {
                    listOfArrays.RemoveAt(i);
                }
            }

        }

        private int getArrayIndex(int index)
        {
            int currentIndex = 0;
            int arrayIndex = 0;
            foreach (T[] table in listOfArrays)
            {
                foreach (T elem in table)
                {
                    if (currentIndex == index)
                    {
                        return arrayIndex;
                    }
                    currentIndex += 1;
                }
                arrayIndex += 1;
            }
            return -1;
        }

        public override string ToString()
        {

            StringBuilder listRepresentation = new StringBuilder();
            int index = 0;
            for (int i = 0; i < listOfArrays.Count; i++)
            {
                for (int j = 0; j < listOfArrays[i].Length; j++)
                {
                    if (index < firstBlankIndex)
                    {
                        
                        listRepresentation.Append("|" + listOfArrays[i][j].ToString());
                    }
                    else
                    {
                        listRepresentation.Append("| ");
                    }
                    index++;
                }
                listRepresentation.Append("|");
                if (i != listOfArrays.Count - 1)
                {
                    listRepresentation.Append(" -> ");
                }
            }

            return listRepresentation.ToString();
        }
    }
}
