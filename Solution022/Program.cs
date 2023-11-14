using System;
using System.Text;

namespace Solution021 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 내적
        // 입력받은 두 배열 A, B의 내적을 구하시오
        static void Main(string[] args)
        {
            int[] a1 = {1,2,3,4};
            int[] b1 = {-3,-1,0,2};

            int[] a2 = {-1,0,1};
            int[] b2 = {1,0,-1};

            Program pg = new Program();
            var answer0 = pg.Solution(a1, b1);
            var answer1 = pg.Solution(a2, b2);

            Console.WriteLine($"a1, b1의 내적 : {answer0}");
            Console.WriteLine($"a2, b2의 내젹 : {answer1}");
        }
    
        int Solution(int[] a, int[] b)
        {
            int answer = 0;

            for(int i = 0; i < a.Length; i++){
                answer += (a[i] * b[i]);
            }

            return answer;
        }
    }
}