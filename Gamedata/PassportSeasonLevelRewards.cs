using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PassportSeasonLevelRewards : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF572C0", Offset="0xF572C0", VA="0xF572C0", Slot="5")]
			get
			{
				return null;
			}
		}

		public int FreeLength
		{
			[Address(RVA="0xF572F4", Offset="0xF572F4", VA="0xF572F4")]
			get
			{
				return new int();
			}
		}

		public int PremiumLength
		{
			[Address(RVA="0xF57304", Offset="0xF57304", VA="0xF57304")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF572D4", Offset="0xF572D4", VA="0xF572D4")]
		public PassportSeasonLevelRewards __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PassportSeasonLevelRewards();
		}

		[Address(RVA="0xF572C8", Offset="0xF572C8", VA="0xF572C8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DA464", Offset="0x24DA464", VA="0x24DA464")]
		public static void AddFree(FlatBufferBuilder builder, VectorOffset freeOffset)
		{
		}

		[Address(RVA="0x24DA428", Offset="0x24DA428", VA="0x24DA428")]
		public static void AddPremium(FlatBufferBuilder builder, VectorOffset premiumOffset)
		{
		}

		[Address(RVA="0x24DA550", Offset="0x24DA550", VA="0x24DA550")]
		public static VectorOffset CreateFreeVector(FlatBufferBuilder builder, Offset<ItemCount>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DA3C0", Offset="0x24DA3C0", VA="0x24DA3C0")]
		public static Offset<PassportSeasonLevelRewards> CreatePassportSeasonLevelRewards(FlatBufferBuilder builder, VectorOffset freeOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PassportSeasonLevelRewards> Gamedata.PassportSeasonLevelRewards::CreatePassportSeasonLevelRewards(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PassportSeasonLevelRewards> CreatePassportSeasonLevelRewards(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24DA684", Offset="0x24DA684", VA="0x24DA684")]
		public static VectorOffset CreatePremiumVector(FlatBufferBuilder builder, Offset<ItemCount>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DA4A0", Offset="0x24DA4A0", VA="0x24DA4A0")]
		public static Offset<PassportSeasonLevelRewards> EndPassportSeasonLevelRewards(FlatBufferBuilder builder)
		{
			return new Offset<PassportSeasonLevelRewards>();
		}

		[Address(RVA="0xF572EC", Offset="0xF572EC", VA="0xF572EC")]
		public ItemCount? Free(int j)
		{
			return null;
		}

		[Address(RVA="0x24DA0AC", Offset="0x24DA0AC", VA="0x24DA0AC")]
		public static PassportSeasonLevelRewards GetRootAsPassportSeasonLevelRewards(FlatBuffers.ByteBuffer _bb)
		{
			return new PassportSeasonLevelRewards();
		}

		[Address(RVA="0x24DA0B8", Offset="0x24DA0B8", VA="0x24DA0B8")]
		public static PassportSeasonLevelRewards GetRootAsPassportSeasonLevelRewards(FlatBuffers.ByteBuffer _bb, PassportSeasonLevelRewards obj)
		{
			return new PassportSeasonLevelRewards();
		}

		[Address(RVA="0xF572FC", Offset="0xF572FC", VA="0xF572FC")]
		public ItemCount? Premium(int j)
		{
			return null;
		}

		[Address(RVA="0x24DA648", Offset="0x24DA648", VA="0x24DA648")]
		public static void StartFreeVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24DA520", Offset="0x24DA520", VA="0x24DA520")]
		public static void StartPassportSeasonLevelRewards(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24DA77C", Offset="0x24DA77C", VA="0x24DA77C")]
		public static void StartPremiumVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}