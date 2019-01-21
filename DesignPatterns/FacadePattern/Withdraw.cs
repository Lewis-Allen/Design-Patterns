namespace FacadePattern
{
    class Withdraw
    {
        public static void WithdrawAmount(Account account, double amount)
        {
            account.Balance -= amount;
        }
    }
}
