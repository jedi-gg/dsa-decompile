using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ScheduledEvent : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public bool AllowInstantWin
		{
			[Address(RVA="0xF585DC", Offset="0xF585DC", VA="0xF585DC")]
			get
			{
				return new bool();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58560", Offset="0xF58560", VA="0xF58560", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong EventGroupId
		{
			[Address(RVA="0xF585FC", Offset="0xF585FC", VA="0xF585FC")]
			get
			{
				return new ulong();
			}
		}

		public Gamedata.EventMissionData? EventMissionData
		{
			[Address(RVA="0xF58594", Offset="0xF58594", VA="0xF58594")]
			get
			{
				return null;
			}
		}

		public ulong HudCurrency
		{
			[Address(RVA="0xF585E4", Offset="0xF585E4", VA="0xF585E4")]
			get
			{
				return new ulong();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF5858C", Offset="0xF5858C", VA="0xF5858C")]
			get
			{
				return new ulong();
			}
		}

		public bool IsPermanent
		{
			[Address(RVA="0xF5860C", Offset="0xF5860C", VA="0xF5860C")]
			get
			{
				return new bool();
			}
		}

		public bool LifetimeProgressEvent
		{
			[Address(RVA="0xF585B4", Offset="0xF585B4", VA="0xF585B4")]
			get
			{
				return new bool();
			}
		}

		public Color? LockedColor
		{
			[Address(RVA="0xF585CC", Offset="0xF585CC", VA="0xF585CC")]
			get
			{
				return null;
			}
		}

		public string MarqueeImage
		{
			[Address(RVA="0xF5859C", Offset="0xF5859C", VA="0xF5859C")]
			get
			{
				return null;
			}
		}

		public int MarqueeSortOrder
		{
			[Address(RVA="0xF585F4", Offset="0xF585F4", VA="0xF585F4")]
			get
			{
				return new int();
			}
		}

		public bool ResetLifetimeProgress
		{
			[Address(RVA="0xF58604", Offset="0xF58604", VA="0xF58604")]
			get
			{
				return new bool();
			}
		}

		public ulong ShipmentDefId
		{
			[Address(RVA="0xF585EC", Offset="0xF585EC", VA="0xF585EC")]
			get
			{
				return new ulong();
			}
		}

		public int TimesLength
		{
			[Address(RVA="0xF585C4", Offset="0xF585C4", VA="0xF585C4")]
			get
			{
				return new int();
			}
		}

		public Color? UnlockedColor
		{
			[Address(RVA="0xF585D4", Offset="0xF585D4", VA="0xF585D4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF58574", Offset="0xF58574", VA="0xF58574")]
		public ScheduledEvent __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ScheduledEvent();
		}

		[Address(RVA="0xF58568", Offset="0xF58568", VA="0xF58568", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24E5F70", Offset="0x24E5F70", VA="0x24E5F70")]
		public static void AddAllowInstantWin(FlatBufferBuilder builder, bool allowInstantWin)
		{
		}

		[Address(RVA="0x24E5CA0", Offset="0x24E5CA0", VA="0x24E5CA0")]
		public static void AddEventGroupId(FlatBufferBuilder builder, ulong eventGroupId)
		{
		}

		[Address(RVA="0x24E5EBC", Offset="0x24E5EBC", VA="0x24E5EBC")]
		public static void AddEventMissionData(FlatBufferBuilder builder, Offset<Gamedata.EventMissionData> eventMissionDataOffset)
		{
		}

		[Address(RVA="0x24E5D18", Offset="0x24E5D18", VA="0x24E5D18")]
		public static void AddHudCurrency(FlatBufferBuilder builder, ulong hudCurrency)
		{
		}

		[Address(RVA="0x24E5D54", Offset="0x24E5D54", VA="0x24E5D54")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24E5EF8", Offset="0x24E5EF8", VA="0x24E5EF8")]
		public static void AddIsPermanent(FlatBufferBuilder builder, bool isPermanent)
		{
		}

		[Address(RVA="0x24E5FAC", Offset="0x24E5FAC", VA="0x24E5FAC")]
		public static void AddLifetimeProgressEvent(FlatBufferBuilder builder, bool lifetimeProgressEvent)
		{
		}

		[Address(RVA="0x24E5E08", Offset="0x24E5E08", VA="0x24E5E08")]
		public static void AddLockedColor(FlatBufferBuilder builder, Offset<Color> lockedColorOffset)
		{
		}

		[Address(RVA="0x24E5E80", Offset="0x24E5E80", VA="0x24E5E80")]
		public static void AddMarqueeImage(FlatBufferBuilder builder, StringOffset marqueeImageOffset)
		{
		}

		[Address(RVA="0x24E5D90", Offset="0x24E5D90", VA="0x24E5D90")]
		public static void AddMarqueeSortOrder(FlatBufferBuilder builder, int marqueeSortOrder)
		{
		}

		[Address(RVA="0x24E5F34", Offset="0x24E5F34", VA="0x24E5F34")]
		public static void AddResetLifetimeProgress(FlatBufferBuilder builder, bool resetLifetimeProgress)
		{
		}

		[Address(RVA="0x24E5CDC", Offset="0x24E5CDC", VA="0x24E5CDC")]
		public static void AddShipmentDefId(FlatBufferBuilder builder, ulong shipmentDefId)
		{
		}

		[Address(RVA="0x24E5E44", Offset="0x24E5E44", VA="0x24E5E44")]
		public static void AddTimes(FlatBufferBuilder builder, VectorOffset timesOffset)
		{
		}

		[Address(RVA="0x24E5DCC", Offset="0x24E5DCC", VA="0x24E5DCC")]
		public static void AddUnlockedColor(FlatBufferBuilder builder, Offset<Color> unlockedColorOffset)
		{
		}

		[Address(RVA="0x24E5B3C", Offset="0x24E5B3C", VA="0x24E5B3C")]
		public static Offset<ScheduledEvent> CreateScheduledEvent(FlatBufferBuilder builder, ulong id = 0L, Offset<Gamedata.EventMissionData> event_mission_dataOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ScheduledEvent> Gamedata.ScheduledEvent::CreateScheduledEvent(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset`1<Gamedata.EventMissionData>,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.VectorOffset,FlatBuffers.Offset`1<Gamedata.Color>,FlatBuffers.Offset`1<Gamedata.Color>,System.Boolean,System.UInt64,System.UInt64,System.Int32,System.UInt64,System.Boolean,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ScheduledEvent> CreateScheduledEvent(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset<Gamedata.EventMissionData>,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.VectorOffset,FlatBuffers.Offset<Gamedata.Color>,FlatBuffers.Offset<Gamedata.Color>,System.Boolean,System.UInt64,System.UInt64,System.Int32,System.UInt64,System.Boolean,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24E6098", Offset="0x24E6098", VA="0x24E6098")]
		public static VectorOffset CreateTimesVector(FlatBufferBuilder builder, Offset<ScheduledEventTime>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24E5FE8", Offset="0x24E5FE8", VA="0x24E5FE8")]
		public static Offset<ScheduledEvent> EndScheduledEvent(FlatBufferBuilder builder)
		{
			return new Offset<ScheduledEvent>();
		}

		[Address(RVA="0x24E61CC", Offset="0x24E61CC", VA="0x24E61CC")]
		public static void FinishScheduledEventBuffer(FlatBufferBuilder builder, Offset<ScheduledEvent> offset)
		{
		}

		[Address(RVA="0xF585A4", Offset="0xF585A4", VA="0xF585A4")]
		public ArraySegment<byte>? GetMarqueeImageBytes()
		{
			return null;
		}

		[Address(RVA="0x24E52D8", Offset="0x24E52D8", VA="0x24E52D8")]
		public static ScheduledEvent GetRootAsScheduledEvent(FlatBuffers.ByteBuffer _bb)
		{
			return new ScheduledEvent();
		}

		[Address(RVA="0x24E52E4", Offset="0x24E52E4", VA="0x24E52E4")]
		public static ScheduledEvent GetRootAsScheduledEvent(FlatBuffers.ByteBuffer _bb, ScheduledEvent obj)
		{
			return new ScheduledEvent();
		}

		[Address(RVA="0x24E6068", Offset="0x24E6068", VA="0x24E6068")]
		public static void StartScheduledEvent(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24E6190", Offset="0x24E6190", VA="0x24E6190")]
		public static void StartTimesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF585BC", Offset="0xF585BC", VA="0xF585BC")]
		public ScheduledEventTime? Times(int j)
		{
			return null;
		}
	}
}