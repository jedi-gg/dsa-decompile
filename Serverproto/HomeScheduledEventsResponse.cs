using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeScheduledEventsResponse : IMessage<HomeScheduledEventsResponse>, IMessage, IEquatable<HomeScheduledEventsResponse>, IDeepCloneable<HomeScheduledEventsResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeScheduledEventsResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int MarqueeEventFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Event marqueeEvent_;

		[FieldOffset(Offset="0x0")]
		public const int ScheduledEventsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<Event> _repeated_scheduledEvents_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<Event> scheduledEvents_;

		[FieldOffset(Offset="0x0")]
		public const int EventGroupsFieldNumber = 3;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<EventGroup> _repeated_eventGroups_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<EventGroup> eventGroups_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10979E8", Offset="0x10979E8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18D1B5C", Offset="0x18D1B5C", VA="0x18D1B5C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097A50", Offset="0x1097A50")]
		public RepeatedField<EventGroup> EventGroups
		{
			[Address(RVA="0x18D1EA8", Offset="0x18D1EA8", VA="0x18D1EA8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097A08", Offset="0x1097A08")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1097A08", Offset="0x1097A08")]
		public Event MarqueeEvent
		{
			[Address(RVA="0x18D1E30", Offset="0x18D1E30", VA="0x18D1E30")]
			get
			{
				return null;
			}
			[Address(RVA="0x18D1E38", Offset="0x18D1E38", VA="0x18D1E38")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10979D8", Offset="0x10979D8")]
		public static MessageParser<HomeScheduledEventsResponse> Parser
		{
			[Address(RVA="0x18D1AF4", Offset="0x18D1AF4", VA="0x18D1AF4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10979F8", Offset="0x10979F8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18D1C4C", Offset="0x18D1C4C", VA="0x18D1C4C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097A40", Offset="0x1097A40")]
		public RepeatedField<Event> ScheduledEvents
		{
			[Address(RVA="0x18D1EA0", Offset="0x18D1EA0", VA="0x18D1EA0")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18D266C", Offset="0x18D266C", VA="0x18D266C")]
		static HomeScheduledEventsResponse()
		{
		}

		[Address(RVA="0x18D1CA8", Offset="0x18D1CA8", VA="0x18D1CA8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10802FC", Offset="0x10802FC")]
		public HomeScheduledEventsResponse()
		{
		}

		[Address(RVA="0x18D1D40", Offset="0x18D1D40", VA="0x18D1D40")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108030C", Offset="0x108030C")]
		public HomeScheduledEventsResponse(HomeScheduledEventsResponse other)
		{
		}

		[Address(RVA="0x18D228C", Offset="0x18D228C", VA="0x18D228C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108037C", Offset="0x108037C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18D1E40", Offset="0x18D1E40", VA="0x18D1E40", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108031C", Offset="0x108031C")]
		public HomeScheduledEventsResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18D1EB0", Offset="0x18D1EB0", VA="0x18D1EB0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108032C", Offset="0x108032C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18D1F24", Offset="0x18D1F24", VA="0x18D1F24", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108033C", Offset="0x108033C")]
		public bool Equals(HomeScheduledEventsResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18D2018", Offset="0x18D2018", VA="0x18D2018", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108034C", Offset="0x108034C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18D23C8", Offset="0x18D23C8", VA="0x18D23C8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108038C", Offset="0x108038C")]
		public void MergeFrom(HomeScheduledEventsResponse other)
		{
		}

		[Address(RVA="0x18D24D4", Offset="0x18D24D4", VA="0x18D24D4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108039C", Offset="0x108039C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18D20C4", Offset="0x18D20C4", VA="0x18D20C4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108035C", Offset="0x108035C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18D212C", Offset="0x18D212C", VA="0x18D212C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108036C", Offset="0x108036C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FED8", Offset="0x104FED8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeScheduledEventsResponse.<>c <>9;

			[Address(RVA="0x18D27DC", Offset="0x18D27DC", VA="0x18D27DC")]
			static <>c()
			{
			}

			[Address(RVA="0x18D2840", Offset="0x18D2840", VA="0x18D2840")]
			public <>c()
			{
			}

			[Address(RVA="0x18D2848", Offset="0x18D2848", VA="0x18D2848")]
			internal HomeScheduledEventsResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}