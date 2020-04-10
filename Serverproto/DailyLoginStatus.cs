using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DailyLoginStatus : IMessage<DailyLoginStatus>, IMessage, IEquatable<DailyLoginStatus>, IDeepCloneable<DailyLoginStatus>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DailyLoginStatus> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DaysClaimedThisMonthFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong daysClaimedThisMonth_;

		[FieldOffset(Offset="0x0")]
		public const int TodayClaimedFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool todayClaimed_;

		[FieldOffset(Offset="0x0")]
		public const int TodayBonusGrantedFieldNumber = 3;

		[FieldOffset(Offset="0x21")]
		private bool todayBonusGranted_;

		[FieldOffset(Offset="0x0")]
		public const int TodayBonusEligibilityTimestampFieldNumber = 4;

		[FieldOffset(Offset="0x28")]
		private ulong todayBonusEligibilityTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int StartingDayTodayFieldNumber = 5;

		[FieldOffset(Offset="0x30")]
		private ulong startingDayToday_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A150", Offset="0x109A150")]
		public ulong DaysClaimedThisMonth
		{
			[Address(RVA="0x1EF65C0", Offset="0x1EF65C0", VA="0x1EF65C0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EF65C8", Offset="0x1EF65C8", VA="0x1EF65C8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A130", Offset="0x109A130")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF6338", Offset="0x1EF6338", VA="0x1EF6338")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A120", Offset="0x109A120")]
		public static MessageParser<DailyLoginStatus> Parser
		{
			[Address(RVA="0x1EF62D0", Offset="0x1EF62D0", VA="0x1EF62D0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A140", Offset="0x109A140")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF6428", Offset="0x1EF6428", VA="0x1EF6428", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A190", Offset="0x109A190")]
		public ulong StartingDayToday
		{
			[Address(RVA="0x1EF6608", Offset="0x1EF6608", VA="0x1EF6608")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EF6610", Offset="0x1EF6610", VA="0x1EF6610")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A180", Offset="0x109A180")]
		public ulong TodayBonusEligibilityTimestamp
		{
			[Address(RVA="0x1EF65F8", Offset="0x1EF65F8", VA="0x1EF65F8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EF6600", Offset="0x1EF6600", VA="0x1EF6600")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A170", Offset="0x109A170")]
		public bool TodayBonusGranted
		{
			[Address(RVA="0x1EF65E4", Offset="0x1EF65E4", VA="0x1EF65E4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1EF65EC", Offset="0x1EF65EC", VA="0x1EF65EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A160", Offset="0x109A160")]
		public bool TodayClaimed
		{
			[Address(RVA="0x1EF65D0", Offset="0x1EF65D0", VA="0x1EF65D0")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1EF65D8", Offset="0x1EF65D8", VA="0x1EF65D8")]
			set
			{
			}
		}

		[Address(RVA="0x1EF6D50", Offset="0x1EF6D50", VA="0x1EF6D50")]
		static DailyLoginStatus()
		{
		}

		[Address(RVA="0x1EF6484", Offset="0x1EF6484", VA="0x1EF6484")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083DAC", Offset="0x1083DAC")]
		public DailyLoginStatus()
		{
		}

		[Address(RVA="0x1EF648C", Offset="0x1EF648C", VA="0x1EF648C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083DBC", Offset="0x1083DBC")]
		public DailyLoginStatus(DailyLoginStatus other)
		{
		}

		[Address(RVA="0x1EF6A7C", Offset="0x1EF6A7C", VA="0x1EF6A7C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083E2C", Offset="0x1083E2C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EF6560", Offset="0x1EF6560", VA="0x1EF6560", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083DCC", Offset="0x1083DCC")]
		public DailyLoginStatus Clone()
		{
			return null;
		}

		[Address(RVA="0x1EF6618", Offset="0x1EF6618", VA="0x1EF6618", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083DDC", Offset="0x1083DDC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF668C", Offset="0x1EF668C", VA="0x1EF668C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083DEC", Offset="0x1083DEC")]
		public bool Equals(DailyLoginStatus other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF6728", Offset="0x1EF6728", VA="0x1EF6728", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083DFC", Offset="0x1083DFC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF6BB4", Offset="0x1EF6BB4", VA="0x1EF6BB4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083E3C", Offset="0x1083E3C")]
		public void MergeFrom(DailyLoginStatus other)
		{
		}

		[Address(RVA="0x1EF6C24", Offset="0x1EF6C24", VA="0x1EF6C24", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083E4C", Offset="0x1083E4C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EF680C", Offset="0x1EF680C", VA="0x1EF680C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083E0C", Offset="0x1083E0C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EF6874", Offset="0x1EF6874", VA="0x1EF6874", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083E1C", Offset="0x1083E1C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050428", Offset="0x1050428")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DailyLoginStatus.<>c <>9;

			[Address(RVA="0x1EF6E28", Offset="0x1EF6E28", VA="0x1EF6E28")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF6E8C", Offset="0x1EF6E8C", VA="0x1EF6E8C")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF6E94", Offset="0x1EF6E94", VA="0x1EF6E94")]
			internal DailyLoginStatus <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}