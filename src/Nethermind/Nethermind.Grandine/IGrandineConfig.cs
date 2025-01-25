using System.Collections.Generic;
using Nethermind.Config;

namespace Nethermind.Grandine
{
    public interface IGrandineConfig : IConfig
    {
        [ConfigItem(Description = "Name of the Eth2 network to connect to")]
        string Network { get; set; }

        [ConfigItem(Description = "Load configuration from YAML_FILE")]
        string ConfigurationFile { get; set; }

        [ConfigItem(Description = "Load configuration from directory")]
        string ConfigurationDirectory { get; set; }

        [ConfigItem(Description = "Verify that Phase 0 variables in preset match YAML_FILE")]
        string VerifyPhase0PresetFile { get; set; }

        [ConfigItem(Description = "Verify that Altair variables in preset match YAML_FILE")]
        string VerifyAltairPresetFile { get; set; }

        [ConfigItem(Description = "Verify that Bellatrix variables in preset match YAML_FILE")]
        string VerifyBellatrixPresetFile { get; set; }

        [ConfigItem(Description = "Verify that Capella variables in preset match YAML_FILE")]
        string VerifyCapellaPresetFile { get; set; }

        [ConfigItem(Description = "Verify that configuration matches YAML_FILE")]
        string VerifyConfigurationFile { get; set; }

        [ConfigItem(Description = "Override TERMINAL_TOTAL_DIFFICULTY")]
        string TerminalTotalDifficultyOverride { get; set; }

        [ConfigItem(Description = "Override TERMINAL_BLOCK_HASH")]
        string TerminalBlockHashOverride { get; set; }

        [ConfigItem(Description = "Override TERMINAL_BLOCK_HASH_ACTIVATION_EPOCH")]
        string TerminalBlockHashActivationEpochOverride { get; set; }

        [ConfigItem(Description = "Start tracking deposit contract from BLOCK_NUMBER")]
        string DepositContractStartingBlock { get; set; }

        [ConfigItem(Description = "Load genesis state from SSZ_FILE")]
        string GenesisStateFile { get; set; }

        [ConfigItem(Description = "Maximum number of empty slots (default: 32)")]
        string MaxEmptySlots { get; set; }

        [ConfigItem(Description = "Beacon node API URL to load recent finalized checkpoint and sync from it")]
        string CheckpointSyncUrl { get; set; }

        [ConfigItem(Description = "Force checkpoint sync. Requires --checkpoint-sync-url")]
        bool ForceCheckpointSync { get; set; }

        [ConfigItem(Description = "List of Eth1 RPC URLs")]
        List<string> Eth1RpcUrls { get; set; }

        [ConfigItem(Description = "Parent directory for application data files")]
        string DataDir { get; set; }

        [ConfigItem(Description = "Directory to store application data files")]
        string StoreDirectory { get; set; }

        [ConfigItem(Description = "Directory to store application network files")]
        string NetworkDir { get; set; }

        [ConfigItem(Description = "Archival epoch interval")]
        string ArchivalEpochInterval { get; set; }

        [ConfigItem(Description = "Enable prune mode where only single checkpoint state & block are stored in the DB")]
        bool PruneStorage { get; set; }

        [ConfigItem(Description = "Number of unfinalized states to keep in memory")]
        string UnfinalizedStatesInMemory { get; set; }

        [ConfigItem(Description = "Max size of the Eth2 database")]
        string Eth2DatabaseSize { get; set; }

        [ConfigItem(Description = "Max size of the Eth1 database")]
        string Eth1DatabaseSize { get; set; }

        [ConfigItem(Description = "Default global request timeout for various services in milliseconds")]
        string RequestTimeout { get; set; }

        [ConfigItem(Description = "HTTP API address")]
        string HttpAddress { get; set; }

        [ConfigItem(Description = "HTTP API port")]
        string HttpPort { get; set; }

        [ConfigItem(Description = "State slot")]
        string StateSlot { get; set; }

        [ConfigItem(Description = "Disable block signature verification pool")]
        bool DisableBlockVerificationPool { get; set; }

        [ConfigItem(Description = "Subscribe to all subnets")]
        bool SubscribeAllSubnets { get; set; }

        [ConfigItem(Description = "Suggested value for the feeRecipient field of the new payload")]
        string SuggestedFeeRecipient { get; set; }

        [ConfigItem(Description = "Optional CL unique identifier to send to EL in the JWT token claim")]
        string JwtId { get; set; }

        [ConfigItem(Description = "Path to a file containing the hex-encoded 256 bit secret key to be used for verifying/generating JWT tokens")]
        string JwtSecret { get; set; }

        [ConfigItem(Description = "Optional CL node type/version to send to EL in the JWT token claim")]
        string JwtVersion { get; set; }

