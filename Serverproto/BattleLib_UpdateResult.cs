using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleLib_UpdateResult : IMessage<BattleLib_UpdateResult>, IMessage, IEquatable<BattleLib_UpdateResult>, IDeepCloneable<BattleLib_UpdateResult>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleLib_UpdateResult> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ClockSFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private float clockS_;

		[FieldOffset(Offset="0x0")]
		public const int DamageFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.Damage> _repeated_damage_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.Damage> damage_;

		[FieldOffset(Offset="0x0")]
		public const int PositionsFieldNumber = 3;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.UnitPosition> _repeated_positions_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.UnitPosition> positions_;

		[FieldOffset(Offset="0x0")]
		public const int VisualsOnUnitsFieldNumber = 4;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.VisualOnUnit> _repeated_visualsOnUnits_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.VisualOnUnit> visualsOnUnits_;

		[FieldOffset(Offset="0x0")]
		public const int VisualsOnWorldFieldNumber = 5;

		[FieldOffset(Offset="0x20")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.VisualOnWorld> _repeated_visualsOnWorld_codec;

		[FieldOffset(Offset="0x38")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.VisualOnWorld> visualsOnWorld_;

		[FieldOffset(Offset="0x0")]
		public const int HealthFieldNumber = 6;

		[FieldOffset(Offset="0x28")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.UnitHealth> _repeated_health_codec;

		[FieldOffset(Offset="0x40")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.UnitHealth> health_;

		[FieldOffset(Offset="0x0")]
		public const int ManaFieldNumber = 7;

		[FieldOffset(Offset="0x30")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.PlayerMana> _repeated_mana_codec;

		[FieldOffset(Offset="0x48")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.PlayerMana> mana_;

		[FieldOffset(Offset="0x0")]
		public const int AutoAttackTargetChangesFieldNumber = 8;

		[FieldOffset(Offset="0x38")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.AutoAttackTargetChange> _repeated_autoAttackTargetChanges_codec;

		[FieldOffset(Offset="0x50")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.AutoAttackTargetChange> autoAttackTargetChanges_;

		[FieldOffset(Offset="0x0")]
		public const int VisualsInterruptedFieldNumber = 9;

		[FieldOffset(Offset="0x40")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.VisualInterrupt> _repeated_visualsInterrupted_codec;

		[FieldOffset(Offset="0x58")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.VisualInterrupt> visualsInterrupted_;

		[FieldOffset(Offset="0x0")]
		public const int CastStartsFieldNumber = 10;

		[FieldOffset(Offset="0x48")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.CastStart> _repeated_castStarts_codec;

		[FieldOffset(Offset="0x60")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.CastStart> castStarts_;

		[FieldOffset(Offset="0x0")]
		public const int CastEndsFieldNumber = 11;

		[FieldOffset(Offset="0x50")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.CastEnd> _repeated_castEnds_codec;

		[FieldOffset(Offset="0x68")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.CastEnd> castEnds_;

		[FieldOffset(Offset="0x0")]
		public const int UseAbilityResponsesFieldNumber = 12;

		[FieldOffset(Offset="0x58")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.UseAbilityResponse> _repeated_useAbilityResponses_codec;

		[FieldOffset(Offset="0x70")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.UseAbilityResponse> useAbilityResponses_;

		[FieldOffset(Offset="0x0")]
		public const int HandsFieldNumber = 13;

		[FieldOffset(Offset="0x60")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.PlayerHand> _repeated_hands_codec;

		[FieldOffset(Offset="0x78")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.PlayerHand> hands_;

		[FieldOffset(Offset="0x0")]
		public const int SpawnsFieldNumber = 14;

		[FieldOffset(Offset="0x68")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.Spawn> _repeated_spawns_codec;

		[FieldOffset(Offset="0x80")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.Spawn> spawns_;

		[FieldOffset(Offset="0x0")]
		public const int DeathsFieldNumber = 15;

		[FieldOffset(Offset="0x70")]
		private readonly static FieldCodec<uint> _repeated_deaths_codec;

		[FieldOffset(Offset="0x88")]
		private readonly RepeatedField<uint> deaths_;

		[FieldOffset(Offset="0x0")]
		public const int EncountersStartedFieldNumber = 16;

		[FieldOffset(Offset="0x78")]
		private readonly static FieldCodec<uint> _repeated_encountersStarted_codec;

		[FieldOffset(Offset="0x90")]
		private readonly RepeatedField<uint> encountersStarted_;

		[FieldOffset(Offset="0x0")]
		public const int EncountersEndedFieldNumber = 17;

		[FieldOffset(Offset="0x80")]
		private readonly static FieldCodec<uint> _repeated_encountersEnded_codec;

		[FieldOffset(Offset="0x98")]
		private readonly RepeatedField<uint> encountersEnded_;

		[FieldOffset(Offset="0x0")]
		public const int ManaMetaFieldNumber = 18;

		[FieldOffset(Offset="0x88")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.PlayerManaMeta> _repeated_manaMeta_codec;

		[FieldOffset(Offset="0xA0")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.PlayerManaMeta> manaMeta_;

		[FieldOffset(Offset="0x0")]
		public const int BattleEndedFieldNumber = 19;

		[FieldOffset(Offset="0xA8")]
		private BattleLib_UpdateResult.Types.BattleEnded battleEnded_;

		[FieldOffset(Offset="0x0")]
		public const int VisualsAtPositionFieldNumber = 20;

		[FieldOffset(Offset="0x90")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.VisualAtPosition> _repeated_visualsAtPosition_codec;

		[FieldOffset(Offset="0xB0")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.VisualAtPosition> visualsAtPosition_;

		[FieldOffset(Offset="0x0")]
		public const int HpDecayFieldNumber = 21;

		[FieldOffset(Offset="0x98")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.UnitHpDecay> _repeated_hpDecay_codec;

		[FieldOffset(Offset="0xB8")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.UnitHpDecay> hpDecay_;

		[FieldOffset(Offset="0x0")]
		public const int BattleActivityUpdatesFieldNumber = 22;

		[FieldOffset(Offset="0xA0")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.BattleActivityUpdate> _repeated_battleActivityUpdates_codec;

		[FieldOffset(Offset="0xC0")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.BattleActivityUpdate> battleActivityUpdates_;

		[FieldOffset(Offset="0x0")]
		public const int EmotesFieldNumber = 23;

		[FieldOffset(Offset="0xA8")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.BattleEmote> _repeated_emotes_codec;

		[FieldOffset(Offset="0xC8")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.BattleEmote> emotes_;

		[FieldOffset(Offset="0x0")]
		public const int TimeLimitFieldNumber = 24;

		[FieldOffset(Offset="0xD0")]
		private BattleLib_UpdateResult.Types.BattleTimeLimit timeLimit_;

		[FieldOffset(Offset="0x0")]
		public const int KillingBlowFieldNumber = 25;

		[FieldOffset(Offset="0xD8")]
		private BattleLib_UpdateResult.Types.KillingBlow killingBlow_;

		[FieldOffset(Offset="0x0")]
		public const int SpellChargeFieldNumber = 26;

		[FieldOffset(Offset="0xB0")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.PlayerSpellCharge> _repeated_spellCharge_codec;

		[FieldOffset(Offset="0xE0")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.PlayerSpellCharge> spellCharge_;

		[FieldOffset(Offset="0x0")]
		public const int SpellHandsFieldNumber = 28;

		[FieldOffset(Offset="0xB8")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.SpellHand> _repeated_spellHands_codec;

		[FieldOffset(Offset="0xE8")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.SpellHand> spellHands_;

		[FieldOffset(Offset="0x0")]
		public const int UnitEffectsFieldNumber = 29;

		[FieldOffset(Offset="0xC0")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.UnitEffects> _repeated_unitEffects_codec;

		[FieldOffset(Offset="0xF0")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.UnitEffects> unitEffects_;

		[FieldOffset(Offset="0x0")]
		public const int UnitTurnInfoFieldNumber = 30;

		[FieldOffset(Offset="0xC8")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.UnitTurnInfo> _repeated_unitTurnInfo_codec;

		[FieldOffset(Offset="0xF8")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.UnitTurnInfo> unitTurnInfo_;

		[FieldOffset(Offset="0x0")]
		public const int DebugLogsFieldNumber = 31;

		[FieldOffset(Offset="0xD0")]
		private readonly static FieldCodec<string> _repeated_debugLogs_codec;

		[FieldOffset(Offset="0x100")]
		private readonly RepeatedField<string> debugLogs_;

		[FieldOffset(Offset="0x0")]
		public const int UnitTurnStartedFieldNumber = 32;

		[FieldOffset(Offset="0x108")]
		private BattleLib_UpdateResult.Types.UnitTurnStarted unitTurnStarted_;

		[FieldOffset(Offset="0x0")]
		public const int AbilityCamerasFieldNumber = 33;

		[FieldOffset(Offset="0xD8")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.AbilityCamera> _repeated_abilityCameras_codec;

		[FieldOffset(Offset="0x110")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.AbilityCamera> abilityCameras_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerTurnIdledFieldNumber = 34;

		[FieldOffset(Offset="0x118")]
		private BattleLib_UpdateResult.Types.PlayerTurnIdled playerTurnIdled_;

		[FieldOffset(Offset="0x0")]
		public const int TurnLimitFieldNumber = 35;

		[FieldOffset(Offset="0x120")]
		private BattleLib_UpdateResult.Types.BattleTurnLimit turnLimit_;

		[FieldOffset(Offset="0x0")]
		public const int MessagesFieldNumber = 36;

		[FieldOffset(Offset="0xE0")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.BattleMessage> _repeated_messages_codec;

		[FieldOffset(Offset="0x128")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.BattleMessage> messages_;

		[FieldOffset(Offset="0x0")]
		public const int AurasFieldNumber = 37;

		[FieldOffset(Offset="0xE8")]
		private readonly static FieldCodec<BattleLib_UpdateResult.Types.Aura> _repeated_auras_codec;

		[FieldOffset(Offset="0x130")]
		private readonly RepeatedField<BattleLib_UpdateResult.Types.Aura> auras_;

		[FieldOffset(Offset="0x0")]
		public const int BattleBusyFieldNumber = 38;

		[FieldOffset(Offset="0x138")]
		private bool battleBusy_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093900", Offset="0x1093900")]
		public RepeatedField<BattleLib_UpdateResult.Types.AbilityCamera> AbilityCameras
		{
			[Address(RVA="0x17A55A8", Offset="0x17A55A8", VA="0x17A55A8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093940", Offset="0x1093940")]
		public RepeatedField<BattleLib_UpdateResult.Types.Aura> Auras
		{
			[Address(RVA="0x17A55B8", Offset="0x17A55B8", VA="0x17A55B8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093780", Offset="0x1093780")]
		public RepeatedField<BattleLib_UpdateResult.Types.AutoAttackTargetChange> AutoAttackTargetChanges
		{
			[Address(RVA="0x17A5508", Offset="0x17A5508", VA="0x17A5508")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093860", Offset="0x1093860")]
		public RepeatedField<BattleLib_UpdateResult.Types.BattleActivityUpdate> BattleActivityUpdates
		{
			[Address(RVA="0x17A5570", Offset="0x17A5570", VA="0x17A5570")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093950", Offset="0x1093950")]
		public bool BattleBusy
		{
			[Address(RVA="0x17A55C0", Offset="0x17A55C0", VA="0x17A55C0")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x17A55C8", Offset="0x17A55C8", VA="0x17A55C8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093830", Offset="0x1093830")]
		public BattleLib_UpdateResult.Types.BattleEnded BattleEnded
		{
			[Address(RVA="0x17A5348", Offset="0x17A5348", VA="0x17A5348")]
			get
			{
				return null;
			}
			[Address(RVA="0x17A53B0", Offset="0x17A53B0", VA="0x17A53B0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10937B0", Offset="0x10937B0")]
		public RepeatedField<BattleLib_UpdateResult.Types.CastEnd> CastEnds
		{
			[Address(RVA="0x17A5520", Offset="0x17A5520", VA="0x17A5520")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10937A0", Offset="0x10937A0")]
		public RepeatedField<BattleLib_UpdateResult.Types.CastStart> CastStarts
		{
			[Address(RVA="0x17A5518", Offset="0x17A5518", VA="0x17A5518")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093710", Offset="0x1093710")]
		public float ClockS
		{
			[Address(RVA="0x17A54C8", Offset="0x17A54C8", VA="0x17A54C8")]
			get
			{
				return new float();
			}
			[Address(RVA="0x17A54D0", Offset="0x17A54D0", VA="0x17A54D0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093720", Offset="0x1093720")]
		public RepeatedField<BattleLib_UpdateResult.Types.Damage> Damage
		{
			[Address(RVA="0x17A54D8", Offset="0x17A54D8", VA="0x17A54D8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10937F0", Offset="0x10937F0")]
		public RepeatedField<uint> Deaths
		{
			[Address(RVA="0x17A5540", Offset="0x17A5540", VA="0x17A5540")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10938E0", Offset="0x10938E0")]
		public RepeatedField<string> DebugLogs
		{
			[Address(RVA="0x17A55A0", Offset="0x17A55A0", VA="0x17A55A0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10936F0", Offset="0x10936F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x17A47C4", Offset="0x17A47C4", VA="0x17A47C4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093870", Offset="0x1093870")]
		public RepeatedField<BattleLib_UpdateResult.Types.BattleEmote> Emotes
		{
			[Address(RVA="0x17A5578", Offset="0x17A5578", VA="0x17A5578")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093810", Offset="0x1093810")]
		public RepeatedField<uint> EncountersEnded
		{
			[Address(RVA="0x17A5550", Offset="0x17A5550", VA="0x17A5550")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093800", Offset="0x1093800")]
		public RepeatedField<uint> EncountersStarted
		{
			[Address(RVA="0x17A5548", Offset="0x17A5548", VA="0x17A5548")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10937D0", Offset="0x10937D0")]
		public RepeatedField<BattleLib_UpdateResult.Types.PlayerHand> Hands
		{
			[Address(RVA="0x17A5530", Offset="0x17A5530", VA="0x17A5530")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093760", Offset="0x1093760")]
		public RepeatedField<BattleLib_UpdateResult.Types.UnitHealth> Health
		{
			[Address(RVA="0x17A54F8", Offset="0x17A54F8", VA="0x17A54F8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093850", Offset="0x1093850")]
		public RepeatedField<BattleLib_UpdateResult.Types.UnitHpDecay> HpDecay
		{
			[Address(RVA="0x17A5568", Offset="0x17A5568", VA="0x17A5568")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093890", Offset="0x1093890")]
		public BattleLib_UpdateResult.Types.KillingBlow KillingBlow
		{
			[Address(RVA="0x17A5428", Offset="0x17A5428", VA="0x17A5428")]
			get
			{
				return null;
			}
			[Address(RVA="0x17A5430", Offset="0x17A5430", VA="0x17A5430")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093770", Offset="0x1093770")]
		public RepeatedField<BattleLib_UpdateResult.Types.PlayerMana> Mana
		{
			[Address(RVA="0x17A5500", Offset="0x17A5500", VA="0x17A5500")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093820", Offset="0x1093820")]
		public RepeatedField<BattleLib_UpdateResult.Types.PlayerManaMeta> ManaMeta
		{
			[Address(RVA="0x17A5558", Offset="0x17A5558", VA="0x17A5558")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093930", Offset="0x1093930")]
		public RepeatedField<BattleLib_UpdateResult.Types.BattleMessage> Messages
		{
			[Address(RVA="0x17A55B0", Offset="0x17A55B0", VA="0x17A55B0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10936E0", Offset="0x10936E0")]
		public static MessageParser<BattleLib_UpdateResult> Parser
		{
			[Address(RVA="0x17A475C", Offset="0x17A475C", VA="0x17A475C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093700", Offset="0x1093700")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x17A48B4", Offset="0x17A48B4", VA="0x17A48B4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093910", Offset="0x1093910")]
		public BattleLib_UpdateResult.Types.PlayerTurnIdled PlayerTurnIdled
		{
			[Address(RVA="0x17A5448", Offset="0x17A5448", VA="0x17A5448")]
			get
			{
				return null;
			}
			[Address(RVA="0x17A5450", Offset="0x17A5450", VA="0x17A5450")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093730", Offset="0x1093730")]
		public RepeatedField<BattleLib_UpdateResult.Types.UnitPosition> Positions
		{
			[Address(RVA="0x17A54E0", Offset="0x17A54E0", VA="0x17A54E0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10937E0", Offset="0x10937E0")]
		public RepeatedField<BattleLib_UpdateResult.Types.Spawn> Spawns
		{
			[Address(RVA="0x17A5538", Offset="0x17A5538", VA="0x17A5538")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10938A0", Offset="0x10938A0")]
		public RepeatedField<BattleLib_UpdateResult.Types.PlayerSpellCharge> SpellCharge
		{
			[Address(RVA="0x17A5580", Offset="0x17A5580", VA="0x17A5580")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10938B0", Offset="0x10938B0")]
		public RepeatedField<BattleLib_UpdateResult.Types.SpellHand> SpellHands
		{
			[Address(RVA="0x17A5588", Offset="0x17A5588", VA="0x17A5588")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093880", Offset="0x1093880")]
		public BattleLib_UpdateResult.Types.BattleTimeLimit TimeLimit
		{
			[Address(RVA="0x17A53B8", Offset="0x17A53B8", VA="0x17A53B8")]
			get
			{
				return null;
			}
			[Address(RVA="0x17A5420", Offset="0x17A5420", VA="0x17A5420")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093920", Offset="0x1093920")]
		public BattleLib_UpdateResult.Types.BattleTurnLimit TurnLimit
		{
			[Address(RVA="0x17A5458", Offset="0x17A5458", VA="0x17A5458")]
			get
			{
				return null;
			}
			[Address(RVA="0x17A5460", Offset="0x17A5460", VA="0x17A5460")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10938C0", Offset="0x10938C0")]
		public RepeatedField<BattleLib_UpdateResult.Types.UnitEffects> UnitEffects
		{
			[Address(RVA="0x17A5590", Offset="0x17A5590", VA="0x17A5590")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10938D0", Offset="0x10938D0")]
		public RepeatedField<BattleLib_UpdateResult.Types.UnitTurnInfo> UnitTurnInfo
		{
			[Address(RVA="0x17A5598", Offset="0x17A5598", VA="0x17A5598")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10938F0", Offset="0x10938F0")]
		public BattleLib_UpdateResult.Types.UnitTurnStarted UnitTurnStarted
		{
			[Address(RVA="0x17A5438", Offset="0x17A5438", VA="0x17A5438")]
			get
			{
				return null;
			}
			[Address(RVA="0x17A5440", Offset="0x17A5440", VA="0x17A5440")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10937C0", Offset="0x10937C0")]
		public RepeatedField<BattleLib_UpdateResult.Types.UseAbilityResponse> UseAbilityResponses
		{
			[Address(RVA="0x17A5528", Offset="0x17A5528", VA="0x17A5528")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093840", Offset="0x1093840")]
		public RepeatedField<BattleLib_UpdateResult.Types.VisualAtPosition> VisualsAtPosition
		{
			[Address(RVA="0x17A5560", Offset="0x17A5560", VA="0x17A5560")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093790", Offset="0x1093790")]
		public RepeatedField<BattleLib_UpdateResult.Types.VisualInterrupt> VisualsInterrupted
		{
			[Address(RVA="0x17A5510", Offset="0x17A5510", VA="0x17A5510")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093740", Offset="0x1093740")]
		public RepeatedField<BattleLib_UpdateResult.Types.VisualOnUnit> VisualsOnUnits
		{
			[Address(RVA="0x17A54E8", Offset="0x17A54E8", VA="0x17A54E8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093750", Offset="0x1093750")]
		public RepeatedField<BattleLib_UpdateResult.Types.VisualOnWorld> VisualsOnWorld
		{
			[Address(RVA="0x17A54F0", Offset="0x17A54F0", VA="0x17A54F0")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x17A8BA4", Offset="0x17A8BA4", VA="0x17A8BA4")]
		static BattleLib_UpdateResult()
		{
		}

		[Address(RVA="0x17A4910", Offset="0x17A4910", VA="0x17A4910")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078AFC", Offset="0x1078AFC")]
		public BattleLib_UpdateResult()
		{
		}

		[Address(RVA="0x17A4DC8", Offset="0x17A4DC8", VA="0x17A4DC8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078B0C", Offset="0x1078B0C")]
		public BattleLib_UpdateResult(BattleLib_UpdateResult other)
		{
		}

		[Address(RVA="0x17A6D94", Offset="0x17A6D94", VA="0x17A6D94", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078B7C", Offset="0x1078B7C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x17A5468", Offset="0x17A5468", VA="0x17A5468", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078B1C", Offset="0x1078B1C")]
		public BattleLib_UpdateResult Clone()
		{
			return null;
		}

		[Address(RVA="0x17A55D4", Offset="0x17A55D4", VA="0x17A55D4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078B2C", Offset="0x1078B2C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x17A5648", Offset="0x17A5648", VA="0x17A5648", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078B3C", Offset="0x1078B3C")]
		public bool Equals(BattleLib_UpdateResult other)
		{
			return new bool();
		}

		[Address(RVA="0x17A5D30", Offset="0x17A5D30", VA="0x17A5D30", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078B4C", Offset="0x1078B4C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x17A7650", Offset="0x17A7650", VA="0x17A7650", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078B8C", Offset="0x1078B8C")]
		public void MergeFrom(BattleLib_UpdateResult other)
		{
		}

		[Address(RVA="0x17A7FB4", Offset="0x17A7FB4", VA="0x17A7FB4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078B9C", Offset="0x1078B9C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x17A62E0", Offset="0x17A62E0", VA="0x17A62E0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078B5C", Offset="0x1078B5C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x17A6348", Offset="0x17A6348", VA="0x17A6348", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078B6C", Offset="0x1078B6C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F3B8", Offset="0x104F3B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleLib_UpdateResult.<>c <>9;

			[Address(RVA="0x17A96A0", Offset="0x17A96A0", VA="0x17A96A0")]
			static <>c()
			{
			}

			[Address(RVA="0x17A9704", Offset="0x17A9704", VA="0x17A9704")]
			public <>c()
			{
			}

			[Address(RVA="0x17A970C", Offset="0x17A970C", VA="0x17A970C")]
			internal BattleLib_UpdateResult <.cctor>b__206_0()
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x104F3A8", Offset="0x104F3A8")]
		public static class Types
		{
			public sealed class AbilityCamera : IMessage<BattleLib_UpdateResult.Types.AbilityCamera>, IMessage, IEquatable<BattleLib_UpdateResult.Types.AbilityCamera>, IDeepCloneable<BattleLib_UpdateResult.Types.AbilityCamera>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.AbilityCamera> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int VisualIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private ulong visualId_;

				[FieldOffset(Offset="0x0")]
				public const int DurationFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private float duration_;

				[FieldOffset(Offset="0x0")]
				public const int SourceUnitIdFieldNumber = 3;

				[FieldOffset(Offset="0x24")]
				private uint sourceUnitId_;

				[FieldOffset(Offset="0x0")]
				public const int SourcePosXFieldNumber = 4;

				[FieldOffset(Offset="0x28")]
				private float sourcePosX_;

				[FieldOffset(Offset="0x0")]
				public const int SourcePosYFieldNumber = 5;

				[FieldOffset(Offset="0x2C")]
				private float sourcePosY_;

				[FieldOffset(Offset="0x0")]
				public const int TargetUnitIdFieldNumber = 6;

				[FieldOffset(Offset="0x30")]
				private uint targetUnitId_;

				[FieldOffset(Offset="0x0")]
				public const int TargetPosXFieldNumber = 7;

				[FieldOffset(Offset="0x34")]
				private float targetPosX_;

				[FieldOffset(Offset="0x0")]
				public const int TargetPosYFieldNumber = 8;

				[FieldOffset(Offset="0x38")]
				private float targetPosY_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DE38", Offset="0x109DE38")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17A9764", Offset="0x17A9764", VA="0x17A9764")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DE68", Offset="0x109DE68")]
				public float Duration
				{
					[Address(RVA="0x17A9A4C", Offset="0x17A9A4C", VA="0x17A9A4C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x17A9A54", Offset="0x17A9A54", VA="0x17A9A54")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DE28", Offset="0x109DE28")]
				public static MessageParser<BattleLib_UpdateResult.Types.AbilityCamera> Parser
				{
					[Address(RVA="0x17A9568", Offset="0x17A9568", VA="0x17A9568")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DE48", Offset="0x109DE48")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17A9850", Offset="0x17A9850", VA="0x17A9850", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DE88", Offset="0x109DE88")]
				public float SourcePosX
				{
					[Address(RVA="0x17A9A6C", Offset="0x17A9A6C", VA="0x17A9A6C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x17A9A74", Offset="0x17A9A74", VA="0x17A9A74")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DE98", Offset="0x109DE98")]
				public float SourcePosY
				{
					[Address(RVA="0x17A9A7C", Offset="0x17A9A7C", VA="0x17A9A7C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x17A9A84", Offset="0x17A9A84", VA="0x17A9A84")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DE78", Offset="0x109DE78")]
				public uint SourceUnitId
				{
					[Address(RVA="0x17A9A5C", Offset="0x17A9A5C", VA="0x17A9A5C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17A9A64", Offset="0x17A9A64", VA="0x17A9A64")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DEB8", Offset="0x109DEB8")]
				public float TargetPosX
				{
					[Address(RVA="0x17A9A9C", Offset="0x17A9A9C", VA="0x17A9A9C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x17A9AA4", Offset="0x17A9AA4", VA="0x17A9AA4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DEC8", Offset="0x109DEC8")]
				public float TargetPosY
				{
					[Address(RVA="0x17A9AAC", Offset="0x17A9AAC", VA="0x17A9AAC")]
					get
					{
						return new float();
					}
					[Address(RVA="0x17A9AB4", Offset="0x17A9AB4", VA="0x17A9AB4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DEA8", Offset="0x109DEA8")]
				public uint TargetUnitId
				{
					[Address(RVA="0x17A9A8C", Offset="0x17A9A8C", VA="0x17A9A8C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17A9A94", Offset="0x17A9A94", VA="0x17A9A94")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DE58", Offset="0x109DE58")]
				public ulong VisualId
				{
					[Address(RVA="0x17A9A3C", Offset="0x17A9A3C", VA="0x17A9A3C")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x17A9A44", Offset="0x17A9A44", VA="0x17A9A44")]
					set
					{
					}
				}

				[Address(RVA="0x17AA76C", Offset="0x17AA76C", VA="0x17AA76C")]
				static AbilityCamera()
				{
				}

				[Address(RVA="0x17A98AC", Offset="0x17A98AC", VA="0x17A98AC")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FD94", Offset="0x108FD94")]
				public AbilityCamera()
				{
				}

				[Address(RVA="0x17A98B4", Offset="0x17A98B4", VA="0x17A98B4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FDA4", Offset="0x108FDA4")]
				public AbilityCamera(BattleLib_UpdateResult.Types.AbilityCamera other)
				{
				}

				[Address(RVA="0x17AA3B8", Offset="0x17AA3B8", VA="0x17AA3B8", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FE14", Offset="0x108FE14")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17A99DC", Offset="0x17A99DC", VA="0x17A99DC", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FDB4", Offset="0x108FDB4")]
				public BattleLib_UpdateResult.Types.AbilityCamera Clone()
				{
					return null;
				}

				[Address(RVA="0x17A9ABC", Offset="0x17A9ABC", VA="0x17A9ABC", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FDC4", Offset="0x108FDC4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17A9B30", Offset="0x17A9B30", VA="0x17A9B30", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FDD4", Offset="0x108FDD4")]
				public bool Equals(BattleLib_UpdateResult.Types.AbilityCamera other)
				{
					return new bool();
				}

				[Address(RVA="0x17A9D84", Offset="0x17A9D84", VA="0x17A9D84", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FDE4", Offset="0x108FDE4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17AA518", Offset="0x17AA518", VA="0x17AA518", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FE24", Offset="0x108FE24")]
				public void MergeFrom(BattleLib_UpdateResult.Types.AbilityCamera other)
				{
				}

				[Address(RVA="0x17AA5C0", Offset="0x17AA5C0", VA="0x17AA5C0", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FE34", Offset="0x108FE34")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17AA028", Offset="0x17AA028", VA="0x17AA028", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FDF4", Offset="0x108FDF4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17AA090", Offset="0x17AA090", VA="0x17AA090", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FE04", Offset="0x108FE04")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051914", Offset="0x1051914")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.AbilityCamera.<>c <>9;

					[Address(RVA="0x17AA844", Offset="0x17AA844", VA="0x17AA844")]
					static <>c()
					{
					}

					[Address(RVA="0x17AA8A8", Offset="0x17AA8A8", VA="0x17AA8A8")]
					public <>c()
					{
					}

					[Address(RVA="0x17AA8B0", Offset="0x17AA8B0", VA="0x17AA8B0")]
					internal BattleLib_UpdateResult.Types.AbilityCamera <.cctor>b__60_0()
					{
						return null;
					}
				}
			}

			public sealed class AbilityCard : IMessage<BattleLib_UpdateResult.Types.AbilityCard>, IMessage, IEquatable<BattleLib_UpdateResult.Types.AbilityCard>, IDeepCloneable<BattleLib_UpdateResult.Types.AbilityCard>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.AbilityCard> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int SourceTypeFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint sourceType_;

				[FieldOffset(Offset="0x0")]
				public const int SourceIdFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint sourceId_;

				[FieldOffset(Offset="0x0")]
				public const int AbilityIdFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private uint abilityId_;

				[FieldOffset(Offset="0x0")]
				public const int SecondarySourceTypeFieldNumber = 4;

				[FieldOffset(Offset="0x24")]
				private uint secondarySourceType_;

				[FieldOffset(Offset="0x0")]
				public const int SecondarySourceIdFieldNumber = 5;

				[FieldOffset(Offset="0x28")]
				private uint secondarySourceId_;

				[FieldOffset(Offset="0x0")]
				public const int SecondaryAbilityIdFieldNumber = 6;

				[FieldOffset(Offset="0x2C")]
				private uint secondaryAbilityId_;

				[FieldOffset(Offset="0x0")]
				public const int AbilityImpairmentStatusFieldNumber = 7;

				[FieldOffset(Offset="0x30")]
				private uint abilityImpairmentStatus_;

				[FieldOffset(Offset="0x0")]
				public const int ManaCostFieldNumber = 8;

				[FieldOffset(Offset="0x34")]
				private uint manaCost_;

				[FieldOffset(Offset="0x0")]
				public const int AbilityImpairmentEndTimeFieldNumber = 9;

				[FieldOffset(Offset="0x38")]
				private float abilityImpairmentEndTime_;

				[FieldOffset(Offset="0x0")]
				public const int AbilityBuffStatusFieldNumber = 10;

				[FieldOffset(Offset="0x3C")]
				private uint abilityBuffStatus_;

				[FieldOffset(Offset="0x0")]
				public const int AbilityTypeFieldNumber = 11;

				[FieldOffset(Offset="0x40")]
				private uint abilityType_;

				[FieldOffset(Offset="0x0")]
				public const int PolymorphUnitDefIdFieldNumber = 12;

				[FieldOffset(Offset="0x48")]
				private ulong polymorphUnitDefId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D6B8", Offset="0x109D6B8")]
				public uint AbilityBuffStatus
				{
					[Address(RVA="0x17AAD4C", Offset="0x17AAD4C", VA="0x17AAD4C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AAD54", Offset="0x17AAD54", VA="0x17AAD54")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D648", Offset="0x109D648")]
				public uint AbilityId
				{
					[Address(RVA="0x17AACDC", Offset="0x17AACDC", VA="0x17AACDC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AACE4", Offset="0x17AACE4", VA="0x17AACE4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D6A8", Offset="0x109D6A8")]
				public float AbilityImpairmentEndTime
				{
					[Address(RVA="0x17AAD3C", Offset="0x17AAD3C", VA="0x17AAD3C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x17AAD44", Offset="0x17AAD44", VA="0x17AAD44")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D688", Offset="0x109D688")]
				public uint AbilityImpairmentStatus
				{
					[Address(RVA="0x17AAD1C", Offset="0x17AAD1C", VA="0x17AAD1C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AAD24", Offset="0x17AAD24", VA="0x17AAD24")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D6C8", Offset="0x109D6C8")]
				public uint AbilityType
				{
					[Address(RVA="0x17AAD5C", Offset="0x17AAD5C", VA="0x17AAD5C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AAD64", Offset="0x17AAD64", VA="0x17AAD64")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D608", Offset="0x109D608")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17AA974", Offset="0x17AA974", VA="0x17AA974")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D698", Offset="0x109D698")]
				public uint ManaCost
				{
					[Address(RVA="0x17AAD2C", Offset="0x17AAD2C", VA="0x17AAD2C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AAD34", Offset="0x17AAD34", VA="0x17AAD34")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D5F8", Offset="0x109D5F8")]
				public static MessageParser<BattleLib_UpdateResult.Types.AbilityCard> Parser
				{
					[Address(RVA="0x17AA90C", Offset="0x17AA90C", VA="0x17AA90C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D618", Offset="0x109D618")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17AAA60", Offset="0x17AAA60", VA="0x17AAA60", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D6D8", Offset="0x109D6D8")]
				public ulong PolymorphUnitDefId
				{
					[Address(RVA="0x17AAD6C", Offset="0x17AAD6C", VA="0x17AAD6C")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x17AAD74", Offset="0x17AAD74", VA="0x17AAD74")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D678", Offset="0x109D678")]
				public uint SecondaryAbilityId
				{
					[Address(RVA="0x17AAD0C", Offset="0x17AAD0C", VA="0x17AAD0C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AAD14", Offset="0x17AAD14", VA="0x17AAD14")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D668", Offset="0x109D668")]
				public uint SecondarySourceId
				{
					[Address(RVA="0x17AACFC", Offset="0x17AACFC", VA="0x17AACFC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AAD04", Offset="0x17AAD04", VA="0x17AAD04")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D658", Offset="0x109D658")]
				public uint SecondarySourceType
				{
					[Address(RVA="0x17AACEC", Offset="0x17AACEC", VA="0x17AACEC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AACF4", Offset="0x17AACF4", VA="0x17AACF4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D638", Offset="0x109D638")]
				public uint SourceId
				{
					[Address(RVA="0x17AACCC", Offset="0x17AACCC", VA="0x17AACCC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AACD4", Offset="0x17AACD4", VA="0x17AACD4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D628", Offset="0x109D628")]
				public uint SourceType
				{
					[Address(RVA="0x17AACBC", Offset="0x17AACBC", VA="0x17AACBC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AACC4", Offset="0x17AACC4", VA="0x17AACC4")]
					set
					{
					}
				}

				[Address(RVA="0x17ABC94", Offset="0x17ABC94", VA="0x17ABC94")]
				static AbilityCard()
				{
				}

				[Address(RVA="0x17AAABC", Offset="0x17AAABC", VA="0x17AAABC")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EFD4", Offset="0x108EFD4")]
				public AbilityCard()
				{
				}

				[Address(RVA="0x17AAAC4", Offset="0x17AAAC4", VA="0x17AAAC4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EFE4", Offset="0x108EFE4")]
				public AbilityCard(BattleLib_UpdateResult.Types.AbilityCard other)
				{
				}

				[Address(RVA="0x17AB678", Offset="0x17AB678", VA="0x17AB678", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F054", Offset="0x108F054")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17AAC5C", Offset="0x17AAC5C", VA="0x17AAC5C", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EFF4", Offset="0x108EFF4")]
				public BattleLib_UpdateResult.Types.AbilityCard Clone()
				{
					return null;
				}

				[Address(RVA="0x17AAD7C", Offset="0x17AAD7C", VA="0x17AAD7C", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F004", Offset="0x108F004")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17AADF0", Offset="0x17AADF0", VA="0x17AADF0", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F014", Offset="0x108F014")]
				public bool Equals(BattleLib_UpdateResult.Types.AbilityCard other)
				{
					return new bool();
				}

				[Address(RVA="0x17AAF84", Offset="0x17AAF84", VA="0x17AAF84", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F024", Offset="0x108F024")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17AB980", Offset="0x17AB980", VA="0x17AB980", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F064", Offset="0x108F064")]
				public void MergeFrom(BattleLib_UpdateResult.Types.AbilityCard other)
				{
				}

				[Address(RVA="0x17ABA48", Offset="0x17ABA48", VA="0x17ABA48", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F074", Offset="0x108F074")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17AB198", Offset="0x17AB198", VA="0x17AB198", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F034", Offset="0x108F034")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17AB200", Offset="0x17AB200", VA="0x17AB200", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F044", Offset="0x108F044")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10517C4", Offset="0x10517C4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.AbilityCard.<>c <>9;

					[Address(RVA="0x17ABD6C", Offset="0x17ABD6C", VA="0x17ABD6C")]
					static <>c()
					{
					}

					[Address(RVA="0x17ABDD0", Offset="0x17ABDD0", VA="0x17ABDD0")]
					public <>c()
					{
					}

					[Address(RVA="0x17ABDD8", Offset="0x17ABDD8", VA="0x17ABDD8")]
					internal BattleLib_UpdateResult.Types.AbilityCard <.cctor>b__80_0()
					{
						return null;
					}
				}
			}

			public sealed class Aura : IMessage<BattleLib_UpdateResult.Types.Aura>, IMessage, IEquatable<BattleLib_UpdateResult.Types.Aura>, IDeepCloneable<BattleLib_UpdateResult.Types.Aura>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.Aura> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int PlayerIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint playerId_;

				[FieldOffset(Offset="0x0")]
				public const int AuraContentIdFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private ulong auraContentId_;

				[FieldOffset(Offset="0x0")]
				public const int UnitContentIdFieldNumber = 3;

				[FieldOffset(Offset="0x28")]
				private ulong unitContentId_;

				[FieldOffset(Offset="0x0")]
				public const int AbilityIdFieldNumber = 4;

				[FieldOffset(Offset="0x30")]
				private uint abilityId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DF78", Offset="0x109DF78")]
				public uint AbilityId
				{
					[Address(RVA="0x17AC0CC", Offset="0x17AC0CC", VA="0x17AC0CC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AC0D4", Offset="0x17AC0D4", VA="0x17AC0D4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DF58", Offset="0x109DF58")]
				public ulong AuraContentId
				{
					[Address(RVA="0x17AC0AC", Offset="0x17AC0AC", VA="0x17AC0AC")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x17AC0B4", Offset="0x17AC0B4", VA="0x17AC0B4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DF28", Offset="0x109DF28")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17ABE34", Offset="0x17ABE34", VA="0x17ABE34")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DF18", Offset="0x109DF18")]
				public static MessageParser<BattleLib_UpdateResult.Types.Aura> Parser
				{
					[Address(RVA="0x17A9638", Offset="0x17A9638", VA="0x17A9638")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DF38", Offset="0x109DF38")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17ABF20", Offset="0x17ABF20", VA="0x17ABF20", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DF48", Offset="0x109DF48")]
				public uint PlayerId
				{
					[Address(RVA="0x17AC09C", Offset="0x17AC09C", VA="0x17AC09C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AC0A4", Offset="0x17AC0A4", VA="0x17AC0A4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DF68", Offset="0x109DF68")]
				public ulong UnitContentId
				{
					[Address(RVA="0x17AC0BC", Offset="0x17AC0BC", VA="0x17AC0BC")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x17AC0C4", Offset="0x17AC0C4", VA="0x17AC0C4")]
					set
					{
					}
				}

				[Address(RVA="0x17AC738", Offset="0x17AC738", VA="0x17AC738")]
				static Aura()
				{
				}

				[Address(RVA="0x17ABF7C", Offset="0x17ABF7C", VA="0x17ABF7C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FEF4", Offset="0x108FEF4")]
				public Aura()
				{
				}

				[Address(RVA="0x17ABF84", Offset="0x17ABF84", VA="0x17ABF84")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FF04", Offset="0x108FF04")]
				public Aura(BattleLib_UpdateResult.Types.Aura other)
				{
				}

				[Address(RVA="0x17AC48C", Offset="0x17AC48C", VA="0x17AC48C", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FF74", Offset="0x108FF74")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17AC03C", Offset="0x17AC03C", VA="0x17AC03C", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FF14", Offset="0x108FF14")]
				public BattleLib_UpdateResult.Types.Aura Clone()
				{
					return null;
				}

				[Address(RVA="0x17AC0DC", Offset="0x17AC0DC", VA="0x17AC0DC", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FF24", Offset="0x108FF24")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17AC150", Offset="0x17AC150", VA="0x17AC150", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FF34", Offset="0x108FF34")]
				public bool Equals(BattleLib_UpdateResult.Types.Aura other)
				{
					return new bool();
				}

				[Address(RVA="0x17AC1BC", Offset="0x17AC1BC", VA="0x17AC1BC", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FF44", Offset="0x108FF44")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17AC5D8", Offset="0x17AC5D8", VA="0x17AC5D8", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FF84", Offset="0x108FF84")]
				public void MergeFrom(BattleLib_UpdateResult.Types.Aura other)
				{
				}

				[Address(RVA="0x17AC63C", Offset="0x17AC63C", VA="0x17AC63C", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FF94", Offset="0x108FF94")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17AC27C", Offset="0x17AC27C", VA="0x17AC27C", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FF54", Offset="0x108FF54")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17AC2E4", Offset="0x17AC2E4", VA="0x17AC2E4", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FF64", Offset="0x108FF64")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051934", Offset="0x1051934")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.Aura.<>c <>9;

					[Address(RVA="0x17AC810", Offset="0x17AC810", VA="0x17AC810")]
					static <>c()
					{
					}

					[Address(RVA="0x17AC874", Offset="0x17AC874", VA="0x17AC874")]
					public <>c()
					{
					}

					[Address(RVA="0x17AC87C", Offset="0x17AC87C", VA="0x17AC87C")]
					internal BattleLib_UpdateResult.Types.Aura <.cctor>b__40_0()
					{
						return null;
					}
				}
			}

			public sealed class AutoAttackTargetChange : IMessage<BattleLib_UpdateResult.Types.AutoAttackTargetChange>, IMessage, IEquatable<BattleLib_UpdateResult.Types.AutoAttackTargetChange>, IDeepCloneable<BattleLib_UpdateResult.Types.AutoAttackTargetChange>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.AutoAttackTargetChange> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int UnitIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint unitId_;

				[FieldOffset(Offset="0x0")]
				public const int TargetUnitIdFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint targetUnitId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DAC8", Offset="0x109DAC8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17AC8D8", Offset="0x17AC8D8", VA="0x17AC8D8")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DAB8", Offset="0x109DAB8")]
				public static MessageParser<BattleLib_UpdateResult.Types.AutoAttackTargetChange> Parser
				{
					[Address(RVA="0x17A9430", Offset="0x17A9430", VA="0x17A9430")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DAD8", Offset="0x109DAD8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17AC9C4", Offset="0x17AC9C4", VA="0x17AC9C4", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DAF8", Offset="0x109DAF8")]
				public uint TargetUnitId
				{
					[Address(RVA="0x17ACB18", Offset="0x17ACB18", VA="0x17ACB18")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17ACB20", Offset="0x17ACB20", VA="0x17ACB20")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DAE8", Offset="0x109DAE8")]
				public uint UnitId
				{
					[Address(RVA="0x17ACB08", Offset="0x17ACB08", VA="0x17ACB08")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17ACB10", Offset="0x17ACB10", VA="0x17ACB10")]
					set
					{
					}
				}

				[Address(RVA="0x17ACF90", Offset="0x17ACF90", VA="0x17ACF90")]
				static AutoAttackTargetChange()
				{
				}

				[Address(RVA="0x17ACA20", Offset="0x17ACA20", VA="0x17ACA20")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F6B4", Offset="0x108F6B4")]
				public AutoAttackTargetChange()
				{
				}

				[Address(RVA="0x17ACA28", Offset="0x17ACA28", VA="0x17ACA28")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F6C4", Offset="0x108F6C4")]
				public AutoAttackTargetChange(BattleLib_UpdateResult.Types.AutoAttackTargetChange other)
				{
				}

				[Address(RVA="0x17ACDCC", Offset="0x17ACDCC", VA="0x17ACDCC", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F734", Offset="0x108F734")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17ACAA8", Offset="0x17ACAA8", VA="0x17ACAA8", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F6D4", Offset="0x108F6D4")]
				public BattleLib_UpdateResult.Types.AutoAttackTargetChange Clone()
				{
					return null;
				}

				[Address(RVA="0x17ACB28", Offset="0x17ACB28", VA="0x17ACB28", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F6E4", Offset="0x108F6E4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17ACB9C", Offset="0x17ACB9C", VA="0x17ACB9C", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F6F4", Offset="0x108F6F4")]
				public bool Equals(BattleLib_UpdateResult.Types.AutoAttackTargetChange other)
				{
					return new bool();
				}

				[Address(RVA="0x17ACBE8", Offset="0x17ACBE8", VA="0x17ACBE8", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F704", Offset="0x108F704")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17ACEA0", Offset="0x17ACEA0", VA="0x17ACEA0", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F744", Offset="0x108F744")]
				public void MergeFrom(BattleLib_UpdateResult.Types.AutoAttackTargetChange other)
				{
				}

				[Address(RVA="0x17ACEEC", Offset="0x17ACEEC", VA="0x17ACEEC", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F754", Offset="0x108F754")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17ACC6C", Offset="0x17ACC6C", VA="0x17ACC6C", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F714", Offset="0x108F714")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17ACCD4", Offset="0x17ACCD4", VA="0x17ACCD4", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F724", Offset="0x108F724")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051874", Offset="0x1051874")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.AutoAttackTargetChange.<>c <>9;

					[Address(RVA="0x17AD068", Offset="0x17AD068", VA="0x17AD068")]
					static <>c()
					{
					}

					[Address(RVA="0x17AD0CC", Offset="0x17AD0CC", VA="0x17AD0CC")]
					public <>c()
					{
					}

					[Address(RVA="0x17AD0D4", Offset="0x17AD0D4", VA="0x17AD0D4")]
					internal BattleLib_UpdateResult.Types.AutoAttackTargetChange <.cctor>b__30_0()
					{
						return null;
					}
				}
			}

			public sealed class BattleActivityUpdate : IMessage<BattleLib_UpdateResult.Types.BattleActivityUpdate>, IMessage, IEquatable<BattleLib_UpdateResult.Types.BattleActivityUpdate>, IDeepCloneable<BattleLib_UpdateResult.Types.BattleActivityUpdate>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.BattleActivityUpdate> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int PlayerIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint playerId_;

				[FieldOffset(Offset="0x0")]
				public const int ActivityIdFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private ulong activityId_;

				[FieldOffset(Offset="0x0")]
				public const int ValueFieldNumber = 3;

				[FieldOffset(Offset="0x28")]
				private ulong value_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DB48", Offset="0x109DB48")]
				public ulong ActivityId
				{
					[Address(RVA="0x17AD38C", Offset="0x17AD38C", VA="0x17AD38C")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x17AD394", Offset="0x17AD394", VA="0x17AD394")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DB18", Offset="0x109DB18")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17AD130", Offset="0x17AD130", VA="0x17AD130")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DB08", Offset="0x109DB08")]
				public static MessageParser<BattleLib_UpdateResult.Types.BattleActivityUpdate> Parser
				{
					[Address(RVA="0x17A9498", Offset="0x17A9498", VA="0x17A9498")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DB28", Offset="0x109DB28")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17AD21C", Offset="0x17AD21C", VA="0x17AD21C", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DB38", Offset="0x109DB38")]
				public uint PlayerId
				{
					[Address(RVA="0x17AD37C", Offset="0x17AD37C", VA="0x17AD37C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AD384", Offset="0x17AD384", VA="0x17AD384")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DB58", Offset="0x109DB58")]
				public ulong Value
				{
					[Address(RVA="0x17AD39C", Offset="0x17AD39C", VA="0x17AD39C")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x17AD3A4", Offset="0x17AD3A4", VA="0x17AD3A4")]
					set
					{
					}
				}

				[Address(RVA="0x17AD918", Offset="0x17AD918", VA="0x17AD918")]
				static BattleActivityUpdate()
				{
				}

				[Address(RVA="0x17AD278", Offset="0x17AD278", VA="0x17AD278")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F764", Offset="0x108F764")]
				public BattleActivityUpdate()
				{
				}

				[Address(RVA="0x17AD280", Offset="0x17AD280", VA="0x17AD280")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F774", Offset="0x108F774")]
				public BattleActivityUpdate(BattleLib_UpdateResult.Types.BattleActivityUpdate other)
				{
				}

				[Address(RVA="0x17AD6D8", Offset="0x17AD6D8", VA="0x17AD6D8", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F7E4", Offset="0x108F7E4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17AD31C", Offset="0x17AD31C", VA="0x17AD31C", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F784", Offset="0x108F784")]
				public BattleLib_UpdateResult.Types.BattleActivityUpdate Clone()
				{
					return null;
				}

				[Address(RVA="0x17AD3AC", Offset="0x17AD3AC", VA="0x17AD3AC", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F794", Offset="0x108F794")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17AD420", Offset="0x17AD420", VA="0x17AD420", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F7A4", Offset="0x108F7A4")]
				public bool Equals(BattleLib_UpdateResult.Types.BattleActivityUpdate other)
				{
					return new bool();
				}

				[Address(RVA="0x17AD47C", Offset="0x17AD47C", VA="0x17AD47C", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F7B4", Offset="0x108F7B4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17AD7E8", Offset="0x17AD7E8", VA="0x17AD7E8", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F7F4", Offset="0x108F7F4")]
				public void MergeFrom(BattleLib_UpdateResult.Types.BattleActivityUpdate other)
				{
				}

				[Address(RVA="0x17AD840", Offset="0x17AD840", VA="0x17AD840", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F804", Offset="0x108F804")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17AD520", Offset="0x17AD520", VA="0x17AD520", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F7C4", Offset="0x108F7C4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17AD588", Offset="0x17AD588", VA="0x17AD588", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F7D4", Offset="0x108F7D4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051884", Offset="0x1051884")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.BattleActivityUpdate.<>c <>9;

					[Address(RVA="0x17AD9F0", Offset="0x17AD9F0", VA="0x17AD9F0")]
					static <>c()
					{
					}

					[Address(RVA="0x17ADA54", Offset="0x17ADA54", VA="0x17ADA54")]
					public <>c()
					{
					}

					[Address(RVA="0x17ADA5C", Offset="0x17ADA5C", VA="0x17ADA5C")]
					internal BattleLib_UpdateResult.Types.BattleActivityUpdate <.cctor>b__35_0()
					{
						return null;
					}
				}
			}

			public sealed class BattleEmote : IMessage<BattleLib_UpdateResult.Types.BattleEmote>, IMessage, IEquatable<BattleLib_UpdateResult.Types.BattleEmote>, IDeepCloneable<BattleLib_UpdateResult.Types.BattleEmote>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.BattleEmote> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int PlayerIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint playerId_;

				[FieldOffset(Offset="0x0")]
				public const int EmoteIdFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private ulong emoteId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DB78", Offset="0x109DB78")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17ADAB8", Offset="0x17ADAB8", VA="0x17ADAB8")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DBA8", Offset="0x109DBA8")]
				public ulong EmoteId
				{
					[Address(RVA="0x17ADCF8", Offset="0x17ADCF8", VA="0x17ADCF8")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x17ADD00", Offset="0x17ADD00", VA="0x17ADD00")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DB68", Offset="0x109DB68")]
				public static MessageParser<BattleLib_UpdateResult.Types.BattleEmote> Parser
				{
					[Address(RVA="0x17A9500", Offset="0x17A9500", VA="0x17A9500")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DB88", Offset="0x109DB88")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17ADBA4", Offset="0x17ADBA4", VA="0x17ADBA4", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DB98", Offset="0x109DB98")]
				public uint PlayerId
				{
					[Address(RVA="0x17ADCE8", Offset="0x17ADCE8", VA="0x17ADCE8")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17ADCF0", Offset="0x17ADCF0", VA="0x17ADCF0")]
					set
					{
					}
				}

				[Address(RVA="0x17AE174", Offset="0x17AE174", VA="0x17AE174")]
				static BattleEmote()
				{
				}

				[Address(RVA="0x17ADC00", Offset="0x17ADC00", VA="0x17ADC00")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F814", Offset="0x108F814")]
				public BattleEmote()
				{
				}

				[Address(RVA="0x17ADC08", Offset="0x17ADC08", VA="0x17ADC08")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F824", Offset="0x108F824")]
				public BattleEmote(BattleLib_UpdateResult.Types.BattleEmote other)
				{
				}

				[Address(RVA="0x17ADFB0", Offset="0x17ADFB0", VA="0x17ADFB0", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F894", Offset="0x108F894")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17ADC88", Offset="0x17ADC88", VA="0x17ADC88", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F834", Offset="0x108F834")]
				public BattleLib_UpdateResult.Types.BattleEmote Clone()
				{
					return null;
				}

				[Address(RVA="0x17ADD08", Offset="0x17ADD08", VA="0x17ADD08", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F844", Offset="0x108F844")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17ADD7C", Offset="0x17ADD7C", VA="0x17ADD7C", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F854", Offset="0x108F854")]
				public bool Equals(BattleLib_UpdateResult.Types.BattleEmote other)
				{
					return new bool();
				}

				[Address(RVA="0x17ADDC8", Offset="0x17ADDC8", VA="0x17ADDC8", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F864", Offset="0x108F864")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17AE084", Offset="0x17AE084", VA="0x17AE084", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F8A4", Offset="0x108F8A4")]
				public void MergeFrom(BattleLib_UpdateResult.Types.BattleEmote other)
				{
				}

				[Address(RVA="0x17AE0D0", Offset="0x17AE0D0", VA="0x17AE0D0", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F8B4", Offset="0x108F8B4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17ADE50", Offset="0x17ADE50", VA="0x17ADE50", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F874", Offset="0x108F874")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17ADEB8", Offset="0x17ADEB8", VA="0x17ADEB8", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F884", Offset="0x108F884")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051894", Offset="0x1051894")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.BattleEmote.<>c <>9;

					[Address(RVA="0x17AE24C", Offset="0x17AE24C", VA="0x17AE24C")]
					static <>c()
					{
					}

					[Address(RVA="0x17AE2B0", Offset="0x17AE2B0", VA="0x17AE2B0")]
					public <>c()
					{
					}

					[Address(RVA="0x17AE2B8", Offset="0x17AE2B8", VA="0x17AE2B8")]
					internal BattleLib_UpdateResult.Types.BattleEmote <.cctor>b__30_0()
					{
						return null;
					}
				}
			}

			public sealed class BattleEnded : IMessage<BattleLib_UpdateResult.Types.BattleEnded>, IMessage, IEquatable<BattleLib_UpdateResult.Types.BattleEnded>, IDeepCloneable<BattleLib_UpdateResult.Types.BattleEnded>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.BattleEnded> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int WinningTeamFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private int winningTeam_;

				[FieldOffset(Offset="0x0")]
				public const int UnitResultsFieldNumber = 2;

				[FieldOffset(Offset="0x8")]
				private readonly static FieldCodec<BattleLib_UpdateResult.Types.UnitResult> _repeated_unitResults_codec;

				[FieldOffset(Offset="0x20")]
				private readonly RepeatedField<BattleLib_UpdateResult.Types.UnitResult> unitResults_;

				[FieldOffset(Offset="0x0")]
				public const int PlayerResultsFieldNumber = 3;

				[FieldOffset(Offset="0x10")]
				private readonly static FieldCodec<BattleLib_UpdateResult.Types.PlayerResult> _repeated_playerResults_codec;

				[FieldOffset(Offset="0x28")]
				private readonly RepeatedField<BattleLib_UpdateResult.Types.PlayerResult> playerResults_;

				[FieldOffset(Offset="0x0")]
				public const int TeamResultsFieldNumber = 4;

				[FieldOffset(Offset="0x18")]
				private readonly static FieldCodec<BattleLib_UpdateResult.Types.TeamResult> _repeated_teamResults_codec;

				[FieldOffset(Offset="0x30")]
				private readonly RepeatedField<BattleLib_UpdateResult.Types.TeamResult> teamResults_;

				[FieldOffset(Offset="0x0")]
				public const int ReasonFieldNumber = 5;

				[FieldOffset(Offset="0x38")]
				private BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D168", Offset="0x109D168")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17AE37C", Offset="0x17AE37C", VA="0x17AE37C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D158", Offset="0x109D158")]
				public static MessageParser<BattleLib_UpdateResult.Types.BattleEnded> Parser
				{
					[Address(RVA="0x17AE314", Offset="0x17AE314", VA="0x17AE314")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D178", Offset="0x109D178")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17AE468", Offset="0x17AE468", VA="0x17AE468", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D1A8", Offset="0x109D1A8")]
				public RepeatedField<BattleLib_UpdateResult.Types.PlayerResult> PlayerResults
				{
					[Address(RVA="0x17AE5EC", Offset="0x17AE5EC", VA="0x17AE5EC")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D1C8", Offset="0x109D1C8")]
				public BattleLib_UpdateResult.Types.BattleEnded.Types.Reason Reason
				{
					[Address(RVA="0x17AE5FC", Offset="0x17AE5FC", VA="0x17AE5FC")]
					get
					{
						return new BattleLib_UpdateResult.Types.BattleEnded.Types.Reason();
					}
					[Address(RVA="0x17AE604", Offset="0x17AE604", VA="0x17AE604")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D1B8", Offset="0x109D1B8")]
				public RepeatedField<BattleLib_UpdateResult.Types.TeamResult> TeamResults
				{
					[Address(RVA="0x17AE5F4", Offset="0x17AE5F4", VA="0x17AE5F4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D198", Offset="0x109D198")]
				public RepeatedField<BattleLib_UpdateResult.Types.UnitResult> UnitResults
				{
					[Address(RVA="0x17AE5E4", Offset="0x17AE5E4", VA="0x17AE5E4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D188", Offset="0x109D188")]
				public int WinningTeam
				{
					[Address(RVA="0x17AE5D4", Offset="0x17AE5D4", VA="0x17AE5D4")]
					get
					{
						return new int();
					}
					[Address(RVA="0x17AE5DC", Offset="0x17AE5DC", VA="0x17AE5DC")]
					set
					{
					}
				}

				[Address(RVA="0x17AEE80", Offset="0x17AEE80", VA="0x17AEE80")]
				static BattleEnded()
				{
				}

				[Address(RVA="0x17A7D98", Offset="0x17A7D98", VA="0x17A7D98")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E8F4", Offset="0x108E8F4")]
				public BattleEnded()
				{
				}

				[Address(RVA="0x17AE4C4", Offset="0x17AE4C4", VA="0x17AE4C4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E904", Offset="0x108E904")]
				public BattleEnded(BattleLib_UpdateResult.Types.BattleEnded other)
				{
				}

				[Address(RVA="0x17AEAF8", Offset="0x17AEAF8", VA="0x17AEAF8", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E974", Offset="0x108E974")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17A5350", Offset="0x17A5350", VA="0x17A5350", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E914", Offset="0x108E914")]
				public BattleLib_UpdateResult.Types.BattleEnded Clone()
				{
					return null;
				}

				[Address(RVA="0x17AE60C", Offset="0x17AE60C", VA="0x17AE60C", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E924", Offset="0x108E924")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17AE680", Offset="0x17AE680", VA="0x17AE680", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E934", Offset="0x108E934")]
				public bool Equals(BattleLib_UpdateResult.Types.BattleEnded other)
				{
					return new bool();
				}

				[Address(RVA="0x17AE7B0", Offset="0x17AE7B0", VA="0x17AE7B0", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E944", Offset="0x108E944")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17A7E58", Offset="0x17A7E58", VA="0x17A7E58", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E984", Offset="0x108E984")]
				public void MergeFrom(BattleLib_UpdateResult.Types.BattleEnded other)
				{
				}

				[Address(RVA="0x17AECA4", Offset="0x17AECA4", VA="0x17AECA4", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E994", Offset="0x108E994")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17AE8A0", Offset="0x17AE8A0", VA="0x17AE8A0", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E954", Offset="0x108E954")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17AE908", Offset="0x17AE908", VA="0x17AE908", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E964", Offset="0x108E964")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051714", Offset="0x1051714")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.BattleEnded.<>c <>9;

					[Address(RVA="0x17AF03C", Offset="0x17AF03C", VA="0x17AF03C")]
					static <>c()
					{
					}

					[Address(RVA="0x17AF0A0", Offset="0x17AF0A0", VA="0x17AF0A0")]
					public <>c()
					{
					}

					[Address(RVA="0x17AF0A8", Offset="0x17AF0A8", VA="0x17AF0A8")]
					internal BattleLib_UpdateResult.Types.BattleEnded <.cctor>b__46_0()
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1051704", Offset="0x1051704")]
				public static class Types
				{
					public enum Reason
					{
						[Attribute(Name="OriginalNameAttribute", RVA="0x106D9B0", Offset="0x106D9B0")]
						[FieldOffset(Offset="0x0")]
						Invalid,
						[Attribute(Name="OriginalNameAttribute", RVA="0x106D9E8", Offset="0x106D9E8")]
						[FieldOffset(Offset="0x0")]
						Default,
						[Attribute(Name="OriginalNameAttribute", RVA="0x106DA20", Offset="0x106DA20")]
						[FieldOffset(Offset="0x0")]
						TurnLimitReached,
						[Attribute(Name="OriginalNameAttribute", RVA="0x106DA58", Offset="0x106DA58")]
						[FieldOffset(Offset="0x0")]
						AllyDied
					}
				}
			}

			public sealed class BattleMessage : IMessage<BattleLib_UpdateResult.Types.BattleMessage>, IMessage, IEquatable<BattleLib_UpdateResult.Types.BattleMessage>, IDeepCloneable<BattleLib_UpdateResult.Types.BattleMessage>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.BattleMessage> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int ContentIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private ulong contentId_;

				[FieldOffset(Offset="0x0")]
				public const int PointAtUnitIdFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private uint pointAtUnitId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DFB8", Offset="0x109DFB8")]
				public ulong ContentId
				{
					[Address(RVA="0x17AF330", Offset="0x17AF330", VA="0x17AF330")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x17AF338", Offset="0x17AF338", VA="0x17AF338")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DF98", Offset="0x109DF98")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17AF100", Offset="0x17AF100", VA="0x17AF100")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DF88", Offset="0x109DF88")]
				public static MessageParser<BattleLib_UpdateResult.Types.BattleMessage> Parser
				{
					[Address(RVA="0x17A95D0", Offset="0x17A95D0", VA="0x17A95D0")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DFA8", Offset="0x109DFA8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17AF1EC", Offset="0x17AF1EC", VA="0x17AF1EC", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DFC8", Offset="0x109DFC8")]
				public uint PointAtUnitId
				{
					[Address(RVA="0x17AF340", Offset="0x17AF340", VA="0x17AF340")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17AF348", Offset="0x17AF348", VA="0x17AF348")]
					set
					{
					}
				}

				[Address(RVA="0x17AF7BC", Offset="0x17AF7BC", VA="0x17AF7BC")]
				static BattleMessage()
				{
				}

				[Address(RVA="0x17AF248", Offset="0x17AF248", VA="0x17AF248")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FFA4", Offset="0x108FFA4")]
				public BattleMessage()
				{
				}

				[Address(RVA="0x17AF250", Offset="0x17AF250", VA="0x17AF250")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FFB4", Offset="0x108FFB4")]
				public BattleMessage(BattleLib_UpdateResult.Types.BattleMessage other)
				{
				}

				[Address(RVA="0x17AF5F8", Offset="0x17AF5F8", VA="0x17AF5F8", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090024", Offset="0x1090024")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17AF2D0", Offset="0x17AF2D0", VA="0x17AF2D0", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FFC4", Offset="0x108FFC4")]
				public BattleLib_UpdateResult.Types.BattleMessage Clone()
				{
					return null;
				}

				[Address(RVA="0x17AF350", Offset="0x17AF350", VA="0x17AF350", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FFD4", Offset="0x108FFD4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17AF3C4", Offset="0x17AF3C4", VA="0x17AF3C4", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FFE4", Offset="0x108FFE4")]
				public bool Equals(BattleLib_UpdateResult.Types.BattleMessage other)
				{
					return new bool();
				}

				[Address(RVA="0x17AF410", Offset="0x17AF410", VA="0x17AF410", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FFF4", Offset="0x108FFF4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17AF6CC", Offset="0x17AF6CC", VA="0x17AF6CC", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090034", Offset="0x1090034")]
				public void MergeFrom(BattleLib_UpdateResult.Types.BattleMessage other)
				{
				}

				[Address(RVA="0x17AF718", Offset="0x17AF718", VA="0x17AF718", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090044", Offset="0x1090044")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17AF498", Offset="0x17AF498", VA="0x17AF498", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090004", Offset="0x1090004")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17AF500", Offset="0x17AF500", VA="0x17AF500", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090014", Offset="0x1090014")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051944", Offset="0x1051944")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.BattleMessage.<>c <>9;

					[Address(RVA="0x17AF894", Offset="0x17AF894", VA="0x17AF894")]
					static <>c()
					{
					}

					[Address(RVA="0x17AF8F8", Offset="0x17AF8F8", VA="0x17AF8F8")]
					public <>c()
					{
					}

					[Address(RVA="0x17AF900", Offset="0x17AF900", VA="0x17AF900")]
					internal BattleLib_UpdateResult.Types.BattleMessage <.cctor>b__30_0()
					{
						return null;
					}
				}
			}

			public sealed class BattleTimeLimit : IMessage<BattleLib_UpdateResult.Types.BattleTimeLimit>, IMessage, IEquatable<BattleLib_UpdateResult.Types.BattleTimeLimit>, IDeepCloneable<BattleLib_UpdateResult.Types.BattleTimeLimit>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.BattleTimeLimit> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int TimeLimitSFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private float timeLimitS_;

				[FieldOffset(Offset="0x0")]
				public const int OvertimeBeginSFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private float overtimeBeginS_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DBC8", Offset="0x109DBC8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17AF9C4", Offset="0x17AF9C4", VA="0x17AF9C4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DBF8", Offset="0x109DBF8")]
				public float OvertimeBeginS
				{
					[Address(RVA="0x17AFB9C", Offset="0x17AFB9C", VA="0x17AFB9C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x17AFBA4", Offset="0x17AFBA4", VA="0x17AFBA4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DBB8", Offset="0x109DBB8")]
				public static MessageParser<BattleLib_UpdateResult.Types.BattleTimeLimit> Parser
				{
					[Address(RVA="0x17AF95C", Offset="0x17AF95C", VA="0x17AF95C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DBD8", Offset="0x109DBD8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17AFAB0", Offset="0x17AFAB0", VA="0x17AFAB0", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DBE8", Offset="0x109DBE8")]
				public float TimeLimitS
				{
					[Address(RVA="0x17AFB8C", Offset="0x17AFB8C", VA="0x17AFB8C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x17AFB94", Offset="0x17AFB94", VA="0x17AFB94")]
					set
					{
					}
				}

				[Address(RVA="0x17B00D8", Offset="0x17B00D8", VA="0x17B00D8")]
				static BattleTimeLimit()
				{
				}

				[Address(RVA="0x17A7F58", Offset="0x17A7F58", VA="0x17A7F58")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F8C4", Offset="0x108F8C4")]
				public BattleTimeLimit()
				{
				}

				[Address(RVA="0x17AFB0C", Offset="0x17AFB0C", VA="0x17AFB0C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F8D4", Offset="0x108F8D4")]
				public BattleTimeLimit(BattleLib_UpdateResult.Types.BattleTimeLimit other)
				{
				}

				[Address(RVA="0x17AFFE8", Offset="0x17AFFE8", VA="0x17AFFE8", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F944", Offset="0x108F944")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17A53C0", Offset="0x17A53C0", VA="0x17A53C0", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F8E4", Offset="0x108F8E4")]
				public BattleLib_UpdateResult.Types.BattleTimeLimit Clone()
				{
					return null;
				}

				[Address(RVA="0x17AFBAC", Offset="0x17AFBAC", VA="0x17AFBAC", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F8F4", Offset="0x108F8F4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17AFC20", Offset="0x17AFC20", VA="0x17AFC20", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F904", Offset="0x108F904")]
				public bool Equals(BattleLib_UpdateResult.Types.BattleTimeLimit other)
				{
					return new bool();
				}

				[Address(RVA="0x17AFD54", Offset="0x17AFD54", VA="0x17AFD54", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F914", Offset="0x108F914")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17A7F60", Offset="0x17A7F60", VA="0x17A7F60", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F954", Offset="0x108F954")]
				public void MergeFrom(BattleLib_UpdateResult.Types.BattleTimeLimit other)
				{
				}

				[Address(RVA="0x17B0034", Offset="0x17B0034", VA="0x17B0034", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F964", Offset="0x108F964")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17AFE80", Offset="0x17AFE80", VA="0x17AFE80", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F924", Offset="0x108F924")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17AFEE8", Offset="0x17AFEE8", VA="0x17AFEE8", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F934", Offset="0x108F934")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10518A4", Offset="0x10518A4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.BattleTimeLimit.<>c <>9;

					[Address(RVA="0x2027768", Offset="0x2027768", VA="0x2027768")]
					static <>c()
					{
					}

					[Address(RVA="0x20277CC", Offset="0x20277CC", VA="0x20277CC")]
					public <>c()
					{
					}

					[Address(RVA="0x20277D4", Offset="0x20277D4", VA="0x20277D4")]
					internal BattleLib_UpdateResult.Types.BattleTimeLimit <.cctor>b__30_0()
					{
						return null;
					}
				}
			}

			public sealed class BattleTurnLimit : IMessage<BattleLib_UpdateResult.Types.BattleTurnLimit>, IMessage, IEquatable<BattleLib_UpdateResult.Types.BattleTurnLimit>, IDeepCloneable<BattleLib_UpdateResult.Types.BattleTurnLimit>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.BattleTurnLimit> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int TurnsLeftFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint turnsLeft_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DC18", Offset="0x109DC18")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x2027898", Offset="0x2027898", VA="0x2027898")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DC08", Offset="0x109DC08")]
				public static MessageParser<BattleLib_UpdateResult.Types.BattleTurnLimit> Parser
				{
					[Address(RVA="0x2027830", Offset="0x2027830", VA="0x2027830")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DC28", Offset="0x109DC28")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x2027988", Offset="0x2027988", VA="0x2027988", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DC38", Offset="0x109DC38")]
				public uint TurnsLeft
				{
					[Address(RVA="0x2027AB0", Offset="0x2027AB0", VA="0x2027AB0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2027AB8", Offset="0x2027AB8", VA="0x2027AB8")]
					set
					{
					}
				}

				[Address(RVA="0x2027E2C", Offset="0x2027E2C", VA="0x2027E2C")]
				static BattleTurnLimit()
				{
				}

				[Address(RVA="0x20279E4", Offset="0x20279E4", VA="0x20279E4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F974", Offset="0x108F974")]
				public BattleTurnLimit()
				{
				}

				[Address(RVA="0x20279EC", Offset="0x20279EC", VA="0x20279EC")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F984", Offset="0x108F984")]
				public BattleTurnLimit(BattleLib_UpdateResult.Types.BattleTurnLimit other)
				{
				}

				[Address(RVA="0x2027CE0", Offset="0x2027CE0", VA="0x2027CE0", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F9F4", Offset="0x108F9F4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2027A50", Offset="0x2027A50", VA="0x2027A50", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F994", Offset="0x108F994")]
				public BattleLib_UpdateResult.Types.BattleTurnLimit Clone()
				{
					return null;
				}

				[Address(RVA="0x2027AC0", Offset="0x2027AC0", VA="0x2027AC0", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F9A4", Offset="0x108F9A4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2027B34", Offset="0x2027B34", VA="0x2027B34", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F9B4", Offset="0x108F9B4")]
				public bool Equals(BattleLib_UpdateResult.Types.BattleTurnLimit other)
				{
					return new bool();
				}

				[Address(RVA="0x2027B70", Offset="0x2027B70", VA="0x2027B70", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F9C4", Offset="0x108F9C4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x2027D70", Offset="0x2027D70", VA="0x2027D70", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FA04", Offset="0x108FA04")]
				public void MergeFrom(BattleLib_UpdateResult.Types.BattleTurnLimit other)
				{
				}

				[Address(RVA="0x2027DB0", Offset="0x2027DB0", VA="0x2027DB0", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FA14", Offset="0x108FA14")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x2027BD8", Offset="0x2027BD8", VA="0x2027BD8", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F9D4", Offset="0x108F9D4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x2027C40", Offset="0x2027C40", VA="0x2027C40", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F9E4", Offset="0x108F9E4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10518B4", Offset="0x10518B4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.BattleTurnLimit.<>c <>9;

					[Address(RVA="0x2027F04", Offset="0x2027F04", VA="0x2027F04")]
					static <>c()
					{
					}

					[Address(RVA="0x2027F68", Offset="0x2027F68", VA="0x2027F68")]
					public <>c()
					{
					}

					[Address(RVA="0x2027F70", Offset="0x2027F70", VA="0x2027F70")]
					internal BattleLib_UpdateResult.Types.BattleTurnLimit <.cctor>b__25_0()
					{
						return null;
					}
				}
			}

			public sealed class CastEnd : IMessage<BattleLib_UpdateResult.Types.CastEnd>, IMessage, IEquatable<BattleLib_UpdateResult.Types.CastEnd>, IDeepCloneable<BattleLib_UpdateResult.Types.CastEnd>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.CastEnd> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int SourceTypeFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint sourceType_;

				[FieldOffset(Offset="0x0")]
				public const int SourceIdFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint sourceId_;

				[FieldOffset(Offset="0x0")]
				public const int CastIdFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private uint castId_;

				[FieldOffset(Offset="0x0")]
				public const int ReasonFieldNumber = 4;

				[FieldOffset(Offset="0x24")]
				private BattleLib_UpdateResult.Types.CastEnd.Types.Reason reason_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D858", Offset="0x109D858")]
				public uint CastId
				{
					[Address(RVA="0x20282C0", Offset="0x20282C0", VA="0x20282C0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x20282C8", Offset="0x20282C8", VA="0x20282C8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D818", Offset="0x109D818")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x2028034", Offset="0x2028034", VA="0x2028034")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D808", Offset="0x109D808")]
				public static MessageParser<BattleLib_UpdateResult.Types.CastEnd> Parser
				{
					[Address(RVA="0x2027FCC", Offset="0x2027FCC", VA="0x2027FCC")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D828", Offset="0x109D828")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x2028124", Offset="0x2028124", VA="0x2028124", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D868", Offset="0x109D868")]
				public BattleLib_UpdateResult.Types.CastEnd.Types.Reason Reason
				{
					[Address(RVA="0x20282D0", Offset="0x20282D0", VA="0x20282D0")]
					get
					{
						return new BattleLib_UpdateResult.Types.CastEnd.Types.Reason();
					}
					[Address(RVA="0x20282D8", Offset="0x20282D8", VA="0x20282D8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D848", Offset="0x109D848")]
				public uint SourceId
				{
					[Address(RVA="0x20282B0", Offset="0x20282B0", VA="0x20282B0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x20282B8", Offset="0x20282B8", VA="0x20282B8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D838", Offset="0x109D838")]
				public uint SourceType
				{
					[Address(RVA="0x20282A0", Offset="0x20282A0", VA="0x20282A0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x20282A8", Offset="0x20282A8", VA="0x20282A8")]
					set
					{
					}
				}

				[Address(RVA="0x2028938", Offset="0x2028938", VA="0x2028938")]
				static CastEnd()
				{
				}

				[Address(RVA="0x2028180", Offset="0x2028180", VA="0x2028180")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F294", Offset="0x108F294")]
				public CastEnd()
				{
				}

				[Address(RVA="0x2028188", Offset="0x2028188", VA="0x2028188")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F2A4", Offset="0x108F2A4")]
				public CastEnd(BattleLib_UpdateResult.Types.CastEnd other)
				{
				}

				[Address(RVA="0x202868C", Offset="0x202868C", VA="0x202868C", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F314", Offset="0x108F314")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2028240", Offset="0x2028240", VA="0x2028240", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F2B4", Offset="0x108F2B4")]
				public BattleLib_UpdateResult.Types.CastEnd Clone()
				{
					return null;
				}

				[Address(RVA="0x20282E0", Offset="0x20282E0", VA="0x20282E0", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F2C4", Offset="0x108F2C4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2028354", Offset="0x2028354", VA="0x2028354", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F2D4", Offset="0x108F2D4")]
				public bool Equals(BattleLib_UpdateResult.Types.CastEnd other)
				{
					return new bool();
				}

				[Address(RVA="0x20283C0", Offset="0x20283C0", VA="0x20283C0", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F2E4", Offset="0x108F2E4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x20287D8", Offset="0x20287D8", VA="0x20287D8", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F324", Offset="0x108F324")]
				public void MergeFrom(BattleLib_UpdateResult.Types.CastEnd other)
				{
				}

				[Address(RVA="0x202883C", Offset="0x202883C", VA="0x202883C", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F334", Offset="0x108F334")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x202847C", Offset="0x202847C", VA="0x202847C", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F2F4", Offset="0x108F2F4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x20284E4", Offset="0x20284E4", VA="0x20284E4", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F304", Offset="0x108F304")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051814", Offset="0x1051814")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.CastEnd.<>c <>9;

					[Address(RVA="0x2028A10", Offset="0x2028A10", VA="0x2028A10")]
					static <>c()
					{
					}

					[Address(RVA="0x2028A74", Offset="0x2028A74", VA="0x2028A74")]
					public <>c()
					{
					}

					[Address(RVA="0x2028A7C", Offset="0x2028A7C", VA="0x2028A7C")]
					internal BattleLib_UpdateResult.Types.CastEnd <.cctor>b__41_0()
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1051804", Offset="0x1051804")]
				public static class Types
				{
					public enum Reason
					{
						[Attribute(Name="OriginalNameAttribute", RVA="0x106DB38", Offset="0x106DB38")]
						[FieldOffset(Offset="0x0")]
						Invalid,
						[Attribute(Name="OriginalNameAttribute", RVA="0x106DB70", Offset="0x106DB70")]
						[FieldOffset(Offset="0x0")]
						Finished,
						[Attribute(Name="OriginalNameAttribute", RVA="0x106DBA8", Offset="0x106DBA8")]
						[FieldOffset(Offset="0x0")]
						Interrupted
					}
				}
			}

			public sealed class CastStart : IMessage<BattleLib_UpdateResult.Types.CastStart>, IMessage, IEquatable<BattleLib_UpdateResult.Types.CastStart>, IDeepCloneable<BattleLib_UpdateResult.Types.CastStart>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.CastStart> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int SourceTypeFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint sourceType_;

				[FieldOffset(Offset="0x0")]
				public const int SourceIdFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint sourceId_;

				[FieldOffset(Offset="0x0")]
				public const int AbilityIdFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private uint abilityId_;

				[FieldOffset(Offset="0x0")]
				public const int CastIdFieldNumber = 4;

				[FieldOffset(Offset="0x24")]
				private uint castId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D7E8", Offset="0x109D7E8")]
				public uint AbilityId
				{
					[Address(RVA="0x2028DCC", Offset="0x2028DCC", VA="0x2028DCC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2028DD4", Offset="0x2028DD4", VA="0x2028DD4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D7F8", Offset="0x109D7F8")]
				public uint CastId
				{
					[Address(RVA="0x2028DDC", Offset="0x2028DDC", VA="0x2028DDC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2028DE4", Offset="0x2028DE4", VA="0x2028DE4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D7A8", Offset="0x109D7A8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x2028B40", Offset="0x2028B40", VA="0x2028B40")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D798", Offset="0x109D798")]
				public static MessageParser<BattleLib_UpdateResult.Types.CastStart> Parser
				{
					[Address(RVA="0x2028AD8", Offset="0x2028AD8", VA="0x2028AD8")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D7B8", Offset="0x109D7B8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x2028C30", Offset="0x2028C30", VA="0x2028C30", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D7D8", Offset="0x109D7D8")]
				public uint SourceId
				{
					[Address(RVA="0x2028DBC", Offset="0x2028DBC", VA="0x2028DBC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2028DC4", Offset="0x2028DC4", VA="0x2028DC4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D7C8", Offset="0x109D7C8")]
				public uint SourceType
				{
					[Address(RVA="0x2028DAC", Offset="0x2028DAC", VA="0x2028DAC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2028DB4", Offset="0x2028DB4", VA="0x2028DB4")]
					set
					{
					}
				}

				[Address(RVA="0x2029444", Offset="0x2029444", VA="0x2029444")]
				static CastStart()
				{
				}

				[Address(RVA="0x2028C8C", Offset="0x2028C8C", VA="0x2028C8C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F1E4", Offset="0x108F1E4")]
				public CastStart()
				{
				}

				[Address(RVA="0x2028C94", Offset="0x2028C94", VA="0x2028C94")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F1F4", Offset="0x108F1F4")]
				public CastStart(BattleLib_UpdateResult.Types.CastStart other)
				{
				}

				[Address(RVA="0x2029198", Offset="0x2029198", VA="0x2029198", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F264", Offset="0x108F264")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2028D4C", Offset="0x2028D4C", VA="0x2028D4C", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F204", Offset="0x108F204")]
				public BattleLib_UpdateResult.Types.CastStart Clone()
				{
					return null;
				}

				[Address(RVA="0x2028DEC", Offset="0x2028DEC", VA="0x2028DEC", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F214", Offset="0x108F214")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2028E60", Offset="0x2028E60", VA="0x2028E60", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F224", Offset="0x108F224")]
				public bool Equals(BattleLib_UpdateResult.Types.CastStart other)
				{
					return new bool();
				}

				[Address(RVA="0x2028ECC", Offset="0x2028ECC", VA="0x2028ECC", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F234", Offset="0x108F234")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x20292E4", Offset="0x20292E4", VA="0x20292E4", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F274", Offset="0x108F274")]
				public void MergeFrom(BattleLib_UpdateResult.Types.CastStart other)
				{
				}

				[Address(RVA="0x2029348", Offset="0x2029348", VA="0x2029348", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F284", Offset="0x108F284")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x2028F88", Offset="0x2028F88", VA="0x2028F88", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F244", Offset="0x108F244")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x2028FF0", Offset="0x2028FF0", VA="0x2028FF0", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F254", Offset="0x108F254")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10517F4", Offset="0x10517F4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.CastStart.<>c <>9;

					[Address(RVA="0x202951C", Offset="0x202951C", VA="0x202951C")]
					static <>c()
					{
					}

					[Address(RVA="0x2029580", Offset="0x2029580", VA="0x2029580")]
					public <>c()
					{
					}

					[Address(RVA="0x2029588", Offset="0x2029588", VA="0x2029588")]
					internal BattleLib_UpdateResult.Types.CastStart <.cctor>b__40_0()
					{
						return null;
					}
				}
			}

			public sealed class Damage : IMessage<BattleLib_UpdateResult.Types.Damage>, IMessage, IEquatable<BattleLib_UpdateResult.Types.Damage>, IDeepCloneable<BattleLib_UpdateResult.Types.Damage>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.Damage> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int AmountFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private int amount_;

				[FieldOffset(Offset="0x0")]
				public const int UnitIdFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint unitId_;

				[FieldOffset(Offset="0x0")]
				public const int IsCritFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private bool isCrit_;

				[FieldOffset(Offset="0x0")]
				public const int StrengthFieldNumber = 4;

				[FieldOffset(Offset="0x24")]
				private BattleLib_UpdateResult.Types.Damage.Types.Strength strength_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D408", Offset="0x109D408")]
				public int Amount
				{
					[Address(RVA="0x20298B8", Offset="0x20298B8", VA="0x20298B8")]
					get
					{
						return new int();
					}
					[Address(RVA="0x20298C0", Offset="0x20298C0", VA="0x20298C0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D3E8", Offset="0x109D3E8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x202964C", Offset="0x202964C", VA="0x202964C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D428", Offset="0x109D428")]
				public bool IsCrit
				{
					[Address(RVA="0x20298D8", Offset="0x20298D8", VA="0x20298D8")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x20298E0", Offset="0x20298E0", VA="0x20298E0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D3D8", Offset="0x109D3D8")]
				public static MessageParser<BattleLib_UpdateResult.Types.Damage> Parser
				{
					[Address(RVA="0x20295E4", Offset="0x20295E4", VA="0x20295E4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D3F8", Offset="0x109D3F8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x202973C", Offset="0x202973C", VA="0x202973C", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D438", Offset="0x109D438")]
				public BattleLib_UpdateResult.Types.Damage.Types.Strength Strength
				{
					[Address(RVA="0x20298EC", Offset="0x20298EC", VA="0x20298EC")]
					get
					{
						return new BattleLib_UpdateResult.Types.Damage.Types.Strength();
					}
					[Address(RVA="0x20298F4", Offset="0x20298F4", VA="0x20298F4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D418", Offset="0x109D418")]
				public uint UnitId
				{
					[Address(RVA="0x20298C8", Offset="0x20298C8", VA="0x20298C8")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x20298D0", Offset="0x20298D0", VA="0x20298D0")]
					set
					{
					}
				}

				[Address(RVA="0x2029F54", Offset="0x2029F54", VA="0x2029F54")]
				static Damage()
				{
				}

				[Address(RVA="0x2029798", Offset="0x2029798", VA="0x2029798")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EC64", Offset="0x108EC64")]
				public Damage()
				{
				}

				[Address(RVA="0x20297A0", Offset="0x20297A0", VA="0x20297A0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EC74", Offset="0x108EC74")]
				public Damage(BattleLib_UpdateResult.Types.Damage other)
				{
				}

				[Address(RVA="0x2029CC8", Offset="0x2029CC8", VA="0x2029CC8", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ECE4", Offset="0x108ECE4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2029858", Offset="0x2029858", VA="0x2029858", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EC84", Offset="0x108EC84")]
				public BattleLib_UpdateResult.Types.Damage Clone()
				{
					return null;
				}

				[Address(RVA="0x20298FC", Offset="0x20298FC", VA="0x20298FC", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EC94", Offset="0x108EC94")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2029970", Offset="0x2029970", VA="0x2029970", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ECA4", Offset="0x108ECA4")]
				public bool Equals(BattleLib_UpdateResult.Types.Damage other)
				{
					return new bool();
				}

				[Address(RVA="0x20299EC", Offset="0x20299EC", VA="0x20299EC", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ECB4", Offset="0x108ECB4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x2029DF0", Offset="0x2029DF0", VA="0x2029DF0", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ECF4", Offset="0x108ECF4")]
				public void MergeFrom(BattleLib_UpdateResult.Types.Damage other)
				{
				}

				[Address(RVA="0x2029E54", Offset="0x2029E54", VA="0x2029E54", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ED04", Offset="0x108ED04")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x2029AB4", Offset="0x2029AB4", VA="0x2029AB4", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ECC4", Offset="0x108ECC4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x2029B1C", Offset="0x2029B1C", VA="0x2029B1C", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ECD4", Offset="0x108ECD4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051774", Offset="0x1051774")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.Damage.<>c <>9;

					[Address(RVA="0x202A02C", Offset="0x202A02C", VA="0x202A02C")]
					static <>c()
					{
					}

					[Address(RVA="0x202A090", Offset="0x202A090", VA="0x202A090")]
					public <>c()
					{
					}

					[Address(RVA="0x202A098", Offset="0x202A098", VA="0x202A098")]
					internal BattleLib_UpdateResult.Types.Damage <.cctor>b__41_0()
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1051764", Offset="0x1051764")]
				public static class Types
				{
					public enum Strength
					{
						[Attribute(Name="OriginalNameAttribute", RVA="0x106DA90", Offset="0x106DA90")]
						[FieldOffset(Offset="0x0")]
						Invalid,
						[Attribute(Name="OriginalNameAttribute", RVA="0x106DAC8", Offset="0x106DAC8")]
						[FieldOffset(Offset="0x0")]
						Strong,
						[Attribute(Name="OriginalNameAttribute", RVA="0x106DB00", Offset="0x106DB00")]
						[FieldOffset(Offset="0x0")]
						Weak
					}
				}
			}

			public sealed class Effect : IMessage<BattleLib_UpdateResult.Types.Effect>, IMessage, IEquatable<BattleLib_UpdateResult.Types.Effect>, IDeepCloneable<BattleLib_UpdateResult.Types.Effect>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.Effect> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int IconTypeFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint iconType_;

				[FieldOffset(Offset="0x0")]
				public const int IconStackIdFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint iconStackId_;

				[FieldOffset(Offset="0x0")]
				public const int IsPermanentFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private bool isPermanent_;

				[FieldOffset(Offset="0x0")]
				public const int DurationTurnsFieldNumber = 4;

				[FieldOffset(Offset="0x24")]
				private uint durationTurns_;

				[FieldOffset(Offset="0x0")]
				public const int StackCountFieldNumber = 5;

				[FieldOffset(Offset="0x28")]
				private uint stackCount_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DCF8", Offset="0x109DCF8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x202A15C", Offset="0x202A15C", VA="0x202A15C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DD48", Offset="0x109DD48")]
				public uint DurationTurns
				{
					[Address(RVA="0x202A418", Offset="0x202A418", VA="0x202A418")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202A420", Offset="0x202A420", VA="0x202A420")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DD28", Offset="0x109DD28")]
				public uint IconStackId
				{
					[Address(RVA="0x202A3F4", Offset="0x202A3F4", VA="0x202A3F4")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202A3FC", Offset="0x202A3FC", VA="0x202A3FC")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DD18", Offset="0x109DD18")]
				public uint IconType
				{
					[Address(RVA="0x202A3E4", Offset="0x202A3E4", VA="0x202A3E4")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202A3EC", Offset="0x202A3EC", VA="0x202A3EC")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DD38", Offset="0x109DD38")]
				public bool IsPermanent
				{
					[Address(RVA="0x202A404", Offset="0x202A404", VA="0x202A404")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x202A40C", Offset="0x202A40C", VA="0x202A40C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DCE8", Offset="0x109DCE8")]
				public static MessageParser<BattleLib_UpdateResult.Types.Effect> Parser
				{
					[Address(RVA="0x202A0F4", Offset="0x202A0F4", VA="0x202A0F4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DD08", Offset="0x109DD08")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x202A24C", Offset="0x202A24C", VA="0x202A24C", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DD58", Offset="0x109DD58")]
				public uint StackCount
				{
					[Address(RVA="0x202A428", Offset="0x202A428", VA="0x202A428")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202A430", Offset="0x202A430", VA="0x202A430")]
					set
					{
					}
				}

				[Address(RVA="0x202AB80", Offset="0x202AB80", VA="0x202AB80")]
				static Effect()
				{
				}

				[Address(RVA="0x202A2A8", Offset="0x202A2A8", VA="0x202A2A8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FB84", Offset="0x108FB84")]
				public Effect()
				{
				}

				[Address(RVA="0x202A2B0", Offset="0x202A2B0", VA="0x202A2B0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FB94", Offset="0x108FB94")]
				public Effect(BattleLib_UpdateResult.Types.Effect other)
				{
				}

				[Address(RVA="0x202A884", Offset="0x202A884", VA="0x202A884", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FC04", Offset="0x108FC04")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x202A384", Offset="0x202A384", VA="0x202A384", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FBA4", Offset="0x108FBA4")]
				public BattleLib_UpdateResult.Types.Effect Clone()
				{
					return null;
				}

				[Address(RVA="0x202A438", Offset="0x202A438", VA="0x202A438", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FBB4", Offset="0x108FBB4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x202A4AC", Offset="0x202A4AC", VA="0x202A4AC", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FBC4", Offset="0x108FBC4")]
				public bool Equals(BattleLib_UpdateResult.Types.Effect other)
				{
					return new bool();
				}

				[Address(RVA="0x202A538", Offset="0x202A538", VA="0x202A538", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FBD4", Offset="0x108FBD4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x202A9E8", Offset="0x202A9E8", VA="0x202A9E8", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FC14", Offset="0x108FC14")]
				public void MergeFrom(BattleLib_UpdateResult.Types.Effect other)
				{
				}

				[Address(RVA="0x202AA58", Offset="0x202AA58", VA="0x202AA58", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FC24", Offset="0x108FC24")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x202A618", Offset="0x202A618", VA="0x202A618", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FBE4", Offset="0x108FBE4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x202A680", Offset="0x202A680", VA="0x202A680", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FBF4", Offset="0x108FBF4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10518E4", Offset="0x10518E4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.Effect.<>c <>9;

					[Address(RVA="0x202AC58", Offset="0x202AC58", VA="0x202AC58")]
					static <>c()
					{
					}

					[Address(RVA="0x202ACBC", Offset="0x202ACBC", VA="0x202ACBC")]
					public <>c()
					{
					}

					[Address(RVA="0x202ACC4", Offset="0x202ACC4", VA="0x202ACC4")]
					internal BattleLib_UpdateResult.Types.Effect <.cctor>b__45_0()
					{
						return null;
					}
				}
			}

			public sealed class KillingBlow : IMessage<BattleLib_UpdateResult.Types.KillingBlow>, IMessage, IEquatable<BattleLib_UpdateResult.Types.KillingBlow>, IDeepCloneable<BattleLib_UpdateResult.Types.KillingBlow>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.KillingBlow> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int KilledUnitIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint killedUnitId_;

				[FieldOffset(Offset="0x0")]
				public const int SourceUnitIdFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint sourceUnitId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DC58", Offset="0x109DC58")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x202AD88", Offset="0x202AD88", VA="0x202AD88")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DC78", Offset="0x109DC78")]
				public uint KilledUnitId
				{
					[Address(RVA="0x202AFBC", Offset="0x202AFBC", VA="0x202AFBC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202AFC4", Offset="0x202AFC4", VA="0x202AFC4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DC48", Offset="0x109DC48")]
				public static MessageParser<BattleLib_UpdateResult.Types.KillingBlow> Parser
				{
					[Address(RVA="0x202AD20", Offset="0x202AD20", VA="0x202AD20")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DC68", Offset="0x109DC68")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x202AE78", Offset="0x202AE78", VA="0x202AE78", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DC88", Offset="0x109DC88")]
				public uint SourceUnitId
				{
					[Address(RVA="0x202AFCC", Offset="0x202AFCC", VA="0x202AFCC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202AFD4", Offset="0x202AFD4", VA="0x202AFD4")]
					set
					{
					}
				}

				[Address(RVA="0x202B444", Offset="0x202B444", VA="0x202B444")]
				static KillingBlow()
				{
				}

				[Address(RVA="0x202AED4", Offset="0x202AED4", VA="0x202AED4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FA24", Offset="0x108FA24")]
				public KillingBlow()
				{
				}

				[Address(RVA="0x202AEDC", Offset="0x202AEDC", VA="0x202AEDC")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FA34", Offset="0x108FA34")]
				public KillingBlow(BattleLib_UpdateResult.Types.KillingBlow other)
				{
				}

				[Address(RVA="0x202B280", Offset="0x202B280", VA="0x202B280", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FAA4", Offset="0x108FAA4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x202AF5C", Offset="0x202AF5C", VA="0x202AF5C", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FA44", Offset="0x108FA44")]
				public BattleLib_UpdateResult.Types.KillingBlow Clone()
				{
					return null;
				}

				[Address(RVA="0x202AFDC", Offset="0x202AFDC", VA="0x202AFDC", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FA54", Offset="0x108FA54")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x202B050", Offset="0x202B050", VA="0x202B050", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FA64", Offset="0x108FA64")]
				public bool Equals(BattleLib_UpdateResult.Types.KillingBlow other)
				{
					return new bool();
				}

				[Address(RVA="0x202B09C", Offset="0x202B09C", VA="0x202B09C", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FA74", Offset="0x108FA74")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x202B354", Offset="0x202B354", VA="0x202B354", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FAB4", Offset="0x108FAB4")]
				public void MergeFrom(BattleLib_UpdateResult.Types.KillingBlow other)
				{
				}

				[Address(RVA="0x202B3A0", Offset="0x202B3A0", VA="0x202B3A0", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FAC4", Offset="0x108FAC4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x202B120", Offset="0x202B120", VA="0x202B120", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FA84", Offset="0x108FA84")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x202B188", Offset="0x202B188", VA="0x202B188", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FA94", Offset="0x108FA94")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10518C4", Offset="0x10518C4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.KillingBlow.<>c <>9;

					[Address(RVA="0x202B51C", Offset="0x202B51C", VA="0x202B51C")]
					static <>c()
					{
					}

					[Address(RVA="0x202B580", Offset="0x202B580", VA="0x202B580")]
					public <>c()
					{
					}

					[Address(RVA="0x202B588", Offset="0x202B588", VA="0x202B588")]
					internal BattleLib_UpdateResult.Types.KillingBlow <.cctor>b__30_0()
					{
						return null;
					}
				}
			}

			public sealed class PlayerHand : IMessage<BattleLib_UpdateResult.Types.PlayerHand>, IMessage, IEquatable<BattleLib_UpdateResult.Types.PlayerHand>, IDeepCloneable<BattleLib_UpdateResult.Types.PlayerHand>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.PlayerHand> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int PlayerIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint playerId_;

				[FieldOffset(Offset="0x0")]
				public const int NextCardFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private BattleLib_UpdateResult.Types.AbilityCard nextCard_;

				[FieldOffset(Offset="0x0")]
				public const int HandFieldNumber = 3;

				[FieldOffset(Offset="0x8")]
				private readonly static FieldCodec<BattleLib_UpdateResult.Types.AbilityCard> _repeated_hand_codec;

				[FieldOffset(Offset="0x28")]
				private readonly RepeatedField<BattleLib_UpdateResult.Types.AbilityCard> hand_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D6F8", Offset="0x109D6F8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x202B64C", Offset="0x202B64C", VA="0x202B64C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D738", Offset="0x109D738")]
				public RepeatedField<BattleLib_UpdateResult.Types.AbilityCard> Hand
				{
					[Address(RVA="0x202B954", Offset="0x202B954", VA="0x202B954")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D728", Offset="0x109D728")]
				public BattleLib_UpdateResult.Types.AbilityCard NextCard
				{
					[Address(RVA="0x202B8D4", Offset="0x202B8D4", VA="0x202B8D4")]
					get
					{
						return null;
					}
					[Address(RVA="0x202B8DC", Offset="0x202B8DC", VA="0x202B8DC")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D6E8", Offset="0x109D6E8")]
				public static MessageParser<BattleLib_UpdateResult.Types.PlayerHand> Parser
				{
					[Address(RVA="0x202B5E4", Offset="0x202B5E4", VA="0x202B5E4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D708", Offset="0x109D708")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x202B73C", Offset="0x202B73C", VA="0x202B73C", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D718", Offset="0x109D718")]
				public uint PlayerId
				{
					[Address(RVA="0x202B944", Offset="0x202B944", VA="0x202B944")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202B94C", Offset="0x202B94C", VA="0x202B94C")]
					set
					{
					}
				}

				[Address(RVA="0x202C0BC", Offset="0x202C0BC", VA="0x202C0BC")]
				static PlayerHand()
				{
				}

				[Address(RVA="0x202B798", Offset="0x202B798", VA="0x202B798")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F084", Offset="0x108F084")]
				public PlayerHand()
				{
				}

				[Address(RVA="0x202B808", Offset="0x202B808", VA="0x202B808")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F094", Offset="0x108F094")]
				public PlayerHand(BattleLib_UpdateResult.Types.PlayerHand other)
				{
				}

				[Address(RVA="0x202BD28", Offset="0x202BD28", VA="0x202BD28", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F104", Offset="0x108F104")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x202B8E4", Offset="0x202B8E4", VA="0x202B8E4", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F0A4", Offset="0x108F0A4")]
				public BattleLib_UpdateResult.Types.PlayerHand Clone()
				{
					return null;
				}

				[Address(RVA="0x202B95C", Offset="0x202B95C", VA="0x202B95C", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F0B4", Offset="0x108F0B4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x202B9D0", Offset="0x202B9D0", VA="0x202B9D0", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F0C4", Offset="0x108F0C4")]
				public bool Equals(BattleLib_UpdateResult.Types.PlayerHand other)
				{
					return new bool();
				}

				[Address(RVA="0x202BAA4", Offset="0x202BAA4", VA="0x202BAA4", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F0D4", Offset="0x108F0D4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x202BE60", Offset="0x202BE60", VA="0x202BE60", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F114", Offset="0x108F114")]
				public void MergeFrom(BattleLib_UpdateResult.Types.PlayerHand other)
				{
				}

				[Address(RVA="0x202BF4C", Offset="0x202BF4C", VA="0x202BF4C", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F124", Offset="0x108F124")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x202BB4C", Offset="0x202BB4C", VA="0x202BB4C", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F0E4", Offset="0x108F0E4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x202BBB4", Offset="0x202BBB4", VA="0x202BBB4", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F0F4", Offset="0x108F0F4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10517D4", Offset="0x10517D4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.PlayerHand.<>c <>9;

					[Address(RVA="0x202C1E0", Offset="0x202C1E0", VA="0x202C1E0")]
					static <>c()
					{
					}

					[Address(RVA="0x202C244", Offset="0x202C244", VA="0x202C244")]
					public <>c()
					{
					}

					[Address(RVA="0x202C24C", Offset="0x202C24C", VA="0x202C24C")]
					internal BattleLib_UpdateResult.Types.PlayerHand <.cctor>b__35_0()
					{
						return null;
					}
				}
			}

			public sealed class PlayerMana : IMessage<BattleLib_UpdateResult.Types.PlayerMana>, IMessage, IEquatable<BattleLib_UpdateResult.Types.PlayerMana>, IDeepCloneable<BattleLib_UpdateResult.Types.PlayerMana>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.PlayerMana> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int ManaFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private float mana_;

				[FieldOffset(Offset="0x0")]
				public const int PlayerIdFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint playerId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D458", Offset="0x109D458")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x202C30C", Offset="0x202C30C", VA="0x202C30C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D478", Offset="0x109D478")]
				public float Mana
				{
					[Address(RVA="0x202C540", Offset="0x202C540", VA="0x202C540")]
					get
					{
						return new float();
					}
					[Address(RVA="0x202C548", Offset="0x202C548", VA="0x202C548")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D448", Offset="0x109D448")]
				public static MessageParser<BattleLib_UpdateResult.Types.PlayerMana> Parser
				{
					[Address(RVA="0x202C2A4", Offset="0x202C2A4", VA="0x202C2A4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D468", Offset="0x109D468")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x202C3FC", Offset="0x202C3FC", VA="0x202C3FC", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D488", Offset="0x109D488")]
				public uint PlayerId
				{
					[Address(RVA="0x202C550", Offset="0x202C550", VA="0x202C550")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202C558", Offset="0x202C558", VA="0x202C558")]
					set
					{
					}
				}

				[Address(RVA="0x202CAC0", Offset="0x202CAC0", VA="0x202CAC0")]
				static PlayerMana()
				{
				}

				[Address(RVA="0x202C458", Offset="0x202C458", VA="0x202C458")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ED14", Offset="0x108ED14")]
				public PlayerMana()
				{
				}

				[Address(RVA="0x202C460", Offset="0x202C460", VA="0x202C460")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ED24", Offset="0x108ED24")]
				public PlayerMana(BattleLib_UpdateResult.Types.PlayerMana other)
				{
				}

				[Address(RVA="0x202C920", Offset="0x202C920", VA="0x202C920", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ED94", Offset="0x108ED94")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x202C4E0", Offset="0x202C4E0", VA="0x202C4E0", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ED34", Offset="0x108ED34")]
				public BattleLib_UpdateResult.Types.PlayerMana Clone()
				{
					return null;
				}

				[Address(RVA="0x202C560", Offset="0x202C560", VA="0x202C560", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ED44", Offset="0x108ED44")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x202C5D4", Offset="0x202C5D4", VA="0x202C5D4", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ED54", Offset="0x108ED54")]
				public bool Equals(BattleLib_UpdateResult.Types.PlayerMana other)
				{
					return new bool();
				}

				[Address(RVA="0x202C6C8", Offset="0x202C6C8", VA="0x202C6C8", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ED64", Offset="0x108ED64")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x202C9CC", Offset="0x202C9CC", VA="0x202C9CC", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EDA4", Offset="0x108EDA4")]
				public void MergeFrom(BattleLib_UpdateResult.Types.PlayerMana other)
				{
				}

				[Address(RVA="0x202CA1C", Offset="0x202CA1C", VA="0x202CA1C", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EDB4", Offset="0x108EDB4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x202C7B0", Offset="0x202C7B0", VA="0x202C7B0", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ED74", Offset="0x108ED74")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x202C818", Offset="0x202C818", VA="0x202C818", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108ED84", Offset="0x108ED84")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051784", Offset="0x1051784")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.PlayerMana.<>c <>9;

					[Address(RVA="0x202CB98", Offset="0x202CB98", VA="0x202CB98")]
					static <>c()
					{
					}

					[Address(RVA="0x202CBFC", Offset="0x202CBFC", VA="0x202CBFC")]
					public <>c()
					{
					}

					[Address(RVA="0x202CC04", Offset="0x202CC04", VA="0x202CC04")]
					internal BattleLib_UpdateResult.Types.PlayerMana <.cctor>b__30_0()
					{
						return null;
					}
				}
			}

			public sealed class PlayerManaMeta : IMessage<BattleLib_UpdateResult.Types.PlayerManaMeta>, IMessage, IEquatable<BattleLib_UpdateResult.Types.PlayerManaMeta>, IDeepCloneable<BattleLib_UpdateResult.Types.PlayerManaMeta>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.PlayerManaMeta> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int ManaPerSFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private float manaPerS_;

				[FieldOffset(Offset="0x0")]
				public const int PlayerIdFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint playerId_;

				[FieldOffset(Offset="0x0")]
				public const int MaxManaFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private uint maxMana_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D4A8", Offset="0x109D4A8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x202CCC8", Offset="0x202CCC8", VA="0x202CCC8")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D4C8", Offset="0x109D4C8")]
				public float ManaPerS
				{
					[Address(RVA="0x202CF18", Offset="0x202CF18", VA="0x202CF18")]
					get
					{
						return new float();
					}
					[Address(RVA="0x202CF20", Offset="0x202CF20", VA="0x202CF20")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D4E8", Offset="0x109D4E8")]
				public uint MaxMana
				{
					[Address(RVA="0x202CF38", Offset="0x202CF38", VA="0x202CF38")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202CF40", Offset="0x202CF40", VA="0x202CF40")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D498", Offset="0x109D498")]
				public static MessageParser<BattleLib_UpdateResult.Types.PlayerManaMeta> Parser
				{
					[Address(RVA="0x202CC60", Offset="0x202CC60", VA="0x202CC60")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D4B8", Offset="0x109D4B8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x202CDB8", Offset="0x202CDB8", VA="0x202CDB8", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D4D8", Offset="0x109D4D8")]
				public uint PlayerId
				{
					[Address(RVA="0x202CF28", Offset="0x202CF28", VA="0x202CF28")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202CF30", Offset="0x202CF30", VA="0x202CF30")]
					set
					{
					}
				}

				[Address(RVA="0x202D5A4", Offset="0x202D5A4", VA="0x202D5A4")]
				static PlayerManaMeta()
				{
				}

				[Address(RVA="0x202CE14", Offset="0x202CE14", VA="0x202CE14")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EDC4", Offset="0x108EDC4")]
				public PlayerManaMeta()
				{
				}

				[Address(RVA="0x202CE1C", Offset="0x202CE1C", VA="0x202CE1C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EDD4", Offset="0x108EDD4")]
				public PlayerManaMeta(BattleLib_UpdateResult.Types.PlayerManaMeta other)
				{
				}

				[Address(RVA="0x202D38C", Offset="0x202D38C", VA="0x202D38C", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EE44", Offset="0x108EE44")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x202CEB8", Offset="0x202CEB8", VA="0x202CEB8", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EDE4", Offset="0x108EDE4")]
				public BattleLib_UpdateResult.Types.PlayerManaMeta Clone()
				{
					return null;
				}

				[Address(RVA="0x202CF48", Offset="0x202CF48", VA="0x202CF48", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EDF4", Offset="0x108EDF4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x202CFBC", Offset="0x202CFBC", VA="0x202CFBC", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EE04", Offset="0x108EE04")]
				public bool Equals(BattleLib_UpdateResult.Types.PlayerManaMeta other)
				{
					return new bool();
				}

				[Address(RVA="0x202D0C0", Offset="0x202D0C0", VA="0x202D0C0", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EE14", Offset="0x108EE14")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x202D474", Offset="0x202D474", VA="0x202D474", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EE54", Offset="0x108EE54")]
				public void MergeFrom(BattleLib_UpdateResult.Types.PlayerManaMeta other)
				{
				}

				[Address(RVA="0x202D4D0", Offset="0x202D4D0", VA="0x202D4D0", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EE64", Offset="0x108EE64")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x202D1C4", Offset="0x202D1C4", VA="0x202D1C4", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EE24", Offset="0x108EE24")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x202D22C", Offset="0x202D22C", VA="0x202D22C", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EE34", Offset="0x108EE34")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051794", Offset="0x1051794")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.PlayerManaMeta.<>c <>9;

					[Address(RVA="0x202D67C", Offset="0x202D67C", VA="0x202D67C")]
					static <>c()
					{
					}

					[Address(RVA="0x202D6E0", Offset="0x202D6E0", VA="0x202D6E0")]
					public <>c()
					{
					}

					[Address(RVA="0x202D6E8", Offset="0x202D6E8", VA="0x202D6E8")]
					internal BattleLib_UpdateResult.Types.PlayerManaMeta <.cctor>b__35_0()
					{
						return null;
					}
				}
			}

			public sealed class PlayerResult : IMessage<BattleLib_UpdateResult.Types.PlayerResult>, IMessage, IEquatable<BattleLib_UpdateResult.Types.PlayerResult>, IDeepCloneable<BattleLib_UpdateResult.Types.PlayerResult>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.PlayerResult> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int PlayerIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint playerId_;

				[FieldOffset(Offset="0x0")]
				public const int ActivityTrackersFieldNumber = 2;

				[FieldOffset(Offset="0x8")]
				private readonly static FieldCodec<BattleLib_ActivityTracker> _repeated_activityTrackers_codec;

				[FieldOffset(Offset="0x20")]
				private readonly RepeatedField<BattleLib_ActivityTracker> activityTrackers_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D0F8", Offset="0x109D0F8")]
				public RepeatedField<BattleLib_ActivityTracker> ActivityTrackers
				{
					[Address(RVA="0x202DA90", Offset="0x202DA90", VA="0x202DA90")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D0C8", Offset="0x109D0C8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x202D7AC", Offset="0x202D7AC", VA="0x202D7AC")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D0B8", Offset="0x109D0B8")]
				public static MessageParser<BattleLib_UpdateResult.Types.PlayerResult> Parser
				{
					[Address(RVA="0x202D744", Offset="0x202D744", VA="0x202D744")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D0D8", Offset="0x109D0D8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x202D89C", Offset="0x202D89C", VA="0x202D89C", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D0E8", Offset="0x109D0E8")]
				public uint PlayerId
				{
					[Address(RVA="0x202DA80", Offset="0x202DA80", VA="0x202DA80")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202DA88", Offset="0x202DA88", VA="0x202DA88")]
					set
					{
					}
				}

				[Address(RVA="0x202E084", Offset="0x202E084", VA="0x202E084")]
				static PlayerResult()
				{
				}

				[Address(RVA="0x202D8F8", Offset="0x202D8F8", VA="0x202D8F8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E794", Offset="0x108E794")]
				public PlayerResult()
				{
				}

				[Address(RVA="0x202D968", Offset="0x202D968", VA="0x202D968")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E7A4", Offset="0x108E7A4")]
				public PlayerResult(BattleLib_UpdateResult.Types.PlayerResult other)
				{
				}

				[Address(RVA="0x202DDE0", Offset="0x202DDE0", VA="0x202DDE0", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E814", Offset="0x108E814")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x202DA20", Offset="0x202DA20", VA="0x202DA20", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E7B4", Offset="0x108E7B4")]
				public BattleLib_UpdateResult.Types.PlayerResult Clone()
				{
					return null;
				}

				[Address(RVA="0x202DA98", Offset="0x202DA98", VA="0x202DA98", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E7C4", Offset="0x108E7C4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x202DB0C", Offset="0x202DB0C", VA="0x202DB0C", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E7D4", Offset="0x108E7D4")]
				public bool Equals(BattleLib_UpdateResult.Types.PlayerResult other)
				{
					return new bool();
				}

				[Address(RVA="0x202DBCC", Offset="0x202DBCC", VA="0x202DBCC", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E7E4", Offset="0x108E7E4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x202DEDC", Offset="0x202DEDC", VA="0x202DEDC", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E824", Offset="0x108E824")]
				public void MergeFrom(BattleLib_UpdateResult.Types.PlayerResult other)
				{
				}

				[Address(RVA="0x202DF78", Offset="0x202DF78", VA="0x202DF78", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E834", Offset="0x108E834")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x202DC5C", Offset="0x202DC5C", VA="0x202DC5C", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E7F4", Offset="0x108E7F4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x202DCC4", Offset="0x202DCC4", VA="0x202DCC4", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E804", Offset="0x108E804")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10516E4", Offset="0x10516E4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.PlayerResult.<>c <>9;

					[Address(RVA="0x202E1A8", Offset="0x202E1A8", VA="0x202E1A8")]
					static <>c()
					{
					}

					[Address(RVA="0x202E20C", Offset="0x202E20C", VA="0x202E20C")]
					public <>c()
					{
					}

					[Address(RVA="0x202E214", Offset="0x202E214", VA="0x202E214")]
					internal BattleLib_UpdateResult.Types.PlayerResult <.cctor>b__30_0()
					{
						return null;
					}
				}
			}

			public sealed class PlayerSpellCharge : IMessage<BattleLib_UpdateResult.Types.PlayerSpellCharge>, IMessage, IEquatable<BattleLib_UpdateResult.Types.PlayerSpellCharge>, IDeepCloneable<BattleLib_UpdateResult.Types.PlayerSpellCharge>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.PlayerSpellCharge> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int PlayerIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint playerId_;

				[FieldOffset(Offset="0x0")]
				public const int CurrentChargeFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private float currentCharge_;

				[FieldOffset(Offset="0x0")]
				public const int ChargeMaxFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private uint chargeMax_;

				[FieldOffset(Offset="0x0")]
				public const int AbilityIdFieldNumber = 4;

				[FieldOffset(Offset="0x24")]
				private uint abilityId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D558", Offset="0x109D558")]
				public uint AbilityId
				{
					[Address(RVA="0x202E570", Offset="0x202E570", VA="0x202E570")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202E578", Offset="0x202E578", VA="0x202E578")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D548", Offset="0x109D548")]
				public uint ChargeMax
				{
					[Address(RVA="0x202E560", Offset="0x202E560", VA="0x202E560")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202E568", Offset="0x202E568", VA="0x202E568")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D538", Offset="0x109D538")]
				public float CurrentCharge
				{
					[Address(RVA="0x202E550", Offset="0x202E550", VA="0x202E550")]
					get
					{
						return new float();
					}
					[Address(RVA="0x202E558", Offset="0x202E558", VA="0x202E558")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D508", Offset="0x109D508")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x202E2D4", Offset="0x202E2D4", VA="0x202E2D4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D4F8", Offset="0x109D4F8")]
				public static MessageParser<BattleLib_UpdateResult.Types.PlayerSpellCharge> Parser
				{
					[Address(RVA="0x202E26C", Offset="0x202E26C", VA="0x202E26C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D518", Offset="0x109D518")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x202E3C4", Offset="0x202E3C4", VA="0x202E3C4", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D528", Offset="0x109D528")]
				public uint PlayerId
				{
					[Address(RVA="0x202E540", Offset="0x202E540", VA="0x202E540")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202E548", Offset="0x202E548", VA="0x202E548")]
					set
					{
					}
				}

				[Address(RVA="0x202ECE4", Offset="0x202ECE4", VA="0x202ECE4")]
				static PlayerSpellCharge()
				{
				}

				[Address(RVA="0x202E420", Offset="0x202E420", VA="0x202E420")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EE74", Offset="0x108EE74")]
				public PlayerSpellCharge()
				{
				}

				[Address(RVA="0x202E428", Offset="0x202E428", VA="0x202E428")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EE84", Offset="0x108EE84")]
				public PlayerSpellCharge(BattleLib_UpdateResult.Types.PlayerSpellCharge other)
				{
				}

				[Address(RVA="0x202EA58", Offset="0x202EA58", VA="0x202EA58", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EEF4", Offset="0x108EEF4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x202E4E0", Offset="0x202E4E0", VA="0x202E4E0", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EE94", Offset="0x108EE94")]
				public BattleLib_UpdateResult.Types.PlayerSpellCharge Clone()
				{
					return null;
				}

				[Address(RVA="0x202E580", Offset="0x202E580", VA="0x202E580", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EEA4", Offset="0x108EEA4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x202E5F4", Offset="0x202E5F4", VA="0x202E5F4", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EEB4", Offset="0x108EEB4")]
				public bool Equals(BattleLib_UpdateResult.Types.PlayerSpellCharge other)
				{
					return new bool();
				}

				[Address(RVA="0x202E708", Offset="0x202E708", VA="0x202E708", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EEC4", Offset="0x108EEC4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x202EB80", Offset="0x202EB80", VA="0x202EB80", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EF04", Offset="0x108EF04")]
				public void MergeFrom(BattleLib_UpdateResult.Types.PlayerSpellCharge other)
				{
				}

				[Address(RVA="0x202EBE8", Offset="0x202EBE8", VA="0x202EBE8", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EF14", Offset="0x108EF14")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x202E838", Offset="0x202E838", VA="0x202E838", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EED4", Offset="0x108EED4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x202E8A0", Offset="0x202E8A0", VA="0x202E8A0", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EEE4", Offset="0x108EEE4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10517A4", Offset="0x10517A4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.PlayerSpellCharge.<>c <>9;

					[Address(RVA="0x202EDBC", Offset="0x202EDBC", VA="0x202EDBC")]
					static <>c()
					{
					}

					[Address(RVA="0x202EE20", Offset="0x202EE20", VA="0x202EE20")]
					public <>c()
					{
					}

					[Address(RVA="0x202EE28", Offset="0x202EE28", VA="0x202EE28")]
					internal BattleLib_UpdateResult.Types.PlayerSpellCharge <.cctor>b__40_0()
					{
						return null;
					}
				}
			}

			public sealed class PlayerTurnIdled : IMessage<BattleLib_UpdateResult.Types.PlayerTurnIdled>, IMessage, IEquatable<BattleLib_UpdateResult.Types.PlayerTurnIdled>, IDeepCloneable<BattleLib_UpdateResult.Types.PlayerTurnIdled>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.PlayerTurnIdled> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int PlayerIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint playerId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DEE8", Offset="0x109DEE8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x202EEEC", Offset="0x202EEEC", VA="0x202EEEC")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DED8", Offset="0x109DED8")]
				public static MessageParser<BattleLib_UpdateResult.Types.PlayerTurnIdled> Parser
				{
					[Address(RVA="0x202EE84", Offset="0x202EE84", VA="0x202EE84")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DEF8", Offset="0x109DEF8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x202EFDC", Offset="0x202EFDC", VA="0x202EFDC", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DF08", Offset="0x109DF08")]
				public uint PlayerId
				{
					[Address(RVA="0x202F104", Offset="0x202F104", VA="0x202F104")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202F10C", Offset="0x202F10C", VA="0x202F10C")]
					set
					{
					}
				}

				[Address(RVA="0x202F480", Offset="0x202F480", VA="0x202F480")]
				static PlayerTurnIdled()
				{
				}

				[Address(RVA="0x202F038", Offset="0x202F038", VA="0x202F038")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FE44", Offset="0x108FE44")]
				public PlayerTurnIdled()
				{
				}

				[Address(RVA="0x202F040", Offset="0x202F040", VA="0x202F040")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FE54", Offset="0x108FE54")]
				public PlayerTurnIdled(BattleLib_UpdateResult.Types.PlayerTurnIdled other)
				{
				}

				[Address(RVA="0x202F334", Offset="0x202F334", VA="0x202F334", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FEC4", Offset="0x108FEC4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x202F0A4", Offset="0x202F0A4", VA="0x202F0A4", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FE64", Offset="0x108FE64")]
				public BattleLib_UpdateResult.Types.PlayerTurnIdled Clone()
				{
					return null;
				}

				[Address(RVA="0x202F114", Offset="0x202F114", VA="0x202F114", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FE74", Offset="0x108FE74")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x202F188", Offset="0x202F188", VA="0x202F188", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FE84", Offset="0x108FE84")]
				public bool Equals(BattleLib_UpdateResult.Types.PlayerTurnIdled other)
				{
					return new bool();
				}

				[Address(RVA="0x202F1C4", Offset="0x202F1C4", VA="0x202F1C4", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FE94", Offset="0x108FE94")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x202F3C4", Offset="0x202F3C4", VA="0x202F3C4", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FED4", Offset="0x108FED4")]
				public void MergeFrom(BattleLib_UpdateResult.Types.PlayerTurnIdled other)
				{
				}

				[Address(RVA="0x202F404", Offset="0x202F404", VA="0x202F404", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FEE4", Offset="0x108FEE4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x202F22C", Offset="0x202F22C", VA="0x202F22C", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FEA4", Offset="0x108FEA4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x202F294", Offset="0x202F294", VA="0x202F294", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FEB4", Offset="0x108FEB4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051924", Offset="0x1051924")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.PlayerTurnIdled.<>c <>9;

					[Address(RVA="0x202F558", Offset="0x202F558", VA="0x202F558")]
					static <>c()
					{
					}

					[Address(RVA="0x202F5BC", Offset="0x202F5BC", VA="0x202F5BC")]
					public <>c()
					{
					}

					[Address(RVA="0x202F5C4", Offset="0x202F5C4", VA="0x202F5C4")]
					internal BattleLib_UpdateResult.Types.PlayerTurnIdled <.cctor>b__25_0()
					{
						return null;
					}
				}
			}

			public sealed class Spawn : IMessage<BattleLib_UpdateResult.Types.Spawn>, IMessage, IEquatable<BattleLib_UpdateResult.Types.Spawn>, IDeepCloneable<BattleLib_UpdateResult.Types.Spawn>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.Spawn> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int UnitContentIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private ulong unitContentId_;

				[FieldOffset(Offset="0x0")]
				public const int MaxHpFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private uint maxHp_;

				[FieldOffset(Offset="0x0")]
				public const int XFieldNumber = 4;

				[FieldOffset(Offset="0x24")]
				private float x_;

				[FieldOffset(Offset="0x0")]
				public const int YFieldNumber = 5;

				[FieldOffset(Offset="0x28")]
				private float y_;

				[FieldOffset(Offset="0x0")]
				public const int UnitIdFieldNumber = 6;

				[FieldOffset(Offset="0x2C")]
				private uint unitId_;

				[FieldOffset(Offset="0x0")]
				public const int PlayerIdFieldNumber = 7;

				[FieldOffset(Offset="0x30")]
				private uint playerId_;

				[FieldOffset(Offset="0x0")]
				public const int TeamIdFieldNumber = 8;

				[FieldOffset(Offset="0x34")]
				private uint teamId_;

				[FieldOffset(Offset="0x0")]
				public const int SpawnIndexFieldNumber = 9;

				[FieldOffset(Offset="0x38")]
				private uint spawnIndex_;

				[FieldOffset(Offset="0x0")]
				public const int AltPrefabIdFieldNumber = 10;

				[FieldOffset(Offset="0x3C")]
				private uint altPrefabId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D288", Offset="0x109D288")]
				public uint AltPrefabId
				{
					[Address(RVA="0x202FA00", Offset="0x202FA00", VA="0x202FA00")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202FA08", Offset="0x202FA08", VA="0x202FA08")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D1E8", Offset="0x109D1E8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x202F688", Offset="0x202F688", VA="0x202F688")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D218", Offset="0x109D218")]
				public uint MaxHp
				{
					[Address(RVA="0x202F990", Offset="0x202F990", VA="0x202F990")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202F998", Offset="0x202F998", VA="0x202F998")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D1D8", Offset="0x109D1D8")]
				public static MessageParser<BattleLib_UpdateResult.Types.Spawn> Parser
				{
					[Address(RVA="0x202F620", Offset="0x202F620", VA="0x202F620")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D1F8", Offset="0x109D1F8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x202F778", Offset="0x202F778", VA="0x202F778", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D258", Offset="0x109D258")]
				public uint PlayerId
				{
					[Address(RVA="0x202F9D0", Offset="0x202F9D0", VA="0x202F9D0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202F9D8", Offset="0x202F9D8", VA="0x202F9D8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D278", Offset="0x109D278")]
				public uint SpawnIndex
				{
					[Address(RVA="0x202F9F0", Offset="0x202F9F0", VA="0x202F9F0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202F9F8", Offset="0x202F9F8", VA="0x202F9F8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D268", Offset="0x109D268")]
				public uint TeamId
				{
					[Address(RVA="0x202F9E0", Offset="0x202F9E0", VA="0x202F9E0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202F9E8", Offset="0x202F9E8", VA="0x202F9E8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D208", Offset="0x109D208")]
				public ulong UnitContentId
				{
					[Address(RVA="0x202F980", Offset="0x202F980", VA="0x202F980")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x202F988", Offset="0x202F988", VA="0x202F988")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D248", Offset="0x109D248")]
				public uint UnitId
				{
					[Address(RVA="0x202F9C0", Offset="0x202F9C0", VA="0x202F9C0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x202F9C8", Offset="0x202F9C8", VA="0x202F9C8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D228", Offset="0x109D228")]
				public float X
				{
					[Address(RVA="0x202F9A0", Offset="0x202F9A0", VA="0x202F9A0")]
					get
					{
						return new float();
					}
					[Address(RVA="0x202F9A8", Offset="0x202F9A8", VA="0x202F9A8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D238", Offset="0x109D238")]
				public float Y
				{
					[Address(RVA="0x202F9B0", Offset="0x202F9B0", VA="0x202F9B0")]
					get
					{
						return new float();
					}
					[Address(RVA="0x202F9B8", Offset="0x202F9B8", VA="0x202F9B8")]
					set
					{
					}
				}

				[Address(RVA="0x20306A4", Offset="0x20306A4", VA="0x20306A4")]
				static Spawn()
				{
				}

				[Address(RVA="0x202F7D4", Offset="0x202F7D4", VA="0x202F7D4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E9A4", Offset="0x108E9A4")]
				public Spawn()
				{
				}

				[Address(RVA="0x202F7DC", Offset="0x202F7DC", VA="0x202F7DC")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E9B4", Offset="0x108E9B4")]
				public Spawn(BattleLib_UpdateResult.Types.Spawn other)
				{
				}

				[Address(RVA="0x2030204", Offset="0x2030204", VA="0x2030204", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EA24", Offset="0x108EA24")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x202F920", Offset="0x202F920", VA="0x202F920", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E9C4", Offset="0x108E9C4")]
				public BattleLib_UpdateResult.Types.Spawn Clone()
				{
					return null;
				}

				[Address(RVA="0x202FA10", Offset="0x202FA10", VA="0x202FA10", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E9D4", Offset="0x108E9D4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x202FA84", Offset="0x202FA84", VA="0x202FA84", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E9E4", Offset="0x108E9E4")]
				public bool Equals(BattleLib_UpdateResult.Types.Spawn other)
				{
					return new bool();
				}

				[Address(RVA="0x202FC28", Offset="0x202FC28", VA="0x202FC28", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E9F4", Offset="0x108E9F4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x2030428", Offset="0x2030428", VA="0x2030428", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EA34", Offset="0x108EA34")]
				public void MergeFrom(BattleLib_UpdateResult.Types.Spawn other)
				{
				}

				[Address(RVA="0x20304D0", Offset="0x20304D0", VA="0x20304D0", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EA44", Offset="0x108EA44")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x202FE28", Offset="0x202FE28", VA="0x202FE28", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EA04", Offset="0x108EA04")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x202FE90", Offset="0x202FE90", VA="0x202FE90", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EA14", Offset="0x108EA14")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051724", Offset="0x1051724")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.Spawn.<>c <>9;

					[Address(RVA="0x203077C", Offset="0x203077C", VA="0x203077C")]
					static <>c()
					{
					}

					[Address(RVA="0x20307E0", Offset="0x20307E0", VA="0x20307E0")]
					public <>c()
					{
					}

					[Address(RVA="0x20307E8", Offset="0x20307E8", VA="0x20307E8")]
					internal BattleLib_UpdateResult.Types.Spawn <.cctor>b__65_0()
					{
						return null;
					}
				}
			}

			public sealed class SpellHand : IMessage<BattleLib_UpdateResult.Types.SpellHand>, IMessage, IEquatable<BattleLib_UpdateResult.Types.SpellHand>, IDeepCloneable<BattleLib_UpdateResult.Types.SpellHand>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.SpellHand> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int PlayerIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint playerId_;

				[FieldOffset(Offset="0x0")]
				public const int SpellsFieldNumber = 2;

				[FieldOffset(Offset="0x8")]
				private readonly static FieldCodec<BattleLib_UpdateResult.Types.AbilityCard> _repeated_spells_codec;

				[FieldOffset(Offset="0x20")]
				private readonly RepeatedField<BattleLib_UpdateResult.Types.AbilityCard> spells_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D758", Offset="0x109D758")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x20308AC", Offset="0x20308AC", VA="0x20308AC")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D748", Offset="0x109D748")]
				public static MessageParser<BattleLib_UpdateResult.Types.SpellHand> Parser
				{
					[Address(RVA="0x2030844", Offset="0x2030844", VA="0x2030844")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D768", Offset="0x109D768")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x203099C", Offset="0x203099C", VA="0x203099C", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D778", Offset="0x109D778")]
				public uint PlayerId
				{
					[Address(RVA="0x2030B80", Offset="0x2030B80", VA="0x2030B80")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2030B88", Offset="0x2030B88", VA="0x2030B88")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D788", Offset="0x109D788")]
				public RepeatedField<BattleLib_UpdateResult.Types.AbilityCard> Spells
				{
					[Address(RVA="0x2030B90", Offset="0x2030B90", VA="0x2030B90")]
					get
					{
						return null;
					}
				}

				[Address(RVA="0x2031184", Offset="0x2031184", VA="0x2031184")]
				static SpellHand()
				{
				}

				[Address(RVA="0x20309F8", Offset="0x20309F8", VA="0x20309F8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F134", Offset="0x108F134")]
				public SpellHand()
				{
				}

				[Address(RVA="0x2030A68", Offset="0x2030A68", VA="0x2030A68")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F144", Offset="0x108F144")]
				public SpellHand(BattleLib_UpdateResult.Types.SpellHand other)
				{
				}

				[Address(RVA="0x2030EE0", Offset="0x2030EE0", VA="0x2030EE0", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F1B4", Offset="0x108F1B4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2030B20", Offset="0x2030B20", VA="0x2030B20", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F154", Offset="0x108F154")]
				public BattleLib_UpdateResult.Types.SpellHand Clone()
				{
					return null;
				}

				[Address(RVA="0x2030B98", Offset="0x2030B98", VA="0x2030B98", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F164", Offset="0x108F164")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2030C0C", Offset="0x2030C0C", VA="0x2030C0C", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F174", Offset="0x108F174")]
				public bool Equals(BattleLib_UpdateResult.Types.SpellHand other)
				{
					return new bool();
				}

				[Address(RVA="0x2030CCC", Offset="0x2030CCC", VA="0x2030CCC", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F184", Offset="0x108F184")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x2030FDC", Offset="0x2030FDC", VA="0x2030FDC", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F1C4", Offset="0x108F1C4")]
				public void MergeFrom(BattleLib_UpdateResult.Types.SpellHand other)
				{
				}

				[Address(RVA="0x2031078", Offset="0x2031078", VA="0x2031078", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F1D4", Offset="0x108F1D4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x2030D5C", Offset="0x2030D5C", VA="0x2030D5C", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F194", Offset="0x108F194")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x2030DC4", Offset="0x2030DC4", VA="0x2030DC4", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F1A4", Offset="0x108F1A4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10517E4", Offset="0x10517E4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.SpellHand.<>c <>9;

					[Address(RVA="0x20312A8", Offset="0x20312A8", VA="0x20312A8")]
					static <>c()
					{
					}

					[Address(RVA="0x203130C", Offset="0x203130C", VA="0x203130C")]
					public <>c()
					{
					}

					[Address(RVA="0x2031314", Offset="0x2031314", VA="0x2031314")]
					internal BattleLib_UpdateResult.Types.SpellHand <.cctor>b__30_0()
					{
						return null;
					}
				}
			}

			public sealed class TeamResult : IMessage<BattleLib_UpdateResult.Types.TeamResult>, IMessage, IEquatable<BattleLib_UpdateResult.Types.TeamResult>, IDeepCloneable<BattleLib_UpdateResult.Types.TeamResult>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.TeamResult> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int TeamIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private int teamId_;

				[FieldOffset(Offset="0x0")]
				public const int StarCountFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private ulong starCount_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D118", Offset="0x109D118")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x20313D4", Offset="0x20313D4", VA="0x20313D4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D108", Offset="0x109D108")]
				public static MessageParser<BattleLib_UpdateResult.Types.TeamResult> Parser
				{
					[Address(RVA="0x203136C", Offset="0x203136C", VA="0x203136C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D128", Offset="0x109D128")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x20314C4", Offset="0x20314C4", VA="0x20314C4", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D148", Offset="0x109D148")]
				public ulong StarCount
				{
					[Address(RVA="0x2031618", Offset="0x2031618", VA="0x2031618")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x2031620", Offset="0x2031620", VA="0x2031620")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D138", Offset="0x109D138")]
				public int TeamId
				{
					[Address(RVA="0x2031608", Offset="0x2031608", VA="0x2031608")]
					get
					{
						return new int();
					}
					[Address(RVA="0x2031610", Offset="0x2031610", VA="0x2031610")]
					set
					{
					}
				}

				[Address(RVA="0x2031A94", Offset="0x2031A94", VA="0x2031A94")]
				static TeamResult()
				{
				}

				[Address(RVA="0x2031520", Offset="0x2031520", VA="0x2031520")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E844", Offset="0x108E844")]
				public TeamResult()
				{
				}

				[Address(RVA="0x2031528", Offset="0x2031528", VA="0x2031528")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E854", Offset="0x108E854")]
				public TeamResult(BattleLib_UpdateResult.Types.TeamResult other)
				{
				}

				[Address(RVA="0x20318D0", Offset="0x20318D0", VA="0x20318D0", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E8C4", Offset="0x108E8C4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x20315A8", Offset="0x20315A8", VA="0x20315A8", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E864", Offset="0x108E864")]
				public BattleLib_UpdateResult.Types.TeamResult Clone()
				{
					return null;
				}

				[Address(RVA="0x2031628", Offset="0x2031628", VA="0x2031628", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E874", Offset="0x108E874")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x203169C", Offset="0x203169C", VA="0x203169C", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E884", Offset="0x108E884")]
				public bool Equals(BattleLib_UpdateResult.Types.TeamResult other)
				{
					return new bool();
				}

				[Address(RVA="0x20316E8", Offset="0x20316E8", VA="0x20316E8", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E894", Offset="0x108E894")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x20319A4", Offset="0x20319A4", VA="0x20319A4", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E8D4", Offset="0x108E8D4")]
				public void MergeFrom(BattleLib_UpdateResult.Types.TeamResult other)
				{
				}

				[Address(RVA="0x20319F0", Offset="0x20319F0", VA="0x20319F0", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E8E4", Offset="0x108E8E4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x2031770", Offset="0x2031770", VA="0x2031770", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E8A4", Offset="0x108E8A4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x20317D8", Offset="0x20317D8", VA="0x20317D8", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E8B4", Offset="0x108E8B4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10516F4", Offset="0x10516F4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.TeamResult.<>c <>9;

					[Address(RVA="0x2031B6C", Offset="0x2031B6C", VA="0x2031B6C")]
					static <>c()
					{
					}

					[Address(RVA="0x2031BD0", Offset="0x2031BD0", VA="0x2031BD0")]
					public <>c()
					{
					}

					[Address(RVA="0x2031BD8", Offset="0x2031BD8", VA="0x2031BD8")]
					internal BattleLib_UpdateResult.Types.TeamResult <.cctor>b__30_0()
					{
						return null;
					}
				}
			}

			public sealed class UnitEffects : IMessage<BattleLib_UpdateResult.Types.UnitEffects>, IMessage, IEquatable<BattleLib_UpdateResult.Types.UnitEffects>, IDeepCloneable<BattleLib_UpdateResult.Types.UnitEffects>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.UnitEffects> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int UnitIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint unitId_;

				[FieldOffset(Offset="0x0")]
				public const int EffectsFieldNumber = 2;

				[FieldOffset(Offset="0x8")]
				private readonly static FieldCodec<BattleLib_UpdateResult.Types.Effect> _repeated_effects_codec;

				[FieldOffset(Offset="0x20")]
				private readonly RepeatedField<BattleLib_UpdateResult.Types.Effect> effects_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DCA8", Offset="0x109DCA8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x2031C9C", Offset="0x2031C9C", VA="0x2031C9C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DCD8", Offset="0x109DCD8")]
				public RepeatedField<BattleLib_UpdateResult.Types.Effect> Effects
				{
					[Address(RVA="0x2031F80", Offset="0x2031F80", VA="0x2031F80")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DC98", Offset="0x109DC98")]
				public static MessageParser<BattleLib_UpdateResult.Types.UnitEffects> Parser
				{
					[Address(RVA="0x2031C34", Offset="0x2031C34", VA="0x2031C34")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DCB8", Offset="0x109DCB8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x2031D8C", Offset="0x2031D8C", VA="0x2031D8C", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DCC8", Offset="0x109DCC8")]
				public uint UnitId
				{
					[Address(RVA="0x2031F70", Offset="0x2031F70", VA="0x2031F70")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2031F78", Offset="0x2031F78", VA="0x2031F78")]
					set
					{
					}
				}

				[Address(RVA="0x2032574", Offset="0x2032574", VA="0x2032574")]
				static UnitEffects()
				{
				}

				[Address(RVA="0x2031DE8", Offset="0x2031DE8", VA="0x2031DE8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FAD4", Offset="0x108FAD4")]
				public UnitEffects()
				{
				}

				[Address(RVA="0x2031E58", Offset="0x2031E58", VA="0x2031E58")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FAE4", Offset="0x108FAE4")]
				public UnitEffects(BattleLib_UpdateResult.Types.UnitEffects other)
				{
				}

				[Address(RVA="0x20322D0", Offset="0x20322D0", VA="0x20322D0", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FB54", Offset="0x108FB54")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2031F10", Offset="0x2031F10", VA="0x2031F10", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FAF4", Offset="0x108FAF4")]
				public BattleLib_UpdateResult.Types.UnitEffects Clone()
				{
					return null;
				}

				[Address(RVA="0x2031F88", Offset="0x2031F88", VA="0x2031F88", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FB04", Offset="0x108FB04")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2031FFC", Offset="0x2031FFC", VA="0x2031FFC", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FB14", Offset="0x108FB14")]
				public bool Equals(BattleLib_UpdateResult.Types.UnitEffects other)
				{
					return new bool();
				}

				[Address(RVA="0x20320BC", Offset="0x20320BC", VA="0x20320BC", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FB24", Offset="0x108FB24")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x20323CC", Offset="0x20323CC", VA="0x20323CC", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FB64", Offset="0x108FB64")]
				public void MergeFrom(BattleLib_UpdateResult.Types.UnitEffects other)
				{
				}

				[Address(RVA="0x2032468", Offset="0x2032468", VA="0x2032468", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FB74", Offset="0x108FB74")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x203214C", Offset="0x203214C", VA="0x203214C", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FB34", Offset="0x108FB34")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x20321B4", Offset="0x20321B4", VA="0x20321B4", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FB44", Offset="0x108FB44")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10518D4", Offset="0x10518D4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.UnitEffects.<>c <>9;

					[Address(RVA="0x2032694", Offset="0x2032694", VA="0x2032694")]
					static <>c()
					{
					}

					[Address(RVA="0x20326F8", Offset="0x20326F8", VA="0x20326F8")]
					public <>c()
					{
					}

					[Address(RVA="0x2032700", Offset="0x2032700", VA="0x2032700")]
					internal BattleLib_UpdateResult.Types.UnitEffects <.cctor>b__30_0()
					{
						return null;
					}
				}
			}

			public sealed class UnitHealth : IMessage<BattleLib_UpdateResult.Types.UnitHealth>, IMessage, IEquatable<BattleLib_UpdateResult.Types.UnitHealth>, IDeepCloneable<BattleLib_UpdateResult.Types.UnitHealth>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.UnitHealth> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int HealthPercentFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private float healthPercent_;

				[FieldOffset(Offset="0x0")]
				public const int ShieldPercentFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private float shieldPercent_;

				[FieldOffset(Offset="0x0")]
				public const int UnitIdFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private uint unitId_;

				[FieldOffset(Offset="0x0")]
				public const int IsCcImmuneFieldNumber = 4;

				[FieldOffset(Offset="0x24")]
				private bool isCcImmune_;

				[FieldOffset(Offset="0x0")]
				public const int SpeedBarPercentFieldNumber = 5;

				[FieldOffset(Offset="0x28")]
				private float speedBarPercent_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D368", Offset="0x109D368")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x20327C0", Offset="0x20327C0", VA="0x20327C0")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D388", Offset="0x109D388")]
				public float HealthPercent
				{
					[Address(RVA="0x2032A48", Offset="0x2032A48", VA="0x2032A48")]
					get
					{
						return new float();
					}
					[Address(RVA="0x2032A50", Offset="0x2032A50", VA="0x2032A50")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D3B8", Offset="0x109D3B8")]
				public bool IsCcImmune
				{
					[Address(RVA="0x2032A78", Offset="0x2032A78", VA="0x2032A78")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x2032A80", Offset="0x2032A80", VA="0x2032A80")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D358", Offset="0x109D358")]
				public static MessageParser<BattleLib_UpdateResult.Types.UnitHealth> Parser
				{
					[Address(RVA="0x2032758", Offset="0x2032758", VA="0x2032758")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D378", Offset="0x109D378")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x20328B0", Offset="0x20328B0", VA="0x20328B0", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D398", Offset="0x109D398")]
				public float ShieldPercent
				{
					[Address(RVA="0x2032A58", Offset="0x2032A58", VA="0x2032A58")]
					get
					{
						return new float();
					}
					[Address(RVA="0x2032A60", Offset="0x2032A60", VA="0x2032A60")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D3C8", Offset="0x109D3C8")]
				public float SpeedBarPercent
				{
					[Address(RVA="0x2032A8C", Offset="0x2032A8C", VA="0x2032A8C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x2032A94", Offset="0x2032A94", VA="0x2032A94")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D3A8", Offset="0x109D3A8")]
				public uint UnitId
				{
					[Address(RVA="0x2032A68", Offset="0x2032A68", VA="0x2032A68")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2032A70", Offset="0x2032A70", VA="0x2032A70")]
					set
					{
					}
				}

				[Address(RVA="0x2033398", Offset="0x2033398", VA="0x2033398")]
				static UnitHealth()
				{
				}

				[Address(RVA="0x203290C", Offset="0x203290C", VA="0x203290C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EBB4", Offset="0x108EBB4")]
				public UnitHealth()
				{
				}

				[Address(RVA="0x2032914", Offset="0x2032914", VA="0x2032914")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EBC4", Offset="0x108EBC4")]
				public UnitHealth(BattleLib_UpdateResult.Types.UnitHealth other)
				{
				}

				[Address(RVA="0x203311C", Offset="0x203311C", VA="0x203311C", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EC34", Offset="0x108EC34")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x20329E8", Offset="0x20329E8", VA="0x20329E8", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EBD4", Offset="0x108EBD4")]
				public BattleLib_UpdateResult.Types.UnitHealth Clone()
				{
					return null;
				}

				[Address(RVA="0x2032A9C", Offset="0x2032A9C", VA="0x2032A9C", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EBE4", Offset="0x108EBE4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2032B10", Offset="0x2032B10", VA="0x2032B10", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EBF4", Offset="0x108EBF4")]
				public bool Equals(BattleLib_UpdateResult.Types.UnitHealth other)
				{
					return new bool();
				}

				[Address(RVA="0x2032CC4", Offset="0x2032CC4", VA="0x2032CC4", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EC04", Offset="0x108EC04")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x20331F4", Offset="0x20331F4", VA="0x20331F4", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EC44", Offset="0x108EC44")]
				public void MergeFrom(BattleLib_UpdateResult.Types.UnitHealth other)
				{
				}

				[Address(RVA="0x2033270", Offset="0x2033270", VA="0x2033270", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EC54", Offset="0x108EC54")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x2032E98", Offset="0x2032E98", VA="0x2032E98", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EC14", Offset="0x108EC14")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x2032F00", Offset="0x2032F00", VA="0x2032F00", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EC24", Offset="0x108EC24")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051754", Offset="0x1051754")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.UnitHealth.<>c <>9;

					[Address(RVA="0x2033470", Offset="0x2033470", VA="0x2033470")]
					static <>c()
					{
					}

					[Address(RVA="0x20334D4", Offset="0x20334D4", VA="0x20334D4")]
					public <>c()
					{
					}

					[Address(RVA="0x20334DC", Offset="0x20334DC", VA="0x20334DC")]
					internal BattleLib_UpdateResult.Types.UnitHealth <.cctor>b__45_0()
					{
						return null;
					}
				}
			}

			public sealed class UnitHpDecay : IMessage<BattleLib_UpdateResult.Types.UnitHpDecay>, IMessage, IEquatable<BattleLib_UpdateResult.Types.UnitHpDecay>, IDeepCloneable<BattleLib_UpdateResult.Types.UnitHpDecay>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.UnitHpDecay> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int UnitIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint unitId_;

				[FieldOffset(Offset="0x0")]
				public const int HpDecayFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint hpDecay_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D2A8", Offset="0x109D2A8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x20335A0", Offset="0x20335A0", VA="0x20335A0")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D2D8", Offset="0x109D2D8")]
				public uint HpDecay
				{
					[Address(RVA="0x20337E4", Offset="0x20337E4", VA="0x20337E4")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x20337EC", Offset="0x20337EC", VA="0x20337EC")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D298", Offset="0x109D298")]
				public static MessageParser<BattleLib_UpdateResult.Types.UnitHpDecay> Parser
				{
					[Address(RVA="0x2033538", Offset="0x2033538", VA="0x2033538")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D2B8", Offset="0x109D2B8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x2033690", Offset="0x2033690", VA="0x2033690", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D2C8", Offset="0x109D2C8")]
				public uint UnitId
				{
					[Address(RVA="0x20337D4", Offset="0x20337D4", VA="0x20337D4")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x20337DC", Offset="0x20337DC", VA="0x20337DC")]
					set
					{
					}
				}

				[Address(RVA="0x2033C5C", Offset="0x2033C5C", VA="0x2033C5C")]
				static UnitHpDecay()
				{
				}

				[Address(RVA="0x20336EC", Offset="0x20336EC", VA="0x20336EC")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EA54", Offset="0x108EA54")]
				public UnitHpDecay()
				{
				}

				[Address(RVA="0x20336F4", Offset="0x20336F4", VA="0x20336F4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EA64", Offset="0x108EA64")]
				public UnitHpDecay(BattleLib_UpdateResult.Types.UnitHpDecay other)
				{
				}

				[Address(RVA="0x2033A98", Offset="0x2033A98", VA="0x2033A98", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EAD4", Offset="0x108EAD4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2033774", Offset="0x2033774", VA="0x2033774", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EA74", Offset="0x108EA74")]
				public BattleLib_UpdateResult.Types.UnitHpDecay Clone()
				{
					return null;
				}

				[Address(RVA="0x20337F4", Offset="0x20337F4", VA="0x20337F4", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EA84", Offset="0x108EA84")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2033868", Offset="0x2033868", VA="0x2033868", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EA94", Offset="0x108EA94")]
				public bool Equals(BattleLib_UpdateResult.Types.UnitHpDecay other)
				{
					return new bool();
				}

				[Address(RVA="0x20338B4", Offset="0x20338B4", VA="0x20338B4", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EAA4", Offset="0x108EAA4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x2033B6C", Offset="0x2033B6C", VA="0x2033B6C", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EAE4", Offset="0x108EAE4")]
				public void MergeFrom(BattleLib_UpdateResult.Types.UnitHpDecay other)
				{
				}

				[Address(RVA="0x2033BB8", Offset="0x2033BB8", VA="0x2033BB8", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EAF4", Offset="0x108EAF4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x2033938", Offset="0x2033938", VA="0x2033938", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EAB4", Offset="0x108EAB4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x20339A0", Offset="0x20339A0", VA="0x20339A0", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EAC4", Offset="0x108EAC4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051734", Offset="0x1051734")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.UnitHpDecay.<>c <>9;

					[Address(RVA="0x2033D34", Offset="0x2033D34", VA="0x2033D34")]
					static <>c()
					{
					}

					[Address(RVA="0x2033D98", Offset="0x2033D98", VA="0x2033D98")]
					public <>c()
					{
					}

					[Address(RVA="0x2033DA0", Offset="0x2033DA0", VA="0x2033DA0")]
					internal BattleLib_UpdateResult.Types.UnitHpDecay <.cctor>b__30_0()
					{
						return null;
					}
				}
			}

			public sealed class UnitPosition : IMessage<BattleLib_UpdateResult.Types.UnitPosition>, IMessage, IEquatable<BattleLib_UpdateResult.Types.UnitPosition>, IDeepCloneable<BattleLib_UpdateResult.Types.UnitPosition>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.UnitPosition> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int XFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private float x_;

				[FieldOffset(Offset="0x0")]
				public const int YFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private float y_;

				[FieldOffset(Offset="0x0")]
				public const int UnitIdFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private uint unitId_;

				[FieldOffset(Offset="0x0")]
				public const int TeleportFieldNumber = 4;

				[FieldOffset(Offset="0x24")]
				private bool teleport_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D2F8", Offset="0x109D2F8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x2033E64", Offset="0x2033E64", VA="0x2033E64")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D2E8", Offset="0x109D2E8")]
				public static MessageParser<BattleLib_UpdateResult.Types.UnitPosition> Parser
				{
					[Address(RVA="0x2033DFC", Offset="0x2033DFC", VA="0x2033DFC")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D308", Offset="0x109D308")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x2033F54", Offset="0x2033F54", VA="0x2033F54", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D348", Offset="0x109D348")]
				public bool Teleport
				{
					[Address(RVA="0x2034100", Offset="0x2034100", VA="0x2034100")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x2034108", Offset="0x2034108", VA="0x2034108")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D338", Offset="0x109D338")]
				public uint UnitId
				{
					[Address(RVA="0x20340F0", Offset="0x20340F0", VA="0x20340F0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x20340F8", Offset="0x20340F8", VA="0x20340F8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D318", Offset="0x109D318")]
				public float X
				{
					[Address(RVA="0x20340D0", Offset="0x20340D0", VA="0x20340D0")]
					get
					{
						return new float();
					}
					[Address(RVA="0x20340D8", Offset="0x20340D8", VA="0x20340D8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D328", Offset="0x109D328")]
				public float Y
				{
					[Address(RVA="0x20340E0", Offset="0x20340E0", VA="0x20340E0")]
					get
					{
						return new float();
					}
					[Address(RVA="0x20340E8", Offset="0x20340E8", VA="0x20340E8")]
					set
					{
					}
				}

				[Address(RVA="0x20348C0", Offset="0x20348C0", VA="0x20348C0")]
				static UnitPosition()
				{
				}

				[Address(RVA="0x2033FB0", Offset="0x2033FB0", VA="0x2033FB0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EB04", Offset="0x108EB04")]
				public UnitPosition()
				{
				}

				[Address(RVA="0x2033FB8", Offset="0x2033FB8", VA="0x2033FB8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EB14", Offset="0x108EB14")]
				public UnitPosition(BattleLib_UpdateResult.Types.UnitPosition other)
				{
				}

				[Address(RVA="0x203468C", Offset="0x203468C", VA="0x203468C", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EB84", Offset="0x108EB84")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2034070", Offset="0x2034070", VA="0x2034070", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EB24", Offset="0x108EB24")]
				public BattleLib_UpdateResult.Types.UnitPosition Clone()
				{
					return null;
				}

				[Address(RVA="0x2034114", Offset="0x2034114", VA="0x2034114", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EB34", Offset="0x108EB34")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2034188", Offset="0x2034188", VA="0x2034188", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EB44", Offset="0x108EB44")]
				public bool Equals(BattleLib_UpdateResult.Types.UnitPosition other)
				{
					return new bool();
				}

				[Address(RVA="0x20342EC", Offset="0x20342EC", VA="0x20342EC", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EB54", Offset="0x108EB54")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x2034754", Offset="0x2034754", VA="0x2034754", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EB94", Offset="0x108EB94")]
				public void MergeFrom(BattleLib_UpdateResult.Types.UnitPosition other)
				{
				}

				[Address(RVA="0x20347C0", Offset="0x20347C0", VA="0x20347C0", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EBA4", Offset="0x108EBA4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x2034464", Offset="0x2034464", VA="0x2034464", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EB64", Offset="0x108EB64")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x20344CC", Offset="0x20344CC", VA="0x20344CC", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EB74", Offset="0x108EB74")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051744", Offset="0x1051744")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.UnitPosition.<>c <>9;

					[Address(RVA="0x2034998", Offset="0x2034998", VA="0x2034998")]
					static <>c()
					{
					}

					[Address(RVA="0x20349FC", Offset="0x20349FC", VA="0x20349FC")]
					public <>c()
					{
					}

					[Address(RVA="0x2034A04", Offset="0x2034A04", VA="0x2034A04")]
					internal BattleLib_UpdateResult.Types.UnitPosition <.cctor>b__40_0()
					{
						return null;
					}
				}
			}

			public sealed class UnitResult : IMessage<BattleLib_UpdateResult.Types.UnitResult>, IMessage, IEquatable<BattleLib_UpdateResult.Types.UnitResult>, IDeepCloneable<BattleLib_UpdateResult.Types.UnitResult>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.UnitResult> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int HealthPercentFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private float healthPercent_;

				[FieldOffset(Offset="0x0")]
				public const int PersistentIdFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint persistentId_;

				[FieldOffset(Offset="0x0")]
				public const int IsAliveFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private bool isAlive_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D068", Offset="0x109D068")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x2034AC8", Offset="0x2034AC8", VA="0x2034AC8")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D088", Offset="0x109D088")]
				public float HealthPercent
				{
					[Address(RVA="0x2034D18", Offset="0x2034D18", VA="0x2034D18")]
					get
					{
						return new float();
					}
					[Address(RVA="0x2034D20", Offset="0x2034D20", VA="0x2034D20")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D0A8", Offset="0x109D0A8")]
				public bool IsAlive
				{
					[Address(RVA="0x2034D38", Offset="0x2034D38", VA="0x2034D38")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x2034D40", Offset="0x2034D40", VA="0x2034D40")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D058", Offset="0x109D058")]
				public static MessageParser<BattleLib_UpdateResult.Types.UnitResult> Parser
				{
					[Address(RVA="0x2034A60", Offset="0x2034A60", VA="0x2034A60")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D078", Offset="0x109D078")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x2034BB8", Offset="0x2034BB8", VA="0x2034BB8", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D098", Offset="0x109D098")]
				public uint PersistentId
				{
					[Address(RVA="0x2034D28", Offset="0x2034D28", VA="0x2034D28")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2034D30", Offset="0x2034D30", VA="0x2034D30")]
					set
					{
					}
				}

				[Address(RVA="0x203539C", Offset="0x203539C", VA="0x203539C")]
				static UnitResult()
				{
				}

				[Address(RVA="0x2034C14", Offset="0x2034C14", VA="0x2034C14")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E6E4", Offset="0x108E6E4")]
				public UnitResult()
				{
				}

				[Address(RVA="0x2034C1C", Offset="0x2034C1C", VA="0x2034C1C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E6F4", Offset="0x108E6F4")]
				public UnitResult(BattleLib_UpdateResult.Types.UnitResult other)
				{
				}

				[Address(RVA="0x20351AC", Offset="0x20351AC", VA="0x20351AC", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E764", Offset="0x108E764")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2034CB8", Offset="0x2034CB8", VA="0x2034CB8", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E704", Offset="0x108E704")]
				public BattleLib_UpdateResult.Types.UnitResult Clone()
				{
					return null;
				}

				[Address(RVA="0x2034D4C", Offset="0x2034D4C", VA="0x2034D4C", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E714", Offset="0x108E714")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2034DC0", Offset="0x2034DC0", VA="0x2034DC0", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E724", Offset="0x108E724")]
				public bool Equals(BattleLib_UpdateResult.Types.UnitResult other)
				{
					return new bool();
				}

				[Address(RVA="0x2034ED4", Offset="0x2034ED4", VA="0x2034ED4", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E734", Offset="0x108E734")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x2035268", Offset="0x2035268", VA="0x2035268", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E774", Offset="0x108E774")]
				public void MergeFrom(BattleLib_UpdateResult.Types.UnitResult other)
				{
				}

				[Address(RVA="0x20352C4", Offset="0x20352C4", VA="0x20352C4", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E784", Offset="0x108E784")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x2034FE0", Offset="0x2034FE0", VA="0x2034FE0", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E744", Offset="0x108E744")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x2035048", Offset="0x2035048", VA="0x2035048", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108E754", Offset="0x108E754")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10516D4", Offset="0x10516D4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.UnitResult.<>c <>9;

					[Address(RVA="0x2035474", Offset="0x2035474", VA="0x2035474")]
					static <>c()
					{
					}

					[Address(RVA="0x20354D8", Offset="0x20354D8", VA="0x20354D8")]
					public <>c()
					{
					}

					[Address(RVA="0x20354E0", Offset="0x20354E0", VA="0x20354E0")]
					internal BattleLib_UpdateResult.Types.UnitResult <.cctor>b__35_0()
					{
						return null;
					}
				}
			}

			public sealed class UnitTurnInfo : IMessage<BattleLib_UpdateResult.Types.UnitTurnInfo>, IMessage, IEquatable<BattleLib_UpdateResult.Types.UnitTurnInfo>, IDeepCloneable<BattleLib_UpdateResult.Types.UnitTurnInfo>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.UnitTurnInfo> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int UnitIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint unitId_;

				[FieldOffset(Offset="0x0")]
				public const int SpeedBarPercentFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private float speedBarPercent_;

				[FieldOffset(Offset="0x0")]
				public const int TurnOrderFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private uint turnOrder_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DD78", Offset="0x109DD78")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x20355A4", Offset="0x20355A4", VA="0x20355A4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DD68", Offset="0x109DD68")]
				public static MessageParser<BattleLib_UpdateResult.Types.UnitTurnInfo> Parser
				{
					[Address(RVA="0x203553C", Offset="0x203553C", VA="0x203553C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DD88", Offset="0x109DD88")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x2035694", Offset="0x2035694", VA="0x2035694", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DDA8", Offset="0x109DDA8")]
				public float SpeedBarPercent
				{
					[Address(RVA="0x2035804", Offset="0x2035804", VA="0x2035804")]
					get
					{
						return new float();
					}
					[Address(RVA="0x203580C", Offset="0x203580C", VA="0x203580C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DDB8", Offset="0x109DDB8")]
				public uint TurnOrder
				{
					[Address(RVA="0x2035814", Offset="0x2035814", VA="0x2035814")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x203581C", Offset="0x203581C", VA="0x203581C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DD98", Offset="0x109DD98")]
				public uint UnitId
				{
					[Address(RVA="0x20357F4", Offset="0x20357F4", VA="0x20357F4")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x20357FC", Offset="0x20357FC", VA="0x20357FC")]
					set
					{
					}
				}

				[Address(RVA="0x2035E94", Offset="0x2035E94", VA="0x2035E94")]
				static UnitTurnInfo()
				{
				}

				[Address(RVA="0x20356F0", Offset="0x20356F0", VA="0x20356F0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FC34", Offset="0x108FC34")]
				public UnitTurnInfo()
				{
				}

				[Address(RVA="0x20356F8", Offset="0x20356F8", VA="0x20356F8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FC44", Offset="0x108FC44")]
				public UnitTurnInfo(BattleLib_UpdateResult.Types.UnitTurnInfo other)
				{
				}

				[Address(RVA="0x2035C78", Offset="0x2035C78", VA="0x2035C78", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FCB4", Offset="0x108FCB4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2035794", Offset="0x2035794", VA="0x2035794", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FC54", Offset="0x108FC54")]
				public BattleLib_UpdateResult.Types.UnitTurnInfo Clone()
				{
					return null;
				}

				[Address(RVA="0x2035824", Offset="0x2035824", VA="0x2035824", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FC64", Offset="0x108FC64")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2035898", Offset="0x2035898", VA="0x2035898", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FC74", Offset="0x108FC74")]
				public bool Equals(BattleLib_UpdateResult.Types.UnitTurnInfo other)
				{
					return new bool();
				}

				[Address(RVA="0x203599C", Offset="0x203599C", VA="0x203599C", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FC84", Offset="0x108FC84")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x2035D64", Offset="0x2035D64", VA="0x2035D64", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FCC4", Offset="0x108FCC4")]
				public void MergeFrom(BattleLib_UpdateResult.Types.UnitTurnInfo other)
				{
				}

				[Address(RVA="0x2035DC0", Offset="0x2035DC0", VA="0x2035DC0", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FCD4", Offset="0x108FCD4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x2035AB0", Offset="0x2035AB0", VA="0x2035AB0", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FC94", Offset="0x108FC94")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x2035B18", Offset="0x2035B18", VA="0x2035B18", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FCA4", Offset="0x108FCA4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10518F4", Offset="0x10518F4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.UnitTurnInfo.<>c <>9;

					[Address(RVA="0x2035F6C", Offset="0x2035F6C", VA="0x2035F6C")]
					static <>c()
					{
					}

					[Address(RVA="0x2035FD0", Offset="0x2035FD0", VA="0x2035FD0")]
					public <>c()
					{
					}

					[Address(RVA="0x2035FD8", Offset="0x2035FD8", VA="0x2035FD8")]
					internal BattleLib_UpdateResult.Types.UnitTurnInfo <.cctor>b__35_0()
					{
						return null;
					}
				}
			}

			public sealed class UnitTurnStarted : IMessage<BattleLib_UpdateResult.Types.UnitTurnStarted>, IMessage, IEquatable<BattleLib_UpdateResult.Types.UnitTurnStarted>, IDeepCloneable<BattleLib_UpdateResult.Types.UnitTurnStarted>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.UnitTurnStarted> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int UnitIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint unitId_;

				[FieldOffset(Offset="0x0")]
				public const int TurnExpireTimestampFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private long turnExpireTimestamp_;

				[FieldOffset(Offset="0x0")]
				public const int TurnExpireDurationSFieldNumber = 3;

				[FieldOffset(Offset="0x28")]
				private float turnExpireDurationS_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DDD8", Offset="0x109DDD8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x203609C", Offset="0x203609C", VA="0x203609C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DDC8", Offset="0x109DDC8")]
				public static MessageParser<BattleLib_UpdateResult.Types.UnitTurnStarted> Parser
				{
					[Address(RVA="0x2036034", Offset="0x2036034", VA="0x2036034")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DDE8", Offset="0x109DDE8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x203618C", Offset="0x203618C", VA="0x203618C", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DE18", Offset="0x109DE18")]
				public float TurnExpireDurationS
				{
					[Address(RVA="0x203630C", Offset="0x203630C", VA="0x203630C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x2036314", Offset="0x2036314", VA="0x2036314")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DE08", Offset="0x109DE08")]
				public long TurnExpireTimestamp
				{
					[Address(RVA="0x20362FC", Offset="0x20362FC", VA="0x20362FC")]
					get
					{
						return new long();
					}
					[Address(RVA="0x2036304", Offset="0x2036304", VA="0x2036304")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DDF8", Offset="0x109DDF8")]
				public uint UnitId
				{
					[Address(RVA="0x20362EC", Offset="0x20362EC", VA="0x20362EC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x20362F4", Offset="0x20362F4", VA="0x20362F4")]
					set
					{
					}
				}

				[Address(RVA="0x2036990", Offset="0x2036990", VA="0x2036990")]
				static UnitTurnStarted()
				{
				}

				[Address(RVA="0x20361E8", Offset="0x20361E8", VA="0x20361E8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FCE4", Offset="0x108FCE4")]
				public UnitTurnStarted()
				{
				}

				[Address(RVA="0x20361F0", Offset="0x20361F0", VA="0x20361F0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FCF4", Offset="0x108FCF4")]
				public UnitTurnStarted(BattleLib_UpdateResult.Types.UnitTurnStarted other)
				{
				}

				[Address(RVA="0x2036774", Offset="0x2036774", VA="0x2036774", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FD64", Offset="0x108FD64")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x203628C", Offset="0x203628C", VA="0x203628C", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FD04", Offset="0x108FD04")]
				public BattleLib_UpdateResult.Types.UnitTurnStarted Clone()
				{
					return null;
				}

				[Address(RVA="0x203631C", Offset="0x203631C", VA="0x203631C", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FD14", Offset="0x108FD14")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2036390", Offset="0x2036390", VA="0x2036390", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FD24", Offset="0x108FD24")]
				public bool Equals(BattleLib_UpdateResult.Types.UnitTurnStarted other)
				{
					return new bool();
				}

				[Address(RVA="0x2036494", Offset="0x2036494", VA="0x2036494", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FD34", Offset="0x108FD34")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x2036860", Offset="0x2036860", VA="0x2036860", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FD74", Offset="0x108FD74")]
				public void MergeFrom(BattleLib_UpdateResult.Types.UnitTurnStarted other)
				{
				}

				[Address(RVA="0x20368BC", Offset="0x20368BC", VA="0x20368BC", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FD84", Offset="0x108FD84")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x20365AC", Offset="0x20365AC", VA="0x20365AC", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FD44", Offset="0x108FD44")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x2036614", Offset="0x2036614", VA="0x2036614", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108FD54", Offset="0x108FD54")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051904", Offset="0x1051904")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.UnitTurnStarted.<>c <>9;

					[Address(RVA="0x2036A68", Offset="0x2036A68", VA="0x2036A68")]
					static <>c()
					{
					}

					[Address(RVA="0x2036ACC", Offset="0x2036ACC", VA="0x2036ACC")]
					public <>c()
					{
					}

					[Address(RVA="0x2036AD4", Offset="0x2036AD4", VA="0x2036AD4")]
					internal BattleLib_UpdateResult.Types.UnitTurnStarted <.cctor>b__35_0()
					{
						return null;
					}
				}
			}

			public sealed class UseAbilityResponse : IMessage<BattleLib_UpdateResult.Types.UseAbilityResponse>, IMessage, IEquatable<BattleLib_UpdateResult.Types.UseAbilityResponse>, IDeepCloneable<BattleLib_UpdateResult.Types.UseAbilityResponse>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.UseAbilityResponse> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int PlayerIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint playerId_;

				[FieldOffset(Offset="0x0")]
				public const int SourceTypeFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint sourceType_;

				[FieldOffset(Offset="0x0")]
				public const int SourceIdFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private uint sourceId_;

				[FieldOffset(Offset="0x0")]
				public const int AbilityIdFieldNumber = 4;

				[FieldOffset(Offset="0x24")]
				private uint abilityId_;

				[FieldOffset(Offset="0x0")]
				public const int SuccessFieldNumber = 5;

				[FieldOffset(Offset="0x28")]
				private bool success_;

				[FieldOffset(Offset="0x0")]
				public const int FailureCodeFieldNumber = 6;

				[FieldOffset(Offset="0x2C")]
				private uint failureCode_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D5C8", Offset="0x109D5C8")]
				public uint AbilityId
				{
					[Address(RVA="0x2036E6C", Offset="0x2036E6C", VA="0x2036E6C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2036E74", Offset="0x2036E74", VA="0x2036E74")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D578", Offset="0x109D578")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x2036B98", Offset="0x2036B98", VA="0x2036B98")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D5E8", Offset="0x109D5E8")]
				public uint FailureCode
				{
					[Address(RVA="0x2036E90", Offset="0x2036E90", VA="0x2036E90")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2036E98", Offset="0x2036E98", VA="0x2036E98")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D568", Offset="0x109D568")]
				public static MessageParser<BattleLib_UpdateResult.Types.UseAbilityResponse> Parser
				{
					[Address(RVA="0x2036B30", Offset="0x2036B30", VA="0x2036B30")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D588", Offset="0x109D588")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x2036C88", Offset="0x2036C88", VA="0x2036C88", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D598", Offset="0x109D598")]
				public uint PlayerId
				{
					[Address(RVA="0x2036E3C", Offset="0x2036E3C", VA="0x2036E3C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2036E44", Offset="0x2036E44", VA="0x2036E44")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D5B8", Offset="0x109D5B8")]
				public uint SourceId
				{
					[Address(RVA="0x2036E5C", Offset="0x2036E5C", VA="0x2036E5C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2036E64", Offset="0x2036E64", VA="0x2036E64")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D5A8", Offset="0x109D5A8")]
				public uint SourceType
				{
					[Address(RVA="0x2036E4C", Offset="0x2036E4C", VA="0x2036E4C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2036E54", Offset="0x2036E54", VA="0x2036E54")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D5D8", Offset="0x109D5D8")]
				public bool Success
				{
					[Address(RVA="0x2036E7C", Offset="0x2036E7C", VA="0x2036E7C")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x2036E84", Offset="0x2036E84", VA="0x2036E84")]
					set
					{
					}
				}

				[Address(RVA="0x20376DC", Offset="0x20376DC", VA="0x20376DC")]
				static UseAbilityResponse()
				{
				}

				[Address(RVA="0x2036CE4", Offset="0x2036CE4", VA="0x2036CE4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EF24", Offset="0x108EF24")]
				public UseAbilityResponse()
				{
				}

				[Address(RVA="0x2036CEC", Offset="0x2036CEC", VA="0x2036CEC")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EF34", Offset="0x108EF34")]
				public UseAbilityResponse(BattleLib_UpdateResult.Types.UseAbilityResponse other)
				{
				}

				[Address(RVA="0x2037370", Offset="0x2037370", VA="0x2037370", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EFA4", Offset="0x108EFA4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2036DDC", Offset="0x2036DDC", VA="0x2036DDC", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EF44", Offset="0x108EF44")]
				public BattleLib_UpdateResult.Types.UseAbilityResponse Clone()
				{
					return null;
				}

				[Address(RVA="0x2036EA0", Offset="0x2036EA0", VA="0x2036EA0", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EF54", Offset="0x108EF54")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2036F14", Offset="0x2036F14", VA="0x2036F14", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EF64", Offset="0x108EF64")]
				public bool Equals(BattleLib_UpdateResult.Types.UseAbilityResponse other)
				{
					return new bool();
				}

				[Address(RVA="0x2036FB0", Offset="0x2036FB0", VA="0x2036FB0", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EF74", Offset="0x108EF74")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x2037510", Offset="0x2037510", VA="0x2037510", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EFB4", Offset="0x108EFB4")]
				public void MergeFrom(BattleLib_UpdateResult.Types.UseAbilityResponse other)
				{
				}

				[Address(RVA="0x203758C", Offset="0x203758C", VA="0x203758C", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EFC4", Offset="0x108EFC4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x20370AC", Offset="0x20370AC", VA="0x20370AC", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EF84", Offset="0x108EF84")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x2037114", Offset="0x2037114", VA="0x2037114", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108EF94", Offset="0x108EF94")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10517B4", Offset="0x10517B4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.UseAbilityResponse.<>c <>9;

					[Address(RVA="0x20377B4", Offset="0x20377B4", VA="0x20377B4")]
					static <>c()
					{
					}

					[Address(RVA="0x2037818", Offset="0x2037818", VA="0x2037818")]
					public <>c()
					{
					}

					[Address(RVA="0x2037820", Offset="0x2037820", VA="0x2037820")]
					internal BattleLib_UpdateResult.Types.UseAbilityResponse <.cctor>b__50_0()
					{
						return null;
					}
				}
			}

			public sealed class VisualAtPosition : IMessage<BattleLib_UpdateResult.Types.VisualAtPosition>, IMessage, IEquatable<BattleLib_UpdateResult.Types.VisualAtPosition>, IDeepCloneable<BattleLib_UpdateResult.Types.VisualAtPosition>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.VisualAtPosition> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int VisualIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private ulong visualId_;

				[FieldOffset(Offset="0x0")]
				public const int OriginPosFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private BattleLib_UpdateResult.Types.VisualPos originPos_;

				[FieldOffset(Offset="0x0")]
				public const int TargetPosFieldNumber = 3;

				[FieldOffset(Offset="0x28")]
				private BattleLib_UpdateResult.Types.VisualPos targetPos_;

				[FieldOffset(Offset="0x0")]
				public const int ExpireTimeFieldNumber = 4;

				[FieldOffset(Offset="0x30")]
				private float expireTime_;

				[FieldOffset(Offset="0x0")]
				public const int SourceIdFieldNumber = 5;

				[FieldOffset(Offset="0x34")]
				private uint sourceId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D9E8", Offset="0x109D9E8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x20378E4", Offset="0x20378E4", VA="0x20378E4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DA38", Offset="0x109DA38")]
				public float ExpireTime
				{
					[Address(RVA="0x2037BBC", Offset="0x2037BBC", VA="0x2037BBC")]
					get
					{
						return new float();
					}
					[Address(RVA="0x2037BC4", Offset="0x2037BC4", VA="0x2037BC4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DA18", Offset="0x109DA18")]
				public BattleLib_UpdateResult.Types.VisualPos OriginPos
				{
					[Address(RVA="0x2037ACC", Offset="0x2037ACC", VA="0x2037ACC")]
					get
					{
						return null;
					}
					[Address(RVA="0x2037B34", Offset="0x2037B34", VA="0x2037B34")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D9D8", Offset="0x109D9D8")]
				public static MessageParser<BattleLib_UpdateResult.Types.VisualAtPosition> Parser
				{
					[Address(RVA="0x203787C", Offset="0x203787C", VA="0x203787C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D9F8", Offset="0x109D9F8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x20379D4", Offset="0x20379D4", VA="0x20379D4", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DA48", Offset="0x109DA48")]
				public uint SourceId
				{
					[Address(RVA="0x2037BCC", Offset="0x2037BCC", VA="0x2037BCC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2037BD4", Offset="0x2037BD4", VA="0x2037BD4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DA28", Offset="0x109DA28")]
				public BattleLib_UpdateResult.Types.VisualPos TargetPos
				{
					[Address(RVA="0x2037B3C", Offset="0x2037B3C", VA="0x2037B3C")]
					get
					{
						return null;
					}
					[Address(RVA="0x2037B44", Offset="0x2037B44", VA="0x2037B44")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DA08", Offset="0x109DA08")]
				public ulong VisualId
				{
					[Address(RVA="0x2037BAC", Offset="0x2037BAC", VA="0x2037BAC")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x2037BB4", Offset="0x2037BB4", VA="0x2037BB4")]
					set
					{
					}
				}

				[Address(RVA="0x20385C4", Offset="0x20385C4", VA="0x20385C4")]
				static VisualAtPosition()
				{
				}

				[Address(RVA="0x2037A30", Offset="0x2037A30", VA="0x2037A30")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F554", Offset="0x108F554")]
				public VisualAtPosition()
				{
				}

				[Address(RVA="0x2037A38", Offset="0x2037A38", VA="0x2037A38")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F564", Offset="0x108F564")]
				public VisualAtPosition(BattleLib_UpdateResult.Types.VisualAtPosition other)
				{
				}

				[Address(RVA="0x203813C", Offset="0x203813C", VA="0x203813C", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F5D4", Offset="0x108F5D4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2037B4C", Offset="0x2037B4C", VA="0x2037B4C", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F574", Offset="0x108F574")]
				public BattleLib_UpdateResult.Types.VisualAtPosition Clone()
				{
					return null;
				}

				[Address(RVA="0x2037BDC", Offset="0x2037BDC", VA="0x2037BDC", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F584", Offset="0x108F584")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2037C50", Offset="0x2037C50", VA="0x2037C50", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F594", Offset="0x108F594")]
				public bool Equals(BattleLib_UpdateResult.Types.VisualAtPosition other)
				{
					return new bool();
				}

				[Address(RVA="0x2037D7C", Offset="0x2037D7C", VA="0x2037D7C", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F5A4", Offset="0x108F5A4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x20382A0", Offset="0x20382A0", VA="0x20382A0", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F5E4", Offset="0x108F5E4")]
				public void MergeFrom(BattleLib_UpdateResult.Types.VisualAtPosition other)
				{
				}

				[Address(RVA="0x2038430", Offset="0x2038430", VA="0x2038430", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F5F4", Offset="0x108F5F4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x2037EC4", Offset="0x2037EC4", VA="0x2037EC4", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F5B4", Offset="0x108F5B4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x2037F2C", Offset="0x2037F2C", VA="0x2037F2C", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F5C4", Offset="0x108F5C4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051854", Offset="0x1051854")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.VisualAtPosition.<>c <>9;

					[Address(RVA="0x203869C", Offset="0x203869C", VA="0x203869C")]
					static <>c()
					{
					}

					[Address(RVA="0x2038700", Offset="0x2038700", VA="0x2038700")]
					public <>c()
					{
					}

					[Address(RVA="0x2038708", Offset="0x2038708", VA="0x2038708")]
					internal BattleLib_UpdateResult.Types.VisualAtPosition <.cctor>b__45_0()
					{
						return null;
					}
				}
			}

			public sealed class VisualInterrupt : IMessage<BattleLib_UpdateResult.Types.VisualInterrupt>, IMessage, IEquatable<BattleLib_UpdateResult.Types.VisualInterrupt>, IDeepCloneable<BattleLib_UpdateResult.Types.VisualInterrupt>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.VisualInterrupt> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int SourceIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint sourceId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D888", Offset="0x109D888")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x20387CC", Offset="0x20387CC", VA="0x20387CC")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D878", Offset="0x109D878")]
				public static MessageParser<BattleLib_UpdateResult.Types.VisualInterrupt> Parser
				{
					[Address(RVA="0x2038764", Offset="0x2038764", VA="0x2038764")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D898", Offset="0x109D898")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x20388BC", Offset="0x20388BC", VA="0x20388BC", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D8A8", Offset="0x109D8A8")]
				public uint SourceId
				{
					[Address(RVA="0x20389E4", Offset="0x20389E4", VA="0x20389E4")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x20389EC", Offset="0x20389EC", VA="0x20389EC")]
					set
					{
					}
				}

				[Address(RVA="0x2038D60", Offset="0x2038D60", VA="0x2038D60")]
				static VisualInterrupt()
				{
				}

				[Address(RVA="0x2038918", Offset="0x2038918", VA="0x2038918")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F344", Offset="0x108F344")]
				public VisualInterrupt()
				{
				}

				[Address(RVA="0x2038920", Offset="0x2038920", VA="0x2038920")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F354", Offset="0x108F354")]
				public VisualInterrupt(BattleLib_UpdateResult.Types.VisualInterrupt other)
				{
				}

				[Address(RVA="0x2038C14", Offset="0x2038C14", VA="0x2038C14", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F3C4", Offset="0x108F3C4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2038984", Offset="0x2038984", VA="0x2038984", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F364", Offset="0x108F364")]
				public BattleLib_UpdateResult.Types.VisualInterrupt Clone()
				{
					return null;
				}

				[Address(RVA="0x20389F4", Offset="0x20389F4", VA="0x20389F4", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F374", Offset="0x108F374")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x2038A68", Offset="0x2038A68", VA="0x2038A68", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F384", Offset="0x108F384")]
				public bool Equals(BattleLib_UpdateResult.Types.VisualInterrupt other)
				{
					return new bool();
				}

				[Address(RVA="0x2038AA4", Offset="0x2038AA4", VA="0x2038AA4", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F394", Offset="0x108F394")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x2038CA4", Offset="0x2038CA4", VA="0x2038CA4", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F3D4", Offset="0x108F3D4")]
				public void MergeFrom(BattleLib_UpdateResult.Types.VisualInterrupt other)
				{
				}

				[Address(RVA="0x2038CE4", Offset="0x2038CE4", VA="0x2038CE4", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F3E4", Offset="0x108F3E4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x2038B0C", Offset="0x2038B0C", VA="0x2038B0C", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F3A4", Offset="0x108F3A4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x2038B74", Offset="0x2038B74", VA="0x2038B74", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F3B4", Offset="0x108F3B4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051824", Offset="0x1051824")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.VisualInterrupt.<>c <>9;

					[Address(RVA="0x2038E38", Offset="0x2038E38", VA="0x2038E38")]
					static <>c()
					{
					}

					[Address(RVA="0x2038E9C", Offset="0x2038E9C", VA="0x2038E9C")]
					public <>c()
					{
					}

					[Address(RVA="0x2038EA4", Offset="0x2038EA4", VA="0x2038EA4")]
					internal BattleLib_UpdateResult.Types.VisualInterrupt <.cctor>b__25_0()
					{
						return null;
					}
				}
			}

			public sealed class VisualOnUnit : IMessage<BattleLib_UpdateResult.Types.VisualOnUnit>, IMessage, IEquatable<BattleLib_UpdateResult.Types.VisualOnUnit>, IDeepCloneable<BattleLib_UpdateResult.Types.VisualOnUnit>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.VisualOnUnit> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int VisualIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private ulong visualId_;

				[FieldOffset(Offset="0x0")]
				public const int ExpireTimeFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private float expireTime_;

				[FieldOffset(Offset="0x0")]
				public const int SourceIdFieldNumber = 3;

				[FieldOffset(Offset="0x24")]
				private uint sourceId_;

				[FieldOffset(Offset="0x0")]
				public const int CasterUnitIdFieldNumber = 4;

				[FieldOffset(Offset="0x28")]
				private uint casterUnitId_;

				[FieldOffset(Offset="0x0")]
				public const int TargetUnitIdFieldNumber = 5;

				[FieldOffset(Offset="0x2C")]
				private uint targetUnitId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D918", Offset="0x109D918")]
				public uint CasterUnitId
				{
					[Address(RVA="0x2039220", Offset="0x2039220", VA="0x2039220")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2039228", Offset="0x2039228", VA="0x2039228")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D8C8", Offset="0x109D8C8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x2038F68", Offset="0x2038F68", VA="0x2038F68")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D8F8", Offset="0x109D8F8")]
				public float ExpireTime
				{
					[Address(RVA="0x2039200", Offset="0x2039200", VA="0x2039200")]
					get
					{
						return new float();
					}
					[Address(RVA="0x2039208", Offset="0x2039208", VA="0x2039208")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D8B8", Offset="0x109D8B8")]
				public static MessageParser<BattleLib_UpdateResult.Types.VisualOnUnit> Parser
				{
					[Address(RVA="0x2038F00", Offset="0x2038F00", VA="0x2038F00")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D8D8", Offset="0x109D8D8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x2039058", Offset="0x2039058", VA="0x2039058", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D908", Offset="0x109D908")]
				public uint SourceId
				{
					[Address(RVA="0x2039210", Offset="0x2039210", VA="0x2039210")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2039218", Offset="0x2039218", VA="0x2039218")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D928", Offset="0x109D928")]
				public uint TargetUnitId
				{
					[Address(RVA="0x2039230", Offset="0x2039230", VA="0x2039230")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2039238", Offset="0x2039238", VA="0x2039238")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D8E8", Offset="0x109D8E8")]
				public ulong VisualId
				{
					[Address(RVA="0x20391F0", Offset="0x20391F0", VA="0x20391F0")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x20391F8", Offset="0x20391F8", VA="0x20391F8")]
					set
					{
					}
				}

				[Address(RVA="0x2039A9C", Offset="0x2039A9C", VA="0x2039A9C")]
				static VisualOnUnit()
				{
				}

				[Address(RVA="0x20390B4", Offset="0x20390B4", VA="0x20390B4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F3F4", Offset="0x108F3F4")]
				public VisualOnUnit()
				{
				}

				[Address(RVA="0x20390BC", Offset="0x20390BC", VA="0x20390BC")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F404", Offset="0x108F404")]
				public VisualOnUnit(BattleLib_UpdateResult.Types.VisualOnUnit other)
				{
				}

				[Address(RVA="0x20397A0", Offset="0x20397A0", VA="0x20397A0", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F474", Offset="0x108F474")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2039190", Offset="0x2039190", VA="0x2039190", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F414", Offset="0x108F414")]
				public BattleLib_UpdateResult.Types.VisualOnUnit Clone()
				{
					return null;
				}

				[Address(RVA="0x2039240", Offset="0x2039240", VA="0x2039240", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F424", Offset="0x108F424")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x20392B4", Offset="0x20392B4", VA="0x20392B4", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F434", Offset="0x108F434")]
				public bool Equals(BattleLib_UpdateResult.Types.VisualOnUnit other)
				{
					return new bool();
				}

				[Address(RVA="0x20393D8", Offset="0x20393D8", VA="0x20393D8", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F444", Offset="0x108F444")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x2039904", Offset="0x2039904", VA="0x2039904", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F484", Offset="0x108F484")]
				public void MergeFrom(BattleLib_UpdateResult.Types.VisualOnUnit other)
				{
				}

				[Address(RVA="0x2039978", Offset="0x2039978", VA="0x2039978", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F494", Offset="0x108F494")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x2039528", Offset="0x2039528", VA="0x2039528", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F454", Offset="0x108F454")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x2039590", Offset="0x2039590", VA="0x2039590", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F464", Offset="0x108F464")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051834", Offset="0x1051834")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.VisualOnUnit.<>c <>9;

					[Address(RVA="0x2039B74", Offset="0x2039B74", VA="0x2039B74")]
					static <>c()
					{
					}

					[Address(RVA="0x2039BD8", Offset="0x2039BD8", VA="0x2039BD8")]
					public <>c()
					{
					}

					[Address(RVA="0x2039BE0", Offset="0x2039BE0", VA="0x2039BE0")]
					internal BattleLib_UpdateResult.Types.VisualOnUnit <.cctor>b__45_0()
					{
						return null;
					}
				}
			}

			public sealed class VisualOnWorld : IMessage<BattleLib_UpdateResult.Types.VisualOnWorld>, IMessage, IEquatable<BattleLib_UpdateResult.Types.VisualOnWorld>, IDeepCloneable<BattleLib_UpdateResult.Types.VisualOnWorld>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.VisualOnWorld> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int VisualIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private ulong visualId_;

				[FieldOffset(Offset="0x0")]
				public const int TargetPosXFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private float targetPosX_;

				[FieldOffset(Offset="0x0")]
				public const int TargetPosYFieldNumber = 3;

				[FieldOffset(Offset="0x24")]
				private float targetPosY_;

				[FieldOffset(Offset="0x0")]
				public const int TargetPosVerticalityFieldNumber = 4;

				[FieldOffset(Offset="0x28")]
				private float targetPosVerticality_;

				[FieldOffset(Offset="0x0")]
				public const int ExpireTimeFieldNumber = 5;

				[FieldOffset(Offset="0x2C")]
				private float expireTime_;

				[FieldOffset(Offset="0x0")]
				public const int SourceIdFieldNumber = 6;

				[FieldOffset(Offset="0x30")]
				private uint sourceId_;

				[FieldOffset(Offset="0x0")]
				public const int CasterUnitIdFieldNumber = 7;

				[FieldOffset(Offset="0x34")]
				private uint casterUnitId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D9C8", Offset="0x109D9C8")]
				public uint CasterUnitId
				{
					[Address(RVA="0x2039FC4", Offset="0x2039FC4", VA="0x2039FC4")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2039FCC", Offset="0x2039FCC", VA="0x2039FCC")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D948", Offset="0x109D948")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x2039CA4", Offset="0x2039CA4", VA="0x2039CA4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D9A8", Offset="0x109D9A8")]
				public float ExpireTime
				{
					[Address(RVA="0x2039FA4", Offset="0x2039FA4", VA="0x2039FA4")]
					get
					{
						return new float();
					}
					[Address(RVA="0x2039FAC", Offset="0x2039FAC", VA="0x2039FAC")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D938", Offset="0x109D938")]
				public static MessageParser<BattleLib_UpdateResult.Types.VisualOnWorld> Parser
				{
					[Address(RVA="0x2039C3C", Offset="0x2039C3C", VA="0x2039C3C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D958", Offset="0x109D958")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x2039D94", Offset="0x2039D94", VA="0x2039D94", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D9B8", Offset="0x109D9B8")]
				public uint SourceId
				{
					[Address(RVA="0x2039FB4", Offset="0x2039FB4", VA="0x2039FB4")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x2039FBC", Offset="0x2039FBC", VA="0x2039FBC")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D998", Offset="0x109D998")]
				public float TargetPosVerticality
				{
					[Address(RVA="0x2039F94", Offset="0x2039F94", VA="0x2039F94")]
					get
					{
						return new float();
					}
					[Address(RVA="0x2039F9C", Offset="0x2039F9C", VA="0x2039F9C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D978", Offset="0x109D978")]
				public float TargetPosX
				{
					[Address(RVA="0x2039F74", Offset="0x2039F74", VA="0x2039F74")]
					get
					{
						return new float();
					}
					[Address(RVA="0x2039F7C", Offset="0x2039F7C", VA="0x2039F7C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D988", Offset="0x109D988")]
				public float TargetPosY
				{
					[Address(RVA="0x2039F84", Offset="0x2039F84", VA="0x2039F84")]
					get
					{
						return new float();
					}
					[Address(RVA="0x2039F8C", Offset="0x2039F8C", VA="0x2039F8C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109D968", Offset="0x109D968")]
				public ulong VisualId
				{
					[Address(RVA="0x2039F64", Offset="0x2039F64", VA="0x2039F64")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x2039F6C", Offset="0x2039F6C", VA="0x2039F6C")]
					set
					{
					}
				}

				[Address(RVA="0x203AB2C", Offset="0x203AB2C", VA="0x203AB2C")]
				static VisualOnWorld()
				{
				}

				[Address(RVA="0x2039DF0", Offset="0x2039DF0", VA="0x2039DF0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F4A4", Offset="0x108F4A4")]
				public VisualOnWorld()
				{
				}

				[Address(RVA="0x2039DF8", Offset="0x2039DF8", VA="0x2039DF8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F4B4", Offset="0x108F4B4")]
				public VisualOnWorld(BattleLib_UpdateResult.Types.VisualOnWorld other)
				{
				}

				[Address(RVA="0x203A7C8", Offset="0x203A7C8", VA="0x203A7C8", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F524", Offset="0x108F524")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2039F04", Offset="0x2039F04", VA="0x2039F04", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F4C4", Offset="0x108F4C4")]
				public BattleLib_UpdateResult.Types.VisualOnWorld Clone()
				{
					return null;
				}

				[Address(RVA="0x2039FD4", Offset="0x2039FD4", VA="0x2039FD4", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F4D4", Offset="0x108F4D4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x203A048", Offset="0x203A048", VA="0x203A048", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F4E4", Offset="0x108F4E4")]
				public bool Equals(BattleLib_UpdateResult.Types.VisualOnWorld other)
				{
					return new bool();
				}

				[Address(RVA="0x203A24C", Offset="0x203A24C", VA="0x203A24C", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F4F4", Offset="0x108F4F4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x203A918", Offset="0x203A918", VA="0x203A918", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F534", Offset="0x108F534")]
				public void MergeFrom(BattleLib_UpdateResult.Types.VisualOnWorld other)
				{
				}

				[Address(RVA="0x203A9B0", Offset="0x203A9B0", VA="0x203A9B0", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F544", Offset="0x108F544")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x203A494", Offset="0x203A494", VA="0x203A494", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F504", Offset="0x108F504")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x203A4FC", Offset="0x203A4FC", VA="0x203A4FC", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F514", Offset="0x108F514")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051844", Offset="0x1051844")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.VisualOnWorld.<>c <>9;

					[Address(RVA="0x203AC04", Offset="0x203AC04", VA="0x203AC04")]
					static <>c()
					{
					}

					[Address(RVA="0x203AC68", Offset="0x203AC68", VA="0x203AC68")]
					public <>c()
					{
					}

					[Address(RVA="0x203AC70", Offset="0x203AC70", VA="0x203AC70")]
					internal BattleLib_UpdateResult.Types.VisualOnWorld <.cctor>b__55_0()
					{
						return null;
					}
				}
			}

			public sealed class VisualPos : IMessage<BattleLib_UpdateResult.Types.VisualPos>, IMessage, IEquatable<BattleLib_UpdateResult.Types.VisualPos>, IDeepCloneable<BattleLib_UpdateResult.Types.VisualPos>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_UpdateResult.Types.VisualPos> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int XFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private float x_;

				[FieldOffset(Offset="0x0")]
				public const int YFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private float y_;

				[FieldOffset(Offset="0x0")]
				public const int VerticalityFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private float verticality_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DA68", Offset="0x109DA68")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x203AD34", Offset="0x203AD34", VA="0x203AD34")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DA58", Offset="0x109DA58")]
				public static MessageParser<BattleLib_UpdateResult.Types.VisualPos> Parser
				{
					[Address(RVA="0x203ACCC", Offset="0x203ACCC", VA="0x203ACCC")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DA78", Offset="0x109DA78")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x203AE24", Offset="0x203AE24", VA="0x203AE24", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DAA8", Offset="0x109DAA8")]
				public float Verticality
				{
					[Address(RVA="0x203AF3C", Offset="0x203AF3C", VA="0x203AF3C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x203AF44", Offset="0x203AF44", VA="0x203AF44")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DA88", Offset="0x109DA88")]
				public float X
				{
					[Address(RVA="0x203AF1C", Offset="0x203AF1C", VA="0x203AF1C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x203AF24", Offset="0x203AF24", VA="0x203AF24")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DA98", Offset="0x109DA98")]
				public float Y
				{
					[Address(RVA="0x203AF2C", Offset="0x203AF2C", VA="0x203AF2C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x203AF34", Offset="0x203AF34", VA="0x203AF34")]
					set
					{
					}
				}

				[Address(RVA="0x203B5C0", Offset="0x203B5C0", VA="0x203B5C0")]
				static VisualPos()
				{
				}

				[Address(RVA="0x20383C4", Offset="0x20383C4", VA="0x20383C4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F604", Offset="0x108F604")]
				public VisualPos()
				{
				}

				[Address(RVA="0x203AE80", Offset="0x203AE80", VA="0x203AE80")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F614", Offset="0x108F614")]
				public VisualPos(BattleLib_UpdateResult.Types.VisualPos other)
				{
				}

				[Address(RVA="0x203B490", Offset="0x203B490", VA="0x203B490", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F684", Offset="0x108F684")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x2037AD4", Offset="0x2037AD4", VA="0x2037AD4", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F624", Offset="0x108F624")]
				public BattleLib_UpdateResult.Types.VisualPos Clone()
				{
					return null;
				}

				[Address(RVA="0x203AF4C", Offset="0x203AF4C", VA="0x203AF4C", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F634", Offset="0x108F634")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x203AFC0", Offset="0x203AFC0", VA="0x203AFC0", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F644", Offset="0x108F644")]
				public bool Equals(BattleLib_UpdateResult.Types.VisualPos other)
				{
					return new bool();
				}

				[Address(RVA="0x203B144", Offset="0x203B144", VA="0x203B144", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F654", Offset="0x108F654")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x20383CC", Offset="0x20383CC", VA="0x20383CC", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F694", Offset="0x108F694")]
				public void MergeFrom(BattleLib_UpdateResult.Types.VisualPos other)
				{
				}

				[Address(RVA="0x203B4EC", Offset="0x203B4EC", VA="0x203B4EC", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F6A4", Offset="0x108F6A4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x203B2CC", Offset="0x203B2CC", VA="0x203B2CC", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F664", Offset="0x108F664")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x203B334", Offset="0x203B334", VA="0x203B334", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108F674", Offset="0x108F674")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051864", Offset="0x1051864")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_UpdateResult.Types.VisualPos.<>c <>9;

					[Address(RVA="0x203B698", Offset="0x203B698", VA="0x203B698")]
					static <>c()
					{
					}

					[Address(RVA="0x203B6FC", Offset="0x203B6FC", VA="0x203B6FC")]
					public <>c()
					{
					}

					[Address(RVA="0x203B704", Offset="0x203B704", VA="0x203B704")]
					internal BattleLib_UpdateResult.Types.VisualPos <.cctor>b__35_0()
					{
						return null;
					}
				}
			}
		}
	}
}