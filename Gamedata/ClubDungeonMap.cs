using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubDungeonMap : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF4388C", Offset="0xF4388C", VA="0xF4388C", Slot="5")]
			get
			{
				return null;
			}
		}

		public string MapPrefab
		{
			[Address(RVA="0xF438C8", Offset="0xF438C8", VA="0xF438C8")]
			get
			{
				return null;
			}
		}

		public int NodesLength
		{
			[Address(RVA="0xF438C0", Offset="0xF438C0", VA="0xF438C0")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF438A0", Offset="0xF438A0", VA="0xF438A0")]
		public ClubDungeonMap __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubDungeonMap();
		}

		[Address(RVA="0xF43894", Offset="0xF43894", VA="0xF43894", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x23222A0", Offset="0x23222A0", VA="0x23222A0")]
		public static void AddMapPrefab(FlatBufferBuilder builder, StringOffset mapPrefabOffset)
		{
		}

		[Address(RVA="0x23222DC", Offset="0x23222DC", VA="0x23222DC")]
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
		}

		[Address(RVA="0x2322238", Offset="0x2322238", VA="0x2322238")]
		public static Offset<ClubDungeonMap> CreateClubDungeonMap(FlatBufferBuilder builder, VectorOffset nodesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ClubDungeonMap> Gamedata.ClubDungeonMap::CreateClubDungeonMap(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ClubDungeonMap> CreateClubDungeonMap(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x23223C8", Offset="0x23223C8", VA="0x23223C8")]
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<ClubDungeonNode>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2322318", Offset="0x2322318", VA="0x2322318")]
		public static Offset<ClubDungeonMap> EndClubDungeonMap(FlatBufferBuilder builder)
		{
			return new Offset<ClubDungeonMap>();
		}

		[Address(RVA="0xF438D0", Offset="0xF438D0", VA="0xF438D0")]
		public ArraySegment<byte>? GetMapPrefabBytes()
		{
			return null;
		}

		[Address(RVA="0x2322004", Offset="0x2322004", VA="0x2322004")]
		public static ClubDungeonMap GetRootAsClubDungeonMap(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubDungeonMap();
		}

		[Address(RVA="0x2322010", Offset="0x2322010", VA="0x2322010")]
		public static ClubDungeonMap GetRootAsClubDungeonMap(FlatBuffers.ByteBuffer _bb, ClubDungeonMap obj)
		{
			return new ClubDungeonMap();
		}

		[Address(RVA="0xF438B8", Offset="0xF438B8", VA="0xF438B8")]
		public ClubDungeonNode? Nodes(int j)
		{
			return null;
		}

		[Address(RVA="0x2322398", Offset="0x2322398", VA="0x2322398")]
		public static void StartClubDungeonMap(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x23224C0", Offset="0x23224C0", VA="0x23224C0")]
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}