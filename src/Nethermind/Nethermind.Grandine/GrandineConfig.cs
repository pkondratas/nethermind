using System.Collections.Generic;

namespace Nethermind.Grandine
{
    public class GrandineConfig : IGrandineConfig
    {
        [GrandineCliOption(OptionName = "--network")]
        [NethermindCliOption(OptionName = "--Grandine.Network")]
        public string Network { get; set; }

        [GrandineCliOption(OptionName = "--configuration-file")]
        [NethermindCliOption(OptionName = "--Grandine.ConfigurationFile")]
        public string ConfigurationFile { get; set; }

        [GrandineCliOption(OptionName = "--configuration-directory")]
        [NethermindCliOption(OptionName = "--Grandine.ConfigurationDirectory")]
        public string ConfigurationDirectory { get; set; }

        [GrandineCliOption(OptionName = "--verify-phase0-preset-file")]
        [NethermindCliOption(OptionName = "--Grandine.VerifyPhase0PresetFile")]
        public string VerifyPhase0PresetFile { get; set; }

        [GrandineCliOption(OptionName = "--verify-altair-preset-file")]
        [NethermindCliOption(OptionName = "--Grandine.VerifyAltairPresetFile")]
        public string VerifyAltairPresetFile { get; set; }

        [GrandineCliOption(OptionName = "--verify-bellatrix-preset-file")]
        [NethermindCliOption(OptionName = "--Grandine.VerifyBellatrixPresetFile")]
        public string VerifyBellatrixPresetFile { get; set; }

        [GrandineCliOption(OptionName = "--verify-capella-preset-file")]
        [NethermindCliOption(OptionName = "--Grandine.VerifyCapellaPresetFile")]
        public string VerifyCapellaPresetFile { get; set; }

        [GrandineCliOption(OptionName = "--verify-configuration-file")]
        [NethermindCliOption(OptionName = "--Grandine.VerifyConfigurationFile")]
        public string VerifyConfigurationFile { get; set; }

        [GrandineCliOption(OptionName = "--terminal-total-difficulty-override")]
        [NethermindCliOption(OptionName = "--Grandine.TerminalTotalDifficultyOverride")]
        public string TerminalTotalDifficultyOverride { get; set; }

        [GrandineCliOption(OptionName = "--terminal-block-hash-override")]
        [NethermindCliOption(OptionName = "--Grandine.TerminalBlockHashOverride")]
        public string TerminalBlockHashOverride { get; set; }

        [GrandineCliOption(OptionName = "--terminal-block-hash-activation-epoch-override")]
        [NethermindCliOption(OptionName = "--Grandine.TerminalBlockHashActivationEpochOverride")]
        public string TerminalBlockHashActivationEpochOverride { get; set; }

        [GrandineCliOption(OptionName = "--deposit-contract-starting-block")]
        [NethermindCliOption(OptionName = "--Grandine.DepositContractStartingBlock")]
        public string DepositContractStartingBlock { get; set; }

        [GrandineCliOption(OptionName = "--genesis-state-file")]
        [NethermindCliOption(OptionName = "--Grandine.GenesisStateFile")]
        public string GenesisStateFile { get; set; }

        [GrandineCliOption(OptionName = "--max-empty-slots")]
        [NethermindCliOption(OptionName = "--Grandine.MaxEmptySlots")]
        public string MaxEmptySlots { get; set; }

        [GrandineCliOption(OptionName = "--checkpoint-sync-url")]
        [NethermindCliOption(OptionName = "--Grandine.CheckpointSyncUrl")]
        public string CheckpointSyncUrl { get; set; }

        [GrandineCliOption(OptionName = "--force-checkpoint-sync")]
        [NethermindCliOption(OptionName = "--Grandine.ForceCheckpointSync", IsFlag = true)]
        public bool ForceCheckpointSync { get; set; }

        [GrandineCliOption(OptionName = "--eth1-rpc-urls")]
        [NethermindCliOption(OptionName = "--Grandine.Eth1RpcUrls")]
        public List<string> Eth1RpcUrls { get; set; }

