/*

Encapsulation :-

- It is defined as the wrapping up data and method into single unit.

- Encapsulation helps to protect data by hiding it.

- Variable is declared as private

- Public getter and setter methods are defined

 */

namespace CSharp.OOP.OOP
{
    public class Encapsulation
    {
        public class BankAccount
        {
            #region Variables
            private int Currentbalance;
            #endregion

            #region Properties

            public int Deposit
            {
                get { return Currentbalance; }
                set { Currentbalance += value; }
            }
            #endregion

            #region Methods

            public BankAccount(int initialAmount)
            {
                Currentbalance = initialAmount;
            }
            #endregion
        }


    }
}
