using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerSquadSelection : IMessage<PlayerSquadSelection>, IMessage, IEquatable<PlayerSquadSelection>, IDeepCloneable<PlayerSquadSelection>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerSquadSelection> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int GameModeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private int gameMode_;

		[FieldOffset(Offset="0x0")]
		public const int SlotFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong slot_;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdsFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_unitIds_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<ulong> unitIds_;

		[FieldOffset(Offset="0x0")]
		public const int SpellIdsFieldNumber = 4;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_spellIds_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<ulong> spellIds_;

		[FieldOffset(Offset="0x0")]
		public const int LeaderUnitIdFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong leaderUnitId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A2A0", Offset="0x109A2A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B10910", Offset="0x1B10910", VA="0x1B10910")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A2C0", Offset="0x109A2C0")]
		public int GameMode
		{
			[Address(RVA="0x1B10C44", Offset="0x1B10C44", VA="0x1B10C44")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1B10C4C", Offset="0x1B10C4C", VA="0x1B10C4C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A300", Offset="0x109A300")]
		public ulong LeaderUnitId
		{
			[Address(RVA="0x1B10C74", Offset="0x1B10C74", VA="0x1B10C74")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B10C7C", Offset="0x1B10C7C", VA="0x1B10C7C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A290", Offset="0x109A290")]
		public static MessageParser<PlayerSquadSelection> Parser
		{
			[Address(RVA="0x1B0EB34", Offset="0x1B0EB34", VA="0x1B0EB34")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A2B0", Offset="0x109A2B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B109FC", Offset="0x1B109FC", VA="0x1B109FC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A2D0", Offset="0x109A2D0")]
		public ulong Slot
		{
			[Address(RVA="0x1B10C54", Offset="0x1B10C54", VA="0x1B10C54")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B10C5C", Offset="0x1B10C5C", VA="0x1B10C5C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A2F0", Offset="0x109A2F0")]
		public RepeatedField<ulong> SpellIds
		{
			[Address(RVA="0x1B10C6C", Offset="0x1B10C6C", VA="0x1B10C6C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A2E0", Offset="0x109A2E0")]
		public RepeatedField<ulong> UnitIds
		{
			[Address(RVA="0x1B10C64", Offset="0x1B10C64", VA="0x1B10C64")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B115B8", Offset="0x1B115B8", VA="0x1B115B8")]
		static PlayerSquadSelection()
		{
		}

		[Address(RVA="0x1B10A58", Offset="0x1B10A58", VA="0x1B10A58")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108406C", Offset="0x108406C")]
		public PlayerSquadSelection()
		{
		}

		[Address(RVA="0x1B10AE8", Offset="0x1B10AE8", VA="0x1B10AE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108407C", Offset="0x108407C")]
		public PlayerSquadSelection(PlayerSquadSelection other)
		{
		}

		[Address(RVA="0x1B1116C", Offset="0x1B1116C", VA="0x1B1116C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10840EC", Offset="0x10840EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B10BE4", Offset="0x1B10BE4", VA="0x1B10BE4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108408C", Offset="0x108408C")]
		public PlayerSquadSelection Clone()
		{
			return null;
		}

		[Address(RVA="0x1B10C84", Offset="0x1B10C84", VA="0x1B10C84", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108409C", Offset="0x108409C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B10CF8", Offset="0x1B10CF8", VA="0x1B10CF8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10840AC", Offset="0x10840AC")]
		public bool Equals(PlayerSquadSelection other)
		{
			return new bool();
		}

		[Address(RVA="0x1B10E0C", Offset="0x1B10E0C", VA="0x1B10E0C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10840BC", Offset="0x10840BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B11314", Offset="0x1B11314", VA="0x1B11314", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10840FC", Offset="0x10840FC")]
		public void MergeFrom(PlayerSquadSelection other)
		{
		}

		[Address(RVA="0x1B113F4", Offset="0x1B113F4", VA="0x1B113F4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108410C", Offset="0x108410C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B10EFC", Offset="0x1B10EFC", VA="0x1B10EFC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10840CC", Offset="0x10840CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B10F64", Offset="0x1B10F64", VA="0x1B10F64", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10840DC", Offset="0x10840DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050468", Offset="0x1050468")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerSquadSelection.<>c <>9;

			[Address(RVA="0x1B116C0", Offset="0x1B116C0", VA="0x1B116C0")]
			static <>c()
			{
			}

			[Address(RVA="0x1B11724", Offset="0x1B11724", VA="0x1B11724")]
			public <>c()
			{
			}

			[Address(RVA="0x1B1172C", Offset="0x1B1172C", VA="0x1B1172C")]
			internal PlayerSquadSelection <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}