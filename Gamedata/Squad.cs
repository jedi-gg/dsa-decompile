using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct Squad : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3A3A8", Offset="0xF3A3A8", VA="0xF3A3A8", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF3A3D4", Offset="0xF3A3D4", VA="0xF3A3D4")]
			get
			{
				return new ulong();
			}
		}

		public int UnitSlotsLength
		{
			[Address(RVA="0xF3A3E4", Offset="0xF3A3E4", VA="0xF3A3E4")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF3A3BC", Offset="0xF3A3BC", VA="0xF3A3BC")]
		public Squad __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new Squad();
		}

		[Address(RVA="0xF3A3B0", Offset="0xF3A3B0", VA="0xF3A3B0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22DDF80", Offset="0x22DDF80", VA="0x22DDF80")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x22DDFBC", Offset="0x22DDFBC", VA="0x22DDFBC")]
		public static void AddUnitSlots(FlatBufferBuilder builder, VectorOffset unitSlotsOffset)
		{
		}

		[Address(RVA="0x22DDF18", Offset="0x22DDF18", VA="0x22DDF18")]
		public static Offset<Squad> CreateSquad(FlatBufferBuilder builder, ulong id = 0L, VectorOffset unit_slotsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.Squad> Gamedata.Squad::CreateSquad(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.Squad> CreateSquad(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22DE0A8", Offset="0x22DE0A8", VA="0x22DE0A8")]
		public static VectorOffset CreateUnitSlotsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22DDFF8", Offset="0x22DDFF8", VA="0x22DDFF8")]
		public static Offset<Squad> EndSquad(FlatBufferBuilder builder)
		{
			return new Offset<Squad>();
		}

		[Address(RVA="0x22DE1DC", Offset="0x22DE1DC", VA="0x22DE1DC")]
		public static void FinishSquadBuffer(FlatBufferBuilder builder, Offset<Squad> offset)
		{
		}

		[Address(RVA="0x22DDD04", Offset="0x22DDD04", VA="0x22DDD04")]
		public static Squad GetRootAsSquad(FlatBuffers.ByteBuffer _bb)
		{
			return new Squad();
		}

		[Address(RVA="0x22DDD10", Offset="0x22DDD10", VA="0x22DDD10")]
		public static Squad GetRootAsSquad(FlatBuffers.ByteBuffer _bb, Squad obj)
		{
			return new Squad();
		}

		[Address(RVA="0xF3A3EC", Offset="0xF3A3EC", VA="0xF3A3EC")]
		public ArraySegment<byte>? GetUnitSlotsBytes()
		{
			return null;
		}

		[Address(RVA="0x22DE078", Offset="0x22DE078", VA="0x22DE078")]
		public static void StartSquad(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x22DE1A0", Offset="0x22DE1A0", VA="0x22DE1A0")]
		public static void StartUnitSlotsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF3A3DC", Offset="0xF3A3DC", VA="0xF3A3DC")]
		public ulong UnitSlots(int j)
		{
			return new ulong();
		}
	}
}