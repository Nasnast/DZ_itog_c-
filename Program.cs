/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры: 
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] 
[“1234”, “1567”, “-2”, “computer science”] → [“-2”] 
[“Russia”, “Denmark”, “Kazan”] → []*/

using System.ComponentModel;
using System.Globalization;

namespace DZ_итоговое
{
    public static class Program
    {
        public static void Main(string[] array)
        {
            System.Console.WriteLine("введите строку:");
            string str = System.Console.ReadLine();

            string[] str_array = str.Split(' '); // разбила строку на массив слов
            Console.WriteLine("['{0}']", string.Join("', '", str_array)); // печать исходного массива строк

            string[] res_array = ResArray(str_array);
            Console.WriteLine("['{0}']", string.Join("', '", res_array)); // печать нового массива
        }

        public static int LenArray(string[] str_arr) // определение длины нового массива строк
        {
            int n = 0;
            for (int i = 0; i < str_arr.Length; i++)
            {
                if (str_arr[i].Length <= 3)
                {
                    if (str_arr[i] != "")
                    {
                        n++;
                    }
                }
            }
            return (n);
        }
        public static string[] ResArray(string[] str_arr) // заполнение нового массива строк элементами длиной менее 3-х символов
        {
            int j = 0;
            string [] res_arr = new string[LenArray(str_arr)];
            for (int i = 0; i < str_arr.Length; i++)
            {
                if (str_arr[i].Length <= 3)
                {
                    if (str_arr[i] != "")
                    {
                        res_arr[j] = str_arr[i];
                        j++;
                    }
                }
            }
            return res_arr;
        }
    }
}