using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleSim_Player : IMessage<BattleSim_Player>, IMessage, IEquatable<BattleSim_Player>, IDeepCloneable<BattleSim_Player>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleSim_Player> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerLevelFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong playerLevel_;

		[FieldOffset(Offset="0x0")]
		public const int UnitsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<BattleSim_Unit> _repeated_units_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<BattleSim_Unit> units_;

		[FieldOffset(Offset="0x0")]
		public const int SpellsFieldNumber = 3;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<BattleSim_Spell> _repeated_spells_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<BattleSim_Spell> spells_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093C90", Offset="0x1093C90")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD1728", Offset="0x1DD1728", VA="0x1DD1728")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093C80", Offset="0x1093C80")]
		public static MessageParser<BattleSim_Player> Parser
		{
			[Address(RVA="0x1DCF304", Offset="0x1DCF304", VA="0x1DCF304")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093CA0", Offset="0x1093CA0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD1814", Offset="0x1DD1814", VA="0x1DD1814", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093CB0", Offset="0x1093CB0")]
		public ulong PlayerLevel
		{
			[Address(RVA="0x1DD1A48", Offset="0x1DD1A48", VA="0x1DD1A48")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD1A50", Offset="0x1DD1A50", VA="0x1DD1A50")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093CD0", Offset="0x1093CD0")]
		public RepeatedField<BattleSim_Spell> Spells
		{
			[Address(RVA="0x1DD1A60", Offset="0x1DD1A60", VA="0x1DD1A60")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093CC0", Offset="0x1093CC0")]
		public RepeatedField<BattleSim_Unit> Units
		{
			[Address(RVA="0x1DD1A58", Offset="0x1DD1A58", VA="0x1DD1A58")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1DD21B0", Offset="0x1DD21B0", VA="0x1DD21B0")]
		static BattleSim_Player()
		{
		}

		[Address(RVA="0x1DD1870", Offset="0x1DD1870", VA="0x1DD1870")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107912C", Offset="0x107912C")]
		public BattleSim_Player()
		{
		}

		[Address(RVA="0x1DD1908", Offset="0x1DD1908", VA="0x1DD1908")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107913C", Offset="0x107913C")]
		public BattleSim_Player(BattleSim_Player other)
		{
		}

		[Address(RVA="0x1DD1E48", Offset="0x1DD1E48", VA="0x1DD1E48", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10791AC", Offset="0x10791AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD19E8", Offset="0x1DD19E8", VA="0x1DD19E8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107914C", Offset="0x107914C")]
		public BattleSim_Player Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD1A68", Offset="0x1DD1A68", VA="0x1DD1A68", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107915C", Offset="0x107915C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD1ADC", Offset="0x1DD1ADC", VA="0x1DD1ADC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107916C", Offset="0x107916C")]
		public bool Equals(BattleSim_Player other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD1BCC", Offset="0x1DD1BCC", VA="0x1DD1BCC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107917C", Offset="0x107917C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD1F84", Offset="0x1DD1F84", VA="0x1DD1F84", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10791BC", Offset="0x10791BC")]
		public void MergeFrom(BattleSim_Player other)
		{
		}

		[Address(RVA="0x1DD204C", Offset="0x1DD204C", VA="0x1DD204C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10791CC", Offset="0x10791CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD1C80", Offset="0x1DD1C80", VA="0x1DD1C80", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107918C", Offset="0x107918C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD1CE8", Offset="0x1DD1CE8", VA="0x1DD1CE8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107919C", Offset="0x107919C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F478", Offset="0x104F478")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleSim_Player.<>c <>9;

			[Address(RVA="0x1DD2318", Offset="0x1DD2318", VA="0x1DD2318")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD237C", Offset="0x1DD237C", VA="0x1DD237C")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD2384", Offset="0x1DD2384", VA="0x1DD2384")]
			internal BattleSim_Player <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}