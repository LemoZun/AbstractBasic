namespace AbstractBasic
{
    /*
     * 추상 클래스 
     * 추상 클래스란 클래스의 정의 앞에 abstract 키워드를 배치해 클래스를 추상으로 선언하는 클래스로 
     * 여러 자식클래스에서 공유할 수 있는 기본 클래스의 공통적인 정의를 제공한다.
     * 추상클래스는 인스턴스화 할 수 없고 자식 클래스를 만들어 클래스의 구현을 제공할 수 있다.
     * 추상 클래스에서는 추상 메서드도 정의 할 수 있으며 메서드의 반환 형식 앞에 abstract 키워드를 추가해 정의할 수 있다.
     * 자식 클래스는 반드시 모든 추상 메서드를 구현해야 한다.
     * 
     * 오버라이딩
     * 객체지향 프로그래밍에서 다형성의 특징을 가지는 것으로
     * 부모 클래스에서 물려받은 메서드를 자식클래스에서 재정의하는것이다. 메서드를 오버라이딩 하면 부모 클래스에 있는
     * 메서드보다 자식클래스에서 재정의 된 메서드가 우선시된다. (private 가 붙은 메서드는 오버라이딩 할 수 없다.)
     * 이를 구현하기 위해선 부모클래스의 메서드에 virtual 키워드를 붙이고 오버라이딩 하는 메서드에 override
     * 키워드를 붙여야 한다.
     * 
     * 오버로딩
     * 하나의 메서드를 매개변수의 타입과 개수등을 달리하여 여러번 구현하는것을 말한다.
     * 메서드 이름을 새로 지을 필요가 없으며 일관성 있는 코드 작성이 가능하다.
     * 예를들어 계산기 Calculator() 메서드의 경우 int 값을 받고 int를 반환하거나 float값을 받고 float를 반환하는 등의 오버로딩 구현을 할 수 있다.
     * 
     */
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
