using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWar : IMessage<ClubWar>, IMessage, IEquatable<ClubWar>, IDeepCloneable<ClubWar>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWar> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DefinitionIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong definitionId_;

		[FieldOffset(Offset="0x0")]
		public const int PhaseFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong phase_;

		[FieldOffset(Offset="0x0")]
		public const int ClubsFieldNumber = 3;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubWarClub> _repeated_clubs_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<ClubWarClub> clubs_;

		[FieldOffset(Offset="0x0")]
		public const int NodesFieldNumber = 4;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ClubWar.Types.NodeSummary> _repeated_nodes_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<ClubWar.Types.NodeSummary> nodes_;

		[FieldOffset(Offset="0x0")]
		public const int RegisteredPlayerIdsFieldNumber = 5;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<string> _repeated_registeredPlayerIds_codec;

		[FieldOffset(Offset="0x38")]
		private readonly RepeatedField<string> registeredPlayerIds_;

		[FieldOffset(Offset="0x0")]
		public const int NodeTargetFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private string nodeTarget_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerStateFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ClubWarPlayerState playerState_;

		[FieldOffset(Offset="0x0")]
		public const int PhaseEndTimeFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private ulong phaseEndTime_;

		[FieldOffset(Offset="0x0")]
		public const int WarStartTimeFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private ulong warStartTime_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095BF0", Offset="0x1095BF0")]
		public RepeatedField<ClubWarClub> Clubs
		{
			[Address(RVA="0x1B17E98", Offset="0x1B17E98", VA="0x1B17E98")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095BD0", Offset="0x1095BD0")]
		public ulong DefinitionId
		{
			[Address(RVA="0x1B17E78", Offset="0x1B17E78", VA="0x1B17E78")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B17E80", Offset="0x1B17E80", VA="0x1B17E80")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095BB0", Offset="0x1095BB0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B17A40", Offset="0x1B17A40", VA="0x1B17A40")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095C00", Offset="0x1095C00")]
		public RepeatedField<ClubWar.Types.NodeSummary> Nodes
		{
			[Address(RVA="0x1B17EA0", Offset="0x1B17EA0", VA="0x1B17EA0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095C20", Offset="0x1095C20")]
		public string NodeTarget
		{
			[Address(RVA="0x1B17EB0", Offset="0x1B17EB0", VA="0x1B17EB0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B17EB8", Offset="0x1B17EB8", VA="0x1B17EB8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095BA0", Offset="0x1095BA0")]
		public static MessageParser<ClubWar> Parser
		{
			[Address(RVA="0x1B179D8", Offset="0x1B179D8", VA="0x1B179D8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095BC0", Offset="0x1095BC0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B17B30", Offset="0x1B17B30", VA="0x1B17B30", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095BE0", Offset="0x1095BE0")]
		public ulong Phase
		{
			[Address(RVA="0x1B17E88", Offset="0x1B17E88", VA="0x1B17E88")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B17E90", Offset="0x1B17E90", VA="0x1B17E90")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095C40", Offset="0x1095C40")]
		public ulong PhaseEndTime
		{
			[Address(RVA="0x1B17F28", Offset="0x1B17F28", VA="0x1B17F28")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B17F30", Offset="0x1B17F30", VA="0x1B17F30")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095C30", Offset="0x1095C30")]
		public ClubWarPlayerState PlayerState
		{
			[Address(RVA="0x1B17DA8", Offset="0x1B17DA8", VA="0x1B17DA8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B17E10", Offset="0x1B17E10", VA="0x1B17E10")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095C10", Offset="0x1095C10")]
		public RepeatedField<string> RegisteredPlayerIds
		{
			[Address(RVA="0x1B17EA8", Offset="0x1B17EA8", VA="0x1B17EA8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1095C50", Offset="0x1095C50")]
		public ulong WarStartTime
		{
			[Address(RVA="0x1B17F38", Offset="0x1B17F38", VA="0x1B17F38")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B17F40", Offset="0x1B17F40", VA="0x1B17F40")]
			set
			{
			}
		}

		[Address(RVA="0x1B18EFC", Offset="0x1B18EFC", VA="0x1B18EFC")]
		static ClubWar()
		{
		}

		[Address(RVA="0x1B17B8C", Offset="0x1B17B8C", VA="0x1B17B8C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D38C", Offset="0x107D38C")]
		public ClubWar()
		{
		}

		[Address(RVA="0x1B17C5C", Offset="0x1B17C5C", VA="0x1B17C5C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D39C", Offset="0x107D39C")]
		public ClubWar(ClubWar other)
		{
		}

		[Address(RVA="0x1B1869C", Offset="0x1B1869C", VA="0x1B1869C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D40C", Offset="0x107D40C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B17E18", Offset="0x1B17E18", VA="0x1B17E18", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D3AC", Offset="0x107D3AC")]
		public ClubWar Clone()
		{
			return null;
		}

		[Address(RVA="0x1B17F48", Offset="0x1B17F48", VA="0x1B17F48", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D3BC", Offset="0x107D3BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B17FBC", Offset="0x1B17FBC", VA="0x1B17FBC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D3CC", Offset="0x107D3CC")]
		public bool Equals(ClubWar other)
		{
			return new bool();
		}

		[Address(RVA="0x1B18134", Offset="0x1B18134", VA="0x1B18134", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D3DC", Offset="0x107D3DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B18960", Offset="0x1B18960", VA="0x1B18960", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D41C", Offset="0x107D41C")]
		public void MergeFrom(ClubWar other)
		{
		}

		[Address(RVA="0x1B18C38", Offset="0x1B18C38", VA="0x1B18C38", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D42C", Offset="0x107D42C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B182CC", Offset="0x1B182CC", VA="0x1B182CC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D3EC", Offset="0x107D3EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B18334", Offset="0x1B18334", VA="0x1B18334", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107D3FC", Offset="0x107D3FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FA88", Offset="0x104FA88")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWar.<>c <>9;

			[Address(RVA="0x1B1914C", Offset="0x1B1914C", VA="0x1B1914C")]
			static <>c()
			{
			}

			[Address(RVA="0x1B191B0", Offset="0x1B191B0", VA="0x1B191B0")]
			public <>c()
			{
			}

			[Address(RVA="0x1B191B8", Offset="0x1B191B8", VA="0x1B191B8")]
			internal ClubWar <.cctor>b__66_0()
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x104FA78", Offset="0x104FA78")]
		public static class Types
		{
			public sealed class NodeSummary : IMessage<ClubWar.Types.NodeSummary>, IMessage, IEquatable<ClubWar.Types.NodeSummary>, IDeepCloneable<ClubWar.Types.NodeSummary>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<ClubWar.Types.NodeSummary> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int GdNodeIdFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private string gdNodeId_;

				[FieldOffset(Offset="0x0")]
				public const int OwnerTeamIdFieldNumber = 2;

				[FieldOffset(Offset="0x20")]
				private ulong ownerTeamId_;

				[FieldOffset(Offset="0x0")]
				public const int NumDefendersFieldNumber = 3;

				[FieldOffset(Offset="0x28")]
				private ulong numDefenders_;

				[FieldOffset(Offset="0x0")]
				public const int NumDefendersDefeatedFieldNumber = 4;

				[FieldOffset(Offset="0x30")]
				private ulong numDefendersDefeated_;

				[FieldOffset(Offset="0x0")]
				public const int RebuildFinishTimeFieldNumber = 5;

				[FieldOffset(Offset="0x38")]
				private ulong rebuildFinishTime_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109EA38", Offset="0x109EA38")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x1B19210", Offset="0x1B19210", VA="0x1B19210")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109EA58", Offset="0x109EA58")]
				public string GdNodeId
				{
					[Address(RVA="0x1B194E0", Offset="0x1B194E0", VA="0x1B194E0")]
					get
					{
						return null;
					}
					[Address(RVA="0x1B194E8", Offset="0x1B194E8", VA="0x1B194E8")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109EA78", Offset="0x109EA78")]
				public ulong NumDefenders
				{
					[Address(RVA="0x1B19568", Offset="0x1B19568", VA="0x1B19568")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x1B19570", Offset="0x1B19570", VA="0x1B19570")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109EA88", Offset="0x109EA88")]
				public ulong NumDefendersDefeated
				{
					[Address(RVA="0x1B19578", Offset="0x1B19578", VA="0x1B19578")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x1B19580", Offset="0x1B19580", VA="0x1B19580")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109EA68", Offset="0x109EA68")]
				public ulong OwnerTeamId
				{
					[Address(RVA="0x1B19558", Offset="0x1B19558", VA="0x1B19558")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x1B19560", Offset="0x1B19560", VA="0x1B19560")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109EA28", Offset="0x109EA28")]
				public static MessageParser<ClubWar.Types.NodeSummary> Parser
				{
					[Address(RVA="0x1B190E4", Offset="0x1B190E4", VA="0x1B190E4")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109EA48", Offset="0x109EA48")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x1B192FC", Offset="0x1B192FC", VA="0x1B192FC", Slot="7")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109EA98", Offset="0x109EA98")]
				public ulong RebuildFinishTime
				{
					[Address(RVA="0x1B19588", Offset="0x1B19588", VA="0x1B19588")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x1B19590", Offset="0x1B19590", VA="0x1B19590")]
					set
					{
					}
				}

				[Address(RVA="0x1B19DA4", Offset="0x1B19DA4", VA="0x1B19DA4")]
				static NodeSummary()
				{
				}

				[Address(RVA="0x1B19358", Offset="0x1B19358", VA="0x1B19358")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090C04", Offset="0x1090C04")]
				public NodeSummary()
				{
				}

				[Address(RVA="0x1B193B0", Offset="0x1B193B0", VA="0x1B193B0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090C14", Offset="0x1090C14")]
				public NodeSummary(ClubWar.Types.NodeSummary other)
				{
				}

				[Address(RVA="0x1B19A30", Offset="0x1B19A30", VA="0x1B19A30", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090C84", Offset="0x1090C84")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x1B19480", Offset="0x1B19480", VA="0x1B19480", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090C24", Offset="0x1090C24")]
				public ClubWar.Types.NodeSummary Clone()
				{
					return null;
				}

				[Address(RVA="0x1B19598", Offset="0x1B19598", VA="0x1B19598", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090C34", Offset="0x1090C34")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x1B1960C", Offset="0x1B1960C", VA="0x1B1960C", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090C44", Offset="0x1090C44")]
				public bool Equals(ClubWar.Types.NodeSummary other)
				{
					return new bool();
				}

				[Address(RVA="0x1B196B0", Offset="0x1B196B0", VA="0x1B196B0", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090C54", Offset="0x1090C54")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x1B19BDC", Offset="0x1B19BDC", VA="0x1B19BDC", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090C94", Offset="0x1090C94")]
				public void MergeFrom(ClubWar.Types.NodeSummary other)
				{
				}

				[Address(RVA="0x1B19C78", Offset="0x1B19C78", VA="0x1B19C78", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090CA4", Offset="0x1090CA4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x1B197B0", Offset="0x1B197B0", VA="0x1B197B0", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090C64", Offset="0x1090C64")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x1B19818", Offset="0x1B19818", VA="0x1B19818", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090C74", Offset="0x1090C74")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051A64", Offset="0x1051A64")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static ClubWar.Types.NodeSummary.<>c <>9;

					[Address(RVA="0x1B19E7C", Offset="0x1B19E7C", VA="0x1B19E7C")]
					static <>c()
					{
					}

					[Address(RVA="0x1B19EE0", Offset="0x1B19EE0", VA="0x1B19EE0")]
					public <>c()
					{
					}

					[Address(RVA="0x1B19EE8", Offset="0x1B19EE8", VA="0x1B19EE8")]
					internal ClubWar.Types.NodeSummary <.cctor>b__45_0()
					{
						return null;
					}
				}
			}
		}
	}
}