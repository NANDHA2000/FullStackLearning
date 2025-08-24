namespace CSharp.OOP.OOP
{
    public class MethodOverRidingVsMethodHiding
    {
        // Method over riding using virtual & override keyword it will consider that method as new one.

        public class BaseClassOverRiding
        {
            public virtual void Greetings()
            {
                Console.WriteLine("Hello From BaseClassOverRiding");
            }
        }

        public class DerivedClassOverRiding : BaseClassOverRiding
        {
            public override void Greetings()
            {
                Console.WriteLine("Hello From DerivedClassOverRiding");
            }
        }

        // Method hiding using new keyword it will consider that method as new one.

        public class BaseClassHiding
        {
            public void Greetings()
            {
                Console.WriteLine("Hello From BaseClassHiding");
            }
        }

        public class DerivedClassHiding: BaseClassHiding
        {
            public new void Greetings()
            {
                Console.WriteLine("Hello From DerivedClassHiding");
            }
        }

    }
}
