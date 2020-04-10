using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeClubDonationsRequest : IMessage<HomeClubDonationsRequest>, IMessage, IEquatable<HomeClubDonationsRequest>, IDeepCloneable<HomeClubDonationsRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeClubDonationsRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097BF8", Offset="0x1097BF8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1CFDEEC", Offset="0x1CFDEEC", VA="0x1CFDEEC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097BE8", Offset="0x1097BE8")]
		public static MessageParser<HomeClubDonationsRequest> Parser
		{
			[Address(RVA="0x1CFDE84", Offset="0x1CFDE84", VA="0x1CFDE84")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097C08", Offset="0x1097C08")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1CFE040", Offset="0x1CFE040", VA="0x1CFE040", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1CFE354", Offset="0x1CFE354", VA="0x1CFE354")]
		static HomeClubDonationsRequest()
		{
		}

		[Address(RVA="0x1CFE09C", Offset="0x1CFE09C", VA="0x1CFE09C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108066C", Offset="0x108066C")]
		public HomeClubDonationsRequest()
		{
		}

		[Address(RVA="0x1CFE0A4", Offset="0x1CFE0A4", VA="0x1CFE0A4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108067C", Offset="0x108067C")]
		public HomeClubDonationsRequest(HomeClubDonationsRequest other)
		{
		}

		[Address(RVA="0x1CFE2B8", Offset="0x1CFE2B8", VA="0x1CFE2B8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10806EC", Offset="0x10806EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1CFE0E8", Offset="0x1CFE0E8", VA="0x1CFE0E8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108068C", Offset="0x108068C")]
		public HomeClubDonationsRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1CFE148", Offset="0x1CFE148", VA="0x1CFE148", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108069C", Offset="0x108069C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1CFE1E0", Offset="0x1CFE1E0", VA="0x1CFE1E0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10806AC", Offset="0x10806AC")]
		public bool Equals(HomeClubDonationsRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1CFE20C", Offset="0x1CFE20C", VA="0x1CFE20C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10806BC", Offset="0x10806BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1CFE2CC", Offset="0x1CFE2CC", VA="0x1CFE2CC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10806FC", Offset="0x10806FC")]
		public void MergeFrom(HomeClubDonationsRequest other)
		{
		}

		[Address(RVA="0x1CFE300", Offset="0x1CFE300", VA="0x1CFE300", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108070C", Offset="0x108070C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1CFE23C", Offset="0x1CFE23C", VA="0x1CFE23C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10806CC", Offset="0x10806CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1CFE2A4", Offset="0x1CFE2A4", VA="0x1CFE2A4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10806DC", Offset="0x10806DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FF28", Offset="0x104FF28")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeClubDonationsRequest.<>c <>9;

			[Address(RVA="0x1CFE42C", Offset="0x1CFE42C", VA="0x1CFE42C")]
			static <>c()
			{
			}

			[Address(RVA="0x1CFE490", Offset="0x1CFE490", VA="0x1CFE490")]
			public <>c()
			{
			}

			[Address(RVA="0x1CFE498", Offset="0x1CFE498", VA="0x1CFE498")]
			internal HomeClubDonationsRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}