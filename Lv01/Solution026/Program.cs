using System;
using System.Text;

namespace Solution026 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 문자열 s의 길이가 4 혹은 6이고, 숫자로만 구성돼있는지 확인해주는 함수를 구현하시오.
        //예를 들어 s가 "a234"이면 False를 반환하고 "1234"라면 True를 반환하시오.

        static void Main(string[] args)
        {
            string s1 = "a234";
            string s2 = "1234";

            Program pg = new Program();
            var answer0 = pg.Solution(s1);
            var answer1 = pg.Solution(s2);

            Console.WriteLine($"a1234의 결과값 : {answer0}");
            Console.WriteLine($"1234의 결과값 : {answer1}");
        }
    
        bool Solution(string s)
        {
            bool answer = false;
            //int result = 0;

            Console.WriteLine(s.Length);

            answer = int.TryParse(s, out int result);

            return answer;
        }
    }
}