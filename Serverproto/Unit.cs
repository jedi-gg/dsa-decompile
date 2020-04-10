using Gamedata;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Serverproto
{
	public sealed class Unit : IMessage<Serverproto.Unit>, IMessage, IEquatable<Serverproto.Unit>, IDeepCloneable<Serverproto.Unit>
	{
		[FieldOffset(Offset="0x0")]
		public const string FALLBACK_PREFAB = "unit_fallback/fallback_unit";

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10628C4", Offset="0x10628C4")]
		[FieldOffset(Offset="0x10")]
		private Gamedata.Unit <Definition>k__BackingField;

		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<Serverproto.Unit> _parser;

		[FieldOffset(Offset="0x20")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DefinitionIdFieldNumber = 1;

		[FieldOffset(Offset="0x28")]
		private ulong definitionId_;

		[FieldOffset(Offset="0x0")]
		public const int RarityFieldNumber = 2;

		[FieldOffset(Offset="0x30")]
		private ulong rarity_;

		[FieldOffset(Offset="0x0")]
		public const int LevelFieldNumber = 3;

		[FieldOffset(Offset="0x38")]
		private ulong level_;

		[FieldOffset(Offset="0x0")]
		public const int GearSlotEquippedFieldNumber = 4;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<bool> _repeated_gearSlotEquipped_codec;

		[FieldOffset(Offset="0x40")]
		private readonly RepeatedField<bool> gearSlotEquipped_;

		[FieldOffset(Offset="0x0")]
		public const int GearTierFieldNumber = 5;

		[FieldOffset(Offset="0x48")]
		private ulong gearTier_;

		[FieldOffset(Offset="0x0")]
		public const int OffenseFieldNumber = 6;

		[FieldOffset(Offset="0x50")]
		private ulong offense_;

		[FieldOffset(Offset="0x0")]
		public const int DefenseFieldNumber = 7;

		[FieldOffset(Offset="0x58")]
		private ulong defense_;

		[FieldOffset(Offset="0x0")]
		public const int HealthFieldNumber = 8;

		[FieldOffset(Offset="0x60")]
		private ulong health_;

		[FieldOffset(Offset="0x0")]
		public const int CritChanceFieldNumber = 9;

		[FieldOffset(Offset="0x68")]
		private double critChance_;

		[FieldOffset(Offset="0x0")]
		public const int CritPowerFieldNumber = 10;

		[FieldOffset(Offset="0x70")]
		private double critPower_;

		[FieldOffset(Offset="0x0")]
		public const int AttackSpeedFieldNumber = 11;

		[FieldOffset(Offset="0x78")]
		private double attackSpeed_;

		[FieldOffset(Offset="0x0")]
		public const int AbilityLevelFieldNumber = 12;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_abilityLevel_codec;

		[FieldOffset(Offset="0x80")]
		private readonly RepeatedField<ulong> abilityLevel_;

		[FieldOffset(Offset="0x0")]
		public const int PowerRatingFieldNumber = 13;

		[FieldOffset(Offset="0x88")]
		private ulong powerRating_;

		[FieldOffset(Offset="0x0")]
		public const int RecoveryFieldNumber = 14;

		[FieldOffset(Offset="0x90")]
		private ulong recovery_;

		[FieldOffset(Offset="0x0")]
		public const int SkinItemIdFieldNumber = 15;

		[FieldOffset(Offset="0x98")]
		private ulong skinItemId_;

		[FieldOffset(Offset="0x0")]
		public const int SorcererStoneIdFieldNumber = 16;

		[FieldOffset(Offset="0xA0")]
		private ulong sorcererStoneId_;

		[FieldOffset(Offset="0x0")]
		public const int SpeedFieldNumber = 17;

		[FieldOffset(Offset="0xA8")]
		private ulong speed_;

		[FieldOffset(Offset="0x0")]
		public const int PotencyFieldNumber = 18;

		[FieldOffset(Offset="0xB0")]
		private double potency_;

		[FieldOffset(Offset="0x0")]
		public const int TenacityFieldNumber = 19;

		[FieldOffset(Offset="0xB8")]
		private double tenacity_;

		[FieldOffset(Offset="0x0")]
		public const int AccuracyFieldNumber = 20;

		[FieldOffset(Offset="0xC0")]
		private double accuracy_;

		[FieldOffset(Offset="0x0")]
		public const int EvasionFieldNumber = 21;

		[FieldOffset(Offset="0xC8")]
		private double evasion_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099938", Offset="0x1099938")]
		public RepeatedField<ulong> AbilityLevel
		{
			[Address(RVA="0x14B1274", Offset="0x14B1274", VA="0x14B1274")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10999B8", Offset="0x10999B8")]
		public double Accuracy
		{
			[Address(RVA="0x14B1DC4", Offset="0x14B1DC4", VA="0x14B1DC4")]
			get
			{
				return new double();
			}
			[Address(RVA="0x14B1DCC", Offset="0x14B1DCC", VA="0x14B1DCC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099928", Offset="0x1099928")]
		public double AttackSpeed
		{
			[Address(RVA="0x14B1D54", Offset="0x14B1D54", VA="0x14B1D54")]
			get
			{
				return new double();
			}
			[Address(RVA="0x14B1D5C", Offset="0x14B1D5C", VA="0x14B1D5C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099908", Offset="0x1099908")]
		public double CritChance
		{
			[Address(RVA="0x14B1D34", Offset="0x14B1D34", VA="0x14B1D34")]
			get
			{
				return new double();
			}
			[Address(RVA="0x14B1D3C", Offset="0x14B1D3C", VA="0x14B1D3C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099918", Offset="0x1099918")]
		public double CritPower
		{
			[Address(RVA="0x14B1D44", Offset="0x14B1D44", VA="0x14B1D44")]
			get
			{
				return new double();
			}
			[Address(RVA="0x14B1D4C", Offset="0x14B1D4C", VA="0x14B1D4C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10998E8", Offset="0x10998E8")]
		public ulong Defense
		{
			[Address(RVA="0x14B1D14", Offset="0x14B1D14", VA="0x14B1D14")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B1D1C", Offset="0x14B1D1C", VA="0x14B1D1C")]
			set
			{
			}
		}

		public Gamedata.Unit Definition
		{
			[Address(RVA="0x14B0BEC", Offset="0x14B0BEC", VA="0x14B0BEC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10838BC", Offset="0x10838BC")]
			get
			{
				return new Gamedata.Unit();
			}
			[Address(RVA="0x14B0BF8", Offset="0x14B0BF8", VA="0x14B0BF8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10838CC", Offset="0x10838CC")]
			private set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099888", Offset="0x1099888")]
		public ulong DefinitionId
		{
			[Address(RVA="0x14B127C", Offset="0x14B127C", VA="0x14B127C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B1CE4", Offset="0x14B1CE4", VA="0x14B1CE4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099868", Offset="0x1099868")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x14B18A4", Offset="0x14B18A4", VA="0x14B18A4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10999C8", Offset="0x10999C8")]
		public double Evasion
		{
			[Address(RVA="0x14B1DD4", Offset="0x14B1DD4", VA="0x14B1DD4")]
			get
			{
				return new double();
			}
			[Address(RVA="0x14B1DDC", Offset="0x14B1DDC", VA="0x14B1DDC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10998B8", Offset="0x10998B8")]
		public RepeatedField<bool> GearSlotEquipped
		{
			[Address(RVA="0x14B0E6C", Offset="0x14B0E6C", VA="0x14B0E6C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10998C8", Offset="0x10998C8")]
		public ulong GearTier
		{
			[Address(RVA="0x14B0C0C", Offset="0x14B0C0C", VA="0x14B0C0C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B1CFC", Offset="0x14B1CFC", VA="0x14B1CFC")]
			set
			{
			}
		}

		public int GearTierDataIndex
		{
			[Address(RVA="0x14B0C00", Offset="0x14B0C00", VA="0x14B0C00")]
			get
			{
				return new int();
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10998F8", Offset="0x10998F8")]
		public ulong Health
		{
			[Address(RVA="0x14B1D24", Offset="0x14B1D24", VA="0x14B1D24")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B1D2C", Offset="0x14B1D2C", VA="0x14B1D2C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10998A8", Offset="0x10998A8")]
		public ulong Level
		{
			[Address(RVA="0x14B1824", Offset="0x14B1824", VA="0x14B1824")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B1CF4", Offset="0x14B1CF4", VA="0x14B1CF4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10998D8", Offset="0x10998D8")]
		public ulong Offense
		{
			[Address(RVA="0x14B1D04", Offset="0x14B1D04", VA="0x14B1D04")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B1D0C", Offset="0x14B1D0C", VA="0x14B1D0C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099858", Offset="0x1099858")]
		public static MessageParser<Serverproto.Unit> Parser
		{
			[Address(RVA="0x14B183C", Offset="0x14B183C", VA="0x14B183C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099878", Offset="0x1099878")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x14B19F8", Offset="0x14B19F8", VA="0x14B19F8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099998", Offset="0x1099998")]
		public double Potency
		{
			[Address(RVA="0x14B1DA4", Offset="0x14B1DA4", VA="0x14B1DA4")]
			get
			{
				return new double();
			}
			[Address(RVA="0x14B1DAC", Offset="0x14B1DAC", VA="0x14B1DAC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099948", Offset="0x1099948")]
		public ulong PowerRating
		{
			[Address(RVA="0x14B181C", Offset="0x14B181C", VA="0x14B181C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B1D64", Offset="0x14B1D64", VA="0x14B1D64")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099898", Offset="0x1099898")]
		public ulong Rarity
		{
			[Address(RVA="0x14B182C", Offset="0x14B182C", VA="0x14B182C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B1CEC", Offset="0x14B1CEC", VA="0x14B1CEC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099958", Offset="0x1099958")]
		public ulong Recovery
		{
			[Address(RVA="0x14B1D6C", Offset="0x14B1D6C", VA="0x14B1D6C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B1D74", Offset="0x14B1D74", VA="0x14B1D74")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099968", Offset="0x1099968")]
		public ulong SkinItemId
		{
			[Address(RVA="0x14B1D7C", Offset="0x14B1D7C", VA="0x14B1D7C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B1D84", Offset="0x14B1D84", VA="0x14B1D84")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099978", Offset="0x1099978")]
		public ulong SorcererStoneId
		{
			[Address(RVA="0x14B1834", Offset="0x14B1834", VA="0x14B1834")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B1D8C", Offset="0x14B1D8C", VA="0x14B1D8C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099988", Offset="0x1099988")]
		public ulong Speed
		{
			[Address(RVA="0x14B1D94", Offset="0x14B1D94", VA="0x14B1D94")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x14B1D9C", Offset="0x14B1D9C", VA="0x14B1D9C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10999A8", Offset="0x10999A8")]
		public double Tenacity
		{
			[Address(RVA="0x14B1DB4", Offset="0x14B1DB4", VA="0x14B1DB4")]
			get
			{
				return new double();
			}
			[Address(RVA="0x14B1DBC", Offset="0x14B1DBC", VA="0x14B1DBC")]
			set
			{
			}
		}

		[Address(RVA="0x14B39EC", Offset="0x14B39EC", VA="0x14B39EC")]
		static Unit()
		{
		}

		[Address(RVA="0x14B1A54", Offset="0x14B1A54", VA="0x14B1A54")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10838DC", Offset="0x10838DC")]
		public Unit()
		{
		}

		[Address(RVA="0x14B1AEC", Offset="0x14B1AEC", VA="0x14B1AEC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10838EC", Offset="0x10838EC")]
		public Unit(Serverproto.Unit other)
		{
		}

		[Address(RVA="0x14B2F60", Offset="0x14B2F60", VA="0x14B2F60", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108395C", Offset="0x108395C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x14B0C14", Offset="0x14B0C14", VA="0x14B0C14")]
		public bool CanTierUpGear()
		{
			return new bool();
		}

		[Address(RVA="0x14B1C84", Offset="0x14B1C84", VA="0x14B1C84", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10838FC", Offset="0x10838FC")]
		public Serverproto.Unit Clone()
		{
			return null;
		}

		[Address(RVA="0x14B1DE4", Offset="0x14B1DE4", VA="0x14B1DE4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108390C", Offset="0x108390C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x14B1E58", Offset="0x14B1E58", VA="0x14B1E58", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108391C", Offset="0x108391C")]
		public bool Equals(Serverproto.Unit other)
		{
			return new bool();
		}

		[Address(RVA="0x14B1028", Offset="0x14B1028", VA="0x14B1028")]
		public ulong GetAbilityLevel(UnitAbility? ability)
		{
			return new ulong();
		}

		[Address(RVA="0x14B0E74", Offset="0x14B0E74", VA="0x14B0E74")]
		public UnitGearTierMeritItem? GetCurrentGearTierMeritItem(ref bool meritItemIsUnlocked)
		{
			return null;
		}

		[Address(RVA="0x14B225C", Offset="0x14B225C", VA="0x14B225C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108392C", Offset="0x108392C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x14B33A8", Offset="0x14B33A8", VA="0x14B33A8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108396C", Offset="0x108396C")]
		public void MergeFrom(Serverproto.Unit other)
		{
		}

		[Address(RVA="0x14B3564", Offset="0x14B3564", VA="0x14B3564", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108397C", Offset="0x108397C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x14B26F8", Offset="0x14B26F8", VA="0x14B26F8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108393C", Offset="0x108393C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x14B1284", Offset="0x14B1284", VA="0x14B1284")]
		public Dictionary<string, object> ToTelemetryData()
		{
			return null;
		}

		[Address(RVA="0x14B2760", Offset="0x14B2760", VA="0x14B2760", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108394C", Offset="0x108394C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10503B8", Offset="0x10503B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static Serverproto.Unit.<>c <>9;

			[Address(RVA="0x14B3AF4", Offset="0x14B3AF4", VA="0x14B3AF4")]
			static <>c()
			{
			}

			[Address(RVA="0x14B3B58", Offset="0x14B3B58", VA="0x14B3B58")]
			public <>c()
			{
			}

			[Address(RVA="0x14B3B60", Offset="0x14B3B60", VA="0x14B3B60")]
			internal Serverproto.Unit <.cctor>b__137_0()
			{
				return null;
			}
		}

		public class Factory
		{
			[Attribute(Name="InjectAttribute", RVA="0x106C9D4", Offset="0x106C9D4")]
			[FieldOffset(Offset="0x10")]
			private GamedataDomainController _gamedataDC;

			[Address(RVA="0x14B3E44", Offset="0x14B3E44", VA="0x14B3E44")]
			public Factory()
			{
			}

			[Address(RVA="0x14B3BB8", Offset="0x14B3BB8", VA="0x14B3BB8")]
			public void BindPartialFields(ref Serverproto.Unit unit)
			{
			}

			[Address(RVA="0x14B3CA4", Offset="0x14B3CA4", VA="0x14B3CA4")]
			public Serverproto.Unit FromBattleUnit(BattleLib_Bootstrap.Types.Unit unit)
			{
				return null;
			}
		}
	}
}