using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubDungeonDef : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF437FC", Offset="0xF437FC", VA="0xF437FC", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF43828", Offset="0xF43828", VA="0xF43828")]
			get
			{
				return new ulong();
			}
		}

		public int MapsLength
		{
			[Address(RVA="0xF43838", Offset="0xF43838", VA="0xF43838")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF43810", Offset="0xF43810", VA="0xF43810")]
		public ClubDungeonDef __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubDungeonDef();
		}

		[Address(RVA="0xF43804", Offset="0xF43804", VA="0xF43804", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2321D6C", Offset="0x2321D6C", VA="0x2321D6C")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x2321DA8", Offset="0x2321DA8", VA="0x2321DA8")]
		public static void AddMaps(FlatBufferBuilder builder, VectorOffset mapsOffset)
		{
		}

		[Address(RVA="0x2321D04", Offset="0x2321D04", VA="0x2321D04")]
		public static Offset<ClubDungeonDef> CreateClubDungeonDef(FlatBufferBuilder builder, ulong id = 0L, VectorOffset mapsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ClubDungeonDef> Gamedata.ClubDungeonDef::CreateClubDungeonDef(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ClubDungeonDef> CreateClubDungeonDef(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2321E94", Offset="0x2321E94", VA="0x2321E94")]
		public static VectorOffset CreateMapsVector(FlatBufferBuilder builder, Offset<ClubDungeonMap>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2321DE4", Offset="0x2321DE4", VA="0x2321DE4")]
		public static Offset<ClubDungeonDef> EndClubDungeonDef(FlatBufferBuilder builder)
		{
			return new Offset<ClubDungeonDef>();
		}

		[Address(RVA="0x2321FC8", Offset="0x2321FC8", VA="0x2321FC8")]
		public static void FinishClubDungeonDefBuffer(FlatBufferBuilder builder, Offset<ClubDungeonDef> offset)
		{
		}

		[Address(RVA="0x2321AA4", Offset="0x2321AA4", VA="0x2321AA4")]
		public static ClubDungeonDef GetRootAsClubDungeonDef(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubDungeonDef();
		}

		[Address(RVA="0x2321AB0", Offset="0x2321AB0", VA="0x2321AB0")]
		public static ClubDungeonDef GetRootAsClubDungeonDef(FlatBuffers.ByteBuffer _bb, ClubDungeonDef obj)
		{
			return new ClubDungeonDef();
		}

		[Address(RVA="0xF43830", Offset="0xF43830", VA="0xF43830")]
		public ClubDungeonMap? Maps(int j)
		{
			return null;
		}

		[Address(RVA="0x2321E64", Offset="0x2321E64", VA="0x2321E64")]
		public static void StartClubDungeonDef(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x2321F8C", Offset="0x2321F8C", VA="0x2321F8C")]
		public static void StartMapsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}