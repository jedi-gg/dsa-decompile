using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ItemFindResponse : IMessage<ItemFindResponse>, IMessage, IEquatable<ItemFindResponse>, IDeepCloneable<ItemFindResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ItemFindResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CampaignsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<CampaignRewardsPreview> _repeated_campaigns_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<CampaignRewardsPreview> campaigns_;

		[FieldOffset(Offset="0x0")]
		public const int DailyEventsFieldNumber = 2;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<EventIdentifier> _repeated_dailyEvents_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<EventIdentifier> dailyEvents_;

		[FieldOffset(Offset="0x0")]
		public const int ScheduledEventsFieldNumber = 3;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<EventIdentifier> _repeated_scheduledEvents_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<EventIdentifier> scheduledEvents_;

		[FieldOffset(Offset="0x0")]
		public const int ShipmentLocationsFieldNumber = 4;

		[FieldOffset(Offset="0x20")]
		private readonly static FieldCodec<ulong> _repeated_shipmentLocations_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<ulong> shipmentLocations_;

		[FieldOffset(Offset="0x0")]
		public const int TowerFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private bool tower_;

		[FieldOffset(Offset="0x0")]
		public const int ClubDungeonFieldNumber = 6;

		[FieldOffset(Offset="0x39")]
		private bool clubDungeon_;

		[FieldOffset(Offset="0x0")]
		public const int ArenaFieldNumber = 7;

		[FieldOffset(Offset="0x3A")]
		private bool arena_;

		[FieldOffset(Offset="0x0")]
		public const int ActiveShipmentLocationsFieldNumber = 8;

		[FieldOffset(Offset="0x28")]
		private readonly static FieldCodec<ulong> _repeated_activeShipmentLocations_codec;

		[FieldOffset(Offset="0x40")]
		private readonly RepeatedField<ulong> activeShipmentLocations_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerActivityLocationsFieldNumber = 9;

		[FieldOffset(Offset="0x30")]
		private readonly static FieldCodec<PlayerActivityType> _repeated_playerActivityLocations_codec;

		[FieldOffset(Offset="0x48")]
		private readonly RepeatedField<PlayerActivityType> playerActivityLocations_;

		[FieldOffset(Offset="0x0")]
		public const int StoreFieldNumber = 10;

		[FieldOffset(Offset="0x50")]
		private bool store_;

		[FieldOffset(Offset="0x0")]
		public const int PassportSeasonLevelRewardsFieldNumber = 11;

		[FieldOffset(Offset="0x51")]
		private bool passportSeasonLevelRewards_;

		[FieldOffset(Offset="0x0")]
		public const int ShipmentDefIdsFieldNumber = 12;

		[FieldOffset(Offset="0x38")]
		private readonly static FieldCodec<ulong> _repeated_shipmentDefIds_codec;

		[FieldOffset(Offset="0x58")]
		private readonly RepeatedField<ulong> shipmentDefIds_;

		[FieldOffset(Offset="0x0")]
		public const int ActiveShipmentDefIdsFieldNumber = 13;

		[FieldOffset(Offset="0x40")]
		private readonly static FieldCodec<ulong> _repeated_activeShipmentDefIds_codec;

		[FieldOffset(Offset="0x60")]
		private readonly RepeatedField<ulong> activeShipmentDefIds_;

		[FieldOffset(Offset="0x0")]
		public const int KothFieldNumber = 14;

		[FieldOffset(Offset="0x68")]
		private bool koth_;

		[FieldOffset(Offset="0x0")]
		public const int ClubWarFieldNumber = 15;

		[FieldOffset(Offset="0x69")]
		private bool clubWar_;

		[FieldOffset(Offset="0x0")]
		public const int PvpPackFieldNumber = 16;

		[FieldOffset(Offset="0x6A")]
		private bool pvpPack_;

		[FieldOffset(Offset="0x0")]
		public const int PvpPackAssetFieldNumber = 17;

		[FieldOffset(Offset="0x70")]
		private string pvpPackAsset_;

		[FieldOffset(Offset="0x0")]
		public const int CampaignsWithMapRewardsFieldNumber = 18;

		[FieldOffset(Offset="0x48")]
		private readonly static FieldCodec<ulong> _repeated_campaignsWithMapRewards_codec;

		[FieldOffset(Offset="0x78")]
		private readonly RepeatedField<ulong> campaignsWithMapRewards_;

		[FieldOffset(Offset="0x0")]
		public const int ActiveShipmentsFieldNumber = 19;

		[FieldOffset(Offset="0x50")]
		private readonly static FieldCodec<ItemFindShipment> _repeated_activeShipments_codec;

		[FieldOffset(Offset="0x80")]
		private readonly RepeatedField<ItemFindShipment> activeShipments_;

		[FieldOffset(Offset="0x0")]
		public const int TowersFieldNumber = 20;

		[FieldOffset(Offset="0x58")]
		private readonly static FieldCodec<ItemFindTower> _repeated_towers_codec;

		[FieldOffset(Offset="0x88")]
		private readonly RepeatedField<ItemFindTower> towers_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098EB0", Offset="0x1098EB0")]
		public RepeatedField<ulong> ActiveShipmentDefIds
		{
			[Address(RVA="0x1A932AC", Offset="0x1A932AC", VA="0x1A932AC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098E38", Offset="0x1098E38")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1098E38", Offset="0x1098E38")]
		public RepeatedField<ulong> ActiveShipmentLocations
		{
			[Address(RVA="0x1A9326C", Offset="0x1A9326C", VA="0x1A9326C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098F10", Offset="0x1098F10")]
		public RepeatedField<ItemFindShipment> ActiveShipments
		{
			[Address(RVA="0x1A93370", Offset="0x1A93370", VA="0x1A93370")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098E28", Offset="0x1098E28")]
		public bool Arena
		{
			[Address(RVA="0x1A93258", Offset="0x1A93258", VA="0x1A93258")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A93260", Offset="0x1A93260", VA="0x1A93260")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098DA0", Offset="0x1098DA0")]
		public RepeatedField<CampaignRewardsPreview> Campaigns
		{
			[Address(RVA="0x1A93210", Offset="0x1A93210", VA="0x1A93210")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098F00", Offset="0x1098F00")]
		public RepeatedField<ulong> CampaignsWithMapRewards
		{
			[Address(RVA="0x1A93368", Offset="0x1A93368", VA="0x1A93368")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098E18", Offset="0x1098E18")]
		public bool ClubDungeon
		{
			[Address(RVA="0x1A93244", Offset="0x1A93244", VA="0x1A93244")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A9324C", Offset="0x1A9324C", VA="0x1A9324C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098ED0", Offset="0x1098ED0")]
		public bool ClubWar
		{
			[Address(RVA="0x1A932C8", Offset="0x1A932C8", VA="0x1A932C8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A932D0", Offset="0x1A932D0", VA="0x1A932D0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098DB0", Offset="0x1098DB0")]
		public RepeatedField<EventIdentifier> DailyEvents
		{
			[Address(RVA="0x1A93218", Offset="0x1A93218", VA="0x1A93218")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098D80", Offset="0x1098D80")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A92C58", Offset="0x1A92C58", VA="0x1A92C58")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098EC0", Offset="0x1098EC0")]
		public bool Koth
		{
			[Address(RVA="0x1A932B4", Offset="0x1A932B4", VA="0x1A932B4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A932BC", Offset="0x1A932BC", VA="0x1A932BC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098D70", Offset="0x1098D70")]
		public static MessageParser<ItemFindResponse> Parser
		{
			[Address(RVA="0x1A90684", Offset="0x1A90684", VA="0x1A90684")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098E90", Offset="0x1098E90")]
		public bool PassportSeasonLevelRewards
		{
			[Address(RVA="0x1A93290", Offset="0x1A93290", VA="0x1A93290")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A93298", Offset="0x1A93298", VA="0x1A93298")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098D90", Offset="0x1098D90")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A92D44", Offset="0x1A92D44", VA="0x1A92D44", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098E70", Offset="0x1098E70")]
		public RepeatedField<PlayerActivityType> PlayerActivityLocations
		{
			[Address(RVA="0x1A93274", Offset="0x1A93274", VA="0x1A93274")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098EE0", Offset="0x1098EE0")]
		public bool PvpPack
		{
			[Address(RVA="0x1A932DC", Offset="0x1A932DC", VA="0x1A932DC")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A932E4", Offset="0x1A932E4", VA="0x1A932E4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098EF0", Offset="0x1098EF0")]
		public string PvpPackAsset
		{
			[Address(RVA="0x1A932F0", Offset="0x1A932F0", VA="0x1A932F0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A932F8", Offset="0x1A932F8", VA="0x1A932F8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098DC0", Offset="0x1098DC0")]
		public RepeatedField<EventIdentifier> ScheduledEvents
		{
			[Address(RVA="0x1A93220", Offset="0x1A93220", VA="0x1A93220")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098EA0", Offset="0x1098EA0")]
		public RepeatedField<ulong> ShipmentDefIds
		{
			[Address(RVA="0x1A932A4", Offset="0x1A932A4", VA="0x1A932A4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098DD0", Offset="0x1098DD0")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1098DD0", Offset="0x1098DD0")]
		public RepeatedField<ulong> ShipmentLocations
		{
			[Address(RVA="0x1A93228", Offset="0x1A93228", VA="0x1A93228")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098E80", Offset="0x1098E80")]
		public bool Store
		{
			[Address(RVA="0x1A9327C", Offset="0x1A9327C", VA="0x1A9327C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A93284", Offset="0x1A93284", VA="0x1A93284")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098E08", Offset="0x1098E08")]
		public bool Tower
		{
			[Address(RVA="0x1A93230", Offset="0x1A93230", VA="0x1A93230")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A93238", Offset="0x1A93238", VA="0x1A93238")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098F20", Offset="0x1098F20")]
		public RepeatedField<ItemFindTower> Towers
		{
			[Address(RVA="0x1A93378", Offset="0x1A93378", VA="0x1A93378")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A94E0C", Offset="0x1A94E0C", VA="0x1A94E0C")]
		static ItemFindResponse()
		{
		}

		[Address(RVA="0x1A92DA0", Offset="0x1A92DA0", VA="0x1A92DA0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10823FC", Offset="0x10823FC")]
		public ItemFindResponse()
		{
		}

		[Address(RVA="0x1A92F68", Offset="0x1A92F68", VA="0x1A92F68")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108240C", Offset="0x108240C")]
		public ItemFindResponse(ItemFindResponse other)
		{
		}

		[Address(RVA="0x1A9417C", Offset="0x1A9417C", VA="0x1A9417C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108247C", Offset="0x108247C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A931B0", Offset="0x1A931B0", VA="0x1A931B0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108241C", Offset="0x108241C")]
		public ItemFindResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A93380", Offset="0x1A93380", VA="0x1A93380", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108242C", Offset="0x108242C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A933F4", Offset="0x1A933F4", VA="0x1A933F4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108243C", Offset="0x108243C")]
		public bool Equals(ItemFindResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9377C", Offset="0x1A9377C", VA="0x1A9377C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108244C", Offset="0x108244C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A94570", Offset="0x1A94570", VA="0x1A94570", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108248C", Offset="0x108248C")]
		public void MergeFrom(ItemFindResponse other)
		{
		}

		[Address(RVA="0x1A94824", Offset="0x1A94824", VA="0x1A94824", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108249C", Offset="0x108249C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A93A94", Offset="0x1A93A94", VA="0x1A93A94", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108245C", Offset="0x108245C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A93AFC", Offset="0x1A93AFC", VA="0x1A93AFC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108246C", Offset="0x108246C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10501D8", Offset="0x10501D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ItemFindResponse.<>c <>9;

			[Address(RVA="0x1A95158", Offset="0x1A95158", VA="0x1A95158")]
			static <>c()
			{
			}

			[Address(RVA="0x1A951BC", Offset="0x1A951BC", VA="0x1A951BC")]
			public <>c()
			{
			}

			[Address(RVA="0x1A951C4", Offset="0x1A951C4", VA="0x1A951C4")]
			internal ItemFindResponse <.cctor>b__120_0()
			{
				return null;
			}

			[Address(RVA="0x1A9521C", Offset="0x1A9521C", VA="0x1A9521C")]
			internal int <.cctor>b__120_1(PlayerActivityType x)
			{
				return new int();
			}

			[Address(RVA="0x1A95224", Offset="0x1A95224", VA="0x1A95224")]
			internal PlayerActivityType <.cctor>b__120_2(int x)
			{
				return new PlayerActivityType();
			}
		}
	}
}