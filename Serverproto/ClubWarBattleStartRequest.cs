using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarBattleStartRequest : IMessage<ClubWarBattleStartRequest>, IMessage, IEquatable<ClubWarBattleStartRequest>, IDeepCloneable<ClubWarBattleStartRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarBattleStartRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int GdNodeIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string gdNodeId_;

		[FieldOffset(Offset="0x0")]
		public const int DefenseIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string defenseId_;

		[FieldOffset(Offset="0x0")]
		public const int UnitsFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_units_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<ulong> units_;

		[FieldOffset(Offset="0x0")]
		public const int SpellsFieldNumber = 4;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_spells_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<ulong> spells_;

		[FieldOffset(Offset="0x0")]
		public const int LeaderUnitFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong leaderUnit_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093470", Offset="0x1093470")]
		public string DefenseId
		{
			[Address(RVA="0x1B1BA90", Offset="0x1B1BA90", VA="0x1B1BA90")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B1BA98", Offset="0x1B1BA98", VA="0x1B1BA98")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093440", Offset="0x1093440")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B1B6D0", Offset="0x1B1B6D0", VA="0x1B1B6D0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093460", Offset="0x1093460")]
		public string GdNodeId
		{
			[Address(RVA="0x1B1BA18", Offset="0x1B1BA18", VA="0x1B1BA18")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B1BA20", Offset="0x1B1BA20", VA="0x1B1BA20")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10934A0", Offset="0x10934A0")]
		public ulong LeaderUnit
		{
			[Address(RVA="0x1B1BB18", Offset="0x1B1BB18", VA="0x1B1BB18")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B1BB20", Offset="0x1B1BB20", VA="0x1B1BB20")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093430", Offset="0x1093430")]
		public static MessageParser<ClubWarBattleStartRequest> Parser
		{
			[Address(RVA="0x1B1B668", Offset="0x1B1B668", VA="0x1B1B668")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093450", Offset="0x1093450")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B1B7C0", Offset="0x1B1B7C0", VA="0x1B1B7C0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093490", Offset="0x1093490")]
		public RepeatedField<ulong> Spells
		{
			[Address(RVA="0x1B1BB10", Offset="0x1B1BB10", VA="0x1B1BB10")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093480", Offset="0x1093480")]
		public RepeatedField<ulong> Units
		{
			[Address(RVA="0x1B1BB08", Offset="0x1B1BB08", VA="0x1B1BB08")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B1C564", Offset="0x1B1C564", VA="0x1B1C564")]
		static ClubWarBattleStartRequest()
		{
		}

		[Address(RVA="0x1B1B81C", Offset="0x1B1B81C", VA="0x1B1B81C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10786DC", Offset="0x10786DC")]
		public ClubWarBattleStartRequest()
		{
		}

		[Address(RVA="0x1B1B8BC", Offset="0x1B1B8BC", VA="0x1B1B8BC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10786EC", Offset="0x10786EC")]
		public ClubWarBattleStartRequest(ClubWarBattleStartRequest other)
		{
		}

		[Address(RVA="0x1B1C090", Offset="0x1B1C090", VA="0x1B1C090", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107875C", Offset="0x107875C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B1B9B8", Offset="0x1B1B9B8", VA="0x1B1B9B8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10786FC", Offset="0x10786FC")]
		public ClubWarBattleStartRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B1BB28", Offset="0x1B1BB28", VA="0x1B1BB28", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107870C", Offset="0x107870C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1BB9C", Offset="0x1B1BB9C", VA="0x1B1BB9C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107871C", Offset="0x107871C")]
		public bool Equals(ClubWarBattleStartRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1BCB8", Offset="0x1B1BCB8", VA="0x1B1BCB8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107872C", Offset="0x107872C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B1C270", Offset="0x1B1C270", VA="0x1B1C270", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107876C", Offset="0x107876C")]
		public void MergeFrom(ClubWarBattleStartRequest other)
		{
		}

		[Address(RVA="0x1B1C390", Offset="0x1B1C390", VA="0x1B1C390", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107877C", Offset="0x107877C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B1BDF0", Offset="0x1B1BDF0", VA="0x1B1BDF0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107873C", Offset="0x107873C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B1BE58", Offset="0x1B1BE58", VA="0x1B1BE58", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107874C", Offset="0x107874C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F348", Offset="0x104F348")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarBattleStartRequest.<>c <>9;

			[Address(RVA="0x1B1C66C", Offset="0x1B1C66C", VA="0x1B1C66C")]
			static <>c()
			{
			}

			[Address(RVA="0x1B1C6D0", Offset="0x1B1C6D0", VA="0x1B1C6D0")]
			public <>c()
			{
			}

			[Address(RVA="0x1B1C6D8", Offset="0x1B1C6D8", VA="0x1B1C6D8")]
			internal ClubWarBattleStartRequest <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}