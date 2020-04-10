using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubWarNode : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ulong Battle
		{
			[Address(RVA="0xF44090", Offset="0xF44090", VA="0xF44090")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF4403C", Offset="0xF4403C", VA="0xF4403C", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Id
		{
			[Address(RVA="0xF44068", Offset="0xF44068", VA="0xF44068")]
			get
			{
				return null;
			}
		}

		public ClubWarTeam InitialOwner
		{
			[Address(RVA="0xF440A0", Offset="0xF440A0", VA="0xF440A0")]
			get
			{
				return new ClubWarTeam();
			}
		}

		public int MaxDefenders
		{
			[Address(RVA="0xF44088", Offset="0xF44088", VA="0xF44088")]
			get
			{
				return new int();
			}
		}

		public string NodeLabel
		{
			[Address(RVA="0xF440B0", Offset="0xF440B0", VA="0xF440B0")]
			get
			{
				return null;
			}
		}

		public ClubWarNodeType NodeType
		{
			[Address(RVA="0xF440A8", Offset="0xF440A8", VA="0xF440A8")]
			get
			{
				return new ClubWarNodeType();
			}
		}

		public int PointsPerTick
		{
			[Address(RVA="0xF44080", Offset="0xF44080", VA="0xF44080")]
			get
			{
				return new int();
			}
		}

		public ulong Restrictions
		{
			[Address(RVA="0xF44098", Offset="0xF44098", VA="0xF44098")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF44050", Offset="0xF44050", VA="0xF44050")]
		public ClubWarNode __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarNode();
		}

		[Address(RVA="0xF44044", Offset="0xF44044", VA="0xF44044", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x232701C", Offset="0x232701C", VA="0x232701C")]
		public static void AddBattle(FlatBufferBuilder builder, ulong battle)
		{
		}

		[Address(RVA="0x232710C", Offset="0x232710C", VA="0x232710C")]
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
		}

		[Address(RVA="0x2327184", Offset="0x2327184", VA="0x2327184")]
		public static void AddInitialOwner(FlatBufferBuilder builder, ClubWarTeam initialOwner)
		{
		}

		[Address(RVA="0x2327094", Offset="0x2327094", VA="0x2327094")]
		public static void AddMaxDefenders(FlatBufferBuilder builder, int maxDefenders)
		{
		}

		[Address(RVA="0x2327058", Offset="0x2327058", VA="0x2327058")]
		public static void AddNodeLabel(FlatBufferBuilder builder, StringOffset nodeLabelOffset)
		{
		}

		[Address(RVA="0x2327148", Offset="0x2327148", VA="0x2327148")]
		public static void AddNodeType(FlatBufferBuilder builder, ClubWarNodeType nodeType)
		{
		}

		[Address(RVA="0x23270D0", Offset="0x23270D0", VA="0x23270D0")]
		public static void AddPointsPerTick(FlatBufferBuilder builder, int pointsPerTick)
		{
		}

		[Address(RVA="0x2326FE0", Offset="0x2326FE0", VA="0x2326FE0")]
		public static void AddRestrictions(FlatBufferBuilder builder, ulong restrictions)
		{
		}

		[Address(RVA="0x2326F00", Offset="0x2326F00", VA="0x2326F00")]
		public static Offset<ClubWarNode> CreateClubWarNode(FlatBufferBuilder builder, StringOffset idOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ClubWarNode> Gamedata.ClubWarNode::CreateClubWarNode(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,System.Int32,System.Int32,System.UInt64,System.UInt64,Gamedata.ClubWarTeam,Gamedata.ClubWarNodeType,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ClubWarNode> CreateClubWarNode(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,System.Int32,System.Int32,System.UInt64,System.UInt64,Gamedata.ClubWarTeam,Gamedata.ClubWarNodeType,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x23271C0", Offset="0x23271C0", VA="0x23271C0")]
		public static Offset<ClubWarNode> EndClubWarNode(FlatBufferBuilder builder)
		{
			return new Offset<ClubWarNode>();
		}

		[Address(RVA="0xF44070", Offset="0xF44070", VA="0xF44070")]
		public ArraySegment<byte>? GetIdBytes()
		{
			return null;
		}

		[Address(RVA="0xF440B8", Offset="0xF440B8", VA="0xF440B8")]
		public ArraySegment<byte>? GetNodeLabelBytes()
		{
			return null;
		}

		[Address(RVA="0x2326B1C", Offset="0x2326B1C", VA="0x2326B1C")]
		public static ClubWarNode GetRootAsClubWarNode(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarNode();
		}

		[Address(RVA="0x2326B28", Offset="0x2326B28", VA="0x2326B28")]
		public static ClubWarNode GetRootAsClubWarNode(FlatBuffers.ByteBuffer _bb, ClubWarNode obj)
		{
			return new ClubWarNode();
		}

		[Address(RVA="0x2327240", Offset="0x2327240", VA="0x2327240")]
		public static void StartClubWarNode(FlatBufferBuilder builder)
		{
		}
	}
}