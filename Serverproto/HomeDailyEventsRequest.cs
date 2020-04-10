using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeDailyEventsRequest : IMessage<HomeDailyEventsRequest>, IMessage, IEquatable<HomeDailyEventsRequest>, IDeepCloneable<HomeDailyEventsRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeDailyEventsRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097938", Offset="0x1097938")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D02F04", Offset="0x1D02F04", VA="0x1D02F04")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097928", Offset="0x1097928")]
		public static MessageParser<HomeDailyEventsRequest> Parser
		{
			[Address(RVA="0x1D02E9C", Offset="0x1D02E9C", VA="0x1D02E9C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097948", Offset="0x1097948")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D02FF0", Offset="0x1D02FF0", VA="0x1D02FF0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D03304", Offset="0x1D03304", VA="0x1D03304")]
		static HomeDailyEventsRequest()
		{
		}

		[Address(RVA="0x1D0304C", Offset="0x1D0304C", VA="0x1D0304C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10800EC", Offset="0x10800EC")]
		public HomeDailyEventsRequest()
		{
		}

		[Address(RVA="0x1D03054", Offset="0x1D03054", VA="0x1D03054")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10800FC", Offset="0x10800FC")]
		public HomeDailyEventsRequest(HomeDailyEventsRequest other)
		{
		}

		[Address(RVA="0x1D03268", Offset="0x1D03268", VA="0x1D03268", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108016C", Offset="0x108016C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D03098", Offset="0x1D03098", VA="0x1D03098", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108010C", Offset="0x108010C")]
		public HomeDailyEventsRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1D030F8", Offset="0x1D030F8", VA="0x1D030F8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108011C", Offset="0x108011C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D03190", Offset="0x1D03190", VA="0x1D03190", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108012C", Offset="0x108012C")]
		public bool Equals(HomeDailyEventsRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1D031BC", Offset="0x1D031BC", VA="0x1D031BC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108013C", Offset="0x108013C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D0327C", Offset="0x1D0327C", VA="0x1D0327C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108017C", Offset="0x108017C")]
		public void MergeFrom(HomeDailyEventsRequest other)
		{
		}

		[Address(RVA="0x1D032B0", Offset="0x1D032B0", VA="0x1D032B0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108018C", Offset="0x108018C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D031EC", Offset="0x1D031EC", VA="0x1D031EC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108014C", Offset="0x108014C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D03254", Offset="0x1D03254", VA="0x1D03254", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108015C", Offset="0x108015C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FEA8", Offset="0x104FEA8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeDailyEventsRequest.<>c <>9;

			[Address(RVA="0x1D033DC", Offset="0x1D033DC", VA="0x1D033DC")]
			static <>c()
			{
			}

			[Address(RVA="0x1D03440", Offset="0x1D03440", VA="0x1D03440")]
			public <>c()
			{
			}

			[Address(RVA="0x1D03448", Offset="0x1D03448", VA="0x1D03448")]
			internal HomeDailyEventsRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}