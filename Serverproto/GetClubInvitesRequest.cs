using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetClubInvitesRequest : IMessage<GetClubInvitesRequest>, IMessage, IEquatable<GetClubInvitesRequest>, IDeepCloneable<GetClubInvitesRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetClubInvitesRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095340", Offset="0x1095340")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA6C34", Offset="0x1BA6C34", VA="0x1BA6C34")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095330", Offset="0x1095330")]
		public static MessageParser<GetClubInvitesRequest> Parser
		{
			[Address(RVA="0x1BA6BCC", Offset="0x1BA6BCC", VA="0x1BA6BCC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095350", Offset="0x1095350")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA6D24", Offset="0x1BA6D24", VA="0x1BA6D24", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA7038", Offset="0x1BA7038", VA="0x1BA7038")]
		static GetClubInvitesRequest()
		{
		}

		[Address(RVA="0x1BA6D80", Offset="0x1BA6D80", VA="0x1BA6D80")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BEEC", Offset="0x107BEEC")]
		public GetClubInvitesRequest()
		{
		}

		[Address(RVA="0x1BA6D88", Offset="0x1BA6D88", VA="0x1BA6D88")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BEFC", Offset="0x107BEFC")]
		public GetClubInvitesRequest(GetClubInvitesRequest other)
		{
		}

		[Address(RVA="0x1BA6F9C", Offset="0x1BA6F9C", VA="0x1BA6F9C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BF6C", Offset="0x107BF6C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA6DCC", Offset="0x1BA6DCC", VA="0x1BA6DCC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BF0C", Offset="0x107BF0C")]
		public GetClubInvitesRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA6E2C", Offset="0x1BA6E2C", VA="0x1BA6E2C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BF1C", Offset="0x107BF1C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA6EC4", Offset="0x1BA6EC4", VA="0x1BA6EC4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BF2C", Offset="0x107BF2C")]
		public bool Equals(GetClubInvitesRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA6EF0", Offset="0x1BA6EF0", VA="0x1BA6EF0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BF3C", Offset="0x107BF3C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA6FB0", Offset="0x1BA6FB0", VA="0x1BA6FB0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BF7C", Offset="0x107BF7C")]
		public void MergeFrom(GetClubInvitesRequest other)
		{
		}

		[Address(RVA="0x1BA6FE4", Offset="0x1BA6FE4", VA="0x1BA6FE4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BF8C", Offset="0x107BF8C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA6F20", Offset="0x1BA6F20", VA="0x1BA6F20", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BF4C", Offset="0x107BF4C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA6F88", Offset="0x1BA6F88", VA="0x1BA6F88", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BF5C", Offset="0x107BF5C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F898", Offset="0x104F898")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetClubInvitesRequest.<>c <>9;

			[Address(RVA="0x1BA7110", Offset="0x1BA7110", VA="0x1BA7110")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA7174", Offset="0x1BA7174", VA="0x1BA7174")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA717C", Offset="0x1BA717C", VA="0x1BA717C")]
			internal GetClubInvitesRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}