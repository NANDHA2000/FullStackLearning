namespace DotNetMastery.Basics.ControlFlowStatements
{
    /* -----------------------------------------------------------------------------
    C# Loops Workflow Reference Catalog
    -----------------------------------------------------------------------------
    This file serves as a pure syntax reference for the different behaviors,
    directions, and control strategies across C# loops.
    -----------------------------------------------------------------------------
    */

    public static class LoopsWorkFlow
    {
        #region 1. For Loops (Definite Iteration)

        /// <summary>
        /// Demonstrates a standard incrementing loop path moving forward.
        /// </summary>
        public static void DemonstrateStandardIncrementLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Increment Index i = {i}");
            }
        }

        /// <summary>
        /// Demonstrates a reverse decrementing loop path moving backward.
        /// </summary>
        public static void DemonstrateReverseDecrementLoop()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Decrement Index i = {i}");
            }
        }

        /// <summary>
        /// Demonstrates a customized iteration step interval expression (stepping by 2).
        /// </summary>
        public static void DemonstrateSteppingLoop()
        {
            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine($"Stepping Index i = {i}");
            }
        }

        /// <summary>
        /// Demonstrates traditional array iteration relying on boundary index checks.
        /// </summary>
        public static void DemonstrateArrayForLoop()
        {
            string[] names = { "Ram", "Sita", "Laxman" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Index [{i}] = {names[i]}");
            }
        }

        /// <summary>
        /// Demonstrates multidimensional processing using nested coordinate workflows.
        /// </summary>
        public static void DemonstrateNestedLoop()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"Outer Row: {i}, Inner Col: {j} (Coord: [{i},{j}])");
                }
            }
        }

        #endregion

        #region 2. While Loops (Condition-Driven / Entry-Controlled)

        /// <summary>
        /// Demonstrates an entry-controlled block that requires explicit counter updating.
        /// </summary>
        public static void DemonstrateStandardWhileLoop()
        {
            int counter = 0;

            while (counter < 3)
            {
                Console.WriteLine($"While Counter = {counter}");
                counter++; // Crucial step modification to prevent infinite loops
            }
        }

        #endregion

        #region 3. Do-While Loops (Exit-Controlled / Executes At Least Once)

        /// <summary>
        /// Demonstrates an exit-controlled block evaluating conditions post-execution block.
        /// </summary>
        public static void DemonstrateStandardDoWhileLoop()
        {
            int score = 100;

            // This executes exactly once even though the entry condition evaluates to false initially.
            do
            {
                Console.WriteLine($"Executed Pass! Current Evaluated Score: {score}");
                score++;
            } while (score < 10);
        }

        #endregion

        #region 4. Foreach Loops (Collection Read-Only Iteration)

        /// <summary>
        /// Demonstrates type-safe collection traversal without handling internal indices manually.
        /// </summary>
        public static void DemonstrateForEachCollectionLoop()
        {
            var creditCards = new List<string> { "Visa", "MasterCard", "Amex", "Rupay" };

            foreach (string card in creditCards)
            {
                Console.WriteLine($"Processing Element Type: {card}");
                // Note: Modifying 'card' directly inside this iteration block is illegal in C#.
            }
        }

        #endregion

        #region 5. Loop Control & Jump Statements (Break / Continue)

        /// <summary>
        /// Demonstrates bypassing remainder code logic execution via 'continue'.
        /// </summary>
        public static void DemonstrateLoopWithContinue()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i % 2 != 0)
                {
                    // Immediately bypasses remaining lines below and skips to update expression evaluation (i++)
                    continue;
                }
                Console.WriteLine($"Even Target Located: {i}");
            }
        }

        /// <summary>
        /// Demonstrates manual context-driven escaping from infinite execution loops via 'break'.
        /// </summary>
        public static void DemonstrateInfiniteLoopWithBreak()
        {
            int processingAttempts = 1;

            while (true) // Engine executes indefinitely unless interrupted internally
            {
                if (processingAttempts >= 3)
                {
                    // Forces immediate execution exit out of the loop block context
                    break;
                }

                processingAttempts++;
            }
        }

        #endregion
    }
}