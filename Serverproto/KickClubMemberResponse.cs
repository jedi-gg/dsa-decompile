using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KickClubMemberResponse : IMessage<KickClubMemberResponse>, IMessage, IEquatable<KickClubMemberResponse>, IDeepCloneable<KickClubMemberResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KickClubMemberResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClubFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.Club club_;

		[FieldOffset(Offset="0x0")]
		public const int JoinLockFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private PlayerJoinClubLock joinLock_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095200", Offset="0x1095200")]
		public Serverproto.Club Club
		{
			[Address(RVA="0x1A9788C", Offset="0x1A9788C", VA="0x1A9788C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A97894", Offset="0x1A97894", VA="0x1A97894")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10951E0", Offset="0x10951E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A976A8", Offset="0x1A976A8", VA="0x1A976A8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095210", Offset="0x1095210")]
		public PlayerJoinClubLock JoinLock
		{
			[Address(RVA="0x1A9789C", Offset="0x1A9789C", VA="0x1A9789C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A978A4", Offset="0x1A978A4", VA="0x1A978A4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10951D0", Offset="0x10951D0")]
		public static MessageParser<KickClubMemberResponse> Parser
		{
			[Address(RVA="0x1A97640", Offset="0x1A97640", VA="0x1A97640")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10951F0", Offset="0x10951F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A97798", Offset="0x1A97798", VA="0x1A97798", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A97EB4", Offset="0x1A97EB4", VA="0x1A97EB4")]
		static KickClubMemberResponse()
		{
		}

		[Address(RVA="0x1A977F4", Offset="0x1A977F4", VA="0x1A977F4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BB7C", Offset="0x107BB7C")]
		public KickClubMemberResponse()
		{
		}

		[Address(RVA="0x1A977FC", Offset="0x1A977FC", VA="0x1A977FC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BB8C", Offset="0x107BB8C")]
		public KickClubMemberResponse(KickClubMemberResponse other)
		{
		}

		[Address(RVA="0x1A97BC8", Offset="0x1A97BC8", VA="0x1A97BC8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BBFC", Offset="0x107BBFC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A978AC", Offset="0x1A978AC", VA="0x1A978AC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BB9C", Offset="0x107BB9C")]
		public KickClubMemberResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A9790C", Offset="0x1A9790C", VA="0x1A9790C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BBAC", Offset="0x107BBAC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A97980", Offset="0x1A97980", VA="0x1A97980", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BBBC", Offset="0x107BBBC")]
		public bool Equals(KickClubMemberResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A979F8", Offset="0x1A979F8", VA="0x1A979F8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BBCC", Offset="0x107BBCC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A97C9C", Offset="0x1A97C9C", VA="0x1A97C9C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BC0C", Offset="0x107BC0C")]
		public void MergeFrom(KickClubMemberResponse other)
		{
		}

		[Address(RVA="0x1A97DA0", Offset="0x1A97DA0", VA="0x1A97DA0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BC1C", Offset="0x107BC1C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A97A68", Offset="0x1A97A68", VA="0x1A97A68", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BBDC", Offset="0x107BBDC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A97AD0", Offset="0x1A97AD0", VA="0x1A97AD0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107BBEC", Offset="0x107BBEC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F848", Offset="0x104F848")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KickClubMemberResponse.<>c <>9;

			[Address(RVA="0x1A97F8C", Offset="0x1A97F8C", VA="0x1A97F8C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A97FF0", Offset="0x1A97FF0", VA="0x1A97FF0")]
			public <>c()
			{
			}

			[Address(RVA="0x1A97FF8", Offset="0x1A97FF8", VA="0x1A97FF8")]
			internal KickClubMemberResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}