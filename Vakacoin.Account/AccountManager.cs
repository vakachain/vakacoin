using Vakacoin.Account.Base;
using Vakacoin.Cryptography;

namespace Vakacoin.Account
{
    public class AccountManager : IAccountManager
    {
        public string CreateNewAccount(string password)
        {
            var createAccount = new ECKeyPairGenerate();
            var keypair = createAccount.generate();
            var address = new Address(keypair.GetEncodedPublicKey());
            return address.ToHex();

        }

        public bool WriteAccount(ECKeyPair key, string password)
        {
            throw new System.NotImplementedException();
        }


        public string UnlockAccount(string password)
        {
            throw new System.NotImplementedException();
        }

        public string LockAccount(string address)
        {
            throw new System.NotImplementedException();
        }

        public bool isLocked(string address)
        {
            throw new System.NotImplementedException();
        }

        public string GetAddressFromPrivateKey(string privateKey)
        {
            throw new System.NotImplementedException();
        }

        public string GeneratePhase()
        {
            throw new System.NotImplementedException();
        }
    }
}