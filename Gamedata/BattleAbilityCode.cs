using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleAbilityCode : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF09F80", Offset="0xF09F80", VA="0xF09F80", Slot="5")]
			get
			{
				return null;
			}
		}

		public sbyte Code
		{
			[Address(RVA="0xF09FAC", Offset="0xF09FAC", VA="0xF09FAC")]
			get
			{
				return new sbyte();
			}
		}

		public string LocKey
		{
			[Address(RVA="0xF09FB4", Offset="0xF09FB4", VA="0xF09FB4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF09F94", Offset="0xF09F94", VA="0xF09F94")]
		public BattleAbilityCode __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleAbilityCode();
		}

		[Address(RVA="0xF09F88", Offset="0xF09F88", VA="0xF09F88", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15EF30C", Offset="0x15EF30C", VA="0x15EF30C")]
		public static void AddCode(FlatBufferBuilder builder, sbyte code)
		{
		}

		[Address(RVA="0x15EF2D0", Offset="0x15EF2D0", VA="0x15EF2D0")]
		public static void AddLocKey(FlatBufferBuilder builder, StringOffset locKeyOffset)
		{
		}

		[Address(RVA="0x15EF268", Offset="0x15EF268", VA="0x15EF268")]
		public static Offset<BattleAbilityCode> CreateBattleAbilityCode(FlatBufferBuilder builder, sbyte code = 0, StringOffset loc_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleAbilityCode> Gamedata.BattleAbilityCode::CreateBattleAbilityCode(FlatBuffers.FlatBufferBuilder,System.SByte,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleAbilityCode> CreateBattleAbilityCode(FlatBuffers.FlatBufferBuilder,System.SByte,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15EF348", Offset="0x15EF348", VA="0x15EF348")]
		public static Offset<BattleAbilityCode> EndBattleAbilityCode(FlatBufferBuilder builder)
		{
			return new Offset<BattleAbilityCode>();
		}

		[Address(RVA="0xF09FBC", Offset="0xF09FBC", VA="0xF09FBC")]
		public ArraySegment<byte>? GetLocKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x15EF0D4", Offset="0x15EF0D4", VA="0x15EF0D4")]
		public static BattleAbilityCode GetRootAsBattleAbilityCode(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleAbilityCode();
		}

		[Address(RVA="0x15EF0E0", Offset="0x15EF0E0", VA="0x15EF0E0")]
		public static BattleAbilityCode GetRootAsBattleAbilityCode(FlatBuffers.ByteBuffer _bb, BattleAbilityCode obj)
		{
			return new BattleAbilityCode();
		}

		[Address(RVA="0x15EF3C8", Offset="0x15EF3C8", VA="0x15EF3C8")]
		public static void StartBattleAbilityCode(FlatBufferBuilder builder)
		{
		}
	}
}