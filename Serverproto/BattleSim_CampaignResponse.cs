using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleSim_CampaignResponse : IMessage<BattleSim_CampaignResponse>, IMessage, IEquatable<BattleSim_CampaignResponse>, IDeepCloneable<BattleSim_CampaignResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleSim_CampaignResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int MapsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<BattleSim_CampaignResponse.Types.Map> _repeated_maps_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<BattleSim_CampaignResponse.Types.Map> maps_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093B40", Offset="0x1093B40")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1DD067C", Offset="0x1DD067C", VA="0x1DD067C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093B60", Offset="0x1093B60")]
		public RepeatedField<BattleSim_CampaignResponse.Types.Map> Maps
		{
			[Address(RVA="0x1DD092C", Offset="0x1DD092C", VA="0x1DD092C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093B30", Offset="0x1093B30")]
		public static MessageParser<BattleSim_CampaignResponse> Parser
		{
			[Address(RVA="0x1DCF164", Offset="0x1DCF164", VA="0x1DCF164")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093B50", Offset="0x1093B50")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1DD0768", Offset="0x1DD0768", VA="0x1DD0768", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1DD0E14", Offset="0x1DD0E14", VA="0x1DD0E14")]
		static BattleSim_CampaignResponse()
		{
		}

		[Address(RVA="0x1DD07C4", Offset="0x1DD07C4", VA="0x1DD07C4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078F1C", Offset="0x1078F1C")]
		public BattleSim_CampaignResponse()
		{
		}

		[Address(RVA="0x1DD0834", Offset="0x1DD0834", VA="0x1DD0834")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078F2C", Offset="0x1078F2C")]
		public BattleSim_CampaignResponse(BattleSim_CampaignResponse other)
		{
		}

		[Address(RVA="0x1DD0BE4", Offset="0x1DD0BE4", VA="0x1DD0BE4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078F9C", Offset="0x1078F9C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1DD08CC", Offset="0x1DD08CC", VA="0x1DD08CC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078F3C", Offset="0x1078F3C")]
		public BattleSim_CampaignResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1DD0934", Offset="0x1DD0934", VA="0x1DD0934", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078F4C", Offset="0x1078F4C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD09A8", Offset="0x1DD09A8", VA="0x1DD09A8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078F5C", Offset="0x1078F5C")]
		public bool Equals(BattleSim_CampaignResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1DD0A58", Offset="0x1DD0A58", VA="0x1DD0A58", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078F6C", Offset="0x1078F6C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1DD0CA0", Offset="0x1DD0CA0", VA="0x1DD0CA0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078FAC", Offset="0x1078FAC")]
		public void MergeFrom(BattleSim_CampaignResponse other)
		{
		}

		[Address(RVA="0x1DD0D30", Offset="0x1DD0D30", VA="0x1DD0D30", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078FBC", Offset="0x1078FBC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1DD0AB8", Offset="0x1DD0AB8", VA="0x1DD0AB8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078F7C", Offset="0x1078F7C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1DD0B20", Offset="0x1DD0B20", VA="0x1DD0B20", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1078F8C", Offset="0x1078F8C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F448", Offset="0x104F448")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleSim_CampaignResponse.<>c <>9;

			[Address(RVA="0x1DD0F34", Offset="0x1DD0F34", VA="0x1DD0F34")]
			static <>c()
			{
			}

			[Address(RVA="0x1DD0F98", Offset="0x1DD0F98", VA="0x1DD0F98")]
			public <>c()
			{
			}

			[Address(RVA="0x1DD0FA0", Offset="0x1DD0FA0", VA="0x1DD0FA0")]
			internal BattleSim_CampaignResponse <.cctor>b__26_0()
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x104F438", Offset="0x104F438")]
		public static class Types
		{
			public sealed class Map : IMessage<BattleSim_CampaignResponse.Types.Map>, IMessage, IEquatable<BattleSim_CampaignResponse.Types.Map>, IDeepCloneable<BattleSim_CampaignResponse.Types.Map>
			{
				[FieldOffset(Offset="0x0")]
				private readonly static MessageParser<BattleSim_CampaignResponse.Types.Map> _parser;

				[FieldOffset(Offset="0x10")]
				private UnknownFieldSet _unknownFields;

				[FieldOffset(Offset="0x0")]
				public const int NumNodesFieldNumber = 1;

				[FieldOffset(Offset="0x18")]
				private ulong numNodes_;

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E9F8", Offset="0x109E9F8")]
				public static MessageDescriptor Descriptor
				{
					[Address(RVA="0x1DD0FF8", Offset="0x1DD0FF8", VA="0x1DD0FF8")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109EA18", Offset="0x109EA18")]
				public ulong NumNodes
				{
					[Address(RVA="0x1DD120C", Offset="0x1DD120C", VA="0x1DD120C")]
					get
					{
						return new ulong();
					}
					[Address(RVA="0x1DD1214", Offset="0x1DD1214", VA="0x1DD1214")]
					set
					{
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109E9E8", Offset="0x109E9E8")]
				public static MessageParser<BattleSim_CampaignResponse.Types.Map> Parser
				{
					[Address(RVA="0x1DCF1CC", Offset="0x1DCF1CC", VA="0x1DCF1CC")]
					get
					{
						return null;
					}
				}

				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109EA08", Offset="0x109EA08")]
				private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
				{
					[Address(RVA="0x1DD10E4", Offset="0x1DD10E4", VA="0x1DD10E4", Slot="7")]
					get
					{
						return null;
					}
				}

				[Address(RVA="0x1DD1588", Offset="0x1DD1588", VA="0x1DD1588")]
				static Map()
				{
				}

				[Address(RVA="0x1DD1140", Offset="0x1DD1140", VA="0x1DD1140")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090B54", Offset="0x1090B54")]
				public Map()
				{
				}

				[Address(RVA="0x1DD1148", Offset="0x1DD1148", VA="0x1DD1148")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090B64", Offset="0x1090B64")]
				public Map(BattleSim_CampaignResponse.Types.Map other)
				{
				}

				[Address(RVA="0x1DD143C", Offset="0x1DD143C", VA="0x1DD143C", Slot="6")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090BD4", Offset="0x1090BD4")]
				public int CalculateSize()
				{
					return new int();
				}

				[Address(RVA="0x1DD11AC", Offset="0x1DD11AC", VA="0x1DD11AC", Slot="9")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090B74", Offset="0x1090B74")]
				public BattleSim_CampaignResponse.Types.Map Clone()
				{
					return null;
				}

				[Address(RVA="0x1DD121C", Offset="0x1DD121C", VA="0x1DD121C", Slot="0")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090B84", Offset="0x1090B84")]
				public override bool Equals(object other)
				{
					return new bool();
				}

				[Address(RVA="0x1DD1290", Offset="0x1DD1290", VA="0x1DD1290", Slot="8")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090B94", Offset="0x1090B94")]
				public bool Equals(BattleSim_CampaignResponse.Types.Map other)
				{
					return new bool();
				}

				[Address(RVA="0x1DD12CC", Offset="0x1DD12CC", VA="0x1DD12CC", Slot="2")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090BA4", Offset="0x1090BA4")]
				public override int GetHashCode()
				{
					return new int();
				}

				[Address(RVA="0x1DD14CC", Offset="0x1DD14CC", VA="0x1DD14CC", Slot="10")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090BE4", Offset="0x1090BE4")]
				public void MergeFrom(BattleSim_CampaignResponse.Types.Map other)
				{
				}

				[Address(RVA="0x1DD150C", Offset="0x1DD150C", VA="0x1DD150C", Slot="4")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090BF4", Offset="0x1090BF4")]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Address(RVA="0x1DD1334", Offset="0x1DD1334", VA="0x1DD1334", Slot="3")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090BB4", Offset="0x1090BB4")]
				public override string ToString()
				{
					return null;
				}

				[Address(RVA="0x1DD139C", Offset="0x1DD139C", VA="0x1DD139C", Slot="5")]
				[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1090BC4", Offset="0x1090BC4")]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051A54", Offset="0x1051A54")]
				[Serializable]
				private sealed class <>c
				{
					[FieldOffset(Offset="0x0")]
					public readonly static BattleSim_CampaignResponse.Types.Map.<>c <>9;

					[Address(RVA="0x1DD1660", Offset="0x1DD1660", VA="0x1DD1660")]
					static <>c()
					{
					}

					[Address(RVA="0x1DD16C4", Offset="0x1DD16C4", VA="0x1DD16C4")]
					public <>c()
					{
					}

					[Address(RVA="0x1DD16CC", Offset="0x1DD16CC", VA="0x1DD16CC")]
					internal BattleSim_CampaignResponse.Types.Map <.cctor>b__25_0()
					{
						return null;
					}
				}
			}
		}
	}
}