﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp3
{
    internal class Class1
    {
        public static void Main()
        {
            int[] arr = new int[5];
            int[] arr2 = new int[5];



            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter the element");
                arr[i] = Convert.ToInt32(Console.ReadLine());



            }
            Console.WriteLine("List of arrays:");



            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();



            Array.Sort(arr);
            Console.WriteLine("Sorted array elements in ascending:");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadLine();



            Console.WriteLine("Copied elements are:");
            Array.Copy(arr, arr2, 2);
            foreach (int i in arr2)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadKey();



            Array.Reverse(arr);
            Console.WriteLine("Reversed array alements in desending order:");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadLine();



            Array.Clear(arr, 0, arr.Length);
            Console.WriteLine(" After clear method:");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadLine();



            string[] Leela = new string[3];
            String[] Padhu = new String[3];
            for (int j = 0; j < Leela.Length; j++)
            {
                Console.WriteLine("Enter string elements:");
                Leela[j] = Console.ReadLine();
            }
            Console.WriteLine("List of string elements:");



            foreach (string j in Leela)
            {
                Console.WriteLine(j);
            }
            Console.ReadKey();



            Array.Sort(Leela);
            Console.WriteLine(" Sorted string elements:");
            foreach (string j in Leela)
            {
                Console.WriteLine(j + " ");
            }
            Console.ReadLine();



            Array.Reverse(Leela);
            Console.WriteLine(" Reverse string elements:");
            foreach (string j in Leela)
            {
                Console.WriteLine(j + " ");
            }
            Console.ReadLine();



            Array.Copy(Leela, Padhu, 2);
            Console.WriteLine(" Copied string elements:");
            foreach (string j in Padhu)
            {
                Console.WriteLine(j + " ");
            }
            Console.ReadLine();



            Array.Clear(Leela, 1, 2);
            Console.WriteLine(" After using clear method:");
            foreach (string j in Leela)
            {
                Console.WriteLine(j + " ");
            }
            Console.ReadLine();



        }



    }
}