using System;

namespace Solution018
{
    // 0부터 9까지의 숫자 중 일부가 들어있는 정수 배열 Numbers에서
    // 찾을 수 없는 숫자를 모두 찾아 더한 수를 반환하시오.
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();

            int[] numbers1 = {1,2,3,4,6,7,8,0};
            int[] numbers2 = {5,8,4,0,6,7,9};

            var answer1 = pg.Solution2(numbers1);
            var answer2 = pg.Solution2(numbers2);

            Console.WriteLine($"[1,2,3,4,6,7,8,10] 중 없는 숫자의 합은 : {answer1}");
            Console.WriteLine($"[5,8,4,0,6,7,9] 중 없는 숫자의 합은 : {answer2}");
        }

        int Solution(int[] numbers){
            int answer = 0;

            for(int i = 0; i < 10; i++){
                if(Array.IndexOf(numbers, i) == -1) answer += i;
            }

            return answer;
        }

        int Solution2(int[] numbers){
            int answer = 45;

            for(int i = 0; i < numbers.Length; i++){
                answer -= numbers[i];
            }

            return answer;
        }
    }
}
