// This file is generated from JsonSchema. Don't modify this source code.
using System;
using System.Collections.Generic;
using UniGLTF;
using UniJSON;

namespace UniGLTF.Extensions.VRMC_materials_mtoon
{

    public class TextureInfo
    {
        // Dictionary object with extension-specific objects.
        public glTFExtension Extensions;

        // Application-specific data.
        public glTFExtension Extras;

        // The index of the texture.
        public int? Index;

        // The set index of texture's TEXCOORD attribute used for texture coordinate mapping.
        public int? TexCoord;
    }

    public class ShadingShiftTextureInfo
    {
        // Dictionary object with extension-specific objects.
        public glTFExtension Extensions;

        // Application-specific data.
        public glTFExtension Extras;

        // The index of the texture.
        public int? Index;

        // The set index of texture's TEXCOORD attribute used for texture coordinate mapping.
        public int? TexCoord;

        // The scalar multiplier applied to the texture.
        public float? Scale;
    }

    public enum OutlineWidthMode
    {
        none,
        worldCoordinates,
        screenCoordinates,

    }

    public class VRMC_materials_mtoon
    {
        public const string ExtensionName = "VRMC_materials_mtoon";
        public static readonly Utf8String ExtensionNameUtf8 = Utf8String.From(ExtensionName);

        // Dictionary object with extension-specific objects.
        public glTFExtension Extensions;

        // Application-specific data.
        public glTFExtension Extras;

        // Meta
        public string Version;

        // enable depth buffer when `alphaMode` is `BLEND`
        public bool? TransparentWithZWrite;

        public int? RenderQueueOffsetNumber;

        public float[] ShadeColorFactor;

        public TextureInfo ShadeMultiplyTexture;

        // Lighting
        public float? ShadingShiftFactor;

        // Reference to a texture.
        public ShadingShiftTextureInfo ShadingShiftTexture;

        public float? ShadingToonyFactor;

        public float? GiIntensityFactor;

        // MatCap
        public TextureInfo MatcapTexture;

        // Rim
        public float[] ParametricRimColorFactor;

        public TextureInfo RimMultiplyTexture;

        public float? RimLightingMixFactor;

        public float? ParametricRimFresnelPowerFactor;

        public float? ParametricRimLiftFactor;

        // Outline
        [JsonSchema(EnumSerializationType = EnumSerializationType.AsString)]
        public OutlineWidthMode OutlineWidthMode;

        public float? OutlineWidthFactor;

        public TextureInfo OutlineWidthMultiplyTexture;

        public float[] OutlineColorFactor;

        public float? OutlineLightingMixFactor;

        public TextureInfo UvAnimationMaskTexture;

        public float? UvAnimationScrollXSpeedFactor;

        public float? UvAnimationScrollYSpeedFactor;

        public float? UvAnimationRotationSpeedFactor;
    }
}
