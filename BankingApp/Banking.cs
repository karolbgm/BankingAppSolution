using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp;
internal class Banking
{
    public int AccountId { get; set; }
    public string Description { get; set; }
    public decimal Balance { get; set; } = 0;

    public void DepositIntoAccount(decimal amountToAdd)
    {
        
       
            Balance += amountToAdd;
            Console.WriteLine($"Sucess! You deposited: ${amountToAdd}");
        
    }

    public void WithdrawFromAccount(decimal amountToWithdraw)
    {
        
            Balance -= amountToWithdraw;
            Console.WriteLine($"Sucess! You withdrawed: ${amountToWithdraw}");


    }

    public void DisplayBalance()
    {
        Console.WriteLine($"{Description} Account Balance: ${Balance}");
    }





}
