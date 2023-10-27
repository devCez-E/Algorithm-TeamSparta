using System;

namespace Solution003 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 자연수 N이 주어지면 N의 각 자릿수의 합을 구해서 return하는 함수를 작성하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer1 = pg.Solution(123);
            var answer2 = pg.Solution(987);

            Console.WriteLine($"{123}의 각 자릿수의 합은 : {answer1}");
            Console.WriteLine($"{987}의 각 자릿수의 합은 : {answer2}");
        }

        int Solution(int n){
            int answer = 0;

            while(n / 10 != 0){
                answer += n % 10;
                n /= 10;
            }
            answer += n;

            return answer;
        }
    }
}