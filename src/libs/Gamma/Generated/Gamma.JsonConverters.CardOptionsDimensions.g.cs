#nullable enable

namespace Gamma.JsonConverters
{
    /// <inheritdoc />
    public sealed class CardOptionsDimensionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gamma.CardOptionsDimensions>
    {
        /// <inheritdoc />
        public override global::Gamma.CardOptionsDimensions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Gamma.CardOptionsDimensionsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gamma.CardOptionsDimensions)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gamma.CardOptionsDimensions);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gamma.CardOptionsDimensions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Gamma.CardOptionsDimensionsExtensions.ToValueString(value));
        }
    }
}
