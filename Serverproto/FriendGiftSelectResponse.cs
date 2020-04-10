using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FriendGiftSelectResponse : IMessage<FriendGiftSelectResponse>, IMessage, IEquatable<FriendGiftSelectResponse>, IDeepCloneable<FriendGiftSelectResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FriendGiftSelectResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int GiftIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string giftId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B930", Offset="0x109B930")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B9E308", Offset="0x1B9E308", VA="0x1B9E308")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B950", Offset="0x109B950")]
		public string GiftId
		{
			[Address(RVA="0x1B9E56C", Offset="0x1B9E56C", VA="0x1B9E56C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B9E574", Offset="0x1B9E574", VA="0x1B9E574")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B920", Offset="0x109B920")]
		public static MessageParser<FriendGiftSelectResponse> Parser
		{
			[Address(RVA="0x1B9E2A0", Offset="0x1B9E2A0", VA="0x1B9E2A0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B940", Offset="0x109B940")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B9E3F8", Offset="0x1B9E3F8", VA="0x1B9E3F8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B9EA04", Offset="0x1B9EA04", VA="0x1B9EA04")]
		static FriendGiftSelectResponse()
		{
		}

		[Address(RVA="0x1B9E454", Offset="0x1B9E454", VA="0x1B9E454")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108760C", Offset="0x108760C")]
		public FriendGiftSelectResponse()
		{
		}

		[Address(RVA="0x1B9E4AC", Offset="0x1B9E4AC", VA="0x1B9E4AC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108761C", Offset="0x108761C")]
		public FriendGiftSelectResponse(FriendGiftSelectResponse other)
		{
		}

		[Address(RVA="0x1B9E860", Offset="0x1B9E860", VA="0x1B9E860", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108768C", Offset="0x108768C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B9E50C", Offset="0x1B9E50C", VA="0x1B9E50C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108762C", Offset="0x108762C")]
		public FriendGiftSelectResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B9E5E4", Offset="0x1B9E5E4", VA="0x1B9E5E4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108763C", Offset="0x108763C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9E658", Offset="0x1B9E658", VA="0x1B9E658", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108764C", Offset="0x108764C")]
		public bool Equals(FriendGiftSelectResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9E6BC", Offset="0x1B9E6BC", VA="0x1B9E6BC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108765C", Offset="0x108765C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B9E914", Offset="0x1B9E914", VA="0x1B9E914", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108769C", Offset="0x108769C")]
		public void MergeFrom(FriendGiftSelectResponse other)
		{
		}

		[Address(RVA="0x1B9E980", Offset="0x1B9E980", VA="0x1B9E980", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10876AC", Offset="0x10876AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B9E740", Offset="0x1B9E740", VA="0x1B9E740", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108766C", Offset="0x108766C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B9E7A8", Offset="0x1B9E7A8", VA="0x1B9E7A8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108767C", Offset="0x108767C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050948", Offset="0x1050948")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FriendGiftSelectResponse.<>c <>9;

			[Address(RVA="0x1B9EADC", Offset="0x1B9EADC", VA="0x1B9EADC")]
			static <>c()
			{
			}

			[Address(RVA="0x1B9EB40", Offset="0x1B9EB40", VA="0x1B9EB40")]
			public <>c()
			{
			}

			[Address(RVA="0x1B9EB48", Offset="0x1B9EB48", VA="0x1B9EB48")]
			internal FriendGiftSelectResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}