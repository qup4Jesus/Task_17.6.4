
namespace Task_17._6._4.AccountTypes
{
    internal abstract class AccountType : IAccountType
    {
        public double Balance { get; private set; }
        public double Interest { get; protected set; }

        public AccountType(double balance)
        {
            Balance = balance;
        }

        public virtual void InterestCalculation()
        {
            Console.WriteLine($"Баланс: {Balance}\n" +
                              $"Процентная ставка {Interest}");
        }
    }
}
