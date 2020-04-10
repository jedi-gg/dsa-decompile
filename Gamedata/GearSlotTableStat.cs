using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct GearSlotTableStat : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5A4A0", Offset="0xF5A4A0", VA="0xF5A4A0", Slot="5")]
			get
			{
				return null;
			}
		}

		public int TierLength
		{
			[Address(RVA="0xF5A4D4", Offset="0xF5A4D4", VA="0xF5A4D4")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF5A4B4", Offset="0xF5A4B4", VA="0xF5A4B4")]
		public GearSlotTableStat __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new GearSlotTableStat();
		}

		[Address(RVA="0xF5A4A8", Offset="0xF5A4A8", VA="0xF5A4A8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2513D68", Offset="0x2513D68", VA="0x2513D68")]
		public static void AddTier(FlatBufferBuilder builder, VectorOffset tierOffset)
		{
		}

		[Address(RVA="0x2513D18", Offset="0x2513D18", VA="0x2513D18")]
		public static Offset<GearSlotTableStat> CreateGearSlotTableStat(FlatBufferBuilder builder, VectorOffset tierOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.GearSlotTableStat> Gamedata.GearSlotTableStat::CreateGearSlotTableStat(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.GearSlotTableStat> CreateGearSlotTableStat(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2513E54", Offset="0x2513E54", VA="0x2513E54")]
		public static VectorOffset CreateTierVector(FlatBufferBuilder builder, Offset<GearSlotTableStatTier>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2513DA4", Offset="0x2513DA4", VA="0x2513DA4")]
		public static Offset<GearSlotTableStat> EndGearSlotTableStat(FlatBufferBuilder builder)
		{
			return new Offset<GearSlotTableStat>();
		}

		[Address(RVA="0x2513B3C", Offset="0x2513B3C", VA="0x2513B3C")]
		public static GearSlotTableStat GetRootAsGearSlotTableStat(FlatBuffers.ByteBuffer _bb)
		{
			return new GearSlotTableStat();
		}

		[Address(RVA="0x2513B48", Offset="0x2513B48", VA="0x2513B48")]
		public static GearSlotTableStat GetRootAsGearSlotTableStat(FlatBuffers.ByteBuffer _bb, GearSlotTableStat obj)
		{
			return new GearSlotTableStat();
		}

		[Address(RVA="0x2513E24", Offset="0x2513E24", VA="0x2513E24")]
		public static void StartGearSlotTableStat(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x2513F4C", Offset="0x2513F4C", VA="0x2513F4C")]
		public static void StartTierVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF5A4CC", Offset="0xF5A4CC", VA="0xF5A4CC")]
		public GearSlotTableStatTier? Tier(int j)
		{
			return null;
		}
	}
}