using System;
namespace Section02
{
    public class Copy_Ref
    {
        public Copy_Ref()
        {
            /*
            //ref(참조): 값을 복사(짭퉁)하는것이 아닌 변수 자체를 참조(진퉁)하여 실행한다. 
          
            static void AddOne(ref int number)
            {
                number = number + 1;
            }
            static void Main(string[] args)
            {
                int a = 0;
                AddOne(ref a);
                Console.WriteLine(a);
            }
            
            // ref 결과값 : 1 (유효)
            // 참조하지 않았을 때 결과값 : 0
            */

            /*
            //ref를 사용하지 않고 유효할 수 있는 방법(더 좋음)
            static int AddOne2(int number)
            {
                return nubmer + 1;
            }
            static void Main(string[] args)
            {
                int a = 0;
                a = AddOne2(a);
                Console.WriteLine(a);
            }
            // 결과값 : 1 (유효)
            */

            //두 번째 방법이 더 좋은 이유?
            //비록 로직은 같다고 볼 수 있지만 꼭 진퉁(원본)을 안건들이더라도 값을 다른 곳에 저장하는 용도로 사용 가능.
            //필요하면 원본에 계산된 값을 저장하는 것도 가능.

            /*
            //그럼에도 ref를 사용해야하는 경우(진퉁 계산)
            //Swap
            static void Swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            static void Main(string[] args)
            {
                int num1 = 1;
                int num2 = 2;
                Swap(ref num1, ref num2);
                Console.WriteLine(num1); //2
                Console.WriteLine(num2); //1
            }
            */

            //만약, 값을 여러개 반환해야하는 경우 → out 키워드를 이용해 넘길 수도 있음. (out도 참조(진퉁))
        }
    }
}
