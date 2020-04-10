using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClaimDailyLoginBonusRequest : IMessage<ClaimDailyLoginBonusRequest>, IMessage, IEquatable<ClaimDailyLoginBonusRequest>, IDeepCloneable<ClaimDailyLoginBonusRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClaimDailyLoginBonusRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ADC0", Offset="0x109ADC0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A429D0", Offset="0x1A429D0", VA="0x1A429D0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ADB0", Offset="0x109ADB0")]
		public static MessageParser<ClaimDailyLoginBonusRequest> Parser
		{
			[Address(RVA="0x1A42968", Offset="0x1A42968", VA="0x1A42968")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ADD0", Offset="0x109ADD0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A42AC0", Offset="0x1A42AC0", VA="0x1A42AC0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A42DD4", Offset="0x1A42DD4", VA="0x1A42DD4")]
		static ClaimDailyLoginBonusRequest()
		{
		}

		[Address(RVA="0x1A42B1C", Offset="0x1A42B1C", VA="0x1A42B1C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085BEC", Offset="0x1085BEC")]
		public ClaimDailyLoginBonusRequest()
		{
		}

		[Address(RVA="0x1A42B24", Offset="0x1A42B24", VA="0x1A42B24")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085BFC", Offset="0x1085BFC")]
		public ClaimDailyLoginBonusRequest(ClaimDailyLoginBonusRequest other)
		{
		}

		[Address(RVA="0x1A42D38", Offset="0x1A42D38", VA="0x1A42D38", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085C6C", Offset="0x1085C6C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A42B68", Offset="0x1A42B68", VA="0x1A42B68", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085C0C", Offset="0x1085C0C")]
		public ClaimDailyLoginBonusRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A42BC8", Offset="0x1A42BC8", VA="0x1A42BC8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085C1C", Offset="0x1085C1C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A42C60", Offset="0x1A42C60", VA="0x1A42C60", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085C2C", Offset="0x1085C2C")]
		public bool Equals(ClaimDailyLoginBonusRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A42C8C", Offset="0x1A42C8C", VA="0x1A42C8C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085C3C", Offset="0x1085C3C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A42D4C", Offset="0x1A42D4C", VA="0x1A42D4C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085C7C", Offset="0x1085C7C")]
		public void MergeFrom(ClaimDailyLoginBonusRequest other)
		{
		}

		[Address(RVA="0x1A42D80", Offset="0x1A42D80", VA="0x1A42D80", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085C8C", Offset="0x1085C8C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A42CBC", Offset="0x1A42CBC", VA="0x1A42CBC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085C4C", Offset="0x1085C4C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A42D24", Offset="0x1A42D24", VA="0x1A42D24", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085C5C", Offset="0x1085C5C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10506E8", Offset="0x10506E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClaimDailyLoginBonusRequest.<>c <>9;

			[Address(RVA="0x1A42EAC", Offset="0x1A42EAC", VA="0x1A42EAC")]
			static <>c()
			{
			}

			[Address(RVA="0x1A42F10", Offset="0x1A42F10", VA="0x1A42F10")]
			public <>c()
			{
			}

			[Address(RVA="0x1A42F18", Offset="0x1A42F18", VA="0x1A42F18")]
			internal ClaimDailyLoginBonusRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}