using System;
using System.Text;

namespace Solution024 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 문자열을 내림차순으로 정렬하시오
        // 소문자는 대문자보다 큰 것으로 봅니다.
        // ex. Zbcdefg -> gfedcdZ
        static void Main(string[] args)
        {
            string s1 = "Zbcdefg";

            Program pg = new Program();
            var answer0 = pg.Solution(s1);

            Console.WriteLine($"Zbcdefg의 내림차순 정렬 : {answer0}");
        }
    
        string Solution(string s)
        {
            char[] data = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',};
            int[] _answer = new int[data.Length];

            string answer = "";

            foreach(var c in s){
                int idx = Array.IndexOf(data, c);
                _answer[idx] += 1;
            }

            StringBuilder sb = new StringBuilder();

            for(int i = _answer.Length-1; i >= 0; i--){
                if(_answer[i] == 0) continue;

                for(int j = 0; j < _answer[i]; j++) sb.Append(data[i]);
            }

            answer = sb.ToString();

            return answer;
        }
    }
}