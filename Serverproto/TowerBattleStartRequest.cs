using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerBattleStartRequest : IMessage<TowerBattleStartRequest>, IMessage, IEquatable<TowerBattleStartRequest>, IDeepCloneable<TowerBattleStartRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerBattleStartRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_units_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ulong> units_;

		[FieldOffset(Offset="0x0")]
		public const int SpellsFieldNumber = 2;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_spells_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ulong> spells_;

		[FieldOffset(Offset="0x0")]
		public const int SquadSaveFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private BattleSquadSaveInfo squadSave_;

		[FieldOffset(Offset="0x0")]
		public const int LeaderUnitFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong leaderUnit_;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private TowerIdentifier id_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092EA0", Offset="0x1092EA0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B6FC00", Offset="0x1B6FC00", VA="0x1B6FC00")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092F00", Offset="0x1092F00")]
		public TowerIdentifier Id
		{
			[Address(RVA="0x1B6FED0", Offset="0x1B6FED0", VA="0x1B6FED0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B6FED8", Offset="0x1B6FED8", VA="0x1B6FED8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092EF0", Offset="0x1092EF0")]
		public ulong LeaderUnit
		{
			[Address(RVA="0x1B6FF50", Offset="0x1B6FF50", VA="0x1B6FF50")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B6FF58", Offset="0x1B6FF58", VA="0x1B6FF58")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092E90", Offset="0x1092E90")]
		public static MessageParser<TowerBattleStartRequest> Parser
		{
			[Address(RVA="0x1B6FB98", Offset="0x1B6FB98", VA="0x1B6FB98")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092EB0", Offset="0x1092EB0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B6FCF0", Offset="0x1B6FCF0", VA="0x1B6FCF0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092ED0", Offset="0x1092ED0")]
		public RepeatedField<ulong> Spells
		{
			[Address(RVA="0x1B6FF48", Offset="0x1B6FF48", VA="0x1B6FF48")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092EE0", Offset="0x1092EE0")]
		public BattleSquadSaveInfo SquadSave
		{
			[Address(RVA="0x1B6FEC0", Offset="0x1B6FEC0", VA="0x1B6FEC0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B6FEC8", Offset="0x1B6FEC8", VA="0x1B6FEC8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092EC0", Offset="0x1092EC0")]
		public RepeatedField<ulong> Units
		{
			[Address(RVA="0x1B6FF40", Offset="0x1B6FF40", VA="0x1B6FF40")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B70948", Offset="0x1B70948", VA="0x1B70948")]
		static TowerBattleStartRequest()
		{
		}

		[Address(RVA="0x1B6FD4C", Offset="0x1B6FD4C", VA="0x1B6FD4C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077C8C", Offset="0x1077C8C")]
		public TowerBattleStartRequest()
		{
		}

		[Address(RVA="0x1B6FDDC", Offset="0x1B6FDDC", VA="0x1B6FDDC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077C9C", Offset="0x1077C9C")]
		public TowerBattleStartRequest(TowerBattleStartRequest other)
		{
		}

		[Address(RVA="0x1B7043C", Offset="0x1B7043C", VA="0x1B7043C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077D0C", Offset="0x1077D0C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B6FEE0", Offset="0x1B6FEE0", VA="0x1B6FEE0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077CAC", Offset="0x1077CAC")]
		public TowerBattleStartRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B6FF60", Offset="0x1B6FF60", VA="0x1B6FF60", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077CBC", Offset="0x1077CBC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6FFD4", Offset="0x1B6FFD4", VA="0x1B6FFD4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077CCC", Offset="0x1077CCC")]
		public bool Equals(TowerBattleStartRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B700F0", Offset="0x1B700F0", VA="0x1B700F0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077CDC", Offset="0x1077CDC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B705E0", Offset="0x1B705E0", VA="0x1B705E0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077D1C", Offset="0x1077D1C")]
		public void MergeFrom(TowerBattleStartRequest other)
		{
		}

		[Address(RVA="0x1B70744", Offset="0x1B70744", VA="0x1B70744", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077D2C", Offset="0x1077D2C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B701CC", Offset="0x1B701CC", VA="0x1B701CC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077CEC", Offset="0x1077CEC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B70234", Offset="0x1B70234", VA="0x1B70234", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077CFC", Offset="0x1077CFC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F258", Offset="0x104F258")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerBattleStartRequest.<>c <>9;

			[Address(RVA="0x1B70A50", Offset="0x1B70A50", VA="0x1B70A50")]
			static <>c()
			{
			}

			[Address(RVA="0x1B70AB4", Offset="0x1B70AB4", VA="0x1B70AB4")]
			public <>c()
			{
			}

			[Address(RVA="0x1B70ABC", Offset="0x1B70ABC", VA="0x1B70ABC")]
			internal TowerBattleStartRequest <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}