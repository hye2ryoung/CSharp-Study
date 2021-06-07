using System;

namespace Section02_Practice2
{
    class Star
    {
        //별 찍기
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");//별 연달아 찍기
                }
                Console.WriteLine();//개행
            }
        }
    }
}
