namespace BankApp
{
    public class SavingsAccount : BankAccount
    {
        int funds;
        double interestRate;

        public SavingsAccount(int _funds, double _interestRate)
        {
            funds = _funds;
            interestRate = _interestRate;
        }
        public SavingsAccount (int _funds)
        {
            funds = _funds;
            interestRate = 0;
        }
        public SavingsAccount ()
        {
            funds = 0;
            interestRate = 0;
        }

    }
}