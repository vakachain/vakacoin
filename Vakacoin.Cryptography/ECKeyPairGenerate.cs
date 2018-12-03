using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;

namespace Vakacoin.Cryptography
{
    public class ECKeyPairGenerate
    {
        /// <summary>
        /// Generate key pair with secure random
        /// </summary>
        /// <returns></returns>
        public ECKeyPair generate()
        {
            ECKeyGenerationParameters keygenParams 
                = new ECKeyGenerationParameters(ECParameters.DomainParams, ECParameters.SecureRandom);
        
            ECKeyPairGenerator generator = new ECKeyPairGenerator();
            generator.Init(keygenParams);
        
            AsymmetricCipherKeyPair keypair = generator.GenerateKeyPair();
        
            ECPrivateKeyParameters privParams = (ECPrivateKeyParameters)keypair.Private;
            ECPublicKeyParameters pubParams = (ECPublicKeyParameters)keypair.Public;
        
            ECKeyPair k = new ECKeyPair(privParams, pubParams);
        
            return k;
        }
    }
}