        [GrandineCliOption(OptionName = "--data-dir")]
        [NethermindCliOption(OptionName = "--Grandine.DataDir")]
        public string DataDir { get; set; }

        [GrandineCliOption(OptionName = "--store-directory")]
        [NethermindCliOption(OptionName = "--Grandine.StoreDirectory")]
        public string StoreDirectory { get; set; }

        [GrandineCliOption(OptionName = "--network-dir")]
        [NethermindCliOption(OptionName = "--Grandine.NetworkDir")]
        public string NetworkDir { get; set; }

        [GrandineCliOption(OptionName = "--archival-epoch-interval")]
        [NethermindCliOption(OptionName = "--Grandine.ArchivalEpochInterval")]
        public string ArchivalEpochInterval { get; set; }

        [GrandineCliOption(OptionName = "--prune-storage")]
        [NethermindCliOption(OptionName = "--Grandine.PruneStorage", IsFlag = true)]
        public bool PruneStorage { get; set; }

        [GrandineCliOption(OptionName = "--unfinalized-states-in-memory")]
        [NethermindCliOption(OptionName = "--Grandine.UnfinalizedStatesInMemory")]
        public string UnfinalizedStatesInMemory { get; set; }

        [GrandineCliOption(OptionName = "--database-size")]
        [NethermindCliOption(OptionName = "--Grandine.Eth2DatabaseSize")]
        public string Eth2DatabaseSize { get; set; }

        [GrandineCliOption(OptionName = "--eth1-database-size")]
        [NethermindCliOption(OptionName = "--Grandine.Eth1DatabaseSize")]
        public string Eth1DatabaseSize { get; set; }

        [GrandineCliOption(OptionName = "--request-timeout")]
        [NethermindCliOption(OptionName = "--Grandine.RequestTimeout")]
        public string RequestTimeout { get; set; }

        [GrandineCliOption(OptionName = "--http-address")]
        [NethermindCliOption(OptionName = "--Grandine.HttpAddress")]
        public string HttpAddress { get; set; }

        [GrandineCliOption(OptionName = "--http-port")]
        [NethermindCliOption(OptionName = "--Grandine.HttpPort")]
        public string HttpPort { get; set; }

        [GrandineCliOption(OptionName = "--state-slot")]
        [NethermindCliOption(OptionName = "--Grandine.StateSlot")]
        public string StateSlot { get; set; }

        [GrandineCliOption(OptionName = "--disable-block-verification-pool")]
        [NethermindCliOption(OptionName = "--Grandine.DisableBlockVerificationPool", IsFlag = true)]
        public bool DisableBlockVerificationPool { get; set; }

        [GrandineCliOption(OptionName = "--subscribe-all-subnets")]
        [NethermindCliOption(OptionName = "--Grandine.SubscribeAllSubnets", IsFlag = true)]
        public bool SubscribeAllSubnets { get; set; }

        [GrandineCliOption(OptionName = "--suggested-fee-recipient")]
        [NethermindCliOption(OptionName = "--Grandine.SuggestedFeeRecipient")]
        public string SuggestedFeeRecipient { get; set; }

        [GrandineCliOption(OptionName = "--jwt-id")]
        [NethermindCliOption(OptionName = "--Grandine.JwtId")]
        public string JwtId { get; set; }

        [GrandineCliOption(OptionName = "--jwt-secret")]
        [NethermindCliOption(OptionName = "--Grandine.JwtSecret")]
        public string JwtSecret { get; set; }

        [GrandineCliOption(OptionName = "--jwt-version")]
        [NethermindCliOption(OptionName = "--Grandine.JwtVersion")]
        public string JwtVersion { get; set; }

        [GrandineCliOption(OptionName = "--back-sync")]
        [NethermindCliOption(OptionName = "--Grandine.BackSync", IsFlag = true)]
        public bool BackSync { get; set; }

        [GrandineCliOption(OptionName = "--metrics")]
        [NethermindCliOption(OptionName = "--Grandine.Metrics", IsFlag = true)]
        public bool Metrics { get; set; }

