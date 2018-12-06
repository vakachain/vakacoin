using Vakacoin.Cryptography;

namespace Vakacoin.Account.Base
{
    
    interface IAccountManager
    {
        /// <summary>
        /// This function will create new account with password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        string CreateNewAccount(string password);
        
        bool WriteAccount(ECKeyPair key, string password, string fullPath);
        
        
        
        string UnlockAccount(string password);

        string LockAccount(string address);

        bool isLocked(string address);

        string GetAddressFromPrivateKey(string privateKey);
        
        /// <summary>
        /// this is test function
        /// </summary>
        /// <returns></returns>
        string GeneratePhase();
    }
}