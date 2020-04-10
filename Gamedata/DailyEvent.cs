using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct DailyEvent : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59B88", Offset="0xF59B88", VA="0xF59B88", Slot="5")]
			get
			{
				return null;
			}
		}

		public Gamedata.DayOfWeek? Days
		{
			[Address(RVA="0xF59BC4", Offset="0xF59BC4", VA="0xF59BC4")]
			get
			{
				return null;
			}
		}

		public Gamedata.EventMissionData? EventMissionData
		{
			[Address(RVA="0xF59BBC", Offset="0xF59BBC", VA="0xF59BBC")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF59BB4", Offset="0xF59BB4", VA="0xF59BB4")]
			get
			{
				return new ulong();
			}
		}

		public Color? LockedColor
		{
			[Address(RVA="0xF59BCC", Offset="0xF59BCC", VA="0xF59BCC")]
			get
			{
				return null;
			}
		}

		public Color? UnlockedColor
		{
			[Address(RVA="0xF59BD4", Offset="0xF59BD4", VA="0xF59BD4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF59B9C", Offset="0xF59B9C", VA="0xF59B9C")]
		public DailyEvent __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new DailyEvent();
		}

		[Address(RVA="0xF59B90", Offset="0xF59B90", VA="0xF59B90", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x250E1FC", Offset="0x250E1FC", VA="0x250E1FC")]
		public static void AddDays(FlatBufferBuilder builder, Offset<Gamedata.DayOfWeek> daysOffset)
		{
		}

		[Address(RVA="0x250E238", Offset="0x250E238", VA="0x250E238")]
		public static void AddEventMissionData(FlatBufferBuilder builder, Offset<Gamedata.EventMissionData> eventMissionDataOffset)
		{
		}

		[Address(RVA="0x250E148", Offset="0x250E148", VA="0x250E148")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x250E1C0", Offset="0x250E1C0", VA="0x250E1C0")]
		public static void AddLockedColor(FlatBufferBuilder builder, Offset<Color> lockedColorOffset)
		{
		}

		[Address(RVA="0x250E184", Offset="0x250E184", VA="0x250E184")]
		public static void AddUnlockedColor(FlatBufferBuilder builder, Offset<Color> unlockedColorOffset)
		{
		}

		[Address(RVA="0x250E0A8", Offset="0x250E0A8", VA="0x250E0A8")]
		public static Offset<DailyEvent> CreateDailyEvent(FlatBufferBuilder builder, ulong id = 0L, Offset<Gamedata.EventMissionData> event_mission_dataOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.DailyEvent> Gamedata.DailyEvent::CreateDailyEvent(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset`1<Gamedata.EventMissionData>,FlatBuffers.Offset`1<Gamedata.DayOfWeek>,FlatBuffers.Offset`1<Gamedata.Color>,FlatBuffers.Offset`1<Gamedata.Color>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.DailyEvent> CreateDailyEvent(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset<Gamedata.EventMissionData>,FlatBuffers.Offset<Gamedata.DayOfWeek>,FlatBuffers.Offset<Gamedata.Color>,FlatBuffers.Offset<Gamedata.Color>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x250E274", Offset="0x250E274", VA="0x250E274")]
		public static Offset<DailyEvent> EndDailyEvent(FlatBufferBuilder builder)
		{
			return new Offset<DailyEvent>();
		}

		[Address(RVA="0x250E324", Offset="0x250E324", VA="0x250E324")]
		public static void FinishDailyEventBuffer(FlatBufferBuilder builder, Offset<DailyEvent> offset)
		{
		}

		[Address(RVA="0x250DC40", Offset="0x250DC40", VA="0x250DC40")]
		public static DailyEvent GetRootAsDailyEvent(FlatBuffers.ByteBuffer _bb)
		{
			return new DailyEvent();
		}

		[Address(RVA="0x250DC4C", Offset="0x250DC4C", VA="0x250DC4C")]
		public static DailyEvent GetRootAsDailyEvent(FlatBuffers.ByteBuffer _bb, DailyEvent obj)
		{
			return new DailyEvent();
		}

		[Address(RVA="0x250E2F4", Offset="0x250E2F4", VA="0x250E2F4")]
		public static void StartDailyEvent(FlatBufferBuilder builder)
		{
		}
	}
}