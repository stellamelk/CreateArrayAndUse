using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateArrayAndUse
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateNewArray();
            Print(new int[,] { });
            Console.ReadKey();
        }
        /// <summary>
        /// Create two-dimensional array from random digits from the interval you choose
        /// </summary>
        /// <returns>Return two-dimensional array</returns>
        public static int[,] CreateNewArray()
        {
            
            int arrRowLength = int.Parse(Console.ReadLine());
            int arrColLength = int.Parse(Console.ReadLine());
            int[,] arr = new int[arrRowLength, arrColLength];

            Random rd = new Random();
            int randMinValue = int.Parse(Console.ReadLine());
            int randMaxValue = int.Parse(Console.ReadLine());
            if (randMaxValue > randMinValue)
            {
                for (int i = 0; i < arrRowLength; i++)
                {
                    for (int j = 0; j < arrColLength; j++)
                    {
                        arr[i, j] = rd.Next(randMinValue, randMaxValue);
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// Finds the max element of two-dimensional array 
        /// </summary>
        /// <param name="arr">given any array of Int32 type</param>
        /// <returns>Return maximum element of array</returns>
        public static int GetArrayMax(int[,] arr)
        {
            int maxOfArr = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[0, 0])
                    {
                        maxOfArr = arr[i, j];
                    }
                }
            }
            return maxOfArr;
        }

        /// <summary>
        /// Finds the min element of two-dimensional array
        /// </summary>
        /// <param name="arr">given any array of Int32 type</param>
        /// <returns>Return minimum element of array</returns>
        public static int GetArrayMin(int[,] arr)
        {
            int minOfArr = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[0, 0])
                    {
                        minOfArr = arr[i, j];
                    }
                }
            }
            return minOfArr;
        }

        /// <summary>
        /// Finde indexes of the max element of two-dimensional array
        /// </summary>
        /// <param name="arr">given any array of Int32 type</param>
        /// <returns>Return indexes of the max element of array</returns>
        public static (int, int) GetMaxIndex(int[,] arr)
        {
            int maxRowIndex = 0;
            int maxColIndex = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[maxRowIndex, maxColIndex])
                    {
                        maxRowIndex = i;
                        maxColIndex = j;
                    }
                }
            }
            return (maxRowIndex, maxColIndex);
        }

        /// <summary>
        /// Finds indexes of the min element of two-dimensional array
        /// </summary>
        /// <param name="arr">given any array of Int32 type</param>
        /// <returns>Return indexes of the min element of array</returns>
        public static (int, int) GetMinIndex(int[,] arr)
        {
            int minRowIndex = 0;
            int minColIndex = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[minRowIndex, minColIndex])
                    {
                        minRowIndex = i;
                        minColIndex = j;
                    }
                }
            }
            return (minRowIndex, minColIndex);
        }

        /// <summary>
        /// Finds diagonal elements of regular two-dimensional array
        /// </summary>
        /// <param name="arr">given any array of Int32 type</param>
        /// <returns>Return diagonal elements of array</returns>
        public static int[] GetDiagonal(int[,] arr)
        {
            int[] diagonal = new int[arr.Length];
            if (arr.GetLength(0) == arr.GetLength(1))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    diagonal [i] = arr[i, i];
                }
            }
            return diagonal;
        }

        /// <summary>
        /// Finds max element of array(diagonal)???
        /// </summary>
        /// <param name="arr">given diagonal array</param>
        /// <returns>return maximum element of diagonal</returns>
        public static int GetMaxOfDiagonal(int[]arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }   
            }
            return max;
        }


        /// <summary>
        /// Finds min element of array(diagonal)???
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>return minimum element of diagonal</returns>
        public static int GetMinOfDiagonal(int[]arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }   
            }
            return min;
        }

        /// <summary>
        /// Prints two-dimensional array elements in console
        /// </summary>
        /// <param name="arr">given any two-dimensional array of Int32 type</param>
        public static void Print(int[,] arr)
        {
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Prints diagonal elements of regular two-dimensional elements in console
        /// </summary>
        /// <param name="arr">given array of Int32 type</param>
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        /// <summary>
        /// Print Int32 result from given parametrs
        /// </summary>
        /// <param name="value">given any Int32 value</param>
        public static void Print(int value)
        {
            Console.WriteLine($"{value}");
        }

        /// <summary>
        /// Print string result from given parametrs
        /// </summary>
        /// <param name="name">given any string</param>
        /// <param name="value">given any Int32 value</param>
        public static void Print(string name,int value)
        {
            Console.WriteLine($"{name} - {value}");
        }


    }
}
