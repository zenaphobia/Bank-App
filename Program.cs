using System;

namespace BankApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserAccount alex = new UserAccount( "Alex", "Navarro") ;

            BankTeller bankTeller = new BankTeller( alex );

            bankTeller.addCheckingAccount( 503242 , .008 );

            Console.WriteLine($"The active bank account is { alex.GetName }, current checkings funds are ${ alex.CheckingAccount.getFunds }, and interest rate is { alex.CheckingAccount.getInterestRate }% ");
        }
    }
}