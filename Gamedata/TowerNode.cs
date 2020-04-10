using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct TowerNode : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public BattleNode? BattleData
		{
			[Address(RVA="0xF3B4FC", Offset="0xF3B4FC", VA="0xF3B4FC")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3B4D0", Offset="0xF3B4D0", VA="0xF3B4D0", Slot="5")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF3B4E4", Offset="0xF3B4E4", VA="0xF3B4E4")]
		public TowerNode __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new TowerNode();
		}

		[Address(RVA="0xF3B4D8", Offset="0xF3B4D8", VA="0xF3B4D8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22ECC48", Offset="0x22ECC48", VA="0x22ECC48")]
		public static void AddBattleData(FlatBufferBuilder builder, Offset<BattleNode> battleDataOffset)
		{
		}

		[Address(RVA="0x22ECBF8", Offset="0x22ECBF8", VA="0x22ECBF8")]
		public static Offset<TowerNode> CreateTowerNode(FlatBufferBuilder builder, Offset<BattleNode> battleDataOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.TowerNode> Gamedata.TowerNode::CreateTowerNode(FlatBuffers.FlatBufferBuilder,FlatBuffers.Offset`1<Gamedata.BattleNode>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.TowerNode> CreateTowerNode(FlatBuffers.FlatBufferBuilder,FlatBuffers.Offset<Gamedata.BattleNode>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22ECC84", Offset="0x22ECC84", VA="0x22ECC84")]
		public static Offset<TowerNode> EndTowerNode(FlatBufferBuilder builder)
		{
			return new Offset<TowerNode>();
		}

		[Address(RVA="0x22ECA6C", Offset="0x22ECA6C", VA="0x22ECA6C")]
		public static TowerNode GetRootAsTowerNode(FlatBuffers.ByteBuffer _bb)
		{
			return new TowerNode();
		}

		[Address(RVA="0x22ECA78", Offset="0x22ECA78", VA="0x22ECA78")]
		public static TowerNode GetRootAsTowerNode(FlatBuffers.ByteBuffer _bb, TowerNode obj)
		{
			return new TowerNode();
		}

		[Address(RVA="0x22ECD04", Offset="0x22ECD04", VA="0x22ECD04")]
		public static void StartTowerNode(FlatBufferBuilder builder)
		{
		}
	}
}