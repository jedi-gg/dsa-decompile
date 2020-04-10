using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct MonthlyRecurrence : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56AF8", Offset="0xF56AF8", VA="0xF56AF8", Slot="5")]
			get
			{
				return null;
			}
		}

		public Gamedata.DayOfWeek? Day
		{
			[Address(RVA="0xF56B34", Offset="0xF56B34", VA="0xF56B34")]
			get
			{
				return null;
			}
		}

		public MonthlyInstance Instance
		{
			[Address(RVA="0xF56B2C", Offset="0xF56B2C", VA="0xF56B2C")]
			get
			{
				return new MonthlyInstance();
			}
		}

		public sbyte Rate
		{
			[Address(RVA="0xF56B24", Offset="0xF56B24", VA="0xF56B24")]
			get
			{
				return new sbyte();
			}
		}

		[Address(RVA="0xF56B0C", Offset="0xF56B0C", VA="0xF56B0C")]
		public MonthlyRecurrence __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new MonthlyRecurrence();
		}

		[Address(RVA="0xF56B00", Offset="0xF56B00", VA="0xF56B00", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D6424", Offset="0x24D6424", VA="0x24D6424")]
		public static void AddDay(FlatBufferBuilder builder, Offset<Gamedata.DayOfWeek> dayOffset)
		{
		}

		[Address(RVA="0x24D6460", Offset="0x24D6460", VA="0x24D6460")]
		public static void AddInstance(FlatBufferBuilder builder, MonthlyInstance instance)
		{
		}

		[Address(RVA="0x24D649C", Offset="0x24D649C", VA="0x24D649C")]
		public static void AddRate(FlatBufferBuilder builder, sbyte rate)
		{
		}

		[Address(RVA="0x24D63AC", Offset="0x24D63AC", VA="0x24D63AC")]
		public static Offset<MonthlyRecurrence> CreateMonthlyRecurrence(FlatBufferBuilder builder, sbyte rate = 0, MonthlyInstance instance = 0, Offset<Gamedata.DayOfWeek> dayOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.MonthlyRecurrence> Gamedata.MonthlyRecurrence::CreateMonthlyRecurrence(FlatBuffers.FlatBufferBuilder,System.SByte,Gamedata.MonthlyInstance,FlatBuffers.Offset`1<Gamedata.DayOfWeek>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.MonthlyRecurrence> CreateMonthlyRecurrence(FlatBuffers.FlatBufferBuilder,System.SByte,Gamedata.MonthlyInstance,FlatBuffers.Offset<Gamedata.DayOfWeek>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D64D8", Offset="0x24D64D8", VA="0x24D64D8")]
		public static Offset<MonthlyRecurrence> EndMonthlyRecurrence(FlatBufferBuilder builder)
		{
			return new Offset<MonthlyRecurrence>();
		}

		[Address(RVA="0x24D6138", Offset="0x24D6138", VA="0x24D6138")]
		public static MonthlyRecurrence GetRootAsMonthlyRecurrence(FlatBuffers.ByteBuffer _bb)
		{
			return new MonthlyRecurrence();
		}

		[Address(RVA="0x24D6144", Offset="0x24D6144", VA="0x24D6144")]
		public static MonthlyRecurrence GetRootAsMonthlyRecurrence(FlatBuffers.ByteBuffer _bb, MonthlyRecurrence obj)
		{
			return new MonthlyRecurrence();
		}

		[Address(RVA="0x24D6558", Offset="0x24D6558", VA="0x24D6558")]
		public static void StartMonthlyRecurrence(FlatBufferBuilder builder)
		{
		}
	}
}