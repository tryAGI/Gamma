#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Gamma.CLI.Commands;

internal static partial class PublicApiCreateFromTemplateGenerationCommandApiCommand
{
    private static Option<global::Gamma.FromTemplateGenerationExportAs?> ExportAs { get; } = new(
        name: @"--export-as")
    {
        Description = @"Export format for automatic export after generation",
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Text prompt describing what to generate",
        Required = true,
    };

    private static Option<string> GammaId { get; } = new(
        name: @"--gamma-id")
    {
        Description = @"The File ID of the gamma to be used as a template. The File must contain exactly one Page.",
        Required = true,
    };

    private static Option<string?> ThemeId { get; } = new(
        name: @"--theme-id")
    {
        Description = @"Theme ID to apply to the generated Gamma",
    };

    private static Option<global::Gamma.FromTemplateImageOptions?> ImageOptions { get; } = new(
        name: @"--image-options")
    {
        Description = @"Image generation options",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> FolderIds { get; } = new(
        name: @"--folder-ids")
    {
        Description = @"Folder IDs to place the generated Gamma in",
    };
    private static readonly SharingOptionsOptionSet SharingOptionsOptions = SharingOptionsOptionSet.Create(@"sharing");
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Gamma.FromTemplateGenerationResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Gamma.FromTemplateGenerationResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-from-template-generation", @"Create generation from template
Creates an asynchronous generation job from a template Gamma with variable substitution.");
                        command.Options.Add(ExportAs);
                        command.Options.Add(Prompt);
                        command.Options.Add(GammaId);
                        command.Options.Add(ThemeId);
                        command.Options.Add(ImageOptions);
                        command.Options.Add(FolderIds);                        command.Options.Add(SharingOptionsOptions.WorkspaceAccess);
                        command.Options.Add(SharingOptionsOptions.ExternalAccess);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Gamma.FromTemplateGeneration>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Gamma.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var exportAs = CliRuntime.WasSpecified(parseResult, ExportAs) ? parseResult.GetValue(ExportAs) : __requestBase is not null ? __requestBase.ExportAs : default;
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var gammaId = parseResult.GetRequiredValue(GammaId);
                        var themeId = CliRuntime.WasSpecified(parseResult, ThemeId) ? parseResult.GetValue(ThemeId) : __requestBase is not null ? __requestBase.ThemeId : default;
                        var imageOptions = CliRuntime.WasSpecified(parseResult, ImageOptions) ? parseResult.GetValue(ImageOptions) : __requestBase is not null ? __requestBase.ImageOptions : default;
                        var folderIds = CliRuntime.WasSpecified(parseResult, FolderIds) ? parseResult.GetValue(FolderIds) : __requestBase is not null ? __requestBase.FolderIds : default;

                        var __sharingOptionsBase = __requestBase?.SharingOptions;                        var sharingOptionsWorkspaceAccess = CliRuntime.WasSpecified(parseResult, SharingOptionsOptions.WorkspaceAccess) ? parseResult.GetValue(SharingOptionsOptions.WorkspaceAccess) : __sharingOptionsBase is not null ? __sharingOptionsBase.WorkspaceAccess : default;
                        var sharingOptionsExternalAccess = CliRuntime.WasSpecified(parseResult, SharingOptionsOptions.ExternalAccess) ? parseResult.GetValue(SharingOptionsOptions.ExternalAccess) : __sharingOptionsBase is not null ? __sharingOptionsBase.ExternalAccess : default;
                        var __sharingOptionsSpecified = CliRuntime.WasSpecified(parseResult, SharingOptionsOptions.WorkspaceAccess) || CliRuntime.WasSpecified(parseResult, SharingOptionsOptions.ExternalAccess);
                        var sharingOptions =
                            __sharingOptionsSpecified || __sharingOptionsBase is not null
                                ? new global::Gamma.SharingOptions
                                {
                                WorkspaceAccess = sharingOptionsWorkspaceAccess,
                                ExternalAccess = sharingOptionsExternalAccess,
                                }
                                : __sharingOptionsBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateFromTemplateGenerationAsync(
                                    exportAs: exportAs,
                                    prompt: prompt,
                                    gammaId: gammaId,
                                    themeId: themeId,
                                    imageOptions: imageOptions,
                                    folderIds: folderIds,
                                    sharingOptions: sharingOptions,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Gamma.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}