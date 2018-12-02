namespace Vakacoin.Account.Base
{
    
    interface IAccount
    {
        /// <summary>
        /// This function will create new account with password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        string CreateNewAccount(string password);

        string UnlockAccount(string password);

        string LockAccount(string address);

        bool isLocked(string address);

        string GetAddressFromPrivateKey(string privateKey);
    }
}