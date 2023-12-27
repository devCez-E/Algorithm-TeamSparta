using System;

namespace Solution034
{
    class Program
    {
        // 3개의 정수 번호를 더했을 때 0이 되는 경우의 수를 구하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();

            int [] arr1 = new int[]{-2, 3, 0, 2, -5};
            int [] arr2 = new int[]{-3, -2, -1, 0, 1, 2, 3};
            int [] arr3 = new int[]{-1, 1, -1, 1};

            var answer1 = pg.Solution(arr1);  // 2
            var answer2 = pg.Solution(arr2);  // 5
            var answer3 = pg.Solution(arr3);  // 0

            Console.WriteLine($"[-2, 3, 0, 2, -5]의 삼총사 수 : {answer1}");
            Console.WriteLine($"[-3, -2, -1, 0, 1, 2, 3]의 삼총사 수 : {answer2}");
            Console.WriteLine($"[-1, 1, -1, 1]의 삼총사 수 : {answer3}");
        }

        int Solution(int[] number){
            int answer = 0;
            int length = number.Length;

            for(int i = 0; i < length - 2; i++){
                for(int j = i+1; j < length - 1; j++){
                    for (int k = j+1; k < length; k++){
                        if((number[i] + number[j] + number[k]) == 0) answer++;
                    }
                }
            }

            return answer;
        }
    }
}
