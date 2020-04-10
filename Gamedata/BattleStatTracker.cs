using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleStatTracker : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0AC10", Offset="0xF0AC10", VA="0xF0AC10", Slot="5")]
			get
			{
				return null;
			}
		}

		public string ClassName
		{
			[Address(RVA="0xF0AC44", Offset="0xF0AC44", VA="0xF0AC44")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0AC3C", Offset="0xF0AC3C", VA="0xF0AC3C")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF0AC24", Offset="0xF0AC24", VA="0xF0AC24")]
		public BattleStatTracker __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleStatTracker();
		}

		[Address(RVA="0xF0AC18", Offset="0xF0AC18", VA="0xF0AC18", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F6484", Offset="0x15F6484", VA="0x15F6484")]
		public static void AddClassName(FlatBufferBuilder builder, StringOffset classNameOffset)
		{
		}

		[Address(RVA="0x15F6448", Offset="0x15F6448", VA="0x15F6448")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15F63E0", Offset="0x15F63E0", VA="0x15F63E0")]
		public static Offset<BattleStatTracker> CreateBattleStatTracker(FlatBufferBuilder builder, ulong id = 0L, StringOffset class_nameOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleStatTracker> Gamedata.BattleStatTracker::CreateBattleStatTracker(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleStatTracker> CreateBattleStatTracker(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F64C0", Offset="0x15F64C0", VA="0x15F64C0")]
		public static Offset<BattleStatTracker> EndBattleStatTracker(FlatBufferBuilder builder)
		{
			return new Offset<BattleStatTracker>();
		}

		[Address(RVA="0x15F6570", Offset="0x15F6570", VA="0x15F6570")]
		public static void FinishBattleStatTrackerBuffer(FlatBufferBuilder builder, Offset<BattleStatTracker> offset)
		{
		}

		[Address(RVA="0xF0AC4C", Offset="0xF0AC4C", VA="0xF0AC4C")]
		public ArraySegment<byte>? GetClassNameBytes()
		{
			return null;
		}

		[Address(RVA="0x15F6248", Offset="0x15F6248", VA="0x15F6248")]
		public static BattleStatTracker GetRootAsBattleStatTracker(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleStatTracker();
		}

		[Address(RVA="0x15F6254", Offset="0x15F6254", VA="0x15F6254")]
		public static BattleStatTracker GetRootAsBattleStatTracker(FlatBuffers.ByteBuffer _bb, BattleStatTracker obj)
		{
			return new BattleStatTracker();
		}

		[Address(RVA="0x15F6540", Offset="0x15F6540", VA="0x15F6540")]
		public static void StartBattleStatTracker(FlatBufferBuilder builder)
		{
		}
	}
}