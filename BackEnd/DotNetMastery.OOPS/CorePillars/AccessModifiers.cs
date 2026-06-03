using System;

namespace DotNetMastery.OOP.CorePillars
{
    /* -----------------------------------------------------------------------------
    Access Modifiers Reference Table (Note: assembly = project)
    -----------------------------------------------------------------------------
    Modifier             Accessible From
    -----------------------------------------------------------------------------
    public               Anywhere
    private              Only within the same class
    protected            In the same class and derived classes
    internal             Within the same assembly/project
    protected internal   Same assembly OR derived class (even outside assembly)
    private protected    Same class OR derived class in the same assembly
    -----------------------------------------------------------------------------
    */

    #region 1. Base Class
    public class BaseClass
    {
        // Fields with different access modifiers
        public int num1;                  // Accessible everywhere
        private int num2;                 // Accessible only within BaseClass
        protected int num3;               // Accessible in BaseClass + derived classes
        internal int num4;                // Accessible within the same assembly
        protected internal int num5;      // Accessible within same assembly + derived classes 
        private protected int num6;       // Accessible within derived classes in same assembly

        public void PublicMethod() => Console.WriteLine("Public Method Calling...");
        private void PrivateMethod() => Console.WriteLine("Private Method Calling...");
        protected void ProtectedMethod() => Console.WriteLine("Protected Method Calling...");
        internal void InternalMethod() => Console.WriteLine("Internal Method Calling...");
        protected internal void ProtectedInternalMethod() => Console.WriteLine("Protected Internal Method Calling...");
        private protected void PrivateProtectedMethod() => Console.WriteLine("Private Protected Method Calling...");

        // Public wrapper to demonstrate calling a private method from within the same class
        public void CallPrivateMethod()
        {
            num2 = 2;
            PrivateMethod();
        }

        public void DemonstrateBaseClassAccess()
        {
            // ✅ ALL fields and methods are accessible from within the class they are defined in.
            num1 = 1; num2 = 2; num3 = 3; num4 = 4; num5 = 5; num6 = 6;

            PublicMethod();
            PrivateMethod();
            ProtectedMethod();
            InternalMethod();
            ProtectedInternalMethod();
            PrivateProtectedMethod();
        }
    }
    #endregion

    #region 2. Derived Class (Inheritance)
    public class DerivedClass : BaseClass
    {
        public void DemonstrateDerivedClassAccess()
        {
            // FIELD ACCESS
            this.num1 = 1;    // ✅ public 
            // this.num2 = 2; // ❌ private - Not Accessible
            this.num3 = 3;    // ✅ protected 
            this.num4 = 4;    // ✅ internal (Works because it's in the same assembly)
            this.num5 = 5;    // ✅ protected internal 
            this.num6 = 6;    // ✅ private protected (Works because derived + same assembly)

            // METHOD ACCESS
            this.PublicMethod();             // ✅ public 
            // this.PrivateMethod();         // ❌ private - Not Accessible
            this.ProtectedMethod();          // ✅ protected 
            this.InternalMethod();           // ✅ internal 
            this.ProtectedInternalMethod();  // ✅ protected internal 
            this.PrivateProtectedMethod();   // ✅ private protected 
        }
    }
    #endregion

    #region 3. Other Class (No Inheritance)
    public class OtherClass
    {
        public void DemonstrateOtherClassAccess()
        {
            BaseClass baseClass = new BaseClass();

            // FIELD ACCESS
            baseClass.num1 = 1;    // ✅ public 
            // baseClass.num2 = 2; // ❌ private 
            // baseClass.num3 = 3; // ❌ protected - Not Accessible (Not a derived class)
            baseClass.num4 = 4;    // ✅ internal (Works because it's in the same assembly)
            baseClass.num5 = 5;    // ✅ protected internal (Works because same assembly)
            // baseClass.num6 = 6; // ❌ private protected - Not Accessible (Not derived)

            // METHOD ACCESS
            baseClass.PublicMethod();             // ✅ public 
            // baseClass.PrivateMethod();         // ❌ private 
            // baseClass.ProtectedMethod();       // ❌ protected 
            baseClass.InternalMethod();           // ✅ internal 
            baseClass.ProtectedInternalMethod();  // ✅ protected internal 
            // baseClass.PrivateProtectedMethod();// ❌ private protected 

            // Using the wrapper to access private data indirectly:
            baseClass.CallPrivateMethod();        // ✅ public wrapper
        }
    }
    #endregion
}