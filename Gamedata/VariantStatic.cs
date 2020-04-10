using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct VariantStatic : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0C410", Offset="0xF0C410", VA="0xF0C410", Slot="5")]
			get
			{
				return null;
			}
		}

		public StaticGamedata? Data
		{
			[Address(RVA="0xF0C444", Offset="0xF0C444", VA="0xF0C444")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0C43C", Offset="0xF0C43C", VA="0xF0C43C")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF0C424", Offset="0xF0C424", VA="0xF0C424")]
		public VariantStatic __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new VariantStatic();
		}

		[Address(RVA="0xF0C418", Offset="0xF0C418", VA="0xF0C418", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x16806F0", Offset="0x16806F0", VA="0x16806F0")]
		public static void AddData(FlatBufferBuilder builder, Offset<StaticGamedata> dataOffset)
		{
		}

		[Address(RVA="0x16806B4", Offset="0x16806B4", VA="0x16806B4")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x168064C", Offset="0x168064C", VA="0x168064C")]
		public static Offset<VariantStatic> CreateVariantStatic(FlatBufferBuilder builder, ulong id = 0L, Offset<StaticGamedata> dataOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.VariantStatic> Gamedata.VariantStatic::CreateVariantStatic(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset`1<Gamedata.StaticGamedata>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.VariantStatic> CreateVariantStatic(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset<Gamedata.StaticGamedata>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x168072C", Offset="0x168072C", VA="0x168072C")]
		public static Offset<VariantStatic> EndVariantStatic(FlatBufferBuilder builder)
		{
			return new Offset<VariantStatic>();
		}

		[Address(RVA="0x16807DC", Offset="0x16807DC", VA="0x16807DC")]
		public static void FinishVariantStaticBuffer(FlatBufferBuilder builder, Offset<VariantStatic> offset)
		{
		}

		[Address(RVA="0x168043C", Offset="0x168043C", VA="0x168043C")]
		public static VariantStatic GetRootAsVariantStatic(FlatBuffers.ByteBuffer _bb)
		{
			return new VariantStatic();
		}

		[Address(RVA="0x1680448", Offset="0x1680448", VA="0x1680448")]
		public static VariantStatic GetRootAsVariantStatic(FlatBuffers.ByteBuffer _bb, VariantStatic obj)
		{
			return new VariantStatic();
		}

		[Address(RVA="0x16807AC", Offset="0x16807AC", VA="0x16807AC")]
		public static void StartVariantStatic(FlatBufferBuilder builder)
		{
		}
	}
}