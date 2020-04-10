using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitAbilityAdd : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ulong AddUnitDef
		{
			[Address(RVA="0xF0B364", Offset="0xF0B364", VA="0xF0B364")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0B338", Offset="0xF0B338", VA="0xF0B338", Slot="5")]
			get
			{
				return null;
			}
		}

		public sbyte MaxCount
		{
			[Address(RVA="0xF0B36C", Offset="0xF0B36C", VA="0xF0B36C")]
			get
			{
				return new sbyte();
			}
		}

		public UnitStats? Stats
		{
			[Address(RVA="0xF0B374", Offset="0xF0B374", VA="0xF0B374")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF0B34C", Offset="0xF0B34C", VA="0xF0B34C")]
		public UnitAbilityAdd __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitAbilityAdd();
		}

		[Address(RVA="0xF0B340", Offset="0xF0B340", VA="0xF0B340", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x16771E8", Offset="0x16771E8", VA="0x16771E8")]
		public static void AddAddUnitDef(FlatBufferBuilder builder, ulong addUnitDef)
		{
		}

		[Address(RVA="0x1677260", Offset="0x1677260", VA="0x1677260")]
		public static void AddMaxCount(FlatBufferBuilder builder, sbyte maxCount)
		{
		}

		[Address(RVA="0x1677224", Offset="0x1677224", VA="0x1677224")]
		public static void AddStats(FlatBufferBuilder builder, Offset<UnitStats> statsOffset)
		{
		}

		[Address(RVA="0x1677170", Offset="0x1677170", VA="0x1677170")]
		public static Offset<UnitAbilityAdd> CreateUnitAbilityAdd(FlatBufferBuilder builder, ulong add_unit_def = 0L, sbyte max_count = 0, Offset<UnitStats> statsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitAbilityAdd> Gamedata.UnitAbilityAdd::CreateUnitAbilityAdd(FlatBuffers.FlatBufferBuilder,System.UInt64,System.SByte,FlatBuffers.Offset`1<Gamedata.UnitStats>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitAbilityAdd> CreateUnitAbilityAdd(FlatBuffers.FlatBufferBuilder,System.UInt64,System.SByte,FlatBuffers.Offset<Gamedata.UnitStats>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x167729C", Offset="0x167729C", VA="0x167729C")]
		public static Offset<UnitAbilityAdd> EndUnitAbilityAdd(FlatBufferBuilder builder)
		{
			return new Offset<UnitAbilityAdd>();
		}

		[Address(RVA="0x1676F1C", Offset="0x1676F1C", VA="0x1676F1C")]
		public static UnitAbilityAdd GetRootAsUnitAbilityAdd(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitAbilityAdd();
		}

		[Address(RVA="0x1676F28", Offset="0x1676F28", VA="0x1676F28")]
		public static UnitAbilityAdd GetRootAsUnitAbilityAdd(FlatBuffers.ByteBuffer _bb, UnitAbilityAdd obj)
		{
			return new UnitAbilityAdd();
		}

		[Address(RVA="0x167731C", Offset="0x167731C", VA="0x167731C")]
		public static void StartUnitAbilityAdd(FlatBufferBuilder builder)
		{
		}
	}
}