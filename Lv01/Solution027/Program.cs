using System;
using System.Text;

namespace Solution027 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 행렬의 덧셈

        static void Main(string[] args)
        {
            int[,] arr1 = {{1,2},{2,3}};
            int[,] arr2 = {{3,4},{5,6}};

            int[,] arr3 = {{1},{2}};
            int[,] arr4 = {{3},{4}};

            Program pg = new Program();
            var answer0 = pg.Solution(arr1, arr2);
            var answer1 = pg.Solution(arr3, arr4);

        }
    
        public int[,] Solution(int[,] arr1, int[,] arr2) {
            int[,] answer = new int[,] {{}};
            answer = arr1;
                
            for(int i = 0; i < answer.GetLength(0); i++){
                for(int j = 0; j < answer.GetLength(1); j++){
                    answer[i,j] += arr2[i,j];
                }
            }
        
            return answer;
        }
    }
}