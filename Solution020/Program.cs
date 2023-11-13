using System;
using System.Text;

namespace Solution020 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 가운데 글자 가져오기
        // 문자열 S의 가운데 글자를 반환하시오.
        static void Main(string[] args)
        {
            string s1 = "abcde";
            string s2 = "qwer";
            string s3 = "z";

            Program pg = new Program();
            var answer0 = pg.Solution(s1);
            var answer1 = pg.Solution(s2);
            var answer2 = pg.Solution(s3);

            Console.WriteLine($"abcde의 가운데 글자 : {answer0}");
            Console.WriteLine($"qwer의 가운데 글자 : {answer1}");
            Console.WriteLine($"z의 가운데 글자 : {answer2}");
        }
    
        string Solution(string str)
        {
            string answer = "";

            int str_length = str.Length;
            int idx = str_length / 2;

            if(str_length % 2 == 0){
                answer = str.Substring(idx-1, 2);
            }else{
                answer = str[idx].ToString();
            }

            return answer;
        }
    }
}