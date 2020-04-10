using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ShipmentName : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58CB8", Offset="0xF58CB8", VA="0xF58CB8", Slot="5")]
			get
			{
				return null;
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF58CEC", Offset="0xF58CEC", VA="0xF58CEC")]
			get
			{
				return null;
			}
		}

		public ulong ShipmentDef
		{
			[Address(RVA="0xF58CE4", Offset="0xF58CE4", VA="0xF58CE4")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF58CCC", Offset="0xF58CCC", VA="0xF58CCC")]
		public ShipmentName __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentName();
		}

		[Address(RVA="0xF58CC0", Offset="0xF58CC0", VA="0xF58CC0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E9F34", Offset="0x24E9F34", VA="0x24E9F34")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x24E9EF8", Offset="0x24E9EF8", VA="0x24E9EF8")]
		public static void AddShipmentDef(FlatBufferBuilder builder, ulong shipmentDef)
		{
		}

		[Address(RVA="0x24E9E90", Offset="0x24E9E90", VA="0x24E9E90")]
		public static Offset<ShipmentName> CreateShipmentName(FlatBufferBuilder builder, ulong shipment_def = 0L, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ShipmentName> Gamedata.ShipmentName::CreateShipmentName(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ShipmentName> CreateShipmentName(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24E9F70", Offset="0x24E9F70", VA="0x24E9F70")]
		public static Offset<ShipmentName> EndShipmentName(FlatBufferBuilder builder)
		{
			return new Offset<ShipmentName>();
		}

		[Address(RVA="0xF58CF4", Offset="0xF58CF4", VA="0xF58CF4")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x24E9CF8", Offset="0x24E9CF8", VA="0x24E9CF8")]
		public static ShipmentName GetRootAsShipmentName(FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentName();
		}

		[Address(RVA="0x24E9D04", Offset="0x24E9D04", VA="0x24E9D04")]
		public static ShipmentName GetRootAsShipmentName(FlatBuffers.ByteBuffer _bb, ShipmentName obj)
		{
			return new ShipmentName();
		}

		[Address(RVA="0x24E9FF0", Offset="0x24E9FF0", VA="0x24E9FF0")]
		public static void StartShipmentName(FlatBufferBuilder builder)
		{
		}
	}
}