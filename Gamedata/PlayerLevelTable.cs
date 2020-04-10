using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PlayerLevelTable : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57A18", Offset="0xF57A18", VA="0xF57A18", Slot="5")]
			get
			{
				return null;
			}
		}

		public int LevelsLength
		{
			[Address(RVA="0xF57A54", Offset="0xF57A54", VA="0xF57A54")]
			get
			{
				return new int();
			}
		}

		public ulong XpInventoryItem
		{
			[Address(RVA="0xF57A44", Offset="0xF57A44", VA="0xF57A44")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF57A2C", Offset="0xF57A2C", VA="0xF57A2C")]
		public PlayerLevelTable __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PlayerLevelTable();
		}

		[Address(RVA="0xF57A20", Offset="0xF57A20", VA="0xF57A20", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DE45C", Offset="0x24DE45C", VA="0x24DE45C")]
		public static void AddLevels(FlatBufferBuilder builder, VectorOffset levelsOffset)
		{
		}

		[Address(RVA="0x24DE420", Offset="0x24DE420", VA="0x24DE420")]
		public static void AddXpInventoryItem(FlatBufferBuilder builder, ulong xpInventoryItem)
		{
		}

		[Address(RVA="0x24DE548", Offset="0x24DE548", VA="0x24DE548")]
		public static VectorOffset CreateLevelsVector(FlatBufferBuilder builder, Offset<PlayerLevelTableEntry>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DE3B8", Offset="0x24DE3B8", VA="0x24DE3B8")]
		public static Offset<PlayerLevelTable> CreatePlayerLevelTable(FlatBufferBuilder builder, ulong xp_inventory_item = 0L, VectorOffset levelsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PlayerLevelTable> Gamedata.PlayerLevelTable::CreatePlayerLevelTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PlayerLevelTable> CreatePlayerLevelTable(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24DE498", Offset="0x24DE498", VA="0x24DE498")]
		public static Offset<PlayerLevelTable> EndPlayerLevelTable(FlatBufferBuilder builder)
		{
			return new Offset<PlayerLevelTable>();
		}

		[Address(RVA="0x24DE158", Offset="0x24DE158", VA="0x24DE158")]
		public static PlayerLevelTable GetRootAsPlayerLevelTable(FlatBuffers.ByteBuffer _bb)
		{
			return new PlayerLevelTable();
		}

		[Address(RVA="0x24DE164", Offset="0x24DE164", VA="0x24DE164")]
		public static PlayerLevelTable GetRootAsPlayerLevelTable(FlatBuffers.ByteBuffer _bb, PlayerLevelTable obj)
		{
			return new PlayerLevelTable();
		}

		[Address(RVA="0xF57A4C", Offset="0xF57A4C", VA="0xF57A4C")]
		public PlayerLevelTableEntry? Levels(int j)
		{
			return null;
		}

		[Address(RVA="0x24DE640", Offset="0x24DE640", VA="0x24DE640")]
		public static void StartLevelsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24DE518", Offset="0x24DE518", VA="0x24DE518")]
		public static void StartPlayerLevelTable(FlatBufferBuilder builder)
		{
		}
	}
}