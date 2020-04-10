using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct StoreShelfDef : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public bool AlwaysAvailable
		{
			[Address(RVA="0xF3B124", Offset="0xF3B124", VA="0xF3B124")]
			get
			{
				return new bool();
			}
		}

		public int AvailableOccasionsLength
		{
			[Address(RVA="0xF3B11C", Offset="0xF3B11C", VA="0xF3B11C")]
			get
			{
				return new int();
			}
		}

		public string Background
		{
			[Address(RVA="0xF3B0DC", Offset="0xF3B0DC", VA="0xF3B0DC")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3B090", Offset="0xF3B090", VA="0xF3B090", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF3B0BC", Offset="0xF3B0BC", VA="0xF3B0BC")]
			get
			{
				return new ulong();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF3B0C4", Offset="0xF3B0C4", VA="0xF3B0C4")]
			get
			{
				return null;
			}
		}

		public int StoreItemsLength
		{
			[Address(RVA="0xF3B0FC", Offset="0xF3B0FC", VA="0xF3B0FC")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF3B0A4", Offset="0xF3B0A4", VA="0xF3B0A4")]
		public StoreShelfDef __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new StoreShelfDef();
		}

		[Address(RVA="0xF3B098", Offset="0xF3B098", VA="0xF3B098", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22EA734", Offset="0x22EA734", VA="0x22EA734")]
		public static void AddAlwaysAvailable(FlatBufferBuilder builder, bool alwaysAvailable)
		{
		}

		[Address(RVA="0x22EA644", Offset="0x22EA644", VA="0x22EA644")]
		public static void AddAvailableOccasions(FlatBufferBuilder builder, VectorOffset availableOccasionsOffset)
		{
		}

		[Address(RVA="0x22EA6BC", Offset="0x22EA6BC", VA="0x22EA6BC")]
		public static void AddBackground(FlatBufferBuilder builder, StringOffset backgroundOffset)
		{
		}

		[Address(RVA="0x22EA608", Offset="0x22EA608", VA="0x22EA608")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x22EA6F8", Offset="0x22EA6F8", VA="0x22EA6F8")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x22EA680", Offset="0x22EA680", VA="0x22EA680")]
		public static void AddStoreItems(FlatBufferBuilder builder, VectorOffset storeItemsOffset)
		{
		}

		[Address(RVA="0xF3B114", Offset="0xF3B114", VA="0xF3B114")]
		public OccasionRef? AvailableOccasions(int j)
		{
			return null;
		}

		[Address(RVA="0x22EA954", Offset="0x22EA954", VA="0x22EA954")]
		public static VectorOffset CreateAvailableOccasionsVector(FlatBufferBuilder builder, Offset<OccasionRef>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22EA820", Offset="0x22EA820", VA="0x22EA820")]
		public static VectorOffset CreateStoreItemsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22EA550", Offset="0x22EA550", VA="0x22EA550")]
		public static Offset<StoreShelfDef> CreateStoreShelfDef(FlatBufferBuilder builder, ulong id = 0L, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.StoreShelfDef> Gamedata.StoreShelfDef::CreateStoreShelfDef(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.StoreShelfDef> CreateStoreShelfDef(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22EA770", Offset="0x22EA770", VA="0x22EA770")]
		public static Offset<StoreShelfDef> EndStoreShelfDef(FlatBufferBuilder builder)
		{
			return new Offset<StoreShelfDef>();
		}

		[Address(RVA="0x22EAA88", Offset="0x22EAA88", VA="0x22EAA88")]
		public static void FinishStoreShelfDefBuffer(FlatBufferBuilder builder, Offset<StoreShelfDef> offset)
		{
		}

		[Address(RVA="0xF3B0E4", Offset="0xF3B0E4", VA="0xF3B0E4")]
		public ArraySegment<byte>? GetBackgroundBytes()
		{
			return null;
		}

		[Address(RVA="0xF3B0CC", Offset="0xF3B0CC", VA="0xF3B0CC")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x22EA0FC", Offset="0x22EA0FC", VA="0x22EA0FC")]
		public static StoreShelfDef GetRootAsStoreShelfDef(FlatBuffers.ByteBuffer _bb)
		{
			return new StoreShelfDef();
		}

		[Address(RVA="0x22EA108", Offset="0x22EA108", VA="0x22EA108")]
		public static StoreShelfDef GetRootAsStoreShelfDef(FlatBuffers.ByteBuffer _bb, StoreShelfDef obj)
		{
			return new StoreShelfDef();
		}

		[Address(RVA="0xF3B104", Offset="0xF3B104", VA="0xF3B104")]
		public ArraySegment<byte>? GetStoreItemsBytes()
		{
			return null;
		}

		[Address(RVA="0x22EAA4C", Offset="0x22EAA4C", VA="0x22EAA4C")]
		public static void StartAvailableOccasionsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22EA918", Offset="0x22EA918", VA="0x22EA918")]
		public static void StartStoreItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22EA7F0", Offset="0x22EA7F0", VA="0x22EA7F0")]
		public static void StartStoreShelfDef(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0xF3B0F4", Offset="0xF3B0F4", VA="0xF3B0F4")]
		public ulong StoreItems(int j)
		{
			return new ulong();
		}
	}
}