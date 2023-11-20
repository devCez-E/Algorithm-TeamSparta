using System;

namespace Solution013 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 콜라츠 추측
        // 1937년 Collatz란 사람에 의해 제기된 추측, 주어진 작업을 반복하면 모든 수가 1이 된다.
        // 1-1. 입력된 수가 짝수라면 2로 나눈다.
        // 1-2. 입력된 수가 홀수라면 3을 곱하고 1을 더한다.
        // 2. 결과로 나온 수에 같은 작업을 1이 될 때까지 반복한다.
        // 3. 500번을 시도해도 1이 안나오면 -1을 반환하라.
        static void Main(string[] args)
        {
            Program pg = new Program();
            var answer0 = pg.Solution(6);
            var answer1 = pg.Solution(16);
            var answer2 = pg.Solution(626331);

            Console.WriteLine($"6의 콜라츠 추측 결과 값 : {answer0}");
            Console.WriteLine($"16의 콜라츠 추측 결과 값 : {answer1}");
            Console.WriteLine($"626331의 콜라츠 추측 결과 값 : {answer2}");
        }
    
        int Solution(int num){
            int answer = 0;
            long x = num;

            while(true){
                if(x == 1) {
                    return answer;
                    break;
                }
                else if(answer > 500){
                    return -1;
                    break;
                }
                else{
                    if(x % 2 == 0) x /= 2;
                    else x = (x * 3 + 1);
                    answer++;
                }
            }
        }

        int Solution2(int num)
        {
            int answer = 0;

            int Collatx(long x){
                if(answer > 500) return -1;
                else if(x == 1) return answer;
                else if(x % 2 == 0){
                    answer += 1;
                    return Collatx(x / 2);
                }
                else{
                    answer += 1;
                    return Collatx(x * 3 + 1);
                }
            }

            return Collatx(num);
        }
    }
}