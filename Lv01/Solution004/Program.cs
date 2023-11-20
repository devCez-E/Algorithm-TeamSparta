using System;

namespace Solution004 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 자연수 N이 주어지면 N의 약수의 합을 구하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer1 = pg.Solution(12);
            var answer2 = pg.Solution(5);

            Console.WriteLine($"{12}의 약수의 합은 : {answer1}");
            Console.WriteLine($"{5}의 약수의 합은 : {answer2}");
        }

        int Solution(int n){
            int answer = n;
            int max = n / 2;

            for(int i = 1; i <= max; i++){
                if(n % i == 0) answer += i;
            }

            return answer;
        }
    }
}