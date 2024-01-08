using System;

namespace Solution037
{
    class Program
    {
        //문자열 s가 주어졌을 때, s의 각 위치마다 자신보다 앞에 나왔으면서, 자신과 가장 가까운 곳에 있는 같은 글자의 위치를 반환하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.solution("banana");
            pg.solution("foobar");
        }

        public int[] solution(string s) {
            int[] answer = new int[s.Length];
            answer[0] = -1;
            for(int i= 1; i < s.Length; i++){
                char c = s[i];
                answer[i] = -1;
                for(int j = 0; j < i; j++){
                    if(c.CompareTo(s[j]) == 0) {
                        answer[i] = (i - j);
                    }
                }
            }
            return answer;
        }
    }
}
