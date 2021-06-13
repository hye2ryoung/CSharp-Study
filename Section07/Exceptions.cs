using System;

namespace Section07
{
    public class Exceptions
    {
        public Exceptions()
        {
            try
            {
                //1. 0으로 나눌 때
                //2. 잘못된 메모리를 참조(null)
                //3. 오버플로우
                int a = 0;
                int b = 0;
                int result = a / b; //예외발생하면

                int c = 0; //실행되지않는부분

            }
            catch (DivideByZeroException e)
            {

            }

            catch (Exception e)
            {

            }
            finally
            {
                //DB, 파일 정리 등등 try-catch문과 상관없이 무조건 실행되어야 하는 부분
            }

        }
    }
}
