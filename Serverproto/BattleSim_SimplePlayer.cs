using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleSim_SimplePlayer : IMessage<BattleSim_SimplePlayer>, IMessage, IEquatable<BattleSim_SimplePlayer>, IDeepCloneable<BattleSim_SimplePlayer>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleSim_SimplePlayer> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerLevelFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong playerLevel_;

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
		public const int UnitLevelFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong unitLevel_;

		[FieldOffset(Offset="0x0")]
		public const int UnitRarityFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ulong unitRarity_;

		[FieldOffset(Offset="0x0")]
		public const int UnitGearTierFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong unitGearTier_;

		[FieldOffset(Offset="0x0")]
		public const int UnitAbilityLevelFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ulong unitAbilityLevel_;

		[FieldOffset(Offset="0x0")]
		public const int SpellLevelFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private ulong spellLevel_;

		[FieldOffset(Offset="0x0")]
		public const int EnableAiFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private bool enableAi_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093BD0", Offset="0x1093BD0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD5984", Offset="0x1DD5984", VA="0x1DD5984")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093C70", Offset="0x1093C70")]
		public bool EnableAi
		{
			[Address(RVA="0x1DD5C44", Offset="0x1DD5C44", VA="0x1DD5C44")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1DD5C4C", Offset="0x1DD5C4C", VA="0x1DD5C4C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093BC0", Offset="0x1093BC0")]
		public static MessageParser<BattleSim_SimplePlayer> Parser
		{
			[Address(RVA="0x1DCF29C", Offset="0x1DCF29C", VA="0x1DCF29C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093BE0", Offset="0x1093BE0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD5A70", Offset="0x1DD5A70", VA="0x1DD5A70", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093BF0", Offset="0x1093BF0")]
		public ulong PlayerLevel
		{
			[Address(RVA="0x1DD5BD4", Offset="0x1DD5BD4", VA="0x1DD5BD4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD5BDC", Offset="0x1DD5BDC", VA="0x1DD5BDC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093C10", Offset="0x1093C10")]
		public RepeatedField<ulong> SpellIds
		{
			[Address(RVA="0x1DD5BEC", Offset="0x1DD5BEC", VA="0x1DD5BEC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093C60", Offset="0x1093C60")]
		public ulong SpellLevel
		{
			[Address(RVA="0x1DD5C34", Offset="0x1DD5C34", VA="0x1DD5C34")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD5C3C", Offset="0x1DD5C3C", VA="0x1DD5C3C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093C50", Offset="0x1093C50")]
		public ulong UnitAbilityLevel
		{
			[Address(RVA="0x1DD5C24", Offset="0x1DD5C24", VA="0x1DD5C24")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD5C2C", Offset="0x1DD5C2C", VA="0x1DD5C2C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093C40", Offset="0x1093C40")]
		public ulong UnitGearTier
		{
			[Address(RVA="0x1DD5C14", Offset="0x1DD5C14", VA="0x1DD5C14")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD5C1C", Offset="0x1DD5C1C", VA="0x1DD5C1C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093C00", Offset="0x1093C00")]
		public RepeatedField<ulong> UnitIds
		{
			[Address(RVA="0x1DD5BE4", Offset="0x1DD5BE4", VA="0x1DD5BE4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093C20", Offset="0x1093C20")]
		public ulong UnitLevel
		{
			[Address(RVA="0x1DD5BF4", Offset="0x1DD5BF4", VA="0x1DD5BF4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD5BFC", Offset="0x1DD5BFC", VA="0x1DD5BFC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093C30", Offset="0x1093C30")]
		public ulong UnitRarity
		{
			[Address(RVA="0x1DD5C04", Offset="0x1DD5C04", VA="0x1DD5C04")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1DD5C0C", Offset="0x1DD5C0C", VA="0x1DD5C0C")]
			set
			{
			}
		}

		[Address(RVA="0x1DD6840", Offset="0x1DD6840", VA="0x1DD6840")]
		static BattleSim_SimplePlayer()
		{
		}

		[Address(RVA="0x1DD49DC", Offset="0x1DD49DC", VA="0x1DD49DC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107907C", Offset="0x107907C")]
		public BattleSim_SimplePlayer()
		{
		}

		[Address(RVA="0x1DD5ACC", Offset="0x1DD5ACC", VA="0x1DD5ACC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107908C", Offset="0x107908C")]
		public BattleSim_SimplePlayer(BattleSim_SimplePlayer other)
		{
		}

		[Address(RVA="0x1DD6368", Offset="0x1DD6368", VA="0x1DD6368", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10790FC", Offset="0x10790FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD4480", Offset="0x1DD4480", VA="0x1DD4480", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107909C", Offset="0x107909C")]
		public BattleSim_SimplePlayer Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD5C58", Offset="0x1DD5C58", VA="0x1DD5C58", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10790AC", Offset="0x10790AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD5CCC", Offset="0x1DD5CCC", VA="0x1DD5CCC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10790BC", Offset="0x10790BC")]
		public bool Equals(BattleSim_SimplePlayer other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD5E30", Offset="0x1DD5E30", VA="0x1DD5E30", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10790CC", Offset="0x10790CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD4A6C", Offset="0x1DD4A6C", VA="0x1DD4A6C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107910C", Offset="0x107910C")]
		public void MergeFrom(BattleSim_SimplePlayer other)
		{
		}

		[Address(RVA="0x1DD65D4", Offset="0x1DD65D4", VA="0x1DD65D4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107911C", Offset="0x107911C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD5F94", Offset="0x1DD5F94", VA="0x1DD5F94", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10790DC", Offset="0x10790DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD5FFC", Offset="0x1DD5FFC", VA="0x1DD5FFC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10790EC", Offset="0x10790EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F468", Offset="0x104F468")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleSim_SimplePlayer.<>c <>9;

			[Address(RVA="0x1DD6948", Offset="0x1DD6948", VA="0x1DD6948")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD69AC", Offset="0x1DD69AC", VA="0x1DD69AC")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD69B4", Offset="0x1DD69B4", VA="0x1DD69B4")]
			internal BattleSim_SimplePlayer <.cctor>b__65_0()
			{
				return null;
			}
		}
	}
}