#nullable enable

using System.CommandLine;

namespace Gamma.CLI.Commands;

internal sealed record SharingOptionsOptionSet(
    Option<global::Gamma.SharingOptionsWorkspaceAccess?> WorkspaceAccess,
                     Option<global::Gamma.SharingOptionsExternalAccess?> ExternalAccess)
{
    public static SharingOptionsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SharingOptionsOptionSet(
                        WorkspaceAccess: new Option<global::Gamma.SharingOptionsWorkspaceAccess?>($"--{normalizedPrefix}workspace-access")
                {
                    Description = @"Default access level for workspace members",
                },
                ExternalAccess: new Option<global::Gamma.SharingOptionsExternalAccess?>($"--{normalizedPrefix}external-access")
                {
                    Description = @"Access level for external users (via shared link)",
                }
        );
    }
}