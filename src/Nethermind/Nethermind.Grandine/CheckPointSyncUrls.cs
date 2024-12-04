using System.Collections.Generic;
using System.Collections.Immutable;

namespace Nethermind.Grandine
{
    public static class CheckPointSyncUrls
    {
        public static readonly ImmutableDictionary<string, string> Urls = ImmutableDictionary.CreateRange( 
        [
            new KeyValuePair<string, string>("mainnet", "https://beaconstate.ethstaker.cc"),
            new KeyValuePair<string, string>("holesky", "https://holesky-checkpoint-sync.stakely.io/")
        ]);
    }
}