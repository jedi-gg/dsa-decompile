using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarSetDefenseRequest : IMessage<ClubWarSetDefenseRequest>, IMessage, IEquatable<ClubWarSetDefenseRequest>, IDeepCloneable<ClubWarSetDefenseRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarSetDefenseRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SquadIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string squadId_;

		[FieldOffset(Offset="0x0")]
		public const int GdNodeIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string gdNodeId_;

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

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096130", Offset="0x1096130")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EE3894", Offset="0x1EE3894", VA="0x1EE3894")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096160", Offset="0x1096160")]
		public string GdNodeId
		{
			[Address(RVA="0x1EE3C54", Offset="0x1EE3C54", VA="0x1EE3C54")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EE3C5C", Offset="0x1EE3C5C", VA="0x1EE3C5C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096190", Offset="0x1096190")]
		public ulong LeaderUnitId
		{
			[Address(RVA="0x1EE3CDC", Offset="0x1EE3CDC", VA="0x1EE3CDC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EE3CE4", Offset="0x1EE3CE4", VA="0x1EE3CE4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096120", Offset="0x1096120")]
		public static MessageParser<ClubWarSetDefenseRequest> Parser
		{
			[Address(RVA="0x1EE382C", Offset="0x1EE382C", VA="0x1EE382C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096140", Offset="0x1096140")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EE3984", Offset="0x1EE3984", VA="0x1EE3984", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096180", Offset="0x1096180")]
		public RepeatedField<ulong> SpellIds
		{
			[Address(RVA="0x1EE3CD4", Offset="0x1EE3CD4", VA="0x1EE3CD4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096150", Offset="0x1096150")]
		public string SquadId
		{
			[Address(RVA="0x1EE3BDC", Offset="0x1EE3BDC", VA="0x1EE3BDC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EE3BE4", Offset="0x1EE3BE4", VA="0x1EE3BE4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096170", Offset="0x1096170")]
		public RepeatedField<ulong> UnitIds
		{
			[Address(RVA="0x1EE3CCC", Offset="0x1EE3CCC", VA="0x1EE3CCC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EE4728", Offset="0x1EE4728", VA="0x1EE4728")]
		static ClubWarSetDefenseRequest()
		{
		}

		[Address(RVA="0x1EE39E0", Offset="0x1EE39E0", VA="0x1EE39E0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DF3C", Offset="0x107DF3C")]
		public ClubWarSetDefenseRequest()
		{
		}

		[Address(RVA="0x1EE3A80", Offset="0x1EE3A80", VA="0x1EE3A80")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DF4C", Offset="0x107DF4C")]
		public ClubWarSetDefenseRequest(ClubWarSetDefenseRequest other)
		{
		}

		[Address(RVA="0x1EE4254", Offset="0x1EE4254", VA="0x1EE4254", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DFBC", Offset="0x107DFBC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EE3B7C", Offset="0x1EE3B7C", VA="0x1EE3B7C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DF5C", Offset="0x107DF5C")]
		public ClubWarSetDefenseRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1EE3CEC", Offset="0x1EE3CEC", VA="0x1EE3CEC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DF6C", Offset="0x107DF6C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE3D60", Offset="0x1EE3D60", VA="0x1EE3D60", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DF7C", Offset="0x107DF7C")]
		public bool Equals(ClubWarSetDefenseRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1EE3E7C", Offset="0x1EE3E7C", VA="0x1EE3E7C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DF8C", Offset="0x107DF8C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EE4434", Offset="0x1EE4434", VA="0x1EE4434", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DFCC", Offset="0x107DFCC")]
		public void MergeFrom(ClubWarSetDefenseRequest other)
		{
		}

		[Address(RVA="0x1EE4554", Offset="0x1EE4554", VA="0x1EE4554", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DFDC", Offset="0x107DFDC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EE3FB4", Offset="0x1EE3FB4", VA="0x1EE3FB4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DF9C", Offset="0x107DF9C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EE401C", Offset="0x1EE401C", VA="0x1EE401C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107DFAC", Offset="0x107DFAC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FB98", Offset="0x104FB98")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarSetDefenseRequest.<>c <>9;

			[Address(RVA="0x1EE4830", Offset="0x1EE4830", VA="0x1EE4830")]
			static <>c()
			{
			}

			[Address(RVA="0x1EE4894", Offset="0x1EE4894", VA="0x1EE4894")]
			public <>c()
			{
			}

			[Address(RVA="0x1EE489C", Offset="0x1EE489C", VA="0x1EE489C")]
			internal ClubWarSetDefenseRequest <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}