using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FriendsListResponse : IMessage<FriendsListResponse>, IMessage, IEquatable<FriendsListResponse>, IDeepCloneable<FriendsListResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FriendsListResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int FriendsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<Friend> _repeated_friends_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<Friend> friends_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A740", Offset="0x109A740")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA1498", Offset="0x1BA1498", VA="0x1BA1498")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A760", Offset="0x109A760")]
		public RepeatedField<Friend> Friends
		{
			[Address(RVA="0x1BA174C", Offset="0x1BA174C", VA="0x1BA174C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A730", Offset="0x109A730")]
		public static MessageParser<FriendsListResponse> Parser
		{
			[Address(RVA="0x1BA1430", Offset="0x1BA1430", VA="0x1BA1430")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A750", Offset="0x109A750")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA1588", Offset="0x1BA1588", VA="0x1BA1588", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA1C34", Offset="0x1BA1C34", VA="0x1BA1C34")]
		static FriendsListResponse()
		{
		}

		[Address(RVA="0x1BA15E4", Offset="0x1BA15E4", VA="0x1BA15E4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084ABC", Offset="0x1084ABC")]
		public FriendsListResponse()
		{
		}

		[Address(RVA="0x1BA1654", Offset="0x1BA1654", VA="0x1BA1654")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084ACC", Offset="0x1084ACC")]
		public FriendsListResponse(FriendsListResponse other)
		{
		}

		[Address(RVA="0x1BA1A04", Offset="0x1BA1A04", VA="0x1BA1A04", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084B3C", Offset="0x1084B3C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA16EC", Offset="0x1BA16EC", VA="0x1BA16EC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084ADC", Offset="0x1084ADC")]
		public FriendsListResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA1754", Offset="0x1BA1754", VA="0x1BA1754", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084AEC", Offset="0x1084AEC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA17C8", Offset="0x1BA17C8", VA="0x1BA17C8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084AFC", Offset="0x1084AFC")]
		public bool Equals(FriendsListResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA1878", Offset="0x1BA1878", VA="0x1BA1878", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084B0C", Offset="0x1084B0C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA1AC0", Offset="0x1BA1AC0", VA="0x1BA1AC0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084B4C", Offset="0x1084B4C")]
		public void MergeFrom(FriendsListResponse other)
		{
		}

		[Address(RVA="0x1BA1B50", Offset="0x1BA1B50", VA="0x1BA1B50", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084B5C", Offset="0x1084B5C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA18D8", Offset="0x1BA18D8", VA="0x1BA18D8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084B1C", Offset="0x1084B1C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA1940", Offset="0x1BA1940", VA="0x1BA1940", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084B2C", Offset="0x1084B2C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050558", Offset="0x1050558")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FriendsListResponse.<>c <>9;

			[Address(RVA="0x1BA1D54", Offset="0x1BA1D54", VA="0x1BA1D54")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA1DB8", Offset="0x1BA1DB8", VA="0x1BA1DB8")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA1DC0", Offset="0x1BA1DC0", VA="0x1BA1DC0")]
			internal FriendsListResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}