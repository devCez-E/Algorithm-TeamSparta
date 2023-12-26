using System;
using System.Text;

namespace Solution033
{
    class Program
    {
        //문자열 s는 한 개 이상의 단어로 구성되어 있습니다.
        //각 단어는 하나 이상의 공백문자로 구분되어 있습니다.
        //각 단어의 짝수번째 알파벳은 대문자로, 홀수번째 알파벳은 소문자로 바꾼 문자열을 반환하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer1 = pg.Solution("try hello world");  // "TrY HeLlO WoRlD"

            Console.WriteLine($"try hello world의 이상한 문자열 : {answer1}");
        }

        string Solution(string s){
            bool isEven = true;
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < s.Length; i++){
                char c = s[i];
                if(c != ' '){
                    if(isEven)
                    {
                        sb.Append(Char.ToUpper(s[i]));
                    }
                    else
                    {
                        sb.Append(s[i]);
                    }
                    isEven=!isEven;
                }
                else
                {
                    isEven=true;
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }
    }
}
