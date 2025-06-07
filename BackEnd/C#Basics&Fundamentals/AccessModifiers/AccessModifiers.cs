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
        }
    }
}
