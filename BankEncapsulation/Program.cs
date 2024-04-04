namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(); //step 4 create instance
            Console.WriteLine("Deposit money");



            var amountToDeposit = double.Parse(Console.ReadLine()); //step 6 Because step2 needed a double had to parse to double.  

            account.Depost(amountToDeposit);     //step 5 deposit money

            Console.WriteLine($"Your balance is now {account.GetBalance()}"); // step 7 access account, and call method to get the balance










            //BELOW IS EXTRA PRACTICE



            //Console.WriteLine("How  much would you like to withdraw?");


            //var amountToWithdraw = double.Parse(Console.ReadLine());
            //account.Withdraw(amountToWithdraw);

            //Console.WriteLine($"Your account is now at {account.Withdraw(amountToWithdraw)}");









            /////ATM



            //Console.WriteLine(" ENTER Deposit, Withdraw, Balance");
            //string userInput = (Console.ReadLine());

            //if (userInput == "Withdraw") 

            //{   
            //        Console.WriteLine("How much would you like to withdraw?");
            //        var amountToWithdraw = double.Parse(Console.ReadLine());
            //        account.Withdraw(amountToWithdraw);
            //        Console.WriteLine($"Your account is now at {account.GetBalance()}");
            //}

            //if (userInput == "Deposit")
            //{
            //    Console.WriteLine("How much would you like to deposit?");
            //    var amountToDeposit = double.Parse(Console.ReadLine());
            //    account.Depost(amountToDeposit);
            //    Console.WriteLine($"Your account is now at {account.GetBalance()}");
            //}

            //else if( userInput == "Balance")
            //{
            //    Console.WriteLine($"{account.GetBalance()}");
            //}



        }
    }
}
