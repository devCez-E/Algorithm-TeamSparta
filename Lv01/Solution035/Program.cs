using System;

namespace Solution035
{
    class Program
    {
        // 숫자로 이루어진 문자열 t와 p가 주어질 때, t에서 p와 길이가 같은 부분문자열 중에서, 
        // 이 부분문자열이 나타내는 수가 p가 나타내는 수보다 작거나 같은 것이 나오는 횟수를 반환하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();

            var answer1 = pg.Solution("3141592", "271");  // 2
            var answer2 = pg.Solution("500220839878", "7");  // 8
            var answer3 = pg.Solution("10203", "15");  // 3
            var answer4 = pg.Solution("4", "4");

            Console.WriteLine($"3141592, 271 : {answer1}");
            Console.WriteLine($"500220839878, 7 : {answer2}");
            Console.WriteLine($"10203 , 15 : {answer3}");
            Console.WriteLine($"4 , 4 : {answer4}");
        }

        int Solution(string t, string p){
            int answer = 0;
            int pLength = p.Length;
            long pNum, tNum;

            long.TryParse(p, out pNum);

            for(int i = 0; i <= t.Length - pLength; i++){
                long.TryParse(t.Substring(i, pLength), out tNum);
                if(tNum <= pNum) answer++;
            }
            return answer;
        }
    }
}
