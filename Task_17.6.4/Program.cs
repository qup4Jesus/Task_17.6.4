
using Task_17._6._4.Model;
using Task_17._6._4.Profiles;

Account account = new Account();
account.AccountSelection(new SalaryAccountType(2000));

account.AccountSelection(new UsualAccountType(1000));

account.AccountSelection(new UsualAccountType(500));
