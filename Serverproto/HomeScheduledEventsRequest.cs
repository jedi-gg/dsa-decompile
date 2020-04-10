using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeScheduledEventsRequest : IMessage<HomeScheduledEventsRequest>, IMessage, IEquatable<HomeScheduledEventsRequest>, IDeepCloneable<HomeScheduledEventsRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeScheduledEventsRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10979B8", Offset="0x10979B8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18D1550", Offset="0x18D1550", VA="0x18D1550")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10979A8", Offset="0x10979A8")]
		public static MessageParser<HomeScheduledEventsRequest> Parser
		{
			[Address(RVA="0x18D14E8", Offset="0x18D14E8", VA="0x18D14E8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10979C8", Offset="0x10979C8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18D1640", Offset="0x18D1640", VA="0x18D1640", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18D1954", Offset="0x18D1954", VA="0x18D1954")]
		static HomeScheduledEventsRequest()
		{
		}

		[Address(RVA="0x18D169C", Offset="0x18D169C", VA="0x18D169C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108024C", Offset="0x108024C")]
		public HomeScheduledEventsRequest()
		{
		}

		[Address(RVA="0x18D16A4", Offset="0x18D16A4", VA="0x18D16A4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108025C", Offset="0x108025C")]
		public HomeScheduledEventsRequest(HomeScheduledEventsRequest other)
		{
		}

		[Address(RVA="0x18D18B8", Offset="0x18D18B8", VA="0x18D18B8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10802CC", Offset="0x10802CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18D16E8", Offset="0x18D16E8", VA="0x18D16E8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108026C", Offset="0x108026C")]
		public HomeScheduledEventsRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18D1748", Offset="0x18D1748", VA="0x18D1748", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108027C", Offset="0x108027C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18D17E0", Offset="0x18D17E0", VA="0x18D17E0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108028C", Offset="0x108028C")]
		public bool Equals(HomeScheduledEventsRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18D180C", Offset="0x18D180C", VA="0x18D180C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108029C", Offset="0x108029C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18D18CC", Offset="0x18D18CC", VA="0x18D18CC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10802DC", Offset="0x10802DC")]
		public void MergeFrom(HomeScheduledEventsRequest other)
		{
		}

		[Address(RVA="0x18D1900", Offset="0x18D1900", VA="0x18D1900", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10802EC", Offset="0x10802EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18D183C", Offset="0x18D183C", VA="0x18D183C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10802AC", Offset="0x10802AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18D18A4", Offset="0x18D18A4", VA="0x18D18A4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10802BC", Offset="0x10802BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FEC8", Offset="0x104FEC8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeScheduledEventsRequest.<>c <>9;

			[Address(RVA="0x18D1A2C", Offset="0x18D1A2C", VA="0x18D1A2C")]
			static <>c()
			{
			}

			[Address(RVA="0x18D1A90", Offset="0x18D1A90", VA="0x18D1A90")]
			public <>c()
			{
			}

			[Address(RVA="0x18D1A98", Offset="0x18D1A98", VA="0x18D1A98")]
			internal HomeScheduledEventsRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}