namespace BankApp
{
    public class UserAccount : Account
    {
        string firstName;
        string lastName;
        CheckingAccount checkingAccount { get; set; }
        SavingsAccount savingsAccount { get; set; }
        public UserAccount(string _firstName, string _lastName)
        {
            firstName = _firstName;
            lastName = _lastName;
        }

        public CheckingAccount CheckingAccount
        {
            get { return checkingAccount; }
            set { checkingAccount = value; }
        }

        public SavingsAccount SavingsAccount
        {
            get { return savingsAccount; }
            set { savingsAccount = value; }
        }

        public string GetName
        {
            get { return firstName + " " + lastName; }
        }



    }
}