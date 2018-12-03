using System;
using System.Linq;
using Google.Protobuf;
using Vakacoin.Core.Helper;

namespace Vakacoin.Account
{
    public class Address
    {
        public ByteString Value;

        public const int AddressLength = 18;

        //Todo change address length
        public Address(byte[] bytes)
        {
            if (bytes.Length < AddressLength)
            {
                throw new ArgumentOutOfRangeException(
                    $"Address bytes has to be at least {AddressLength}. The input is {bytes.Length} bytes long.");
            }

            var toTruncate = bytes.Length - AddressLength;
            Value = ByteString.CopyFrom(bytes.Skip(toTruncate).ToArray());
        }

        public String ToHex()
        {
            return Value.ToByteArray().ToHex();
        }
    }
}