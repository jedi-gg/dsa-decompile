using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct KothBot : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ulong Avatar
		{
			[Address(RVA="0xF5AD4C", Offset="0xF5AD4C", VA="0xF5AD4C")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5ACF0", Offset="0xF5ACF0", VA="0xF5ACF0", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint CollectionScore
		{
			[Address(RVA="0xF5AD54", Offset="0xF5AD54", VA="0xF5AD54")]
			get
			{
				return new uint();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF5AD1C", Offset="0xF5AD1C", VA="0xF5AD1C")]
			get
			{
				return new ulong();
			}
		}

		public uint InitialRank
		{
			[Address(RVA="0xF5AD24", Offset="0xF5AD24", VA="0xF5AD24")]
			get
			{
				return new uint();
			}
		}

		public string Name
		{
			[Address(RVA="0xF5AD2C", Offset="0xF5AD2C", VA="0xF5AD2C")]
			get
			{
				return null;
			}
		}

		public uint PlayerLevel
		{
			[Address(RVA="0xF5AD44", Offset="0xF5AD44", VA="0xF5AD44")]
			get
			{
				return new uint();
			}
		}

		public int SpellsLength
		{
			[Address(RVA="0xF5AD74", Offset="0xF5AD74", VA="0xF5AD74")]
			get
			{
				return new int();
			}
		}

		public int UnitsLength
		{
			[Address(RVA="0xF5AD64", Offset="0xF5AD64", VA="0xF5AD64")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF5AD04", Offset="0xF5AD04", VA="0xF5AD04")]
		public KothBot __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new KothBot();
		}

		[Address(RVA="0xF5ACF8", Offset="0xF5ACF8", VA="0xF5ACF8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x25192D4", Offset="0x25192D4", VA="0x25192D4")]
		public static void AddAvatar(FlatBufferBuilder builder, ulong avatar)
		{
		}

		[Address(RVA="0x25193C4", Offset="0x25193C4", VA="0x25193C4")]
		public static void AddCollectionScore(FlatBufferBuilder builder, uint collectionScore)
		{
		}

		[Address(RVA="0x2519310", Offset="0x2519310", VA="0x2519310")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x2519478", Offset="0x2519478", VA="0x2519478")]
		public static void AddInitialRank(FlatBufferBuilder builder, uint initialRank)
		{
		}

		[Address(RVA="0x251943C", Offset="0x251943C", VA="0x251943C")]
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
		}

		[Address(RVA="0x2519400", Offset="0x2519400", VA="0x2519400")]
		public static void AddPlayerLevel(FlatBufferBuilder builder, uint playerLevel)
		{
		}

		[Address(RVA="0x251934C", Offset="0x251934C", VA="0x251934C")]
		public static void AddSpells(FlatBufferBuilder builder, VectorOffset spellsOffset)
		{
		}

		[Address(RVA="0x2519388", Offset="0x2519388", VA="0x2519388")]
		public static void AddUnits(FlatBufferBuilder builder, VectorOffset unitsOffset)
		{
		}

		[Address(RVA="0x25191F4", Offset="0x25191F4", VA="0x25191F4")]
		public static Offset<KothBot> CreateKothBot(FlatBufferBuilder builder, ulong id = 0L, uint initial_rank = 0, StringOffset nameOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.KothBot> Gamedata.KothBot::CreateKothBot(FlatBuffers.FlatBufferBuilder,System.UInt64,System.UInt32,FlatBuffers.StringOffset,System.UInt32,System.UInt64,System.UInt32,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.KothBot> CreateKothBot(FlatBuffers.FlatBufferBuilder,System.UInt64,System.UInt32,FlatBuffers.StringOffset,System.UInt32,System.UInt64,System.UInt32,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2519698", Offset="0x2519698", VA="0x2519698")]
		public static VectorOffset CreateSpellsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2519564", Offset="0x2519564", VA="0x2519564")]
		public static VectorOffset CreateUnitsVector(FlatBufferBuilder builder, Offset<KothBotUnit>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x25194B4", Offset="0x25194B4", VA="0x25194B4")]
		public static Offset<KothBot> EndKothBot(FlatBufferBuilder builder)
		{
			return new Offset<KothBot>();
		}

		[Address(RVA="0x25197CC", Offset="0x25197CC", VA="0x25197CC")]
		public static void FinishKothBotBuffer(FlatBufferBuilder builder, Offset<KothBot> offset)
		{
		}

		[Address(RVA="0xF5AD34", Offset="0xF5AD34", VA="0xF5AD34")]
		public ArraySegment<byte>? GetNameBytes()
		{
			return null;
		}

		[Address(RVA="0x2518CC4", Offset="0x2518CC4", VA="0x2518CC4")]
		public static KothBot GetRootAsKothBot(FlatBuffers.ByteBuffer _bb)
		{
			return new KothBot();
		}

		[Address(RVA="0x2518CD0", Offset="0x2518CD0", VA="0x2518CD0")]
		public static KothBot GetRootAsKothBot(FlatBuffers.ByteBuffer _bb, KothBot obj)
		{
			return new KothBot();
		}

		[Address(RVA="0xF5AD7C", Offset="0xF5AD7C", VA="0xF5AD7C")]
		public ArraySegment<byte>? GetSpellsBytes()
		{
			return null;
		}

		[Address(RVA="0xF5AD6C", Offset="0xF5AD6C", VA="0xF5AD6C")]
		public ulong Spells(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x2519534", Offset="0x2519534", VA="0x2519534")]
		public static void StartKothBot(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x2519790", Offset="0x2519790", VA="0x2519790")]
		public static void StartSpellsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x251965C", Offset="0x251965C", VA="0x251965C")]
		public static void StartUnitsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF5AD5C", Offset="0xF5AD5C", VA="0xF5AD5C")]
		public KothBotUnit? Units(int j)
		{
			return null;
		}
	}
}