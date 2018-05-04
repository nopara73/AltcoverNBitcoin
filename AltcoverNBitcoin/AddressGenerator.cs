using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltcoverNBitcoin
{
    public static class AddressGenerator
    {
        public static string GenerateRandomBech32AddressString(Network network) => new Key().PubKey.GetSegwitAddress(network).ToString();
    }
}
