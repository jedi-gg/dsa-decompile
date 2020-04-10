using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubSupportRequest : IMessage<ClubSupportRequest>, IMessage, IEquatable<ClubSupportRequest>, IDeepCloneable<ClubSupportRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubSupportRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ByteString id_;

		[FieldOffset(Offset="0x0")]
		public const int RequestTypeFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ClubSupportRequestType requestType_;

		[FieldOffset(Offset="0x0")]
		public const int OwnerFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private PlayerProfileSimple owner_;

		[FieldOffset(Offset="0x0")]
		public const int CreatedTimestampFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private long createdTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int ExpiryTimestampFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private long expiryTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int StateFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ClubSupportRequestState state_;

		[FieldOffset(Offset="0x0")]
		public const int TelemetryRefIdFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private long telemetryRefId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096AA0", Offset="0x1096AA0")]
		public long CreatedTimestamp
		{
			[Address(RVA="0x1B16CD8", Offset="0x1B16CD8", VA="0x1B16CD8")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1B16CE0", Offset="0x1B16CE0", VA="0x1B16CE0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096A50", Offset="0x1096A50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B16970", Offset="0x1B16970", VA="0x1B16970")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096AB0", Offset="0x1096AB0")]
		public long ExpiryTimestamp
		{
			[Address(RVA="0x1B16CE8", Offset="0x1B16CE8", VA="0x1B16CE8")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1B16CF0", Offset="0x1B16CF0", VA="0x1B16CF0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096A70", Offset="0x1096A70")]
		public ByteString Id
		{
			[Address(RVA="0x1B16C50", Offset="0x1B16C50", VA="0x1B16C50")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B16C58", Offset="0x1B16C58", VA="0x1B16C58")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096A90", Offset="0x1096A90")]
		public PlayerProfileSimple Owner
		{
			[Address(RVA="0x1B16BE0", Offset="0x1B16BE0", VA="0x1B16BE0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B16BE8", Offset="0x1B16BE8", VA="0x1B16BE8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096A40", Offset="0x1096A40")]
		public static MessageParser<ClubSupportRequest> Parser
		{
			[Address(RVA="0x1B16908", Offset="0x1B16908", VA="0x1B16908")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096A60", Offset="0x1096A60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B16A60", Offset="0x1B16A60", VA="0x1B16A60", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096A80", Offset="0x1096A80")]
		public ClubSupportRequestType RequestType
		{
			[Address(RVA="0x1B16CC8", Offset="0x1B16CC8", VA="0x1B16CC8")]
			get
			{
				return new ClubSupportRequestType();
			}
			[Address(RVA="0x1B16CD0", Offset="0x1B16CD0", VA="0x1B16CD0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096AC0", Offset="0x1096AC0")]
		public ClubSupportRequestState State
		{
			[Address(RVA="0x1B16CF8", Offset="0x1B16CF8", VA="0x1B16CF8")]
			get
			{
				return new ClubSupportRequestState();
			}
			[Address(RVA="0x1B16D00", Offset="0x1B16D00", VA="0x1B16D00")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096AD0", Offset="0x1096AD0")]
		public long TelemetryRefId
		{
			[Address(RVA="0x1B16D08", Offset="0x1B16D08", VA="0x1B16D08")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1B16D10", Offset="0x1B16D10", VA="0x1B16D10")]
			set
			{
			}
		}

		[Address(RVA="0x1B1783C", Offset="0x1B1783C", VA="0x1B1783C")]
		static ClubSupportRequest()
		{
		}

		[Address(RVA="0x1B16ABC", Offset="0x1B16ABC", VA="0x1B16ABC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EF0C", Offset="0x107EF0C")]
		public ClubSupportRequest()
		{
		}

		[Address(RVA="0x1B16B30", Offset="0x1B16B30", VA="0x1B16B30")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EF1C", Offset="0x107EF1C")]
		public ClubSupportRequest(ClubSupportRequest other)
		{
		}

		[Address(RVA="0x1B17318", Offset="0x1B17318", VA="0x1B17318", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EF8C", Offset="0x107EF8C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B16BF0", Offset="0x1B16BF0", VA="0x1B16BF0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EF2C", Offset="0x107EF2C")]
		public ClubSupportRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B16D18", Offset="0x1B16D18", VA="0x1B16D18", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EF3C", Offset="0x107EF3C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B16D8C", Offset="0x1B16D8C", VA="0x1B16D8C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EF4C", Offset="0x107EF4C")]
		public bool Equals(ClubSupportRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B16EAC", Offset="0x1B16EAC", VA="0x1B16EAC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EF5C", Offset="0x107EF5C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B1753C", Offset="0x1B1753C", VA="0x1B1753C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EF9C", Offset="0x107EF9C")]
		public void MergeFrom(ClubSupportRequest other)
		{
		}

		[Address(RVA="0x1B17658", Offset="0x1B17658", VA="0x1B17658", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EFAC", Offset="0x107EFAC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B16FE8", Offset="0x1B16FE8", VA="0x1B16FE8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EF6C", Offset="0x107EF6C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B17050", Offset="0x1B17050", VA="0x1B17050", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EF7C", Offset="0x107EF7C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FD08", Offset="0x104FD08")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubSupportRequest.<>c <>9;

			[Address(RVA="0x1B17914", Offset="0x1B17914", VA="0x1B17914")]
			static <>c()
			{
			}

			[Address(RVA="0x1B17978", Offset="0x1B17978", VA="0x1B17978")]
			public <>c()
			{
			}

			[Address(RVA="0x1B17980", Offset="0x1B17980", VA="0x1B17980")]
			internal ClubSupportRequest <.cctor>b__55_0()
			{
				return null;
			}
		}
	}
}