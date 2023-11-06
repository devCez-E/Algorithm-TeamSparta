using System;

namespace Solution010 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 정수 N의 각 자릿수를 큰것부터 작은 순으로 정렬한 새로운 정수를 반환하시오.
        // ex) 118372 -> 873211
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer1 = pg.Solution(118372);

            Console.WriteLine($"118372의 반환 값 : {answer1}");
        }
    
        long Solution(long value){
            long answer = 0;
            int length = (int)Math.Log10(value) + 1;
            int[] data = new int[length];

            for(int i = 0; i < data.Length; i++){
                data[i] = (int)(value % 10);
                value /= 10;
            }

            Array.Sort(data);

            for(int i = 0; i < data.Length; i++) {
                answer += (long)(Math.Pow(10, i) * data[i]);
            }
            return answer;
        }
    }
}