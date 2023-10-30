using System;

namespace Solution005 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // N을 X로 나눈 나머지가 1이 되도록 하는 가장 작은 자연수 X를 구하시오
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer1 = pg.Solution(10);
            var answer2 = pg.Solution(12);

            Console.WriteLine($"{10}을 나누었을 때 나머지가 1이 되는 가장 작은 자연수 X : {answer1}");
            Console.WriteLine($"{12}을 나누었을 때 나머지가 1이 되는 가장 작은 자연수 X : {answer2}");
        }

        int Solution(int n){
            int answer = 0;

            for(int i = 1; i < n; i++){
                if(n % i == 1) 
                {
                    answer = i;
                    break;
                }
            }

            return answer;
        }
    }
}