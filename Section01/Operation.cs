using System;
namespace Section01
{
    public class Operation
    {
        public Operation()
        {
            //데이터 연산

            int hp = 100;

            // + - * / %
            hp = 100 + 1; 
            hp = 100 - 1; 
            hp = 100 * 2;
            hp = 100 / 2;

            hp = 2 * 100 + 1; //201
            hp = (1 + 2) * 100; //300
            hp = 100 % 3; //(33 * 3 + 1) 1

            Console.WriteLine(hp);

            hp++;
            //hp = hp + 1

            ++hp;
            //hp++와 ++hp의 차이 : ++가 앞에 붙으면 덧셈부터 하고 다음동작, 뒤에 붙으면 그대로 유지한 채로 동작한 뒤 덧셈
            //순서차이

            hp--;
            //hp = hp - 1

            // < <= > >= == !=
            int level = 50;

            bool isAlive = (hp > 0);
            bool isHighLevel = (level >= 40);


            // && : AND, || : OR, ! : NOT
            // a = 살아있는 고렙 유져인가요?
            bool a = isAlive && isHighLevel;

            //b = 살아있거나,  고렙 유저이거나, 둘 중 하나인가요?
            bool b = isAlive || isHighLevel;

            //c = 죽은 유저인가요 ?
            bool c = !isAlive;




            //비트 연산 
            // << >> shift연산 : 최상위비트 1인 경우(음수)에 오른쪽 shift할 시 shift 후 부호 유지(최상위비트 1 유지)
            // uint(unsigned)로 맞추면 편하다

            //&(and), |(or), ^(xor), ~(not)
            //xor을 이용한 id 암호화
            int id = 123;
            int key = 401;

            int d = id ^ key; //490
            int e = d ^ key; //123 -> 원래 값이 나옴
            //key값과 xor한 id 값(a)를 네트워크에 보내면, 받은사람은 같은 key값을 대입하여 원래 id값(b)를 얻음.
            //중간에 id 정보를 가로채려는 사람은 key값을 모르면 알 수 없다.


            //var
            //조커 카드 같은 개념의 형식. 명시적으로 type을 알려주지 않아도 compiler가 알아서 찾게끔 맞춰주는 문법
            //but 남용금지
            var num = 3; //int32
            var num2 = "Hello World"; //string


        }
    }
}
