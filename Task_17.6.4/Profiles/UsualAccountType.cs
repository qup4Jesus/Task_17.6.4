
using Task_17._6._4.AccountTypes;

namespace Task_17._6._4.Profiles
{
    internal class UsualAccountType : AccountType
    {
        public UsualAccountType(double balance) : base(balance) { }

        public override void InterestCalculation()
        {
            // Расчет процентной ставки для обычного аккаунта по правилам банка
            if (this.Balance < 1000)
                Interest -= Balance * 0.2;
            else
                Interest -= Balance * 0.4;

            base.InterestCalculation();
        }
    }
}
