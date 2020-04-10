using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleAltPrefab : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string BattlePrefab
		{
			[Address(RVA="0xF0A15C", Offset="0xF0A15C", VA="0xF0A15C")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A128", Offset="0xF0A128", VA="0xF0A128", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint Id
		{
			[Address(RVA="0xF0A154", Offset="0xF0A154", VA="0xF0A154")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF0A13C", Offset="0xF0A13C", VA="0xF0A13C")]
		public BattleAltPrefab __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleAltPrefab();
		}

		[Address(RVA="0xF0A130", Offset="0xF0A130", VA="0xF0A130", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15EFDFC", Offset="0x15EFDFC", VA="0x15EFDFC")]
		public static void AddBattlePrefab(FlatBufferBuilder builder, StringOffset battlePrefabOffset)
		{
		}

		[Address(RVA="0x15EFE38", Offset="0x15EFE38", VA="0x15EFE38")]
		public static void AddId(FlatBufferBuilder builder, uint id)
		{
		}

		[Address(RVA="0x15EFD94", Offset="0x15EFD94", VA="0x15EFD94")]
		public static Offset<BattleAltPrefab> CreateBattleAltPrefab(FlatBufferBuilder builder, uint id = 0, StringOffset battle_prefabOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleAltPrefab> Gamedata.BattleAltPrefab::CreateBattleAltPrefab(FlatBuffers.FlatBufferBuilder,System.UInt32,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleAltPrefab> CreateBattleAltPrefab(FlatBuffers.FlatBufferBuilder,System.UInt32,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15EFE74", Offset="0x15EFE74", VA="0x15EFE74")]
		public static Offset<BattleAltPrefab> EndBattleAltPrefab(FlatBufferBuilder builder)
		{
			return new Offset<BattleAltPrefab>();
		}

		[Address(RVA="0xF0A164", Offset="0xF0A164", VA="0xF0A164")]
		public ArraySegment<byte>? GetBattlePrefabBytes()
		{
			return null;
		}

		[Address(RVA="0x15EFC00", Offset="0x15EFC00", VA="0x15EFC00")]
		public static BattleAltPrefab GetRootAsBattleAltPrefab(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleAltPrefab();
		}

		[Address(RVA="0x15EFC0C", Offset="0x15EFC0C", VA="0x15EFC0C")]
		public static BattleAltPrefab GetRootAsBattleAltPrefab(FlatBuffers.ByteBuffer _bb, BattleAltPrefab obj)
		{
			return new BattleAltPrefab();
		}

		[Address(RVA="0x15EFEF4", Offset="0x15EFEF4", VA="0x15EFEF4")]
		public static void StartBattleAltPrefab(FlatBufferBuilder builder)
		{
		}
	}
}