
#nullable enable

namespace Gamma
{
    /// <summary>
    /// Language code for the generated content
    /// </summary>
    public enum TextOptionsLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Af,
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        ArSa,
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Bn,
        /// <summary>
        /// 
        /// </summary>
        Bs,
        /// <summary>
        /// 
        /// </summary>
        Ca,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        Cy,
        /// <summary>
        /// 
        /// </summary>
        Da,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        El,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        EnGb,
        /// <summary>
        /// 
        /// </summary>
        EnIn,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Es419,
        /// <summary>
        /// 
        /// </summary>
        EsEs,
        /// <summary>
        /// 
        /// </summary>
        EsMx,
        /// <summary>
        /// 
        /// </summary>
        Et,
        /// <summary>
        /// 
        /// </summary>
        Fa,
        /// <summary>
        /// 
        /// </summary>
        Fi,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Gu,
        /// <summary>
        /// 
        /// </summary>
        Ha,
        /// <summary>
        /// 
        /// </summary>
        He,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Hr,
        /// <summary>
        /// 
        /// </summary>
        Hu,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Is,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        JaDa,
        /// <summary>
        /// 
        /// </summary>
        Kk,
        /// <summary>
        /// 
        /// </summary>
        Kn,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lv,
        /// <summary>
        /// 
        /// </summary>
        Mk,
        /// <summary>
        /// 
        /// </summary>
        Ml,
        /// <summary>
        /// 
        /// </summary>
        Mr,
        /// <summary>
        /// 
        /// </summary>
        Ms,
        /// <summary>
        /// 
        /// </summary>
        Nb,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        PtPt,
        /// <summary>
        /// 
        /// </summary>
        Ro,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sl,
        /// <summary>
        /// 
        /// </summary>
        Sq,
        /// <summary>
        /// 
        /// </summary>
        Sr,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Sw,
        /// <summary>
        /// 
        /// </summary>
        Ta,
        /// <summary>
        /// 
        /// </summary>
        Te,
        /// <summary>
        /// 
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        Tl,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Ur,
        /// <summary>
        /// 
        /// </summary>
        Uz,
        /// <summary>
        /// 
        /// </summary>
        Vi,
        /// <summary>
        /// 
        /// </summary>
        Yo,
        /// <summary>
        /// 
        /// </summary>
        ZhCn,
        /// <summary>
        /// 
        /// </summary>
        ZhTw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextOptionsLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextOptionsLanguage value)
        {
            return value switch
            {
                TextOptionsLanguage.Af => "af",
                TextOptionsLanguage.Ar => "ar",
                TextOptionsLanguage.ArSa => "ar-sa",
                TextOptionsLanguage.Bg => "bg",
                TextOptionsLanguage.Bn => "bn",
                TextOptionsLanguage.Bs => "bs",
                TextOptionsLanguage.Ca => "ca",
                TextOptionsLanguage.Cs => "cs",
                TextOptionsLanguage.Cy => "cy",
                TextOptionsLanguage.Da => "da",
                TextOptionsLanguage.De => "de",
                TextOptionsLanguage.El => "el",
                TextOptionsLanguage.En => "en",
                TextOptionsLanguage.EnGb => "en-gb",
                TextOptionsLanguage.EnIn => "en-in",
                TextOptionsLanguage.Es => "es",
                TextOptionsLanguage.Es419 => "es-419",
                TextOptionsLanguage.EsEs => "es-es",
                TextOptionsLanguage.EsMx => "es-mx",
                TextOptionsLanguage.Et => "et",
                TextOptionsLanguage.Fa => "fa",
                TextOptionsLanguage.Fi => "fi",
                TextOptionsLanguage.Fr => "fr",
                TextOptionsLanguage.Gu => "gu",
                TextOptionsLanguage.Ha => "ha",
                TextOptionsLanguage.He => "he",
                TextOptionsLanguage.Hi => "hi",
                TextOptionsLanguage.Hr => "hr",
                TextOptionsLanguage.Hu => "hu",
                TextOptionsLanguage.Id => "id",
                TextOptionsLanguage.Is => "is",
                TextOptionsLanguage.It => "it",
                TextOptionsLanguage.Ja => "ja",
                TextOptionsLanguage.JaDa => "ja-da",
                TextOptionsLanguage.Kk => "kk",
                TextOptionsLanguage.Kn => "kn",
                TextOptionsLanguage.Ko => "ko",
                TextOptionsLanguage.Lt => "lt",
                TextOptionsLanguage.Lv => "lv",
                TextOptionsLanguage.Mk => "mk",
                TextOptionsLanguage.Ml => "ml",
                TextOptionsLanguage.Mr => "mr",
                TextOptionsLanguage.Ms => "ms",
                TextOptionsLanguage.Nb => "nb",
                TextOptionsLanguage.Nl => "nl",
                TextOptionsLanguage.Pl => "pl",
                TextOptionsLanguage.PtBr => "pt-br",
                TextOptionsLanguage.PtPt => "pt-pt",
                TextOptionsLanguage.Ro => "ro",
                TextOptionsLanguage.Ru => "ru",
                TextOptionsLanguage.Sl => "sl",
                TextOptionsLanguage.Sq => "sq",
                TextOptionsLanguage.Sr => "sr",
                TextOptionsLanguage.Sv => "sv",
                TextOptionsLanguage.Sw => "sw",
                TextOptionsLanguage.Ta => "ta",
                TextOptionsLanguage.Te => "te",
                TextOptionsLanguage.Th => "th",
                TextOptionsLanguage.Tl => "tl",
                TextOptionsLanguage.Tr => "tr",
                TextOptionsLanguage.Uk => "uk",
                TextOptionsLanguage.Ur => "ur",
                TextOptionsLanguage.Uz => "uz",
                TextOptionsLanguage.Vi => "vi",
                TextOptionsLanguage.Yo => "yo",
                TextOptionsLanguage.ZhCn => "zh-cn",
                TextOptionsLanguage.ZhTw => "zh-tw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextOptionsLanguage? ToEnum(string value)
        {
            return value switch
            {
                "af" => TextOptionsLanguage.Af,
                "ar" => TextOptionsLanguage.Ar,
                "ar-sa" => TextOptionsLanguage.ArSa,
                "bg" => TextOptionsLanguage.Bg,
                "bn" => TextOptionsLanguage.Bn,
                "bs" => TextOptionsLanguage.Bs,
                "ca" => TextOptionsLanguage.Ca,
                "cs" => TextOptionsLanguage.Cs,
                "cy" => TextOptionsLanguage.Cy,
                "da" => TextOptionsLanguage.Da,
                "de" => TextOptionsLanguage.De,
                "el" => TextOptionsLanguage.El,
                "en" => TextOptionsLanguage.En,
                "en-gb" => TextOptionsLanguage.EnGb,
                "en-in" => TextOptionsLanguage.EnIn,
                "es" => TextOptionsLanguage.Es,
                "es-419" => TextOptionsLanguage.Es419,
                "es-es" => TextOptionsLanguage.EsEs,
                "es-mx" => TextOptionsLanguage.EsMx,
                "et" => TextOptionsLanguage.Et,
                "fa" => TextOptionsLanguage.Fa,
                "fi" => TextOptionsLanguage.Fi,
                "fr" => TextOptionsLanguage.Fr,
                "gu" => TextOptionsLanguage.Gu,
                "ha" => TextOptionsLanguage.Ha,
                "he" => TextOptionsLanguage.He,
                "hi" => TextOptionsLanguage.Hi,
                "hr" => TextOptionsLanguage.Hr,
                "hu" => TextOptionsLanguage.Hu,
                "id" => TextOptionsLanguage.Id,
                "is" => TextOptionsLanguage.Is,
                "it" => TextOptionsLanguage.It,
                "ja" => TextOptionsLanguage.Ja,
                "ja-da" => TextOptionsLanguage.JaDa,
                "kk" => TextOptionsLanguage.Kk,
                "kn" => TextOptionsLanguage.Kn,
                "ko" => TextOptionsLanguage.Ko,
                "lt" => TextOptionsLanguage.Lt,
                "lv" => TextOptionsLanguage.Lv,
                "mk" => TextOptionsLanguage.Mk,
                "ml" => TextOptionsLanguage.Ml,
                "mr" => TextOptionsLanguage.Mr,
                "ms" => TextOptionsLanguage.Ms,
                "nb" => TextOptionsLanguage.Nb,
                "nl" => TextOptionsLanguage.Nl,
                "pl" => TextOptionsLanguage.Pl,
                "pt-br" => TextOptionsLanguage.PtBr,
                "pt-pt" => TextOptionsLanguage.PtPt,
                "ro" => TextOptionsLanguage.Ro,
                "ru" => TextOptionsLanguage.Ru,
                "sl" => TextOptionsLanguage.Sl,
                "sq" => TextOptionsLanguage.Sq,
                "sr" => TextOptionsLanguage.Sr,
                "sv" => TextOptionsLanguage.Sv,
                "sw" => TextOptionsLanguage.Sw,
                "ta" => TextOptionsLanguage.Ta,
                "te" => TextOptionsLanguage.Te,
                "th" => TextOptionsLanguage.Th,
                "tl" => TextOptionsLanguage.Tl,
                "tr" => TextOptionsLanguage.Tr,
                "uk" => TextOptionsLanguage.Uk,
                "ur" => TextOptionsLanguage.Ur,
                "uz" => TextOptionsLanguage.Uz,
                "vi" => TextOptionsLanguage.Vi,
                "yo" => TextOptionsLanguage.Yo,
                "zh-cn" => TextOptionsLanguage.ZhCn,
                "zh-tw" => TextOptionsLanguage.ZhTw,
                _ => null,
            };
        }
    }
}