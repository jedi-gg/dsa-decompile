using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct Occasion : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56CF0", Offset="0xF56CF0", VA="0xF56CF0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF56D1C", Offset="0xF56D1C", VA="0xF56D1C")]
			get
			{
				return new ulong();
			}
		}

		public Recurrence RecurringType
		{
			[Address(RVA="0xF56D44", Offset="0xF56D44", VA="0xF56D44")]
			get
			{
				return new Recurrence();
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF56D24", Offset="0xF56D24", VA="0xF56D24")]
			get
			{
				return null;
			}
		}

		public OccasionSchedule? Schedule
		{
			[Address(RVA="0xF56D3C", Offset="0xF56D3C", VA="0xF56D3C")]
			get
			{
				return null;
			}
		}

		public Gamedata.TimeZone TimeZone
		{
			[Address(RVA="0xF56D4C", Offset="0xF56D4C", VA="0xF56D4C")]
			get
			{
				return new Gamedata.TimeZone();
			}
		}

		[Address(RVA="0xF56D04", Offset="0xF56D04", VA="0xF56D04")]
		public Occasion __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new Occasion();
		}

		[Address(RVA="0xF56CF8", Offset="0xF56CF8", VA="0xF56CF8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D71D0", Offset="0x24D71D0", VA="0x24D71D0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24D720C", Offset="0x24D720C", VA="0x24D720C")]
		public static void AddRecurring(FlatBufferBuilder builder, int recurringOffset)
		{
		}

		[Address(RVA="0x24D72FC", Offset="0x24D72FC", VA="0x24D72FC")]
		public static void AddRecurringType(FlatBufferBuilder builder, Recurrence recurringType)
		{
		}

		[Address(RVA="0x24D7284", Offset="0x24D7284", VA="0x24D7284")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x24D7248", Offset="0x24D7248", VA="0x24D7248")]
		public static void AddSchedule(FlatBufferBuilder builder, Offset<OccasionSchedule> scheduleOffset)
		{
		}

		[Address(RVA="0x24D72C0", Offset="0x24D72C0", VA="0x24D72C0")]
		public static void AddTimeZone(FlatBufferBuilder builder, Gamedata.TimeZone timeZone)
		{
		}

		[Address(RVA="0x24D7118", Offset="0x24D7118", VA="0x24D7118")]
		public static Offset<Occasion> CreateOccasion(FlatBufferBuilder builder, ulong id = 0L, StringOffset requirementOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.Occasion> Gamedata.Occasion::CreateOccasion(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.Offset`1<Gamedata.OccasionSchedule>,Gamedata.Recurrence,System.Int32,Gamedata.TimeZone)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.Occasion> CreateOccasion(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.Offset<Gamedata.OccasionSchedule>,Gamedata.Recurrence,System.Int32,Gamedata.TimeZone)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D7338", Offset="0x24D7338", VA="0x24D7338")]
		public static Offset<Occasion> EndOccasion(FlatBufferBuilder builder)
		{
			return new Offset<Occasion>();
		}

		[Address(RVA="0x24D73E8", Offset="0x24D73E8", VA="0x24D73E8")]
		public static void FinishOccasionBuffer(FlatBufferBuilder builder, Offset<Occasion> offset)
		{
		}

		[Address(RVA="0xF56D2C", Offset="0xF56D2C", VA="0xF56D2C")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x24D6DEC", Offset="0x24D6DEC", VA="0x24D6DEC")]
		public static Occasion GetRootAsOccasion(FlatBuffers.ByteBuffer _bb)
		{
			return new Occasion();
		}

		[Address(RVA="0x24D6DF8", Offset="0x24D6DF8", VA="0x24D6DF8")]
		public static Occasion GetRootAsOccasion(FlatBuffers.ByteBuffer _bb, Occasion obj)
		{
			return new Occasion();
		}

		public Nullable<TTable> Recurring<TTable>()
		where TTable : struct, IFlatbufferObject
		{
			return null;
		}

		[Address(RVA="0x24D73B8", Offset="0x24D73B8", VA="0x24D73B8")]
		public static void StartOccasion(FlatBufferBuilder builder)
		{
		}
	}
}