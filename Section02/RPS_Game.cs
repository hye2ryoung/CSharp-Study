using System;
namespace Section02
{
    public class RPS_Game
    {
        //enum(열거형) : const의 별개적인 느낌 대신 사용(그룹) 
        enum Choice
        {
            Rock = 1,
            Paper = 2,
            Scissors = 0
        }

        public static void Main(string[] args)
        {
            //const(상수) : 변수의 값을 고정시킬 수 있도록 자료형 앞에 붙여줌
            //상수는 한 번 설정한 이후로 다시 값을 바꿀 수 없다
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 0;


            //0:가위 1:바위 2:보

            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); //0~2사이의 랜덤 값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case SCISSORS://enum에서 가져올 때는 (int)Choice.Scissors:
                              //사용할 때 그룹 이름을 앞에 명시, enum값이기 때문에 정수형으로 변환
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case ROCK:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case PAPER:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }

            switch (aiChoice)
            {
                case SCISSORS:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;
                case ROCK:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                    break;
                case PAPER:
                    Console.WriteLine("컴퓨터의 선택은 보입니다.");
                    break;
            }

            //승리 무승부 패배
            if (choice == aiChoice)
            {
                Console.WriteLine("무승부입니다.");
            }
            else if (choice == SCISSORS && aiChoice == PAPER)
            {
                Console.WriteLine("승리입니다.");
            }
            else if (choice == ROCK && aiChoice == SCISSORS)
            {
                Console.WriteLine("승리입니다.");
            }
            else if (choice == PAPER && aiChoice == ROCK)
            {
                Console.WriteLine("승리입니다.");
            }
            else 
            {
                Console.WriteLine("패배입니다.");
            }
        }
    }
}
 