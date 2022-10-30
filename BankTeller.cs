namespace BankApp
{
    public class BankTeller : IBankTeller
    {
        UserAccount activeAccount;

        public BankTeller( UserAccount _userAccount )
        {
            this.activeAccount = _userAccount;
        }
        public void selectAccount( UserAccount _userAccount )
        {
            this.activeAccount = _userAccount;
        }
        public void addCheckingAccount()
        {
            this.activeAccount.CheckingAccount = new CheckingAccount();
        }
        public void addCheckingAccount(int _funds)
        {
            this.activeAccount.CheckingAccount = new CheckingAccount( _funds );
        }
        public void addCheckingAccount(int _funds, double _interestRate )
        {
            this.activeAccount.CheckingAccount = new CheckingAccount( _funds, _interestRate );
        }
        public void addSavingsAccount ()
        {
            this.activeAccount.SavingsAccount = new SavingsAccount();
        }

    }
}