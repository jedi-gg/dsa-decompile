using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitGearTier : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0BA28", Offset="0xF0BA28", VA="0xF0BA28", Slot="5")]
			get
			{
				return null;
			}
		}

		public int SlotLength
		{
			[Address(RVA="0xF0BA5C", Offset="0xF0BA5C", VA="0xF0BA5C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF0BA3C", Offset="0xF0BA3C", VA="0xF0BA3C")]
		public UnitGearTier __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitGearTier();
		}

		[Address(RVA="0xF0BA30", Offset="0xF0BA30", VA="0xF0BA30", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x167B7A8", Offset="0x167B7A8", VA="0x167B7A8")]
		public static void AddSlot(FlatBufferBuilder builder, VectorOffset slotOffset)
		{
		}

		[Address(RVA="0x167B894", Offset="0x167B894", VA="0x167B894")]
		public static VectorOffset CreateSlotVector(FlatBufferBuilder builder, Offset<UnitGearSlot>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x167B758", Offset="0x167B758", VA="0x167B758")]
		public static Offset<UnitGearTier> CreateUnitGearTier(FlatBufferBuilder builder, VectorOffset slotOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitGearTier> Gamedata.UnitGearTier::CreateUnitGearTier(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitGearTier> CreateUnitGearTier(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x167B7E4", Offset="0x167B7E4", VA="0x167B7E4")]
		public static Offset<UnitGearTier> EndUnitGearTier(FlatBufferBuilder builder)
		{
			return new Offset<UnitGearTier>();
		}

		[Address(RVA="0x167B594", Offset="0x167B594", VA="0x167B594")]
		public static UnitGearTier GetRootAsUnitGearTier(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitGearTier();
		}

		[Address(RVA="0x167B5A0", Offset="0x167B5A0", VA="0x167B5A0")]
		public static UnitGearTier GetRootAsUnitGearTier(FlatBuffers.ByteBuffer _bb, UnitGearTier obj)
		{
			return new UnitGearTier();
		}

		[Address(RVA="0xF0BA54", Offset="0xF0BA54", VA="0xF0BA54")]
		public UnitGearSlot? Slot(int j)
		{
			return null;
		}

		[Address(RVA="0x167B98C", Offset="0x167B98C", VA="0x167B98C")]
		public static void StartSlotVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x167B864", Offset="0x167B864", VA="0x167B864")]
		public static void StartUnitGearTier(FlatBufferBuilder builder)
		{
		}
	}
}