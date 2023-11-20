using System;

namespace Solution012 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 두 정수 사이에 있는 수들의 합을 구하시오
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer0 = pg.Solution(3, 5);
            var answer1 = pg.Solution(3, 3);
            var answer2 = pg.Solution(5, 3);
            var answer3 = pg.Solution(4, 7);

            Console.WriteLine($"3과 5 사이의 수들의 합은 {answer0} 이다.");
            Console.WriteLine($"3과 3 사이의 수들의 합은 {answer1} 이다.");
            Console.WriteLine($"5과 3 사이의 수들의 합은 {answer2} 이다.");
            Console.WriteLine($"4과 7 사이의 수들의 합은 {answer3} 이다.");
        }
    
        long Solution(int a, int b){
            long answer = 0;
            answer = (long)((a + b) * (Math.Abs(b - a) + 1)) / 2;
            return answer;
        }

        long Solution2(int a, int b)
        {
            long answer = 0;
        
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
        
            for(int i = min; i <= max; i++){
                answer += i;
            }

            return answer;
        }
    }
}