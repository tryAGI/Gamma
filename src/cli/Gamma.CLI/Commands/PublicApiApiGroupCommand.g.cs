#nullable enable

using System.CommandLine;

namespace Gamma.CLI.Commands;

internal static partial class PublicApiApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"public-api", @"public-api endpoint commands.");
                         command.Subcommands.Add(PublicApiCreateFromTemplateGenerationCommandApiCommand.Create());
                         command.Subcommands.Add(PublicApiCreateGenerationCommandApiCommand.Create());
                         command.Subcommands.Add(PublicApiGetGenerationStatusCommandApiCommand.Create());
                         command.Subcommands.Add(PublicApiListFoldersCommandApiCommand.Create());
                         command.Subcommands.Add(PublicApiListThemesCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}