using System;
namespace Section02
{
    public class While_For 
    {
        public While_For()
        {
            //while 반복문
            int count = 5;

            while (count > 0)
            {
                Console.WriteLine("Hello World!");
                count--;
            }

            //for문
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Hello World");
            }

            //거울아 거울아
            string answer;
            do
            {
                Console.WriteLine("세상에서 내가 가장 아름답니? (y/n) : ");
                answer = Console.ReadLine();
            } while (answer != "y"); //answer이 y가 아닌 동안 do

            Console.WriteLine("정답입니다.");

            //break
            int num = 10002;
            for (int i = 2; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    Console.WriteLine("소수가 아닙니다!");
                    //특정조건
                    //10002는 2로 나누어 떨어지므로 출력창에 메세지가 찍히면서 break
                    break;
                }
            }

            //continue
            for(int i = 1; i <= 100; i++)
            {
                if ((i % 3) != 0)
                    continue;//일련의 조건을 만족하지 못했을때 빠져나가는 것이 잘 보인다. 

                Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}"); //3부터 99까지 출력
            }
        }
    }
}
