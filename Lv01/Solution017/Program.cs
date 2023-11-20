using System;
using System.Text;

namespace Solution017 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 핸드폰 번호 가리기
        // 전화번호 문자열 S를 뒷 4자리를 제외한 나머지 숫자를 전부 *로 가리고 반환하시오.
        static void Main(string[] args)
        {
            string pn1 = "01033334444";
            string pn2 = "027778888";

            Program pg = new Program();
            var answer0 = pg.Solution(pn1);
            var answer1 = pg.Solution(pn2);

            Console.WriteLine($"phone_number_1 : {answer0}");
            Console.WriteLine($"phone_number_2 : {answer1}");
        }
    
        string Solution(string phone_number)
        {
            string answer = "";

            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < phone_number.Length; i++)
            {
                if(i < phone_number.Length - 4){
                    sb.Append("*");
                }
                else{
                    sb.Append(phone_number[i]);
                }
            }
            answer = sb.ToString();

            return answer;
        }
    }
}