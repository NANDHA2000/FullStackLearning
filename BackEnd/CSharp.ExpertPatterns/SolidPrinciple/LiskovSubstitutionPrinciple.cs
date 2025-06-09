using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ExpertPatterns.SolidPrinciple
{

/*     Liskov Substitution Principle (LSP) 

        "The principle defines that objects of a superclass shall be replaceable with objects of its 
         subclasses without breaking the application" 

*/

    /*SuperclassBehaviour == SubclassBehaviour */

    public class LiskovSubstitutionPrinciple
    {

        #region LSP Code

        // Without LSP:

        public class Bird1
        {
            public virtual void Fly()
            {
                Console.WriteLine("The bird is flying.");
            }
        }

        public class Ostrich1 : Bird1
        {
            // Ostrich cannot fly, so it throws an exception here, violating LSP
            public override void Fly()
            {
                //throw new InvalidOperationException("Ostriches cannot fly.");
                Console.WriteLine("Ostriches cannot fly.");
            }
        }

        // With LSP:

        public abstract class Bird2
        {
            // Only common behavior to all birds
            public abstract void Move();
        }

        public class FlyingBird2 : Bird2
        {
            public override void Move()
            {
                Console.WriteLine("The bird is flying.");
            }
        }

        public class Ostrich2 : Bird2
        {
            // Ostrich moves by running, adhering to LSP by not exposing the Fly method
            public override void Move()
            {
                Console.WriteLine("The ostrich is running.");
            }
        }

        #endregion
    }
}
