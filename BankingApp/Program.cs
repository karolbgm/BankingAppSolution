namespace BankingApp;

internal class Program
{
    static void Main(string[] args)
    {
        //Banking myAccount = new Banking { AccountId = 1, Description = "Checking" };

        Console.WriteLine("Welcome to Karol's bank!");
        Console.WriteLine("Type AccountId: ");
        var accountId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type Checking or Savings: ");
        var accountDescription = Console.ReadLine();

        Banking myAccount = new Banking { AccountId = accountId, Description = accountDescription };

        

        while (true)
        {
            Console.WriteLine($"Account Id: {myAccount.AccountId} Type: {myAccount.Description}");
            Console.WriteLine("Choose an operation (deposit, withdraw or balance) or type 'cancel': ");
            var operation = Console.ReadLine();

            if (operation == "balance")
            {
                myAccount.DisplayBalance();
            }
            else if (operation == "deposit" || operation == "withdraw")
            {
                Console.WriteLine("How much?");
                decimal money = Convert.ToDecimal(Console.ReadLine());
                if (money < 0)
                {
                    Console.WriteLine("Try again.");
                    continue;
                } else
                {
                    if (operation == "deposit")
                    {
                        myAccount.DepositIntoAccount(money);

                    }
                    else if (operation == "withdraw" && money < myAccount.Balance)
                    {
                        myAccount.WithdrawFromAccount(money);

                    } else
                    {
                        Console.WriteLine("Try again.");
                            continue;
                    }
                }
                
            } else if (operation == "cancel")
            {
                break;
            }
        }
        
    }
}
