#nullable enable

using System.CommandLine;

namespace Gamma.CLI.Commands;

internal static class PublicApiApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"public-api", @"public-api endpoint commands.");
                         command.Subcommands.Add(PublicApiCreateFromTemplateGenerationCommandApiCommand.Create());
                         command.Subcommands.Add(PublicApiCreateGenerationCommandApiCommand.Create());
                         command.Subcommands.Add(PublicApiGetGenerationStatusCommandApiCommand.Create());
                         command.Subcommands.Add(PublicApiListFoldersCommandApiCommand.Create());
                         command.Subcommands.Add(PublicApiListThemesCommandApiCommand.Create());
        return command;
    }
}