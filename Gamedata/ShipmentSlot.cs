using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ShipmentSlot : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58DE0", Offset="0xF58DE0", VA="0xF58DE0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF58E0C", Offset="0xF58E0C", VA="0xF58E0C")]
			get
			{
				return new ulong();
			}
		}

		public string LockedKey
		{
			[Address(RVA="0xF58E3C", Offset="0xF58E3C", VA="0xF58E3C")]
			get
			{
				return null;
			}
		}

		public int OptionsLength
		{
			[Address(RVA="0xF58E1C", Offset="0xF58E1C", VA="0xF58E1C")]
			get
			{
				return new int();
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF58E24", Offset="0xF58E24", VA="0xF58E24")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF58DF4", Offset="0xF58DF4", VA="0xF58DF4")]
		public ShipmentSlot __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentSlot();
		}

		[Address(RVA="0xF58DE8", Offset="0xF58DE8", VA="0xF58DE8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24EA910", Offset="0x24EA910", VA="0x24EA910")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24EA94C", Offset="0x24EA94C", VA="0x24EA94C")]
		public static void AddLockedKey(FlatBufferBuilder builder, StringOffset lockedKeyOffset)
		{
		}

		[Address(RVA="0x24EA9C4", Offset="0x24EA9C4", VA="0x24EA9C4")]
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
		}

		[Address(RVA="0x24EA988", Offset="0x24EA988", VA="0x24EA988")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x24EAAB0", Offset="0x24EAAB0", VA="0x24EAAB0")]
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<ShipmentSlotItem>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24EA880", Offset="0x24EA880", VA="0x24EA880")]
		public static Offset<ShipmentSlot> CreateShipmentSlot(FlatBufferBuilder builder, ulong id = 0L, VectorOffset optionsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ShipmentSlot> Gamedata.ShipmentSlot::CreateShipmentSlot(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ShipmentSlot> CreateShipmentSlot(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24EAA00", Offset="0x24EAA00", VA="0x24EAA00")]
		public static Offset<ShipmentSlot> EndShipmentSlot(FlatBufferBuilder builder)
		{
			return new Offset<ShipmentSlot>();
		}

		[Address(RVA="0x24EABE4", Offset="0x24EABE4", VA="0x24EABE4")]
		public static void FinishShipmentSlotBuffer(FlatBufferBuilder builder, Offset<ShipmentSlot> offset)
		{
		}

		[Address(RVA="0xF58E44", Offset="0xF58E44", VA="0xF58E44")]
		public ArraySegment<byte>? GetLockedKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF58E2C", Offset="0xF58E2C", VA="0xF58E2C")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x24EA570", Offset="0x24EA570", VA="0x24EA570")]
		public static ShipmentSlot GetRootAsShipmentSlot(FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentSlot();
		}

		[Address(RVA="0x24EA57C", Offset="0x24EA57C", VA="0x24EA57C")]
		public static ShipmentSlot GetRootAsShipmentSlot(FlatBuffers.ByteBuffer _bb, ShipmentSlot obj)
		{
			return new ShipmentSlot();
		}

		[Address(RVA="0xF58E14", Offset="0xF58E14", VA="0xF58E14")]
		public ShipmentSlotItem? Options(int j)
		{
			return null;
		}

		[Address(RVA="0x24EABA8", Offset="0x24EABA8", VA="0x24EABA8")]
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24EAA80", Offset="0x24EAA80", VA="0x24EAA80")]
		public static void StartShipmentSlot(FlatBufferBuilder builder)
		{
		}
	}
}