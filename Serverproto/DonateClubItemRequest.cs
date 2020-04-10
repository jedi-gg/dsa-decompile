using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DonateClubItemRequest : IMessage<DonateClubItemRequest>, IMessage, IEquatable<DonateClubItemRequest>, IDeepCloneable<DonateClubItemRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DonateClubItemRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int RequestIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ByteString requestId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10952C0", Offset="0x10952C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FBC918", Offset="0x1FBC918", VA="0x1FBC918")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10952B0", Offset="0x10952B0")]
		public static MessageParser<DonateClubItemRequest> Parser
		{
			[Address(RVA="0x1FBC8B0", Offset="0x1FBC8B0", VA="0x1FBC8B0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10952D0", Offset="0x10952D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FBCA08", Offset="0x1FBCA08", VA="0x1FBCA08", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10952E0", Offset="0x10952E0")]
		public ByteString RequestId
		{
			[Address(RVA="0x1FBCB98", Offset="0x1FBCB98", VA="0x1FBCB98")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FBCBA0", Offset="0x1FBCBA0", VA="0x1FBCBA0")]
			set
			{
			}
		}

		[Address(RVA="0x1FBD088", Offset="0x1FBD088", VA="0x1FBD088")]
		static DonateClubItemRequest()
		{
		}

		[Address(RVA="0x1FBCA64", Offset="0x1FBCA64", VA="0x1FBCA64")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BD8C", Offset="0x107BD8C")]
		public DonateClubItemRequest()
		{
		}

		[Address(RVA="0x1FBCAD8", Offset="0x1FBCAD8", VA="0x1FBCAD8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BD9C", Offset="0x107BD9C")]
		public DonateClubItemRequest(DonateClubItemRequest other)
		{
		}

		[Address(RVA="0x1FBCEE4", Offset="0x1FBCEE4", VA="0x1FBCEE4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BE0C", Offset="0x107BE0C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FBCB38", Offset="0x1FBCB38", VA="0x1FBCB38", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BDAC", Offset="0x107BDAC")]
		public DonateClubItemRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FBCC10", Offset="0x1FBCC10", VA="0x1FBCC10", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BDBC", Offset="0x107BDBC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBCC84", Offset="0x1FBCC84", VA="0x1FBCC84", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BDCC", Offset="0x107BDCC")]
		public bool Equals(DonateClubItemRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBCD40", Offset="0x1FBCD40", VA="0x1FBCD40", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BDDC", Offset="0x107BDDC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FBCF98", Offset="0x1FBCF98", VA="0x1FBCF98", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BE1C", Offset="0x107BE1C")]
		public void MergeFrom(DonateClubItemRequest other)
		{
		}

		[Address(RVA="0x1FBD004", Offset="0x1FBD004", VA="0x1FBD004", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BE2C", Offset="0x107BE2C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FBCDC4", Offset="0x1FBCDC4", VA="0x1FBCDC4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BDEC", Offset="0x107BDEC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FBCE2C", Offset="0x1FBCE2C", VA="0x1FBCE2C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BDFC", Offset="0x107BDFC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F878", Offset="0x104F878")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DonateClubItemRequest.<>c <>9;

			[Address(RVA="0x1FBD160", Offset="0x1FBD160", VA="0x1FBD160")]
			static <>c()
			{
			}

			[Address(RVA="0x1FBD1C4", Offset="0x1FBD1C4", VA="0x1FBD1C4")]
			public <>c()
			{
			}

			[Address(RVA="0x1FBD1CC", Offset="0x1FBD1CC", VA="0x1FBD1CC")]
			internal DonateClubItemRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}