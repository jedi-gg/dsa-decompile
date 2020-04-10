using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FriendsListModifyRequest : IMessage<FriendsListModifyRequest>, IMessage, IEquatable<FriendsListModifyRequest>, IDeepCloneable<FriendsListModifyRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FriendsListModifyRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ActionFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private FriendsListModifyAction action_;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int TokenFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string token_;

		[FieldOffset(Offset="0x0")]
		public const int TelemetryRefIdFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private long telemetryRefId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A7A0", Offset="0x109A7A0")]
		public FriendsListModifyAction Action
		{
			[Address(RVA="0x1B9FDCC", Offset="0x1B9FDCC", VA="0x1B9FDCC")]
			get
			{
				return new FriendsListModifyAction();
			}
			[Address(RVA="0x1B9FDD4", Offset="0x1B9FDD4", VA="0x1B9FDD4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A780", Offset="0x109A780")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B9FB14", Offset="0x1B9FB14", VA="0x1B9FB14")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A7B0", Offset="0x109A7B0")]
		public string Id
		{
			[Address(RVA="0x1B9FDDC", Offset="0x1B9FDDC", VA="0x1B9FDDC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B9FDE4", Offset="0x1B9FDE4", VA="0x1B9FDE4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A770", Offset="0x109A770")]
		public static MessageParser<FriendsListModifyRequest> Parser
		{
			[Address(RVA="0x1B9FAAC", Offset="0x1B9FAAC", VA="0x1B9FAAC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A790", Offset="0x109A790")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B9FC04", Offset="0x1B9FC04", VA="0x1B9FC04", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A7D0", Offset="0x109A7D0")]
		public long TelemetryRefId
		{
			[Address(RVA="0x1B9FECC", Offset="0x1B9FECC", VA="0x1B9FECC")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1B9FED4", Offset="0x1B9FED4", VA="0x1B9FED4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A7C0", Offset="0x109A7C0")]
		public string Token
		{
			[Address(RVA="0x1B9FE54", Offset="0x1B9FE54", VA="0x1B9FE54")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B9FE5C", Offset="0x1B9FE5C", VA="0x1B9FE5C")]
			set
			{
			}
		}

		[Address(RVA="0x1BA067C", Offset="0x1BA067C", VA="0x1BA067C")]
		static FriendsListModifyRequest()
		{
		}

		[Address(RVA="0x1B9FC60", Offset="0x1B9FC60", VA="0x1B9FC60")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084B6C", Offset="0x1084B6C")]
		public FriendsListModifyRequest()
		{
		}

		[Address(RVA="0x1B9FCB8", Offset="0x1B9FCB8", VA="0x1B9FCB8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084B7C", Offset="0x1084B7C")]
		public FriendsListModifyRequest(FriendsListModifyRequest other)
		{
		}

		[Address(RVA="0x1BA033C", Offset="0x1BA033C", VA="0x1BA033C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084BEC", Offset="0x1084BEC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B9FD6C", Offset="0x1B9FD6C", VA="0x1B9FD6C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084B8C", Offset="0x1084B8C")]
		public FriendsListModifyRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B9FEDC", Offset="0x1B9FEDC", VA="0x1B9FEDC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084B9C", Offset="0x1084B9C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9FF50", Offset="0x1B9FF50", VA="0x1B9FF50", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084BAC", Offset="0x1084BAC")]
		public bool Equals(FriendsListModifyRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9FFE8", Offset="0x1B9FFE8", VA="0x1B9FFE8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084BBC", Offset="0x1084BBC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA04C0", Offset="0x1BA04C0", VA="0x1BA04C0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084BFC", Offset="0x1084BFC")]
		public void MergeFrom(FriendsListModifyRequest other)
		{
		}

		[Address(RVA="0x1BA0570", Offset="0x1BA0570", VA="0x1BA0570", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084C0C", Offset="0x1084C0C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA00FC", Offset="0x1BA00FC", VA="0x1BA00FC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084BCC", Offset="0x1084BCC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA0164", Offset="0x1BA0164", VA="0x1BA0164", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084BDC", Offset="0x1084BDC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050568", Offset="0x1050568")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FriendsListModifyRequest.<>c <>9;

			[Address(RVA="0x1BA0754", Offset="0x1BA0754", VA="0x1BA0754")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA07B8", Offset="0x1BA07B8", VA="0x1BA07B8")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA07C0", Offset="0x1BA07C0", VA="0x1BA07C0")]
			internal FriendsListModifyRequest <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}