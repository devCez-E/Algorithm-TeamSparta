using System;
using System.Text;

namespace Solution030 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 문자열 S에서 가운데 글자를 반환하시오.
        // 문자열의 길이가 짝수라면 가운데 두 글자를 반환하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();
            
            string s1 = "abcde";
            string s2 = "qwer";

            var answer1 =  pg.Solution(s1);
            var answer2 = pg.Solution(s2);

            Console.WriteLine($"abcde의 가운데 글자는 {answer1}");
            Console.WriteLine($"qwer의 가운데 글자는 {answer2}");
        }

        string Solution(string s){
            string answer = "";

            int str_length = s.Length;
            int idx = str_length / 2;

            if(str_length % 2 == 0){
                answer = s.Substring(idx-1, 2);
            }else{
                answer = s[idx].ToString();
            }

            return answer;
        }
    }
}