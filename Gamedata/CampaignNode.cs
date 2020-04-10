using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct CampaignNode : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public int BattlesLength
		{
			[Address(RVA="0xF43528", Offset="0xF43528", VA="0xF43528")]
			get
			{
				return new int();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF434F4", Offset="0xF434F4", VA="0xF434F4", Slot="5")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF43508", Offset="0xF43508", VA="0xF43508")]
		public CampaignNode __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new CampaignNode();
		}

		[Address(RVA="0xF434FC", Offset="0xF434FC", VA="0xF434FC", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x231FEA0", Offset="0x231FEA0", VA="0x231FEA0")]
		public static void AddBattles(FlatBufferBuilder builder, VectorOffset battlesOffset)
		{
		}

		[Address(RVA="0xF43520", Offset="0xF43520", VA="0xF43520")]
		public BattleNode? Battles(int j)
		{
			return null;
		}

		[Address(RVA="0x231FF8C", Offset="0x231FF8C", VA="0x231FF8C")]
		public static VectorOffset CreateBattlesVector(FlatBufferBuilder builder, Offset<BattleNode>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x231FE50", Offset="0x231FE50", VA="0x231FE50")]
		public static Offset<CampaignNode> CreateCampaignNode(FlatBufferBuilder builder, VectorOffset battlesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.CampaignNode> Gamedata.CampaignNode::CreateCampaignNode(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.CampaignNode> CreateCampaignNode(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x231FEDC", Offset="0x231FEDC", VA="0x231FEDC")]
		public static Offset<CampaignNode> EndCampaignNode(FlatBufferBuilder builder)
		{
			return new Offset<CampaignNode>();
		}

		[Address(RVA="0x231FC50", Offset="0x231FC50", VA="0x231FC50")]
		public static CampaignNode GetRootAsCampaignNode(FlatBuffers.ByteBuffer _bb)
		{
			return new CampaignNode();
		}

		[Address(RVA="0x231FC5C", Offset="0x231FC5C", VA="0x231FC5C")]
		public static CampaignNode GetRootAsCampaignNode(FlatBuffers.ByteBuffer _bb, CampaignNode obj)
		{
			return new CampaignNode();
		}

		[Address(RVA="0x2320084", Offset="0x2320084", VA="0x2320084")]
		public static void StartBattlesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x231FF5C", Offset="0x231FF5C", VA="0x231FF5C")]
		public static void StartCampaignNode(FlatBufferBuilder builder)
		{
		}
	}
}