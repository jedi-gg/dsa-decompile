using DG.Tweening;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies
{
	public static class AssetUtil
	{
		[FieldOffset(Offset="0x0")]
		private readonly static Vector3 s_bounceInStartScale;

		[FieldOffset(Offset="0x0")]
		private const float BOUNCE_IN_END_SCALE = 1f;

		[FieldOffset(Offset="0x0")]
		private const float BOUNCE_IN_DURATION = 0.3f;

		[FieldOffset(Offset="0x0")]
		private const float BOUNCE_IN_DELAY = 0.1f;

		[FieldOffset(Offset="0x0")]
		private const Ease BOUNCE_IN_EASE = Ease.OutElastic;

		[Address(RVA="0x14FF3A0", Offset="0x14FF3A0", VA="0x14FF3A0")]
		static AssetUtil()
		{
		}

		[Address(RVA="0x19A1B94", Offset="0x19A1B94", VA="0x19A1B94")]
		public static void LoadTextureAssetIntoRawImage<T>(string assetPath, T registry, RawImage rawImage, float endAlpha = 1f, Action imageSetCallback = // 
		// Current member / type: System.Void Glunies.AssetUtil::LoadTextureAssetIntoRawImage(System.String,T,UnityEngine.UI.RawImage,System.Single,System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void LoadTextureAssetIntoRawImage(System.String,T,UnityEngine.UI.RawImage,System.Single,System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x19A1D98", Offset="0x19A1D98", VA="0x19A1D98")]
		public static void LoadTextureAssetIntoRawImages<T>(string assetPath, T registry, float endAlpha, params RawImage[] rawImages)
		where T : IAssetGetter
		{
		}

		[Address(RVA="0x19A1FC8", Offset="0x19A1FC8", VA="0x19A1FC8")]
		public static void LoadTextureWithPlaceholder<T>(string assetPath, T registry, RawImage rawImage, GameObject placeholder, bool bounceIn = true)
		where T : IAssetGetter
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10510D8", Offset="0x10510D8")]
		private sealed class <>c__DisplayClass0_0<T>
		where T : IAssetGetter
		{
			[FieldOffset(Offset="0x0")]
			public RawImage rawImage;

			[FieldOffset(Offset="0x0")]
			public float endAlpha;

			[FieldOffset(Offset="0x0")]
			public Action imageSetCallback;

			[Address(RVA="0x1BFFC10", Offset="0x1BFFC10", VA="0x1BFFC10")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x1BFFC3C", Offset="0x1BFFC3C", VA="0x1BFFC3C")]
			internal void <LoadTextureAssetIntoRawImage>b__0(AssetHandle assetHandle)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10510E8", Offset="0x10510E8")]
		private sealed class <>c__DisplayClass1_0<T>
		where T : IAssetGetter
		{
			[FieldOffset(Offset="0x0")]
			public RawImage[] rawImages;

			[FieldOffset(Offset="0x0")]
			public float endAlpha;

			[Address(RVA="0x1BFFD64", Offset="0x1BFFD64", VA="0x1BFFD64")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x1BFFD90", Offset="0x1BFFD90", VA="0x1BFFD90")]
			internal void <LoadTextureAssetIntoRawImages>b__0(AssetHandle assetHandle)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10510F8", Offset="0x10510F8")]
		private sealed class <>c__DisplayClass2_0<T>
		where T : IAssetGetter
		{
			[FieldOffset(Offset="0x0")]
			public RawImage rawImage;

			[FieldOffset(Offset="0x0")]
			public bool bounceIn;

			[FieldOffset(Offset="0x0")]
			public GameObject placeholder;

			[FieldOffset(Offset="0x0")]
			public TweenCallback <>9__1;

			[Address(RVA="0x1BFFEE4", Offset="0x1BFFEE4", VA="0x1BFFEE4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x1BFFF10", Offset="0x1BFFF10", VA="0x1BFFF10")]
			internal void <LoadTextureWithPlaceholder>b__0(AssetHandle assetHandle)
			{
			}

			[Address(RVA="0x1C0019C", Offset="0x1C0019C", VA="0x1C0019C")]
			internal void <LoadTextureWithPlaceholder>b__1()
			{
			}
		}
	}
}