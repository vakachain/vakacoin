using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Math;

namespace Vakacoin.Cryptography
{
    public class ECSigner
    {
        /// <summary>
        /// Sign data with key pair
        /// </summary>
        /// <param name="keyPair"></param>
        /// <param name="data"></param>
        /// <returns>ECSignature</returns>
        public ECSignature Sign(ECKeyPair keyPair, byte[] data)
        {
            ECDsaSigner ecdsaSigner = new ECDsaSigner();
            ecdsaSigner.Init(true, new ParametersWithRandom(keyPair.PrivateKey, ECParameters.SecureRandom));
        
            BigInteger[] signature = ecdsaSigner.GenerateSignature(data);
            
            return new ECSignature(signature);
        }
    }
}