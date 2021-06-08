using System;
namespace Section06
{
    public class MultiArray
    {
        //다차원 배열
        
        class Map
        {
            //[n,m]
            int[,] tiles =
            {
                {1,1,1,1,1},
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,1,1,1,1},

            };

            public void Render()
            {
                //Array.GetLength(i) : 배열의 i차원의 크기를 제공, 0차원부터 시작한다(1차원: 0 2차원: 1)
                //1차원 배열의 길이 n 2차원 배열의 길이 m
                //Array.Length를 사용하면 nm의 값을 얻는다.
                for (int y = 0; y < tiles.GetLength(1); y++)//GetLength(1) : m
                {
                    for (int x = 0; x < tiles.GetLength(0); x++)//GetLength(0) : n
                    {
                        if (tiles[x, y] == 1)
                            Console.ForegroundColor = ConsoleColor.Red;// 색깔변경
                        else
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('\u25cf');//동그라미출력 
                    }
                    Console.WriteLine();//개행 
                }
            }
        }

       
        /*
        static void Main(string[] args)
        {
            Map map = new Map();
            map.Render();
        }
        */
    }
}
