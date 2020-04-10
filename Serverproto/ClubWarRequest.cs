using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarRequest : IMessage<ClubWarRequest>, IMessage, IEquatable<ClubWarRequest>, IDeepCloneable<ClubWarRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095E40", Offset="0x1095E40")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B29C74", Offset="0x1B29C74", VA="0x1B29C74")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095E30", Offset="0x1095E30")]
		public static MessageParser<ClubWarRequest> Parser
		{
			[Address(RVA="0x1B29C0C", Offset="0x1B29C0C", VA="0x1B29C0C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095E50", Offset="0x1095E50")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B29D64", Offset="0x1B29D64", VA="0x1B29D64", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B2A078", Offset="0x1B2A078", VA="0x1B2A078")]
		static ClubWarRequest()
		{
		}

		[Address(RVA="0x1B29DC0", Offset="0x1B29DC0", VA="0x1B29DC0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D6FC", Offset="0x107D6FC")]
		public ClubWarRequest()
		{
		}

		[Address(RVA="0x1B29DC8", Offset="0x1B29DC8", VA="0x1B29DC8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D70C", Offset="0x107D70C")]
		public ClubWarRequest(ClubWarRequest other)
		{
		}

		[Address(RVA="0x1B29FDC", Offset="0x1B29FDC", VA="0x1B29FDC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D77C", Offset="0x107D77C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B29E0C", Offset="0x1B29E0C", VA="0x1B29E0C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D71C", Offset="0x107D71C")]
		public ClubWarRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B29E6C", Offset="0x1B29E6C", VA="0x1B29E6C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D72C", Offset="0x107D72C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B29F04", Offset="0x1B29F04", VA="0x1B29F04", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D73C", Offset="0x107D73C")]
		public bool Equals(ClubWarRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B29F30", Offset="0x1B29F30", VA="0x1B29F30", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D74C", Offset="0x107D74C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B29FF0", Offset="0x1B29FF0", VA="0x1B29FF0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D78C", Offset="0x107D78C")]
		public void MergeFrom(ClubWarRequest other)
		{
		}

		[Address(RVA="0x1B2A024", Offset="0x1B2A024", VA="0x1B2A024", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D79C", Offset="0x107D79C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B29F60", Offset="0x1B29F60", VA="0x1B29F60", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D75C", Offset="0x107D75C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B29FC8", Offset="0x1B29FC8", VA="0x1B29FC8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D76C", Offset="0x107D76C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FAD8", Offset="0x104FAD8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarRequest.<>c <>9;

			[Address(RVA="0x1B2A150", Offset="0x1B2A150", VA="0x1B2A150")]
			static <>c()
			{
			}

			[Address(RVA="0x1B2A1B4", Offset="0x1B2A1B4", VA="0x1B2A1B4")]
			public <>c()
			{
			}

			[Address(RVA="0x1B2A1BC", Offset="0x1B2A1BC", VA="0x1B2A1BC")]
			internal ClubWarRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}