using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct CpuAlly : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ulong Ai
		{
			[Address(RVA="0xF59A5C", Offset="0xF59A5C", VA="0xF59A5C")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59A20", Offset="0xF59A20", VA="0xF59A20", Slot="5")]
			get
			{
				return null;
			}
		}

		public sbyte PlayerId
		{
			[Address(RVA="0xF59A4C", Offset="0xF59A4C", VA="0xF59A4C")]
			get
			{
				return new sbyte();
			}
		}

		public sbyte PlayerLevel
		{
			[Address(RVA="0xF59A54", Offset="0xF59A54", VA="0xF59A54")]
			get
			{
				return new sbyte();
			}
		}

		public ulong SquadSelector
		{
			[Address(RVA="0xF59A64", Offset="0xF59A64", VA="0xF59A64")]
			get
			{
				return new ulong();
			}
		}

		public UnitStatOverride? Stats
		{
			[Address(RVA="0xF59A6C", Offset="0xF59A6C", VA="0xF59A6C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF59A34", Offset="0xF59A34", VA="0xF59A34")]
		public CpuAlly __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new CpuAlly();
		}

		[Address(RVA="0xF59A28", Offset="0xF59A28", VA="0xF59A28", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x250D178", Offset="0x250D178", VA="0x250D178")]
		public static void AddAi(FlatBufferBuilder builder, ulong ai)
		{
		}

		[Address(RVA="0x250D22C", Offset="0x250D22C", VA="0x250D22C")]
		public static void AddPlayerId(FlatBufferBuilder builder, sbyte playerId)
		{
		}

		[Address(RVA="0x250D1F0", Offset="0x250D1F0", VA="0x250D1F0")]
		public static void AddPlayerLevel(FlatBufferBuilder builder, sbyte playerLevel)
		{
		}

		[Address(RVA="0x250D13C", Offset="0x250D13C", VA="0x250D13C")]
		public static void AddSquadSelector(FlatBufferBuilder builder, ulong squadSelector)
		{
		}

		[Address(RVA="0x250D1B4", Offset="0x250D1B4", VA="0x250D1B4")]
		public static void AddStats(FlatBufferBuilder builder, Offset<UnitStatOverride> statsOffset)
		{
		}

		[Address(RVA="0x250D09C", Offset="0x250D09C", VA="0x250D09C")]
		public static Offset<CpuAlly> CreateCpuAlly(FlatBufferBuilder builder, sbyte player_id = 0, sbyte player_level = 0, ulong ai = 0L, ulong squad_selector = 0L, Offset<UnitStatOverride> statsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.CpuAlly> Gamedata.CpuAlly::CreateCpuAlly(FlatBuffers.FlatBufferBuilder,System.SByte,System.SByte,System.UInt64,System.UInt64,FlatBuffers.Offset`1<Gamedata.UnitStatOverride>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.CpuAlly> CreateCpuAlly(FlatBuffers.FlatBufferBuilder,System.SByte,System.SByte,System.UInt64,System.UInt64,FlatBuffers.Offset<Gamedata.UnitStatOverride>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x250D268", Offset="0x250D268", VA="0x250D268")]
		public static Offset<CpuAlly> EndCpuAlly(FlatBufferBuilder builder)
		{
			return new Offset<CpuAlly>();
		}

		[Address(RVA="0x250CD50", Offset="0x250CD50", VA="0x250CD50")]
		public static CpuAlly GetRootAsCpuAlly(FlatBuffers.ByteBuffer _bb)
		{
			return new CpuAlly();
		}

		[Address(RVA="0x250CD5C", Offset="0x250CD5C", VA="0x250CD5C")]
		public static CpuAlly GetRootAsCpuAlly(FlatBuffers.ByteBuffer _bb, CpuAlly obj)
		{
			return new CpuAlly();
		}

		[Address(RVA="0x250D2E8", Offset="0x250D2E8", VA="0x250D2E8")]
		public static void StartCpuAlly(FlatBufferBuilder builder)
		{
		}
	}
}