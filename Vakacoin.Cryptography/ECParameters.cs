using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Vakacoin.Cryptography
{
    public class ECParameters
    {
        public static SecureRandom SecureRandom = new SecureRandom();
        public static X9ECParameters Curve = SecNamedCurves.GetByName("secp256k1");
        public static ECDomainParameters DomainParams = new ECDomainParameters (Curve.Curve, Curve.G, Curve.N, Curve.H);
    }
}