using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct LevelBandedRewardChoiceOption : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56458", Offset="0xF56458", VA="0xF56458", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong LootTable
		{
			[Address(RVA="0xF56484", Offset="0xF56484", VA="0xF56484")]
			get
			{
				return new ulong();
			}
		}

		public string PreviewAsset
		{
			[Address(RVA="0xF5648C", Offset="0xF5648C", VA="0xF5648C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF5646C", Offset="0xF5646C", VA="0xF5646C")]
		public LevelBandedRewardChoiceOption __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new LevelBandedRewardChoiceOption();
		}

		[Address(RVA="0xF56460", Offset="0xF56460", VA="0xF56460", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D2DBC", Offset="0x24D2DBC", VA="0x24D2DBC")]
		public static void AddLootTable(FlatBufferBuilder builder, ulong lootTable)
		{
		}

		[Address(RVA="0x24D2DF8", Offset="0x24D2DF8", VA="0x24D2DF8")]
		public static void AddPreviewAsset(FlatBufferBuilder builder, StringOffset previewAssetOffset)
		{
		}

		[Address(RVA="0x24D2D54", Offset="0x24D2D54", VA="0x24D2D54")]
		public static Offset<LevelBandedRewardChoiceOption> CreateLevelBandedRewardChoiceOption(FlatBufferBuilder builder, ulong loot_table = 0L, StringOffset preview_assetOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.LevelBandedRewardChoiceOption> Gamedata.LevelBandedRewardChoiceOption::CreateLevelBandedRewardChoiceOption(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.LevelBandedRewardChoiceOption> CreateLevelBandedRewardChoiceOption(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D2E34", Offset="0x24D2E34", VA="0x24D2E34")]
		public static Offset<LevelBandedRewardChoiceOption> EndLevelBandedRewardChoiceOption(FlatBufferBuilder builder)
		{
			return new Offset<LevelBandedRewardChoiceOption>();
		}

		[Address(RVA="0xF56494", Offset="0xF56494", VA="0xF56494")]
		public ArraySegment<byte>? GetPreviewAssetBytes()
		{
			return null;
		}

		[Address(RVA="0x24D2BD4", Offset="0x24D2BD4", VA="0x24D2BD4")]
		public static LevelBandedRewardChoiceOption GetRootAsLevelBandedRewardChoiceOption(FlatBuffers.ByteBuffer _bb)
		{
			return new LevelBandedRewardChoiceOption();
		}

		[Address(RVA="0x24D2BE0", Offset="0x24D2BE0", VA="0x24D2BE0")]
		public static LevelBandedRewardChoiceOption GetRootAsLevelBandedRewardChoiceOption(FlatBuffers.ByteBuffer _bb, LevelBandedRewardChoiceOption obj)
		{
			return new LevelBandedRewardChoiceOption();
		}

		[Address(RVA="0x24D2EB4", Offset="0x24D2EB4", VA="0x24D2EB4")]
		public static void StartLevelBandedRewardChoiceOption(FlatBufferBuilder builder)
		{
		}
	}
}