namespace FacadePattern
{
    class Deposit
    {
        public static void DepositAmount(Account account, double amount)
        {
            account.Balance += amount;
        }
    }
}
