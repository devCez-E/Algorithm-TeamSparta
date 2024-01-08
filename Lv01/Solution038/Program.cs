using System;

namespace Solution038
{
    class Program
    {
        // 배열 array의 i번째 숫자부터 j번째 숫자까지 자르고 정렬했을 때, 
        // k번째에 있는 수를 구해 반환하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();
            
            int[] arr1 = new int[] {1,5,2,6,3,7,4};
            int[,] arr2 = new int[,]{{2,5,3}, {4,4,1}, {1,7,3}};            
            pg.solution(arr1, arr2);
        }

        
        public int[] solution(int[] array, int[,] commands) {
            int length = commands.GetLength(0);
            int[] answer = new int[length];

            for(int i = 0; i< length; i++){
                int x = commands[i,0] - 1;
                int y = commands[i,1] - commands[i,0] + 1;
                var segment = new ArraySegment<int>(array, x, y);
                var temp = segment.ToArray();
                Array.Sort(temp);

                answer[i] = temp[commands[i,2]-1];
            }

            return answer;
        }
    }
}
