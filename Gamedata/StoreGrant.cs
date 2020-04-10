using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct StoreGrant : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string BoxBackNameKey
		{
			[Address(RVA="0xF3AB4C", Offset="0xF3AB4C", VA="0xF3AB4C")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3AB08", Offset="0xF3AB08", VA="0xF3AB08", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF3AB34", Offset="0xF3AB34", VA="0xF3AB34")]
			get
			{
				return new ulong();
			}
		}

		public uint MonteCarloFirstTimeDiscount
		{
			[Address(RVA="0xF3AB6C", Offset="0xF3AB6C", VA="0xF3AB6C")]
			get
			{
				return new uint();
			}
		}

		public uint MonteCarloLimit
		{
			[Address(RVA="0xF3AB64", Offset="0xF3AB64", VA="0xF3AB64")]
			get
			{
				return new uint();
			}
		}

		public int OptionsLength
		{
			[Address(RVA="0xF3AB44", Offset="0xF3AB44", VA="0xF3AB44")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF3AB1C", Offset="0xF3AB1C", VA="0xF3AB1C")]
		public StoreGrant __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new StoreGrant();
		}

		[Address(RVA="0xF3AB10", Offset="0xF3AB10", VA="0xF3AB10", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22E66A4", Offset="0x22E66A4", VA="0x22E66A4")]
		public static void AddBoxBackNameKey(FlatBufferBuilder builder, StringOffset boxBackNameKeyOffset)
		{
		}

		[Address(RVA="0x22E65F0", Offset="0x22E65F0", VA="0x22E65F0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x22E662C", Offset="0x22E662C", VA="0x22E662C")]
		public static void AddMonteCarloFirstTimeDiscount(FlatBufferBuilder builder, uint monteCarloFirstTimeDiscount)
		{
		}

		[Address(RVA="0x22E6668", Offset="0x22E6668", VA="0x22E6668")]
		public static void AddMonteCarloLimit(FlatBufferBuilder builder, uint monteCarloLimit)
		{
		}

		[Address(RVA="0x22E66E0", Offset="0x22E66E0", VA="0x22E66E0")]
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
		}

		[Address(RVA="0x22E67CC", Offset="0x22E67CC", VA="0x22E67CC")]
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<StoreGrantItem>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22E6550", Offset="0x22E6550", VA="0x22E6550")]
		public static Offset<StoreGrant> CreateStoreGrant(FlatBufferBuilder builder, ulong id = 0L, VectorOffset optionsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.StoreGrant> Gamedata.StoreGrant::CreateStoreGrant(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.UInt32,System.UInt32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.StoreGrant> CreateStoreGrant(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.UInt32,System.UInt32)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22E671C", Offset="0x22E671C", VA="0x22E671C")]
		public static Offset<StoreGrant> EndStoreGrant(FlatBufferBuilder builder)
		{
			return new Offset<StoreGrant>();
		}

		[Address(RVA="0x22E6900", Offset="0x22E6900", VA="0x22E6900")]
		public static void FinishStoreGrantBuffer(FlatBufferBuilder builder, Offset<StoreGrant> offset)
		{
		}

		[Address(RVA="0xF3AB54", Offset="0xF3AB54", VA="0xF3AB54")]
		public ArraySegment<byte>? GetBoxBackNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x22E61C8", Offset="0x22E61C8", VA="0x22E61C8")]
		public static StoreGrant GetRootAsStoreGrant(FlatBuffers.ByteBuffer _bb)
		{
			return new StoreGrant();
		}

		[Address(RVA="0x22E61D4", Offset="0x22E61D4", VA="0x22E61D4")]
		public static StoreGrant GetRootAsStoreGrant(FlatBuffers.ByteBuffer _bb, StoreGrant obj)
		{
			return new StoreGrant();
		}

		[Address(RVA="0xF3AB3C", Offset="0xF3AB3C", VA="0xF3AB3C")]
		public StoreGrantItem? Options(int j)
		{
			return null;
		}

		[Address(RVA="0x22E68C4", Offset="0x22E68C4", VA="0x22E68C4")]
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22E679C", Offset="0x22E679C", VA="0x22E679C")]
		public static void StartStoreGrant(FlatBufferBuilder builder)
		{
		}
	}
}