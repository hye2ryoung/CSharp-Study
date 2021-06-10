using System;
namespace Section07
{
    public class Property
    {
        // 객체지향 -> 은닉성
        // 프로퍼티는 함수보다 사용성이 편리하고 은닉성도 가질 수 있는 장점이 있다.
        class Knight
        {
            protected int hp;

            public int Hp
            {
                get { return hp; }
                set { hp = value; }
            }


            //Getter / Get함수
            public int GetHp() { return hp; }

            //Setter / Set함수 
            public void SetHp(int hp) { this.hp = hp; }

            /*
            //자동구현 프로퍼티
            public int Hp { get; set; }
           
            private int _hp;
            public int GetHp() { return _hp; }
            public void SetHp(int value) { _hp = value; }
            */
        }

        public Property()
        //public static void Main(string[] args)
        {
            //프로퍼티
            Knight knight = new Knight();
            //knight.SetHp(100);
            knight.Hp = 100;

            int hp = knight.Hp;
        }
    }
}
