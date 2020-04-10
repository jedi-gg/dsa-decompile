using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ShipmentLevel : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58C08", Offset="0xF58C08", VA="0xF58C08", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF58C34", Offset="0xF58C34", VA="0xF58C34")]
			get
			{
				return null;
			}
		}

		public int SlotsLength
		{
			[Address(RVA="0xF58C54", Offset="0xF58C54", VA="0xF58C54")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF58C1C", Offset="0xF58C1C", VA="0xF58C1C")]
		public ShipmentLevel __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentLevel();
		}

		[Address(RVA="0xF58C10", Offset="0xF58C10", VA="0xF58C10", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E9AD0", Offset="0x24E9AD0", VA="0x24E9AD0")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x24E9A94", Offset="0x24E9A94", VA="0x24E9A94")]
		public static void AddSlots(FlatBufferBuilder builder, VectorOffset slotsOffset)
		{
		}

		[Address(RVA="0x24E9A2C", Offset="0x24E9A2C", VA="0x24E9A2C")]
		public static Offset<ShipmentLevel> CreateShipmentLevel(FlatBufferBuilder builder, StringOffset requirementOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ShipmentLevel> Gamedata.ShipmentLevel::CreateShipmentLevel(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ShipmentLevel> CreateShipmentLevel(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24E9BBC", Offset="0x24E9BBC", VA="0x24E9BBC")]
		public static VectorOffset CreateSlotsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E9B0C", Offset="0x24E9B0C", VA="0x24E9B0C")]
		public static Offset<ShipmentLevel> EndShipmentLevel(FlatBufferBuilder builder)
		{
			return new Offset<ShipmentLevel>();
		}

		[Address(RVA="0xF58C3C", Offset="0xF58C3C", VA="0xF58C3C")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x24E9844", Offset="0x24E9844", VA="0x24E9844")]
		public static ShipmentLevel GetRootAsShipmentLevel(FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentLevel();
		}

		[Address(RVA="0x24E9850", Offset="0x24E9850", VA="0x24E9850")]
		public static ShipmentLevel GetRootAsShipmentLevel(FlatBuffers.ByteBuffer _bb, ShipmentLevel obj)
		{
			return new ShipmentLevel();
		}

		[Address(RVA="0xF58C5C", Offset="0xF58C5C", VA="0xF58C5C")]
		public ArraySegment<byte>? GetSlotsBytes()
		{
			return null;
		}

		[Address(RVA="0xF58C4C", Offset="0xF58C4C", VA="0xF58C4C")]
		public ulong Slots(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x24E9B8C", Offset="0x24E9B8C", VA="0x24E9B8C")]
		public static void StartShipmentLevel(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24E9CB4", Offset="0x24E9CB4", VA="0x24E9CB4")]
		public static void StartSlotsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}