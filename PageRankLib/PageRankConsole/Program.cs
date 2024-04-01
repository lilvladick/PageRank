using System;
using System.Data;
using System.Diagnostics;
using PageRankWork;

namespace PageRankWork;

class Program
{
    static void Main()
    {
        Console.WriteLine("hello");
        double dampingFactor = 0.85;
        double tolerance = 0.1;
        int maxIterations = 100;
        int[,] webGraph;
        long[] timeresult = new long[4];
        Stopwatch sw = new();
        for (int i = 0; i<4; i++)
        {
            switch (i)
            {
                case 0:
                    sw.Start();
                    webGraph = GenerateMatix(500);
                    PageRank pagerank = new(webGraph, dampingFactor, tolerance, maxIterations);
                    double[] result = pagerank.CalculatePageRank();
                    sw.Stop();
                    //Print(result);
                    Console.WriteLine($"Время работы для матрицы 500х500: {sw.ElapsedMilliseconds} мс");
                    break;
                case 1:
                    sw.Restart();
                    webGraph = GenerateMatix(1000);
                    PageRank pagerank1 = new(webGraph, dampingFactor, tolerance, maxIterations);
                    double[] result1 = pagerank1.CalculatePageRank();
                    sw.Stop();
                    //timeresult[1] = sw.ElapsedMilliseconds;
                    //Print(result1);
                    Console.WriteLine($"Время работы для матрицы 1000х1000: {sw.ElapsedMilliseconds} мс");
                    break;
                case 2:
                    sw.Restart();
                    webGraph = GenerateMatix(1500);
                    PageRank pagerank2 = new(webGraph, dampingFactor, tolerance, maxIterations);
                    double[] result2 = pagerank2.CalculatePageRank();
                    sw.Stop();
                    //timeresult[2] = sw.ElapsedMilliseconds;
                    //Print(result2);
                    Console.WriteLine($"Время работы для матрицы 1500х1500: {sw.ElapsedMilliseconds} мс");
                    break;
                case 3:
                    sw.Restart();
                    webGraph = GenerateMatix(2000);
                    PageRank pagerank3 = new(webGraph, dampingFactor, tolerance, maxIterations);
                    double[] result3 = pagerank3.CalculatePageRank();
                    sw.Stop();
                    //timeresult[3] = sw.ElapsedMilliseconds;
                    //Print(result3);
                    Console.WriteLine($"Время работы для матрицы 2000х2000: {sw.ElapsedMilliseconds} мс");
                    break;
            }
                
        }
        //for (int i = 0;i<4;i++)
            //Console.WriteLine($"Время работы: {timeresult[i]} мс");


        

        //for (int i = 0; i < result.Length; i++)
        //{
            //Console.WriteLine($"Page {i+1}: {result[i]}") ;
        //}
        //Console.WriteLine(String.Join("\nPage ", result));
    }

    static void Print(double[] result)
    {
        for (int i = 0; i < result.Length; i++)
        {
        Console.WriteLine($"Page {i+1}: {result[i]}") ;
        }
    }

    static int[,] GenerateMatix(int size)
    {
        int[,] data = new int[size,size];

        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                data[i, j] = random.Next(0, 2);
                //Console.Write(data[i, j] + " ");
            }
            //Console.WriteLine();
        }
        return data;
    }
}
