using System;

namespace Solution011 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 하샤드 수를 구하시오.
        // 하샤드 수는 주어진 정수 N의 각 자리 수의 합으로 N이 나누어지는 수 입니다.
        // ex) 18의 각 자리 수의 합은 9이고 18은 9로 나누어지므로 하샤드 수
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer0 = pg.Solution(1);
            var answer1 = pg.Solution(10);
            var answer2 = pg.Solution(12);
            var answer3 = pg.Solution(11);
            var answer4 = pg.Solution(13);

            Console.WriteLine($"1은 하샤드 수이다. : {answer0}");
            Console.WriteLine($"10은 하샤드 수이다. : {answer1}");
            Console.WriteLine($"12은 하샤드 수이다. : {answer2}");
            Console.WriteLine($"11은 하샤드 수이다. : {answer3}");
            Console.WriteLine($"13은 하샤드 수이다. : {answer4}");
        }
    
        bool Solution(int x){
            bool answer = true;
            int value = x;
            int length = (int)Math.Log10(value) + 1;
            int sum = 0;

            for(int i = 0; i < length; i++){
                sum += value % 10;
                value /= 10;
            }

            if(x % sum == 0) answer = true;
            else answer = false;

            return answer;
        }
    }
}