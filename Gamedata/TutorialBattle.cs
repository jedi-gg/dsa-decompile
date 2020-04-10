using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct TutorialBattle : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public sbyte Battle
		{
			[Address(RVA="0xF3B594", Offset="0xF3B594", VA="0xF3B594")]
			get
			{
				return new sbyte();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3B550", Offset="0xF3B550", VA="0xF3B550", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Campaign
		{
			[Address(RVA="0xF3B57C", Offset="0xF3B57C", VA="0xF3B57C")]
			get
			{
				return new ulong();
			}
		}

		public sbyte Map
		{
			[Address(RVA="0xF3B584", Offset="0xF3B584", VA="0xF3B584")]
			get
			{
				return new sbyte();
			}
		}

		public sbyte Node
		{
			[Address(RVA="0xF3B58C", Offset="0xF3B58C", VA="0xF3B58C")]
			get
			{
				return new sbyte();
			}
		}

		public int PlayerUnitsLength
		{
			[Address(RVA="0xF3B5A4", Offset="0xF3B5A4", VA="0xF3B5A4")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF3B564", Offset="0xF3B564", VA="0xF3B564")]
		public TutorialBattle __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new TutorialBattle();
		}

		[Address(RVA="0xF3B558", Offset="0xF3B558", VA="0xF3B558", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22ED1A0", Offset="0x22ED1A0", VA="0x22ED1A0")]
		public static void AddBattle(FlatBufferBuilder builder, sbyte battle)
		{
		}

		[Address(RVA="0x22ED128", Offset="0x22ED128", VA="0x22ED128")]
		public static void AddCampaign(FlatBufferBuilder builder, ulong campaign)
		{
		}

		[Address(RVA="0x22ED218", Offset="0x22ED218", VA="0x22ED218")]
		public static void AddMap(FlatBufferBuilder builder, sbyte map)
		{
		}

		[Address(RVA="0x22ED1DC", Offset="0x22ED1DC", VA="0x22ED1DC")]
		public static void AddNode(FlatBufferBuilder builder, sbyte node)
		{
		}

		[Address(RVA="0x22ED164", Offset="0x22ED164", VA="0x22ED164")]
		public static void AddPlayerUnits(FlatBufferBuilder builder, VectorOffset playerUnitsOffset)
		{
		}

		[Address(RVA="0x22ED304", Offset="0x22ED304", VA="0x22ED304")]
		public static VectorOffset CreatePlayerUnitsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22ED088", Offset="0x22ED088", VA="0x22ED088")]
		public static Offset<TutorialBattle> CreateTutorialBattle(FlatBufferBuilder builder, ulong campaign = 0L, sbyte map = 0, sbyte node = 0, sbyte battle = 0, VectorOffset player_unitsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.TutorialBattle> Gamedata.TutorialBattle::CreateTutorialBattle(FlatBuffers.FlatBufferBuilder,System.UInt64,System.SByte,System.SByte,System.SByte,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.TutorialBattle> CreateTutorialBattle(FlatBuffers.FlatBufferBuilder,System.UInt64,System.SByte,System.SByte,System.SByte,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22ED254", Offset="0x22ED254", VA="0x22ED254")]
		public static Offset<TutorialBattle> EndTutorialBattle(FlatBufferBuilder builder)
		{
			return new Offset<TutorialBattle>();
		}

		[Address(RVA="0xF3B5AC", Offset="0xF3B5AC", VA="0xF3B5AC")]
		public ArraySegment<byte>? GetPlayerUnitsBytes()
		{
			return null;
		}

		[Address(RVA="0x22ECD3C", Offset="0x22ECD3C", VA="0x22ECD3C")]
		public static TutorialBattle GetRootAsTutorialBattle(FlatBuffers.ByteBuffer _bb)
		{
			return new TutorialBattle();
		}

		[Address(RVA="0x22ECD48", Offset="0x22ECD48", VA="0x22ECD48")]
		public static TutorialBattle GetRootAsTutorialBattle(FlatBuffers.ByteBuffer _bb, TutorialBattle obj)
		{
			return new TutorialBattle();
		}

		[Address(RVA="0xF3B59C", Offset="0xF3B59C", VA="0xF3B59C")]
		public ulong PlayerUnits(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x22ED3FC", Offset="0x22ED3FC", VA="0x22ED3FC")]
		public static void StartPlayerUnitsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22ED2D4", Offset="0x22ED2D4", VA="0x22ED2D4")]
		public static void StartTutorialBattle(FlatBufferBuilder builder)
		{
		}
	}
}