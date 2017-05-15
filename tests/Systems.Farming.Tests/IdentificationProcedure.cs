using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace Systems.Farming.Tests
{
    public class IdentificationProcedure
    {
        [Fact]
        public void IdentifySeed()
        {
            SeedBank seedBank = new SeedBank();
            seedBank.Add("Carrot");
            seedBank.Add("Dragonfruit");
            seedBank.Add("Squash");

            ISeed seed = new UnidentifiedSeed();
            ISeed idenitifiedSeed = seedBank.Identify(seed);

            Assert.NotEqual(idenitifiedSeed?.GetType(), typeof(UnidentifiedSeed));
            Debug.WriteLine($"Identified Seed Type: {idenitifiedSeed.SeedType}");
        }
    }
}
