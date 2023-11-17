using System;

namespace Solution028 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 가로의 길이가 n, 세로의 길이가 m인 직사각형을 출력하시오
        static void Main(string[] args)
        {
            Program pg = new Program();
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            pg.PrintRectangle(a, b);
        }

        void PrintRectangle(int n, int m){
            for(int i = 0; i < m; i++){
                for(int j = 0; j < n; j++){
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}