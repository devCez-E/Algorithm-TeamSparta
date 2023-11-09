using System;

namespace Solution016 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 정수들의 절댓값을 차례대로 담은 정수 배열 absolutes와 
        // 이 정수들의 부호를 차례대로 담은 불리언 배열 signs이 있습니다.
        // 실제 정수들의 합을 구하여 반환하시오.

        static void Main(string[] args)
        {
        
            int[] arr1 = {4,7,12};
            int[] arr2 = {1,2,3};

            bool[] sign1 = {true, false, true};
            bool[] sign2 = {false, false, true};

            Program pg = new Program();
            var answer0 = pg.Solution(arr1,sign1);
            var answer1 = pg.Solution(arr2, sign2);

            Console.WriteLine($"[4,7,12], [true, false, true] : {answer0}");
            Console.WriteLine($"[1,2,3], [false, false, true] : {answer1}");
        }
    
        int Solution(int[] absolute, bool[] signs)
        {
            int answer = 0;

            for(int i = 0; i < absolute.Length; i++){
                if(signs[i]){
                    answer += absolute[i];
                }else{
                    answer -= absolute[i];
                }
            }

            return answer;
        }
    }
}