using System;
namespace Section01
{
    public class Casting
    {
        public Casting()
        {
            //1. 바구니 크기가 다른 경우
            int a = 0xFFF;
            short b = (short)a;

            //2. 바구니 크기는 같긴 한데, 부호가 다를 경우
            byte c = 255;
            sbyte sb = (sbyte)c;

            //casting : 크기가 큰 type에서 작은 type 변환 시 주의 (데이터 분실 위험이 있음)

            //underflow(언더플로우), overflow(오버플로우) : 크기는 같은데 부호가 다를 경우 발생
            //0xFF = 0b11111111 = -1

            //3. 소수
            float f = 3.1414f;
            double d = f;

            

        }
    }
}
