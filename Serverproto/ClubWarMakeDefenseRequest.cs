using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarMakeDefenseRequest : IMessage<ClubWarMakeDefenseRequest>, IMessage, IEquatable<ClubWarMakeDefenseRequest>, IDeepCloneable<ClubWarMakeDefenseRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarMakeDefenseRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SquadIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string squadId_;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_unitIds_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ulong> unitIds_;

		[FieldOffset(Offset="0x0")]
		public const int SpellIdsFieldNumber = 3;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_spellIds_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<ulong> spellIds_;

		[FieldOffset(Offset="0x0")]
		public const int LeaderUnitIdFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong leaderUnitId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096020", Offset="0x1096020")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B231B4", Offset="0x1B231B4", VA="0x1B231B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096070", Offset="0x1096070")]
		public ulong LeaderUnitId
		{
			[Address(RVA="0x1B23568", Offset="0x1B23568", VA="0x1B23568")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B23570", Offset="0x1B23570", VA="0x1B23570")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096010", Offset="0x1096010")]
		public static MessageParser<ClubWarMakeDefenseRequest> Parser
		{
			[Address(RVA="0x1B2314C", Offset="0x1B2314C", VA="0x1B2314C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096030", Offset="0x1096030")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B232A4", Offset="0x1B232A4", VA="0x1B232A4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096060", Offset="0x1096060")]
		public RepeatedField<ulong> SpellIds
		{
			[Address(RVA="0x1B23560", Offset="0x1B23560", VA="0x1B23560")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096040", Offset="0x1096040")]
		public string SquadId
		{
			[Address(RVA="0x1B234E0", Offset="0x1B234E0", VA="0x1B234E0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B234E8", Offset="0x1B234E8", VA="0x1B234E8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096050", Offset="0x1096050")]
		public RepeatedField<ulong> UnitIds
		{
			[Address(RVA="0x1B23558", Offset="0x1B23558", VA="0x1B23558")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B23E28", Offset="0x1B23E28", VA="0x1B23E28")]
		static ClubWarMakeDefenseRequest()
		{
		}

		[Address(RVA="0x1B23300", Offset="0x1B23300", VA="0x1B23300")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DC7C", Offset="0x107DC7C")]
		public ClubWarMakeDefenseRequest()
		{
		}

		[Address(RVA="0x1B233A0", Offset="0x1B233A0", VA="0x1B233A0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DC8C", Offset="0x107DC8C")]
		public ClubWarMakeDefenseRequest(ClubWarMakeDefenseRequest other)
		{
		}

		[Address(RVA="0x1B23A18", Offset="0x1B23A18", VA="0x1B23A18", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DCFC", Offset="0x107DCFC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B23480", Offset="0x1B23480", VA="0x1B23480", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DC9C", Offset="0x107DC9C")]
		public ClubWarMakeDefenseRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B23578", Offset="0x1B23578", VA="0x1B23578", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DCAC", Offset="0x107DCAC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B235EC", Offset="0x1B235EC", VA="0x1B235EC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DCBC", Offset="0x107DCBC")]
		public bool Equals(ClubWarMakeDefenseRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B236F4", Offset="0x1B236F4", VA="0x1B236F4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DCCC", Offset="0x107DCCC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B23BA0", Offset="0x1B23BA0", VA="0x1B23BA0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DD0C", Offset="0x107DD0C")]
		public void MergeFrom(ClubWarMakeDefenseRequest other)
		{
		}

		[Address(RVA="0x1B23C94", Offset="0x1B23C94", VA="0x1B23C94", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DD1C", Offset="0x107DD1C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B237E8", Offset="0x1B237E8", VA="0x1B237E8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DCDC", Offset="0x107DCDC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B23850", Offset="0x1B23850", VA="0x1B23850", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DCEC", Offset="0x107DCEC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FB58", Offset="0x104FB58")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarMakeDefenseRequest.<>c <>9;

			[Address(RVA="0x1B23F30", Offset="0x1B23F30", VA="0x1B23F30")]
			static <>c()
			{
			}

			[Address(RVA="0x1B23F94", Offset="0x1B23F94", VA="0x1B23F94")]
			public <>c()
			{
			}

			[Address(RVA="0x1B23F9C", Offset="0x1B23F9C", VA="0x1B23F9C")]
			internal ClubWarMakeDefenseRequest <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}