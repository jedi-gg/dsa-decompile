using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct GearSlotTableStatTier : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5A528", Offset="0xF5A528", VA="0xF5A528", Slot="5")]
			get
			{
				return null;
			}
		}

		public int ValueLength
		{
			[Address(RVA="0xF5A55C", Offset="0xF5A55C", VA="0xF5A55C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF5A53C", Offset="0xF5A53C", VA="0xF5A53C")]
		public GearSlotTableStatTier __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new GearSlotTableStatTier();
		}

		[Address(RVA="0xF5A530", Offset="0xF5A530", VA="0xF5A530", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2514170", Offset="0x2514170", VA="0x2514170")]
		public static void AddValue(FlatBufferBuilder builder, VectorOffset valueOffset)
		{
		}

		[Address(RVA="0x2514120", Offset="0x2514120", VA="0x2514120")]
		public static Offset<GearSlotTableStatTier> CreateGearSlotTableStatTier(FlatBufferBuilder builder, VectorOffset valueOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.GearSlotTableStatTier> Gamedata.GearSlotTableStatTier::CreateGearSlotTableStatTier(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.GearSlotTableStatTier> CreateGearSlotTableStatTier(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x251425C", Offset="0x251425C", VA="0x251425C")]
		public static VectorOffset CreateValueVector(FlatBufferBuilder builder, float[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x25141AC", Offset="0x25141AC", VA="0x25141AC")]
		public static Offset<GearSlotTableStatTier> EndGearSlotTableStatTier(FlatBufferBuilder builder)
		{
			return new Offset<GearSlotTableStatTier>();
		}

		[Address(RVA="0x2513F90", Offset="0x2513F90", VA="0x2513F90")]
		public static GearSlotTableStatTier GetRootAsGearSlotTableStatTier(FlatBuffers.ByteBuffer _bb)
		{
			return new GearSlotTableStatTier();
		}

		[Address(RVA="0x2513F9C", Offset="0x2513F9C", VA="0x2513F9C")]
		public static GearSlotTableStatTier GetRootAsGearSlotTableStatTier(FlatBuffers.ByteBuffer _bb, GearSlotTableStatTier obj)
		{
			return new GearSlotTableStatTier();
		}

		[Address(RVA="0xF5A564", Offset="0xF5A564", VA="0xF5A564")]
		public ArraySegment<byte>? GetValueBytes()
		{
			return null;
		}

		[Address(RVA="0x251422C", Offset="0x251422C", VA="0x251422C")]
		public static void StartGearSlotTableStatTier(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x2514354", Offset="0x2514354", VA="0x2514354")]
		public static void StartValueVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF5A554", Offset="0xF5A554", VA="0xF5A554")]
		public float Value(int j)
		{
			return new float();
		}
	}
}