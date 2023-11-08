using System;

namespace Solution015 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 배열의 각 원소 중 divisor로 나누어 떨어지는 수를 오름차순으로 정렬한 뒤 반환하시오.
        // 해당하는 수가 없으면 -1을 반환하시오.
        static void Main(string[] args)
        {
            int[] arr1 = {5,9,7,10};
            int[] arr2 = {2,36,1,3};
            int[] arr3 = {3,2,6};

            Program pg = new Program();
            var answer0 = pg.Solution(arr1, 5);
            var answer1 = pg.Solution(arr2, 1);
            var answer2 = pg.Solution(arr3, 10);

            Console.WriteLine($"[5,9,7,10], Divisor : 5 {answer0}");
            Console.WriteLine($"[2,36,1,3], Divisor : 1 {answer1}");
            Console.WriteLine($"[3,2,6], Divisor : 10 {answer2}");
        }
    
        int[] Solution(int[] arr, int divisor)
        {
            int[] answer = new int[] {};

            for(int i = 0; i < arr.Length; i++){
                if(arr[i] % divisor == 0){
                    answer = answer.Append(arr[i]).ToArray();
                }
            }

            if(answer.Length == 0) answer = answer.Append(-1).ToArray();
            
            Array.Sort(answer);

            return answer;
        }
    }
}