namespace DotNetMastery.Basics.ControlFlowStatements
{
    /* -----------------------------------------------------------------------------
    C# Control Flow Statements Reference Catalog
    -----------------------------------------------------------------------------
    📌 Selection Statements   -> if, if-else, if-else-if, switch
    📌 Iteration Statements   -> for, while, do-while, foreach
    📌 Jump Statements        -> break, continue
    -----------------------------------------------------------------------------
    */

    public static class ControlFlowStatements
    {
        #region 1. Conditional Statements (If-Else)

        /// <summary>
        /// Demonstrates standard conditional branching statements.
        /// </summary>
        public static void DemonstrateIfElse(int num)
        {
            // Simple if
            if (num > 0)
            {
                Console.WriteLine("Positive number verified.");
            }

            // If-else
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }

            // If-else-if ladder
            if (num == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }

        #endregion

        #region 2. Switch Statement

        /// <summary>
        /// Demonstrates multi-way branching based on a single pattern expression value.
        /// </summary>
        public static void DemonstrateSwitch(int day)
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }

        #endregion

        #region 3. For Loop (With Break and Continue)

        /// <summary>
        /// Demonstrates counter-driven loops alongside conditional jump controls.
        /// </summary>
        public static void DemonstrateForLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    // Immediately bypasses remaining lines and triggers the next iteration increment (i++)
                    continue;
                }
                if (i == 4)
                {
                    // Immediately terminates the execution frame loop completely
                    break;
                }
                Console.WriteLine($"Current Index: {i}");
            }
        }

        #endregion

        #region 4. While Loop

        /// <summary>
        /// Demonstrates a condition-driven entry-controlled iteration workflow.
        /// </summary>
        public static void DemonstrateWhileLoop()
        {
            int j = 0;
            while (j < 3)
            {
                Console.WriteLine($"While iteration: {j}");
                j++;
            }
        }

        #endregion

        #region 5. Do-While Loop

        /// <summary>
        /// Demonstrates an exit-controlled loop that guarantees at least one execution pass.
        /// </summary>
        public static void DemonstrateDoWhileLoop()
        {
            int k = 0;
            do
            {
                Console.WriteLine($"Do-While iteration: {k}");
                k++;
            } while (k < 2);
        }

        #endregion

        #region 6. Foreach Loop

        /// <summary>
        /// Demonstrates safe, sequential data read-only iteration over collection objects.
        /// </summary>
        public static void DemonstrateForEachLoop(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"[{item}] ");
            }
        }

        #endregion
    }
}