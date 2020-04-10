using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeFriendsRequest : IMessage<HomeFriendsRequest>, IMessage, IEquatable<HomeFriendsRequest>, IDeepCloneable<HomeFriendsRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeFriendsRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10981E0", Offset="0x10981E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D03DCC", Offset="0x1D03DCC", VA="0x1D03DCC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10981D0", Offset="0x10981D0")]
		public static MessageParser<HomeFriendsRequest> Parser
		{
			[Address(RVA="0x1D03D64", Offset="0x1D03D64", VA="0x1D03D64")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10981F0", Offset="0x10981F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D03EB8", Offset="0x1D03EB8", VA="0x1D03EB8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D041CC", Offset="0x1D041CC", VA="0x1D041CC")]
		static HomeFriendsRequest()
		{
		}

		[Address(RVA="0x1D03F14", Offset="0x1D03F14", VA="0x1D03F14")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108137C", Offset="0x108137C")]
		public HomeFriendsRequest()
		{
		}

		[Address(RVA="0x1D03F1C", Offset="0x1D03F1C", VA="0x1D03F1C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108138C", Offset="0x108138C")]
		public HomeFriendsRequest(HomeFriendsRequest other)
		{
		}

		[Address(RVA="0x1D04130", Offset="0x1D04130", VA="0x1D04130", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10813FC", Offset="0x10813FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D03F60", Offset="0x1D03F60", VA="0x1D03F60", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108139C", Offset="0x108139C")]
		public HomeFriendsRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1D03FC0", Offset="0x1D03FC0", VA="0x1D03FC0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10813AC", Offset="0x10813AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D04058", Offset="0x1D04058", VA="0x1D04058", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10813BC", Offset="0x10813BC")]
		public bool Equals(HomeFriendsRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1D04084", Offset="0x1D04084", VA="0x1D04084", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10813CC", Offset="0x10813CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D04144", Offset="0x1D04144", VA="0x1D04144", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108140C", Offset="0x108140C")]
		public void MergeFrom(HomeFriendsRequest other)
		{
		}

		[Address(RVA="0x1D04178", Offset="0x1D04178", VA="0x1D04178", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108141C", Offset="0x108141C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D040B4", Offset="0x1D040B4", VA="0x1D040B4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10813DC", Offset="0x10813DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D0411C", Offset="0x1D0411C", VA="0x1D0411C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10813EC", Offset="0x10813EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050058", Offset="0x1050058")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeFriendsRequest.<>c <>9;

			[Address(RVA="0x1D042A4", Offset="0x1D042A4", VA="0x1D042A4")]
			static <>c()
			{
			}

			[Address(RVA="0x1D04308", Offset="0x1D04308", VA="0x1D04308")]
			public <>c()
			{
			}

			[Address(RVA="0x1D04310", Offset="0x1D04310", VA="0x1D04310")]
			internal HomeFriendsRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}