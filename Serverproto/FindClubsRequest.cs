using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FindClubsRequest : IMessage<FindClubsRequest>, IMessage, IEquatable<FindClubsRequest>, IDeepCloneable<FindClubsRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FindClubsRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int NameFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string name_;

		[FieldOffset(Offset="0x0")]
		public const int CreatedAfterTimestampFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong createdAfterTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int OffsetFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong offset_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094DE0", Offset="0x1094DE0")]
		public ulong CreatedAfterTimestamp
		{
			[Address(RVA="0x1B9B6A8", Offset="0x1B9B6A8", VA="0x1B9B6A8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B9B6B0", Offset="0x1B9B6B0", VA="0x1B9B6B0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094DB0", Offset="0x1094DB0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B9B394", Offset="0x1B9B394", VA="0x1B9B394")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094DD0", Offset="0x1094DD0")]
		public string Name
		{
			[Address(RVA="0x1B9B630", Offset="0x1B9B630", VA="0x1B9B630")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B9B638", Offset="0x1B9B638", VA="0x1B9B638")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094DF0", Offset="0x1094DF0")]
		public ulong Offset
		{
			[Address(RVA="0x1B9B6B8", Offset="0x1B9B6B8", VA="0x1B9B6B8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B9B6C0", Offset="0x1B9B6C0", VA="0x1B9B6C0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094DA0", Offset="0x1094DA0")]
		public static MessageParser<FindClubsRequest> Parser
		{
			[Address(RVA="0x1B9B32C", Offset="0x1B9B32C", VA="0x1B9B32C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094DC0", Offset="0x1094DC0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B9B484", Offset="0x1B9B484", VA="0x1B9B484", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B9BCEC", Offset="0x1B9BCEC", VA="0x1B9BCEC")]
		static FindClubsRequest()
		{
		}

		[Address(RVA="0x1B9B4E0", Offset="0x1B9B4E0", VA="0x1B9B4E0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B12C", Offset="0x107B12C")]
		public FindClubsRequest()
		{
		}

		[Address(RVA="0x1B9B538", Offset="0x1B9B538", VA="0x1B9B538")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B13C", Offset="0x107B13C")]
		public FindClubsRequest(FindClubsRequest other)
		{
		}

		[Address(RVA="0x1B9BA58", Offset="0x1B9BA58", VA="0x1B9BA58", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B1AC", Offset="0x107B1AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B9B5D0", Offset="0x1B9B5D0", VA="0x1B9B5D0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B14C", Offset="0x107B14C")]
		public FindClubsRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B9B6C8", Offset="0x1B9B6C8", VA="0x1B9B6C8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B15C", Offset="0x107B15C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9B73C", Offset="0x1B9B73C", VA="0x1B9B73C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B16C", Offset="0x107B16C")]
		public bool Equals(FindClubsRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9B7C0", Offset="0x1B9B7C0", VA="0x1B9B7C0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B17C", Offset="0x107B17C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B9BB8C", Offset="0x1B9BB8C", VA="0x1B9BB8C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B1BC", Offset="0x107B1BC")]
		public void MergeFrom(FindClubsRequest other)
		{
		}

		[Address(RVA="0x1B9BC10", Offset="0x1B9BC10", VA="0x1B9BC10", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B1CC", Offset="0x107B1CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B9B888", Offset="0x1B9B888", VA="0x1B9B888", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B18C", Offset="0x107B18C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B9B8F0", Offset="0x1B9B8F0", VA="0x1B9B8F0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B19C", Offset="0x107B19C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F758", Offset="0x104F758")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FindClubsRequest.<>c <>9;

			[Address(RVA="0x1B9BDC4", Offset="0x1B9BDC4", VA="0x1B9BDC4")]
			static <>c()
			{
			}

			[Address(RVA="0x1B9BE28", Offset="0x1B9BE28", VA="0x1B9BE28")]
			public <>c()
			{
			}

			[Address(RVA="0x1B9BE30", Offset="0x1B9BE30", VA="0x1B9BE30")]
			internal FindClubsRequest <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}