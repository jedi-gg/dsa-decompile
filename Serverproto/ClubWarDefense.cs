using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarDefense : IMessage<ClubWarDefense>, IMessage, IEquatable<ClubWarDefense>, IDeepCloneable<ClubWarDefense>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarDefense> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DefeatedByTeamIdsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_defeatedByTeamIds_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ulong> defeatedByTeamIds_;

		[FieldOffset(Offset="0x0")]
		public const int SquadFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ClubWarSquad squad_;

		[FieldOffset(Offset="0x0")]
		public const int UnderAttackByPlayersClubFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private bool underAttackByPlayersClub_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095DB0", Offset="0x1095DB0")]
		public RepeatedField<ulong> DefeatedByTeamIds
		{
			[Address(RVA="0x1B2192C", Offset="0x1B2192C", VA="0x1B2192C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095D90", Offset="0x1095D90")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B2164C", Offset="0x1B2164C", VA="0x1B2164C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095D80", Offset="0x1095D80")]
		public static MessageParser<ClubWarDefense> Parser
		{
			[Address(RVA="0x1B215E4", Offset="0x1B215E4", VA="0x1B215E4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095DA0", Offset="0x1095DA0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B2173C", Offset="0x1B2173C", VA="0x1B2173C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095DC0", Offset="0x1095DC0")]
		public ClubWarSquad Squad
		{
			[Address(RVA="0x1B218BC", Offset="0x1B218BC", VA="0x1B218BC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B218C4", Offset="0x1B218C4", VA="0x1B218C4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095DD0", Offset="0x1095DD0")]
		public bool UnderAttackByPlayersClub
		{
			[Address(RVA="0x1B21934", Offset="0x1B21934", VA="0x1B21934")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1B2193C", Offset="0x1B2193C", VA="0x1B2193C")]
			set
			{
			}
		}

		[Address(RVA="0x1B2208C", Offset="0x1B2208C", VA="0x1B2208C")]
		static ClubWarDefense()
		{
		}

		[Address(RVA="0x1B21798", Offset="0x1B21798", VA="0x1B21798")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D59C", Offset="0x107D59C")]
		public ClubWarDefense()
		{
		}

		[Address(RVA="0x1B21808", Offset="0x1B21808", VA="0x1B21808")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D5AC", Offset="0x107D5AC")]
		public ClubWarDefense(ClubWarDefense other)
		{
		}

		[Address(RVA="0x1B21D24", Offset="0x1B21D24", VA="0x1B21D24", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D61C", Offset="0x107D61C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B218CC", Offset="0x1B218CC", VA="0x1B218CC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D5BC", Offset="0x107D5BC")]
		public ClubWarDefense Clone()
		{
			return null;
		}

		[Address(RVA="0x1B21948", Offset="0x1B21948", VA="0x1B21948", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D5CC", Offset="0x107D5CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B219BC", Offset="0x1B219BC", VA="0x1B219BC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D5DC", Offset="0x107D5DC")]
		public bool Equals(ClubWarDefense other)
		{
			return new bool();
		}

		[Address(RVA="0x1B21AA0", Offset="0x1B21AA0", VA="0x1B21AA0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D5EC", Offset="0x107D5EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B21E28", Offset="0x1B21E28", VA="0x1B21E28", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D62C", Offset="0x107D62C")]
		public void MergeFrom(ClubWarDefense other)
		{
		}

		[Address(RVA="0x1B21F14", Offset="0x1B21F14", VA="0x1B21F14", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D63C", Offset="0x107D63C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B21B44", Offset="0x1B21B44", VA="0x1B21B44", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D5FC", Offset="0x107D5FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B21BAC", Offset="0x1B21BAC", VA="0x1B21BAC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D60C", Offset="0x107D60C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FAB8", Offset="0x104FAB8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarDefense.<>c <>9;

			[Address(RVA="0x1B2217C", Offset="0x1B2217C", VA="0x1B2217C")]
			static <>c()
			{
			}

			[Address(RVA="0x1B221E0", Offset="0x1B221E0", VA="0x1B221E0")]
			public <>c()
			{
			}

			[Address(RVA="0x1B221E8", Offset="0x1B221E8", VA="0x1B221E8")]
			internal ClubWarDefense <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}