using System;
using Vakacoin.Cryptography;

namespace Vakacoin.Account.Models
{
    public class UnlockAccount
    {
        public ECKeyPair KeyPair;
        public TimeSpan lockedTime;
    }
}