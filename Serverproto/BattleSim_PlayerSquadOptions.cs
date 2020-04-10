using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleSim_PlayerSquadOptions : IMessage<BattleSim_PlayerSquadOptions>, IMessage, IEquatable<BattleSim_PlayerSquadOptions>, IDeepCloneable<BattleSim_PlayerSquadOptions>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleSim_PlayerSquadOptions> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnitIdsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_unitIds_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<ulong> unitIds_;

		[FieldOffset(Offset="0x0")]
		public const int SpellIdsFieldNumber = 2;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_spellIds_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ulong> spellIds_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093B80", Offset="0x1093B80")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD23DC", Offset="0x1DD23DC", VA="0x1DD23DC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093B70", Offset="0x1093B70")]
		public static MessageParser<BattleSim_PlayerSquadOptions> Parser
		{
			[Address(RVA="0x1DCF234", Offset="0x1DCF234", VA="0x1DCF234")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093B90", Offset="0x1093B90")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD24C8", Offset="0x1DD24C8", VA="0x1DD24C8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093BB0", Offset="0x1093BB0")]
		public RepeatedField<ulong> SpellIds
		{
			[Address(RVA="0x1DD26D4", Offset="0x1DD26D4", VA="0x1DD26D4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093BA0", Offset="0x1093BA0")]
		public RepeatedField<ulong> UnitIds
		{
			[Address(RVA="0x1DD26CC", Offset="0x1DD26CC", VA="0x1DD26CC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1DD2D08", Offset="0x1DD2D08", VA="0x1DD2D08")]
		static BattleSim_PlayerSquadOptions()
		{
		}

		[Address(RVA="0x1DD2524", Offset="0x1DD2524", VA="0x1DD2524")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078FCC", Offset="0x1078FCC")]
		public BattleSim_PlayerSquadOptions()
		{
		}

		[Address(RVA="0x1DD25B4", Offset="0x1DD25B4", VA="0x1DD25B4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078FDC", Offset="0x1078FDC")]
		public BattleSim_PlayerSquadOptions(BattleSim_PlayerSquadOptions other)
		{
		}

		[Address(RVA="0x1DD2A28", Offset="0x1DD2A28", VA="0x1DD2A28", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107904C", Offset="0x107904C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD266C", Offset="0x1DD266C", VA="0x1DD266C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078FEC", Offset="0x1078FEC")]
		public BattleSim_PlayerSquadOptions Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD26DC", Offset="0x1DD26DC", VA="0x1DD26DC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078FFC", Offset="0x1078FFC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD2750", Offset="0x1DD2750", VA="0x1DD2750", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107900C", Offset="0x107900C")]
		public bool Equals(BattleSim_PlayerSquadOptions other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD2834", Offset="0x1DD2834", VA="0x1DD2834", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107901C", Offset="0x107901C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD2B1C", Offset="0x1DD2B1C", VA="0x1DD2B1C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107905C", Offset="0x107905C")]
		public void MergeFrom(BattleSim_PlayerSquadOptions other)
		{
		}

		[Address(RVA="0x1DD2BD8", Offset="0x1DD2BD8", VA="0x1DD2BD8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107906C", Offset="0x107906C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD28C0", Offset="0x1DD28C0", VA="0x1DD28C0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107902C", Offset="0x107902C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD2928", Offset="0x1DD2928", VA="0x1DD2928", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107903C", Offset="0x107903C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F458", Offset="0x104F458")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleSim_PlayerSquadOptions.<>c <>9;

			[Address(RVA="0x1DD2E10", Offset="0x1DD2E10", VA="0x1DD2E10")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD2E74", Offset="0x1DD2E74", VA="0x1DD2E74")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD2E7C", Offset="0x1DD2E7C", VA="0x1DD2E7C")]
			internal BattleSim_PlayerSquadOptions <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}