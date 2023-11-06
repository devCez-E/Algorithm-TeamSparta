using System;

namespace Solution009 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 임의의 양의 정수 N에 대해, N이 어떤 양의 정수 X의 제곱인지 구하시오.
        // 제곱이라면 X+1 의 제곱을 반환하고,
        // 아니라면, -1을 반환하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer1 = pg.Solution(121);
            var answer2 = pg.Solution(3);
            var answer3 = pg.Solution(1);

            Console.WriteLine($"121의 반환 값 : {answer1}");
            Console.WriteLine($"3의 반환 값 : {answer2}");
            Console.WriteLine($"1의 반환 값 : {answer3}");
        }
    
        long Solution(long value){
            if(value < 1) return -1;

            long answer = -1;
            long max = (value / 2) + 1;

            for(int i = 1; i <= max; i++){
                if(value % i == 0) 
                {
                    if(value / i == i){
                        answer = (long)Math.Pow((i+1), 2);
                        break;
                    }
                }
            }

            return answer;
        }
    }
}