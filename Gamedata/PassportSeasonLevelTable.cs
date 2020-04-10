using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PassportSeasonLevelTable : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57358", Offset="0xF57358", VA="0xF57358", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong LevelPurchaseCostItem
		{
			[Address(RVA="0xF573A4", Offset="0xF573A4", VA="0xF573A4")]
			get
			{
				return new ulong();
			}
		}

		public int LevelPurchaseCostLength
		{
			[Address(RVA="0xF573B4", Offset="0xF573B4", VA="0xF573B4")]
			get
			{
				return new int();
			}
		}

		public int XpRequiredLength
		{
			[Address(RVA="0xF5738C", Offset="0xF5738C", VA="0xF5738C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF5736C", Offset="0xF5736C", VA="0xF5736C")]
		public PassportSeasonLevelTable __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PassportSeasonLevelTable();
		}

		[Address(RVA="0xF57360", Offset="0xF57360", VA="0xF57360", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DAB54", Offset="0x24DAB54", VA="0x24DAB54")]
		public static void AddLevelPurchaseCost(FlatBufferBuilder builder, VectorOffset levelPurchaseCostOffset)
		{
		}

		[Address(RVA="0x24DAB18", Offset="0x24DAB18", VA="0x24DAB18")]
		public static void AddLevelPurchaseCostItem(FlatBufferBuilder builder, ulong levelPurchaseCostItem)
		{
		}

		[Address(RVA="0x24DAB90", Offset="0x24DAB90", VA="0x24DAB90")]
		public static void AddXpRequired(FlatBufferBuilder builder, VectorOffset xpRequiredOffset)
		{
		}

		[Address(RVA="0x24DADB0", Offset="0x24DADB0", VA="0x24DADB0")]
		public static VectorOffset CreateLevelPurchaseCostVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DAAA0", Offset="0x24DAAA0", VA="0x24DAAA0")]
		public static Offset<PassportSeasonLevelTable> CreatePassportSeasonLevelTable(FlatBufferBuilder builder, VectorOffset xp_requiredOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PassportSeasonLevelTable> Gamedata.PassportSeasonLevelTable::CreatePassportSeasonLevelTable(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,System.UInt64,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PassportSeasonLevelTable> CreatePassportSeasonLevelTable(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,System.UInt64,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24DAC7C", Offset="0x24DAC7C", VA="0x24DAC7C")]
		public static VectorOffset CreateXpRequiredVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DABCC", Offset="0x24DABCC", VA="0x24DABCC")]
		public static Offset<PassportSeasonLevelTable> EndPassportSeasonLevelTable(FlatBufferBuilder builder)
		{
			return new Offset<PassportSeasonLevelTable>();
		}

		[Address(RVA="0xF573BC", Offset="0xF573BC", VA="0xF573BC")]
		public ArraySegment<byte>? GetLevelPurchaseCostBytes()
		{
			return null;
		}

		[Address(RVA="0x24DA7C0", Offset="0x24DA7C0", VA="0x24DA7C0")]
		public static PassportSeasonLevelTable GetRootAsPassportSeasonLevelTable(FlatBuffers.ByteBuffer _bb)
		{
			return new PassportSeasonLevelTable();
		}

		[Address(RVA="0x24DA7CC", Offset="0x24DA7CC", VA="0x24DA7CC")]
		public static PassportSeasonLevelTable GetRootAsPassportSeasonLevelTable(FlatBuffers.ByteBuffer _bb, PassportSeasonLevelTable obj)
		{
			return new PassportSeasonLevelTable();
		}

		[Address(RVA="0xF57394", Offset="0xF57394", VA="0xF57394")]
		public ArraySegment<byte>? GetXpRequiredBytes()
		{
			return null;
		}

		[Address(RVA="0xF573AC", Offset="0xF573AC", VA="0xF573AC")]
		public uint LevelPurchaseCost(int j)
		{
			return new uint();
		}

		[Address(RVA="0x24DAEA8", Offset="0x24DAEA8", VA="0x24DAEA8")]
		public static void StartLevelPurchaseCostVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24DAC4C", Offset="0x24DAC4C", VA="0x24DAC4C")]
		public static void StartPassportSeasonLevelTable(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24DAD74", Offset="0x24DAD74", VA="0x24DAD74")]
		public static void StartXpRequiredVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF57384", Offset="0xF57384", VA="0xF57384")]
		public uint XpRequired(int j)
		{
			return new uint();
		}
	}
}