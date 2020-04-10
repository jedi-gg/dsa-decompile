using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PassportSeasonCallToAction : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string BgImageAsset
		{
			[Address(RVA="0xF571AC", Offset="0xF571AC", VA="0xF571AC")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57180", Offset="0xF57180", VA="0xF57180", Slot="5")]
			get
			{
				return null;
			}
		}

		public int OffersLength
		{
			[Address(RVA="0xF571CC", Offset="0xF571CC", VA="0xF571CC")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF57194", Offset="0xF57194", VA="0xF57194")]
		public PassportSeasonCallToAction __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PassportSeasonCallToAction();
		}

		[Address(RVA="0xF57188", Offset="0xF57188", VA="0xF57188", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D99FC", Offset="0x24D99FC", VA="0x24D99FC")]
		public static void AddBgImageAsset(FlatBufferBuilder builder, StringOffset bgImageAssetOffset)
		{
		}

		[Address(RVA="0x24D99C0", Offset="0x24D99C0", VA="0x24D99C0")]
		public static void AddOffers(FlatBufferBuilder builder, VectorOffset offersOffset)
		{
		}

		[Address(RVA="0x24D9AE8", Offset="0x24D9AE8", VA="0x24D9AE8")]
		public static VectorOffset CreateOffersVector(FlatBufferBuilder builder, Offset<PassportSeasonCallToActionOffer>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D9958", Offset="0x24D9958", VA="0x24D9958")]
		public static Offset<PassportSeasonCallToAction> CreatePassportSeasonCallToAction(FlatBufferBuilder builder, StringOffset bg_image_assetOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PassportSeasonCallToAction> Gamedata.PassportSeasonCallToAction::CreatePassportSeasonCallToAction(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PassportSeasonCallToAction> CreatePassportSeasonCallToAction(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D9A38", Offset="0x24D9A38", VA="0x24D9A38")]
		public static Offset<PassportSeasonCallToAction> EndPassportSeasonCallToAction(FlatBufferBuilder builder)
		{
			return new Offset<PassportSeasonCallToAction>();
		}

		[Address(RVA="0xF571B4", Offset="0xF571B4", VA="0xF571B4")]
		public ArraySegment<byte>? GetBgImageAssetBytes()
		{
			return null;
		}

		[Address(RVA="0x24D9724", Offset="0x24D9724", VA="0x24D9724")]
		public static PassportSeasonCallToAction GetRootAsPassportSeasonCallToAction(FlatBuffers.ByteBuffer _bb)
		{
			return new PassportSeasonCallToAction();
		}

		[Address(RVA="0x24D9730", Offset="0x24D9730", VA="0x24D9730")]
		public static PassportSeasonCallToAction GetRootAsPassportSeasonCallToAction(FlatBuffers.ByteBuffer _bb, PassportSeasonCallToAction obj)
		{
			return new PassportSeasonCallToAction();
		}

		[Address(RVA="0xF571C4", Offset="0xF571C4", VA="0xF571C4")]
		public PassportSeasonCallToActionOffer? Offers(int j)
		{
			return null;
		}

		[Address(RVA="0x24D9BE0", Offset="0x24D9BE0", VA="0x24D9BE0")]
		public static void StartOffersVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24D9AB8", Offset="0x24D9AB8", VA="0x24D9AB8")]
		public static void StartPassportSeasonCallToAction(FlatBufferBuilder builder)
		{
		}
	}
}