using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct DailyLogin : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59C28", Offset="0xF59C28", VA="0xF59C28", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF59C54", Offset="0xF59C54", VA="0xF59C54")]
			get
			{
				return new ulong();
			}
		}

		public Gamedata.Month Month
		{
			[Address(RVA="0xF59C64", Offset="0xF59C64", VA="0xF59C64")]
			get
			{
				return new Gamedata.Month();
			}
		}

		public int RewardsLength
		{
			[Address(RVA="0xF59C74", Offset="0xF59C74", VA="0xF59C74")]
			get
			{
				return new int();
			}
		}

		public int Year
		{
			[Address(RVA="0xF59C5C", Offset="0xF59C5C", VA="0xF59C5C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF59C3C", Offset="0xF59C3C", VA="0xF59C3C")]
		public DailyLogin __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new DailyLogin();
		}

		[Address(RVA="0xF59C30", Offset="0xF59C30", VA="0xF59C30", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x250E720", Offset="0x250E720", VA="0x250E720")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x250E7D4", Offset="0x250E7D4", VA="0x250E7D4")]
		public static void AddMonth(FlatBufferBuilder builder, Gamedata.Month month)
		{
		}

		[Address(RVA="0x250E75C", Offset="0x250E75C", VA="0x250E75C")]
		public static void AddRewards(FlatBufferBuilder builder, VectorOffset rewardsOffset)
		{
		}

		[Address(RVA="0x250E798", Offset="0x250E798", VA="0x250E798")]
		public static void AddYear(FlatBufferBuilder builder, int year)
		{
		}

		[Address(RVA="0x250E690", Offset="0x250E690", VA="0x250E690")]
		public static Offset<DailyLogin> CreateDailyLogin(FlatBufferBuilder builder, ulong id = 0L, int year = 0, Gamedata.Month month = 0, VectorOffset rewardsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.DailyLogin> Gamedata.DailyLogin::CreateDailyLogin(FlatBuffers.FlatBufferBuilder,System.UInt64,System.Int32,Gamedata.Month,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.DailyLogin> CreateDailyLogin(FlatBuffers.FlatBufferBuilder,System.UInt64,System.Int32,Gamedata.Month,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x250E8C0", Offset="0x250E8C0", VA="0x250E8C0")]
		public static VectorOffset CreateRewardsVector(FlatBufferBuilder builder, Offset<ItemCount>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x250E810", Offset="0x250E810", VA="0x250E810")]
		public static Offset<DailyLogin> EndDailyLogin(FlatBufferBuilder builder)
		{
			return new Offset<DailyLogin>();
		}

		[Address(RVA="0x250E9F4", Offset="0x250E9F4", VA="0x250E9F4")]
		public static void FinishDailyLoginBuffer(FlatBufferBuilder builder, Offset<DailyLogin> offset)
		{
		}

		[Address(RVA="0x250E360", Offset="0x250E360", VA="0x250E360")]
		public static DailyLogin GetRootAsDailyLogin(FlatBuffers.ByteBuffer _bb)
		{
			return new DailyLogin();
		}

		[Address(RVA="0x250E36C", Offset="0x250E36C", VA="0x250E36C")]
		public static DailyLogin GetRootAsDailyLogin(FlatBuffers.ByteBuffer _bb, DailyLogin obj)
		{
			return new DailyLogin();
		}

		[Address(RVA="0xF59C6C", Offset="0xF59C6C", VA="0xF59C6C")]
		public ItemCount? Rewards(int j)
		{
			return null;
		}

		[Address(RVA="0x250E890", Offset="0x250E890", VA="0x250E890")]
		public static void StartDailyLogin(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x250E9B8", Offset="0x250E9B8", VA="0x250E9B8")]
		public static void StartRewardsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}