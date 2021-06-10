using System;
using System.Collections.Generic;

namespace Section07
{
    class Generic
    {
        
        //일반화 형식 : <이름> 붙여주기
        //인자가 여러개일 때 type도 늘리기 가능 ex) <T, K>


        //일반화 형식에 조건 추가하기
        //where 이름 : 조건입력
        //MyList<T> where T : struct (T는 값 형식)
        //                    class (T는 참조 형식)
        //                    new() (T는 어떠한 인자도 받지 않는 기본 생성자가 있어야 한다)
        //                    Monster (T는 Monster, 혹은 Monster를 상속받은 class여야 한다)
        

        //class 일반화
        class MyList<T>
        {
            //object[] arr = new object[10]; //좋은 방법이 아니다.

            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }



        }

        class Monster
        {

        }

        //함수 일반화
        static void Test<T>(T input)
        {

        }


        /*
        public static void Main(string[] args)
        {
            
            //int와 string과 같은 형식들이 object형식을 상속받기 때문에 이러한 변환이 가능.
            object obj = 3;
            object obj2 = "hello world";

            //object에서 데이터를 빼오고 넣는 과정은 속도가 느리다.
            //object는 참조 type로 돌아간다.
            //heap에 메모리를 할당해서 데이터를 넣고 빼올때는 다시 데이터를 stack에 저장하는 복잡한 연산 
            int num = (int)obj;
            string str = (string)obj2;
            



            MyList<int> myIntList = new MyList<int>();
            myIntList.GetItem(0);

            MyList<short> myShortList = new MyList<short>();
            MyList<Monster> myMonsterList = new MyList<Monster>();

            Test<int>(3);
            Test<float>(3.0f);


        }*/
    }
}
