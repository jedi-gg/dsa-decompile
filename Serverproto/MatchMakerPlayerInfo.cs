using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MatchMakerPlayerInfo : IMessage<MatchMakerPlayerInfo>, IMessage, IEquatable<MatchMakerPlayerInfo>, IDeepCloneable<MatchMakerPlayerInfo>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MatchMakerPlayerInfo> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int GamedataVersionFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string gamedataVersion_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string playerId_;

		[FieldOffset(Offset="0x0")]
		public const int PowerRatingFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong powerRating_;

		[FieldOffset(Offset="0x0")]
		public const int UnitsFieldNumber = 4;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<Unit> _repeated_units_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<Unit> units_;

		[FieldOffset(Offset="0x0")]
		public const int SpellsFieldNumber = 5;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<Spell> _repeated_spells_codec;

		[FieldOffset(Offset="0x38")]
		private readonly RepeatedField<Spell> spells_;

		[FieldOffset(Offset="0x0")]
		public const int ActivitiesFieldNumber = 6;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<MultiplayerBattleActivity> _repeated_activities_codec;

		[FieldOffset(Offset="0x40")]
		private readonly RepeatedField<MultiplayerBattleActivity> activities_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerLevelFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ulong playerLevel_;

		[FieldOffset(Offset="0x0")]
		public const int EmotesFieldNumber = 8;

		[FieldOffset(Offset="0x20")]
		private readonly static FieldCodec<ulong> _repeated_emotes_codec;

		[FieldOffset(Offset="0x50")]
		private readonly RepeatedField<ulong> emotes_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092538", Offset="0x1092538")]
		public RepeatedField<MultiplayerBattleActivity> Activities
		{
			[Address(RVA="0x1A1C3A8", Offset="0x1A1C3A8", VA="0x1A1C3A8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10924C8", Offset="0x10924C8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A1BFDC", Offset="0x1A1BFDC", VA="0x1A1BFDC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092558", Offset="0x1092558")]
		public RepeatedField<ulong> Emotes
		{
			[Address(RVA="0x1A1C3C0", Offset="0x1A1C3C0", VA="0x1A1C3C0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10924E8", Offset="0x10924E8")]
		public string GamedataVersion
		{
			[Address(RVA="0x1A1C298", Offset="0x1A1C298", VA="0x1A1C298")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1C2A0", Offset="0x1A1C2A0", VA="0x1A1C2A0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10924B8", Offset="0x10924B8")]
		public static MessageParser<MatchMakerPlayerInfo> Parser
		{
			[Address(RVA="0x1A1BF74", Offset="0x1A1BF74", VA="0x1A1BF74")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10924D8", Offset="0x10924D8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A1C0CC", Offset="0x1A1C0CC", VA="0x1A1C0CC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10924F8", Offset="0x10924F8")]
		public string PlayerId
		{
			[Address(RVA="0x1A1C310", Offset="0x1A1C310", VA="0x1A1C310")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1C318", Offset="0x1A1C318", VA="0x1A1C318")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092548", Offset="0x1092548")]
		public ulong PlayerLevel
		{
			[Address(RVA="0x1A1C3B0", Offset="0x1A1C3B0", VA="0x1A1C3B0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A1C3B8", Offset="0x1A1C3B8", VA="0x1A1C3B8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092508", Offset="0x1092508")]
		public ulong PowerRating
		{
			[Address(RVA="0x1A1C388", Offset="0x1A1C388", VA="0x1A1C388")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A1C390", Offset="0x1A1C390", VA="0x1A1C390")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092528", Offset="0x1092528")]
		public RepeatedField<Spell> Spells
		{
			[Address(RVA="0x1A1C3A0", Offset="0x1A1C3A0", VA="0x1A1C3A0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092518", Offset="0x1092518")]
		public RepeatedField<Unit> Units
		{
			[Address(RVA="0x1A1C398", Offset="0x1A1C398", VA="0x1A1C398")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A1D054", Offset="0x1A1D054", VA="0x1A1D054")]
		static MatchMakerPlayerInfo()
		{
		}

		[Address(RVA="0x1A19C28", Offset="0x1A19C28", VA="0x1A19C28")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10769FC", Offset="0x10769FC")]
		public MatchMakerPlayerInfo()
		{
		}

		[Address(RVA="0x1A1C128", Offset="0x1A1C128", VA="0x1A1C128")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076A0C", Offset="0x1076A0C")]
		public MatchMakerPlayerInfo(MatchMakerPlayerInfo other)
		{
		}

		[Address(RVA="0x1A1CAEC", Offset="0x1A1CAEC", VA="0x1A1CAEC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076A7C", Offset="0x1076A7C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A194F8", Offset="0x1A194F8", VA="0x1A194F8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076A1C", Offset="0x1076A1C")]
		public MatchMakerPlayerInfo Clone()
		{
			return null;
		}

		[Address(RVA="0x1A1C3C8", Offset="0x1A1C3C8", VA="0x1A1C3C8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076A2C", Offset="0x1076A2C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1C43C", Offset="0x1A1C43C", VA="0x1A1C43C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076A3C", Offset="0x1076A3C")]
		public bool Equals(MatchMakerPlayerInfo other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1C5C4", Offset="0x1A1C5C4", VA="0x1A1C5C4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076A4C", Offset="0x1076A4C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A19D20", Offset="0x1A19D20", VA="0x1A19D20", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076A8C", Offset="0x1076A8C")]
		public void MergeFrom(MatchMakerPlayerInfo other)
		{
		}

		[Address(RVA="0x1A1CD9C", Offset="0x1A1CD9C", VA="0x1A1CD9C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076A9C", Offset="0x1076A9C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A1C764", Offset="0x1A1C764", VA="0x1A1C764", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076A5C", Offset="0x1076A5C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A1C7CC", Offset="0x1A1C7CC", VA="0x1A1C7CC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076A6C", Offset="0x1076A6C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F0A8", Offset="0x104F0A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MatchMakerPlayerInfo.<>c <>9;

			[Address(RVA="0x1A1D28C", Offset="0x1A1D28C", VA="0x1A1D28C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A1D2F0", Offset="0x1A1D2F0", VA="0x1A1D2F0")]
			public <>c()
			{
			}

			[Address(RVA="0x1A1D2F8", Offset="0x1A1D2F8", VA="0x1A1D2F8")]
			internal MatchMakerPlayerInfo <.cctor>b__60_0()
			{
				return null;
			}
		}
	}
}