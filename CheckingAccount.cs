namespace BankApp
{
    public class CheckingAccount : BankAccount
    {
        int funds;
        double interestRate;

        public CheckingAccount(int _funds, double _interestRate)
        {
            funds = _funds;
            interestRate = _interestRate;
        }
        public CheckingAccount (int _funds)
        {
            funds = _funds;
            interestRate = 0;
        }
        public CheckingAccount()
        {
            funds = 0;
            interestRate = 0;
        }

        public int getFunds
        {
            get { return funds; }
        }

        public double getInterestRate
        {
            get { return interestRate; }
        }

    }
}