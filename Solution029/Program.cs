using System;
using System.Linq;

namespace Solution029 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 배열 Arr 에서 가장 작은수를 제외한 배열을 반환하시오.
        // 반환하는 배열이 빈 배열인 경우에 -1을 반환하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();
            
            int [] arr1 = {4,3,2,1};
            int [] arr2 = {10};

            pg.RemoveMin(arr1);
            pg.RemoveMin(arr2);
        }

        int[] RemoveMin(int[] arr){
            int[] answer = {};
            int min = int.MaxValue;

            for(int i = 0; i < arr.Length; i++){
                if(arr[i] < min) min = arr[i];
            }

            answer = arr.Where(num => num != min).ToArray();

            if(arr.Length == 0) answer = arr.Append(-1).ToArray();

            return answer;
        }
    }
}