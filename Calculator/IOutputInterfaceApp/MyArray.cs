using InterfaceApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace IOutputInterfaceApp
{
    public class MyArray : IOutput,IMath,ISort
    {
        private int[] array;

        public MyArray(int[] values)
        {
            array = values;
        }
//Task 1
        public void Show()
        {
            Console.WriteLine("Array elements:");
            foreach(int item in array)
            {
                Console.WriteLine($"{item};");
            }
            Console.WriteLine();
        }
        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }
//Task 2
        public int Max()
        {
            int max = array[0];
            foreach(int n in array)
            {
                if (n > max) max = n;
            }
            return max;
        }
        public int Min()
        {
            int min = array[0];
            foreach (int n in array)
            {
                if (n > min) min = n;
            }
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            foreach(int n in array)
            {
                sum += n;
            }
            float avg = sum / array.Length;
            return avg;
        }
        public bool Search(int valueToSearch)
        {
            foreach(int n in array)
            {
                if (n == valueToSearch)
                    return true;
            }
            return false;
        }
//Task 3
        public void SortAsc()
        {
            Array.Sort(array);
        }
        public void SortDesc()
        {
            Array.Sort(array);
            Array.Reverse(array);
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
                SortAsc();
            else
                SortDesc();
        }
    }
}
