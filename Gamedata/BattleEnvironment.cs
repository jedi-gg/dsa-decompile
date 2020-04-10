using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleEnvironment : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ulong BattleFormation
		{
			[Address(RVA="0xF0A2BC", Offset="0xF0A2BC", VA="0xF0A2BC")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A258", Offset="0xF0A258", VA="0xF0A258", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0A284", Offset="0xF0A284", VA="0xF0A284")]
			get
			{
				return new ulong();
			}
		}

		public ulong Map
		{
			[Address(RVA="0xF0A2A4", Offset="0xF0A2A4", VA="0xF0A2A4")]
			get
			{
				return new ulong();
			}
		}

		public int MultiScenePrefabsLength
		{
			[Address(RVA="0xF0A2B4", Offset="0xF0A2B4", VA="0xF0A2B4")]
			get
			{
				return new int();
			}
		}

		public string Prefab
		{
			[Address(RVA="0xF0A28C", Offset="0xF0A28C", VA="0xF0A28C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF0A26C", Offset="0xF0A26C", VA="0xF0A26C")]
		public BattleEnvironment __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleEnvironment();
		}

		[Address(RVA="0xF0A260", Offset="0xF0A260", VA="0xF0A260", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F0648", Offset="0x15F0648", VA="0x15F0648")]
		public static void AddBattleFormation(FlatBufferBuilder builder, ulong battleFormation)
		{
		}

		[Address(RVA="0x15F06C0", Offset="0x15F06C0", VA="0x15F06C0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15F0684", Offset="0x15F0684", VA="0x15F0684")]
		public static void AddMap(FlatBufferBuilder builder, ulong map)
		{
		}

		[Address(RVA="0x15F06FC", Offset="0x15F06FC", VA="0x15F06FC")]
		public static void AddMultiScenePrefabs(FlatBufferBuilder builder, VectorOffset multiScenePrefabsOffset)
		{
		}

		[Address(RVA="0x15F0738", Offset="0x15F0738", VA="0x15F0738")]
		public static void AddPrefab(FlatBufferBuilder builder, StringOffset prefabOffset)
		{
		}

		[Address(RVA="0x15F05A8", Offset="0x15F05A8", VA="0x15F05A8")]
		public static Offset<BattleEnvironment> CreateBattleEnvironment(FlatBufferBuilder builder, ulong id = 0L, StringOffset prefabOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleEnvironment> Gamedata.BattleEnvironment::CreateBattleEnvironment(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,System.UInt64,FlatBuffers.VectorOffset,System.UInt64)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleEnvironment> CreateBattleEnvironment(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,System.UInt64,FlatBuffers.VectorOffset,System.UInt64)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F0824", Offset="0x15F0824", VA="0x15F0824")]
		public static VectorOffset CreateMultiScenePrefabsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15F0774", Offset="0x15F0774", VA="0x15F0774")]
		public static Offset<BattleEnvironment> EndBattleEnvironment(FlatBufferBuilder builder)
		{
			return new Offset<BattleEnvironment>();
		}

		[Address(RVA="0x15F0958", Offset="0x15F0958", VA="0x15F0958")]
		public static void FinishBattleEnvironmentBuffer(FlatBufferBuilder builder, Offset<BattleEnvironment> offset)
		{
		}

		[Address(RVA="0xF0A294", Offset="0xF0A294", VA="0xF0A294")]
		public ArraySegment<byte>? GetPrefabBytes()
		{
			return null;
		}

		[Address(RVA="0x15F0290", Offset="0x15F0290", VA="0x15F0290")]
		public static BattleEnvironment GetRootAsBattleEnvironment(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleEnvironment();
		}

		[Address(RVA="0x15F029C", Offset="0x15F029C", VA="0x15F029C")]
		public static BattleEnvironment GetRootAsBattleEnvironment(FlatBuffers.ByteBuffer _bb, BattleEnvironment obj)
		{
			return new BattleEnvironment();
		}

		[Address(RVA="0xF0A2AC", Offset="0xF0A2AC", VA="0xF0A2AC")]
		public string MultiScenePrefabs(int j)
		{
			return null;
		}

		[Address(RVA="0x15F07F4", Offset="0x15F07F4", VA="0x15F07F4")]
		public static void StartBattleEnvironment(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x15F091C", Offset="0x15F091C", VA="0x15F091C")]
		public static void StartMultiScenePrefabsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}