        [GrandineCliOption(OptionName = "--metrics-address")]
        [NethermindCliOption(OptionName = "--Grandine.MetricsAddress")]
        public string MetricsAddress { get; set; }

        [GrandineCliOption(OptionName = "--metrics-port")]
        [NethermindCliOption(OptionName = "--Grandine.MetricsPort")]
        public string MetricsPort { get; set; }

        [GrandineCliOption(OptionName = "--remote-metrics-url")]
        [NethermindCliOption(OptionName = "--Grandine.RemoteMetricsUrl")]
        public string RemoteMetricsUrl { get; set; }

        [GrandineCliOption(OptionName = "--track-liveness")]
        [NethermindCliOption(OptionName = "--Grandine.TrackLiveness", IsFlag = true)]
        public bool TrackLiveness { get; set; }

        [GrandineCliOption(OptionName = "--max-events")]
        [NethermindCliOption(OptionName = "--Grandine.MaxEvents")]
        public string MaxEvents { get; set; }

        [GrandineCliOption(OptionName = "--timeout")]
        [NethermindCliOption(OptionName = "--Grandine.Timeout")]
        public string Timeout { get; set; }

        [GrandineCliOption(OptionName = "--listen-address")]
        [NethermindCliOption(OptionName = "--Grandine.ListenAddress")]
        public string ListenAddress { get; set; }

        [GrandineCliOption(OptionName = "--listen-address-ipv6")]
        [NethermindCliOption(OptionName = "--Grandine.ListenAddressIpv6")]
        public string ListenAddressIpv6 { get; set; }

        [GrandineCliOption(OptionName = "--libp2p-port")]
        [NethermindCliOption(OptionName = "--Grandine.Libp2pPort")]
        public string Libp2pPort { get; set; }

        [GrandineCliOption(OptionName = "--libp2p-port-ipv6")]
        [NethermindCliOption(OptionName = "--Grandine.Libp2pPortIpv6")]
        public string Libp2pPortIpv6 { get; set; }

        [GrandineCliOption(OptionName = "--disable-peer-scoring")]
        [NethermindCliOption(OptionName = "--Grandine.DisablePeerScoring", IsFlag = true)]
        public bool DisablePeerScoring { get; set; }

        [GrandineCliOption(OptionName = "--disable-upnp")]
        [NethermindCliOption(OptionName = "--Grandine.DisableUpnp", IsFlag = true)]
        public bool DisableUpnp { get; set; }

        [GrandineCliOption(OptionName = "--discovery-port")]
        [NethermindCliOption(OptionName = "--Grandine.DiscoveryPort")]
        public string DiscoveryPort { get; set; }

        [GrandineCliOption(OptionName = "--discovery-port-ipv6")]
        [NethermindCliOption(OptionName = "--Grandine.DiscoveryPortIpv6")]
        public string DiscoveryPortIpv6 { get; set; }

        [GrandineCliOption(OptionName = "--enr-address")]
        [NethermindCliOption(OptionName = "--Grandine.EnrAddress")]
        public string EnrAddress { get; set; }

        [GrandineCliOption(OptionName = "--enr-address-ipv6")]
        [NethermindCliOption(OptionName = "--Grandine.EnrAddressIpv6")]
        public string EnrAddressIpv6 { get; set; }

        [GrandineCliOption(OptionName = "--enr-tcp-port")]
        [NethermindCliOption(OptionName = "--Grandine.EnrTcpPort")]
        public string EnrTcpPort { get; set; }

        [GrandineCliOption(OptionName = "--enr-tcp-port-ipv6")]
        [NethermindCliOption(OptionName = "--Grandine.EnrTcpPortIpv6")]
        public string EnrTcpPortIpv6 { get; set; }

        [GrandineCliOption(OptionName = "--enr-udp-port")]
        [NethermindCliOption(OptionName = "--Grandine.EnrUdpPort")]
        public string EnrUdpPort { get; set; }

