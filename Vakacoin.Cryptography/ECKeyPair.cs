using System;
using System.Linq;
using Org.BouncyCastle.Crypto.Parameters;

namespace Vakacoin.Cryptography
{
    public class ECKeyPair
    {
        public static int AddressLength { get; } = 18;
        public ECPrivateKeyParameters PrivateKey { get; private set; }
        public ECPublicKeyParameters PublicKey { get; private set; }

        public ECKeyPair(ECPrivateKeyParameters privateKey, ECPublicKeyParameters publicKey)
        {
            PublicKey = publicKey;
            PrivateKey = privateKey;
        }

        public byte[] GetEncodedPublicKey(bool compressed = false)
        {
            return PublicKey.Q.GetEncoded(compressed);
        }

        public static ECKeyPair FromPublicKey(byte[] publicKey)
        {
            ECPublicKeyParameters pubKey
                = new ECPublicKeyParameters(ECParameters.Curve.Curve.DecodePoint(publicKey), ECParameters.DomainParams);

            ECKeyPair k = new ECKeyPair(null, pubKey);

            return k;
        }
        public byte[] GetAddress()
        {
            return GetEncodedPublicKey().Take(AddressLength).ToArray();
        }
        public string GetAddressHex()
        {
            return "0x" + BitConverter.ToString(GetAddress()).Replace("-", string.Empty).ToLower();
        }
    }
}