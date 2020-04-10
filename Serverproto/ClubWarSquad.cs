using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarSquad : IMessage<ClubWarSquad>, IMessage, IEquatable<ClubWarSquad>, IDeepCloneable<ClubWarSquad>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarSquad> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int ProfileFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ClubWarPlayerProfileSimple profile_;

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

		[FieldOffset(Offset="0x0")]
		public const int RebuildingDefenseSquadFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private bool rebuildingDefenseSquad_;

		[FieldOffset(Offset="0x0")]
		public const int GdNodeIdFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private string gdNodeId_;

		[FieldOffset(Offset="0x0")]
		public const int DeadFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private bool dead_;

		[FieldOffset(Offset="0x0")]
		public const int PowerRatingFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private ulong powerRating_;

		public bool AssignedToNode
		{
			[Address(RVA="0x1EE71C4", Offset="0x1EE71C4", VA="0x1EE71C4")]
			get
			{
				return new bool();
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095D60", Offset="0x1095D60")]
		public bool Dead
		{
			[Address(RVA="0x1EE6328", Offset="0x1EE6328", VA="0x1EE6328")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1EE6330", Offset="0x1EE6330", VA="0x1EE6330")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095CD0", Offset="0x1095CD0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EE5E74", Offset="0x1EE5E74", VA="0x1EE5E74")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095D50", Offset="0x1095D50")]
		public string GdNodeId
		{
			[Address(RVA="0x1EE62B0", Offset="0x1EE62B0", VA="0x1EE62B0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EE62B8", Offset="0x1EE62B8", VA="0x1EE62B8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095CF0", Offset="0x1095CF0")]
		public string Id
		{
			[Address(RVA="0x1EE6204", Offset="0x1EE6204", VA="0x1EE6204")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EE620C", Offset="0x1EE620C", VA="0x1EE620C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095D30", Offset="0x1095D30")]
		public ulong LeaderUnitId
		{
			[Address(RVA="0x1EE628C", Offset="0x1EE628C", VA="0x1EE628C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EE6294", Offset="0x1EE6294", VA="0x1EE6294")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095CC0", Offset="0x1095CC0")]
		public static MessageParser<ClubWarSquad> Parser
		{
			[Address(RVA="0x1EE5E0C", Offset="0x1EE5E0C", VA="0x1EE5E0C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095CE0", Offset="0x1095CE0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EE5F64", Offset="0x1EE5F64", VA="0x1EE5F64", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095D70", Offset="0x1095D70")]
		public ulong PowerRating
		{
			[Address(RVA="0x1EE633C", Offset="0x1EE633C", VA="0x1EE633C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EE6344", Offset="0x1EE6344", VA="0x1EE6344")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095D00", Offset="0x1095D00")]
		public ClubWarPlayerProfileSimple Profile
		{
			[Address(RVA="0x1EE6194", Offset="0x1EE6194", VA="0x1EE6194")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EE619C", Offset="0x1EE619C", VA="0x1EE619C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095D40", Offset="0x1095D40")]
		public bool RebuildingDefenseSquad
		{
			[Address(RVA="0x1EE629C", Offset="0x1EE629C", VA="0x1EE629C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1EE62A4", Offset="0x1EE62A4", VA="0x1EE62A4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095D20", Offset="0x1095D20")]
		public RepeatedField<Spell> Spells
		{
			[Address(RVA="0x1EE6284", Offset="0x1EE6284", VA="0x1EE6284")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095D10", Offset="0x1095D10")]
		public RepeatedField<Unit> Units
		{
			[Address(RVA="0x1EE627C", Offset="0x1EE627C", VA="0x1EE627C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EE71E8", Offset="0x1EE71E8", VA="0x1EE71E8")]
		static ClubWarSquad()
		{
		}

		[Address(RVA="0x1EE5FC0", Offset="0x1EE5FC0", VA="0x1EE5FC0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D4EC", Offset="0x107D4EC")]
		public ClubWarSquad()
		{
		}

		[Address(RVA="0x1EE6078", Offset="0x1EE6078", VA="0x1EE6078")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D4FC", Offset="0x107D4FC")]
		public ClubWarSquad(ClubWarSquad other)
		{
		}

		[Address(RVA="0x1EE6B00", Offset="0x1EE6B00", VA="0x1EE6B00", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D56C", Offset="0x107D56C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EE61A4", Offset="0x1EE61A4", VA="0x1EE61A4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D50C", Offset="0x107D50C")]
		public ClubWarSquad Clone()
		{
			return null;
		}

		[Address(RVA="0x1EE634C", Offset="0x1EE634C", VA="0x1EE634C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D51C", Offset="0x107D51C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE63C0", Offset="0x1EE63C0", VA="0x1EE63C0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D52C", Offset="0x107D52C")]
		public bool Equals(ClubWarSquad other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE653C", Offset="0x1EE653C", VA="0x1EE653C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D53C", Offset="0x107D53C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EE6D80", Offset="0x1EE6D80", VA="0x1EE6D80", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D57C", Offset="0x107D57C")]
		public void MergeFrom(ClubWarSquad other)
		{
		}

		[Address(RVA="0x1EE6F14", Offset="0x1EE6F14", VA="0x1EE6F14", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D58C", Offset="0x107D58C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EE66F0", Offset="0x1EE66F0", VA="0x1EE66F0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D54C", Offset="0x107D54C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EE6758", Offset="0x1EE6758", VA="0x1EE6758", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D55C", Offset="0x107D55C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FAA8", Offset="0x104FAA8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarSquad.<>c <>9;

			[Address(RVA="0x1EE7358", Offset="0x1EE7358", VA="0x1EE7358")]
			static <>c()
			{
			}

			[Address(RVA="0x1EE73BC", Offset="0x1EE73BC", VA="0x1EE73BC")]
			public <>c()
			{
			}

			[Address(RVA="0x1EE73C4", Offset="0x1EE73C4", VA="0x1EE73C4")]
			internal ClubWarSquad <.cctor>b__67_0()
			{
				return null;
			}
		}
	}
}