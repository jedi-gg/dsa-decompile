using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleFormation : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A310", Offset="0xF0A310", VA="0xF0A310", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0A33C", Offset="0xF0A33C", VA="0xF0A33C")]
			get
			{
				return new ulong();
			}
		}

		public int LeftSpawnPointsLength
		{
			[Address(RVA="0xF0A34C", Offset="0xF0A34C", VA="0xF0A34C")]
			get
			{
				return new int();
			}
		}

		public int RightSpawnPointsLength
		{
			[Address(RVA="0xF0A35C", Offset="0xF0A35C", VA="0xF0A35C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF0A324", Offset="0xF0A324", VA="0xF0A324")]
		public BattleFormation __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleFormation();
		}

		[Address(RVA="0xF0A318", Offset="0xF0A318", VA="0xF0A318", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F0D74", Offset="0x15F0D74", VA="0x15F0D74")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15F0DEC", Offset="0x15F0DEC", VA="0x15F0DEC")]
		public static void AddLeftSpawnPoints(FlatBufferBuilder builder, VectorOffset leftSpawnPointsOffset)
		{
		}

		[Address(RVA="0x15F0DB0", Offset="0x15F0DB0", VA="0x15F0DB0")]
		public static void AddRightSpawnPoints(FlatBufferBuilder builder, VectorOffset rightSpawnPointsOffset)
		{
		}

		[Address(RVA="0x15F0CFC", Offset="0x15F0CFC", VA="0x15F0CFC")]
		public static Offset<BattleFormation> CreateBattleFormation(FlatBufferBuilder builder, ulong id = 0L, VectorOffset left_spawn_pointsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleFormation> Gamedata.BattleFormation::CreateBattleFormation(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleFormation> CreateBattleFormation(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F0ED8", Offset="0x15F0ED8", VA="0x15F0ED8")]
		public static VectorOffset CreateLeftSpawnPointsVector(FlatBufferBuilder builder, Offset<BattleSpawnPoint>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15F100C", Offset="0x15F100C", VA="0x15F100C")]
		public static VectorOffset CreateRightSpawnPointsVector(FlatBufferBuilder builder, Offset<BattleSpawnPoint>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15F0E28", Offset="0x15F0E28", VA="0x15F0E28")]
		public static Offset<BattleFormation> EndBattleFormation(FlatBufferBuilder builder)
		{
			return new Offset<BattleFormation>();
		}

		[Address(RVA="0x15F1140", Offset="0x15F1140", VA="0x15F1140")]
		public static void FinishBattleFormationBuffer(FlatBufferBuilder builder, Offset<BattleFormation> offset)
		{
		}

		[Address(RVA="0x15F0994", Offset="0x15F0994", VA="0x15F0994")]
		public static BattleFormation GetRootAsBattleFormation(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleFormation();
		}

		[Address(RVA="0x15F09A0", Offset="0x15F09A0", VA="0x15F09A0")]
		public static BattleFormation GetRootAsBattleFormation(FlatBuffers.ByteBuffer _bb, BattleFormation obj)
		{
			return new BattleFormation();
		}

		[Address(RVA="0xF0A344", Offset="0xF0A344", VA="0xF0A344")]
		public BattleSpawnPoint? LeftSpawnPoints(int j)
		{
			return null;
		}

		[Address(RVA="0xF0A354", Offset="0xF0A354", VA="0xF0A354")]
		public BattleSpawnPoint? RightSpawnPoints(int j)
		{
			return null;
		}

		[Address(RVA="0x15F0EA8", Offset="0x15F0EA8", VA="0x15F0EA8")]
		public static void StartBattleFormation(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x15F0FD0", Offset="0x15F0FD0", VA="0x15F0FD0")]
		public static void StartLeftSpawnPointsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x15F1104", Offset="0x15F1104", VA="0x15F1104")]
		public static void StartRightSpawnPointsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}