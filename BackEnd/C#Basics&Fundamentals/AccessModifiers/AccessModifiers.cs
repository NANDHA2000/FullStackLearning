/*
 
Access modifiers control the visibility or access level of classes, methods, 
and other members.

Note : assembly means project

-----------------------------------------------------------------------------
Modifier	             Accessible From
-----------------------------------------------------------------------------
public	                 Anywhere
private	                 Only within the same class
protected	             In the same class and derived classes
internal	             Within the same assembly/project
protected internal	     Same assembly or derived class
private protected	     Same class or derived class in the same assembly

---------------------------------*--------------------------------------------
 
 */

namespace CSharp.Basics.AccessModifiers
{
    public class AccessModifiers
    {

        public class BaseClass
        {

            // Fields with different access modifiers
            public int num1;                  // Accessible everywhere
            private int num2;                 // Accessible only within BaseClass
            protected int num3;               // Accessible in BaseClass + derived classes
            internal int num4;                // Accessible within the same assembly (project)
            protected internal int num5;      // Accessible within same assembly + derived classes (even outside assembly)
            private protected int num6;       // Accessible within derived classes in same assembly

            public void publicMethod() 
            {
                Console.WriteLine("Public Method Calling...");
            }

            private void privateMethod()
            {
                Console.WriteLine("Private Method Calling...");
            }

            protected void protectedMethod()
            {
                Console.WriteLine("Protected Method Calling...");
            }

            internal void internalMethod()
            {
                Console.WriteLine("Internal Method Calling...");
            }

            protected internal void protectedInternalMethod()
            {
                Console.WriteLine("Protected Internal Method Calling...");
            }

            private protected void privateProtectedMethod()
            {
                Console.WriteLine("Private Protected Method Calling...");
            }


            // Public wrapper to call private method
            public void CallPrivateMethod()
            {
                num2 = 2;
                privateMethod();
            }

            public void BaseClassEx()
            {
                // Accessible fields
                num1 = 1;
                num2 = 2;
                num3 = 3;
                num4 = 4;
                num5 = 5;
                num6 = 6;

                // Accessible methods
                publicMethod();
                privateMethod();
                protectedMethod();
                internalMethod();
                protectedInternalMethod();
                privateProtectedMethod();
            }
        }

        public class DerivedClass : BaseClass
        {

            public void DerivedClassEx()
            {
                // Access to members from the derived class

                this.num1 = 1;    // ✅ public - accessible
                                  // this.num2 = 2; // ❌ private - not accessible
                this.num3 = 3;    // ✅ protected - accessible
                this.num4 = 4;    // ✅ internal - accessible (same assembly)
                this.num5 = 5;    // ✅ protected internal - accessible
                this.num6 = 6;    // ✅ private protected - accessible (derived + same assembly)

                // Call methods
                this.publicMethod();             // ✅ public - accessible
                //this.privateMethod();            // ❌ private - not accessible
                this.protectedMethod();          // ✅ protected - accessible
                this.internalMethod();           // ✅ internal - accessible
                this.protectedInternalMethod();  // ✅ protected internal - accessible
                this.privateProtectedMethod();   // ✅ private protected - accessible


            }

        }

        public class OtherClass
        {
            public void OtherClassEx()
            {
                BaseClass baseClass = new BaseClass();

                baseClass.num1 = 1;    // ✅ public - accessible
                //baseClass.num2 = 2;    // ❌ private - not accessible
                //baseClass.num3 = 3;    // ❌ protected - not accessible from non-derived class
                baseClass.num4 = 4;    // ✅ internal - accessible (same assembly)
                baseClass.num5 = 5;    // ✅ protected internal - accessible (since same assembly)
                //baseClass.num6 = 6;    // ❌ private protected - not accessible from here (only accessible in derived class + same assembly)

                // Call methods
                baseClass.publicMethod();             // ✅ public - accessible
                baseClass.internalMethod();           // ✅ internal - accessible (same assembly)
                //baseClass.protectedMethod();          // ❌ protected - not accessible
                //baseClass.privateMethod();            // ❌ private - not accessible
                baseClass.protectedInternalMethod();  // ✅ protected internal - accessible
                //baseClass.privateProtectedMethod();   // ❌ private protected - not accessible from here

                // If you want to call private method indirectly, use:
                
                //baseClass.CallPrivateMethod();        // ✅ Public wrapper calling private method
            }

        }

        /*public class BaseClass
        {
            public string publicVar = "Public Member";
            private string privateVar = "Private Member";
            protected string protectedVar = "Protected Member";
            internal string internalVar = "Internal Member";
            protected internal string protectedInternalVar = "Protected Internal Member";
            private protected string privateProtectedVar = "Private Protected Member";

            public void ShowAccessInBase()
            {
                Console.WriteLine("Inside BaseClass:");
                Console.WriteLine(publicVar);              // ✅
                Console.WriteLine(privateVar);             // ✅
                Console.WriteLine(protectedVar);           // ✅
                Console.WriteLine(internalVar);            // ✅
                Console.WriteLine(protectedInternalVar);   // ✅
                Console.WriteLine(privateProtectedVar);    // ✅
            }
        }

        public class DerivedClass : BaseClass
        {
            public void ShowAccessInDerived()
            {
                Console.WriteLine("Inside DerivedClass:");
                Console.WriteLine(publicVar);              // ✅
                                                           // Console.WriteLine(privateVar);         // ❌ Not accessible
                Console.WriteLine(protectedVar);           // ✅
                Console.WriteLine(internalVar);            // ✅ (same assembly)
                Console.WriteLine(protectedInternalVar);   // ✅
                Console.WriteLine(privateProtectedVar);    // ✅ (same assembly + derived)
            }
        }

        public class OtherClass
        {
            public void ShowAccessInOther()
            {
                BaseClass obj = new BaseClass();
                Console.WriteLine("Inside OtherClass:");
                Console.WriteLine(obj.publicVar);              // ✅
                                                               // Console.WriteLine(obj.privateVar);         // ❌
                                                               // Console.WriteLine(obj.protectedVar);       // ❌
                Console.WriteLine(obj.internalVar);            // ✅
                Console.WriteLine(obj.protectedInternalVar);   // ✅
                                                               // Console.WriteLine(obj.privateProtectedVar);// ❌
            }
        }*/
    }
}
