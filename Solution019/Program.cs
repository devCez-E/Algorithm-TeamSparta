using System;
using System.Linq;

namespace Solution019
{
    // 정수를 저장한 배열 arr 에서 가장 작은 수를 제거한 배열을 반환하시오.
    // 반환하는 배열이 빈 배열이면 -1을 반환합니다.
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();

            int[] numbers1 = {4,3,2,1};
            int[] numbers2 = {10,10};

            var answer1 = pg.Solution(numbers1);
            var answer2 = pg.Solution(numbers2);

            Console.WriteLine($"[4,3,2,1] 중 가장 작은 값을 제외한 배열의 길이 : {answer1.Length}");
            Console.WriteLine($"[10] 중 가장 작은 값을 제외한 배열의 길이 : {answer2.Length}");
        }

        int[] Solution(int[] numbers){
            int[] answer = new int[]{};
            int min = int.MaxValue;

            for(int i = 0; i < numbers.Length; i++){
                if(min > numbers[i]){
                    min = numbers[i];
                }
            }

            answer = numbers.Where(num => num != min).ToArray();
            
            if(answer.Length == 0) answer = answer.Append(-1).ToArray();
            
            return answer;
        }
    }
}
