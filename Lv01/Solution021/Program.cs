using System;
using System.Text;

namespace Solution021 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 수박수박수박수...    
        // 입력받는 수가 4면 수박수박, 3이면 수박수를 
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer0 = pg.Solution(3);
            var answer1 = pg.Solution(4);
            var answer2 = pg.Solution(1);

            Console.WriteLine($"입력값이 3일 때 : {answer0}");
            Console.WriteLine($"입력값이 4일 때 : {answer1}");
            Console.WriteLine($"입력값이 1일 때 : {answer2}");
        }
    
        string Solution(int n)
        {
            int idx = (n+1) / 2;
            string answer = "";
            string pattern = "수박";
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < idx; i++){
                sb.Append(pattern);
            }
            answer = sb.ToString();

            if(n % 2 != 0) answer = answer.Substring(0, n);

            return answer;
        }
    }
}