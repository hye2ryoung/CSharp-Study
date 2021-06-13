using System;
namespace Section07
{
    public class Nullable
    {
        static int Find()
        {
            return 0;
        }

        class Monster
        {
            public int Id { get; set; }
        }

        public Nullable()
        {
            //Nullabe = Null + able
            //형식 + ?
            //??
            //?.


            int? number = null; // ? : number가 null도 될수있다는 의미
            if (number != null) // null인지 아닌지 체크를 거쳐서 값을 뽑아야 함 
            {
                number = 3;
                int a = number.Value;
                Console.WriteLine(a); // 3

            }

            int b = number ?? 0; // ?? : number가 null인 경우 b에 초기값 0을 넣어줌


            Monster monster = null;
            if (monster != null)
            {
                int monsterId = monster.Id;
            }

            int? id = monster?.Id; // ?. : monster가 null이면 id에 null값, null이 아니면 int Id값 

        }
    }
}
