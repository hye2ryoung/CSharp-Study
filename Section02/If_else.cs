using System;

namespace Section02
{
    class If_else
    {
        public If_else()
        {
            int choice = 0; //0:가위 1:바위 2:보 3:치트키

            if (choice == 0)
            {
                Console.WriteLine("가위입니다.");
            }
            else if (choice == 1)
            {
                Console.WriteLine("바위입니다.");
            }
            else if (choice == 2)
            {
                Console.WriteLine("보입니다.");
            }
            else
            {
                Console.WriteLine("치트키입니다.");
            }



            //if-else문

            int number = 25;
            bool isPair;
            if ((number % 2) == 0)
                isPair = true;
            else
                isPair = false;

            //if-else문을 삼항연산자로 표현

            //bool isPair = (조건 ? 맞을때 : 틀릴때);
            //bool isPair = ((number % 2) == 0 ? true : false);
        }
        
    }
}
