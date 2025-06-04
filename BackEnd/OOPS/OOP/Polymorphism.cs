/*
       Polymorphism means "many forms"

       In Simple words,behaving in different ways depending upon the
       input received is called as Polymorphism

       Two types of polymorphism
            - Compile-time polymorphism(Method Overloading)
            - Run-time polymorphism(Method Overriding)

*/

namespace CSharp.OOP.OOP
{
    public class Polymorphism
    {

        #region Method Overloading
/*

            Method Overloading

                - Compile-time Polymorphism

                - Multiple method with same name but different parameter in same class

                - Method return type may or may not be same

*/


        public class MethodOverLoading
        {
            public int Addition(int a, int b)
            {
                return a + b;
            }

            public int Addition(int a, int b, int c)
            {
                return a + b + c;
            }
        }
        #endregion


        #region Method Overriding
/*
              Method Overriding

               - Run-time Polymorphism

               - Method with same name and same parameter in different class

               - Virtual and over ride key word is used

               - Method return type must be same
*/

        public class MethodOverRiding
        {
            public class ParentClass
            {
                public virtual void Job(string job)
                {
                    Console.WriteLine("The parent primary job is :" + job);
                }
            }

            public class ChildClass : ParentClass
            {
                public override void Job(string job)
                {
                    Console.WriteLine("The child primary job is :" + job);
                }
            }



        } 
        #endregion

    }
}
