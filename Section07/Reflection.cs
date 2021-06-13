using System;
using System.Reflection;

namespace Section07
{
    public class Reflection
    {
        class Important : System.Attribute
        {
            string message;
            public Important(string message) { this.message = message; }
        }

        class Monster
        {
            // hp입니다. 중요한 정보입니다.
            [Important("Very Important")] // attribute : 컴퓨터가 런타임에 체크할 수 있는 주석이다.  
            public int hp;
            protected int attack;
            private float speed;

            void Attack() { }
        }

        //public static void Main(string[] args)
        public Reflection()
        {
            // Reflection : X-Ray를 찍는 것과 같다
            Monster monster = new Monster();
            Type type = monster.GetType();

            var fields = type.GetFields(System.Reflection.BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance);
            foreach (FieldInfo field in fields)
            {
                string access = "protected";
                if (field.IsPublic)
                    access = "public";
                else if (field.IsPrivate)
                    access = "private";

                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}
