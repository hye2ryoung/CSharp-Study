using System;
namespace Section02
{
    public class OverLoading
    {
        //오버로딩 : 함수 이름의 재사용
        //매개 변수의 type 또는 매개변수의 개수가 정확히 일치하면 안됨

        //static int Add(int a, int b)의 오버로딩
        static int Add(int a, int b)
        {
            Console.WriteLine("Add int 호출");
            return a + b;
        }

        static int Add(int a, int b, int c)//개수가 다르므로 가능
        {
            Console.WriteLine("Add int 호출");
            return a + b + c;
        }

        static float Add(float a, float b)//type이 다르므로 가능
        {
            Console.WriteLine("Add float 호출");
            return a + b;
        }
        /*
        static void Main(string[] args)
        {
            int ret = OverLoading.Add(2, 3);
            int ret2 = OverLoading.Add(2, 3, 4);
            float ret3 = OverLoading.Add(2.0f, 3.0f);
        }
        */

        //선택적 오버로딩
        static int Add(int a, int b, int c = 0, float d = 1.0f, double e = 3.0)
        {
            Console.WriteLine("Add int 호출");
            return a + b + c;
        }
        //필수입력값 a,b 옵션값 c, d, e
        //단, 옵션값을 입력해줄때는 순서를 잘 지켜야 함
        //옵션값 중에서 지정해서 값을 넣어 줄 수도 있음(d:2.0f)

    }
}
