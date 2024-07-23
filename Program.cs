namespace AbstractBasic
{
    internal class Program
    {
        enum ControlType {Mordern, Classic, Dynamic}
        const int Maxhp = 100;
        const int MaxGauge = 300;

        public abstract class Character
        {
            string name;
            ControlType controlType;
            int hp;
            int defense = 10;
            int gauge;
            double speed=10.0;

            public void Basics()
            {
                Console.WriteLine("기본기로 10의 데미지를 주었습니다.");
            }
            public virtual void Grab(int value)
            {
                Console.WriteLine($"잡기로 {10 + value}데미지를 줬습니다.");                
            }
            public abstract void SpecialArts();



        }

        public class Zoning : Character
        {
            int dfMinusValue;
            double reachValue;
            int maxInstall;

            public void Okizeme() //깔아두기
            {
                Console.WriteLine("깔아두기 기술 사용");
            }

            public void Poke()
            {
                Console.WriteLine("견제기 사용");
            }

            public override void SpecialArts()
            {
                Console.WriteLine("장거리형 필살기를 사용했습니다.");
            }
        }

        public class Grappler : Character
        {
            int dfPlusValue;
            double speedMinusValue;
            bool guardPoint;

            void CommandGrab()
            {
                Console.WriteLine("커맨드 잡기 사용.");
            }
            void OverDrive(bool _guardPoint)
            {
                if (guardPoint == true) Console.WriteLine("상대의 공격을 버티고 공격을 성공했습니다.");
                else Console.WriteLine("공격을 버티지 못했습니다.");
            }
            public override void Grab(int _value)
            {
                Console.WriteLine($"잡기로 {10 + _value + 10}데미지를 줬습니다.");
            }

            public override void SpecialArts()
            {
                Console.WriteLine("가드불가 잡기형 필살기를 사용했습니다.");
            }

        }

        public class Shoto : Character
        {
            int fireBallDamage;
            int dpDamage;
            int uniqueStack;

                public override void SpecialArts()
            {
                Console.WriteLine("일반 필살기를 사용했습니다.");
            }
        }


            
        static void Main(string[] args)
        {
            
        }
    }
}
