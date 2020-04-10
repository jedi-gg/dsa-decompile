using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitSelector : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0BDB0", Offset="0xF0BDB0", VA="0xF0BDB0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0BDDC", Offset="0xF0BDDC", VA="0xF0BDDC")]
			get
			{
				return new ulong();
			}
		}

		public int SelectorsLength
		{
			[Address(RVA="0xF0BDEC", Offset="0xF0BDEC", VA="0xF0BDEC")]
			get
			{
				return new int();
			}
		}

		public UnitSlotType SlotType
		{
			[Address(RVA="0xF0BE04", Offset="0xF0BE04", VA="0xF0BE04")]
			get
			{
				return new UnitSlotType();
			}
		}

		public int UnitsLength
		{
			[Address(RVA="0xF0BDFC", Offset="0xF0BDFC", VA="0xF0BDFC")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF0BDC4", Offset="0xF0BDC4", VA="0xF0BDC4")]
		public UnitSelector __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitSelector();
		}

		[Address(RVA="0xF0BDB8", Offset="0xF0BDB8", VA="0xF0BDB8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167D350", Offset="0x167D350", VA="0x167D350")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x167D3C8", Offset="0x167D3C8", VA="0x167D3C8")]
		public static void AddSelectors(FlatBufferBuilder builder, VectorOffset selectorsOffset)
		{
		}

		[Address(RVA="0x167D404", Offset="0x167D404", VA="0x167D404")]
		public static void AddSlotType(FlatBufferBuilder builder, UnitSlotType slotType)
		{
		}

		[Address(RVA="0x167D38C", Offset="0x167D38C", VA="0x167D38C")]
		public static void AddUnits(FlatBufferBuilder builder, VectorOffset unitsOffset)
		{
		}

		[Address(RVA="0x167D4F0", Offset="0x167D4F0", VA="0x167D4F0")]
		public static VectorOffset CreateSelectorsVector(FlatBufferBuilder builder, Offset<UnitSelectorSelectorWeight>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x167D2C0", Offset="0x167D2C0", VA="0x167D2C0")]
		public static Offset<UnitSelector> CreateUnitSelector(FlatBufferBuilder builder, ulong id = 0L, VectorOffset selectorsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitSelector> Gamedata.UnitSelector::CreateUnitSelector(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,Gamedata.UnitSlotType)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitSelector> CreateUnitSelector(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,Gamedata.UnitSlotType)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x167D624", Offset="0x167D624", VA="0x167D624")]
		public static VectorOffset CreateUnitsVector(FlatBufferBuilder builder, Offset<UnitSelectorUnitWeight>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x167D440", Offset="0x167D440", VA="0x167D440")]
		public static Offset<UnitSelector> EndUnitSelector(FlatBufferBuilder builder)
		{
			return new Offset<UnitSelector>();
		}

		[Address(RVA="0x167D758", Offset="0x167D758", VA="0x167D758")]
		public static void FinishUnitSelectorBuffer(FlatBufferBuilder builder, Offset<UnitSelector> offset)
		{
		}

		[Address(RVA="0x167CED8", Offset="0x167CED8", VA="0x167CED8")]
		public static UnitSelector GetRootAsUnitSelector(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitSelector();
		}

		[Address(RVA="0x167CEE4", Offset="0x167CEE4", VA="0x167CEE4")]
		public static UnitSelector GetRootAsUnitSelector(FlatBuffers.ByteBuffer _bb, UnitSelector obj)
		{
			return new UnitSelector();
		}

		[Address(RVA="0xF0BDE4", Offset="0xF0BDE4", VA="0xF0BDE4")]
		public UnitSelectorSelectorWeight? Selectors(int j)
		{
			return null;
		}

		[Address(RVA="0x167D5E8", Offset="0x167D5E8", VA="0x167D5E8")]
		public static void StartSelectorsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x167D4C0", Offset="0x167D4C0", VA="0x167D4C0")]
		public static void StartUnitSelector(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x167D71C", Offset="0x167D71C", VA="0x167D71C")]
		public static void StartUnitsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF0BDF4", Offset="0xF0BDF4", VA="0xF0BDF4")]
		public UnitSelectorUnitWeight? Units(int j)
		{
			return null;
		}
	}
}