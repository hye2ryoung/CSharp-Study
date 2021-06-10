using System;
using System.Collections.Generic;

namespace Section06
{
    public class Dictionary
    {
        class Monster
        {
            public int id;

            public Monster(int id) { this.id = id; }
        }

        public Dictionary()
        //static void Main(string[] args)
        {
            List<int> list = new List<int>();

            //dictionary의 list와의 차이점 : hashtable
            //아주 큰 박스 [ .. ...  . .] 1만개 (1~1만)
            //박스 여러개를 쪼갠다. [1~10] [11~10 ] [ ] [ ] [ ] 10개씩 1천개의 박스에 저장
            //777번 공 ?
            //특정 번호의 데이터를 찾고자 할 때 어디에 있는지 빠르게 찾을 수 있는 방법
            //단점 : 메모리적으로 손해를 본다. 메모리를 내주고 성능을 취한다


            // 100만마리의 몬스터
            // 103번 몬스터 찾기 - 루프 돌면서 하나씩 찾기 - 오래걸림
            // key를 가지고 해당하는 value를 찾는 방법 사용 : Dictionary<TKey, TValue>
            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            for (int i = 0; i < 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }
            //추가
            //dic.Add(1, new Monster(1));
            //dic[5] = new Monster(5);

            //가져오기
            //Monster mon = dic[5000]; //이런식으로 바로 값에 접근하면 코드가 크래쉬 될 수도 있어서 위험하다.
            Monster mon;
            bool found = dic.TryGetValue(7777, out mon); //true, mon의 id값 7777

            //삭제
            //dic.Remove(7777);
            //dic.Clear();
        }
    }
}
