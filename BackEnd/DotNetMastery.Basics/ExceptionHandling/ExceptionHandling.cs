using System;

namespace DotNetMastery.Basics.ExceptionHandling
{
    /* -----------------------------------------------------------------------------
    C# Exception Handling Reference Catalog
    -----------------------------------------------------------------------------
    Basic architecture for capturing and processing runtime anomalies.
    
    Key Principles:
    1. try     -> Encloses code blocks that possess potential runtime error risks.
    2. catch   -> Intercepts and handles errors. Arranged from most specific to generic.
    3. finally -> An execution block guaranteed to run, ideal for resource cleanup.
    -----------------------------------------------------------------------------
    */

    public static class ExceptionHandling
    {
        #region Structured Exception Handling (Try-Catch-Finally)

        /// <summary>
        /// Demonstrates structured error handling using a division scenario.
        /// </summary>
        public static void DemonstrateDivision(int dividend, int divisor)
        {
            try
            {
                // Execution jumps straight to the catch block the exact moment an exception occurs
                int result = dividend / divisor;
            }
            // Rule: Specific exceptions must always be caught BEFORE the general Exception class
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"[CATCH] Specific Exception: {ex.GetType().Name}");
                Console.WriteLine($"  -> Error Message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[CATCH] Generic Exception: {ex.GetType().Name}");
                Console.WriteLine($"  -> Error Message: {ex.Message}");
            }
            finally
            {
                // Always executes regardless of whether an exception was thrown, skipped, or caught
                Console.WriteLine("[FINALLY] Execution completed: Safe cleanup operations performed.");
            }
        }

        #endregion
    }
}