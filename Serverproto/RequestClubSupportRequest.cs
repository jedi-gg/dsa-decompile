using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class RequestClubSupportRequest : IMessage<RequestClubSupportRequest>, IMessage, IEquatable<RequestClubSupportRequest>, IDeepCloneable<RequestClubSupportRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<RequestClubSupportRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SupportRequestTypeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubSupportRequestType supportRequestType_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095430", Offset="0x1095430")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x202585C", Offset="0x202585C", VA="0x202585C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095420", Offset="0x1095420")]
		public static MessageParser<RequestClubSupportRequest> Parser
		{
			[Address(RVA="0x20257F4", Offset="0x20257F4", VA="0x20257F4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095440", Offset="0x1095440")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x202594C", Offset="0x202594C", VA="0x202594C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095450", Offset="0x1095450")]
		public ClubSupportRequestType SupportRequestType
		{
			[Address(RVA="0x2025A74", Offset="0x2025A74", VA="0x2025A74")]
			get
			{
				return new ClubSupportRequestType();
			}
			[Address(RVA="0x2025A7C", Offset="0x2025A7C", VA="0x2025A7C")]
			set
			{
			}
		}

		[Address(RVA="0x2025DF0", Offset="0x2025DF0", VA="0x2025DF0")]
		static RequestClubSupportRequest()
		{
		}

		[Address(RVA="0x20259A8", Offset="0x20259A8", VA="0x20259A8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C1AC", Offset="0x107C1AC")]
		public RequestClubSupportRequest()
		{
		}

		[Address(RVA="0x20259B0", Offset="0x20259B0", VA="0x20259B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C1BC", Offset="0x107C1BC")]
		public RequestClubSupportRequest(RequestClubSupportRequest other)
		{
		}

		[Address(RVA="0x2025CA4", Offset="0x2025CA4", VA="0x2025CA4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C22C", Offset="0x107C22C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2025A14", Offset="0x2025A14", VA="0x2025A14", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C1CC", Offset="0x107C1CC")]
		public RequestClubSupportRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x2025A84", Offset="0x2025A84", VA="0x2025A84", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C1DC", Offset="0x107C1DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2025AF8", Offset="0x2025AF8", VA="0x2025AF8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C1EC", Offset="0x107C1EC")]
		public bool Equals(RequestClubSupportRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x2025B34", Offset="0x2025B34", VA="0x2025B34", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C1FC", Offset="0x107C1FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2025D34", Offset="0x2025D34", VA="0x2025D34", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C23C", Offset="0x107C23C")]
		public void MergeFrom(RequestClubSupportRequest other)
		{
		}

		[Address(RVA="0x2025D74", Offset="0x2025D74", VA="0x2025D74", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C24C", Offset="0x107C24C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2025B9C", Offset="0x2025B9C", VA="0x2025B9C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C20C", Offset="0x107C20C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2025C04", Offset="0x2025C04", VA="0x2025C04", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107C21C", Offset="0x107C21C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F8D8", Offset="0x104F8D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RequestClubSupportRequest.<>c <>9;

			[Address(RVA="0x2025EC8", Offset="0x2025EC8", VA="0x2025EC8")]
			static <>c()
			{
			}

			[Address(RVA="0x2025F2C", Offset="0x2025F2C", VA="0x2025F2C")]
			public <>c()
			{
			}

			[Address(RVA="0x2025F34", Offset="0x2025F34", VA="0x2025F34")]
			internal RequestClubSupportRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}