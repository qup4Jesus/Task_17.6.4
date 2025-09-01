
using Task_17._6._4.AccountTypes;

namespace Task_17._6._4.Profiles
{
    internal class SalaryAccountType : AccountType
    {
        public SalaryAccountType(double balance) : base(balance) { }

        public override void InterestCalculation()
        {
            // Расчет процентной ставки зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;

            base.InterestCalculation();
        }
    }
}
