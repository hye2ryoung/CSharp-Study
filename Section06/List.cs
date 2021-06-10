using System;
using System.Collections.Generic;

namespace Section06
{
    public class List
    {
        //static void Main(string[] args)
        public List()
        {
            int[] arr = new int[10];
            arr[0] = 1;

            //List <- 동적 배열
            List<int> list = new List<int>();
            for(int i = 0; i < 5; i++)
                list.Add(i); // [ 0 1 2 3 4 ]

            //삽입 삭제
            //인덱스 2에 999 삽입. 기존의 것은 뒤로 밀려남 
            list.Insert(2, 999); //[ 0 1 999 2 3 4 ]
            //값 3 삭제
            list.Remove(3); // [ 0 1 999 2 4 ]
            //인덱스 0의 값 삭제
            list.RemoveAt(0); // [ 1 999 2 4 ]
            //전체삭제
            list.Clear();


            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            foreach (int num in list)
                Console.WriteLine(num);
        }
    }
}
