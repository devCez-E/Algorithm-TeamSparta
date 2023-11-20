using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //정수 num이 짝수일 경우 "Even"을 반환하고 홀수인 경우 "Odd"를 반환하는 코드를 작성하시오.
            string input = Console.ReadLine();
            int num = 0;
            string answer = "";

            if(int.TryParse(input, out num))
            {
                if(num % 2 == 0) answer = "Even";
                else answer = "Odd";

                Console.WriteLine(answer);
            }
        }
    }
}