using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetScheduledEventsRequest : IMessage<GetScheduledEventsRequest>, IMessage, IEquatable<GetScheduledEventsRequest>, IDeepCloneable<GetScheduledEventsRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetScheduledEventsRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10974A8", Offset="0x10974A8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BAC198", Offset="0x1BAC198", VA="0x1BAC198")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097498", Offset="0x1097498")]
		public static MessageParser<GetScheduledEventsRequest> Parser
		{
			[Address(RVA="0x1BAC130", Offset="0x1BAC130", VA="0x1BAC130")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10974B8", Offset="0x10974B8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BAC288", Offset="0x1BAC288", VA="0x1BAC288", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BAC59C", Offset="0x1BAC59C", VA="0x1BAC59C")]
		static GetScheduledEventsRequest()
		{
		}

		[Address(RVA="0x1BAC2E4", Offset="0x1BAC2E4", VA="0x1BAC2E4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FC1C", Offset="0x107FC1C")]
		public GetScheduledEventsRequest()
		{
		}

		[Address(RVA="0x1BAC2EC", Offset="0x1BAC2EC", VA="0x1BAC2EC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FC2C", Offset="0x107FC2C")]
		public GetScheduledEventsRequest(GetScheduledEventsRequest other)
		{
		}

		[Address(RVA="0x1BAC500", Offset="0x1BAC500", VA="0x1BAC500", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FC9C", Offset="0x107FC9C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BAC330", Offset="0x1BAC330", VA="0x1BAC330", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FC3C", Offset="0x107FC3C")]
		public GetScheduledEventsRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BAC390", Offset="0x1BAC390", VA="0x1BAC390", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FC4C", Offset="0x107FC4C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BAC428", Offset="0x1BAC428", VA="0x1BAC428", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FC5C", Offset="0x107FC5C")]
		public bool Equals(GetScheduledEventsRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BAC454", Offset="0x1BAC454", VA="0x1BAC454", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FC6C", Offset="0x107FC6C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BAC514", Offset="0x1BAC514", VA="0x1BAC514", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FCAC", Offset="0x107FCAC")]
		public void MergeFrom(GetScheduledEventsRequest other)
		{
		}

		[Address(RVA="0x1BAC548", Offset="0x1BAC548", VA="0x1BAC548", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FCBC", Offset="0x107FCBC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BAC484", Offset="0x1BAC484", VA="0x1BAC484", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FC7C", Offset="0x107FC7C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BAC4EC", Offset="0x1BAC4EC", VA="0x1BAC4EC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107FC8C", Offset="0x107FC8C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FE38", Offset="0x104FE38")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetScheduledEventsRequest.<>c <>9;

			[Address(RVA="0x1BAC674", Offset="0x1BAC674", VA="0x1BAC674")]
			static <>c()
			{
			}

			[Address(RVA="0x1BAC6D8", Offset="0x1BAC6D8", VA="0x1BAC6D8")]
			public <>c()
			{
			}

			[Address(RVA="0x1BAC6E0", Offset="0x1BAC6E0", VA="0x1BAC6E0")]
			internal GetScheduledEventsRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}