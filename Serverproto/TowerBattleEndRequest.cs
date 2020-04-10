using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class TowerBattleEndRequest : IMessage<TowerBattleEndRequest>, IMessage, IEquatable<TowerBattleEndRequest>, IDeepCloneable<TowerBattleEndRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<TowerBattleEndRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int WinFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private bool win_;

		[FieldOffset(Offset="0x0")]
		public const int UnitsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<UnitBattleResult> _repeated_units_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<UnitBattleResult> units_;

		[FieldOffset(Offset="0x0")]
		public const int ActivityResultsFieldNumber = 3;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<BattleActivityResult> _repeated_activityResults_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<BattleActivityResult> activityResults_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093010", Offset="0x1093010")]
		public RepeatedField<BattleActivityResult> ActivityResults
		{
			[Address(RVA="0x1B6E998", Offset="0x1B6E998", VA="0x1B6E998")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092FD0", Offset="0x1092FD0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B6E658", Offset="0x1B6E658", VA="0x1B6E658")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092FC0", Offset="0x1092FC0")]
		public static MessageParser<TowerBattleEndRequest> Parser
		{
			[Address(RVA="0x1B6E5F0", Offset="0x1B6E5F0", VA="0x1B6E5F0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092FE0", Offset="0x1092FE0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B6E748", Offset="0x1B6E748", VA="0x1B6E748", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093000", Offset="0x1093000")]
		public RepeatedField<UnitBattleResult> Units
		{
			[Address(RVA="0x1B6E990", Offset="0x1B6E990", VA="0x1B6E990")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092FF0", Offset="0x1092FF0")]
		public bool Win
		{
			[Address(RVA="0x1B6E97C", Offset="0x1B6E97C", VA="0x1B6E97C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1B6E984", Offset="0x1B6E984", VA="0x1B6E984")]
			set
			{
			}
		}

		[Address(RVA="0x1B6F0C4", Offset="0x1B6F0C4", VA="0x1B6F0C4")]
		static TowerBattleEndRequest()
		{
		}

		[Address(RVA="0x1B6E7A4", Offset="0x1B6E7A4", VA="0x1B6E7A4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077E9C", Offset="0x1077E9C")]
		public TowerBattleEndRequest()
		{
		}

		[Address(RVA="0x1B6E83C", Offset="0x1B6E83C", VA="0x1B6E83C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077EAC", Offset="0x1077EAC")]
		public TowerBattleEndRequest(TowerBattleEndRequest other)
		{
		}

		[Address(RVA="0x1B6ED90", Offset="0x1B6ED90", VA="0x1B6ED90", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077F1C", Offset="0x1077F1C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B6E91C", Offset="0x1B6E91C", VA="0x1B6E91C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077EBC", Offset="0x1077EBC")]
		public TowerBattleEndRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B6E9A0", Offset="0x1B6E9A0", VA="0x1B6E9A0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077ECC", Offset="0x1077ECC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6EA14", Offset="0x1B6EA14", VA="0x1B6EA14", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077EDC", Offset="0x1077EDC")]
		public bool Equals(TowerBattleEndRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B6EB14", Offset="0x1B6EB14", VA="0x1B6EB14", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077EEC", Offset="0x1077EEC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B6EE94", Offset="0x1B6EE94", VA="0x1B6EE94", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077F2C", Offset="0x1077F2C")]
		public void MergeFrom(TowerBattleEndRequest other)
		{
		}

		[Address(RVA="0x1B6EF5C", Offset="0x1B6EF5C", VA="0x1B6EF5C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077F3C", Offset="0x1077F3C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B6EBC4", Offset="0x1B6EBC4", VA="0x1B6EBC4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077EFC", Offset="0x1077EFC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B6EC2C", Offset="0x1B6EC2C", VA="0x1B6EC2C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1077F0C", Offset="0x1077F0C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F288", Offset="0x104F288")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TowerBattleEndRequest.<>c <>9;

			[Address(RVA="0x1B6F234", Offset="0x1B6F234", VA="0x1B6F234")]
			static <>c()
			{
			}

			[Address(RVA="0x1B6F298", Offset="0x1B6F298", VA="0x1B6F298")]
			public <>c()
			{
			}

			[Address(RVA="0x1B6F2A0", Offset="0x1B6F2A0", VA="0x1B6F2A0")]
			internal TowerBattleEndRequest <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}