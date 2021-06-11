using System;

namespace Section07_Event
{
    //delegate 문법을 보완(외부에서 마음대로 호출하는 문제)하기 위해서 한번 더 delegate를 래핑하는 문법
    class Event
    {
        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }

        public static void Main(string[] args)
        {
            InputManager inputManager = new InputManager();

            //event 구독신청 : event +=
            //event 구독취소 : event -=
            //실질적으로 InputKey를 호출할수는 없음 (evnet와 delegate의 가장 큰 차이점)
            inputManager.InputKey += OnInputTest;

            while (true)
            {
                inputManager.Update();
            }
        }
    }
}
