using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct WeeklyRecurrence : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0C608", Offset="0xF0C608", VA="0xF0C608", Slot="5")]
			get
			{
				return null;
			}
		}

		public Gamedata.DayOfWeek? Days
		{
			[Address(RVA="0xF0C63C", Offset="0xF0C63C", VA="0xF0C63C")]
			get
			{
				return null;
			}
		}

		public sbyte Rate
		{
			[Address(RVA="0xF0C634", Offset="0xF0C634", VA="0xF0C634")]
			get
			{
				return new sbyte();
			}
		}

		[Address(RVA="0xF0C61C", Offset="0xF0C61C", VA="0xF0C61C")]
		public WeeklyRecurrence __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new WeeklyRecurrence();
		}

		[Address(RVA="0xF0C610", Offset="0xF0C610", VA="0xF0C610", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x16819DC", Offset="0x16819DC", VA="0x16819DC")]
		public static void AddDays(FlatBufferBuilder builder, Offset<Gamedata.DayOfWeek> daysOffset)
		{
		}

		[Address(RVA="0x1681A18", Offset="0x1681A18", VA="0x1681A18")]
		public static void AddRate(FlatBufferBuilder builder, sbyte rate)
		{
		}

		[Address(RVA="0x1681974", Offset="0x1681974", VA="0x1681974")]
		public static Offset<WeeklyRecurrence> CreateWeeklyRecurrence(FlatBufferBuilder builder, sbyte rate = 0, Offset<Gamedata.DayOfWeek> daysOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.WeeklyRecurrence> Gamedata.WeeklyRecurrence::CreateWeeklyRecurrence(FlatBuffers.FlatBufferBuilder,System.SByte,FlatBuffers.Offset`1<Gamedata.DayOfWeek>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.WeeklyRecurrence> CreateWeeklyRecurrence(FlatBuffers.FlatBufferBuilder,System.SByte,FlatBuffers.Offset<Gamedata.DayOfWeek>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1681A54", Offset="0x1681A54", VA="0x1681A54")]
		public static Offset<WeeklyRecurrence> EndWeeklyRecurrence(FlatBufferBuilder builder)
		{
			return new Offset<WeeklyRecurrence>();
		}

		[Address(RVA="0x1681768", Offset="0x1681768", VA="0x1681768")]
		public static WeeklyRecurrence GetRootAsWeeklyRecurrence(FlatBuffers.ByteBuffer _bb)
		{
			return new WeeklyRecurrence();
		}

		[Address(RVA="0x1681774", Offset="0x1681774", VA="0x1681774")]
		public static WeeklyRecurrence GetRootAsWeeklyRecurrence(FlatBuffers.ByteBuffer _bb, WeeklyRecurrence obj)
		{
			return new WeeklyRecurrence();
		}

		[Address(RVA="0x1681AD4", Offset="0x1681AD4", VA="0x1681AD4")]
		public static void StartWeeklyRecurrence(FlatBufferBuilder builder)
		{
		}
	}
}