        [GrandineCliOption(OptionName = "--enr-udp-port-ipv6")]
        [NethermindCliOption(OptionName = "--Grandine.EnrUdpPortIpv6")]
        public string EnrUdpPortIpv6 { get; set; }

        [GrandineCliOption(OptionName = "--boot-nodes")]
        [NethermindCliOption(OptionName = "--Grandine.BootNodes")]
        public List<string> BootNodes { get; set; }

        [GrandineCliOption(OptionName = "--libp2p-nodes")]
        [NethermindCliOption(OptionName = "--Grandine.Libp2pNodes")]
        public List<string> Libp2pNodes { get; set; }

        [GrandineCliOption(OptionName = "--target-peers")]
        [NethermindCliOption(OptionName = "--Grandine.TargetPeers")]
        public string TargetPeers { get; set; }

        [GrandineCliOption(OptionName = "--trusted-peers")]
        [NethermindCliOption(OptionName = "--Grandine.TrustedPeers")]
        public List<string> TrustedPeers { get; set; }

        [GrandineCliOption(OptionName = "--slashing-enabled")]
        [NethermindCliOption(OptionName = "--Grandine.SlashingEnabled", IsFlag = true)]
        public bool SlashingEnabled { get; set; }

        [GrandineCliOption(OptionName = "--slashing-history-limit")]
        [NethermindCliOption(OptionName = "--Grandine.SlashingHistoryLimit")]
        public string SlashingHistoryLimit { get; set; }

        [GrandineCliOption(OptionName = "--keystore-dir")]
        [NethermindCliOption(OptionName = "--Grandine.KeystoreDir")]
        public string KeystoreDir { get; set; }

        [GrandineCliOption(OptionName = "--keystore-password-dir")]
        [NethermindCliOption(OptionName = "--Grandine.KeystorePasswordDir")]
        public string KeystorePasswordDir { get; set; }

        [GrandineCliOption(OptionName = "--keystore-password-file")]
        [NethermindCliOption(OptionName = "--Grandine.KeystorePasswordFile")]
        public string KeystorePasswordFile { get; set; }

        [GrandineCliOption(OptionName = "--pack-extra-attestations")]
        [NethermindCliOption(OptionName = "--Grandine.PackExtraAttestations", IsFlag = true)]
        public bool PackExtraAttestations { get; set; }

        [GrandineCliOption(OptionName = "--builder-api-url")]
        [NethermindCliOption(OptionName = "--Grandine.BuilderApiUrl")]
        public string BuilderApiUrl { get; set; }

        [GrandineCliOption(OptionName = "--builder-disable-checks")]
        [NethermindCliOption(OptionName = "--Grandine.BuilderDisableChecks", IsFlag = true)]
        public bool BuilderDisableChecks { get; set; }

        [GrandineCliOption(OptionName = "--builder-max-skipped-slots")]
        [NethermindCliOption(OptionName = "--Grandine.BuilderMaxSkippedSlots")]
        public string BuilderMaxSkippedSlots { get; set; }

        [GrandineCliOption(OptionName = "--builder-max-skipped-slots-per-epoch")]
        [NethermindCliOption(OptionName = "--Grandine.BuilderMaxSkippedSlotsPerEpoch")]
        public string BuilderMaxSkippedSlotsPerEpoch { get; set; }

        [GrandineCliOption(OptionName = "--web3signer-api-urls")]
        [NethermindCliOption(OptionName = "--Grandine.Web3SignerApiUrls")]
        public List<string> Web3SignerApiUrls { get; set; }

        [GrandineCliOption(OptionName = "--use-validator-key-cache")]
        [NethermindCliOption(OptionName = "--Grandine.UseValidatorKeyCache", IsFlag = true)]
        public bool UseValidatorKeyCache { get; set; }

        [GrandineCliOption(OptionName = "--graffiti")]
        [NethermindCliOption(OptionName = "--Grandine.Graffiti")]
        public string Graffiti { get; set; }

        [GrandineCliOption(OptionName = "--features")]
        [NethermindCliOption(OptionName = "--Grandine.Features")]
        public List<string> Features { get; set; }
    }
}