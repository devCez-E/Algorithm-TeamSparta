using System;
using System.Text;

namespace Solution021 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 약수의 개수와 덧셈
        // 입력받은 두 수 left, right 까지의 수 중 약수의 개수가 짝수인 수는 더하고
        // 약수의 개수가 홀수인 수는 뺀 합계를 반환하시오
        static void Main(string[] args)
        {
            int a1 = 13;
            int b1 = 17;

            int a2 = 24;
            int b2 = 27;

            Program pg = new Program();
            var answer0 = pg.Solution(a1, b1);
            var answer1 = pg.Solution(a2, b2);

            Console.WriteLine($"a1, b1의 약수의 합 : {answer0}");
            Console.WriteLine($"a2, b2의 약수의 합 : {answer1}");
        }
    
        int Solution(int left, int right)
        {
            int answer = 0;

            for(int j = left; j <= right; j++){
                int sum = 1;
                int max = j / 2;
                for(int i = 1; i <= max; i++){
                    if(j % i == 0) sum++;
                }
                if(sum % 2 == 0) answer += j;
                else answer -= j;
            }

            return answer;
        }
    }
}