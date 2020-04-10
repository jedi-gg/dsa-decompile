using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleNodeOverride : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A930", Offset="0xF0A930", VA="0xF0A930", Slot="5")]
			get
			{
				return null;
			}
		}

		public BattleNode? Data
		{
			[Address(RVA="0xF0A974", Offset="0xF0A974", VA="0xF0A974")]
			get
			{
				return null;
			}
		}

		public string GameModeId
		{
			[Address(RVA="0xF0A95C", Offset="0xF0A95C", VA="0xF0A95C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF0A944", Offset="0xF0A944", VA="0xF0A944")]
		public BattleNodeOverride __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleNodeOverride();
		}

		[Address(RVA="0xF0A938", Offset="0xF0A938", VA="0xF0A938", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F4960", Offset="0x15F4960", VA="0x15F4960")]
		public static void AddData(FlatBufferBuilder builder, Offset<BattleNode> dataOffset)
		{
		}

		[Address(RVA="0x15F499C", Offset="0x15F499C", VA="0x15F499C")]
		public static void AddGameModeId(FlatBufferBuilder builder, StringOffset gameModeIdOffset)
		{
		}

		[Address(RVA="0x15F48F8", Offset="0x15F48F8", VA="0x15F48F8")]
		public static Offset<BattleNodeOverride> CreateBattleNodeOverride(FlatBufferBuilder builder, StringOffset game_mode_idOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleNodeOverride> Gamedata.BattleNodeOverride::CreateBattleNodeOverride(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.Offset`1<Gamedata.BattleNode>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleNodeOverride> CreateBattleNodeOverride(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.Offset<Gamedata.BattleNode>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F49D8", Offset="0x15F49D8", VA="0x15F49D8")]
		public static Offset<BattleNodeOverride> EndBattleNodeOverride(FlatBufferBuilder builder)
		{
			return new Offset<BattleNodeOverride>();
		}

		[Address(RVA="0xF0A964", Offset="0xF0A964", VA="0xF0A964")]
		public ArraySegment<byte>? GetGameModeIdBytes()
		{
			return null;
		}

		[Address(RVA="0x15F4720", Offset="0x15F4720", VA="0x15F4720")]
		public static BattleNodeOverride GetRootAsBattleNodeOverride(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleNodeOverride();
		}

		[Address(RVA="0x15F472C", Offset="0x15F472C", VA="0x15F472C")]
		public static BattleNodeOverride GetRootAsBattleNodeOverride(FlatBuffers.ByteBuffer _bb, BattleNodeOverride obj)
		{
			return new BattleNodeOverride();
		}

		[Address(RVA="0x15F4A58", Offset="0x15F4A58", VA="0x15F4A58")]
		public static void StartBattleNodeOverride(FlatBufferBuilder builder)
		{
		}
	}
}