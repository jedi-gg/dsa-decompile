using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleSim_Unit : IMessage<BattleSim_Unit>, IMessage, IEquatable<BattleSim_Unit>, IDeepCloneable<BattleSim_Unit>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleSim_Unit> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DefIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong defId_;

		[FieldOffset(Offset="0x0")]
		public const int LevelFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong level_;

		[FieldOffset(Offset="0x0")]
		public const int RarityFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong rarity_;

		[FieldOffset(Offset="0x0")]
		public const int GearTierFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong gearTier_;

		[FieldOffset(Offset="0x0")]
		public const int GearSlotEquippedFieldNumber = 5;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<bool> _repeated_gearSlotEquipped_codec;

		[FieldOffset(Offset="0x38")]
		private readonly RepeatedField<bool> gearSlotEquipped_;

		[FieldOffset(Offset="0x0")]
		public const int AbilityLevelsFieldNumber = 6;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_abilityLevels_codec;

		[FieldOffset(Offset="0x40")]
		private readonly RepeatedField<ulong> abilityLevels_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093D60", Offset="0x1093D60")]
		public RepeatedField<ulong> AbilityLevels
		{
			[Address(RVA="0x1DD7620", Offset="0x1DD7620", VA="0x1DD7620")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093D10", Offset="0x1093D10")]
		public ulong DefId
		{
			[Address(RVA="0x1DD75D8", Offset="0x1DD75D8", VA="0x1DD75D8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD75E0", Offset="0x1DD75E0", VA="0x1DD75E0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093CF0", Offset="0x1093CF0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD7264", Offset="0x1DD7264", VA="0x1DD7264")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093D50", Offset="0x1093D50")]
		public RepeatedField<bool> GearSlotEquipped
		{
			[Address(RVA="0x1DD7618", Offset="0x1DD7618", VA="0x1DD7618")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093D40", Offset="0x1093D40")]
		public ulong GearTier
		{
			[Address(RVA="0x1DD7608", Offset="0x1DD7608", VA="0x1DD7608")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD7610", Offset="0x1DD7610", VA="0x1DD7610")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093D20", Offset="0x1093D20")]
		public ulong Level
		{
			[Address(RVA="0x1DD75E8", Offset="0x1DD75E8", VA="0x1DD75E8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD75F0", Offset="0x1DD75F0", VA="0x1DD75F0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093CE0", Offset="0x1093CE0")]
		public static MessageParser<BattleSim_Unit> Parser
		{
			[Address(RVA="0x1DCF36C", Offset="0x1DCF36C", VA="0x1DCF36C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093D00", Offset="0x1093D00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD7350", Offset="0x1DD7350", VA="0x1DD7350", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093D30", Offset="0x1093D30")]
		public ulong Rarity
		{
			[Address(RVA="0x1DD75F8", Offset="0x1DD75F8", VA="0x1DD75F8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD7600", Offset="0x1DD7600", VA="0x1DD7600")]
			set
			{
			}
		}

		[Address(RVA="0x1DD8074", Offset="0x1DD8074", VA="0x1DD8074")]
		static BattleSim_Unit()
		{
		}

		[Address(RVA="0x1DD73AC", Offset="0x1DD73AC", VA="0x1DD73AC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10791DC", Offset="0x10791DC")]
		public BattleSim_Unit()
		{
		}

		[Address(RVA="0x1DD7444", Offset="0x1DD7444", VA="0x1DD7444")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10791EC", Offset="0x10791EC")]
		public BattleSim_Unit(BattleSim_Unit other)
		{
		}

		[Address(RVA="0x1DD7B94", Offset="0x1DD7B94", VA="0x1DD7B94", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107925C", Offset="0x107925C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD7578", Offset="0x1DD7578", VA="0x1DD7578", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10791FC", Offset="0x10791FC")]
		public BattleSim_Unit Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD7628", Offset="0x1DD7628", VA="0x1DD7628", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107920C", Offset="0x107920C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD769C", Offset="0x1DD769C", VA="0x1DD769C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107921C", Offset="0x107921C")]
		public bool Equals(BattleSim_Unit other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD77BC", Offset="0x1DD77BC", VA="0x1DD77BC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107922C", Offset="0x107922C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD7D84", Offset="0x1DD7D84", VA="0x1DD7D84", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107926C", Offset="0x107926C")]
		public void MergeFrom(BattleSim_Unit other)
		{
		}

		[Address(RVA="0x1DD7E70", Offset="0x1DD7E70", VA="0x1DD7E70", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107927C", Offset="0x107927C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD78C4", Offset="0x1DD78C4", VA="0x1DD78C4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107923C", Offset="0x107923C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD792C", Offset="0x1DD792C", VA="0x1DD792C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107924C", Offset="0x107924C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F488", Offset="0x104F488")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleSim_Unit.<>c <>9;

			[Address(RVA="0x1DD817C", Offset="0x1DD817C", VA="0x1DD817C")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD81E0", Offset="0x1DD81E0", VA="0x1DD81E0")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD81E8", Offset="0x1DD81E8", VA="0x1DD81E8")]
			internal BattleSim_Unit <.cctor>b__50_0()
			{
				return null;
			}
		}
	}
}