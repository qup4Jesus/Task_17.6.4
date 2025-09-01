
using Task_17._6._4.AccountTypes;

namespace Task_17._6._4.Model
{
    internal class Account
    {
        private AccountType _accountType;

        public Account() { }

        public void AccountSelection(AccountType accountType)
        {
            _accountType = accountType;
            _accountType.InterestCalculation();
        }
    }
}
