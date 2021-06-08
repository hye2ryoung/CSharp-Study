using System;

namespace Section06
{
    /*
    class Player
    {

    }

    class Monster
    {

    }
    */

    class Array
    {
        /*
        Player player;
        Monster monster;
        Monster monster_2;
        Monster monster_3;
        */

        //최대값
        static int GetHighScore(int[] scores)
        {
            int maxValue = 0;

            foreach (int score in scores)
            {
                if (score > maxValue)
                    maxValue = score;
            }

            return maxValue;
        }

        //평균
        static int GetAverageSore(int[] scores)
        {
            if (scores.Length == 0)
                return 0;

            int sum = 0;

            foreach ( int score in scores)
            {
                sum += score;
            }
            
            return sum / scores.Length;
        }

        //인덱스값
        static int GetIndexOf(int[] scores, int value)
        {
            //인덱스 반환이 목표이니 굳이 foreach를 쓸 필요 없이 for문으로 0번부터 인덱스 탐색
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == value)
                    return i;
            }

            return -1; //값을 찾지 못했을 떄 -1 반환
        }

        //정렬
        static void Sort(int[] scores)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                // [i ~ sccores.Length - 1]에서 제일 작은 숫자가 있는 inex를 찾는다.
                int minIndex = i;
                for (int j = i;  j < scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex])
                        minIndex = j;
                }

                // swap
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;

                
            }
        }
        
        static void Main(string[] args)
        {
            /*
            //배열
            int[] scores = new int[5] { 10, 20, 30, 40, 50 };
            int[] scores2 = scores;

            scores2[0] = 9999; //scores의 첫번째 인자인 10이 9999로 변경됨

            //0 1 2 3 4
            //scores[0] = 10;
            //scores[1] = 20;
            //scores[2] = 30;
            //scores[3] = 40;
            //scores[4] = 50;

            //for문
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            //foreach문
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }*/
            
            
            
            //연습문제
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            int highestScore = GetHighScore(scores);
            Console.WriteLine(highestScore);

            int averageScore = GetAverageSore(scores);
            Console.WriteLine(averageScore);

            int index = GetIndexOf(scores, 20);
            Console.WriteLine(index);

            Sort(scores); // 10 20 30 40 50 순서로 정렬
        
        }
    
    }
}
