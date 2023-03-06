using System;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.

            //Console.Write("Введите n: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] mas = new int[n];
            //Random ran = new Random();
            //int max = 0;
            //int min = 80;
            //for(int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = ran.Next(1, 81);
            //    Console.WriteLine($"\nmas[{i}] = {mas[i]}");
            //    if(mas[i] > max)
            //    {
            //        max = mas[i];
            //    }
            //    else if(mas[i] < min)
            //    {
            //        min = mas[i];
            //    }
            //}
            //Console.WriteLine($"\nМаксимальный элемент = {max}");
            //Console.WriteLine($"\nМинимальный элемент = {min}");

            //int p = mas[max];
            //mas[max] = mas[min];
            //mas[min] = p;
            //foreach(int elem in mas)
            //{
            //    Console.WriteLine(elem);
            //}
            //Console.ReadKey();

            //Задача 2.

            double[] mas = new double[31];
            Random ran = new Random();
            double sum = 0;
            double max = 0;
            double index = 0;
            double min = 65;
            double index1 = 0;
            for(int i = 0; i < mas.Length; i++)
            {
                mas[i] = 62 + 3 * ran.NextDouble();
                Console.WriteLine($"mas[{i+1}] = {mas[i]:f2}");
                sum += mas[i];
                if(mas[i] > max)
                {
                    max = mas[i];
                    index = i;
                }
                else if(mas[i] < min)
                {
                    min = mas[i];
                    index1 = i;
                }
            }
            Console.WriteLine($"\nСредний курс валюты = {sum / mas.Length:f2} руб.");
            Console.WriteLine($"\nМаксимальный курс валюты в {index+1} день = {max:f2} руб.");
            Console.WriteLine($"\nМинимальный курс валюты в {index1+1} день = {min:f2} руб.");
            Console.ReadKey();
        }
    }
}