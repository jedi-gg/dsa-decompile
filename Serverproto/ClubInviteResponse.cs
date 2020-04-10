using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubInviteResponse : IMessage<ClubInviteResponse>, IMessage, IEquatable<ClubInviteResponse>, IDeepCloneable<ClubInviteResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubInviteResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.Club club_;

		[FieldOffset(Offset="0x0")]
		public const int InviteFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ClubInvite invite_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094EE0", Offset="0x1094EE0")]
		public Serverproto.Club Club
		{
			[Address(RVA="0x1FF9898", Offset="0x1FF9898", VA="0x1FF9898")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF98A0", Offset="0x1FF98A0", VA="0x1FF98A0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094EC0", Offset="0x1094EC0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FF96BC", Offset="0x1FF96BC", VA="0x1FF96BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094EF0", Offset="0x1094EF0")]
		public ClubInvite Invite
		{
			[Address(RVA="0x1FF98A8", Offset="0x1FF98A8", VA="0x1FF98A8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FF98B0", Offset="0x1FF98B0", VA="0x1FF98B0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094EB0", Offset="0x1094EB0")]
		public static MessageParser<ClubInviteResponse> Parser
		{
			[Address(RVA="0x1FF9654", Offset="0x1FF9654", VA="0x1FF9654")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094ED0", Offset="0x1094ED0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FF97A8", Offset="0x1FF97A8", VA="0x1FF97A8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FF9EB4", Offset="0x1FF9EB4", VA="0x1FF9EB4")]
		static ClubInviteResponse()
		{
		}

		[Address(RVA="0x1FF9804", Offset="0x1FF9804", VA="0x1FF9804")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B33C", Offset="0x107B33C")]
		public ClubInviteResponse()
		{
		}

		[Address(RVA="0x1FF980C", Offset="0x1FF980C", VA="0x1FF980C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B34C", Offset="0x107B34C")]
		public ClubInviteResponse(ClubInviteResponse other)
		{
		}

		[Address(RVA="0x1FF9BD4", Offset="0x1FF9BD4", VA="0x1FF9BD4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B3BC", Offset="0x107B3BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FF98B8", Offset="0x1FF98B8", VA="0x1FF98B8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B35C", Offset="0x107B35C")]
		public ClubInviteResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FF9918", Offset="0x1FF9918", VA="0x1FF9918", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B36C", Offset="0x107B36C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF998C", Offset="0x1FF998C", VA="0x1FF998C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B37C", Offset="0x107B37C")]
		public bool Equals(ClubInviteResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FF9A04", Offset="0x1FF9A04", VA="0x1FF9A04", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B38C", Offset="0x107B38C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FF9CA8", Offset="0x1FF9CA8", VA="0x1FF9CA8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B3CC", Offset="0x107B3CC")]
		public void MergeFrom(ClubInviteResponse other)
		{
		}

		[Address(RVA="0x1FF9DA4", Offset="0x1FF9DA4", VA="0x1FF9DA4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B3DC", Offset="0x107B3DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FF9A74", Offset="0x1FF9A74", VA="0x1FF9A74", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B39C", Offset="0x107B39C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FF9ADC", Offset="0x1FF9ADC", VA="0x1FF9ADC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107B3AC", Offset="0x107B3AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F788", Offset="0x104F788")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubInviteResponse.<>c <>9;

			[Address(RVA="0x1FF9F8C", Offset="0x1FF9F8C", VA="0x1FF9F8C")]
			static <>c()
			{
			}

			[Address(RVA="0x1FF9FF0", Offset="0x1FF9FF0", VA="0x1FF9FF0")]
			public <>c()
			{
			}

			[Address(RVA="0x1FF9FF8", Offset="0x1FF9FF8", VA="0x1FF9FF8")]
			internal ClubInviteResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}