using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ExpertPatterns.SolidPrinciple
{
    /*
         Open Closed Principle (OCP) 
        
        "software entities(class,modules,functions,etc.) should be open for extension,
         but closed for modification" 
    */

    public class OpenClosedPrinciple
    {
        #region OCP Code

        // Without OCP:

        public class Rectangle1
        {
            public double Width { get; set; }
            public double Height { get; set; }
        }

        public class Circle1
        {
            public double Radius { get; set; }
        }

        public class AreaCalculator1
        {
            public double CalculateArea(object shape)
            {
                if(shape is Rectangle1 rectangle)
                {
                    return rectangle.Width * rectangle.Height;
                }
                else if(shape is Circle1 circle)
                {
                    return Math.PI * circle.Radius * circle.Radius;
                }
                return 0;
            }
        }


        // With OCP:

        public interface IShape
        {
            double CalculateArea();
        }

        public class Rectangle2 : IShape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public double CalculateArea()
            {
                return Width * Height;
            }
        }

        public class Circle2 : IShape
        {
            public double Radius { get; set; }

            public double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class AreaCalculator2
        {
            public double CalculateArea(IShape shape)
            {
                return shape.CalculateArea();
            }
        }

        #endregion
    }
}
