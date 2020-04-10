using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PveBattleSquad : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57F18", Offset="0xF57F18", VA="0xF57F18", Slot="5")]
			get
			{
				return null;
			}
		}

		public sbyte OverrideBossIndex
		{
			[Address(RVA="0xF57F74", Offset="0xF57F74", VA="0xF57F74")]
			get
			{
				return new sbyte();
			}
		}

		public int OverrideSpawnOrderLength
		{
			[Address(RVA="0xF57F84", Offset="0xF57F84", VA="0xF57F84")]
			get
			{
				return new int();
			}
		}

		public int OverrideUnitSlotsLength
		{
			[Address(RVA="0xF57F5C", Offset="0xF57F5C", VA="0xF57F5C")]
			get
			{
				return new int();
			}
		}

		public sbyte PlayerId
		{
			[Address(RVA="0xF57F4C", Offset="0xF57F4C", VA="0xF57F4C")]
			get
			{
				return new sbyte();
			}
		}

		public ulong SquadSelector
		{
			[Address(RVA="0xF57F44", Offset="0xF57F44", VA="0xF57F44")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF57F2C", Offset="0xF57F2C", VA="0xF57F2C")]
		public PveBattleSquad __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PveBattleSquad();
		}

		[Address(RVA="0xF57F20", Offset="0xF57F20", VA="0xF57F20", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E1B74", Offset="0x24E1B74", VA="0x24E1B74")]
		public static void AddOverrideBossIndex(FlatBufferBuilder builder, sbyte overrideBossIndex)
		{
		}

		[Address(RVA="0x24E1AFC", Offset="0x24E1AFC", VA="0x24E1AFC")]
		public static void AddOverrideSpawnOrder(FlatBufferBuilder builder, VectorOffset overrideSpawnOrderOffset)
		{
		}

		[Address(RVA="0x24E1B38", Offset="0x24E1B38", VA="0x24E1B38")]
		public static void AddOverrideUnitSlots(FlatBufferBuilder builder, VectorOffset overrideUnitSlotsOffset)
		{
		}

		[Address(RVA="0x24E1BB0", Offset="0x24E1BB0", VA="0x24E1BB0")]
		public static void AddPlayerId(FlatBufferBuilder builder, sbyte playerId)
		{
		}

		[Address(RVA="0x24E1AC0", Offset="0x24E1AC0", VA="0x24E1AC0")]
		public static void AddSquadSelector(FlatBufferBuilder builder, ulong squadSelector)
		{
		}

		[Address(RVA="0x24E1DD0", Offset="0x24E1DD0", VA="0x24E1DD0")]
		public static VectorOffset CreateOverrideSpawnOrderVector(FlatBufferBuilder builder, sbyte[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E1C9C", Offset="0x24E1C9C", VA="0x24E1C9C")]
		public static VectorOffset CreateOverrideUnitSlotsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E1A20", Offset="0x24E1A20", VA="0x24E1A20")]
		public static Offset<PveBattleSquad> CreatePveBattleSquad(FlatBufferBuilder builder, ulong squad_selector = 0L, sbyte player_id = 0, VectorOffset override_unit_slotsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PveBattleSquad> Gamedata.PveBattleSquad::CreatePveBattleSquad(FlatBuffers.FlatBufferBuilder,System.UInt64,System.SByte,FlatBuffers.VectorOffset,System.SByte,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PveBattleSquad> CreatePveBattleSquad(FlatBuffers.FlatBufferBuilder,System.UInt64,System.SByte,FlatBuffers.VectorOffset,System.SByte,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24E1BEC", Offset="0x24E1BEC", VA="0x24E1BEC")]
		public static Offset<PveBattleSquad> EndPveBattleSquad(FlatBufferBuilder builder)
		{
			return new Offset<PveBattleSquad>();
		}

		[Address(RVA="0xF57F8C", Offset="0xF57F8C", VA="0xF57F8C")]
		public ArraySegment<byte>? GetOverrideSpawnOrderBytes()
		{
			return null;
		}

		[Address(RVA="0xF57F64", Offset="0xF57F64", VA="0xF57F64")]
		public ArraySegment<byte>? GetOverrideUnitSlotsBytes()
		{
			return null;
		}

		[Address(RVA="0x24E1684", Offset="0x24E1684", VA="0x24E1684")]
		public static PveBattleSquad GetRootAsPveBattleSquad(FlatBuffers.ByteBuffer _bb)
		{
			return new PveBattleSquad();
		}

		[Address(RVA="0x24E1690", Offset="0x24E1690", VA="0x24E1690")]
		public static PveBattleSquad GetRootAsPveBattleSquad(FlatBuffers.ByteBuffer _bb, PveBattleSquad obj)
		{
			return new PveBattleSquad();
		}

		[Address(RVA="0xF57F7C", Offset="0xF57F7C", VA="0xF57F7C")]
		public sbyte OverrideSpawnOrder(int j)
		{
			return new sbyte();
		}

		[Address(RVA="0xF57F54", Offset="0xF57F54", VA="0xF57F54")]
		public ulong OverrideUnitSlots(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x24E1ECC", Offset="0x24E1ECC", VA="0x24E1ECC")]
		public static void StartOverrideSpawnOrderVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24E1D94", Offset="0x24E1D94", VA="0x24E1D94")]
		public static void StartOverrideUnitSlotsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24E1C6C", Offset="0x24E1C6C", VA="0x24E1C6C")]
		public static void StartPveBattleSquad(FlatBufferBuilder builder)
		{
		}
	}
}