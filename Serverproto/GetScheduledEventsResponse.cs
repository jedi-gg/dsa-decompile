using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetScheduledEventsResponse : IMessage<GetScheduledEventsResponse>, IMessage, IEquatable<GetScheduledEventsResponse>, IDeepCloneable<GetScheduledEventsResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetScheduledEventsResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ScheduledEventsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<Event> _repeated_scheduledEvents_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<Event> scheduledEvents_;

		[FieldOffset(Offset="0x0")]
		public const int EventGroupsFieldNumber = 2;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<EventGroup> _repeated_eventGroups_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<EventGroup> eventGroups_;

		[FieldOffset(Offset="0x0")]
		public const int InfoEventsFieldNumber = 3;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<InfoEvent> _repeated_infoEvents_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<InfoEvent> infoEvents_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10974D8", Offset="0x10974D8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BAC7A4", Offset="0x1BAC7A4", VA="0x1BAC7A4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097508", Offset="0x1097508")]
		public RepeatedField<EventGroup> EventGroups
		{
			[Address(RVA="0x1B97F78", Offset="0x1B97F78", VA="0x1B97F78")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097518", Offset="0x1097518")]
		public RepeatedField<InfoEvent> InfoEvents
		{
			[Address(RVA="0x1BACAF8", Offset="0x1BACAF8", VA="0x1BACAF8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10974C8", Offset="0x10974C8")]
		public static MessageParser<GetScheduledEventsResponse> Parser
		{
			[Address(RVA="0x1BAC73C", Offset="0x1BAC73C", VA="0x1BAC73C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10974E8", Offset="0x10974E8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BAC894", Offset="0x1BAC894", VA="0x1BAC894", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10974F8", Offset="0x10974F8")]
		public RepeatedField<Event> ScheduledEvents
		{
			[Address(RVA="0x1B97F80", Offset="0x1B97F80", VA="0x1B97F80")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BAD284", Offset="0x1BAD284", VA="0x1BAD284")]
		static GetScheduledEventsResponse()
		{
		}

		[Address(RVA="0x1BAC8F0", Offset="0x1BAC8F0", VA="0x1BAC8F0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FCCC", Offset="0x107FCCC")]
		public GetScheduledEventsResponse()
		{
		}

		[Address(RVA="0x1BAC9B0", Offset="0x1BAC9B0", VA="0x1BAC9B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FCDC", Offset="0x107FCDC")]
		public GetScheduledEventsResponse(GetScheduledEventsResponse other)
		{
		}

		[Address(RVA="0x1BACEDC", Offset="0x1BACEDC", VA="0x1BACEDC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FD4C", Offset="0x107FD4C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BACA98", Offset="0x1BACA98", VA="0x1BACA98", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FCEC", Offset="0x107FCEC")]
		public GetScheduledEventsResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BACB00", Offset="0x1BACB00", VA="0x1BACB00", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FCFC", Offset="0x107FCFC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BACB74", Offset="0x1BACB74", VA="0x1BACB74", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FD0C", Offset="0x107FD0C")]
		public bool Equals(GetScheduledEventsResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BACC84", Offset="0x1BACC84", VA="0x1BACC84", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FD1C", Offset="0x107FD1C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BAD010", Offset="0x1BAD010", VA="0x1BAD010", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FD5C", Offset="0x107FD5C")]
		public void MergeFrom(GetScheduledEventsResponse other)
		{
		}

		[Address(RVA="0x1BAD0F8", Offset="0x1BAD0F8", VA="0x1BAD0F8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FD6C", Offset="0x107FD6C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BACD34", Offset="0x1BACD34", VA="0x1BACD34", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FD2C", Offset="0x107FD2C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BACD9C", Offset="0x1BACD9C", VA="0x1BACD9C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FD3C", Offset="0x107FD3C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FE48", Offset="0x104FE48")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetScheduledEventsResponse.<>c <>9;

			[Address(RVA="0x1BAD440", Offset="0x1BAD440", VA="0x1BAD440")]
			static <>c()
			{
			}

			[Address(RVA="0x1BAD4A4", Offset="0x1BAD4A4", VA="0x1BAD4A4")]
			public <>c()
			{
			}

			[Address(RVA="0x1BAD4AC", Offset="0x1BAD4AC", VA="0x1BAD4AC")]
			internal GetScheduledEventsResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}