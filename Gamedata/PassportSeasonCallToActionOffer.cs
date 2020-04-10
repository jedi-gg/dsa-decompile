using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PassportSeasonCallToActionOffer : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57220", Offset="0xF57220", VA="0xF57220", Slot="5")]
			get
			{
				return null;
			}
		}

		public int ImageAssetsLength
		{
			[Address(RVA="0xF57254", Offset="0xF57254", VA="0xF57254")]
			get
			{
				return new int();
			}
		}

		public string LocKey
		{
			[Address(RVA="0xF5725C", Offset="0xF5725C", VA="0xF5725C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF57234", Offset="0xF57234", VA="0xF57234")]
		public PassportSeasonCallToActionOffer __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PassportSeasonCallToActionOffer();
		}

		[Address(RVA="0xF57228", Offset="0xF57228", VA="0xF57228", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D9E84", Offset="0x24D9E84", VA="0x24D9E84")]
		public static void AddImageAssets(FlatBufferBuilder builder, VectorOffset imageAssetsOffset)
		{
		}

		[Address(RVA="0x24D9E48", Offset="0x24D9E48", VA="0x24D9E48")]
		public static void AddLocKey(FlatBufferBuilder builder, StringOffset locKeyOffset)
		{
		}

		[Address(RVA="0x24D9F70", Offset="0x24D9F70", VA="0x24D9F70")]
		public static VectorOffset CreateImageAssetsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D9DE0", Offset="0x24D9DE0", VA="0x24D9DE0")]
		public static Offset<PassportSeasonCallToActionOffer> CreatePassportSeasonCallToActionOffer(FlatBufferBuilder builder, VectorOffset image_assetsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PassportSeasonCallToActionOffer> Gamedata.PassportSeasonCallToActionOffer::CreatePassportSeasonCallToActionOffer(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PassportSeasonCallToActionOffer> CreatePassportSeasonCallToActionOffer(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D9EC0", Offset="0x24D9EC0", VA="0x24D9EC0")]
		public static Offset<PassportSeasonCallToActionOffer> EndPassportSeasonCallToActionOffer(FlatBufferBuilder builder)
		{
			return new Offset<PassportSeasonCallToActionOffer>();
		}

		[Address(RVA="0xF57264", Offset="0xF57264", VA="0xF57264")]
		public ArraySegment<byte>? GetLocKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x24D9C24", Offset="0x24D9C24", VA="0x24D9C24")]
		public static PassportSeasonCallToActionOffer GetRootAsPassportSeasonCallToActionOffer(FlatBuffers.ByteBuffer _bb)
		{
			return new PassportSeasonCallToActionOffer();
		}

		[Address(RVA="0x24D9C30", Offset="0x24D9C30", VA="0x24D9C30")]
		public static PassportSeasonCallToActionOffer GetRootAsPassportSeasonCallToActionOffer(FlatBuffers.ByteBuffer _bb, PassportSeasonCallToActionOffer obj)
		{
			return new PassportSeasonCallToActionOffer();
		}

		[Address(RVA="0xF5724C", Offset="0xF5724C", VA="0xF5724C")]
		public string ImageAssets(int j)
		{
			return null;
		}

		[Address(RVA="0x24DA068", Offset="0x24DA068", VA="0x24DA068")]
		public static void StartImageAssetsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24D9F40", Offset="0x24D9F40", VA="0x24D9F40")]
		public static void StartPassportSeasonCallToActionOffer(FlatBufferBuilder builder)
		{
		}
	}
}