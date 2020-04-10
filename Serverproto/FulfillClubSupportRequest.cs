using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FulfillClubSupportRequest : IMessage<FulfillClubSupportRequest>, IMessage, IEquatable<FulfillClubSupportRequest>, IDeepCloneable<FulfillClubSupportRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FulfillClubSupportRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RequestIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ByteString requestId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10954B0", Offset="0x10954B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA2A98", Offset="0x1BA2A98", VA="0x1BA2A98")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10954A0", Offset="0x10954A0")]
		public static MessageParser<FulfillClubSupportRequest> Parser
		{
			[Address(RVA="0x1BA2A30", Offset="0x1BA2A30", VA="0x1BA2A30")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10954C0", Offset="0x10954C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA2B88", Offset="0x1BA2B88", VA="0x1BA2B88", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10954D0", Offset="0x10954D0")]
		public ByteString RequestId
		{
			[Address(RVA="0x1BA2D18", Offset="0x1BA2D18", VA="0x1BA2D18")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BA2D20", Offset="0x1BA2D20", VA="0x1BA2D20")]
			set
			{
			}
		}

		[Address(RVA="0x1BA3208", Offset="0x1BA3208", VA="0x1BA3208")]
		static FulfillClubSupportRequest()
		{
		}

		[Address(RVA="0x1BA2BE4", Offset="0x1BA2BE4", VA="0x1BA2BE4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C30C", Offset="0x107C30C")]
		public FulfillClubSupportRequest()
		{
		}

		[Address(RVA="0x1BA2C58", Offset="0x1BA2C58", VA="0x1BA2C58")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C31C", Offset="0x107C31C")]
		public FulfillClubSupportRequest(FulfillClubSupportRequest other)
		{
		}

		[Address(RVA="0x1BA3064", Offset="0x1BA3064", VA="0x1BA3064", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C38C", Offset="0x107C38C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA2CB8", Offset="0x1BA2CB8", VA="0x1BA2CB8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C32C", Offset="0x107C32C")]
		public FulfillClubSupportRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA2D90", Offset="0x1BA2D90", VA="0x1BA2D90", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C33C", Offset="0x107C33C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA2E04", Offset="0x1BA2E04", VA="0x1BA2E04", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C34C", Offset="0x107C34C")]
		public bool Equals(FulfillClubSupportRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA2EC0", Offset="0x1BA2EC0", VA="0x1BA2EC0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C35C", Offset="0x107C35C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA3118", Offset="0x1BA3118", VA="0x1BA3118", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C39C", Offset="0x107C39C")]
		public void MergeFrom(FulfillClubSupportRequest other)
		{
		}

		[Address(RVA="0x1BA3184", Offset="0x1BA3184", VA="0x1BA3184", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C3AC", Offset="0x107C3AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA2F44", Offset="0x1BA2F44", VA="0x1BA2F44", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C36C", Offset="0x107C36C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA2FAC", Offset="0x1BA2FAC", VA="0x1BA2FAC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C37C", Offset="0x107C37C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F8F8", Offset="0x104F8F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FulfillClubSupportRequest.<>c <>9;

			[Address(RVA="0x1BA32E0", Offset="0x1BA32E0", VA="0x1BA32E0")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA3344", Offset="0x1BA3344", VA="0x1BA3344")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA334C", Offset="0x1BA334C", VA="0x1BA334C")]
			internal FulfillClubSupportRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}