using System;

namespace Solution014 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 서울에서 김서방 찾기
        // String 배열 L 에서 문자열 S("Kim")의 위치를 찾아 반환하세요.
        static void Main(string[] args)
        {
            string[] arr = {"Jane", "Kim"};

            Program pg = new Program();
            var answer0 = pg.Solution(arr);
            Console.WriteLine($"김서방은 {answer0}에 있다.");
        }
    
        int Solution(string[] L)
        {
            return Array.IndexOf(L, "Kim");
        }
    }
}