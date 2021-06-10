using System;
namespace Section07
{
    public class Interface
    {
        //추상 class와 인터페이스


        //abstract : 상속받는 class에서 오버라이딩을 빼먹지 않도록 설정한다.
        //해당 class는 추상 class가 됨
        abstract class Monster
        {
            //가상함수 virtual로 가상함수 Shout을 정의
            //public virtual void Shout() { }

            //함수를 추상적으로 만들었기 때문에 정의{}를 할 수 없으므로 개념적으로만 존재.
            //상속받는 class에서 인터페이스(Shout 기능)를 반드시 사용하도록 강요한다.
            public abstract void Shout();
        }

        //interface문법 : 이름앞에 I를 붙이는 것이 좋다
        //IFlable의 기능을 가지고 있다면, Fly라는 인터페이스 함수를 제공해야 한다.but 구현부는 물려주지 않는다.
        interface IFlyable
        {
            void Fly();
        }

        class Orc : Monster
        {
            //오버라이딩
            public override void Shout()
            {
                Console.WriteLine("록타르 오가르!");
            }
        }

        //interface는 다중상속에 적용 가능(class는 다중상속이 불가능하다)
        class FlyableOrc : Orc, IFlyable
        {
            //interface를 가지고 있다면 해당 함수를 구현해야 한다. 
            public void Fly()
            {

            }
        }

        class Skeleton : Monster
        {
            //오버라이딩
            public override void Shout()
            {
                Console.WriteLine("크어어!");
            }
        }

        static void DoFly(IFlyable flyable)
        {
            flyable.Fly();
        }

        /*
        public static void Main(string[] args)
        {
            //FlyableOrc 클래스가 IFlyable 인터페이스를 상속받으므로 interface형 변수에 저장 가능
            IFlyable flyable = new FlyableOrc();
            DoFly(flyable);

            FlyableOrc orc = new FlyableOrc();
            DoFly(orc);

            
        }
        */
    }
}
