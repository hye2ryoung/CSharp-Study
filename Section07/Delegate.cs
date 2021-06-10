using System;
namespace Section07
{
    public class Delegate
    {
        delegate int OnClicked();
        // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 형식
        // 반환 : int, 입력 : void
        // OnClicked : 이 delegate 형식의 이름 


        //UI
        static void ButtonPressed(OnClicked clickedFunction/* 함수 자체를 인자로 넘겨주고 */)
        {
            //함수를 호출();
            clickedFunction();
        }


        static int TestDelegate()
        {
            Console.WriteLine("hello delegate");
            return 0;
        }

        static int TestDelegate2()
        {
            Console.WriteLine("hello delegate 2");
            return 0;
        }

        //public Delegate()
        public static void Main(string[] args)
        {
            // delegate (대리자)
            OnClicked clicked = new OnClicked(TestDelegate);
            clicked += TestDelegate2; // 이어서 실행하도록 연결 

            ButtonPressed(clicked); // hello delegate hello delegate 2
            ButtonPressed(TestDelegate/* */); // hello delegate

        }
    }
}
