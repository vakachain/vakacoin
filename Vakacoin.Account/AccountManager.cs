using Vakacoin.Account.Base;
using Vakacoin.Cryptography;

namespace Vakacoin.Account
{
    public class AccountManager : IAccountManager
    {
        public string CreateNewAccount(string password)
        {
            var createaAccount = new ECKeyPairGenerate();
            var Keypair = createaAccount.generate();
            var Address = new Address(Keypair.GetEncodedPublicKey());
            return Address.ToHex();

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