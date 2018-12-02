using Org.BouncyCastle.Crypto.Signers;

namespace Vakacoin.Cryptography
{
    public class ECVerify
    {
        private ECKeyPair _keyPair { get; set; }
        
        public ECVerify(ECKeyPair keyPair)
        {
            _keyPair = keyPair;
        }
        /// <summary>
        /// Verify data with signature
        /// </summary>
        /// <param name="signature"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Verify(ECSignature signature, byte[] data)
        {
            if (signature == null || _keyPair == null || data == null)
                return false;
            
            ECDsaSigner verifier = new ECDsaSigner();
            verifier.Init(false, _keyPair.PublicKey);

            return verifier.VerifySignature(data, signature.Signature[0], signature.Signature[1]);
        }
    }
}