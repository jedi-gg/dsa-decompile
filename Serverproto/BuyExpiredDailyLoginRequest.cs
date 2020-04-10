using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyExpiredDailyLoginRequest : IMessage<BuyExpiredDailyLoginRequest>, IMessage, IEquatable<BuyExpiredDailyLoginRequest>, IDeepCloneable<BuyExpiredDailyLoginRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyExpiredDailyLoginRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AD50", Offset="0x109AD50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F83F70", Offset="0x1F83F70", VA="0x1F83F70")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AD40", Offset="0x109AD40")]
		public static MessageParser<BuyExpiredDailyLoginRequest> Parser
		{
			[Address(RVA="0x1F83F08", Offset="0x1F83F08", VA="0x1F83F08")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AD60", Offset="0x109AD60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F84060", Offset="0x1F84060", VA="0x1F84060", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F84374", Offset="0x1F84374", VA="0x1F84374")]
		static BuyExpiredDailyLoginRequest()
		{
		}

		[Address(RVA="0x1F840BC", Offset="0x1F840BC", VA="0x1F840BC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085A8C", Offset="0x1085A8C")]
		public BuyExpiredDailyLoginRequest()
		{
		}

		[Address(RVA="0x1F840C4", Offset="0x1F840C4", VA="0x1F840C4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085A9C", Offset="0x1085A9C")]
		public BuyExpiredDailyLoginRequest(BuyExpiredDailyLoginRequest other)
		{
		}

		[Address(RVA="0x1F842D8", Offset="0x1F842D8", VA="0x1F842D8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085B0C", Offset="0x1085B0C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F84108", Offset="0x1F84108", VA="0x1F84108", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085AAC", Offset="0x1085AAC")]
		public BuyExpiredDailyLoginRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1F84168", Offset="0x1F84168", VA="0x1F84168", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085ABC", Offset="0x1085ABC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F84200", Offset="0x1F84200", VA="0x1F84200", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085ACC", Offset="0x1085ACC")]
		public bool Equals(BuyExpiredDailyLoginRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8422C", Offset="0x1F8422C", VA="0x1F8422C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085ADC", Offset="0x1085ADC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F842EC", Offset="0x1F842EC", VA="0x1F842EC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085B1C", Offset="0x1085B1C")]
		public void MergeFrom(BuyExpiredDailyLoginRequest other)
		{
		}

		[Address(RVA="0x1F84320", Offset="0x1F84320", VA="0x1F84320", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085B2C", Offset="0x1085B2C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F8425C", Offset="0x1F8425C", VA="0x1F8425C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085AEC", Offset="0x1085AEC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F842C4", Offset="0x1F842C4", VA="0x1F842C4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085AFC", Offset="0x1085AFC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10506C8", Offset="0x10506C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyExpiredDailyLoginRequest.<>c <>9;

			[Address(RVA="0x1F8444C", Offset="0x1F8444C", VA="0x1F8444C")]
			static <>c()
			{
			}

			[Address(RVA="0x1F844B0", Offset="0x1F844B0", VA="0x1F844B0")]
			public <>c()
			{
			}

			[Address(RVA="0x1F844B8", Offset="0x1F844B8", VA="0x1F844B8")]
			internal BuyExpiredDailyLoginRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}