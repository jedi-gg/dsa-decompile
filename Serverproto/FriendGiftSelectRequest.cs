using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FriendGiftSelectRequest : IMessage<FriendGiftSelectRequest>, IMessage, IEquatable<FriendGiftSelectRequest>, IDeepCloneable<FriendGiftSelectRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FriendGiftSelectRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SenderIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string senderId_;

		[FieldOffset(Offset="0x0")]
		public const int ReceiverIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string receiverId_;

		[FieldOffset(Offset="0x0")]
		public const int ProductIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string productId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B8D0", Offset="0x109B8D0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B9D5CC", Offset="0x1B9D5CC", VA="0x1B9D5CC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B8C0", Offset="0x109B8C0")]
		public static MessageParser<FriendGiftSelectRequest> Parser
		{
			[Address(RVA="0x1B9D564", Offset="0x1B9D564", VA="0x1B9D564")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B8E0", Offset="0x109B8E0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B9D6BC", Offset="0x1B9D6BC", VA="0x1B9D6BC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B910", Offset="0x109B910")]
		public string ProductId
		{
			[Address(RVA="0x1B9D95C", Offset="0x1B9D95C", VA="0x1B9D95C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B9D964", Offset="0x1B9D964", VA="0x1B9D964")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B900", Offset="0x109B900")]
		public string ReceiverId
		{
			[Address(RVA="0x1B9D8E4", Offset="0x1B9D8E4", VA="0x1B9D8E4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B9D8EC", Offset="0x1B9D8EC", VA="0x1B9D8EC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B8F0", Offset="0x109B8F0")]
		public string SenderId
		{
			[Address(RVA="0x1B9D86C", Offset="0x1B9D86C", VA="0x1B9D86C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B9D874", Offset="0x1B9D874", VA="0x1B9D874")]
			set
			{
			}
		}

		[Address(RVA="0x1B9E104", Offset="0x1B9E104", VA="0x1B9E104")]
		static FriendGiftSelectRequest()
		{
		}

		[Address(RVA="0x1B9D718", Offset="0x1B9D718", VA="0x1B9D718")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108755C", Offset="0x108755C")]
		public FriendGiftSelectRequest()
		{
		}

		[Address(RVA="0x1B9D774", Offset="0x1B9D774", VA="0x1B9D774")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108756C", Offset="0x108756C")]
		public FriendGiftSelectRequest(FriendGiftSelectRequest other)
		{
		}

		[Address(RVA="0x1B9DDE8", Offset="0x1B9DDE8", VA="0x1B9DDE8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10875DC", Offset="0x10875DC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B9D80C", Offset="0x1B9D80C", VA="0x1B9D80C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108757C", Offset="0x108757C")]
		public FriendGiftSelectRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B9D9D4", Offset="0x1B9D9D4", VA="0x1B9D9D4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108758C", Offset="0x108758C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9DA48", Offset="0x1B9DA48", VA="0x1B9DA48", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108759C", Offset="0x108759C")]
		public bool Equals(FriendGiftSelectRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9DAD4", Offset="0x1B9DAD4", VA="0x1B9DAD4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10875AC", Offset="0x10875AC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B9DF54", Offset="0x1B9DF54", VA="0x1B9DF54", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10875EC", Offset="0x10875EC")]
		public void MergeFrom(FriendGiftSelectRequest other)
		{
		}

		[Address(RVA="0x1B9E018", Offset="0x1B9E018", VA="0x1B9E018", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10875FC", Offset="0x10875FC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B9DBE8", Offset="0x1B9DBE8", VA="0x1B9DBE8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10875BC", Offset="0x10875BC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B9DC50", Offset="0x1B9DC50", VA="0x1B9DC50", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10875CC", Offset="0x10875CC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050938", Offset="0x1050938")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FriendGiftSelectRequest.<>c <>9;

			[Address(RVA="0x1B9E1DC", Offset="0x1B9E1DC", VA="0x1B9E1DC")]
			static <>c()
			{
			}

			[Address(RVA="0x1B9E240", Offset="0x1B9E240", VA="0x1B9E240")]
			public <>c()
			{
			}

			[Address(RVA="0x1B9E248", Offset="0x1B9E248", VA="0x1B9E248")]
			internal FriendGiftSelectRequest <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}