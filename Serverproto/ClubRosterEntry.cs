using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubRosterEntry : IMessage<ClubRosterEntry>, IMessage, IEquatable<ClubRosterEntry>, IDeepCloneable<ClubRosterEntry>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubRosterEntry> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private PlayerProfileSimple player_;

		[FieldOffset(Offset="0x0")]
		public const int DonationCountFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong donationCount_;

		[FieldOffset(Offset="0x0")]
		public const int JoinedTimestampFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong joinedTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int LastLoginTimestampFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong lastLoginTimestamp_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094920", Offset="0x1094920")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B14980", Offset="0x1B14980", VA="0x1B14980")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094950", Offset="0x1094950")]
		public ulong DonationCount
		{
			[Address(RVA="0x1B14BD8", Offset="0x1B14BD8", VA="0x1B14BD8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B14BE0", Offset="0x1B14BE0", VA="0x1B14BE0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094960", Offset="0x1094960")]
		public ulong JoinedTimestamp
		{
			[Address(RVA="0x1B14BE8", Offset="0x1B14BE8", VA="0x1B14BE8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B14BF0", Offset="0x1B14BF0", VA="0x1B14BF0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094970", Offset="0x1094970")]
		public ulong LastLoginTimestamp
		{
			[Address(RVA="0x1B14BF8", Offset="0x1B14BF8", VA="0x1B14BF8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B14C00", Offset="0x1B14C00", VA="0x1B14C00")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094910", Offset="0x1094910")]
		public static MessageParser<ClubRosterEntry> Parser
		{
			[Address(RVA="0x1B14918", Offset="0x1B14918", VA="0x1B14918")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094930", Offset="0x1094930")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B14A70", Offset="0x1B14A70", VA="0x1B14A70", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094940", Offset="0x1094940")]
		public PlayerProfileSimple Player
		{
			[Address(RVA="0x1B14B68", Offset="0x1B14B68", VA="0x1B14B68")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B14B70", Offset="0x1B14B70", VA="0x1B14B70")]
			set
			{
			}
		}

		[Address(RVA="0x1B15358", Offset="0x1B15358", VA="0x1B15358")]
		static ClubRosterEntry()
		{
		}

		[Address(RVA="0x1B14ACC", Offset="0x1B14ACC", VA="0x1B14ACC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A8EC", Offset="0x107A8EC")]
		public ClubRosterEntry()
		{
		}

		[Address(RVA="0x1B14AD4", Offset="0x1B14AD4", VA="0x1B14AD4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A8FC", Offset="0x107A8FC")]
		public ClubRosterEntry(ClubRosterEntry other)
		{
		}

		[Address(RVA="0x1B14FD8", Offset="0x1B14FD8", VA="0x1B14FD8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A96C", Offset="0x107A96C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B14B78", Offset="0x1B14B78", VA="0x1B14B78", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A90C", Offset="0x107A90C")]
		public ClubRosterEntry Clone()
		{
			return null;
		}

		[Address(RVA="0x1B14C08", Offset="0x1B14C08", VA="0x1B14C08", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A91C", Offset="0x107A91C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B14C7C", Offset="0x1B14C7C", VA="0x1B14C7C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A92C", Offset="0x107A92C")]
		public bool Equals(ClubRosterEntry other)
		{
			return new bool();
		}

		[Address(RVA="0x1B14D10", Offset="0x1B14D10", VA="0x1B14D10", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A93C", Offset="0x107A93C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B15124", Offset="0x1B15124", VA="0x1B15124", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A97C", Offset="0x107A97C")]
		public void MergeFrom(ClubRosterEntry other)
		{
		}

		[Address(RVA="0x1B151FC", Offset="0x1B151FC", VA="0x1B151FC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A98C", Offset="0x107A98C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B14DC8", Offset="0x1B14DC8", VA="0x1B14DC8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A94C", Offset="0x107A94C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B14E30", Offset="0x1B14E30", VA="0x1B14E30", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A95C", Offset="0x107A95C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F698", Offset="0x104F698")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubRosterEntry.<>c <>9;

			[Address(RVA="0x1B15430", Offset="0x1B15430", VA="0x1B15430")]
			static <>c()
			{
			}

			[Address(RVA="0x1B15494", Offset="0x1B15494", VA="0x1B15494")]
			public <>c()
			{
			}

			[Address(RVA="0x1B1549C", Offset="0x1B1549C", VA="0x1B1549C")]
			internal ClubRosterEntry <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}