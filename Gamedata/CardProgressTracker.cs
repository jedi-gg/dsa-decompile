using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct CardProgressTracker : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF4357C", Offset="0xF4357C", VA="0xF4357C", Slot="5")]
			get
			{
				return null;
			}
		}

		public CardProgressTrackerCategory Category
		{
			[Address(RVA="0xF435B8", Offset="0xF435B8", VA="0xF435B8")]
			get
			{
				return new CardProgressTrackerCategory();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF435A8", Offset="0xF435A8", VA="0xF435A8")]
			get
			{
				return new ulong();
			}
		}

		public int SpecificSpellsLength
		{
			[Address(RVA="0xF435F0", Offset="0xF435F0", VA="0xF435F0")]
			get
			{
				return new int();
			}
		}

		public int SpecificUnitsLength
		{
			[Address(RVA="0xF435D0", Offset="0xF435D0", VA="0xF435D0")]
			get
			{
				return new int();
			}
		}

		public CardProgressTrackerStrategy Strategy
		{
			[Address(RVA="0xF435C0", Offset="0xF435C0", VA="0xF435C0")]
			get
			{
				return new CardProgressTrackerStrategy();
			}
		}

		public int Weight
		{
			[Address(RVA="0xF435B0", Offset="0xF435B0", VA="0xF435B0")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF43590", Offset="0xF43590", VA="0xF43590")]
		public CardProgressTracker __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new CardProgressTracker();
		}

		[Address(RVA="0xF43584", Offset="0xF43584", VA="0xF43584", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x23206CC", Offset="0x23206CC", VA="0x23206CC")]
		public static void AddCategory(FlatBufferBuilder builder, CardProgressTrackerCategory category)
		{
		}

		[Address(RVA="0x23205A0", Offset="0x23205A0", VA="0x23205A0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x23205DC", Offset="0x23205DC", VA="0x23205DC")]
		public static void AddSpecificSpells(FlatBufferBuilder builder, VectorOffset specificSpellsOffset)
		{
		}

		[Address(RVA="0x2320618", Offset="0x2320618", VA="0x2320618")]
		public static void AddSpecificUnits(FlatBufferBuilder builder, VectorOffset specificUnitsOffset)
		{
		}

		[Address(RVA="0x2320690", Offset="0x2320690", VA="0x2320690")]
		public static void AddStrategy(FlatBufferBuilder builder, CardProgressTrackerStrategy strategy)
		{
		}

		[Address(RVA="0x2320654", Offset="0x2320654", VA="0x2320654")]
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
		}

		[Address(RVA="0x23204E8", Offset="0x23204E8", VA="0x23204E8")]
		public static Offset<CardProgressTracker> CreateCardProgressTracker(FlatBufferBuilder builder, ulong id = 0L, int weight = 0, CardProgressTrackerCategory category = 0, CardProgressTrackerStrategy strategy = 0, VectorOffset specific_unitsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.CardProgressTracker> Gamedata.CardProgressTracker::CreateCardProgressTracker(FlatBuffers.FlatBufferBuilder,System.UInt64,System.Int32,Gamedata.CardProgressTrackerCategory,Gamedata.CardProgressTrackerStrategy,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.CardProgressTracker> CreateCardProgressTracker(FlatBuffers.FlatBufferBuilder,System.UInt64,System.Int32,Gamedata.CardProgressTrackerCategory,Gamedata.CardProgressTrackerStrategy,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x23208EC", Offset="0x23208EC", VA="0x23208EC")]
		public static VectorOffset CreateSpecificSpellsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x23207B8", Offset="0x23207B8", VA="0x23207B8")]
		public static VectorOffset CreateSpecificUnitsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2320708", Offset="0x2320708", VA="0x2320708")]
		public static Offset<CardProgressTracker> EndCardProgressTracker(FlatBufferBuilder builder)
		{
			return new Offset<CardProgressTracker>();
		}

		[Address(RVA="0x2320A20", Offset="0x2320A20", VA="0x2320A20")]
		public static void FinishCardProgressTrackerBuffer(FlatBufferBuilder builder, Offset<CardProgressTracker> offset)
		{
		}

		[Address(RVA="0x23200C8", Offset="0x23200C8", VA="0x23200C8")]
		public static CardProgressTracker GetRootAsCardProgressTracker(FlatBuffers.ByteBuffer _bb)
		{
			return new CardProgressTracker();
		}

		[Address(RVA="0x23200D4", Offset="0x23200D4", VA="0x23200D4")]
		public static CardProgressTracker GetRootAsCardProgressTracker(FlatBuffers.ByteBuffer _bb, CardProgressTracker obj)
		{
			return new CardProgressTracker();
		}

		[Address(RVA="0xF435F8", Offset="0xF435F8", VA="0xF435F8")]
		public ArraySegment<byte>? GetSpecificSpellsBytes()
		{
			return null;
		}

		[Address(RVA="0xF435D8", Offset="0xF435D8", VA="0xF435D8")]
		public ArraySegment<byte>? GetSpecificUnitsBytes()
		{
			return null;
		}

		[Address(RVA="0xF435E8", Offset="0xF435E8", VA="0xF435E8")]
		public ulong SpecificSpells(int j)
		{
			return new ulong();
		}

		[Address(RVA="0xF435C8", Offset="0xF435C8", VA="0xF435C8")]
		public ulong SpecificUnits(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x2320788", Offset="0x2320788", VA="0x2320788")]
		public static void StartCardProgressTracker(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x23209E4", Offset="0x23209E4", VA="0x23209E4")]
		public static void StartSpecificSpellsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x23208B0", Offset="0x23208B0", VA="0x23208B0")]
		public static void StartSpecificUnitsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}