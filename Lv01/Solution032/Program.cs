using System;

namespace Solution032
{
    class Program
    {
        // 자연수 n이 매개변수로 주어집니다. 
        // n을 3진법 상에서 앞뒤로 뒤집은 후, 이를 다시 10진법으로 표현한 수를 반환하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer1 = pg.Solution(45);  // 7
            var answer2 = pg.Solution(125); //229

            Console.WriteLine($"45의 3진법 뒤집기 : {answer1}");
            Console.WriteLine($"125의 3진법 뒤집기 : {answer2}");
        }

        int Solution(int n){
            int answer = 0;
            int length = (int)Math.Truncate(Math.Log(n, 3));

            for(int i = length; i >= 0; i--){
                int temp = (int)Math.Pow(3, i);
                int value = (int)Math.Pow(3, (length - i));
                int num = 0;

                if(n >= temp * 2) num = 2;
                else if (n >= temp) num = 1;
                else num = 0;

                n -= temp * num;
                answer += value * num;
            }

            return answer;
        }
    }
}
