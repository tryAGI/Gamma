#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Gamma.CLI.Commands;

internal static partial class PublicApiCreateGenerationCommandApiCommand
{
    private static Option<global::Gamma.GenerationTextMode?> TextMode { get; } = new(
        name: @"--text-mode")
    {
        Description = @"How to interpret the input text",
    };

    private static Option<global::Gamma.GenerationFormat?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"Output format for the generated Gamma",
    };

    private static Option<global::Gamma.GenerationCardSplit?> CardSplit { get; } = new(
        name: @"--card-split")
    {
        Description = @"How to split content across cards",
    };

    private static Option<global::Gamma.GenerationExportAs?> ExportAs { get; } = new(
        name: @"--export-as")
    {
        Description = @"Export format for automatic export after generation",
    };

    private static Option<string> InputText { get; } = new(
        name: @"--input-text")
    {
        Description = @"The text content to generate from (topic, outline, or full content)",
        Required = true,
    };

    private static Option<string?> AdditionalInstructions { get; } = new(
        name: @"--additional-instructions")
    {
        Description = @"Additional instructions for the AI",
    };

    private static Option<double?> NumCards { get; } = new(
        name: @"--num-cards")
    {
        Description = @"Target number of cards/slides to generate",
    };

    private static Option<string?> ThemeId { get; } = new(
        name: @"--theme-id")
    {
        Description = @"Theme ID to apply (from /themes endpoint)",
    };

    private static Option<global::Gamma.TextOptions?> TextOptions { get; } = new(
        name: @"--text-options")
    {
        Description = @"Text generation options",
    };

    private static Option<global::Gamma.ImageOptions?> ImageOptions { get; } = new(
        name: @"--image-options")
    {
        Description = @"Image generation and selection options",
    };

    private static Option<global::Gamma.CardOptions?> CardOptions { get; } = new(
        name: @"--card-options")
    {
        Description = @"Card dimensions and layout options",
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

                    private static string FormatResponse(ParseResult parseResult, global::Gamma.CreateGenerationResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Gamma.CreateGenerationResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-generation", @"Create async generation
Creates an asynchronous generation job from provided text input. Returns a generation ID that can be used to poll for status.");
                        command.Options.Add(TextMode);
                        command.Options.Add(Format);
                        command.Options.Add(CardSplit);
                        command.Options.Add(ExportAs);
                        command.Options.Add(InputText);
                        command.Options.Add(AdditionalInstructions);
                        command.Options.Add(NumCards);
                        command.Options.Add(ThemeId);
                        command.Options.Add(TextOptions);
                        command.Options.Add(ImageOptions);
                        command.Options.Add(CardOptions);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Gamma.Generation>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Gamma.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var textMode = CliRuntime.WasSpecified(parseResult, TextMode) ? parseResult.GetValue(TextMode) : (__requestBase is { } __TextModeBaseValue ? __TextModeBaseValue.TextMode : default);
                        var format = CliRuntime.WasSpecified(parseResult, Format) ? parseResult.GetValue(Format) : (__requestBase is { } __FormatBaseValue ? __FormatBaseValue.Format : default);
                        var cardSplit = CliRuntime.WasSpecified(parseResult, CardSplit) ? parseResult.GetValue(CardSplit) : (__requestBase is { } __CardSplitBaseValue ? __CardSplitBaseValue.CardSplit : default);
                        var exportAs = CliRuntime.WasSpecified(parseResult, ExportAs) ? parseResult.GetValue(ExportAs) : (__requestBase is { } __ExportAsBaseValue ? __ExportAsBaseValue.ExportAs : default);
                        var inputText = parseResult.GetRequiredValue(InputText);
                        var additionalInstructions = CliRuntime.WasSpecified(parseResult, AdditionalInstructions) ? parseResult.GetValue(AdditionalInstructions) : (__requestBase is { } __AdditionalInstructionsBaseValue ? __AdditionalInstructionsBaseValue.AdditionalInstructions : default);
                        var numCards = CliRuntime.WasSpecified(parseResult, NumCards) ? parseResult.GetValue(NumCards) : (__requestBase is { } __NumCardsBaseValue ? __NumCardsBaseValue.NumCards : default);
                        var themeId = CliRuntime.WasSpecified(parseResult, ThemeId) ? parseResult.GetValue(ThemeId) : (__requestBase is { } __ThemeIdBaseValue ? __ThemeIdBaseValue.ThemeId : default);
                        var textOptions = CliRuntime.WasSpecified(parseResult, TextOptions) ? parseResult.GetValue(TextOptions) : (__requestBase is { } __TextOptionsBaseValue ? __TextOptionsBaseValue.TextOptions : default);
                        var imageOptions = CliRuntime.WasSpecified(parseResult, ImageOptions) ? parseResult.GetValue(ImageOptions) : (__requestBase is { } __ImageOptionsBaseValue ? __ImageOptionsBaseValue.ImageOptions : default);
                        var cardOptions = CliRuntime.WasSpecified(parseResult, CardOptions) ? parseResult.GetValue(CardOptions) : (__requestBase is { } __CardOptionsBaseValue ? __CardOptionsBaseValue.CardOptions : default);
                        var folderIds = CliRuntime.WasSpecified(parseResult, FolderIds) ? parseResult.GetValue(FolderIds) : (__requestBase is { } __FolderIdsBaseValue ? __FolderIdsBaseValue.FolderIds : default);

                        var __sharingOptionsBase = __requestBase is { } __SharingOptionsBaseValue ? __SharingOptionsBaseValue.SharingOptions : default;                        var sharingOptionsWorkspaceAccess = CliRuntime.WasSpecified(parseResult, SharingOptionsOptions.WorkspaceAccess) ? parseResult.GetValue(SharingOptionsOptions.WorkspaceAccess) : (__sharingOptionsBase is { } __SharingOptionsworkspaceAccessBaseValue ? __SharingOptionsworkspaceAccessBaseValue.WorkspaceAccess : default);
                        var sharingOptionsExternalAccess = CliRuntime.WasSpecified(parseResult, SharingOptionsOptions.ExternalAccess) ? parseResult.GetValue(SharingOptionsOptions.ExternalAccess) : (__sharingOptionsBase is { } __SharingOptionsexternalAccessBaseValue ? __SharingOptionsexternalAccessBaseValue.ExternalAccess : default);
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


                                var response = await client.CreateGenerationAsync(
                                    textMode: textMode,
                                    format: format,
                                    cardSplit: cardSplit,
                                    exportAs: exportAs,
                                    inputText: inputText,
                                    additionalInstructions: additionalInstructions,
                                    numCards: numCards,
                                    themeId: themeId,
                                    textOptions: textOptions,
                                    imageOptions: imageOptions,
                                    cardOptions: cardOptions,
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