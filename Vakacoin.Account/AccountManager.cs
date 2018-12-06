using System;
using System.IO;
using System.Reflection;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Vakacoin.Account.Base;
using Vakacoin.Cryptography;

namespace Vakacoin.Account
{
    public class AccountManager : IAccountManager
    {
        public static readonly string FileName = ".ak";
        public static readonly string FolderKey = "keys";
        private static readonly SecureRandom RandomSec = new SecureRandom();
        private static readonly string Alg = "AES-256-CFB";
        
        
        /// <summary>
        /// Create new account with password and save it in to folder key
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string CreateNewAccount(string password)
        {
            var createAccount = new ECKeyPairGenerate();
            var keypair = createAccount.generate();
            //get current directory
            //todo change to application folder
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            path = Path.Combine(path, FolderKey);
            
            //create or get directory folder keys
            try
            {
                Directory.CreateDirectory(path);
                
            }
            catch (Exception e)
            {
                throw e;
            }
            try
            {
                var write = WriteAccount(keypair, password, path);
                return write ? "Create account success with address: " + keypair.GetAddressHex() : "Create account fail";

            }
            catch (Exception e)
            {
                throw e;
            }
            
            

        }

       
        /// <summary>
        /// write account with key, password to keys folders
        /// </summary>
        /// <param name="key"></param>
        /// <param name="password"></param>
        /// <param name="fullPath"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool WriteAccount(ECKeyPair key, string password, string fullPath)
        {
            if(key.PrivateKey == null || key.PublicKey == null)
                throw new Exception("Private key or public key cannot be null");
            if(String.IsNullOrEmpty(password))
                throw new Exception("password Cannot be null");
            //return true;
            //check path write
            //
            try
            {
                Directory.CreateDirectory(fullPath);
            }
            catch (Exception e)
            {
                throw e;
            }
            var akp = new AsymmetricCipherKeyPair(key.PublicKey, key.PrivateKey);

            fullPath = Path.Combine(fullPath, key.GetAddressHex() + FileName);
            
            using (var writer = File.CreateText(fullPath))
            {
                var pw = new PemWriter(writer);
                pw.WriteObject(akp, "alg", password.ToCharArray(), RandomSec);
                pw.Writer.Close();
            }

            return true;
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