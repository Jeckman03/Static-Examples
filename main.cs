using System;

class MainClass {
  public static void Main (string[] args) {

		// ---PLAYING WITH STATIC MEMBERS AND METHODS---
		
		// Creating an instance of Account 
		Account me = new Account(1000, 37);

		// Calculating if account is allowed
		if (Account.AccountAllowed(me.Balance, me.Age))
		{
			Console.WriteLine("Account allowed");
		}
		else
		{
			Console.WriteLine("Account not allowed");
		}

		// Depositing funds into the account
		me.DepositFunds(20);

		me.ShowCurrentBalance().PrintToConsole();

    Console.ReadLine();
  }
}

public static class UIHelper
{
	public static void PrintToConsole(this string message)
	{
		Console.WriteLine(message);
	}
}

public class Account
{
	// Private Fields
	private int balance;
	private int age;

	// Properties
	public int Balance 
	{ 
		get
		{
			return balance;
		} 
		set
		{
			balance = value;
		} 
	}
	public int Age { 
		get
		{
			return age;
		} 
		set
		{
			age = value;
		}
	}

	private static int MinBalance 
	{ 
		get
			{
				return 200;
			} 
	}
	private static int MinAge 
	{
		get
		{
			return 18;
		}
	}

	// Constructor
	public Account(int Balance, int Age)
	{
		this.Balance = Balance;
		this.Age = Age;
	}

	// This is a static method in a non static class (static items belong to the class not an instance of the class)
	public static bool AccountAllowed(int balance, int age)
	{
		if (balance < MinBalance || age < MinAge)
		{
			return false;
		}
		else
		{
			return true;
		}
	}

	// Methods that are not static
	public void DepositFunds(int amount)
	{
		if (amount > 0)
		{
			Balance += amount;
		}
	}

	public string ShowCurrentBalance()
	{
		string output = "";

		output = $"Available Balance: { Balance }";

		return output;
	}
}