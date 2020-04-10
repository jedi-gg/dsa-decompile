using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleLib_PlayerMessage : IMessage<BattleLib_PlayerMessage>, IMessage, IEquatable<BattleLib_PlayerMessage>, IDeepCloneable<BattleLib_PlayerMessage>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleLib_PlayerMessage> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CastsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<BattleLib_PlayerMessage.Types.Cast> _repeated_casts_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<BattleLib_PlayerMessage.Types.Cast> casts_;

		[FieldOffset(Offset="0x0")]
		public const int AutoBattleFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private BattleLib_PlayerMessage.Types.AutoBattle autoBattle_;

		[FieldOffset(Offset="0x0")]
		public const int CinematicDoneFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private BattleLib_PlayerMessage.Types.CinematicDone cinematicDone_;

		[FieldOffset(Offset="0x0")]
		public const int EncounterTransitionDoneFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private BattleLib_PlayerMessage.Types.EncounterTransitionDone encounterTransitionDone_;

		[FieldOffset(Offset="0x0")]
		public const int EmoteFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private BattleLib_PlayerMessage.Types.Emote emote_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093A20", Offset="0x1093A20")]
		public BattleLib_PlayerMessage.Types.AutoBattle AutoBattle
		{
			[Address(RVA="0x17A0B28", Offset="0x17A0B28", VA="0x17A0B28")]
			get
			{
				return null;
			}
			[Address(RVA="0x17A0B90", Offset="0x17A0B90", VA="0x17A0B90")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093A10", Offset="0x1093A10")]
		public RepeatedField<BattleLib_PlayerMessage.Types.Cast> Casts
		{
			[Address(RVA="0x17A0D48", Offset="0x17A0D48", VA="0x17A0D48")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093A30", Offset="0x1093A30")]
		public BattleLib_PlayerMessage.Types.CinematicDone CinematicDone
		{
			[Address(RVA="0x17A0B98", Offset="0x17A0B98", VA="0x17A0B98")]
			get
			{
				return null;
			}
			[Address(RVA="0x17A0C00", Offset="0x17A0C00", VA="0x17A0C00")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10939F0", Offset="0x10939F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x17A0894", Offset="0x17A0894", VA="0x17A0894")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093A50", Offset="0x1093A50")]
		public BattleLib_PlayerMessage.Types.Emote Emote
		{
			[Address(RVA="0x17A0C78", Offset="0x17A0C78", VA="0x17A0C78")]
			get
			{
				return null;
			}
			[Address(RVA="0x17A0CE0", Offset="0x17A0CE0", VA="0x17A0CE0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093A40", Offset="0x1093A40")]
		public BattleLib_PlayerMessage.Types.EncounterTransitionDone EncounterTransitionDone
		{
			[Address(RVA="0x17A0C08", Offset="0x17A0C08", VA="0x17A0C08")]
			get
			{
				return null;
			}
			[Address(RVA="0x17A0C70", Offset="0x17A0C70", VA="0x17A0C70")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10939E0", Offset="0x10939E0")]
		public static MessageParser<BattleLib_PlayerMessage> Parser
		{
			[Address(RVA="0x17A082C", Offset="0x17A082C", VA="0x17A082C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093A00", Offset="0x1093A00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x17A0984", Offset="0x17A0984", VA="0x17A0984", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x17A18DC", Offset="0x17A18DC", VA="0x17A18DC")]
		static BattleLib_PlayerMessage()
		{
		}

		[Address(RVA="0x17A09E0", Offset="0x17A09E0", VA="0x17A09E0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078D0C", Offset="0x1078D0C")]
		public BattleLib_PlayerMessage()
		{
		}

		[Address(RVA="0x17A0A50", Offset="0x17A0A50", VA="0x17A0A50")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078D1C", Offset="0x1078D1C")]
		public BattleLib_PlayerMessage(BattleLib_PlayerMessage other)
		{
		}

		[Address(RVA="0x17A1210", Offset="0x17A1210", VA="0x17A1210", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078D8C", Offset="0x1078D8C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x17A0CE8", Offset="0x17A0CE8", VA="0x17A0CE8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078D2C", Offset="0x1078D2C")]
		public BattleLib_PlayerMessage Clone()
		{
			return null;
		}

		[Address(RVA="0x17A0D50", Offset="0x17A0D50", VA="0x17A0D50", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078D3C", Offset="0x1078D3C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x17A0DC4", Offset="0x17A0DC4", VA="0x17A0DC4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078D4C", Offset="0x1078D4C")]
		public bool Equals(BattleLib_PlayerMessage other)
		{
			return new bool();
		}

		[Address(RVA="0x17A0EC4", Offset="0x17A0EC4", VA="0x17A0EC4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078D5C", Offset="0x1078D5C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x17A13B8", Offset="0x17A13B8", VA="0x17A13B8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078D9C", Offset="0x1078D9C")]
		public void MergeFrom(BattleLib_PlayerMessage other)
		{
		}

		[Address(RVA="0x17A16EC", Offset="0x17A16EC", VA="0x17A16EC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078DAC", Offset="0x1078DAC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x17A0F84", Offset="0x17A0F84", VA="0x17A0F84", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078D6C", Offset="0x1078D6C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x17A0FEC", Offset="0x17A0FEC", VA="0x17A0FEC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078D7C", Offset="0x1078D7C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F3F8", Offset="0x104F3F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleLib_PlayerMessage.<>c <>9;

			[Address(RVA="0x17A1A64", Offset="0x17A1A64", VA="0x17A1A64")]
			static <>c()
			{
			}

			[Address(RVA="0x17A1AC8", Offset="0x17A1AC8", VA="0x17A1AC8")]
			public <>c()
			{
			}

			[Address(RVA="0x17A1AD0", Offset="0x17A1AD0", VA="0x17A1AD0")]
			internal BattleLib_PlayerMessage <.cctor>b__46_0()
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x104F3E8", Offset="0x104F3E8")]
		public static class Types
		{
			public sealed class AutoBattle : IMessage<BattleLib_PlayerMessage.Types.AutoBattle>, IMessage, IEquatable<BattleLib_PlayerMessage.Types.AutoBattle>, IDeepCloneable<BattleLib_PlayerMessage.Types.AutoBattle>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_PlayerMessage.Types.AutoBattle> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int EnabledFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private bool enabled_;

				[FieldOffset(Offset="0x0")]
				public const int PreferredTargetFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint preferredTarget_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E088", Offset="0x109E088")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17A1B90", Offset="0x17A1B90", VA="0x17A1B90")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E0A8", Offset="0x109E0A8")]
				public bool Enabled
				{
					[Address(RVA="0x17A1D58", Offset="0x17A1D58", VA="0x17A1D58")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x17A1D60", Offset="0x17A1D60", VA="0x17A1D60")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E078", Offset="0x109E078")]
				public static MessageParser<BattleLib_PlayerMessage.Types.AutoBattle> Parser
				{
					[Address(RVA="0x17A1B28", Offset="0x17A1B28", VA="0x17A1B28")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E098", Offset="0x109E098")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17A1C7C", Offset="0x17A1C7C", VA="0x17A1C7C", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E0B8", Offset="0x109E0B8")]
				public uint PreferredTarget
				{
					[Address(RVA="0x17A1D6C", Offset="0x17A1D6C", VA="0x17A1D6C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17A1D74", Offset="0x17A1D74", VA="0x17A1D74")]
					set
					{
					}
				}

				[Address(RVA="0x17A2180", Offset="0x17A2180", VA="0x17A2180")]
				static AutoBattle()
				{
				}

				[Address(RVA="0x17A15C0", Offset="0x17A15C0", VA="0x17A15C0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090104", Offset="0x1090104")]
				public AutoBattle()
				{
				}

				[Address(RVA="0x17A1CD8", Offset="0x17A1CD8", VA="0x17A1CD8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090114", Offset="0x1090114")]
				public AutoBattle(BattleLib_PlayerMessage.Types.AutoBattle other)
				{
				}

				[Address(RVA="0x17A2034", Offset="0x17A2034", VA="0x17A2034", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090184", Offset="0x1090184")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17A0B30", Offset="0x17A0B30", VA="0x17A0B30", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090124", Offset="0x1090124")]
				public BattleLib_PlayerMessage.Types.AutoBattle Clone()
				{
					return null;
				}

				[Address(RVA="0x17A1D7C", Offset="0x17A1D7C", VA="0x17A1D7C", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090134", Offset="0x1090134")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17A1DF0", Offset="0x17A1DF0", VA="0x17A1DF0", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090144", Offset="0x1090144")]
				public bool Equals(BattleLib_PlayerMessage.Types.AutoBattle other)
				{
					return new bool();
				}

				[Address(RVA="0x17A1E4C", Offset="0x17A1E4C", VA="0x17A1E4C", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090154", Offset="0x1090154")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17A15C8", Offset="0x17A15C8", VA="0x17A15C8", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090194", Offset="0x1090194")]
				public void MergeFrom(BattleLib_PlayerMessage.Types.AutoBattle other)
				{
				}

				[Address(RVA="0x17A20D8", Offset="0x17A20D8", VA="0x17A20D8", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10901A4", Offset="0x10901A4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17A1ED0", Offset="0x17A1ED0", VA="0x17A1ED0", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090164", Offset="0x1090164")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17A1F38", Offset="0x17A1F38", VA="0x17A1F38", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090174", Offset="0x1090174")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051964", Offset="0x1051964")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_PlayerMessage.Types.AutoBattle.<>c <>9;

					[Address(RVA="0x17A2258", Offset="0x17A2258", VA="0x17A2258")]
					static <>c()
					{
					}

					[Address(RVA="0x17A22BC", Offset="0x17A22BC", VA="0x17A22BC")]
					public <>c()
					{
					}

					[Address(RVA="0x17A22C4", Offset="0x17A22C4", VA="0x17A22C4")]
					internal BattleLib_PlayerMessage.Types.AutoBattle <.cctor>b__30_0()
					{
						return null;
					}
				}
			}

			public sealed class Cast : IMessage<BattleLib_PlayerMessage.Types.Cast>, IMessage, IEquatable<BattleLib_PlayerMessage.Types.Cast>, IDeepCloneable<BattleLib_PlayerMessage.Types.Cast>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_PlayerMessage.Types.Cast> _parser;

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
				public const int TargetUnitFieldNumber = 4;

				[FieldOffset(Offset="0x24")]
				private uint targetUnit_;

				[FieldOffset(Offset="0x0")]
				public const int TargetPosXFieldNumber = 5;

				[FieldOffset(Offset="0x28")]
				private float targetPosX_;

				[FieldOffset(Offset="0x0")]
				public const int TargetPosYFieldNumber = 6;

				[FieldOffset(Offset="0x2C")]
				private float targetPosY_;

				[FieldOffset(Offset="0x0")]
				public const int SpawnIndexFieldNumber = 7;

				[FieldOffset(Offset="0x30")]
				private uint spawnIndex_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E028", Offset="0x109E028")]
				public uint AbilityId
				{
					[Address(RVA="0x17A25FC", Offset="0x17A25FC", VA="0x17A25FC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17A2604", Offset="0x17A2604", VA="0x17A2604")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DFE8", Offset="0x109DFE8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17A2320", Offset="0x17A2320", VA="0x17A2320")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DFD8", Offset="0x109DFD8")]
				public static MessageParser<BattleLib_PlayerMessage.Types.Cast> Parser
				{
					[Address(RVA="0x17A19FC", Offset="0x17A19FC", VA="0x17A19FC")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109DFF8", Offset="0x109DFF8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17A240C", Offset="0x17A240C", VA="0x17A240C", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E018", Offset="0x109E018")]
				public uint SourceId
				{
					[Address(RVA="0x17A25EC", Offset="0x17A25EC", VA="0x17A25EC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17A25F4", Offset="0x17A25F4", VA="0x17A25F4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E008", Offset="0x109E008")]
				public uint SourceType
				{
					[Address(RVA="0x17A25DC", Offset="0x17A25DC", VA="0x17A25DC")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17A25E4", Offset="0x17A25E4", VA="0x17A25E4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E068", Offset="0x109E068")]
				public uint SpawnIndex
				{
					[Address(RVA="0x17A263C", Offset="0x17A263C", VA="0x17A263C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17A2644", Offset="0x17A2644", VA="0x17A2644")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E048", Offset="0x109E048")]
				public float TargetPosX
				{
					[Address(RVA="0x17A261C", Offset="0x17A261C", VA="0x17A261C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x17A2624", Offset="0x17A2624", VA="0x17A2624")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E058", Offset="0x109E058")]
				public float TargetPosY
				{
					[Address(RVA="0x17A262C", Offset="0x17A262C", VA="0x17A262C")]
					get
					{
						return new float();
					}
					[Address(RVA="0x17A2634", Offset="0x17A2634", VA="0x17A2634")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E038", Offset="0x109E038")]
				public uint TargetUnit
				{
					[Address(RVA="0x17A260C", Offset="0x17A260C", VA="0x17A260C")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17A2614", Offset="0x17A2614", VA="0x17A2614")]
					set
					{
					}
				}

				[Address(RVA="0x17A30EC", Offset="0x17A30EC", VA="0x17A30EC")]
				static Cast()
				{
				}

				[Address(RVA="0x17A2468", Offset="0x17A2468", VA="0x17A2468")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090054", Offset="0x1090054")]
				public Cast()
				{
				}

				[Address(RVA="0x17A2470", Offset="0x17A2470", VA="0x17A2470")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090064", Offset="0x1090064")]
				public Cast(BattleLib_PlayerMessage.Types.Cast other)
				{
				}

				[Address(RVA="0x17A2D34", Offset="0x17A2D34", VA="0x17A2D34", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10900D4", Offset="0x10900D4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17A257C", Offset="0x17A257C", VA="0x17A257C", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090074", Offset="0x1090074")]
				public BattleLib_PlayerMessage.Types.Cast Clone()
				{
					return null;
				}

				[Address(RVA="0x17A264C", Offset="0x17A264C", VA="0x17A264C", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090084", Offset="0x1090084")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17A26C0", Offset="0x17A26C0", VA="0x17A26C0", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090094", Offset="0x1090094")]
				public bool Equals(BattleLib_PlayerMessage.Types.Cast other)
				{
					return new bool();
				}

				[Address(RVA="0x17A2844", Offset="0x17A2844", VA="0x17A2844", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10900A4", Offset="0x10900A4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17A2EE0", Offset="0x17A2EE0", VA="0x17A2EE0", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10900E4", Offset="0x10900E4")]
				public void MergeFrom(BattleLib_PlayerMessage.Types.Cast other)
				{
				}

				[Address(RVA="0x17A2F70", Offset="0x17A2F70", VA="0x17A2F70", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10900F4", Offset="0x10900F4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17A2A08", Offset="0x17A2A08", VA="0x17A2A08", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10900B4", Offset="0x10900B4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17A2A70", Offset="0x17A2A70", VA="0x17A2A70", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10900C4", Offset="0x10900C4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051954", Offset="0x1051954")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_PlayerMessage.Types.Cast.<>c <>9;

					[Address(RVA="0x17A31C4", Offset="0x17A31C4", VA="0x17A31C4")]
					static <>c()
					{
					}

					[Address(RVA="0x17A3228", Offset="0x17A3228", VA="0x17A3228")]
					public <>c()
					{
					}

					[Address(RVA="0x17A3230", Offset="0x17A3230", VA="0x17A3230")]
					internal BattleLib_PlayerMessage.Types.Cast <.cctor>b__55_0()
					{
						return null;
					}
				}
			}

			public sealed class CinematicDone : IMessage<BattleLib_PlayerMessage.Types.CinematicDone>, IMessage, IEquatable<BattleLib_PlayerMessage.Types.CinematicDone>, IDeepCloneable<BattleLib_PlayerMessage.Types.CinematicDone>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_PlayerMessage.Types.CinematicDone> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int EncounterIndexFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint encounterIndex_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E0D8", Offset="0x109E0D8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17A32F4", Offset="0x17A32F4", VA="0x17A32F4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E0F8", Offset="0x109E0F8")]
				public uint EncounterIndex
				{
					[Address(RVA="0x17A34A0", Offset="0x17A34A0", VA="0x17A34A0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17A34A8", Offset="0x17A34A8", VA="0x17A34A8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E0C8", Offset="0x109E0C8")]
				public static MessageParser<BattleLib_PlayerMessage.Types.CinematicDone> Parser
				{
					[Address(RVA="0x17A328C", Offset="0x17A328C", VA="0x17A328C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E0E8", Offset="0x109E0E8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17A33E0", Offset="0x17A33E0", VA="0x17A33E0", Slot="7")]
					get
					{
						return null;
					}
				}

				[Address(RVA="0x17A37DC", Offset="0x17A37DC", VA="0x17A37DC")]
				static CinematicDone()
				{
				}

				[Address(RVA="0x17A1614", Offset="0x17A1614", VA="0x17A1614")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10901B4", Offset="0x10901B4")]
				public CinematicDone()
				{
				}

				[Address(RVA="0x17A343C", Offset="0x17A343C", VA="0x17A343C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10901C4", Offset="0x10901C4")]
				public CinematicDone(BattleLib_PlayerMessage.Types.CinematicDone other)
				{
				}

				[Address(RVA="0x17A36D0", Offset="0x17A36D0", VA="0x17A36D0", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090234", Offset="0x1090234")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17A0BA0", Offset="0x17A0BA0", VA="0x17A0BA0", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10901D4", Offset="0x10901D4")]
				public BattleLib_PlayerMessage.Types.CinematicDone Clone()
				{
					return null;
				}

				[Address(RVA="0x17A34B0", Offset="0x17A34B0", VA="0x17A34B0", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10901E4", Offset="0x10901E4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17A3524", Offset="0x17A3524", VA="0x17A3524", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10901F4", Offset="0x10901F4")]
				public bool Equals(BattleLib_PlayerMessage.Types.CinematicDone other)
				{
					return new bool();
				}

				[Address(RVA="0x17A3560", Offset="0x17A3560", VA="0x17A3560", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090204", Offset="0x1090204")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17A161C", Offset="0x17A161C", VA="0x17A161C", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090244", Offset="0x1090244")]
				public void MergeFrom(BattleLib_PlayerMessage.Types.CinematicDone other)
				{
				}

				[Address(RVA="0x17A3760", Offset="0x17A3760", VA="0x17A3760", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090254", Offset="0x1090254")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17A35C8", Offset="0x17A35C8", VA="0x17A35C8", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090214", Offset="0x1090214")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17A3630", Offset="0x17A3630", VA="0x17A3630", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090224", Offset="0x1090224")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051974", Offset="0x1051974")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_PlayerMessage.Types.CinematicDone.<>c <>9;

					[Address(RVA="0x17A38B4", Offset="0x17A38B4", VA="0x17A38B4")]
					static <>c()
					{
					}

					[Address(RVA="0x17A3918", Offset="0x17A3918", VA="0x17A3918")]
					public <>c()
					{
					}

					[Address(RVA="0x17A3920", Offset="0x17A3920", VA="0x17A3920")]
					internal BattleLib_PlayerMessage.Types.CinematicDone <.cctor>b__25_0()
					{
						return null;
					}
				}
			}

			public sealed class Emote : IMessage<BattleLib_PlayerMessage.Types.Emote>, IMessage, IEquatable<BattleLib_PlayerMessage.Types.Emote>, IDeepCloneable<BattleLib_PlayerMessage.Types.Emote>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_PlayerMessage.Types.Emote> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int EmoteIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private ulong emoteId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E158", Offset="0x109E158")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17A39E4", Offset="0x17A39E4", VA="0x17A39E4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E178", Offset="0x109E178")]
				public ulong EmoteId
				{
					[Address(RVA="0x17A3B90", Offset="0x17A3B90", VA="0x17A3B90")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x17A3B98", Offset="0x17A3B98", VA="0x17A3B98")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E148", Offset="0x109E148")]
				public static MessageParser<BattleLib_PlayerMessage.Types.Emote> Parser
				{
					[Address(RVA="0x17A397C", Offset="0x17A397C", VA="0x17A397C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E168", Offset="0x109E168")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17A3AD0", Offset="0x17A3AD0", VA="0x17A3AD0", Slot="7")]
					get
					{
						return null;
					}
				}

				[Address(RVA="0x17A3ECC", Offset="0x17A3ECC", VA="0x17A3ECC")]
				static Emote()
				{
				}

				[Address(RVA="0x17A16A4", Offset="0x17A16A4", VA="0x17A16A4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090314", Offset="0x1090314")]
				public Emote()
				{
				}

				[Address(RVA="0x17A3B2C", Offset="0x17A3B2C", VA="0x17A3B2C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090324", Offset="0x1090324")]
				public Emote(BattleLib_PlayerMessage.Types.Emote other)
				{
				}

				[Address(RVA="0x17A3DC0", Offset="0x17A3DC0", VA="0x17A3DC0", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090394", Offset="0x1090394")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17A0C80", Offset="0x17A0C80", VA="0x17A0C80", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090334", Offset="0x1090334")]
				public BattleLib_PlayerMessage.Types.Emote Clone()
				{
					return null;
				}

				[Address(RVA="0x17A3BA0", Offset="0x17A3BA0", VA="0x17A3BA0", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090344", Offset="0x1090344")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17A3C14", Offset="0x17A3C14", VA="0x17A3C14", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090354", Offset="0x1090354")]
				public bool Equals(BattleLib_PlayerMessage.Types.Emote other)
				{
					return new bool();
				}

				[Address(RVA="0x17A3C50", Offset="0x17A3C50", VA="0x17A3C50", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090364", Offset="0x1090364")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17A16AC", Offset="0x17A16AC", VA="0x17A16AC", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10903A4", Offset="0x10903A4")]
				public void MergeFrom(BattleLib_PlayerMessage.Types.Emote other)
				{
				}

				[Address(RVA="0x17A3E50", Offset="0x17A3E50", VA="0x17A3E50", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10903B4", Offset="0x10903B4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17A3CB8", Offset="0x17A3CB8", VA="0x17A3CB8", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090374", Offset="0x1090374")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17A3D20", Offset="0x17A3D20", VA="0x17A3D20", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090384", Offset="0x1090384")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051994", Offset="0x1051994")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_PlayerMessage.Types.Emote.<>c <>9;

					[Address(RVA="0x17A3FA4", Offset="0x17A3FA4", VA="0x17A3FA4")]
					static <>c()
					{
					}

					[Address(RVA="0x17A4008", Offset="0x17A4008", VA="0x17A4008")]
					public <>c()
					{
					}

					[Address(RVA="0x17A4010", Offset="0x17A4010", VA="0x17A4010")]
					internal BattleLib_PlayerMessage.Types.Emote <.cctor>b__25_0()
					{
						return null;
					}
				}
			}

			public sealed class EncounterTransitionDone : IMessage<BattleLib_PlayerMessage.Types.EncounterTransitionDone>, IMessage, IEquatable<BattleLib_PlayerMessage.Types.EncounterTransitionDone>, IDeepCloneable<BattleLib_PlayerMessage.Types.EncounterTransitionDone>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_PlayerMessage.Types.EncounterTransitionDone> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int EncounterIndexFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint encounterIndex_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E118", Offset="0x109E118")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x17A40D4", Offset="0x17A40D4", VA="0x17A40D4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E138", Offset="0x109E138")]
				public uint EncounterIndex
				{
					[Address(RVA="0x17A4280", Offset="0x17A4280", VA="0x17A4280")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17A4288", Offset="0x17A4288", VA="0x17A4288")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E108", Offset="0x109E108")]
				public static MessageParser<BattleLib_PlayerMessage.Types.EncounterTransitionDone> Parser
				{
					[Address(RVA="0x17A406C", Offset="0x17A406C", VA="0x17A406C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E128", Offset="0x109E128")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x17A41C0", Offset="0x17A41C0", VA="0x17A41C0", Slot="7")]
					get
					{
						return null;
					}
				}

				[Address(RVA="0x17A45BC", Offset="0x17A45BC", VA="0x17A45BC")]
				static EncounterTransitionDone()
				{
				}

				[Address(RVA="0x17A165C", Offset="0x17A165C", VA="0x17A165C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090264", Offset="0x1090264")]
				public EncounterTransitionDone()
				{
				}

				[Address(RVA="0x17A421C", Offset="0x17A421C", VA="0x17A421C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090274", Offset="0x1090274")]
				public EncounterTransitionDone(BattleLib_PlayerMessage.Types.EncounterTransitionDone other)
				{
				}

				[Address(RVA="0x17A44B0", Offset="0x17A44B0", VA="0x17A44B0", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10902E4", Offset="0x10902E4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17A0C10", Offset="0x17A0C10", VA="0x17A0C10", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090284", Offset="0x1090284")]
				public BattleLib_PlayerMessage.Types.EncounterTransitionDone Clone()
				{
					return null;
				}

				[Address(RVA="0x17A4290", Offset="0x17A4290", VA="0x17A4290", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090294", Offset="0x1090294")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17A4304", Offset="0x17A4304", VA="0x17A4304", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10902A4", Offset="0x10902A4")]
				public bool Equals(BattleLib_PlayerMessage.Types.EncounterTransitionDone other)
				{
					return new bool();
				}

				[Address(RVA="0x17A4340", Offset="0x17A4340", VA="0x17A4340", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10902B4", Offset="0x10902B4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17A1664", Offset="0x17A1664", VA="0x17A1664", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10902F4", Offset="0x10902F4")]
				public void MergeFrom(BattleLib_PlayerMessage.Types.EncounterTransitionDone other)
				{
				}

				[Address(RVA="0x17A4540", Offset="0x17A4540", VA="0x17A4540", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090304", Offset="0x1090304")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17A43A8", Offset="0x17A43A8", VA="0x17A43A8", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10902C4", Offset="0x10902C4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17A4410", Offset="0x17A4410", VA="0x17A4410", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10902D4", Offset="0x10902D4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051984", Offset="0x1051984")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_PlayerMessage.Types.EncounterTransitionDone.<>c <>9;

					[Address(RVA="0x17A4694", Offset="0x17A4694", VA="0x17A4694")]
					static <>c()
					{
					}

					[Address(RVA="0x17A46F8", Offset="0x17A46F8", VA="0x17A46F8")]
					public <>c()
					{
					}

					[Address(RVA="0x17A4700", Offset="0x17A4700", VA="0x17A4700")]
					internal BattleLib_PlayerMessage.Types.EncounterTransitionDone <.cctor>b__25_0()
					{
						return null;
					}
				}
			}
		}
	}
}