using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}
		private double balance = 0; //step 1 create private field double.
									// balance field is set to private

		public void Depost(double amount)//2 create method (DEPOSIT) will accept double
		{								 // and store it in the balance field.
			balance += amount;
		}

		public double GetBalance() //3create Method named (GetBalance)
		{						   // it will return the amount in the balance field
			return balance;
		}
		//BELOW IS EXTRA PRACTICE

		public double Withdraw(double amount)
		{
			
			balance -= amount;
			
			return balance;
			
		}

		


	}
}

