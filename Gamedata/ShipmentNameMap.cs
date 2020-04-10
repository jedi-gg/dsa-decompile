using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ShipmentNameMap : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58D50", Offset="0xF58D50", VA="0xF58D50", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF58D7C", Offset="0xF58D7C", VA="0xF58D7C")]
			get
			{
				return new ulong();
			}
		}

		public int NamesLength
		{
			[Address(RVA="0xF58D8C", Offset="0xF58D8C", VA="0xF58D8C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF58D64", Offset="0xF58D64", VA="0xF58D64")]
		public ShipmentNameMap __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentNameMap();
		}

		[Address(RVA="0xF58D58", Offset="0xF58D58", VA="0xF58D58", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24EA2D8", Offset="0x24EA2D8", VA="0x24EA2D8")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24EA314", Offset="0x24EA314", VA="0x24EA314")]
		public static void AddNames(FlatBufferBuilder builder, VectorOffset namesOffset)
		{
		}

		[Address(RVA="0x24EA400", Offset="0x24EA400", VA="0x24EA400")]
		public static VectorOffset CreateNamesVector(FlatBufferBuilder builder, Offset<ShipmentName>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24EA270", Offset="0x24EA270", VA="0x24EA270")]
		public static Offset<ShipmentNameMap> CreateShipmentNameMap(FlatBufferBuilder builder, ulong id = 0L, VectorOffset namesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ShipmentNameMap> Gamedata.ShipmentNameMap::CreateShipmentNameMap(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ShipmentNameMap> CreateShipmentNameMap(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24EA350", Offset="0x24EA350", VA="0x24EA350")]
		public static Offset<ShipmentNameMap> EndShipmentNameMap(FlatBufferBuilder builder)
		{
			return new Offset<ShipmentNameMap>();
		}

		[Address(RVA="0x24EA534", Offset="0x24EA534", VA="0x24EA534")]
		public static void FinishShipmentNameMapBuffer(FlatBufferBuilder builder, Offset<ShipmentNameMap> offset)
		{
		}

		[Address(RVA="0x24EA028", Offset="0x24EA028", VA="0x24EA028")]
		public static ShipmentNameMap GetRootAsShipmentNameMap(FlatBuffers.ByteBuffer _bb)
		{
			return new ShipmentNameMap();
		}

		[Address(RVA="0x24EA034", Offset="0x24EA034", VA="0x24EA034")]
		public static ShipmentNameMap GetRootAsShipmentNameMap(FlatBuffers.ByteBuffer _bb, ShipmentNameMap obj)
		{
			return new ShipmentNameMap();
		}

		[Address(RVA="0xF58D84", Offset="0xF58D84", VA="0xF58D84")]
		public ShipmentName? Names(int j)
		{
			return null;
		}

		[Address(RVA="0x24EA4F8", Offset="0x24EA4F8", VA="0x24EA4F8")]
		public static void StartNamesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24EA3D0", Offset="0x24EA3D0", VA="0x24EA3D0")]
		public static void StartShipmentNameMap(FlatBufferBuilder builder)
		{
		}
	}
}