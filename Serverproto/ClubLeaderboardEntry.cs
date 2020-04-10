using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubLeaderboardEntry : IMessage<ClubLeaderboardEntry>, IMessage, IEquatable<ClubLeaderboardEntry>, IDeepCloneable<ClubLeaderboardEntry>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubLeaderboardEntry> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int NameFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string name_;

		[FieldOffset(Offset="0x0")]
		public const int AvatarIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong avatarId_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentScoreFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong currentScore_;

		[FieldOffset(Offset="0x0")]
		public const int RankDeltaFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private int rankDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10994F0", Offset="0x10994F0")]
		public ulong AvatarId
		{
			[Address(RVA="0x1FFB684", Offset="0x1FFB684", VA="0x1FFB684")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FFB68C", Offset="0x1FFB68C", VA="0x1FFB68C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099500", Offset="0x1099500")]
		public ulong CurrentScore
		{
			[Address(RVA="0x1FFB694", Offset="0x1FFB694", VA="0x1FFB694")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FFB69C", Offset="0x1FFB69C", VA="0x1FFB69C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10994B0", Offset="0x10994B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FFB2C0", Offset="0x1FFB2C0", VA="0x1FFB2C0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10994D0", Offset="0x10994D0")]
		public string Id
		{
			[Address(RVA="0x1FFB594", Offset="0x1FFB594", VA="0x1FFB594")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FFB59C", Offset="0x1FFB59C", VA="0x1FFB59C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10994E0", Offset="0x10994E0")]
		public string Name
		{
			[Address(RVA="0x1FFB60C", Offset="0x1FFB60C", VA="0x1FFB60C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FFB614", Offset="0x1FFB614", VA="0x1FFB614")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10994A0", Offset="0x10994A0")]
		public static MessageParser<ClubLeaderboardEntry> Parser
		{
			[Address(RVA="0x1FFB258", Offset="0x1FFB258", VA="0x1FFB258")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10994C0", Offset="0x10994C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FFB3B0", Offset="0x1FFB3B0", VA="0x1FFB3B0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099510", Offset="0x1099510")]
		public int RankDelta
		{
			[Address(RVA="0x1FFB6A4", Offset="0x1FFB6A4", VA="0x1FFB6A4")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1FFB6AC", Offset="0x1FFB6AC", VA="0x1FFB6AC")]
			set
			{
			}
		}

		[Address(RVA="0x1FFBF50", Offset="0x1FFBF50", VA="0x1FFBF50")]
		static ClubLeaderboardEntry()
		{
		}

		[Address(RVA="0x1FFB40C", Offset="0x1FFB40C", VA="0x1FFB40C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108326C", Offset="0x108326C")]
		public ClubLeaderboardEntry()
		{
		}

		[Address(RVA="0x1FFB464", Offset="0x1FFB464", VA="0x1FFB464")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108327C", Offset="0x108327C")]
		public ClubLeaderboardEntry(ClubLeaderboardEntry other)
		{
		}

		[Address(RVA="0x1FFBB98", Offset="0x1FFBB98", VA="0x1FFBB98", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10832EC", Offset="0x10832EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FFB534", Offset="0x1FFB534", VA="0x1FFB534", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108328C", Offset="0x108328C")]
		public ClubLeaderboardEntry Clone()
		{
			return null;
		}

		[Address(RVA="0x1FFB6B4", Offset="0x1FFB6B4", VA="0x1FFB6B4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108329C", Offset="0x108329C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFB728", Offset="0x1FFB728", VA="0x1FFB728", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10832AC", Offset="0x10832AC")]
		public bool Equals(ClubLeaderboardEntry other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFB7D0", Offset="0x1FFB7D0", VA="0x1FFB7D0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10832BC", Offset="0x10832BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FFBD60", Offset="0x1FFBD60", VA="0x1FFBD60", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10832FC", Offset="0x10832FC")]
		public void MergeFrom(ClubLeaderboardEntry other)
		{
		}

		[Address(RVA="0x1FFBE1C", Offset="0x1FFBE1C", VA="0x1FFBE1C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108330C", Offset="0x108330C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FFB900", Offset="0x1FFB900", VA="0x1FFB900", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10832CC", Offset="0x10832CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FFB968", Offset="0x1FFB968", VA="0x1FFB968", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10832DC", Offset="0x10832DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050328", Offset="0x1050328")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubLeaderboardEntry.<>c <>9;

			[Address(RVA="0x1FFC028", Offset="0x1FFC028", VA="0x1FFC028")]
			static <>c()
			{
			}

			[Address(RVA="0x1FFC08C", Offset="0x1FFC08C", VA="0x1FFC08C")]
			public <>c()
			{
			}

			[Address(RVA="0x1FFC094", Offset="0x1FFC094", VA="0x1FFC094")]
			internal ClubLeaderboardEntry <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}