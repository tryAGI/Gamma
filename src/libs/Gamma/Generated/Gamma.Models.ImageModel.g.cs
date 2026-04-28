
#nullable enable

namespace Gamma
{
    /// <summary>
    /// AI model to use for image generation
    /// </summary>
    public enum ImageModel
    {
        /// <summary>
        /// 
        /// </summary>
        DallE3,
        /// <summary>
        /// 
        /// </summary>
        Flux1Pro,
        /// <summary>
        /// 
        /// </summary>
        Flux1Quick,
        /// <summary>
        /// 
        /// </summary>
        Flux1Ultra,
        /// <summary>
        /// 
        /// </summary>
        Flux2Flex,
        /// <summary>
        /// 
        /// </summary>
        Flux2Klein,
        /// <summary>
        /// 
        /// </summary>
        Flux2Max,
        /// <summary>
        /// 
        /// </summary>
        Flux2Pro,
        /// <summary>
        /// 
        /// </summary>
        FluxKontextFast,
        /// <summary>
        /// 
        /// </summary>
        FluxKontextMax,
        /// <summary>
        /// 
        /// </summary>
        FluxKontextPro,
        /// <summary>
        /// 
        /// </summary>
        Gemini25FlashImage,
        /// <summary>
        /// 
        /// </summary>
        Gemini3ProImage,
        /// <summary>
        /// 
        /// </summary>
        Gemini3ProImageHd,
        /// <summary>
        /// 
        /// </summary>
        Gemini31FlashImage,
        /// <summary>
        /// 
        /// </summary>
        Gemini31FlashImageHd,
        /// <summary>
        /// 
        /// </summary>
        Gemini31FlashImageMini,
        /// <summary>
        /// 
        /// </summary>
        GptImage1High,
        /// <summary>
        /// 
        /// </summary>
        GptImage1Medium,
        /// <summary>
        /// 
        /// </summary>
        GptImage1MiniHigh,
        /// <summary>
        /// 
        /// </summary>
        GptImage1MiniLow,
        /// <summary>
        /// 
        /// </summary>
        GptImage1MiniMedium,
        /// <summary>
        /// 
        /// </summary>
        GptImage2,
        /// <summary>
        /// 
        /// </summary>
        GptImage2Hd,
        /// <summary>
        /// 
        /// </summary>
        GptImage2Mini,
        /// <summary>
        /// 
        /// </summary>
        IdeogramV3,
        /// <summary>
        /// 
        /// </summary>
        IdeogramV3Quality,
        /// <summary>
        /// 
        /// </summary>
        IdeogramV3Turbo,
        /// <summary>
        /// 
        /// </summary>
        Imagen3Flash,
        /// <summary>
        /// 
        /// </summary>
        Imagen3Pro,
        /// <summary>
        /// 
        /// </summary>
        Imagen4Pro,
        /// <summary>
        /// 
        /// </summary>
        Imagen4Ultra,
        /// <summary>
        /// 
        /// </summary>
        LeonardoMotion2,
        /// <summary>
        /// 
        /// </summary>
        LeonardoMotion2Fast,
        /// <summary>
        /// 
        /// </summary>
        LeonardoPhoenix,
        /// <summary>
        /// 
        /// </summary>
        LumaPhoton1,
        /// <summary>
        /// 
        /// </summary>
        LumaPhotonFlash1,
        /// <summary>
        /// 
        /// </summary>
        LumaRay2,
        /// <summary>
        /// 
        /// </summary>
        LumaRay2Flash,
        /// <summary>
        /// 
        /// </summary>
        RecraftV3,
        /// <summary>
        /// 
        /// </summary>
        RecraftV3Svg,
        /// <summary>
        /// 
        /// </summary>
        RecraftV4,
        /// <summary>
        /// 
        /// </summary>
        RecraftV4Pro,
        /// <summary>
        /// 
        /// </summary>
        RecraftV4Svg,
        /// <summary>
        /// 
        /// </summary>
        Veo31,
        /// <summary>
        /// 
        /// </summary>
        Veo31Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageModel value)
        {
            return value switch
            {
                ImageModel.DallE3 => "dall-e-3",
                ImageModel.Flux1Pro => "flux-1-pro",
                ImageModel.Flux1Quick => "flux-1-quick",
                ImageModel.Flux1Ultra => "flux-1-ultra",
                ImageModel.Flux2Flex => "flux-2-flex",
                ImageModel.Flux2Klein => "flux-2-klein",
                ImageModel.Flux2Max => "flux-2-max",
                ImageModel.Flux2Pro => "flux-2-pro",
                ImageModel.FluxKontextFast => "flux-kontext-fast",
                ImageModel.FluxKontextMax => "flux-kontext-max",
                ImageModel.FluxKontextPro => "flux-kontext-pro",
                ImageModel.Gemini25FlashImage => "gemini-2.5-flash-image",
                ImageModel.Gemini3ProImage => "gemini-3-pro-image",
                ImageModel.Gemini3ProImageHd => "gemini-3-pro-image-hd",
                ImageModel.Gemini31FlashImage => "gemini-3.1-flash-image",
                ImageModel.Gemini31FlashImageHd => "gemini-3.1-flash-image-hd",
                ImageModel.Gemini31FlashImageMini => "gemini-3.1-flash-image-mini",
                ImageModel.GptImage1High => "gpt-image-1-high",
                ImageModel.GptImage1Medium => "gpt-image-1-medium",
                ImageModel.GptImage1MiniHigh => "gpt-image-1-mini-high",
                ImageModel.GptImage1MiniLow => "gpt-image-1-mini-low",
                ImageModel.GptImage1MiniMedium => "gpt-image-1-mini-medium",
                ImageModel.GptImage2 => "gpt-image-2",
                ImageModel.GptImage2Hd => "gpt-image-2-hd",
                ImageModel.GptImage2Mini => "gpt-image-2-mini",
                ImageModel.IdeogramV3 => "ideogram-v3",
                ImageModel.IdeogramV3Quality => "ideogram-v3-quality",
                ImageModel.IdeogramV3Turbo => "ideogram-v3-turbo",
                ImageModel.Imagen3Flash => "imagen-3-flash",
                ImageModel.Imagen3Pro => "imagen-3-pro",
                ImageModel.Imagen4Pro => "imagen-4-pro",
                ImageModel.Imagen4Ultra => "imagen-4-ultra",
                ImageModel.LeonardoMotion2 => "leonardo-motion-2",
                ImageModel.LeonardoMotion2Fast => "leonardo-motion-2-fast",
                ImageModel.LeonardoPhoenix => "leonardo-phoenix",
                ImageModel.LumaPhoton1 => "luma-photon-1",
                ImageModel.LumaPhotonFlash1 => "luma-photon-flash-1",
                ImageModel.LumaRay2 => "luma-ray-2",
                ImageModel.LumaRay2Flash => "luma-ray-2-flash",
                ImageModel.RecraftV3 => "recraft-v3",
                ImageModel.RecraftV3Svg => "recraft-v3-svg",
                ImageModel.RecraftV4 => "recraft-v4",
                ImageModel.RecraftV4Pro => "recraft-v4-pro",
                ImageModel.RecraftV4Svg => "recraft-v4-svg",
                ImageModel.Veo31 => "veo-3.1",
                ImageModel.Veo31Fast => "veo-3.1-fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageModel? ToEnum(string value)
        {
            return value switch
            {
                "dall-e-3" => ImageModel.DallE3,
                "flux-1-pro" => ImageModel.Flux1Pro,
                "flux-1-quick" => ImageModel.Flux1Quick,
                "flux-1-ultra" => ImageModel.Flux1Ultra,
                "flux-2-flex" => ImageModel.Flux2Flex,
                "flux-2-klein" => ImageModel.Flux2Klein,
                "flux-2-max" => ImageModel.Flux2Max,
                "flux-2-pro" => ImageModel.Flux2Pro,
                "flux-kontext-fast" => ImageModel.FluxKontextFast,
                "flux-kontext-max" => ImageModel.FluxKontextMax,
                "flux-kontext-pro" => ImageModel.FluxKontextPro,
                "gemini-2.5-flash-image" => ImageModel.Gemini25FlashImage,
                "gemini-3-pro-image" => ImageModel.Gemini3ProImage,
                "gemini-3-pro-image-hd" => ImageModel.Gemini3ProImageHd,
                "gemini-3.1-flash-image" => ImageModel.Gemini31FlashImage,
                "gemini-3.1-flash-image-hd" => ImageModel.Gemini31FlashImageHd,
                "gemini-3.1-flash-image-mini" => ImageModel.Gemini31FlashImageMini,
                "gpt-image-1-high" => ImageModel.GptImage1High,
                "gpt-image-1-medium" => ImageModel.GptImage1Medium,
                "gpt-image-1-mini-high" => ImageModel.GptImage1MiniHigh,
                "gpt-image-1-mini-low" => ImageModel.GptImage1MiniLow,
                "gpt-image-1-mini-medium" => ImageModel.GptImage1MiniMedium,
                "gpt-image-2" => ImageModel.GptImage2,
                "gpt-image-2-hd" => ImageModel.GptImage2Hd,
                "gpt-image-2-mini" => ImageModel.GptImage2Mini,
                "ideogram-v3" => ImageModel.IdeogramV3,
                "ideogram-v3-quality" => ImageModel.IdeogramV3Quality,
                "ideogram-v3-turbo" => ImageModel.IdeogramV3Turbo,
                "imagen-3-flash" => ImageModel.Imagen3Flash,
                "imagen-3-pro" => ImageModel.Imagen3Pro,
                "imagen-4-pro" => ImageModel.Imagen4Pro,
                "imagen-4-ultra" => ImageModel.Imagen4Ultra,
                "leonardo-motion-2" => ImageModel.LeonardoMotion2,
                "leonardo-motion-2-fast" => ImageModel.LeonardoMotion2Fast,
                "leonardo-phoenix" => ImageModel.LeonardoPhoenix,
                "luma-photon-1" => ImageModel.LumaPhoton1,
                "luma-photon-flash-1" => ImageModel.LumaPhotonFlash1,
                "luma-ray-2" => ImageModel.LumaRay2,
                "luma-ray-2-flash" => ImageModel.LumaRay2Flash,
                "recraft-v3" => ImageModel.RecraftV3,
                "recraft-v3-svg" => ImageModel.RecraftV3Svg,
                "recraft-v4" => ImageModel.RecraftV4,
                "recraft-v4-pro" => ImageModel.RecraftV4Pro,
                "recraft-v4-svg" => ImageModel.RecraftV4Svg,
                "veo-3.1" => ImageModel.Veo31,
                "veo-3.1-fast" => ImageModel.Veo31Fast,
                _ => null,
            };
        }
    }
}