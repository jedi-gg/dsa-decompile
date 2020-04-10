using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleAbilityCodes : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A018", Offset="0xF0A018", VA="0xF0A018", Slot="5")]
			get
			{
				return null;
			}
		}

		public int FailureCodesLength
		{
			[Address(RVA="0xF0A054", Offset="0xF0A054", VA="0xF0A054")]
			get
			{
				return new int();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0A044", Offset="0xF0A044", VA="0xF0A044")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF0A02C", Offset="0xF0A02C", VA="0xF0A02C")]
		public BattleAbilityCodes __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleAbilityCodes();
		}

		[Address(RVA="0xF0A020", Offset="0xF0A020", VA="0xF0A020", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15EF6EC", Offset="0x15EF6EC", VA="0x15EF6EC")]
		public static void AddFailureCodes(FlatBufferBuilder builder, VectorOffset failureCodesOffset)
		{
		}

		[Address(RVA="0x15EF6B0", Offset="0x15EF6B0", VA="0x15EF6B0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15EF648", Offset="0x15EF648", VA="0x15EF648")]
		public static Offset<BattleAbilityCodes> CreateBattleAbilityCodes(FlatBufferBuilder builder, ulong id = 0L, VectorOffset failure_codesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleAbilityCodes> Gamedata.BattleAbilityCodes::CreateBattleAbilityCodes(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleAbilityCodes> CreateBattleAbilityCodes(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15EF7D8", Offset="0x15EF7D8", VA="0x15EF7D8")]
		public static VectorOffset CreateFailureCodesVector(FlatBufferBuilder builder, Offset<BattleAbilityCode>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15EF728", Offset="0x15EF728", VA="0x15EF728")]
		public static Offset<BattleAbilityCodes> EndBattleAbilityCodes(FlatBufferBuilder builder)
		{
			return new Offset<BattleAbilityCodes>();
		}

		[Address(RVA="0xF0A04C", Offset="0xF0A04C", VA="0xF0A04C")]
		public BattleAbilityCode? FailureCodes(int j)
		{
			return null;
		}

		[Address(RVA="0x15EF90C", Offset="0x15EF90C", VA="0x15EF90C")]
		public static void FinishBattleAbilityCodesBuffer(FlatBufferBuilder builder, Offset<BattleAbilityCodes> offset)
		{
		}

		[Address(RVA="0x15EF400", Offset="0x15EF400", VA="0x15EF400")]
		public static BattleAbilityCodes GetRootAsBattleAbilityCodes(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleAbilityCodes();
		}

		[Address(RVA="0x15EF40C", Offset="0x15EF40C", VA="0x15EF40C")]
		public static BattleAbilityCodes GetRootAsBattleAbilityCodes(FlatBuffers.ByteBuffer _bb, BattleAbilityCodes obj)
		{
			return new BattleAbilityCodes();
		}

		[Address(RVA="0x15EF7A8", Offset="0x15EF7A8", VA="0x15EF7A8")]
		public static void StartBattleAbilityCodes(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x15EF8D0", Offset="0x15EF8D0", VA="0x15EF8D0")]
		public static void StartFailureCodesVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}