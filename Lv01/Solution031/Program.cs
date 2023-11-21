using System;

namespace Solution031 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 최대공약수와 최소공배수를 구하시오
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer1 = pg.GCD(3, 12);
            var answer2 = pg.GCD(2, 5);

            var answer3 = pg.LCM(3,12);
            var answer4 = pg.LCM(2,5);

            Console.WriteLine($"3과 12의 최대공약수는 {answer1}");
            Console.WriteLine($"2와 5의 최대공약수는 {answer2}");

            Console.WriteLine($"3과 12의 최소공배수는 {answer3}");
            Console.WriteLine($"2와 5의 최소공배수는 {answer4}");

            pg.Solution(3,12);
            pg.Solution(2,5);
        }

        int GCD(int a, int b){
            if(b==0) return a;
            else return GCD(b, a%b);
        }

        int LCM(int a, int b){
            int gcd = GCD(a, b);
            return (a * b) / gcd;
        }

        int[] Solution(int a, int b){
            int [] answer = {0, 0};

            answer[0] = GCD(a,b);
            answer[1] = (a * b) / answer[0];

            return answer;
        }
    }
}