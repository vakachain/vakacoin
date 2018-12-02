using System;
using Vakacoin.Account;

namespace Vakacoin.Test.Account
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new AccountManager();
            var address = account.CreateNewAccount("concuacang");
            Console.WriteLine("New Address: "+address);
        }
    }
}