using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CalendarDate : IMessage<CalendarDate>, IMessage, IEquatable<CalendarDate>, IDeepCloneable<CalendarDate>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CalendarDate> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int YearFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong year_;

		[FieldOffset(Offset="0x0")]
		public const int MonthFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong month_;

		[FieldOffset(Offset="0x0")]
		public const int DayFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong day_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096870", Offset="0x1096870")]
		public ulong Day
		{
			[Address(RVA="0x1F8C950", Offset="0x1F8C950", VA="0x1F8C950")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F8C958", Offset="0x1F8C958", VA="0x1F8C958")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096830", Offset="0x1096830")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F8C6E0", Offset="0x1F8C6E0", VA="0x1F8C6E0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096860", Offset="0x1096860")]
		public ulong Month
		{
			[Address(RVA="0x1F8C940", Offset="0x1F8C940", VA="0x1F8C940")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F8C948", Offset="0x1F8C948", VA="0x1F8C948")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096820", Offset="0x1096820")]
		public static MessageParser<CalendarDate> Parser
		{
			[Address(RVA="0x1F8C678", Offset="0x1F8C678", VA="0x1F8C678")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096840", Offset="0x1096840")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F8C7D0", Offset="0x1F8C7D0", VA="0x1F8C7D0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096850", Offset="0x1096850")]
		public ulong Year
		{
			[Address(RVA="0x1F8C930", Offset="0x1F8C930", VA="0x1F8C930")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F8C938", Offset="0x1F8C938", VA="0x1F8C938")]
			set
			{
			}
		}

		[Address(RVA="0x1F8CEC8", Offset="0x1F8CEC8", VA="0x1F8CEC8")]
		static CalendarDate()
		{
		}

		[Address(RVA="0x1F8C82C", Offset="0x1F8C82C", VA="0x1F8C82C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ECFC", Offset="0x107ECFC")]
		public CalendarDate()
		{
		}

		[Address(RVA="0x1F8C834", Offset="0x1F8C834", VA="0x1F8C834")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ED0C", Offset="0x107ED0C")]
		public CalendarDate(CalendarDate other)
		{
		}

		[Address(RVA="0x1F8CC88", Offset="0x1F8CC88", VA="0x1F8CC88", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ED7C", Offset="0x107ED7C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F8C8D0", Offset="0x1F8C8D0", VA="0x1F8C8D0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ED1C", Offset="0x107ED1C")]
		public CalendarDate Clone()
		{
			return null;
		}

		[Address(RVA="0x1F8C960", Offset="0x1F8C960", VA="0x1F8C960", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ED2C", Offset="0x107ED2C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8C9D4", Offset="0x1F8C9D4", VA="0x1F8C9D4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ED3C", Offset="0x107ED3C")]
		public bool Equals(CalendarDate other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8CA30", Offset="0x1F8CA30", VA="0x1F8CA30", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ED4C", Offset="0x107ED4C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F8CD98", Offset="0x1F8CD98", VA="0x1F8CD98", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ED8C", Offset="0x107ED8C")]
		public void MergeFrom(CalendarDate other)
		{
		}

		[Address(RVA="0x1F8CDF0", Offset="0x1F8CDF0", VA="0x1F8CDF0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ED9C", Offset="0x107ED9C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F8CAD0", Offset="0x1F8CAD0", VA="0x1F8CAD0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ED5C", Offset="0x107ED5C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F8CB38", Offset="0x1F8CB38", VA="0x1F8CB38", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ED6C", Offset="0x107ED6C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FCD8", Offset="0x104FCD8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CalendarDate.<>c <>9;

			[Address(RVA="0x1F8CFA0", Offset="0x1F8CFA0", VA="0x1F8CFA0")]
			static <>c()
			{
			}

			[Address(RVA="0x1F8D004", Offset="0x1F8D004", VA="0x1F8D004")]
			public <>c()
			{
			}

			[Address(RVA="0x1F8D00C", Offset="0x1F8D00C", VA="0x1F8D00C")]
			internal CalendarDate <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}