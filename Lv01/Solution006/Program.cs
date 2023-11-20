using System;

namespace Solution006 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // X부터 시작해 X씩 증가하는 숫자 N개를 지니는 리스트를 구하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer1 = pg.Solution(2,5);
            var answer2 = pg.Solution(4,3);
            var answer3 = pg.Solution(-4,2);

            Console.WriteLine($"2만큼 증가하는 원소 5개 리스트 : {answer1}");
            Console.WriteLine($"4만큼 증가하는 원소 3개 리스트 : {answer2}");
            Console.WriteLine($"-4만큼 증가하는 원소 2개 리스트 : {answer3}");
        }

        long[] Solution(int x, int n){
            long[] arr = new long[n];
            arr[0] = x;

            for(int i = 1; i < n; i++){
                arr[i] = arr[i-1] + x;
                Console.WriteLine(arr[i]);
            }

            return arr;
        }
    }
}