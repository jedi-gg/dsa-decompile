using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitGearTierMeritItem : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0BAB0", Offset="0xF0BAB0", VA="0xF0BAB0", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Icon
		{
			[Address(RVA="0xF0BAE4", Offset="0xF0BAE4", VA="0xF0BAE4")]
			get
			{
				return null;
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF0BAFC", Offset="0xF0BAFC", VA="0xF0BAFC")]
			get
			{
				return null;
			}
		}

		public UnitStats? Stats
		{
			[Address(RVA="0xF0BB14", Offset="0xF0BB14", VA="0xF0BB14")]
			get
			{
				return null;
			}
		}

		public uint TierGrantedAt
		{
			[Address(RVA="0xF0BADC", Offset="0xF0BADC", VA="0xF0BADC")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF0BAC4", Offset="0xF0BAC4", VA="0xF0BAC4")]
		public UnitGearTierMeritItem __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitGearTierMeritItem();
		}

		[Address(RVA="0xF0BAB8", Offset="0xF0BAB8", VA="0xF0BAB8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167BD58", Offset="0x167BD58", VA="0x167BD58")]
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
		}

		[Address(RVA="0x167BD1C", Offset="0x167BD1C", VA="0x167BD1C")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x167BCE0", Offset="0x167BCE0", VA="0x167BCE0")]
		public static void AddStats(FlatBufferBuilder builder, Offset<UnitStats> statsOffset)
		{
		}

		[Address(RVA="0x167BD94", Offset="0x167BD94", VA="0x167BD94")]
		public static void AddTierGrantedAt(FlatBufferBuilder builder, uint tierGrantedAt)
		{
		}

		[Address(RVA="0x167BC50", Offset="0x167BC50", VA="0x167BC50")]
		public static Offset<UnitGearTierMeritItem> CreateUnitGearTierMeritItem(FlatBufferBuilder builder, uint tier_granted_at = 0, StringOffset iconOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitGearTierMeritItem> Gamedata.UnitGearTierMeritItem::CreateUnitGearTierMeritItem(FlatBuffers.FlatBufferBuilder,System.UInt32,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.Offset`1<Gamedata.UnitStats>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitGearTierMeritItem> CreateUnitGearTierMeritItem(FlatBuffers.FlatBufferBuilder,System.UInt32,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.Offset<Gamedata.UnitStats>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x167BDD0", Offset="0x167BDD0", VA="0x167BDD0")]
		public static Offset<UnitGearTierMeritItem> EndUnitGearTierMeritItem(FlatBufferBuilder builder)
		{
			return new Offset<UnitGearTierMeritItem>();
		}

		[Address(RVA="0xF0BAEC", Offset="0xF0BAEC", VA="0xF0BAEC")]
		public ArraySegment<byte>? GetIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF0BB04", Offset="0xF0BB04", VA="0xF0BB04")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x167B9D0", Offset="0x167B9D0", VA="0x167B9D0")]
		public static UnitGearTierMeritItem GetRootAsUnitGearTierMeritItem(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitGearTierMeritItem();
		}

		[Address(RVA="0x167B9DC", Offset="0x167B9DC", VA="0x167B9DC")]
		public static UnitGearTierMeritItem GetRootAsUnitGearTierMeritItem(FlatBuffers.ByteBuffer _bb, UnitGearTierMeritItem obj)
		{
			return new UnitGearTierMeritItem();
		}

		[Address(RVA="0x167BE50", Offset="0x167BE50", VA="0x167BE50")]
		public static void StartUnitGearTierMeritItem(FlatBufferBuilder builder)
		{
		}
	}
}