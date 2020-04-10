using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothLobbyOpponent : IMessage<KothLobbyOpponent>, IMessage, IEquatable<KothLobbyOpponent>, IDeepCloneable<KothLobbyOpponent>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothLobbyOpponent> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ProfileFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private PlayerProfileSimple profile_;

		[FieldOffset(Offset="0x0")]
		public const int RankFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong rank_;

		[FieldOffset(Offset="0x0")]
		public const int UnitsFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<Unit> _repeated_units_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<Unit> units_;

		[FieldOffset(Offset="0x0")]
		public const int SpellsFieldNumber = 4;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<Spell> _repeated_spells_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<Spell> spells_;

		[FieldOffset(Offset="0x0")]
		public const int LeaderUnitIdFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong leaderUnitId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B380", Offset="0x109B380")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A9EF18", Offset="0x1A9EF18", VA="0x1A9EF18")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B3E0", Offset="0x109B3E0")]
		public ulong LeaderUnitId
		{
			[Address(RVA="0x1A9F194", Offset="0x1A9F194", VA="0x1A9F194")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A9F19C", Offset="0x1A9F19C", VA="0x1A9F19C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B370", Offset="0x109B370")]
		public static MessageParser<KothLobbyOpponent> Parser
		{
			[Address(RVA="0x1A9EEB0", Offset="0x1A9EEB0", VA="0x1A9EEB0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B390", Offset="0x109B390")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A9F008", Offset="0x1A9F008", VA="0x1A9F008", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B3A0", Offset="0x109B3A0")]
		public PlayerProfileSimple Profile
		{
			[Address(RVA="0x1A9F164", Offset="0x1A9F164", VA="0x1A9F164")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A9F16C", Offset="0x1A9F16C", VA="0x1A9F16C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B3B0", Offset="0x109B3B0")]
		public ulong Rank
		{
			[Address(RVA="0x1A9F174", Offset="0x1A9F174", VA="0x1A9F174")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A9F17C", Offset="0x1A9F17C", VA="0x1A9F17C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B3D0", Offset="0x109B3D0")]
		public RepeatedField<Spell> Spells
		{
			[Address(RVA="0x1A9F18C", Offset="0x1A9F18C", VA="0x1A9F18C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B3C0", Offset="0x109B3C0")]
		public RepeatedField<Unit> Units
		{
			[Address(RVA="0x1A9F184", Offset="0x1A9F184", VA="0x1A9F184")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A9FA20", Offset="0x1A9FA20", VA="0x1A9FA20")]
		static KothLobbyOpponent()
		{
		}

		[Address(RVA="0x1A98988", Offset="0x1A98988", VA="0x1A98988")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086A5C", Offset="0x1086A5C")]
		public KothLobbyOpponent()
		{
		}

		[Address(RVA="0x1A9F064", Offset="0x1A9F064", VA="0x1A9F064")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086A6C", Offset="0x1086A6C")]
		public KothLobbyOpponent(KothLobbyOpponent other)
		{
		}

		[Address(RVA="0x1A9F688", Offset="0x1A9F688", VA="0x1A9F688", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086ADC", Offset="0x1086ADC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A982A8", Offset="0x1A982A8", VA="0x1A982A8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086A7C", Offset="0x1086A7C")]
		public KothLobbyOpponent Clone()
		{
			return null;
		}

		[Address(RVA="0x1A9F1A4", Offset="0x1A9F1A4", VA="0x1A9F1A4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086A8C", Offset="0x1086A8C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9F218", Offset="0x1A9F218", VA="0x1A9F218", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086A9C", Offset="0x1086A9C")]
		public bool Equals(KothLobbyOpponent other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9F32C", Offset="0x1A9F32C", VA="0x1A9F32C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086AAC", Offset="0x1086AAC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A98A20", Offset="0x1A98A20", VA="0x1A98A20", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086AEC", Offset="0x1086AEC")]
		public void MergeFrom(KothLobbyOpponent other)
		{
		}

		[Address(RVA="0x1A9F838", Offset="0x1A9F838", VA="0x1A9F838", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086AFC", Offset="0x1086AFC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A9F410", Offset="0x1A9F410", VA="0x1A9F410", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086ABC", Offset="0x1086ABC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A9F478", Offset="0x1A9F478", VA="0x1A9F478", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1086ACC", Offset="0x1086ACC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050838", Offset="0x1050838")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothLobbyOpponent.<>c <>9;

			[Address(RVA="0x1A9FB90", Offset="0x1A9FB90", VA="0x1A9FB90")]
			static <>c()
			{
			}

			[Address(RVA="0x1A9FBF4", Offset="0x1A9FBF4", VA="0x1A9FBF4")]
			public <>c()
			{
			}

			[Address(RVA="0x1A9FBFC", Offset="0x1A9FBFC", VA="0x1A9FBFC")]
			internal KothLobbyOpponent <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}