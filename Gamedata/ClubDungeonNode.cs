using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubDungeonNode : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public BattleNode? BattleData
		{
			[Address(RVA="0xF43958", Offset="0xF43958", VA="0xF43958")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF4392C", Offset="0xF4392C", VA="0xF4392C", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong DungeonReward
		{
			[Address(RVA="0xF43968", Offset="0xF43968", VA="0xF43968")]
			get
			{
				return new ulong();
			}
		}

		public ClubDungeonNodeType NodeType
		{
			[Address(RVA="0xF43960", Offset="0xF43960", VA="0xF43960")]
			get
			{
				return new ClubDungeonNodeType();
			}
		}

		[Address(RVA="0xF43940", Offset="0xF43940", VA="0xF43940")]
		public ClubDungeonNode __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubDungeonNode();
		}

		[Address(RVA="0xF43934", Offset="0xF43934", VA="0xF43934", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2322818", Offset="0x2322818", VA="0x2322818")]
		public static void AddBattleData(FlatBufferBuilder builder, Offset<BattleNode> battleDataOffset)
		{
		}

		[Address(RVA="0x23227DC", Offset="0x23227DC", VA="0x23227DC")]
		public static void AddDungeonReward(FlatBufferBuilder builder, ulong dungeonReward)
		{
		}

		[Address(RVA="0x2322854", Offset="0x2322854", VA="0x2322854")]
		public static void AddNodeType(FlatBufferBuilder builder, ClubDungeonNodeType nodeType)
		{
		}

		[Address(RVA="0x2322764", Offset="0x2322764", VA="0x2322764")]
		public static Offset<ClubDungeonNode> CreateClubDungeonNode(FlatBufferBuilder builder, Offset<BattleNode> battle_dataOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ClubDungeonNode> Gamedata.ClubDungeonNode::CreateClubDungeonNode(FlatBuffers.FlatBufferBuilder,FlatBuffers.Offset`1<Gamedata.BattleNode>,Gamedata.ClubDungeonNodeType,System.UInt64)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ClubDungeonNode> CreateClubDungeonNode(FlatBuffers.FlatBufferBuilder,FlatBuffers.Offset<Gamedata.BattleNode>,Gamedata.ClubDungeonNodeType,System.UInt64)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2322890", Offset="0x2322890", VA="0x2322890")]
		public static Offset<ClubDungeonNode> EndClubDungeonNode(FlatBufferBuilder builder)
		{
			return new Offset<ClubDungeonNode>();
		}

		[Address(RVA="0x2322504", Offset="0x2322504", VA="0x2322504")]
		public static ClubDungeonNode GetRootAsClubDungeonNode(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubDungeonNode();
		}

		[Address(RVA="0x2322510", Offset="0x2322510", VA="0x2322510")]
		public static ClubDungeonNode GetRootAsClubDungeonNode(FlatBuffers.ByteBuffer _bb, ClubDungeonNode obj)
		{
			return new ClubDungeonNode();
		}

		[Address(RVA="0x2322910", Offset="0x2322910", VA="0x2322910")]
		public static void StartClubDungeonNode(FlatBufferBuilder builder)
		{
		}
	}
}