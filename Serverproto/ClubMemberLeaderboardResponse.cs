using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubMemberLeaderboardResponse : IMessage<ClubMemberLeaderboardResponse>, IMessage, IEquatable<ClubMemberLeaderboardResponse>, IDeepCloneable<ClubMemberLeaderboardResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubMemberLeaderboardResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TypeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubMemberLeaderboardType type_;

		[FieldOffset(Offset="0x0")]
		public const int EntriesFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<PlayerLeaderboardEntry> _repeated_entries_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<PlayerLeaderboardEntry> entries_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099690", Offset="0x1099690")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FFDBB0", Offset="0x1FFDBB0", VA="0x1FFDBB0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10996C0", Offset="0x10996C0")]
		public RepeatedField<PlayerLeaderboardEntry> Entries
		{
			[Address(RVA="0x1FFDE94", Offset="0x1FFDE94", VA="0x1FFDE94")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099680", Offset="0x1099680")]
		public static MessageParser<ClubMemberLeaderboardResponse> Parser
		{
			[Address(RVA="0x1FFDB48", Offset="0x1FFDB48", VA="0x1FFDB48")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10996A0", Offset="0x10996A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FFDCA0", Offset="0x1FFDCA0", VA="0x1FFDCA0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10996B0", Offset="0x10996B0")]
		public ClubMemberLeaderboardType Type
		{
			[Address(RVA="0x1FFDE84", Offset="0x1FFDE84", VA="0x1FFDE84")]
			get
			{
				return new ClubMemberLeaderboardType();
			}
			[Address(RVA="0x1FFDE8C", Offset="0x1FFDE8C", VA="0x1FFDE8C")]
			set
			{
			}
		}

		[Address(RVA="0x1FFE488", Offset="0x1FFE488", VA="0x1FFE488")]
		static ClubMemberLeaderboardResponse()
		{
		}

		[Address(RVA="0x1FFDCFC", Offset="0x1FFDCFC", VA="0x1FFDCFC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108368C", Offset="0x108368C")]
		public ClubMemberLeaderboardResponse()
		{
		}

		[Address(RVA="0x1FFDD6C", Offset="0x1FFDD6C", VA="0x1FFDD6C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108369C", Offset="0x108369C")]
		public ClubMemberLeaderboardResponse(ClubMemberLeaderboardResponse other)
		{
		}

		[Address(RVA="0x1FFE1E4", Offset="0x1FFE1E4", VA="0x1FFE1E4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108370C", Offset="0x108370C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FFDE24", Offset="0x1FFDE24", VA="0x1FFDE24", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10836AC", Offset="0x10836AC")]
		public ClubMemberLeaderboardResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FFDE9C", Offset="0x1FFDE9C", VA="0x1FFDE9C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10836BC", Offset="0x10836BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFDF10", Offset="0x1FFDF10", VA="0x1FFDF10", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10836CC", Offset="0x10836CC")]
		public bool Equals(ClubMemberLeaderboardResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFDFD0", Offset="0x1FFDFD0", VA="0x1FFDFD0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10836DC", Offset="0x10836DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FFE2E0", Offset="0x1FFE2E0", VA="0x1FFE2E0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108371C", Offset="0x108371C")]
		public void MergeFrom(ClubMemberLeaderboardResponse other)
		{
		}

		[Address(RVA="0x1FFE37C", Offset="0x1FFE37C", VA="0x1FFE37C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108372C", Offset="0x108372C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FFE060", Offset="0x1FFE060", VA="0x1FFE060", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10836EC", Offset="0x10836EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FFE0C8", Offset="0x1FFE0C8", VA="0x1FFE0C8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10836FC", Offset="0x10836FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050388", Offset="0x1050388")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubMemberLeaderboardResponse.<>c <>9;

			[Address(RVA="0x1FFE5AC", Offset="0x1FFE5AC", VA="0x1FFE5AC")]
			static <>c()
			{
			}

			[Address(RVA="0x1FFE610", Offset="0x1FFE610", VA="0x1FFE610")]
			public <>c()
			{
			}

			[Address(RVA="0x1FFE618", Offset="0x1FFE618", VA="0x1FFE618")]
			internal ClubMemberLeaderboardResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}