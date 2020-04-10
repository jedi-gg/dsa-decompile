using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FulfillAllClubSupportResponse : IMessage<FulfillAllClubSupportResponse>, IMessage, IEquatable<FulfillAllClubSupportResponse>, IDeepCloneable<FulfillAllClubSupportResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FulfillAllClubSupportResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095560", Offset="0x1095560")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA248C", Offset="0x1BA248C", VA="0x1BA248C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095550", Offset="0x1095550")]
		public static MessageParser<FulfillAllClubSupportResponse> Parser
		{
			[Address(RVA="0x1BA2424", Offset="0x1BA2424", VA="0x1BA2424")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095570", Offset="0x1095570")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA257C", Offset="0x1BA257C", VA="0x1BA257C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA2890", Offset="0x1BA2890", VA="0x1BA2890")]
		static FulfillAllClubSupportResponse()
		{
		}

		[Address(RVA="0x1BA25D8", Offset="0x1BA25D8", VA="0x1BA25D8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C51C", Offset="0x107C51C")]
		public FulfillAllClubSupportResponse()
		{
		}

		[Address(RVA="0x1BA25E0", Offset="0x1BA25E0", VA="0x1BA25E0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C52C", Offset="0x107C52C")]
		public FulfillAllClubSupportResponse(FulfillAllClubSupportResponse other)
		{
		}

		[Address(RVA="0x1BA27F4", Offset="0x1BA27F4", VA="0x1BA27F4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C59C", Offset="0x107C59C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA2624", Offset="0x1BA2624", VA="0x1BA2624", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C53C", Offset="0x107C53C")]
		public FulfillAllClubSupportResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA2684", Offset="0x1BA2684", VA="0x1BA2684", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C54C", Offset="0x107C54C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA271C", Offset="0x1BA271C", VA="0x1BA271C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C55C", Offset="0x107C55C")]
		public bool Equals(FulfillAllClubSupportResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA2748", Offset="0x1BA2748", VA="0x1BA2748", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C56C", Offset="0x107C56C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA2808", Offset="0x1BA2808", VA="0x1BA2808", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C5AC", Offset="0x107C5AC")]
		public void MergeFrom(FulfillAllClubSupportResponse other)
		{
		}

		[Address(RVA="0x1BA283C", Offset="0x1BA283C", VA="0x1BA283C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C5BC", Offset="0x107C5BC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA2778", Offset="0x1BA2778", VA="0x1BA2778", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C57C", Offset="0x107C57C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA27E0", Offset="0x1BA27E0", VA="0x1BA27E0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C58C", Offset="0x107C58C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F928", Offset="0x104F928")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FulfillAllClubSupportResponse.<>c <>9;

			[Address(RVA="0x1BA2968", Offset="0x1BA2968", VA="0x1BA2968")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA29CC", Offset="0x1BA29CC", VA="0x1BA29CC")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA29D4", Offset="0x1BA29D4", VA="0x1BA29D4")]
			internal FulfillAllClubSupportResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}