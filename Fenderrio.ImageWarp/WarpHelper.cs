using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Fenderrio.ImageWarp
{
	public static class WarpHelper
	{
		[FieldOffset(Offset="0x0")]
		private const string kUILayerName = "UI";

		[FieldOffset(Offset="0x0")]
		private const string kStandardSpritePath = "UI/Skin/UISprite.psd";

		[FieldOffset(Offset="0x0")]
		private const string kBackgroundSpritePath = "UI/Skin/Background.psd";

		[FieldOffset(Offset="0x0")]
		private const string kInputFieldBackgroundPath = "UI/Skin/InputFieldBackground.psd";

		[FieldOffset(Offset="0x0")]
		private const string kKnobPath = "UI/Skin/Knob.psd";

		[FieldOffset(Offset="0x0")]
		private const string kCheckmarkPath = "UI/Skin/Checkmark.psd";

		[FieldOffset(Offset="0x0")]
		private const string kDropdownArrowPath = "UI/Skin/DropdownArrow.psd";

		[FieldOffset(Offset="0x0")]
		private const string kMaskPath = "UI/Skin/UIMask.psd";

		[FieldOffset(Offset="0x0")]
		private static DefaultControls.Resources s_StandardResources;

		[Address(RVA="0x12C5410", Offset="0x12C5410", VA="0x12C5410")]
		public static bool ConvertImageToImageWarp(GameObject imageObject)
		{
			return new bool();
		}

		[Address(RVA="0x12C5850", Offset="0x12C5850", VA="0x12C5850")]
		public static bool ConvertRawImageToRawImageWarp(GameObject imageObject)
		{
			return new bool();
		}

		[Address(RVA="0x12C59F0", Offset="0x12C59F0", VA="0x12C59F0")]
		public static void CopyComponent(RawImage imageFrom, RawImage imageTo)
		{
		}

		[Address(RVA="0x12C55B0", Offset="0x12C55B0", VA="0x12C55B0")]
		public static void CopyComponentTo(Image imageFrom, Image imageTo)
		{
		}
	}
}