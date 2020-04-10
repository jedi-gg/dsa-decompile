using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleLib_Bootstrap : IMessage<BattleLib_Bootstrap>, IMessage, IEquatable<BattleLib_Bootstrap>, IDeepCloneable<BattleLib_Bootstrap>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleLib_Bootstrap> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int EnvironmentFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private BattleLib_Bootstrap.Types.Environment environment_;

		[FieldOffset(Offset="0x0")]
		public const int PlayersFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<BattleLib_Bootstrap.Types.Player> _repeated_players_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<BattleLib_Bootstrap.Types.Player> players_;

		[FieldOffset(Offset="0x0")]
		public const int RulesetFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private uint ruleset_;

		[FieldOffset(Offset="0x0")]
		public const int MutatorsFieldNumber = 4;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_mutators_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<ulong> mutators_;

		[FieldOffset(Offset="0x0")]
		public const int IntroCinematicOverrideFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string introCinematicOverride_;

		[FieldOffset(Offset="0x0")]
		public const int VisualEffectIdsFieldNumber = 20;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<ulong> _repeated_visualEffectIds_codec;

		[FieldOffset(Offset="0x40")]
		private readonly RepeatedField<ulong> visualEffectIds_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093A70", Offset="0x1093A70")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1E829E4", Offset="0x1E829E4", VA="0x1E829E4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093A90", Offset="0x1093A90")]
		public BattleLib_Bootstrap.Types.Environment Environment
		{
			[Address(RVA="0x1E82D10", Offset="0x1E82D10", VA="0x1E82D10")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E82D78", Offset="0x1E82D78", VA="0x1E82D78")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093AD0", Offset="0x1093AD0")]
		public string IntroCinematicOverride
		{
			[Address(RVA="0x1E82E00", Offset="0x1E82E00", VA="0x1E82E00")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E82E08", Offset="0x1E82E08", VA="0x1E82E08")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093AC0", Offset="0x1093AC0")]
		public RepeatedField<ulong> Mutators
		{
			[Address(RVA="0x1E82DF8", Offset="0x1E82DF8", VA="0x1E82DF8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093A60", Offset="0x1093A60")]
		public static MessageParser<BattleLib_Bootstrap> Parser
		{
			[Address(RVA="0x1E81CB8", Offset="0x1E81CB8", VA="0x1E81CB8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093A80", Offset="0x1093A80")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1E82AD0", Offset="0x1E82AD0", VA="0x1E82AD0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093AA0", Offset="0x1093AA0")]
		public RepeatedField<BattleLib_Bootstrap.Types.Player> Players
		{
			[Address(RVA="0x1E82DE0", Offset="0x1E82DE0", VA="0x1E82DE0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093AB0", Offset="0x1093AB0")]
		public uint Ruleset
		{
			[Address(RVA="0x1E82DE8", Offset="0x1E82DE8", VA="0x1E82DE8")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1E82DF0", Offset="0x1E82DF0", VA="0x1E82DF0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093AE0", Offset="0x1093AE0")]
		public RepeatedField<ulong> VisualEffectIds
		{
			[Address(RVA="0x1E82E78", Offset="0x1E82E78", VA="0x1E82E78")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1E83C04", Offset="0x1E83C04", VA="0x1E83C04")]
		static BattleLib_Bootstrap()
		{
		}

		[Address(RVA="0x1E82B2C", Offset="0x1E82B2C", VA="0x1E82B2C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078DBC", Offset="0x1078DBC")]
		public BattleLib_Bootstrap()
		{
		}

		[Address(RVA="0x1E82BF4", Offset="0x1E82BF4", VA="0x1E82BF4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078DCC", Offset="0x1078DCC")]
		public BattleLib_Bootstrap(BattleLib_Bootstrap other)
		{
		}

		[Address(RVA="0x1E83470", Offset="0x1E83470", VA="0x1E83470", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078E3C", Offset="0x1078E3C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1E82D80", Offset="0x1E82D80", VA="0x1E82D80", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078DDC", Offset="0x1078DDC")]
		public BattleLib_Bootstrap Clone()
		{
			return null;
		}

		[Address(RVA="0x1E82E80", Offset="0x1E82E80", VA="0x1E82E80", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078DEC", Offset="0x1078DEC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1E82EF4", Offset="0x1E82EF4", VA="0x1E82EF4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078DFC", Offset="0x1078DFC")]
		public bool Equals(BattleLib_Bootstrap other)
		{
			return new bool();
		}

		[Address(RVA="0x1E83040", Offset="0x1E83040", VA="0x1E83040", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078E0C", Offset="0x1078E0C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1E836A4", Offset="0x1E836A4", VA="0x1E836A4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078E4C", Offset="0x1078E4C")]
		public void MergeFrom(BattleLib_Bootstrap other)
		{
		}

		[Address(RVA="0x1E839A8", Offset="0x1E839A8", VA="0x1E839A8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078E5C", Offset="0x1078E5C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1E83180", Offset="0x1E83180", VA="0x1E83180", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078E1C", Offset="0x1078E1C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1E831E8", Offset="0x1E831E8", VA="0x1E831E8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078E2C", Offset="0x1078E2C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F418", Offset="0x104F418")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleLib_Bootstrap.<>c <>9;

			[Address(RVA="0x1E83D54", Offset="0x1E83D54", VA="0x1E83D54")]
			static <>c()
			{
			}

			[Address(RVA="0x1E83DB8", Offset="0x1E83DB8", VA="0x1E83DB8")]
			public <>c()
			{
			}

			[Address(RVA="0x1E83DC0", Offset="0x1E83DC0", VA="0x1E83DC0")]
			internal BattleLib_Bootstrap <.cctor>b__51_0()
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x104F408", Offset="0x104F408")]
		public static class Types
		{
			public sealed class Ability : IMessage<BattleLib_Bootstrap.Types.Ability>, IMessage, IEquatable<BattleLib_Bootstrap.Types.Ability>, IDeepCloneable<BattleLib_Bootstrap.Types.Ability>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_Bootstrap.Types.Ability> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int NameKeyFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private string nameKey_;

				[FieldOffset(Offset="0x0")]
				public const int IconFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private string icon_;

				[FieldOffset(Offset="0x0")]
				public const int ManaCostFieldNumber = 3;

				[FieldOffset(Offset="0x28")]
				private uint manaCost_;

				[FieldOffset(Offset="0x0")]
				public const int ActivatedFieldNumber = 4;

				[FieldOffset(Offset="0x2C")]
				private bool activated_;

				[FieldOffset(Offset="0x0")]
				public const int LevelFieldNumber = 5;

				[FieldOffset(Offset="0x30")]
				private uint level_;

				[FieldOffset(Offset="0x0")]
				public const int ShapeFieldNumber = 6;

				[FieldOffset(Offset="0x34")]
				private uint shape_;

				[FieldOffset(Offset="0x0")]
				public const int ShapeLengthFieldNumber = 7;

				[FieldOffset(Offset="0x38")]
				private float shapeLength_;

				[FieldOffset(Offset="0x0")]
				public const int ShapeWidthFieldNumber = 8;

				[FieldOffset(Offset="0x3C")]
				private float shapeWidth_;

				[FieldOffset(Offset="0x0")]
				public const int ShapeAngleFieldNumber = 9;

				[FieldOffset(Offset="0x40")]
				private float shapeAngle_;

				[FieldOffset(Offset="0x0")]
				public const int TargetSelfFieldNumber = 10;

				[FieldOffset(Offset="0x44")]
				private bool targetSelf_;

				[FieldOffset(Offset="0x0")]
				public const int TargetAllyFieldNumber = 11;

				[FieldOffset(Offset="0x45")]
				private bool targetAlly_;

				[FieldOffset(Offset="0x0")]
				public const int TargetEnemyFieldNumber = 12;

				[FieldOffset(Offset="0x46")]
				private bool targetEnemy_;

				[FieldOffset(Offset="0x0")]
				public const int AddUnitMaxCountFieldNumber = 13;

				[FieldOffset(Offset="0x48")]
				private uint addUnitMaxCount_;

				[FieldOffset(Offset="0x0")]
				public const int AddUnitFieldNumber = 14;

				[FieldOffset(Offset="0x50")]
				private BattleLib_Bootstrap.Types.Unit addUnit_;

				[FieldOffset(Offset="0x0")]
				public const int GeoIdFieldNumber = 15;

				[FieldOffset(Offset="0x58")]
				private ulong geoId_;

				[FieldOffset(Offset="0x0")]
				public const int RangeFieldNumber = 16;

				[FieldOffset(Offset="0x60")]
				private float range_;

				[FieldOffset(Offset="0x0")]
				public const int IdFieldNumber = 17;

				[FieldOffset(Offset="0x64")]
				private uint id_;

				[FieldOffset(Offset="0x0")]
				public const int CastAreaFieldNumber = 18;

				[FieldOffset(Offset="0x68")]
				private uint castArea_;

				[FieldOffset(Offset="0x0")]
				public const int IsAlternateFieldNumber = 19;

				[FieldOffset(Offset="0x6C")]
				private bool isAlternate_;

				[FieldOffset(Offset="0x0")]
				public const int DescKeyFieldNumber = 20;

				[FieldOffset(Offset="0x70")]
				private string descKey_;

				[FieldOffset(Offset="0x0")]
				public const int PreviewStrengthFieldNumber = 21;

				[FieldOffset(Offset="0x78")]
				private bool previewStrength_;

				[FieldOffset(Offset="0x0")]
				public const int IgnoreBuildingsFieldNumber = 22;

				[FieldOffset(Offset="0x79")]
				private bool ignoreBuildings_;

				[FieldOffset(Offset="0x0")]
				public const int InitialManaFieldNumber = 23;

				[FieldOffset(Offset="0x7C")]
				private uint initialMana_;

				[FieldOffset(Offset="0x0")]
				public const int AbilityTypeFieldNumber = 24;

				[FieldOffset(Offset="0x80")]
				private uint abilityType_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E578", Offset="0x109E578")]
				public uint AbilityType
				{
					[Address(RVA="0x1E844F4", Offset="0x1E844F4", VA="0x1E844F4")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E844FC", Offset="0x1E844FC", VA="0x1E844FC")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E438", Offset="0x109E438")]
				public bool Activated
				{
					[Address(RVA="0x1E84340", Offset="0x1E84340", VA="0x1E84340")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x1E84348", Offset="0x1E84348", VA="0x1E84348")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E4D8", Offset="0x109E4D8")]
				public BattleLib_Bootstrap.Types.Unit AddUnit
				{
					[Address(RVA="0x1E841D0", Offset="0x1E841D0", VA="0x1E841D0")]
					get
					{
						return null;
					}
					[Address(RVA="0x1E841D8", Offset="0x1E841D8", VA="0x1E841D8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E4C8", Offset="0x109E4C8")]
				public uint AddUnitMaxCount
				{
					[Address(RVA="0x1E843E0", Offset="0x1E843E0", VA="0x1E843E0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E843E8", Offset="0x1E843E8", VA="0x1E843E8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E518", Offset="0x109E518")]
				public uint CastArea
				{
					[Address(RVA="0x1E84420", Offset="0x1E84420", VA="0x1E84420")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E84428", Offset="0x1E84428", VA="0x1E84428")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E538", Offset="0x109E538")]
				public string DescKey
				{
					[Address(RVA="0x1E84444", Offset="0x1E84444", VA="0x1E84444")]
					get
					{
						return null;
					}
					[Address(RVA="0x1E8444C", Offset="0x1E8444C", VA="0x1E8444C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E3E8", Offset="0x109E3E8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x1E83E18", Offset="0x1E83E18", VA="0x1E83E18")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E4E8", Offset="0x109E4E8")]
				public ulong GeoId
				{
					[Address(RVA="0x1E843F0", Offset="0x1E843F0", VA="0x1E843F0")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x1E843F8", Offset="0x1E843F8", VA="0x1E843F8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E418", Offset="0x109E418")]
				public string Icon
				{
					[Address(RVA="0x1E842B8", Offset="0x1E842B8", VA="0x1E842B8")]
					get
					{
						return null;
					}
					[Address(RVA="0x1E842C0", Offset="0x1E842C0", VA="0x1E842C0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E508", Offset="0x109E508")]
				public uint Id
				{
					[Address(RVA="0x1E84410", Offset="0x1E84410", VA="0x1E84410")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E84418", Offset="0x1E84418", VA="0x1E84418")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E558", Offset="0x109E558")]
				public bool IgnoreBuildings
				{
					[Address(RVA="0x1E844D0", Offset="0x1E844D0", VA="0x1E844D0")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x1E844D8", Offset="0x1E844D8", VA="0x1E844D8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E568", Offset="0x109E568")]
				public uint InitialMana
				{
					[Address(RVA="0x1E844E4", Offset="0x1E844E4", VA="0x1E844E4")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E844EC", Offset="0x1E844EC", VA="0x1E844EC")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E528", Offset="0x109E528")]
				public bool IsAlternate
				{
					[Address(RVA="0x1E84430", Offset="0x1E84430", VA="0x1E84430")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x1E84438", Offset="0x1E84438", VA="0x1E84438")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E448", Offset="0x109E448")]
				public uint Level
				{
					[Address(RVA="0x1E84354", Offset="0x1E84354", VA="0x1E84354")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E8435C", Offset="0x1E8435C", VA="0x1E8435C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E428", Offset="0x109E428")]
				public uint ManaCost
				{
					[Address(RVA="0x1E84330", Offset="0x1E84330", VA="0x1E84330")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E84338", Offset="0x1E84338", VA="0x1E84338")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E408", Offset="0x109E408")]
				public string NameKey
				{
					[Address(RVA="0x1E84240", Offset="0x1E84240", VA="0x1E84240")]
					get
					{
						return null;
					}
					[Address(RVA="0x1E84248", Offset="0x1E84248", VA="0x1E84248")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E3D8", Offset="0x109E3D8")]
				public static MessageParser<BattleLib_Bootstrap.Types.Ability> Parser
				{
					[Address(RVA="0x1E81F28", Offset="0x1E81F28", VA="0x1E81F28")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E3F8", Offset="0x109E3F8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x1E83F04", Offset="0x1E83F04", VA="0x1E83F04", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E548", Offset="0x109E548")]
				public bool PreviewStrength
				{
					[Address(RVA="0x1E844BC", Offset="0x1E844BC", VA="0x1E844BC")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x1E844C4", Offset="0x1E844C4", VA="0x1E844C4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E4F8", Offset="0x109E4F8")]
				public float Range
				{
					[Address(RVA="0x1E84400", Offset="0x1E84400", VA="0x1E84400")]
					get
					{
						return new float();
					}
					[Address(RVA="0x1E84408", Offset="0x1E84408", VA="0x1E84408")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E458", Offset="0x109E458")]
				public uint Shape
				{
					[Address(RVA="0x1E84364", Offset="0x1E84364", VA="0x1E84364")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E8436C", Offset="0x1E8436C", VA="0x1E8436C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E488", Offset="0x109E488")]
				public float ShapeAngle
				{
					[Address(RVA="0x1E84394", Offset="0x1E84394", VA="0x1E84394")]
					get
					{
						return new float();
					}
					[Address(RVA="0x1E8439C", Offset="0x1E8439C", VA="0x1E8439C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E468", Offset="0x109E468")]
				public float ShapeLength
				{
					[Address(RVA="0x1E84374", Offset="0x1E84374", VA="0x1E84374")]
					get
					{
						return new float();
					}
					[Address(RVA="0x1E8437C", Offset="0x1E8437C", VA="0x1E8437C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E478", Offset="0x109E478")]
				public float ShapeWidth
				{
					[Address(RVA="0x1E84384", Offset="0x1E84384", VA="0x1E84384")]
					get
					{
						return new float();
					}
					[Address(RVA="0x1E8438C", Offset="0x1E8438C", VA="0x1E8438C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E4A8", Offset="0x109E4A8")]
				public bool TargetAlly
				{
					[Address(RVA="0x1E843B8", Offset="0x1E843B8", VA="0x1E843B8")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x1E843C0", Offset="0x1E843C0", VA="0x1E843C0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E4B8", Offset="0x109E4B8")]
				public bool TargetEnemy
				{
					[Address(RVA="0x1E843CC", Offset="0x1E843CC", VA="0x1E843CC")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x1E843D4", Offset="0x1E843D4", VA="0x1E843D4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E498", Offset="0x109E498")]
				public bool TargetSelf
				{
					[Address(RVA="0x1E843A4", Offset="0x1E843A4", VA="0x1E843A4")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x1E843AC", Offset="0x1E843AC", VA="0x1E843AC")]
					set
					{
					}
				}

				[Address(RVA="0x1E86304", Offset="0x1E86304", VA="0x1E86304")]
				static Ability()
				{
				}

				[Address(RVA="0x1E83F60", Offset="0x1E83F60", VA="0x1E83F60")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090734", Offset="0x1090734")]
				public Ability()
				{
				}

				[Address(RVA="0x1E83FBC", Offset="0x1E83FBC", VA="0x1E83FBC")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090744", Offset="0x1090744")]
				public Ability(BattleLib_Bootstrap.Types.Ability other)
				{
				}

				[Address(RVA="0x1E8577C", Offset="0x1E8577C", VA="0x1E8577C", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10907B4", Offset="0x10907B4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x1E841E0", Offset="0x1E841E0", VA="0x1E841E0", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090754", Offset="0x1090754")]
				public BattleLib_Bootstrap.Types.Ability Clone()
				{
					return null;
				}

				[Address(RVA="0x1E84504", Offset="0x1E84504", VA="0x1E84504", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090764", Offset="0x1090764")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x1E84578", Offset="0x1E84578", VA="0x1E84578", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090774", Offset="0x1090774")]
				public bool Equals(BattleLib_Bootstrap.Types.Ability other)
				{
					return new bool();
				}

				[Address(RVA="0x1E8490C", Offset="0x1E8490C", VA="0x1E8490C", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090784", Offset="0x1090784")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x1E85BEC", Offset="0x1E85BEC", VA="0x1E85BEC", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10907C4", Offset="0x10907C4")]
				public void MergeFrom(BattleLib_Bootstrap.Types.Ability other)
				{
				}

				[Address(RVA="0x1E85E24", Offset="0x1E85E24", VA="0x1E85E24", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10907D4", Offset="0x10907D4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x1E84DC4", Offset="0x1E84DC4", VA="0x1E84DC4", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090794", Offset="0x1090794")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x1E84E2C", Offset="0x1E84E2C", VA="0x1E84E2C", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10907A4", Offset="0x10907A4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10519F4", Offset="0x10519F4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_Bootstrap.Types.Ability.<>c <>9;

					[Address(RVA="0x1E863DC", Offset="0x1E863DC", VA="0x1E863DC")]
					static <>c()
					{
					}

					[Address(RVA="0x1E86440", Offset="0x1E86440", VA="0x1E86440")]
					public <>c()
					{
					}

					[Address(RVA="0x1E86448", Offset="0x1E86448", VA="0x1E86448")]
					internal BattleLib_Bootstrap.Types.Ability <.cctor>b__140_0()
					{
						return null;
					}
				}
			}

			public sealed class Encounter : IMessage<BattleLib_Bootstrap.Types.Encounter>, IMessage, IEquatable<BattleLib_Bootstrap.Types.Encounter>, IDeepCloneable<BattleLib_Bootstrap.Types.Encounter>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_Bootstrap.Types.Encounter> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int IdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private string id_;

				[FieldOffset(Offset="0x0")]
				public const int XFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private float x_;

				[FieldOffset(Offset="0x0")]
				public const int YFieldNumber = 3;

				[FieldOffset(Offset="0x24")]
				private float y_;

				[FieldOffset(Offset="0x0")]
				public const int NumLanesFieldNumber = 4;

				[FieldOffset(Offset="0x28")]
				private uint numLanes_;

				[FieldOffset(Offset="0x0")]
				public const int GridGapFieldNumber = 5;

				[FieldOffset(Offset="0x2C")]
				private uint gridGap_;

				[FieldOffset(Offset="0x0")]
				public const int CinematicFieldNumber = 6;

				[FieldOffset(Offset="0x30")]
				private string cinematic_;

				[FieldOffset(Offset="0x0")]
				public const int VerticalityFieldNumber = 7;

				[FieldOffset(Offset="0x38")]
				private float verticality_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E208", Offset="0x109E208")]
				public string Cinematic
				{
					[Address(RVA="0x1E86864", Offset="0x1E86864", VA="0x1E86864")]
					get
					{
						return null;
					}
					[Address(RVA="0x1E8686C", Offset="0x1E8686C", VA="0x1E8686C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E198", Offset="0x109E198")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x1E864A0", Offset="0x1E864A0", VA="0x1E864A0")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E1F8", Offset="0x109E1F8")]
				public uint GridGap
				{
					[Address(RVA="0x1E86854", Offset="0x1E86854", VA="0x1E86854")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E8685C", Offset="0x1E8685C", VA="0x1E8685C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E1B8", Offset="0x109E1B8")]
				public string Id
				{
					[Address(RVA="0x1E867AC", Offset="0x1E867AC", VA="0x1E867AC")]
					get
					{
						return null;
					}
					[Address(RVA="0x1E867B4", Offset="0x1E867B4", VA="0x1E867B4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E1E8", Offset="0x109E1E8")]
				public uint NumLanes
				{
					[Address(RVA="0x1E86844", Offset="0x1E86844", VA="0x1E86844")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E8684C", Offset="0x1E8684C", VA="0x1E8684C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E188", Offset="0x109E188")]
				public static MessageParser<BattleLib_Bootstrap.Types.Encounter> Parser
				{
					[Address(RVA="0x1E81D20", Offset="0x1E81D20", VA="0x1E81D20")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E1A8", Offset="0x109E1A8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x1E8658C", Offset="0x1E8658C", VA="0x1E8658C", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E218", Offset="0x109E218")]
				public float Verticality
				{
					[Address(RVA="0x1E868DC", Offset="0x1E868DC", VA="0x1E868DC")]
					get
					{
						return new float();
					}
					[Address(RVA="0x1E868E4", Offset="0x1E868E4", VA="0x1E868E4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E1C8", Offset="0x109E1C8")]
				public float X
				{
					[Address(RVA="0x1E86824", Offset="0x1E86824", VA="0x1E86824")]
					get
					{
						return new float();
					}
					[Address(RVA="0x1E8682C", Offset="0x1E8682C", VA="0x1E8682C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E1D8", Offset="0x109E1D8")]
				public float Y
				{
					[Address(RVA="0x1E86834", Offset="0x1E86834", VA="0x1E86834")]
					get
					{
						return new float();
					}
					[Address(RVA="0x1E8683C", Offset="0x1E8683C", VA="0x1E8683C")]
					set
					{
					}
				}

				[Address(RVA="0x1E87504", Offset="0x1E87504", VA="0x1E87504")]
				static Encounter()
				{
				}

				[Address(RVA="0x1E865E8", Offset="0x1E865E8", VA="0x1E865E8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10903C4", Offset="0x10903C4")]
				public Encounter()
				{
				}

				[Address(RVA="0x1E86644", Offset="0x1E86644", VA="0x1E86644")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10903D4", Offset="0x10903D4")]
				public Encounter(BattleLib_Bootstrap.Types.Encounter other)
				{
				}

				[Address(RVA="0x1E870E0", Offset="0x1E870E0", VA="0x1E870E0", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090444", Offset="0x1090444")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x1E8674C", Offset="0x1E8674C", VA="0x1E8674C", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10903E4", Offset="0x10903E4")]
				public BattleLib_Bootstrap.Types.Encounter Clone()
				{
					return null;
				}

				[Address(RVA="0x1E868EC", Offset="0x1E868EC", VA="0x1E868EC", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10903F4", Offset="0x10903F4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x1E86960", Offset="0x1E86960", VA="0x1E86960", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090404", Offset="0x1090404")]
				public bool Equals(BattleLib_Bootstrap.Types.Encounter other)
				{
					return new bool();
				}

				[Address(RVA="0x1E86B2C", Offset="0x1E86B2C", VA="0x1E86B2C", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090414", Offset="0x1090414")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x1E87298", Offset="0x1E87298", VA="0x1E87298", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090454", Offset="0x1090454")]
				public void MergeFrom(BattleLib_Bootstrap.Types.Encounter other)
				{
				}

				[Address(RVA="0x1E87378", Offset="0x1E87378", VA="0x1E87378", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090464", Offset="0x1090464")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x1E86D80", Offset="0x1E86D80", VA="0x1E86D80", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090424", Offset="0x1090424")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x1E86DE8", Offset="0x1E86DE8", VA="0x1E86DE8", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090434", Offset="0x1090434")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10519A4", Offset="0x10519A4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_Bootstrap.Types.Encounter.<>c <>9;

					[Address(RVA="0x1E875DC", Offset="0x1E875DC", VA="0x1E875DC")]
					static <>c()
					{
					}

					[Address(RVA="0x1E87640", Offset="0x1E87640", VA="0x1E87640")]
					public <>c()
					{
					}

					[Address(RVA="0x1E87648", Offset="0x1E87648", VA="0x1E87648")]
					internal BattleLib_Bootstrap.Types.Encounter <.cctor>b__55_0()
					{
						return null;
					}
				}
			}

			public sealed class Environment : IMessage<BattleLib_Bootstrap.Types.Environment>, IMessage, IEquatable<BattleLib_Bootstrap.Types.Environment>, IDeepCloneable<BattleLib_Bootstrap.Types.Environment>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_Bootstrap.Types.Environment> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int PrefabsFieldNumber = 1;

				[FieldOffset(Offset="0x8")]
				private readonly static FieldCodec<string> _repeated_prefabs_codec;

				[FieldOffset(Offset="0x18")]
				private readonly RepeatedField<string> prefabs_;

				[FieldOffset(Offset="0x0")]
				public const int MapFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private BattleLib_Bootstrap.Types.Map map_;

				[FieldOffset(Offset="0x0")]
				public const int SpawnPointsFieldNumber = 3;

				[FieldOffset(Offset="0x10")]
				private readonly static FieldCodec<BattleLib_Bootstrap.Types.SpawnPoint> _repeated_spawnPoints_codec;

				[FieldOffset(Offset="0x28")]
				private readonly RepeatedField<BattleLib_Bootstrap.Types.SpawnPoint> spawnPoints_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E388", Offset="0x109E388")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x1E876A0", Offset="0x1E876A0", VA="0x1E876A0")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E3B8", Offset="0x109E3B8")]
				public BattleLib_Bootstrap.Types.Map Map
				{
					[Address(RVA="0x1E878B8", Offset="0x1E878B8", VA="0x1E878B8")]
					get
					{
						return null;
					}
					[Address(RVA="0x1E87920", Offset="0x1E87920", VA="0x1E87920")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E378", Offset="0x109E378")]
				public static MessageParser<BattleLib_Bootstrap.Types.Environment> Parser
				{
					[Address(RVA="0x1E81EC0", Offset="0x1E81EC0", VA="0x1E81EC0")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E398", Offset="0x109E398")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x1E8778C", Offset="0x1E8778C", VA="0x1E8778C", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E3A8", Offset="0x109E3A8")]
				public RepeatedField<string> Prefabs
				{
					[Address(RVA="0x1E87928", Offset="0x1E87928", VA="0x1E87928")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E3C8", Offset="0x109E3C8")]
				public RepeatedField<BattleLib_Bootstrap.Types.SpawnPoint> SpawnPoints
				{
					[Address(RVA="0x1E87930", Offset="0x1E87930", VA="0x1E87930")]
					get
					{
						return null;
					}
				}

				[Address(RVA="0x1E88188", Offset="0x1E88188", VA="0x1E88188")]
				static Environment()
				{
				}

				[Address(RVA="0x1E8380C", Offset="0x1E8380C", VA="0x1E8380C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090684", Offset="0x1090684")]
				public Environment()
				{
				}

				[Address(RVA="0x1E877E8", Offset="0x1E877E8", VA="0x1E877E8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090694", Offset="0x1090694")]
				public Environment(BattleLib_Bootstrap.Types.Environment other)
				{
				}

				[Address(RVA="0x1E87D28", Offset="0x1E87D28", VA="0x1E87D28", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090704", Offset="0x1090704")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x1E82D18", Offset="0x1E82D18", VA="0x1E82D18", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10906A4", Offset="0x10906A4")]
				public BattleLib_Bootstrap.Types.Environment Clone()
				{
					return null;
				}

				[Address(RVA="0x1E87938", Offset="0x1E87938", VA="0x1E87938", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10906B4", Offset="0x10906B4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x1E879AC", Offset="0x1E879AC", VA="0x1E879AC", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10906C4", Offset="0x10906C4")]
				public bool Equals(BattleLib_Bootstrap.Types.Environment other)
				{
					return new bool();
				}

				[Address(RVA="0x1E87AA0", Offset="0x1E87AA0", VA="0x1E87AA0", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10906D4", Offset="0x10906D4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x1E838A4", Offset="0x1E838A4", VA="0x1E838A4", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090714", Offset="0x1090714")]
				public void MergeFrom(BattleLib_Bootstrap.Types.Environment other)
				{
				}

				[Address(RVA="0x1E87FF4", Offset="0x1E87FF4", VA="0x1E87FF4", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090724", Offset="0x1090724")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x1E87B48", Offset="0x1E87B48", VA="0x1E87B48", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10906E4", Offset="0x10906E4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x1E87BB0", Offset="0x1E87BB0", VA="0x1E87BB0", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10906F4", Offset="0x10906F4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10519E4", Offset="0x10519E4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_Bootstrap.Types.Environment.<>c <>9;

					[Address(RVA="0x1E882C0", Offset="0x1E882C0", VA="0x1E882C0")]
					static <>c()
					{
					}

					[Address(RVA="0x1E88324", Offset="0x1E88324", VA="0x1E88324")]
					public <>c()
					{
					}

					[Address(RVA="0x1E8832C", Offset="0x1E8832C", VA="0x1E8832C")]
					internal BattleLib_Bootstrap.Types.Environment <.cctor>b__35_0()
					{
						return null;
					}
				}
			}

			public sealed class Map : IMessage<BattleLib_Bootstrap.Types.Map>, IMessage, IEquatable<BattleLib_Bootstrap.Types.Map>, IDeepCloneable<BattleLib_Bootstrap.Types.Map>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_Bootstrap.Types.Map> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int WidthFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private float width_;

				[FieldOffset(Offset="0x0")]
				public const int HeightFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private float height_;

				[FieldOffset(Offset="0x0")]
				public const int GridScaleFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private float gridScale_;

				[FieldOffset(Offset="0x0")]
				public const int EncountersFieldNumber = 4;

				[FieldOffset(Offset="0x8")]
				private readonly static FieldCodec<BattleLib_Bootstrap.Types.Encounter> _repeated_encounters_codec;

				[FieldOffset(Offset="0x28")]
				private readonly RepeatedField<BattleLib_Bootstrap.Types.Encounter> encounters_;

				[FieldOffset(Offset="0x0")]
				public const int ObstructionsFieldNumber = 5;

				[FieldOffset(Offset="0x10")]
				private readonly static FieldCodec<BattleLib_Bootstrap.Types.Obstruction> _repeated_obstructions_codec;

				[FieldOffset(Offset="0x30")]
				private readonly RepeatedField<BattleLib_Bootstrap.Types.Obstruction> obstructions_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E298", Offset="0x109E298")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x1E88384", Offset="0x1E88384", VA="0x1E88384")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E2E8", Offset="0x109E2E8")]
				public RepeatedField<BattleLib_Bootstrap.Types.Encounter> Encounters
				{
					[Address(RVA="0x1E88614", Offset="0x1E88614", VA="0x1E88614")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E2D8", Offset="0x109E2D8")]
				public float GridScale
				{
					[Address(RVA="0x1E88604", Offset="0x1E88604", VA="0x1E88604")]
					get
					{
						return new float();
					}
					[Address(RVA="0x1E8860C", Offset="0x1E8860C", VA="0x1E8860C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E2C8", Offset="0x109E2C8")]
				public float Height
				{
					[Address(RVA="0x1E885F4", Offset="0x1E885F4", VA="0x1E885F4")]
					get
					{
						return new float();
					}
					[Address(RVA="0x1E885FC", Offset="0x1E885FC", VA="0x1E885FC")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E2F8", Offset="0x109E2F8")]
				public RepeatedField<BattleLib_Bootstrap.Types.Obstruction> Obstructions
				{
					[Address(RVA="0x1E8861C", Offset="0x1E8861C", VA="0x1E8861C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E288", Offset="0x109E288")]
				public static MessageParser<BattleLib_Bootstrap.Types.Map> Parser
				{
					[Address(RVA="0x1E81DF0", Offset="0x1E81DF0", VA="0x1E81DF0")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E2A8", Offset="0x109E2A8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x1E88470", Offset="0x1E88470", VA="0x1E88470", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E2B8", Offset="0x109E2B8")]
				public float Width
				{
					[Address(RVA="0x1E885E4", Offset="0x1E885E4", VA="0x1E885E4")]
					get
					{
						return new float();
					}
					[Address(RVA="0x1E885EC", Offset="0x1E885EC", VA="0x1E885EC")]
					set
					{
					}
				}

				[Address(RVA="0x1E88FBC", Offset="0x1E88FBC", VA="0x1E88FBC")]
				static Map()
				{
				}

				[Address(RVA="0x1E87E70", Offset="0x1E87E70", VA="0x1E87E70")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090524", Offset="0x1090524")]
				public Map()
				{
				}

				[Address(RVA="0x1E884CC", Offset="0x1E884CC", VA="0x1E884CC")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090534", Offset="0x1090534")]
				public Map(BattleLib_Bootstrap.Types.Map other)
				{
				}

				[Address(RVA="0x1E88CE0", Offset="0x1E88CE0", VA="0x1E88CE0", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10905A4", Offset="0x10905A4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x1E878C0", Offset="0x1E878C0", VA="0x1E878C0", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090544", Offset="0x1090544")]
				public BattleLib_Bootstrap.Types.Map Clone()
				{
					return null;
				}

				[Address(RVA="0x1E88624", Offset="0x1E88624", VA="0x1E88624", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090554", Offset="0x1090554")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x1E88698", Offset="0x1E88698", VA="0x1E88698", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090564", Offset="0x1090564")]
				public bool Equals(BattleLib_Bootstrap.Types.Map other)
				{
					return new bool();
				}

				[Address(RVA="0x1E8887C", Offset="0x1E8887C", VA="0x1E8887C", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090574", Offset="0x1090574")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x1E87F08", Offset="0x1E87F08", VA="0x1E87F08", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10905B4", Offset="0x10905B4")]
				public void MergeFrom(BattleLib_Bootstrap.Types.Map other)
				{
				}

				[Address(RVA="0x1E88E08", Offset="0x1E88E08", VA="0x1E88E08", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10905C4", Offset="0x10905C4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x1E88A50", Offset="0x1E88A50", VA="0x1E88A50", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090584", Offset="0x1090584")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x1E88AB8", Offset="0x1E88AB8", VA="0x1E88AB8", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090594", Offset="0x1090594")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10519C4", Offset="0x10519C4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_Bootstrap.Types.Map.<>c <>9;

					[Address(RVA="0x1E89124", Offset="0x1E89124", VA="0x1E89124")]
					static <>c()
					{
					}

					[Address(RVA="0x1E89188", Offset="0x1E89188", VA="0x1E89188")]
					public <>c()
					{
					}

					[Address(RVA="0x1E89190", Offset="0x1E89190", VA="0x1E89190")]
					internal BattleLib_Bootstrap.Types.Map <.cctor>b__45_0()
					{
						return null;
					}
				}
			}

			public sealed class Obstruction : IMessage<BattleLib_Bootstrap.Types.Obstruction>, IMessage, IEquatable<BattleLib_Bootstrap.Types.Obstruction>, IDeepCloneable<BattleLib_Bootstrap.Types.Obstruction>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_Bootstrap.Types.Obstruction> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int XStartFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint xStart_;

				[FieldOffset(Offset="0x0")]
				public const int XEndFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint xEnd_;

				[FieldOffset(Offset="0x0")]
				public const int YFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private uint y_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E238", Offset="0x109E238")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x1E891E8", Offset="0x1E891E8", VA="0x1E891E8")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E228", Offset="0x109E228")]
				public static MessageParser<BattleLib_Bootstrap.Types.Obstruction> Parser
				{
					[Address(RVA="0x1E81D88", Offset="0x1E81D88", VA="0x1E81D88")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E248", Offset="0x109E248")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x1E892D4", Offset="0x1E892D4", VA="0x1E892D4", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E268", Offset="0x109E268")]
				public uint XEnd
				{
					[Address(RVA="0x1E89444", Offset="0x1E89444", VA="0x1E89444")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E8944C", Offset="0x1E8944C", VA="0x1E8944C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E258", Offset="0x109E258")]
				public uint XStart
				{
					[Address(RVA="0x1E89434", Offset="0x1E89434", VA="0x1E89434")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E8943C", Offset="0x1E8943C", VA="0x1E8943C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E278", Offset="0x109E278")]
				public uint Y
				{
					[Address(RVA="0x1E89454", Offset="0x1E89454", VA="0x1E89454")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E8945C", Offset="0x1E8945C", VA="0x1E8945C")]
					set
					{
					}
				}

				[Address(RVA="0x1E899CC", Offset="0x1E899CC", VA="0x1E899CC")]
				static Obstruction()
				{
				}

				[Address(RVA="0x1E89330", Offset="0x1E89330", VA="0x1E89330")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090474", Offset="0x1090474")]
				public Obstruction()
				{
				}

				[Address(RVA="0x1E89338", Offset="0x1E89338", VA="0x1E89338")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090484", Offset="0x1090484")]
				public Obstruction(BattleLib_Bootstrap.Types.Obstruction other)
				{
				}

				[Address(RVA="0x1E8978C", Offset="0x1E8978C", VA="0x1E8978C", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10904F4", Offset="0x10904F4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x1E893D4", Offset="0x1E893D4", VA="0x1E893D4", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090494", Offset="0x1090494")]
				public BattleLib_Bootstrap.Types.Obstruction Clone()
				{
					return null;
				}

				[Address(RVA="0x1E89464", Offset="0x1E89464", VA="0x1E89464", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10904A4", Offset="0x10904A4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x1E894D8", Offset="0x1E894D8", VA="0x1E894D8", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10904B4", Offset="0x10904B4")]
				public bool Equals(BattleLib_Bootstrap.Types.Obstruction other)
				{
					return new bool();
				}

				[Address(RVA="0x1E89534", Offset="0x1E89534", VA="0x1E89534", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10904C4", Offset="0x10904C4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x1E8989C", Offset="0x1E8989C", VA="0x1E8989C", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090504", Offset="0x1090504")]
				public void MergeFrom(BattleLib_Bootstrap.Types.Obstruction other)
				{
				}

				[Address(RVA="0x1E898F4", Offset="0x1E898F4", VA="0x1E898F4", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090514", Offset="0x1090514")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x1E895D4", Offset="0x1E895D4", VA="0x1E895D4", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10904D4", Offset="0x10904D4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x1E8963C", Offset="0x1E8963C", VA="0x1E8963C", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10904E4", Offset="0x10904E4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10519B4", Offset="0x10519B4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_Bootstrap.Types.Obstruction.<>c <>9;

					[Address(RVA="0x1E89AA4", Offset="0x1E89AA4", VA="0x1E89AA4")]
					static <>c()
					{
					}

					[Address(RVA="0x1E89B08", Offset="0x1E89B08", VA="0x1E89B08")]
					public <>c()
					{
					}

					[Address(RVA="0x1E89B10", Offset="0x1E89B10", VA="0x1E89B10")]
					internal BattleLib_Bootstrap.Types.Obstruction <.cctor>b__35_0()
					{
						return null;
					}
				}
			}

			public sealed class Player : IMessage<BattleLib_Bootstrap.Types.Player>, IMessage, IEquatable<BattleLib_Bootstrap.Types.Player>, IDeepCloneable<BattleLib_Bootstrap.Types.Player>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_Bootstrap.Types.Player> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int AiContentIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private ulong aiContentId_;

				[FieldOffset(Offset="0x0")]
				public const int SquadsFieldNumber = 2;

				[FieldOffset(Offset="0x8")]
				private readonly static FieldCodec<BattleLib_Bootstrap.Types.Squad> _repeated_squads_codec;

				[FieldOffset(Offset="0x20")]
				private readonly RepeatedField<BattleLib_Bootstrap.Types.Squad> squads_;

				[FieldOffset(Offset="0x0")]
				public const int IsHumanFieldNumber = 3;

				[FieldOffset(Offset="0x28")]
				private bool isHuman_;

				[FieldOffset(Offset="0x0")]
				public const int PlayerIdFieldNumber = 4;

				[FieldOffset(Offset="0x2C")]
				private uint playerId_;

				[FieldOffset(Offset="0x0")]
				public const int TeamIdFieldNumber = 5;

				[FieldOffset(Offset="0x30")]
				private uint teamId_;

				[FieldOffset(Offset="0x0")]
				public const int SpellsFieldNumber = 6;

				[FieldOffset(Offset="0x10")]
				private readonly static FieldCodec<BattleLib_Bootstrap.Types.Spell> _repeated_spells_codec;

				[FieldOffset(Offset="0x38")]
				private readonly RepeatedField<BattleLib_Bootstrap.Types.Spell> spells_;

				[FieldOffset(Offset="0x0")]
				public const int ActivityTrackersFieldNumber = 7;

				[FieldOffset(Offset="0x18")]
				private readonly static FieldCodec<BattleLib_ActivityTracker> _repeated_activityTrackers_codec;

				[FieldOffset(Offset="0x40")]
				private readonly RepeatedField<BattleLib_ActivityTracker> activityTrackers_;

				[FieldOffset(Offset="0x0")]
				public const int PlayerLevelFieldNumber = 8;

				[FieldOffset(Offset="0x48")]
				private uint playerLevel_;

				[FieldOffset(Offset="0x0")]
				public const int EnableAutoFieldNumber = 9;

				[FieldOffset(Offset="0x4C")]
				private bool enableAuto_;

				[FieldOffset(Offset="0x0")]
				public const int EmotesFieldNumber = 10;

				[FieldOffset(Offset="0x20")]
				private readonly static FieldCodec<ulong> _repeated_emotes_codec;

				[FieldOffset(Offset="0x50")]
				private readonly RepeatedField<ulong> emotes_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E9A8", Offset="0x109E9A8")]
				public RepeatedField<BattleLib_ActivityTracker> ActivityTrackers
				{
					[Address(RVA="0x1E89FA8", Offset="0x1E89FA8", VA="0x1E89FA8")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E948", Offset="0x109E948")]
				public ulong AiContentId
				{
					[Address(RVA="0x1E89F54", Offset="0x1E89F54", VA="0x1E89F54")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x1E89F5C", Offset="0x1E89F5C", VA="0x1E89F5C")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E928", Offset="0x109E928")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x1E89B6C", Offset="0x1E89B6C", VA="0x1E89B6C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E9D8", Offset="0x109E9D8")]
				public RepeatedField<ulong> Emotes
				{
					[Address(RVA="0x1E89FD4", Offset="0x1E89FD4", VA="0x1E89FD4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E9C8", Offset="0x109E9C8")]
				public bool EnableAuto
				{
					[Address(RVA="0x1E89FC0", Offset="0x1E89FC0", VA="0x1E89FC0")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x1E89FC8", Offset="0x1E89FC8", VA="0x1E89FC8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E968", Offset="0x109E968")]
				public bool IsHuman
				{
					[Address(RVA="0x1E89F6C", Offset="0x1E89F6C", VA="0x1E89F6C")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x1E89F74", Offset="0x1E89F74", VA="0x1E89F74")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E918", Offset="0x109E918")]
				public static MessageParser<BattleLib_Bootstrap.Types.Player> Parser
				{
					[Address(RVA="0x1E81FF8", Offset="0x1E81FF8", VA="0x1E81FF8")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E938", Offset="0x109E938")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x1E89C58", Offset="0x1E89C58", VA="0x1E89C58", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E978", Offset="0x109E978")]
				public uint PlayerId
				{
					[Address(RVA="0x1E89F80", Offset="0x1E89F80", VA="0x1E89F80")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E89F88", Offset="0x1E89F88", VA="0x1E89F88")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E9B8", Offset="0x109E9B8")]
				public uint PlayerLevel
				{
					[Address(RVA="0x1E89FB0", Offset="0x1E89FB0", VA="0x1E89FB0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E89FB8", Offset="0x1E89FB8", VA="0x1E89FB8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E998", Offset="0x109E998")]
				public RepeatedField<BattleLib_Bootstrap.Types.Spell> Spells
				{
					[Address(RVA="0x1E89FA0", Offset="0x1E89FA0", VA="0x1E89FA0")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E958", Offset="0x109E958")]
				public RepeatedField<BattleLib_Bootstrap.Types.Squad> Squads
				{
					[Address(RVA="0x1E89F64", Offset="0x1E89F64", VA="0x1E89F64")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E988", Offset="0x109E988")]
				public uint TeamId
				{
					[Address(RVA="0x1E89F90", Offset="0x1E89F90", VA="0x1E89F90")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E89F98", Offset="0x1E89F98", VA="0x1E89F98")]
					set
					{
					}
				}

				[Address(RVA="0x1E8AEE0", Offset="0x1E8AEE0", VA="0x1E8AEE0")]
				static Player()
				{
				}

				[Address(RVA="0x1E89CB4", Offset="0x1E89CB4", VA="0x1E89CB4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090AA4", Offset="0x1090AA4")]
				public Player()
				{
				}

				[Address(RVA="0x1E89D9C", Offset="0x1E89D9C", VA="0x1E89D9C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090AB4", Offset="0x1090AB4")]
				public Player(BattleLib_Bootstrap.Types.Player other)
				{
				}

				[Address(RVA="0x1E8A7D4", Offset="0x1E8A7D4", VA="0x1E8A7D4", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090B24", Offset="0x1090B24")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x1E89EF4", Offset="0x1E89EF4", VA="0x1E89EF4", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090AC4", Offset="0x1090AC4")]
				public BattleLib_Bootstrap.Types.Player Clone()
				{
					return null;
				}

				[Address(RVA="0x1E89FDC", Offset="0x1E89FDC", VA="0x1E89FDC", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090AD4", Offset="0x1090AD4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x1E8A050", Offset="0x1E8A050", VA="0x1E8A050", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090AE4", Offset="0x1090AE4")]
				public bool Equals(BattleLib_Bootstrap.Types.Player other)
				{
					return new bool();
				}

				[Address(RVA="0x1E8A210", Offset="0x1E8A210", VA="0x1E8A210", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090AF4", Offset="0x1090AF4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x1E8AA84", Offset="0x1E8AA84", VA="0x1E8AA84", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090B34", Offset="0x1090B34")]
				public void MergeFrom(BattleLib_Bootstrap.Types.Player other)
				{
				}

				[Address(RVA="0x1E8ABE0", Offset="0x1E8ABE0", VA="0x1E8ABE0", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090B44", Offset="0x1090B44")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x1E8A3AC", Offset="0x1E8A3AC", VA="0x1E8A3AC", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090B04", Offset="0x1090B04")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x1E8A414", Offset="0x1E8A414", VA="0x1E8A414", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090B14", Offset="0x1090B14")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051A44", Offset="0x1051A44")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_Bootstrap.Types.Player.<>c <>9;

					[Address(RVA="0x1E8B0AC", Offset="0x1E8B0AC", VA="0x1E8B0AC")]
					static <>c()
					{
					}

					[Address(RVA="0x1E8B110", Offset="0x1E8B110", VA="0x1E8B110")]
					public <>c()
					{
					}

					[Address(RVA="0x1E8B118", Offset="0x1E8B118", VA="0x1E8B118")]
					internal BattleLib_Bootstrap.Types.Player <.cctor>b__70_0()
					{
						return null;
					}
				}
			}

			public enum RemoteControl
			{
				[Attribute(Name="OriginalNameAttribute", RVA="0x106D860", Offset="0x106D860")]
				[FieldOffset(Offset="0x0")]
				Invalid,
				[Attribute(Name="OriginalNameAttribute", RVA="0x106D898", Offset="0x106D898")]
				[FieldOffset(Offset="0x0")]
				ClientReady,
				[Attribute(Name="OriginalNameAttribute", RVA="0x106D8D0", Offset="0x106D8D0")]
				[FieldOffset(Offset="0x0")]
				ServerFinishedProcessingResults,
				[Attribute(Name="OriginalNameAttribute", RVA="0x106D908", Offset="0x106D908")]
				[FieldOffset(Offset="0x0")]
				AllClientsReady,
				[Attribute(Name="OriginalNameAttribute", RVA="0x106D940", Offset="0x106D940")]
				[FieldOffset(Offset="0x0")]
				Emote,
				[Attribute(Name="OriginalNameAttribute", RVA="0x106D978", Offset="0x106D978")]
				[FieldOffset(Offset="0x0")]
				BattleSpeed
			}

			public sealed class SpawnPoint : IMessage<BattleLib_Bootstrap.Types.SpawnPoint>, IMessage, IEquatable<BattleLib_Bootstrap.Types.SpawnPoint>, IDeepCloneable<BattleLib_Bootstrap.Types.SpawnPoint>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_Bootstrap.Types.SpawnPoint> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int TeamIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint teamId_;

				[FieldOffset(Offset="0x0")]
				public const int UnitTypeFieldNumber = 2;

				[FieldOffset(Offset="0x1C")]
				private uint unitType_;

				[FieldOffset(Offset="0x0")]
				public const int XFieldNumber = 3;

				[FieldOffset(Offset="0x20")]
				private float x_;

				[FieldOffset(Offset="0x0")]
				public const int YFieldNumber = 4;

				[FieldOffset(Offset="0x24")]
				private float y_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E318", Offset="0x109E318")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x1E8B170", Offset="0x1E8B170", VA="0x1E8B170")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E308", Offset="0x109E308")]
				public static MessageParser<BattleLib_Bootstrap.Types.SpawnPoint> Parser
				{
					[Address(RVA="0x1E81E58", Offset="0x1E81E58", VA="0x1E81E58")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E328", Offset="0x109E328")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x1E8B25C", Offset="0x1E8B25C", VA="0x1E8B25C", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E338", Offset="0x109E338")]
				public uint TeamId
				{
					[Address(RVA="0x1E8B3D8", Offset="0x1E8B3D8", VA="0x1E8B3D8")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E8B3E0", Offset="0x1E8B3E0", VA="0x1E8B3E0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E348", Offset="0x109E348")]
				public uint UnitType
				{
					[Address(RVA="0x1E8B3E8", Offset="0x1E8B3E8", VA="0x1E8B3E8")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E8B3F0", Offset="0x1E8B3F0", VA="0x1E8B3F0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E358", Offset="0x109E358")]
				public float X
				{
					[Address(RVA="0x1E8B3F8", Offset="0x1E8B3F8", VA="0x1E8B3F8")]
					get
					{
						return new float();
					}
					[Address(RVA="0x1E8B400", Offset="0x1E8B400", VA="0x1E8B400")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E368", Offset="0x109E368")]
				public float Y
				{
					[Address(RVA="0x1E8B408", Offset="0x1E8B408", VA="0x1E8B408")]
					get
					{
						return new float();
					}
					[Address(RVA="0x1E8B410", Offset="0x1E8B410", VA="0x1E8B410")]
					set
					{
					}
				}

				[Address(RVA="0x1E8BBD4", Offset="0x1E8BBD4", VA="0x1E8BBD4")]
				static SpawnPoint()
				{
				}

				[Address(RVA="0x1E8B2B8", Offset="0x1E8B2B8", VA="0x1E8B2B8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10905D4", Offset="0x10905D4")]
				public SpawnPoint()
				{
				}

				[Address(RVA="0x1E8B2C0", Offset="0x1E8B2C0", VA="0x1E8B2C0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10905E4", Offset="0x10905E4")]
				public SpawnPoint(BattleLib_Bootstrap.Types.SpawnPoint other)
				{
				}

				[Address(RVA="0x1E8B974", Offset="0x1E8B974", VA="0x1E8B974", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090654", Offset="0x1090654")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x1E8B378", Offset="0x1E8B378", VA="0x1E8B378", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10905F4", Offset="0x10905F4")]
				public BattleLib_Bootstrap.Types.SpawnPoint Clone()
				{
					return null;
				}

				[Address(RVA="0x1E8B418", Offset="0x1E8B418", VA="0x1E8B418", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090604", Offset="0x1090604")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x1E8B48C", Offset="0x1E8B48C", VA="0x1E8B48C", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090614", Offset="0x1090614")]
				public bool Equals(BattleLib_Bootstrap.Types.SpawnPoint other)
				{
					return new bool();
				}

				[Address(RVA="0x1E8B5E0", Offset="0x1E8B5E0", VA="0x1E8B5E0", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090624", Offset="0x1090624")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x1E8BA6C", Offset="0x1E8BA6C", VA="0x1E8BA6C", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090664", Offset="0x1090664")]
				public void MergeFrom(BattleLib_Bootstrap.Types.SpawnPoint other)
				{
				}

				[Address(RVA="0x1E8BAD8", Offset="0x1E8BAD8", VA="0x1E8BAD8", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090674", Offset="0x1090674")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x1E8B750", Offset="0x1E8B750", VA="0x1E8B750", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090634", Offset="0x1090634")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x1E8B7B8", Offset="0x1E8B7B8", VA="0x1E8B7B8", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090644", Offset="0x1090644")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10519D4", Offset="0x10519D4")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_Bootstrap.Types.SpawnPoint.<>c <>9;

					[Address(RVA="0x1E8BCAC", Offset="0x1E8BCAC", VA="0x1E8BCAC")]
					static <>c()
					{
					}

					[Address(RVA="0x1E8BD10", Offset="0x1E8BD10", VA="0x1E8BD10")]
					public <>c()
					{
					}

					[Address(RVA="0x1E8BD18", Offset="0x1E8BD18", VA="0x1E8BD18")]
					internal BattleLib_Bootstrap.Types.SpawnPoint <.cctor>b__40_0()
					{
						return null;
					}
				}
			}

			public sealed class Spell : IMessage<BattleLib_Bootstrap.Types.Spell>, IMessage, IEquatable<BattleLib_Bootstrap.Types.Spell>, IDeepCloneable<BattleLib_Bootstrap.Types.Spell>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_Bootstrap.Types.Spell> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int DefinitionIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private ulong definitionId_;

				[FieldOffset(Offset="0x0")]
				public const int EffectDefIdsFieldNumber = 2;

				[FieldOffset(Offset="0x8")]
				private readonly static FieldCodec<ulong> _repeated_effectDefIds_codec;

				[FieldOffset(Offset="0x20")]
				private readonly RepeatedField<ulong> effectDefIds_;

				[FieldOffset(Offset="0x0")]
				public const int AbilityFieldNumber = 3;

				[FieldOffset(Offset="0x28")]
				private BattleLib_Bootstrap.Types.Ability ability_;

				[FieldOffset(Offset="0x0")]
				public const int PowerRatingFieldNumber = 4;

				[FieldOffset(Offset="0x30")]
				private uint powerRating_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E898", Offset="0x109E898")]
				public BattleLib_Bootstrap.Types.Ability Ability
				{
					[Address(RVA="0x1E8BFFC", Offset="0x1E8BFFC", VA="0x1E8BFFC")]
					get
					{
						return null;
					}
					[Address(RVA="0x1E8C004", Offset="0x1E8C004", VA="0x1E8C004")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E878", Offset="0x109E878")]
				public ulong DefinitionId
				{
					[Address(RVA="0x1E8C06C", Offset="0x1E8C06C", VA="0x1E8C06C")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x1E8C074", Offset="0x1E8C074", VA="0x1E8C074")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E858", Offset="0x109E858")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x1E8BD74", Offset="0x1E8BD74", VA="0x1E8BD74")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E888", Offset="0x109E888")]
				public RepeatedField<ulong> EffectDefIds
				{
					[Address(RVA="0x1E8C07C", Offset="0x1E8C07C", VA="0x1E8C07C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E848", Offset="0x109E848")]
				public static MessageParser<BattleLib_Bootstrap.Types.Spell> Parser
				{
					[Address(RVA="0x1E81F90", Offset="0x1E81F90", VA="0x1E81F90")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E868", Offset="0x109E868")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x1E8BE60", Offset="0x1E8BE60", VA="0x1E8BE60", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E8A8", Offset="0x109E8A8")]
				public uint PowerRating
				{
					[Address(RVA="0x1E8C084", Offset="0x1E8C084", VA="0x1E8C084")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x1E8C08C", Offset="0x1E8C08C", VA="0x1E8C08C")]
					set
					{
					}
				}

				[Address(RVA="0x1E8C8EC", Offset="0x1E8C8EC", VA="0x1E8C8EC")]
				static Spell()
				{
				}

				[Address(RVA="0x1E8BEBC", Offset="0x1E8BEBC", VA="0x1E8BEBC")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090944", Offset="0x1090944")]
				public Spell()
				{
				}

				[Address(RVA="0x1E8BF2C", Offset="0x1E8BF2C", VA="0x1E8BF2C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090954", Offset="0x1090954")]
				public Spell(BattleLib_Bootstrap.Types.Spell other)
				{
				}

				[Address(RVA="0x1E8C4EC", Offset="0x1E8C4EC", VA="0x1E8C4EC", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10909C4", Offset="0x10909C4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x1E8C00C", Offset="0x1E8C00C", VA="0x1E8C00C", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090964", Offset="0x1090964")]
				public BattleLib_Bootstrap.Types.Spell Clone()
				{
					return null;
				}

				[Address(RVA="0x1E8C094", Offset="0x1E8C094", VA="0x1E8C094", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090974", Offset="0x1090974")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x1E8C108", Offset="0x1E8C108", VA="0x1E8C108", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090984", Offset="0x1090984")]
				public bool Equals(BattleLib_Bootstrap.Types.Spell other)
				{
					return new bool();
				}

				[Address(RVA="0x1E8C1EC", Offset="0x1E8C1EC", VA="0x1E8C1EC", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090994", Offset="0x1090994")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x1E8C65C", Offset="0x1E8C65C", VA="0x1E8C65C", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10909D4", Offset="0x10909D4")]
				public void MergeFrom(BattleLib_Bootstrap.Types.Spell other)
				{
				}

				[Address(RVA="0x1E8C74C", Offset="0x1E8C74C", VA="0x1E8C74C", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10909E4", Offset="0x10909E4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x1E8C2B8", Offset="0x1E8C2B8", VA="0x1E8C2B8", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10909A4", Offset="0x10909A4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x1E8C320", Offset="0x1E8C320", VA="0x1E8C320", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10909B4", Offset="0x10909B4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051A24", Offset="0x1051A24")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_Bootstrap.Types.Spell.<>c <>9;

					[Address(RVA="0x179B398", Offset="0x179B398", VA="0x179B398")]
					static <>c()
					{
					}

					[Address(RVA="0x179B3FC", Offset="0x179B3FC", VA="0x179B3FC")]
					public <>c()
					{
					}

					[Address(RVA="0x179B404", Offset="0x179B404", VA="0x179B404")]
					internal BattleLib_Bootstrap.Types.Spell <.cctor>b__40_0()
					{
						return null;
					}
				}
			}

			public sealed class Squad : IMessage<BattleLib_Bootstrap.Types.Squad>, IMessage, IEquatable<BattleLib_Bootstrap.Types.Squad>, IDeepCloneable<BattleLib_Bootstrap.Types.Squad>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_Bootstrap.Types.Squad> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int UnitsFieldNumber = 1;

				[FieldOffset(Offset="0x8")]
				private readonly static FieldCodec<BattleLib_Bootstrap.Types.Unit> _repeated_units_codec;

				[FieldOffset(Offset="0x18")]
				private readonly RepeatedField<BattleLib_Bootstrap.Types.Unit> units_;

				[FieldOffset(Offset="0x0")]
				public const int EncounterFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private string encounter_;

				[FieldOffset(Offset="0x0")]
				public const int SpawnOrderFieldNumber = 3;

				[FieldOffset(Offset="0x10")]
				private readonly static FieldCodec<uint> _repeated_spawnOrder_codec;

				[FieldOffset(Offset="0x28")]
				private readonly RepeatedField<uint> spawnOrder_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E8C8", Offset="0x109E8C8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x179B4C8", Offset="0x179B4C8", VA="0x179B4C8")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E8F8", Offset="0x109E8F8")]
				public string Encounter
				{
					[Address(RVA="0x179B7EC", Offset="0x179B7EC", VA="0x179B7EC")]
					get
					{
						return null;
					}
					[Address(RVA="0x179B7F4", Offset="0x179B7F4", VA="0x179B7F4")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E8B8", Offset="0x109E8B8")]
				public static MessageParser<BattleLib_Bootstrap.Types.Squad> Parser
				{
					[Address(RVA="0x179B460", Offset="0x179B460", VA="0x179B460")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E8D8", Offset="0x109E8D8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x179B5B8", Offset="0x179B5B8", VA="0x179B5B8", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E908", Offset="0x109E908")]
				public RepeatedField<uint> SpawnOrder
				{
					[Address(RVA="0x179B864", Offset="0x179B864", VA="0x179B864")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E8E8", Offset="0x109E8E8")]
				public RepeatedField<BattleLib_Bootstrap.Types.Unit> Units
				{
					[Address(RVA="0x179B7E4", Offset="0x179B7E4", VA="0x179B7E4")]
					get
					{
						return null;
					}
				}

				[Address(RVA="0x179C070", Offset="0x179C070", VA="0x179C070")]
				static Squad()
				{
				}

				[Address(RVA="0x179B614", Offset="0x179B614", VA="0x179B614")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10909F4", Offset="0x10909F4")]
				public Squad()
				{
				}

				[Address(RVA="0x179B6BC", Offset="0x179B6BC", VA="0x179B6BC")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090A04", Offset="0x1090A04")]
				public Squad(BattleLib_Bootstrap.Types.Squad other)
				{
				}

				[Address(RVA="0x179BCA0", Offset="0x179BCA0", VA="0x179BCA0", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090A74", Offset="0x1090A74")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x179B784", Offset="0x179B784", VA="0x179B784", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090A14", Offset="0x1090A14")]
				public BattleLib_Bootstrap.Types.Squad Clone()
				{
					return null;
				}

				[Address(RVA="0x179B86C", Offset="0x179B86C", VA="0x179B86C", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090A24", Offset="0x1090A24")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x179B8E0", Offset="0x179B8E0", VA="0x179B8E0", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090A34", Offset="0x1090A34")]
				public bool Equals(BattleLib_Bootstrap.Types.Squad other)
				{
					return new bool();
				}

				[Address(RVA="0x179B9D4", Offset="0x179B9D4", VA="0x179B9D4", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090A44", Offset="0x1090A44")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x179BE04", Offset="0x179BE04", VA="0x179BE04", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090A84", Offset="0x1090A84")]
				public void MergeFrom(BattleLib_Bootstrap.Types.Squad other)
				{
				}

				[Address(RVA="0x179BEEC", Offset="0x179BEEC", VA="0x179BEEC", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090A94", Offset="0x1090A94")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x179BAA8", Offset="0x179BAA8", VA="0x179BAA8", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090A54", Offset="0x1090A54")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x179BB10", Offset="0x179BB10", VA="0x179BB10", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090A64", Offset="0x1090A64")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051A34", Offset="0x1051A34")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_Bootstrap.Types.Squad.<>c <>9;

					[Address(RVA="0x179C210", Offset="0x179C210", VA="0x179C210")]
					static <>c()
					{
					}

					[Address(RVA="0x179C274", Offset="0x179C274", VA="0x179C274")]
					public <>c()
					{
					}

					[Address(RVA="0x179C27C", Offset="0x179C27C", VA="0x179C27C")]
					internal BattleLib_Bootstrap.Types.Squad <.cctor>b__35_0()
					{
						return null;
					}
				}
			}

			public sealed class Unit : IMessage<BattleLib_Bootstrap.Types.Unit>, IMessage, IEquatable<BattleLib_Bootstrap.Types.Unit>, IDeepCloneable<BattleLib_Bootstrap.Types.Unit>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_Bootstrap.Types.Unit> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int DefinitionIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private ulong definitionId_;

				[FieldOffset(Offset="0x0")]
				public const int PersistentIdFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private uint persistentId_;

				[FieldOffset(Offset="0x0")]
				public const int RarityFieldNumber = 3;

				[FieldOffset(Offset="0x24")]
				private uint rarity_;

				[FieldOffset(Offset="0x0")]
				public const int LevelFieldNumber = 4;

				[FieldOffset(Offset="0x28")]
				private uint level_;

				[FieldOffset(Offset="0x0")]
				public const int GearSlotEquippedFieldNumber = 5;

				[FieldOffset(Offset="0x8")]
				private readonly static FieldCodec<bool> _repeated_gearSlotEquipped_codec;

				[FieldOffset(Offset="0x30")]
				private readonly RepeatedField<bool> gearSlotEquipped_;

				[FieldOffset(Offset="0x0")]
				public const int GearTierFieldNumber = 6;

				[FieldOffset(Offset="0x38")]
				private uint gearTier_;

				[FieldOffset(Offset="0x0")]
				public const int OffenseFieldNumber = 7;

				[FieldOffset(Offset="0x3C")]
				private uint offense_;

				[FieldOffset(Offset="0x0")]
				public const int DefenseFieldNumber = 8;

				[FieldOffset(Offset="0x40")]
				private uint defense_;

				[FieldOffset(Offset="0x0")]
				public const int HealthFieldNumber = 9;

				[FieldOffset(Offset="0x44")]
				private uint health_;

				[FieldOffset(Offset="0x0")]
				public const int RecoveryFieldNumber = 10;

				[FieldOffset(Offset="0x48")]
				private uint recovery_;

				[FieldOffset(Offset="0x0")]
				public const int CritChanceFieldNumber = 11;

				[FieldOffset(Offset="0x4C")]
				private float critChance_;

				[FieldOffset(Offset="0x0")]
				public const int CritPowerFieldNumber = 12;

				[FieldOffset(Offset="0x50")]
				private float critPower_;

				[FieldOffset(Offset="0x0")]
				public const int AttackSpeedFieldNumber = 13;

				[FieldOffset(Offset="0x54")]
				private float attackSpeed_;

				[FieldOffset(Offset="0x0")]
				public const int WalkSpeedFieldNumber = 14;

				[FieldOffset(Offset="0x58")]
				private float walkSpeed_;

				[FieldOffset(Offset="0x0")]
				public const int AttackRangeFieldNumber = 15;

				[FieldOffset(Offset="0x5C")]
				private float attackRange_;

				[FieldOffset(Offset="0x0")]
				public const int RadiusFieldNumber = 16;

				[FieldOffset(Offset="0x60")]
				private float radius_;

				[FieldOffset(Offset="0x0")]
				public const int NameKeyFieldNumber = 17;

				[FieldOffset(Offset="0x68")]
				private string nameKey_;

				[FieldOffset(Offset="0x0")]
				public const int AssetIdFieldNumber = 18;

				[FieldOffset(Offset="0x70")]
				private string assetId_;

				[FieldOffset(Offset="0x0")]
				public const int IconFieldNumber = 19;

				[FieldOffset(Offset="0x78")]
				private string icon_;

				[FieldOffset(Offset="0x0")]
				public const int EffectDefIdsFieldNumber = 20;

				[FieldOffset(Offset="0x10")]
				private readonly static FieldCodec<ulong> _repeated_effectDefIds_codec;

				[FieldOffset(Offset="0x80")]
				private readonly RepeatedField<ulong> effectDefIds_;

				[FieldOffset(Offset="0x0")]
				public const int AbilitiesFieldNumber = 21;

				[FieldOffset(Offset="0x18")]
				private readonly static FieldCodec<BattleLib_Bootstrap.Types.Ability> _repeated_abilities_codec;

				[FieldOffset(Offset="0x88")]
				private readonly RepeatedField<BattleLib_Bootstrap.Types.Ability> abilities_;

				[FieldOffset(Offset="0x0")]
				public const int UnitTypeFieldNumber = 22;

				[FieldOffset(Offset="0x90")]
				private uint unitType_;

				[FieldOffset(Offset="0x0")]
				public const int HealthPercentFieldNumber = 23;

				[FieldOffset(Offset="0x94")]
				private float healthPercent_;

				[FieldOffset(Offset="0x0")]
				public const int PowerRatingFieldNumber = 24;

				[FieldOffset(Offset="0x98")]
				private uint powerRating_;

				[FieldOffset(Offset="0x0")]
				public const int UnitSlotTypeFieldNumber = 25;

				[FieldOffset(Offset="0x9C")]
				private uint unitSlotType_;

				[FieldOffset(Offset="0x0")]
				public const int SubtitleKeyFieldNumber = 26;

				[FieldOffset(Offset="0xA0")]
				private string subtitleKey_;

				[FieldOffset(Offset="0x0")]
				public const int SkinItemIdFieldNumber = 27;

				[FieldOffset(Offset="0xA8")]
				private ulong skinItemId_;

				[FieldOffset(Offset="0x0")]
				public const int CategoryIdsFieldNumber = 28;

				[FieldOffset(Offset="0x20")]
				private readonly static FieldCodec<ulong> _repeated_categoryIds_codec;

				[FieldOffset(Offset="0xB0")]
				private readonly RepeatedField<ulong> categoryIds_;

				[FieldOffset(Offset="0x0")]
				public const int SorcererStoneIdFieldNumber = 29;

				[FieldOffset(Offset="0xB8")]
				private ulong sorcererStoneId_;

				[FieldOffset(Offset="0x0")]
				public const int SpeedFieldNumber = 30;

				[FieldOffset(Offset="0xC0")]
				private uint speed_;

				[FieldOffset(Offset="0x0")]
				public const int PotencyFieldNumber = 31;

				[FieldOffset(Offset="0xC4")]
				private float potency_;

				[FieldOffset(Offset="0x0")]
				public const int TenacityFieldNumber = 32;

				[FieldOffset(Offset="0xC8")]
				private float tenacity_;

				[FieldOffset(Offset="0x0")]
				public const int AccuracyFieldNumber = 33;

				[FieldOffset(Offset="0xCC")]
				private float accuracy_;

				[FieldOffset(Offset="0x0")]
				public const int EvasionFieldNumber = 34;

				[FieldOffset(Offset="0xD0")]
				private float evasion_;

				[FieldOffset(Offset="0x0")]
				public const int AltPrefabsFieldNumber = 35;

				[FieldOffset(Offset="0x28")]
				private readonly static FieldCodec<BattleLib_Bootstrap.Types.UnitAltPrefab> _repeated_altPrefabs_codec;

				[FieldOffset(Offset="0xD8")]
				private readonly RepeatedField<BattleLib_Bootstrap.Types.UnitAltPrefab> altPrefabs_;

				[FieldOffset(Offset="0x0")]
				public const int AffectsStarRatingFieldNumber = 36;

				[FieldOffset(Offset="0xE0")]
				private bool affectsStarRating_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E748", Offset="0x109E748")]
				public RepeatedField<BattleLib_Bootstrap.Types.Ability> Abilities
				{
					[Address(RVA="0x179CA90", Offset="0x179CA90", VA="0x179CA90")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E808", Offset="0x109E808")]
				public float Accuracy
				{
					[Address(RVA="0x179CBA8", Offset="0x179CBA8", VA="0x179CBA8")]
					get
					{
						return new float();
					}
					[Address(RVA="0x179CBB0", Offset="0x179CBB0", VA="0x179CBB0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E838", Offset="0x109E838")]
				public bool AffectsStarRating
				{
					[Address(RVA="0x179CBD0", Offset="0x179CBD0", VA="0x179CBD0")]
					get
					{
						return new bool();
					}
					[Address(RVA="0x179CBD8", Offset="0x179CBD8", VA="0x179CBD8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E828", Offset="0x109E828")]
				public RepeatedField<BattleLib_Bootstrap.Types.UnitAltPrefab> AltPrefabs
				{
					[Address(RVA="0x179CBC8", Offset="0x179CBC8", VA="0x179CBC8")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E718", Offset="0x109E718")]
				public string AssetId
				{
					[Address(RVA="0x179C998", Offset="0x179C998", VA="0x179C998")]
					get
					{
						return null;
					}
					[Address(RVA="0x179C9A0", Offset="0x179C9A0", VA="0x179C9A0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E6E8", Offset="0x109E6E8")]
				public float AttackRange
				{
					[Address(RVA="0x179C900", Offset="0x179C900", VA="0x179C900")]
					get
					{
						return new float();
					}
					[Address(RVA="0x179C908", Offset="0x179C908", VA="0x179C908")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E6C8", Offset="0x109E6C8")]
				public float AttackSpeed
				{
					[Address(RVA="0x179C8E0", Offset="0x179C8E0", VA="0x179C8E0")]
					get
					{
						return new float();
					}
					[Address(RVA="0x179C8E8", Offset="0x179C8E8", VA="0x179C8E8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E7B8", Offset="0x109E7B8")]
				public RepeatedField<ulong> CategoryIds
				{
					[Address(RVA="0x179CB60", Offset="0x179CB60", VA="0x179CB60")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E6A8", Offset="0x109E6A8")]
				public float CritChance
				{
					[Address(RVA="0x179C8C0", Offset="0x179C8C0", VA="0x179C8C0")]
					get
					{
						return new float();
					}
					[Address(RVA="0x179C8C8", Offset="0x179C8C8", VA="0x179C8C8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E6B8", Offset="0x109E6B8")]
				public float CritPower
				{
					[Address(RVA="0x179C8D0", Offset="0x179C8D0", VA="0x179C8D0")]
					get
					{
						return new float();
					}
					[Address(RVA="0x179C8D8", Offset="0x179C8D8", VA="0x179C8D8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E678", Offset="0x109E678")]
				public uint Defense
				{
					[Address(RVA="0x179C890", Offset="0x179C890", VA="0x179C890")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x179C898", Offset="0x179C898", VA="0x179C898")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E608", Offset="0x109E608")]
				public ulong DefinitionId
				{
					[Address(RVA="0x179C828", Offset="0x179C828", VA="0x179C828")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x179C830", Offset="0x179C830", VA="0x179C830")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E5E8", Offset="0x109E5E8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x179C2D4", Offset="0x179C2D4", VA="0x179C2D4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E738", Offset="0x109E738")]
				public RepeatedField<ulong> EffectDefIds
				{
					[Address(RVA="0x179CA88", Offset="0x179CA88", VA="0x179CA88")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E818", Offset="0x109E818")]
				public float Evasion
				{
					[Address(RVA="0x179CBB8", Offset="0x179CBB8", VA="0x179CBB8")]
					get
					{
						return new float();
					}
					[Address(RVA="0x179CBC0", Offset="0x179CBC0", VA="0x179CBC0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E648", Offset="0x109E648")]
				public RepeatedField<bool> GearSlotEquipped
				{
					[Address(RVA="0x179C868", Offset="0x179C868", VA="0x179C868")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E658", Offset="0x109E658")]
				public uint GearTier
				{
					[Address(RVA="0x179C870", Offset="0x179C870", VA="0x179C870")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x179C878", Offset="0x179C878", VA="0x179C878")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E688", Offset="0x109E688")]
				public uint Health
				{
					[Address(RVA="0x179C8A0", Offset="0x179C8A0", VA="0x179C8A0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x179C8A8", Offset="0x179C8A8", VA="0x179C8A8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E768", Offset="0x109E768")]
				public float HealthPercent
				{
					[Address(RVA="0x179CAA8", Offset="0x179CAA8", VA="0x179CAA8")]
					get
					{
						return new float();
					}
					[Address(RVA="0x179CAB0", Offset="0x179CAB0", VA="0x179CAB0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E728", Offset="0x109E728")]
				public string Icon
				{
					[Address(RVA="0x179CA10", Offset="0x179CA10", VA="0x179CA10")]
					get
					{
						return null;
					}
					[Address(RVA="0x179CA18", Offset="0x179CA18", VA="0x179CA18")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E638", Offset="0x109E638")]
				public uint Level
				{
					[Address(RVA="0x179C858", Offset="0x179C858", VA="0x179C858")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x179C860", Offset="0x179C860", VA="0x179C860")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E708", Offset="0x109E708")]
				public string NameKey
				{
					[Address(RVA="0x179C920", Offset="0x179C920", VA="0x179C920")]
					get
					{
						return null;
					}
					[Address(RVA="0x179C928", Offset="0x179C928", VA="0x179C928")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E668", Offset="0x109E668")]
				public uint Offense
				{
					[Address(RVA="0x179C880", Offset="0x179C880", VA="0x179C880")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x179C888", Offset="0x179C888", VA="0x179C888")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E5D8", Offset="0x109E5D8")]
				public static MessageParser<BattleLib_Bootstrap.Types.Unit> Parser
				{
					[Address(RVA="0x179C1A8", Offset="0x179C1A8", VA="0x179C1A8")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E5F8", Offset="0x109E5F8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x179C3C4", Offset="0x179C3C4", VA="0x179C3C4", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E618", Offset="0x109E618")]
				public uint PersistentId
				{
					[Address(RVA="0x179C838", Offset="0x179C838", VA="0x179C838")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x179C840", Offset="0x179C840", VA="0x179C840")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E7E8", Offset="0x109E7E8")]
				public float Potency
				{
					[Address(RVA="0x179CB88", Offset="0x179CB88", VA="0x179CB88")]
					get
					{
						return new float();
					}
					[Address(RVA="0x179CB90", Offset="0x179CB90", VA="0x179CB90")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E778", Offset="0x109E778")]
				public uint PowerRating
				{
					[Address(RVA="0x179CAB8", Offset="0x179CAB8", VA="0x179CAB8")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x179CAC0", Offset="0x179CAC0", VA="0x179CAC0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E6F8", Offset="0x109E6F8")]
				public float Radius
				{
					[Address(RVA="0x179C910", Offset="0x179C910", VA="0x179C910")]
					get
					{
						return new float();
					}
					[Address(RVA="0x179C918", Offset="0x179C918", VA="0x179C918")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E628", Offset="0x109E628")]
				public uint Rarity
				{
					[Address(RVA="0x179C848", Offset="0x179C848", VA="0x179C848")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x179C850", Offset="0x179C850", VA="0x179C850")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E698", Offset="0x109E698")]
				public uint Recovery
				{
					[Address(RVA="0x179C8B0", Offset="0x179C8B0", VA="0x179C8B0")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x179C8B8", Offset="0x179C8B8", VA="0x179C8B8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E7A8", Offset="0x109E7A8")]
				public ulong SkinItemId
				{
					[Address(RVA="0x179CB50", Offset="0x179CB50", VA="0x179CB50")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x179CB58", Offset="0x179CB58", VA="0x179CB58")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E7C8", Offset="0x109E7C8")]
				public ulong SorcererStoneId
				{
					[Address(RVA="0x179CB68", Offset="0x179CB68", VA="0x179CB68")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x179CB70", Offset="0x179CB70", VA="0x179CB70")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E7D8", Offset="0x109E7D8")]
				public uint Speed
				{
					[Address(RVA="0x179CB78", Offset="0x179CB78", VA="0x179CB78")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x179CB80", Offset="0x179CB80", VA="0x179CB80")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E798", Offset="0x109E798")]
				public string SubtitleKey
				{
					[Address(RVA="0x179CAD8", Offset="0x179CAD8", VA="0x179CAD8")]
					get
					{
						return null;
					}
					[Address(RVA="0x179CAE0", Offset="0x179CAE0", VA="0x179CAE0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E7F8", Offset="0x109E7F8")]
				public float Tenacity
				{
					[Address(RVA="0x179CB98", Offset="0x179CB98", VA="0x179CB98")]
					get
					{
						return new float();
					}
					[Address(RVA="0x179CBA0", Offset="0x179CBA0", VA="0x179CBA0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E788", Offset="0x109E788")]
				public uint UnitSlotType
				{
					[Address(RVA="0x179CAC8", Offset="0x179CAC8", VA="0x179CAC8")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x179CAD0", Offset="0x179CAD0", VA="0x179CAD0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E758", Offset="0x109E758")]
				public uint UnitType
				{
					[Address(RVA="0x179CA98", Offset="0x179CA98", VA="0x179CA98")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x179CAA0", Offset="0x179CAA0", VA="0x179CAA0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E6D8", Offset="0x109E6D8")]
				public float WalkSpeed
				{
					[Address(RVA="0x179C8F0", Offset="0x179C8F0", VA="0x179C8F0")]
					get
					{
						return new float();
					}
					[Address(RVA="0x179C8F8", Offset="0x179C8F8", VA="0x179C8F8")]
					set
					{
					}
				}

				[Address(RVA="0x179FB88", Offset="0x179FB88", VA="0x179FB88")]
				static Unit()
				{
				}

				[Address(RVA="0x179C420", Offset="0x179C420", VA="0x179C420")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090894", Offset="0x1090894")]
				public Unit()
				{
				}

				[Address(RVA="0x179C54C", Offset="0x179C54C", VA="0x179C54C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10908A4", Offset="0x10908A4")]
				public Unit(BattleLib_Bootstrap.Types.Unit other)
				{
				}

				[Address(RVA="0x179E8EC", Offset="0x179E8EC", VA="0x179E8EC", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090914", Offset="0x1090914")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x179C7C8", Offset="0x179C7C8", VA="0x179C7C8", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10908B4", Offset="0x10908B4")]
				public BattleLib_Bootstrap.Types.Unit Clone()
				{
					return null;
				}

				[Address(RVA="0x179CBE4", Offset="0x179CBE4", VA="0x179CBE4", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10908C4", Offset="0x10908C4")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x179CC58", Offset="0x179CC58", VA="0x179CC58", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10908D4", Offset="0x10908D4")]
				public bool Equals(BattleLib_Bootstrap.Types.Unit other)
				{
					return new bool();
				}

				[Address(RVA="0x179D2C4", Offset="0x179D2C4", VA="0x179D2C4", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10908E4", Offset="0x10908E4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x179F064", Offset="0x179F064", VA="0x179F064", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090924", Offset="0x1090924")]
				public void MergeFrom(BattleLib_Bootstrap.Types.Unit other)
				{
				}

				[Address(RVA="0x179F3C4", Offset="0x179F3C4", VA="0x179F3C4", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090934", Offset="0x1090934")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x179DAC8", Offset="0x179DAC8", VA="0x179DAC8", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10908F4", Offset="0x10908F4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x179DB30", Offset="0x179DB30", VA="0x179DB30", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090904", Offset="0x1090904")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051A14", Offset="0x1051A14")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_Bootstrap.Types.Unit.<>c <>9;

					[Address(RVA="0x179FDA4", Offset="0x179FDA4", VA="0x179FDA4")]
					static <>c()
					{
					}

					[Address(RVA="0x179FE08", Offset="0x179FE08", VA="0x179FE08")]
					public <>c()
					{
					}

					[Address(RVA="0x179FE10", Offset="0x179FE10", VA="0x179FE10")]
					internal BattleLib_Bootstrap.Types.Unit <.cctor>b__200_0()
					{
						return null;
					}
				}
			}

			public sealed class UnitAltPrefab : IMessage<BattleLib_Bootstrap.Types.UnitAltPrefab>, IMessage, IEquatable<BattleLib_Bootstrap.Types.UnitAltPrefab>, IDeepCloneable<BattleLib_Bootstrap.Types.UnitAltPrefab>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleLib_Bootstrap.Types.UnitAltPrefab> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int IdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private uint id_;

				[FieldOffset(Offset="0x0")]
				public const int AssetIdFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private string assetId_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E5C8", Offset="0x109E5C8")]
				public string AssetId
				{
					[Address(RVA="0x17A00F8", Offset="0x17A00F8", VA="0x17A00F8")]
					get
					{
						return null;
					}
					[Address(RVA="0x17A0100", Offset="0x17A0100", VA="0x17A0100")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E598", Offset="0x109E598")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x179FE68", Offset="0x179FE68", VA="0x179FE68")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E5B8", Offset="0x109E5B8")]
				public uint Id
				{
					[Address(RVA="0x17A00E8", Offset="0x17A00E8", VA="0x17A00E8")]
					get
					{
						return new uint();
					}
					[Address(RVA="0x17A00F0", Offset="0x17A00F0", VA="0x17A00F0")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E588", Offset="0x109E588")]
				public static MessageParser<BattleLib_Bootstrap.Types.UnitAltPrefab> Parser
				{
					[Address(RVA="0x179FD3C", Offset="0x179FD3C", VA="0x179FD3C")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E5A8", Offset="0x109E5A8")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x179FF58", Offset="0x179FF58", VA="0x179FF58", Slot="7")]
					get
					{
						return null;
					}
				}

				[Address(RVA="0x17A0690", Offset="0x17A0690", VA="0x17A0690")]
				static UnitAltPrefab()
				{
				}

				[Address(RVA="0x179FFB4", Offset="0x179FFB4", VA="0x179FFB4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10907E4", Offset="0x10907E4")]
				public UnitAltPrefab()
				{
				}

				[Address(RVA="0x17A000C", Offset="0x17A000C", VA="0x17A000C")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10907F4", Offset="0x10907F4")]
				public UnitAltPrefab(BattleLib_Bootstrap.Types.UnitAltPrefab other)
				{
				}

				[Address(RVA="0x17A047C", Offset="0x17A047C", VA="0x17A047C", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090864", Offset="0x1090864")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x17A0088", Offset="0x17A0088", VA="0x17A0088", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090804", Offset="0x1090804")]
				public BattleLib_Bootstrap.Types.UnitAltPrefab Clone()
				{
					return null;
				}

				[Address(RVA="0x17A0170", Offset="0x17A0170", VA="0x17A0170", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090814", Offset="0x1090814")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x17A01E4", Offset="0x17A01E4", VA="0x17A01E4", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090824", Offset="0x1090824")]
				public bool Equals(BattleLib_Bootstrap.Types.UnitAltPrefab other)
				{
					return new bool();
				}

				[Address(RVA="0x17A0258", Offset="0x17A0258", VA="0x17A0258", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090834", Offset="0x1090834")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x17A056C", Offset="0x17A056C", VA="0x17A056C", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090874", Offset="0x1090874")]
				public void MergeFrom(BattleLib_Bootstrap.Types.UnitAltPrefab other)
				{
				}

				[Address(RVA="0x17A05E4", Offset="0x17A05E4", VA="0x17A05E4", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090884", Offset="0x1090884")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x17A0304", Offset="0x17A0304", VA="0x17A0304", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090844", Offset="0x1090844")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x17A036C", Offset="0x17A036C", VA="0x17A036C", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090854", Offset="0x1090854")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051A04", Offset="0x1051A04")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleLib_Bootstrap.Types.UnitAltPrefab.<>c <>9;

					[Address(RVA="0x17A0768", Offset="0x17A0768", VA="0x17A0768")]
					static <>c()
					{
					}

					[Address(RVA="0x17A07CC", Offset="0x17A07CC", VA="0x17A07CC")]
					public <>c()
					{
					}

					[Address(RVA="0x17A07D4", Offset="0x17A07D4", VA="0x17A07D4")]
					internal BattleLib_Bootstrap.Types.UnitAltPrefab <.cctor>b__30_0()
					{
						return null;
					}
				}
			}
		}
	}
}