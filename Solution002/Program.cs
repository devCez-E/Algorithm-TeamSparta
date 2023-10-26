using System;

namespace Solution002 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 정수를 담고 있는 배열 arr의 평균값을 return하는 함수를 작성하시오.
        static void Main(string[] args)
        {
            Program pg = new Program();

            int [] arr1 = {1, 2, 3, 4};
            int [] arr2 = {5,5};

            Console.WriteLine($"arr1 average : {pg.GetAverage(arr1)}");
            Console.WriteLine($"arr2 average : {pg.GetAverage(arr2)}");
        }

        double GetAverage(int[] data){
            int sum = 0;
            for(int i = 0; i < data.Length; i++){
                sum += data[i];
            }
            return sum / (double)data.Length;
        }
    }
}