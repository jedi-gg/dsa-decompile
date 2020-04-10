using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerLeaderboardResponse : IMessage<PlayerLeaderboardResponse>, IMessage, IEquatable<PlayerLeaderboardResponse>, IDeepCloneable<PlayerLeaderboardResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerLeaderboardResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TypeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private PlayerLeaderboardType type_;

		[FieldOffset(Offset="0x0")]
		public const int EntriesFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<PlayerLeaderboardEntry> _repeated_entries_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<PlayerLeaderboardEntry> entries_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099570", Offset="0x1099570")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AFAEC8", Offset="0x1AFAEC8", VA="0x1AFAEC8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10995A0", Offset="0x10995A0")]
		public RepeatedField<PlayerLeaderboardEntry> Entries
		{
			[Address(RVA="0x1AFB1AC", Offset="0x1AFB1AC", VA="0x1AFB1AC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099560", Offset="0x1099560")]
		public static MessageParser<PlayerLeaderboardResponse> Parser
		{
			[Address(RVA="0x1AFAE60", Offset="0x1AFAE60", VA="0x1AFAE60")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099580", Offset="0x1099580")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AFAFB8", Offset="0x1AFAFB8", VA="0x1AFAFB8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099590", Offset="0x1099590")]
		public PlayerLeaderboardType Type
		{
			[Address(RVA="0x1AFB19C", Offset="0x1AFB19C", VA="0x1AFB19C")]
			get
			{
				return new PlayerLeaderboardType();
			}
			[Address(RVA="0x1AFB1A4", Offset="0x1AFB1A4", VA="0x1AFB1A4")]
			set
			{
			}
		}

		[Address(RVA="0x1AFB7A0", Offset="0x1AFB7A0", VA="0x1AFB7A0")]
		static PlayerLeaderboardResponse()
		{
		}

		[Address(RVA="0x1AFB014", Offset="0x1AFB014", VA="0x1AFB014")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10833CC", Offset="0x10833CC")]
		public PlayerLeaderboardResponse()
		{
		}

		[Address(RVA="0x1AFB084", Offset="0x1AFB084", VA="0x1AFB084")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10833DC", Offset="0x10833DC")]
		public PlayerLeaderboardResponse(PlayerLeaderboardResponse other)
		{
		}

		[Address(RVA="0x1AFB4FC", Offset="0x1AFB4FC", VA="0x1AFB4FC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108344C", Offset="0x108344C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AFB13C", Offset="0x1AFB13C", VA="0x1AFB13C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10833EC", Offset="0x10833EC")]
		public PlayerLeaderboardResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1AFB1B4", Offset="0x1AFB1B4", VA="0x1AFB1B4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10833FC", Offset="0x10833FC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AFB228", Offset="0x1AFB228", VA="0x1AFB228", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108340C", Offset="0x108340C")]
		public bool Equals(PlayerLeaderboardResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1AFB2E8", Offset="0x1AFB2E8", VA="0x1AFB2E8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108341C", Offset="0x108341C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AFB5F8", Offset="0x1AFB5F8", VA="0x1AFB5F8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108345C", Offset="0x108345C")]
		public void MergeFrom(PlayerLeaderboardResponse other)
		{
		}

		[Address(RVA="0x1AFB694", Offset="0x1AFB694", VA="0x1AFB694", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108346C", Offset="0x108346C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AFB378", Offset="0x1AFB378", VA="0x1AFB378", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108342C", Offset="0x108342C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AFB3E0", Offset="0x1AFB3E0", VA="0x1AFB3E0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108343C", Offset="0x108343C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050348", Offset="0x1050348")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerLeaderboardResponse.<>c <>9;

			[Address(RVA="0x1AFB8C0", Offset="0x1AFB8C0", VA="0x1AFB8C0")]
			static <>c()
			{
			}

			[Address(RVA="0x1AFB924", Offset="0x1AFB924", VA="0x1AFB924")]
			public <>c()
			{
			}

			[Address(RVA="0x1AFB92C", Offset="0x1AFB92C", VA="0x1AFB92C")]
			internal PlayerLeaderboardResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}