        [ConfigItem(Description = "Enable syncing historical data")]
        bool BackSync { get; set; }

        [ConfigItem(Description = "Collect Prometheus metrics")]
        bool Metrics { get; set; }

        [ConfigItem(Description = "Metrics address for metrics endpoint")]
        string MetricsAddress { get; set; }

        [ConfigItem(Description = "Listen port for metrics endpoint")]
        string MetricsPort { get; set; }

        [ConfigItem(Description = "Optional remote metrics URL that Grandine will periodically send metrics to")]
        string RemoteMetricsUrl { get; set; }

        [ConfigItem(Description = "Enable validator liveness tracking")]
        bool TrackLiveness { get; set; }

        [ConfigItem(Description = "Max number of events stored in a single channel for HTTP API /events api call")]
        string MaxEvents { get; set; }

        [ConfigItem(Description = "HTTP API timeout in milliseconds")]
        string Timeout { get; set; }

        [ConfigItem(Description = "Listen IPv4 address")]
        string ListenAddress { get; set; }

        [ConfigItem(Description = "Listen IPv6 address")]
        string ListenAddressIpv6 { get; set; }

        [ConfigItem(Description = "libp2p IPv4 port")]
        string Libp2pPort { get; set; }

        [ConfigItem(Description = "libp2p IPv6 port")]
        string Libp2pPortIpv6 { get; set; }

        [ConfigItem(Description = "Disable peer scoring")]
        bool DisablePeerScoring { get; set; }

        [ConfigItem(Description = "Disable NAT traversal via UPnP")]
        bool DisableUpnp { get; set; }

        [ConfigItem(Description = "discv5 IPv4 port")]
        string DiscoveryPort { get; set; }

        [ConfigItem(Description = "discv5 IPv6 port")]
        string DiscoveryPortIpv6 { get; set; }

        [ConfigItem(Description = "ENR IPv4 address")]
        string EnrAddress { get; set; }

        [ConfigItem(Description = "ENR IPv6 address")]
        string EnrAddressIpv6 { get; set; }

        [ConfigItem(Description = "ENR TCP IPv4 port")]
        string EnrTcpPort { get; set; }

        [ConfigItem(Description = "ENR TCP IPv6 port")]
        string EnrTcpPortIpv6 { get; set; }

        [ConfigItem(Description = "ENR UDP IPv4 port")]
        string EnrUdpPort { get; set; }

        [ConfigItem(Description = "ENR UDP IPv6 port")]
        string EnrUdpPortIpv6 { get; set; }

        [ConfigItem(Description = "List of ENR boot node addresses")]
        List<string> BootNodes { get; set; }

        [ConfigItem(Description = "List of Multiaddr node addresses")]
        List<string> Libp2pNodes { get; set; }

        [ConfigItem(Description = "Target number of network peers")]
        string TargetPeers { get; set; }

        [ConfigItem(Description = "List of trusted peers")]
        List<string> TrustedPeers { get; set; }

        [ConfigItem(Description = "Enable slasher")]
        bool SlashingEnabled { get; set; }

        [ConfigItem(Description = "Number of epochs for slasher to search for violations")]
        string SlashingHistoryLimit { get; set; }

        [ConfigItem(Description = "Path to a directory containing EIP-2335 keystore files")]
        string KeystoreDir { get; set; }

        [ConfigItem(Description = "Path to a directory containing passwords for keystore files")]
        string KeystorePasswordDir { get; set; }

        [ConfigItem(Description = "Path to a file containing password for keystore files")]
        string KeystorePasswordFile { get; set; }

        [ConfigItem(Description = "Pack extra singular attestations to proposed block")]
        bool PackExtraAttestations { get; set; }

        [ConfigItem(Description = "External block builder API URL")]
        string BuilderApiUrl { get; set; }

        [ConfigItem(Description = "Always use specified external block builder without checking for circuit breaker conditions")]
        bool BuilderDisableChecks { get; set; }

        [ConfigItem(Description = "Max allowed consecutive missing blocks to trigger circuit breaker condition and switch to local execution engine for payload construction")]
        string BuilderMaxSkippedSlots { get; set; }

        [ConfigItem(Description = "Max allowed missing blocks in the last rolling epoch to trigger circuit breaker condition and switch to local execution engine for payload construction")]
        string BuilderMaxSkippedSlotsPerEpoch { get; set; }

        [ConfigItem(Description = "List of Web3Signer API URLs")]
        List<string> Web3SignerApiUrls { get; set; }

        [ConfigItem(Description = "Use validator key cache for faster startup")]
        bool UseValidatorKeyCache { get; set; }

        [ConfigItem(Description = "Graffiti")]
        string Graffiti { get; set; }

        [ConfigItem(Description = "List of optional runtime features to enable")]
        List<string> Features { get; set; }
    }
}