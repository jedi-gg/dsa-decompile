using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct CampaignMap : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0AEE8", Offset="0xF0AEE8", VA="0xF0AEE8", Slot="5")]
			get
			{
				return null;
			}
		}

		public string LockedTextKey
		{
			[Address(RVA="0xF0AF5C", Offset="0xF0AF5C", VA="0xF0AF5C")]
			get
			{
				return null;
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF0AF14", Offset="0xF0AF14", VA="0xF0AF14")]
			get
			{
				return null;
			}
		}

		public int NodesLength
		{
			[Address(RVA="0xF0AF4C", Offset="0xF0AF4C", VA="0xF0AF4C")]
			get
			{
				return new int();
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF0AF2C", Offset="0xF0AF2C", VA="0xF0AF2C")]
			get
			{
				return null;
			}
		}

		public ulong RewardPlayerActivityId
		{
			[Address(RVA="0xF0AF54", Offset="0xF0AF54", VA="0xF0AF54")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF0AEFC", Offset="0xF0AEFC", VA="0xF0AEFC")]
		public CampaignMap __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new CampaignMap();
		}

		[Address(RVA="0xF0AEF0", Offset="0xF0AEF0", VA="0xF0AEF0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F8328", Offset="0x15F8328", VA="0x15F8328")]
		public static void AddLockedTextKey(FlatBufferBuilder builder, StringOffset lockedTextKeyOffset)
		{
		}

		[Address(RVA="0x15F83DC", Offset="0x15F83DC", VA="0x15F83DC")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x15F8364", Offset="0x15F8364", VA="0x15F8364")]
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
		}

		[Address(RVA="0x15F83A0", Offset="0x15F83A0", VA="0x15F83A0")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x15F82EC", Offset="0x15F82EC", VA="0x15F82EC")]
		public static void AddRewardPlayerActivityId(FlatBufferBuilder builder, ulong rewardPlayerActivityId)
		{
		}

		[Address(RVA="0x15F824C", Offset="0x15F824C", VA="0x15F824C")]
		public static Offset<CampaignMap> CreateCampaignMap(FlatBufferBuilder builder, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.CampaignMap> Gamedata.CampaignMap::CreateCampaignMap(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,System.UInt64,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.CampaignMap> CreateCampaignMap(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,System.UInt64,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F84C8", Offset="0x15F84C8", VA="0x15F84C8")]
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<CampaignNode>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15F8418", Offset="0x15F8418", VA="0x15F8418")]
		public static Offset<CampaignMap> EndCampaignMap(FlatBufferBuilder builder)
		{
			return new Offset<CampaignMap>();
		}

		[Address(RVA="0xF0AF64", Offset="0xF0AF64", VA="0xF0AF64")]
		public ArraySegment<byte>? GetLockedTextKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF0AF1C", Offset="0xF0AF1C", VA="0xF0AF1C")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF0AF34", Offset="0xF0AF34", VA="0xF0AF34")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x15F7EF0", Offset="0x15F7EF0", VA="0x15F7EF0")]
		public static CampaignMap GetRootAsCampaignMap(FlatBuffers.ByteBuffer _bb)
		{
			return new CampaignMap();
		}

		[Address(RVA="0x15F7EFC", Offset="0x15F7EFC", VA="0x15F7EFC")]
		public static CampaignMap GetRootAsCampaignMap(FlatBuffers.ByteBuffer _bb, CampaignMap obj)
		{
			return new CampaignMap();
		}

		[Address(RVA="0xF0AF44", Offset="0xF0AF44", VA="0xF0AF44")]
		public CampaignNode? Nodes(int j)
		{
			return null;
		}

		[Address(RVA="0x15F8498", Offset="0x15F8498", VA="0x15F8498")]
		public static void StartCampaignMap(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x15F85C0", Offset="0x15F85C0", VA="0x15F85C0")]
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}