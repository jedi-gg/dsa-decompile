using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubInviteRequest : IMessage<ClubInviteRequest>, IMessage, IEquatable<ClubInviteRequest>, IDeepCloneable<ClubInviteRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubInviteRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string clubId_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string playerId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094E90", Offset="0x1094E90")]
		public string ClubId
		{
			[Address(RVA="0x1FF8E1C", Offset="0x1FF8E1C", VA="0x1FF8E1C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF8E24", Offset="0x1FF8E24", VA="0x1FF8E24")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094E70", Offset="0x1094E70")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FF8BA0", Offset="0x1FF8BA0", VA="0x1FF8BA0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094E60", Offset="0x1094E60")]
		public static MessageParser<ClubInviteRequest> Parser
		{
			[Address(RVA="0x1FF8B38", Offset="0x1FF8B38", VA="0x1FF8B38")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094E80", Offset="0x1094E80")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FF8C8C", Offset="0x1FF8C8C", VA="0x1FF8C8C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094EA0", Offset="0x1094EA0")]
		public string PlayerId
		{
			[Address(RVA="0x1FF8E94", Offset="0x1FF8E94", VA="0x1FF8E94")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF8E9C", Offset="0x1FF8E9C", VA="0x1FF8E9C")]
			set
			{
			}
		}

		[Address(RVA="0x1FF94B8", Offset="0x1FF94B8", VA="0x1FF94B8")]
		static ClubInviteRequest()
		{
		}

		[Address(RVA="0x1FF8CE8", Offset="0x1FF8CE8", VA="0x1FF8CE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B28C", Offset="0x107B28C")]
		public ClubInviteRequest()
		{
		}

		[Address(RVA="0x1FF8D40", Offset="0x1FF8D40", VA="0x1FF8D40")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B29C", Offset="0x107B29C")]
		public ClubInviteRequest(ClubInviteRequest other)
		{
		}

		[Address(RVA="0x1FF9258", Offset="0x1FF9258", VA="0x1FF9258", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B30C", Offset="0x107B30C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FF8DBC", Offset="0x1FF8DBC", VA="0x1FF8DBC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B2AC", Offset="0x107B2AC")]
		public ClubInviteRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FF8F0C", Offset="0x1FF8F0C", VA="0x1FF8F0C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B2BC", Offset="0x107B2BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF8F80", Offset="0x1FF8F80", VA="0x1FF8F80", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B2CC", Offset="0x107B2CC")]
		public bool Equals(ClubInviteRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF8FF8", Offset="0x1FF8FF8", VA="0x1FF8FF8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B2DC", Offset="0x107B2DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FF936C", Offset="0x1FF936C", VA="0x1FF936C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B31C", Offset="0x107B31C")]
		public void MergeFrom(ClubInviteRequest other)
		{
		}

		[Address(RVA="0x1FF9404", Offset="0x1FF9404", VA="0x1FF9404", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B32C", Offset="0x107B32C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FF90C8", Offset="0x1FF90C8", VA="0x1FF90C8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B2EC", Offset="0x107B2EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FF9130", Offset="0x1FF9130", VA="0x1FF9130", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B2FC", Offset="0x107B2FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F778", Offset="0x104F778")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubInviteRequest.<>c <>9;

			[Address(RVA="0x1FF9590", Offset="0x1FF9590", VA="0x1FF9590")]
			static <>c()
			{
			}

			[Address(RVA="0x1FF95F4", Offset="0x1FF95F4", VA="0x1FF95F4")]
			public <>c()
			{
			}

			[Address(RVA="0x1FF95FC", Offset="0x1FF95FC", VA="0x1FF95FC")]
			internal ClubInviteRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}