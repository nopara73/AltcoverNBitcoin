using NBitcoin;
using System;
using Xunit;

namespace AltcoverNBitcoin.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.StartsWith("bc1", AddressGenerator.GenerateRandomBech32AddressString(Network.Main));
        }
    }
}
