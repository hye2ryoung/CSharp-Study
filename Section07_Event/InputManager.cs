using System;
namespace Section07_Event
{
    // Observer Pattern
    public class InputManager
    {
        public delegate void OnInputKey();
        public event OnInputKey InputKey; //구독자를 모집 한 다음

        public void Update()
        {
            if (Console.KeyAvailable == false)
                return;

            //특정 이벤트가 발생했을 때
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.A)
            {
                //구독자들에  메세지를 뿌려주는 방식
                InputKey();

            }
        }
    }
}
