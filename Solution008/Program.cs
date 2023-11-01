using System;

namespace Solution008 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 문자열 S를 숫자로 변환하는 함수를 작성하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer1 = pg.Solution("1234");
            var answer2 = pg.Solution("-1234");
            var answer3 = pg.Solution("+1234");

            Console.WriteLine($"문자열 \"1234\"를 숫자로 변환한 결과 : {answer1}");
            Console.WriteLine($"문자열 \"-1234\"를 숫자로 변환한 결과 : {answer2}");
            Console.WriteLine($"문자열 \"+1234\"를 숫자로 변환한 결과 : {answer3}");
        }

        int Solution(string s){
            int answer = int.Parse(s);
            
            return answer;
        }
    }
}