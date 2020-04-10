using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PlayerPowerRating : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public int ByAbilityLevelLength
		{
			[Address(RVA="0xF57BE4", Offset="0xF57BE4", VA="0xF57BE4")]
			get
			{
				return new int();
			}
		}

		public int ByEquipmentAtTierLength
		{
			[Address(RVA="0xF57BC4", Offset="0xF57BC4", VA="0xF57BC4")]
			get
			{
				return new int();
			}
		}

		public int ByLevelLength
		{
			[Address(RVA="0xF57B84", Offset="0xF57B84", VA="0xF57B84")]
			get
			{
				return new int();
			}
		}

		public int ByRarityLength
		{
			[Address(RVA="0xF57BA4", Offset="0xF57BA4", VA="0xF57BA4")]
			get
			{
				return new int();
			}
		}

		public int BySpellLevelLength
		{
			[Address(RVA="0xF57C04", Offset="0xF57C04", VA="0xF57C04")]
			get
			{
				return new int();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57B50", Offset="0xF57B50", VA="0xF57B50", Slot="5")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF57B64", Offset="0xF57B64", VA="0xF57B64")]
		public PlayerPowerRating __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PlayerPowerRating();
		}

		[Address(RVA="0xF57B58", Offset="0xF57B58", VA="0xF57B58", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DF388", Offset="0x24DF388", VA="0x24DF388")]
		public static void AddByAbilityLevel(FlatBufferBuilder builder, VectorOffset byAbilityLevelOffset)
		{
		}

		[Address(RVA="0x24DF3C4", Offset="0x24DF3C4", VA="0x24DF3C4")]
		public static void AddByEquipmentAtTier(FlatBufferBuilder builder, VectorOffset byEquipmentAtTierOffset)
		{
		}

		[Address(RVA="0x24DF43C", Offset="0x24DF43C", VA="0x24DF43C")]
		public static void AddByLevel(FlatBufferBuilder builder, VectorOffset byLevelOffset)
		{
		}

		[Address(RVA="0x24DF400", Offset="0x24DF400", VA="0x24DF400")]
		public static void AddByRarity(FlatBufferBuilder builder, VectorOffset byRarityOffset)
		{
		}

		[Address(RVA="0x24DF34C", Offset="0x24DF34C", VA="0x24DF34C")]
		public static void AddBySpellLevel(FlatBufferBuilder builder, VectorOffset bySpellLevelOffset)
		{
		}

		[Address(RVA="0xF57BDC", Offset="0xF57BDC", VA="0xF57BDC")]
		public uint ByAbilityLevel(int j)
		{
			return new uint();
		}

		[Address(RVA="0xF57BBC", Offset="0xF57BBC", VA="0xF57BBC")]
		public uint ByEquipmentAtTier(int j)
		{
			return new uint();
		}

		[Address(RVA="0xF57B7C", Offset="0xF57B7C", VA="0xF57B7C")]
		public uint ByLevel(int j)
		{
			return new uint();
		}

		[Address(RVA="0xF57B9C", Offset="0xF57B9C", VA="0xF57B9C")]
		public uint ByRarity(int j)
		{
			return new uint();
		}

		[Address(RVA="0xF57BFC", Offset="0xF57BFC", VA="0xF57BFC")]
		public uint BySpellLevel(int j)
		{
			return new uint();
		}

		[Address(RVA="0x24DF8C4", Offset="0x24DF8C4", VA="0x24DF8C4")]
		public static VectorOffset CreateByAbilityLevelVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DF790", Offset="0x24DF790", VA="0x24DF790")]
		public static VectorOffset CreateByEquipmentAtTierVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DF528", Offset="0x24DF528", VA="0x24DF528")]
		public static VectorOffset CreateByLevelVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DF65C", Offset="0x24DF65C", VA="0x24DF65C")]
		public static VectorOffset CreateByRarityVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DF9F8", Offset="0x24DF9F8", VA="0x24DF9F8")]
		public static VectorOffset CreateBySpellLevelVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DF2AC", Offset="0x24DF2AC", VA="0x24DF2AC")]
		public static Offset<PlayerPowerRating> CreatePlayerPowerRating(FlatBufferBuilder builder, VectorOffset by_levelOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PlayerPowerRating> Gamedata.PlayerPowerRating::CreatePlayerPowerRating(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PlayerPowerRating> CreatePlayerPowerRating(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24DF478", Offset="0x24DF478", VA="0x24DF478")]
		public static Offset<PlayerPowerRating> EndPlayerPowerRating(FlatBufferBuilder builder)
		{
			return new Offset<PlayerPowerRating>();
		}

		[Address(RVA="0xF57BEC", Offset="0xF57BEC", VA="0xF57BEC")]
		public ArraySegment<byte>? GetByAbilityLevelBytes()
		{
			return null;
		}

		[Address(RVA="0xF57BCC", Offset="0xF57BCC", VA="0xF57BCC")]
		public ArraySegment<byte>? GetByEquipmentAtTierBytes()
		{
			return null;
		}

		[Address(RVA="0xF57B8C", Offset="0xF57B8C", VA="0xF57B8C")]
		public ArraySegment<byte>? GetByLevelBytes()
		{
			return null;
		}

		[Address(RVA="0xF57BAC", Offset="0xF57BAC", VA="0xF57BAC")]
		public ArraySegment<byte>? GetByRarityBytes()
		{
			return null;
		}

		[Address(RVA="0xF57C0C", Offset="0xF57C0C", VA="0xF57C0C")]
		public ArraySegment<byte>? GetBySpellLevelBytes()
		{
			return null;
		}

		[Address(RVA="0x24DEDC8", Offset="0x24DEDC8", VA="0x24DEDC8")]
		public static PlayerPowerRating GetRootAsPlayerPowerRating(FlatBuffers.ByteBuffer _bb)
		{
			return new PlayerPowerRating();
		}

		[Address(RVA="0x24DEDD4", Offset="0x24DEDD4", VA="0x24DEDD4")]
		public static PlayerPowerRating GetRootAsPlayerPowerRating(FlatBuffers.ByteBuffer _bb, PlayerPowerRating obj)
		{
			return new PlayerPowerRating();
		}

		[Address(RVA="0x24DF9BC", Offset="0x24DF9BC", VA="0x24DF9BC")]
		public static void StartByAbilityLevelVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24DF888", Offset="0x24DF888", VA="0x24DF888")]
		public static void StartByEquipmentAtTierVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24DF620", Offset="0x24DF620", VA="0x24DF620")]
		public static void StartByLevelVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24DF754", Offset="0x24DF754", VA="0x24DF754")]
		public static void StartByRarityVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24DFAF0", Offset="0x24DFAF0", VA="0x24DFAF0")]
		public static void StartBySpellLevelVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24DF4F8", Offset="0x24DF4F8", VA="0x24DF4F8")]
		public static void StartPlayerPowerRating(FlatBufferBuilder builder)
		{
		}
	}
}