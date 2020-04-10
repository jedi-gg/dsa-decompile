using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class EventBattleStartRequest : IMessage<EventBattleStartRequest>, IMessage, IEquatable<EventBattleStartRequest>, IDeepCloneable<EventBattleStartRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<EventBattleStartRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int EventIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private EventIdentifier eventId_;

		[FieldOffset(Offset="0x0")]
		public const int UnitsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_units_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ulong> units_;

		[FieldOffset(Offset="0x0")]
		public const int SpellsFieldNumber = 3;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_spells_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<ulong> spells_;

		[FieldOffset(Offset="0x0")]
		public const int SquadSaveFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private BattleSquadSaveInfo squadSave_;

		[FieldOffset(Offset="0x0")]
		public const int LeaderUnitFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong leaderUnit_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092BF0", Offset="0x1092BF0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FCB950", Offset="0x1FCB950", VA="0x1FCB950")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092C10", Offset="0x1092C10")]
		public EventIdentifier EventId
		{
			[Address(RVA="0x1FCBC2C", Offset="0x1FCBC2C", VA="0x1FCBC2C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FCBC94", Offset="0x1FCBC94", VA="0x1FCBC94")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092C50", Offset="0x1092C50")]
		public ulong LeaderUnit
		{
			[Address(RVA="0x1FCBD1C", Offset="0x1FCBD1C", VA="0x1FCBD1C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FCBD24", Offset="0x1FCBD24", VA="0x1FCBD24")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092BE0", Offset="0x1092BE0")]
		public static MessageParser<EventBattleStartRequest> Parser
		{
			[Address(RVA="0x1FCB8E8", Offset="0x1FCB8E8", VA="0x1FCB8E8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092C00", Offset="0x1092C00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FCBA40", Offset="0x1FCBA40", VA="0x1FCBA40", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092C30", Offset="0x1092C30")]
		public RepeatedField<ulong> Spells
		{
			[Address(RVA="0x1FCBD14", Offset="0x1FCBD14", VA="0x1FCBD14")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092C40", Offset="0x1092C40")]
		public BattleSquadSaveInfo SquadSave
		{
			[Address(RVA="0x1FCBC9C", Offset="0x1FCBC9C", VA="0x1FCBC9C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FCBCA4", Offset="0x1FCBCA4", VA="0x1FCBCA4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092C20", Offset="0x1092C20")]
		public RepeatedField<ulong> Units
		{
			[Address(RVA="0x1FCBD0C", Offset="0x1FCBD0C", VA="0x1FCBD0C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FCC76C", Offset="0x1FCC76C", VA="0x1FCC76C")]
		static EventBattleStartRequest()
		{
		}

		[Address(RVA="0x1FCBA9C", Offset="0x1FCBA9C", VA="0x1FCBA9C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107770C", Offset="0x107770C")]
		public EventBattleStartRequest()
		{
		}

		[Address(RVA="0x1FCBB2C", Offset="0x1FCBB2C", VA="0x1FCBB2C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107771C", Offset="0x107771C")]
		public EventBattleStartRequest(EventBattleStartRequest other)
		{
		}

		[Address(RVA="0x1FCC210", Offset="0x1FCC210", VA="0x1FCC210", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107778C", Offset="0x107778C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FCBCAC", Offset="0x1FCBCAC", VA="0x1FCBCAC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107772C", Offset="0x107772C")]
		public EventBattleStartRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1FCBD2C", Offset="0x1FCBD2C", VA="0x1FCBD2C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107773C", Offset="0x107773C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCBDA0", Offset="0x1FCBDA0", VA="0x1FCBDA0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107774C", Offset="0x107774C")]
		public bool Equals(EventBattleStartRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1FCBEBC", Offset="0x1FCBEBC", VA="0x1FCBEBC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107775C", Offset="0x107775C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FCC3B8", Offset="0x1FCC3B8", VA="0x1FCC3B8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107779C", Offset="0x107779C")]
		public void MergeFrom(EventBattleStartRequest other)
		{
		}

		[Address(RVA="0x1FCC570", Offset="0x1FCC570", VA="0x1FCC570", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10777AC", Offset="0x10777AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FCBFA0", Offset="0x1FCBFA0", VA="0x1FCBFA0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107776C", Offset="0x107776C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FCC008", Offset="0x1FCC008", VA="0x1FCC008", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107777C", Offset="0x107777C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F1D8", Offset="0x104F1D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static EventBattleStartRequest.<>c <>9;

			[Address(RVA="0x1FCC874", Offset="0x1FCC874", VA="0x1FCC874")]
			static <>c()
			{
			}

			[Address(RVA="0x1FCC8D8", Offset="0x1FCC8D8", VA="0x1FCC8D8")]
			public <>c()
			{
			}

			[Address(RVA="0x1FCC8E0", Offset="0x1FCC8E0", VA="0x1FCC8E0")]
			internal EventBattleStartRequest <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}