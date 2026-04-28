
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Gamma
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Gamma.JsonConverters.FromTemplateGenerationExportAsJsonConverter),

            typeof(global::Gamma.JsonConverters.FromTemplateGenerationExportAsNullableJsonConverter),

            typeof(global::Gamma.JsonConverters.ImageModelJsonConverter),

            typeof(global::Gamma.JsonConverters.ImageModelNullableJsonConverter),

            typeof(global::Gamma.JsonConverters.SharingOptionsWorkspaceAccessJsonConverter),

            typeof(global::Gamma.JsonConverters.SharingOptionsWorkspaceAccessNullableJsonConverter),

            typeof(global::Gamma.JsonConverters.SharingOptionsExternalAccessJsonConverter),

            typeof(global::Gamma.JsonConverters.SharingOptionsExternalAccessNullableJsonConverter),

            typeof(global::Gamma.JsonConverters.EmailOptionsAccessJsonConverter),

            typeof(global::Gamma.JsonConverters.EmailOptionsAccessNullableJsonConverter),

            typeof(global::Gamma.JsonConverters.GenerationTextModeJsonConverter),

            typeof(global::Gamma.JsonConverters.GenerationTextModeNullableJsonConverter),

            typeof(global::Gamma.JsonConverters.GenerationFormatJsonConverter),

            typeof(global::Gamma.JsonConverters.GenerationFormatNullableJsonConverter),

            typeof(global::Gamma.JsonConverters.GenerationCardSplitJsonConverter),

            typeof(global::Gamma.JsonConverters.GenerationCardSplitNullableJsonConverter),

            typeof(global::Gamma.JsonConverters.GenerationExportAsJsonConverter),

            typeof(global::Gamma.JsonConverters.GenerationExportAsNullableJsonConverter),

            typeof(global::Gamma.JsonConverters.TextOptionsAmountJsonConverter),

            typeof(global::Gamma.JsonConverters.TextOptionsAmountNullableJsonConverter),

            typeof(global::Gamma.JsonConverters.TextOptionsLanguageJsonConverter),

            typeof(global::Gamma.JsonConverters.TextOptionsLanguageNullableJsonConverter),

            typeof(global::Gamma.JsonConverters.ImageOptionsSourceJsonConverter),

            typeof(global::Gamma.JsonConverters.ImageOptionsSourceNullableJsonConverter),

            typeof(global::Gamma.JsonConverters.CardOptionsDimensionsJsonConverter),

            typeof(global::Gamma.JsonConverters.CardOptionsDimensionsNullableJsonConverter),

            typeof(global::Gamma.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.FromTemplateGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.FromTemplateGenerationExportAs), TypeInfoPropertyName = "FromTemplateGenerationExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.FromTemplateImageOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.SharingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.ImageModel), TypeInfoPropertyName = "ImageModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.SharingOptionsWorkspaceAccess), TypeInfoPropertyName = "SharingOptionsWorkspaceAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.SharingOptionsExternalAccess), TypeInfoPropertyName = "SharingOptionsExternalAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.EmailOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.EmailOptionsAccess), TypeInfoPropertyName = "EmailOptionsAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.FromTemplateGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.Generation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.GenerationTextMode), TypeInfoPropertyName = "GenerationTextMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.GenerationFormat), TypeInfoPropertyName = "GenerationFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.GenerationCardSplit), TypeInfoPropertyName = "GenerationCardSplit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.GenerationExportAs), TypeInfoPropertyName = "GenerationExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.TextOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.ImageOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.CardOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.TextOptionsAmount), TypeInfoPropertyName = "TextOptionsAmount2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.TextOptionsLanguage), TypeInfoPropertyName = "TextOptionsLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.ImageOptionsSource), TypeInfoPropertyName = "ImageOptionsSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.CardOptionsDimensions), TypeInfoPropertyName = "CardOptionsDimensions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.HeaderFooter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.HeaderFooterElement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.CreateGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.GenerationStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.CreditsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.ListFoldersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gamma.FolderItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.FolderItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.ListThemesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Gamma.ThemeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Gamma.ThemeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gamma.FolderItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Gamma.ThemeItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}