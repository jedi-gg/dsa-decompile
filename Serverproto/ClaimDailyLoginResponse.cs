using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClaimDailyLoginResponse : IMessage<ClaimDailyLoginResponse>, IMessage, IEquatable<ClaimDailyLoginResponse>, IDeepCloneable<ClaimDailyLoginResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClaimDailyLoginResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int TodayBonusEligibilityTimeFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong todayBonusEligibilityTime_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AD00", Offset="0x109AD00")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A43F9C", Offset="0x1A43F9C", VA="0x1A43F9C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AD20", Offset="0x109AD20")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1A44174", Offset="0x1A44174", VA="0x1A44174")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A4417C", Offset="0x1A4417C", VA="0x1A4417C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ACF0", Offset="0x109ACF0")]
		public static MessageParser<ClaimDailyLoginResponse> Parser
		{
			[Address(RVA="0x1A43F34", Offset="0x1A43F34", VA="0x1A43F34")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AD10", Offset="0x109AD10")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A4408C", Offset="0x1A4408C", VA="0x1A4408C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AD30", Offset="0x109AD30")]
		public ulong TodayBonusEligibilityTime
		{
			[Address(RVA="0x1A441E4", Offset="0x1A441E4", VA="0x1A441E4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A441EC", Offset="0x1A441EC", VA="0x1A441EC")]
			set
			{
			}
		}

		[Address(RVA="0x1A44754", Offset="0x1A44754", VA="0x1A44754")]
		static ClaimDailyLoginResponse()
		{
		}

		[Address(RVA="0x1A440E8", Offset="0x1A440E8", VA="0x1A440E8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10859DC", Offset="0x10859DC")]
		public ClaimDailyLoginResponse()
		{
		}

		[Address(RVA="0x1A440F0", Offset="0x1A440F0", VA="0x1A440F0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10859EC", Offset="0x10859EC")]
		public ClaimDailyLoginResponse(ClaimDailyLoginResponse other)
		{
		}

		[Address(RVA="0x1A444BC", Offset="0x1A444BC", VA="0x1A444BC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085A5C", Offset="0x1085A5C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A44184", Offset="0x1A44184", VA="0x1A44184", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10859FC", Offset="0x10859FC")]
		public ClaimDailyLoginResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A441F4", Offset="0x1A441F4", VA="0x1A441F4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085A0C", Offset="0x1085A0C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A44268", Offset="0x1A44268", VA="0x1A44268", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085A1C", Offset="0x1085A1C")]
		public bool Equals(ClaimDailyLoginResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A442DC", Offset="0x1A442DC", VA="0x1A442DC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085A2C", Offset="0x1085A2C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A44590", Offset="0x1A44590", VA="0x1A44590", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085A6C", Offset="0x1085A6C")]
		public void MergeFrom(ClaimDailyLoginResponse other)
		{
		}

		[Address(RVA="0x1A44650", Offset="0x1A44650", VA="0x1A44650", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085A7C", Offset="0x1085A7C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A4435C", Offset="0x1A4435C", VA="0x1A4435C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085A3C", Offset="0x1085A3C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A443C4", Offset="0x1A443C4", VA="0x1A443C4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085A4C", Offset="0x1085A4C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10506B8", Offset="0x10506B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClaimDailyLoginResponse.<>c <>9;

			[Address(RVA="0x1A4482C", Offset="0x1A4482C", VA="0x1A4482C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A44890", Offset="0x1A44890", VA="0x1A44890")]
			public <>c()
			{
			}

			[Address(RVA="0x1A44898", Offset="0x1A44898", VA="0x1A44898")]
			internal ClaimDailyLoginResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}