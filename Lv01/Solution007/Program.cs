using System;

namespace Solution007 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 자연수 X를 뒤집어 각 자리 숫자를 원소로 가지는 배열
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer1 = pg.Solution(12345);

            Console.WriteLine($"12345를 뒤집어 각 자리 숫자를 원소로 가지는 배열 : {answer1}");
        }

        int[] Solution(long n){
            int size = (int)Math.Log10(n) + 1;
            int[] arr = new int[size];

            for(int i = 0; i < size; i++){
                arr[i] = (int)(n % 10);
                n /= 10;
            }

            return arr;
        }
    }
}