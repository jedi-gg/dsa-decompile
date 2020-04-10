using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct LevelBandedRewardChoice : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF563C8", Offset="0xF563C8", VA="0xF563C8", Slot="5")]
			get
			{
				return null;
			}
		}

		public int MaxLevel
		{
			[Address(RVA="0xF56404", Offset="0xF56404", VA="0xF56404")]
			get
			{
				return new int();
			}
		}

		public int OptionsLength
		{
			[Address(RVA="0xF563FC", Offset="0xF563FC", VA="0xF563FC")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF563DC", Offset="0xF563DC", VA="0xF563DC")]
		public LevelBandedRewardChoice __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new LevelBandedRewardChoice();
		}

		[Address(RVA="0xF563D0", Offset="0xF563D0", VA="0xF563D0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D2970", Offset="0x24D2970", VA="0x24D2970")]
		public static void AddMaxLevel(FlatBufferBuilder builder, int maxLevel)
		{
		}

		[Address(RVA="0x24D29AC", Offset="0x24D29AC", VA="0x24D29AC")]
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
		}

		[Address(RVA="0x24D2908", Offset="0x24D2908", VA="0x24D2908")]
		public static Offset<LevelBandedRewardChoice> CreateLevelBandedRewardChoice(FlatBufferBuilder builder, VectorOffset optionsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.LevelBandedRewardChoice> Gamedata.LevelBandedRewardChoice::CreateLevelBandedRewardChoice(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.LevelBandedRewardChoice> CreateLevelBandedRewardChoice(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D2A98", Offset="0x24D2A98", VA="0x24D2A98")]
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<LevelBandedRewardChoiceOption>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D29E8", Offset="0x24D29E8", VA="0x24D29E8")]
		public static Offset<LevelBandedRewardChoice> EndLevelBandedRewardChoice(FlatBufferBuilder builder)
		{
			return new Offset<LevelBandedRewardChoice>();
		}

		[Address(RVA="0x24D26AC", Offset="0x24D26AC", VA="0x24D26AC")]
		public static LevelBandedRewardChoice GetRootAsLevelBandedRewardChoice(FlatBuffers.ByteBuffer _bb)
		{
			return new LevelBandedRewardChoice();
		}

		[Address(RVA="0x24D26B8", Offset="0x24D26B8", VA="0x24D26B8")]
		public static LevelBandedRewardChoice GetRootAsLevelBandedRewardChoice(FlatBuffers.ByteBuffer _bb, LevelBandedRewardChoice obj)
		{
			return new LevelBandedRewardChoice();
		}

		[Address(RVA="0xF563F4", Offset="0xF563F4", VA="0xF563F4")]
		public LevelBandedRewardChoiceOption? Options(int j)
		{
			return null;
		}

		[Address(RVA="0x24D2A68", Offset="0x24D2A68", VA="0x24D2A68")]
		public static void StartLevelBandedRewardChoice(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24D2B90", Offset="0x24D2B90", VA="0x24D2B90")]
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}