using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct OfferWallSpecial : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56F50", Offset="0xF56F50", VA="0xF56F50", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong EndTimestampS
		{
			[Address(RVA="0xF56F9C", Offset="0xF56F9C", VA="0xF56F9C")]
			get
			{
				return new ulong();
			}
		}

		public string SpecialTextKey
		{
			[Address(RVA="0xF56F7C", Offset="0xF56F7C", VA="0xF56F7C")]
			get
			{
				return null;
			}
		}

		public ulong StartTimestampS
		{
			[Address(RVA="0xF56F94", Offset="0xF56F94", VA="0xF56F94")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF56F64", Offset="0xF56F64", VA="0xF56F64")]
		public OfferWallSpecial __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new OfferWallSpecial();
		}

		[Address(RVA="0xF56F58", Offset="0xF56F58", VA="0xF56F58", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D837C", Offset="0x24D837C", VA="0x24D837C")]
		public static void AddEndTimestampS(FlatBufferBuilder builder, ulong endTimestampS)
		{
		}

		[Address(RVA="0x24D83F4", Offset="0x24D83F4", VA="0x24D83F4")]
		public static void AddSpecialTextKey(FlatBufferBuilder builder, StringOffset specialTextKeyOffset)
		{
		}

		[Address(RVA="0x24D83B8", Offset="0x24D83B8", VA="0x24D83B8")]
		public static void AddStartTimestampS(FlatBufferBuilder builder, ulong startTimestampS)
		{
		}

		[Address(RVA="0x24D8304", Offset="0x24D8304", VA="0x24D8304")]
		public static Offset<OfferWallSpecial> CreateOfferWallSpecial(FlatBufferBuilder builder, StringOffset special_text_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.OfferWallSpecial> Gamedata.OfferWallSpecial::CreateOfferWallSpecial(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,System.UInt64,System.UInt64)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.OfferWallSpecial> CreateOfferWallSpecial(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,System.UInt64,System.UInt64)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D8430", Offset="0x24D8430", VA="0x24D8430")]
		public static Offset<OfferWallSpecial> EndOfferWallSpecial(FlatBufferBuilder builder)
		{
			return new Offset<OfferWallSpecial>();
		}

		[Address(RVA="0x24D8100", Offset="0x24D8100", VA="0x24D8100")]
		public static OfferWallSpecial GetRootAsOfferWallSpecial(FlatBuffers.ByteBuffer _bb)
		{
			return new OfferWallSpecial();
		}

		[Address(RVA="0x24D810C", Offset="0x24D810C", VA="0x24D810C")]
		public static OfferWallSpecial GetRootAsOfferWallSpecial(FlatBuffers.ByteBuffer _bb, OfferWallSpecial obj)
		{
			return new OfferWallSpecial();
		}

		[Address(RVA="0xF56F84", Offset="0xF56F84", VA="0xF56F84")]
		public ArraySegment<byte>? GetSpecialTextKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x24D84B0", Offset="0x24D84B0", VA="0x24D84B0")]
		public static void StartOfferWallSpecial(FlatBufferBuilder builder)
		{
		}
	}
}