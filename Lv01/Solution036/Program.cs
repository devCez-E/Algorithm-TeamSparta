using System;
using System.Text;

namespace Solution036
{
    // 어떤 문장의 각 알파벳을 일정한 거리만큼 밀어서 다른 알파벳으로 바꾸는 암호화 방식인 시저 암호를 구현하시오.
    // 
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();

            var answer1 = pg.Solution("AB", 1);  //  BC
            var answer2 = pg.Solution("z", 1);   //  a
            var answer3 = pg.Solution("a B z", 4); // e F d

            Console.WriteLine($"AB의 시저암호는 {answer1}");
            Console.WriteLine($"z의 시저암호는 {answer2}");
            Console.WriteLine($"a B z의 시저암호는 {answer3}");
        }

        public string Solution(string s, int n) {
            string answer = "";
            char[] data = new char[]{'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < s.Length; i++){
                if(s[i] == ' ') sb.Append(" ");
                else{
                    int idx = Array.IndexOf(data, Char.ToLower(s[i])) + n;
                    
                    if(idx > 25) idx -= 26;
                    
                    if(Char.IsUpper(s[i])){
                        sb.Append(Char.ToUpper(data[idx]));
                    }else{
                        sb.Append(Char.ToLower(data[idx]));
                    }
                }
            }
            answer = sb.ToString();
            return answer;
        }
    }
}
