using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class StoreItem : IMessage<StoreItem>, IMessage, IEquatable<StoreItem>, IDeepCloneable<StoreItem>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<StoreItem> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong id_;

		[FieldOffset(Offset="0x0")]
		public const int NameKeyFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string nameKey_;

		[FieldOffset(Offset="0x0")]
		public const int StickerKeyFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string stickerKey_;

		[FieldOffset(Offset="0x0")]
		public const int MainImageFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string mainImage_;

		[FieldOffset(Offset="0x0")]
		public const int ShowcaseOverridePrefabFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string showcaseOverridePrefab_;

		[FieldOffset(Offset="0x0")]
		public const int PackOpeningTypeFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private uint packOpeningType_;

		[FieldOffset(Offset="0x0")]
		public const int CostFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ItemCount cost_;

		[FieldOffset(Offset="0x0")]
		public const int PurchaseLimitsFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private Serverproto.PurchaseLimits purchaseLimits_;

		[FieldOffset(Offset="0x0")]
		public const int SubtitleKeyFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private string subtitleKey_;

		[FieldOffset(Offset="0x0")]
		public const int ShelfKeyFieldNumber = 10;

		[FieldOffset(Offset="0x60")]
		private string shelfKey_;

		[FieldOffset(Offset="0x0")]
		public const int BoxBackAssetFieldNumber = 11;

		[FieldOffset(Offset="0x68")]
		private string boxBackAsset_;

		[FieldOffset(Offset="0x0")]
		public const int MinQuantityFieldNumber = 12;

		[FieldOffset(Offset="0x70")]
		private uint minQuantity_;

		[FieldOffset(Offset="0x0")]
		public const int MaxQuantityFieldNumber = 13;

		[FieldOffset(Offset="0x74")]
		private uint maxQuantity_;

		[FieldOffset(Offset="0x0")]
		public const int IapProductIdIosFieldNumber = 14;

		[FieldOffset(Offset="0x78")]
		private string iapProductIdIos_;

		[FieldOffset(Offset="0x0")]
		public const int IapProductIdAndroidFieldNumber = 15;

		[FieldOffset(Offset="0x80")]
		private string iapProductIdAndroid_;

		[FieldOffset(Offset="0x0")]
		public const int SpecialOfferEndTimestampFieldNumber = 16;

		[FieldOffset(Offset="0x88")]
		private ulong specialOfferEndTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int IsFreeFieldNumber = 17;

		[FieldOffset(Offset="0x90")]
		private bool isFree_;

		[FieldOffset(Offset="0x0")]
		public const int ContentsPreviewAssetsFieldNumber = 18;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<string> _repeated_contentsPreviewAssets_codec;

		[FieldOffset(Offset="0x98")]
		private readonly RepeatedField<string> contentsPreviewAssets_;

		[FieldOffset(Offset="0x0")]
		public const int ItemCountsFieldNumber = 19;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ItemCountRange> _repeated_itemCounts_codec;

		[FieldOffset(Offset="0xA0")]
		private readonly RepeatedField<ItemCountRange> itemCounts_;

		[FieldOffset(Offset="0x0")]
		public const int ExpiryFieldNumber = 20;

		[FieldOffset(Offset="0xA8")]
		private ulong expiry_;

		[FieldOffset(Offset="0x0")]
		public const int SpecialOfferIconFieldNumber = 21;

		[FieldOffset(Offset="0xB0")]
		private string specialOfferIcon_;

		[FieldOffset(Offset="0x0")]
		public const int SpecialOfferVgpPlacementTriggersFieldNumber = 22;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<string> _repeated_specialOfferVgpPlacementTriggers_codec;

		[FieldOffset(Offset="0xB8")]
		private readonly RepeatedField<string> specialOfferVgpPlacementTriggers_;

		[FieldOffset(Offset="0x0")]
		public const int HighlightedItemsFieldNumber = 23;

		[FieldOffset(Offset="0x20")]
		private readonly static FieldCodec<ulong> _repeated_highlightedItems_codec;

		[FieldOffset(Offset="0xC0")]
		private readonly RepeatedField<ulong> highlightedItems_;

		[FieldOffset(Offset="0x0")]
		public const int HasGiftsFieldNumber = 24;

		[FieldOffset(Offset="0xC8")]
		private bool hasGifts_;

		[FieldOffset(Offset="0x0")]
		public const int IsPurchaseLimitsHiddenFieldNumber = 25;

		[FieldOffset(Offset="0xC9")]
		private bool isPurchaseLimitsHidden_;

		[FieldOffset(Offset="0x0")]
		public const int IsAFriendGiftFieldNumber = 26;

		[FieldOffset(Offset="0xCA")]
		private bool isAFriendGift_;

		[FieldOffset(Offset="0x0")]
		public const int StorePackTypeFieldNumber = 27;

		[FieldOffset(Offset="0xCC")]
		private uint storePackType_;

		[FieldOffset(Offset="0x0")]
		public const int FrameColorFieldNumber = 28;

		[FieldOffset(Offset="0xD0")]
		private Color frameColor_;

		[FieldOffset(Offset="0x0")]
		public const int MainImageSpecialOfferOverrideFieldNumber = 29;

		[FieldOffset(Offset="0xD8")]
		private string mainImageSpecialOfferOverride_;

		[FieldOffset(Offset="0x0")]
		public const int NameKeySpecialOfferTabOverrideFieldNumber = 30;

		[FieldOffset(Offset="0xE0")]
		private string nameKeySpecialOfferTabOverride_;

		[FieldOffset(Offset="0x0")]
		public const int VfxAssetFieldNumber = 31;

		[FieldOffset(Offset="0xE8")]
		private string vfxAsset_;

		[FieldOffset(Offset="0x0")]
		public const int VipDataFieldNumber = 32;

		[FieldOffset(Offset="0xF0")]
		private StoreItemVipData vipData_;

		[FieldOffset(Offset="0x0")]
		public const int SpecialOfferPopupFrequencySFieldNumber = 33;

		[FieldOffset(Offset="0xF8")]
		private uint specialOfferPopupFrequencyS_;

		[FieldOffset(Offset="0x0")]
		public const int SpecialOfferPopupBeforeExpireSFieldNumber = 34;

		[FieldOffset(Offset="0xFC")]
		private uint specialOfferPopupBeforeExpireS_;

		[FieldOffset(Offset="0x0")]
		public const int PopupItemSizeFieldNumber = 35;

		[FieldOffset(Offset="0x100")]
		private StoreItemSize popupItemSize_;

		[FieldOffset(Offset="0x0")]
		public const int SubtitleKeySpecialOfferOverrideFieldNumber = 36;

		[FieldOffset(Offset="0x108")]
		private string subtitleKeySpecialOfferOverride_;

		[FieldOffset(Offset="0x0")]
		public const int OverrideCostsFieldNumber = 37;

		[FieldOffset(Offset="0x28")]
		private readonly static FieldCodec<ItemCount> _repeated_overrideCosts_codec;

		[FieldOffset(Offset="0x110")]
		private readonly RepeatedField<ItemCount> overrideCosts_;

		[FieldOffset(Offset="0x0")]
		public const int VfxAssetSpecialOfferOverrideFieldNumber = 38;

		[FieldOffset(Offset="0x118")]
		private string vfxAssetSpecialOfferOverride_;

		[FieldOffset(Offset="0x0")]
		public const int RevSdkVideoAdTypeFieldNumber = 39;

		[FieldOffset(Offset="0x120")]
		private int revSdkVideoAdType_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BF38", Offset="0x109BF38")]
		public string BoxBackAsset
		{
			[Address(RVA="0x1BDB104", Offset="0x1BDB104", VA="0x1BDB104")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDB10C", Offset="0x1BDB10C", VA="0x1BDB10C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BFF8", Offset="0x109BFF8")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x109BFF8", Offset="0x109BFF8")]
		public RepeatedField<string> ContentsPreviewAssets
		{
			[Address(RVA="0x1BDB2B0", Offset="0x1BDB2B0", VA="0x1BDB2B0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BED0", Offset="0x109BED0")]
		public ItemCount Cost
		{
			[Address(RVA="0x1BDADD4", Offset="0x1BDADD4", VA="0x1BDADD4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDADDC", Offset="0x1BDADDC", VA="0x1BDADDC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BE28", Offset="0x109BE28")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BDA99C", Offset="0x1BDA99C", VA="0x1BDA99C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C040", Offset="0x109C040")]
		public ulong Expiry
		{
			[Address(RVA="0x1BDB2C0", Offset="0x1BDB2C0", VA="0x1BDB2C0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BDB2C8", Offset="0x1BDB2C8", VA="0x1BDB2C8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C0C0", Offset="0x109C0C0")]
		public Color FrameColor
		{
			[Address(RVA="0x1BDADF4", Offset="0x1BDADF4", VA="0x1BDADF4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDADFC", Offset="0x1BDADFC", VA="0x1BDADFC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C080", Offset="0x109C080")]
		public bool HasGifts
		{
			[Address(RVA="0x1BDB358", Offset="0x1BDB358", VA="0x1BDB358")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BDB360", Offset="0x1BDB360", VA="0x1BDB360")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C070", Offset="0x109C070")]
		public RepeatedField<ulong> HighlightedItems
		{
			[Address(RVA="0x1BDB350", Offset="0x1BDB350", VA="0x1BDB350")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BFC8", Offset="0x109BFC8")]
		public string IapProductIdAndroid
		{
			[Address(RVA="0x1BDB214", Offset="0x1BDB214", VA="0x1BDB214")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDB21C", Offset="0x1BDB21C", VA="0x1BDB21C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BFB8", Offset="0x109BFB8")]
		public string IapProductIdIos
		{
			[Address(RVA="0x1BDB19C", Offset="0x1BDB19C", VA="0x1BDB19C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDB1A4", Offset="0x1BDB1A4", VA="0x1BDB1A4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BE48", Offset="0x109BE48")]
		public ulong Id
		{
			[Address(RVA="0x1BDAE14", Offset="0x1BDAE14", VA="0x1BDAE14")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BDAE1C", Offset="0x1BDAE1C", VA="0x1BDAE1C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C0A0", Offset="0x109C0A0")]
		public bool IsAFriendGift
		{
			[Address(RVA="0x1BDB380", Offset="0x1BDB380", VA="0x1BDB380")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BDB388", Offset="0x1BDB388", VA="0x1BDB388")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BFE8", Offset="0x109BFE8")]
		public bool IsFree
		{
			[Address(RVA="0x1BDB29C", Offset="0x1BDB29C", VA="0x1BDB29C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BDB2A4", Offset="0x1BDB2A4", VA="0x1BDB2A4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C090", Offset="0x109C090")]
		public bool IsPurchaseLimitsHidden
		{
			[Address(RVA="0x1BDB36C", Offset="0x1BDB36C", VA="0x1BDB36C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1BDB374", Offset="0x1BDB374", VA="0x1BDB374")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C030", Offset="0x109C030")]
		public RepeatedField<ItemCountRange> ItemCounts
		{
			[Address(RVA="0x1BDB2B8", Offset="0x1BDB2B8", VA="0x1BDB2B8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BE78", Offset="0x109BE78")]
		public string MainImage
		{
			[Address(RVA="0x1BDAF14", Offset="0x1BDAF14", VA="0x1BDAF14")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDAF1C", Offset="0x1BDAF1C", VA="0x1BDAF1C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C0D0", Offset="0x109C0D0")]
		public string MainImageSpecialOfferOverride
		{
			[Address(RVA="0x1BDB3A4", Offset="0x1BDB3A4", VA="0x1BDB3A4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDB3AC", Offset="0x1BDB3AC", VA="0x1BDB3AC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BF80", Offset="0x109BF80")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x109BF80", Offset="0x109BF80")]
		public uint MaxQuantity
		{
			[Address(RVA="0x1BDB18C", Offset="0x1BDB18C", VA="0x1BDB18C")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1BDB194", Offset="0x1BDB194", VA="0x1BDB194")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BF48", Offset="0x109BF48")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x109BF48", Offset="0x109BF48")]
		public uint MinQuantity
		{
			[Address(RVA="0x1BDB17C", Offset="0x1BDB17C", VA="0x1BDB17C")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1BDB184", Offset="0x1BDB184", VA="0x1BDB184")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BE58", Offset="0x109BE58")]
		public string NameKey
		{
			[Address(RVA="0x1BDAE24", Offset="0x1BDAE24", VA="0x1BDAE24")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDAE2C", Offset="0x1BDAE2C", VA="0x1BDAE2C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C0E0", Offset="0x109C0E0")]
		public string NameKeySpecialOfferTabOverride
		{
			[Address(RVA="0x1BDB41C", Offset="0x1BDB41C", VA="0x1BDB41C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDB424", Offset="0x1BDB424", VA="0x1BDB424")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C150", Offset="0x109C150")]
		public RepeatedField<ItemCount> OverrideCosts
		{
			[Address(RVA="0x1BDB5B4", Offset="0x1BDB5B4", VA="0x1BDB5B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BE98", Offset="0x109BE98")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x109BE98", Offset="0x109BE98")]
		public uint PackOpeningType
		{
			[Address(RVA="0x1BDB004", Offset="0x1BDB004", VA="0x1BDB004")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1BDB00C", Offset="0x1BDB00C", VA="0x1BDB00C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BE18", Offset="0x109BE18")]
		public static MessageParser<StoreItem> Parser
		{
			[Address(RVA="0x1BD75E4", Offset="0x1BD75E4", VA="0x1BD75E4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BE38", Offset="0x109BE38")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BDAA8C", Offset="0x1BDAA8C", VA="0x1BDAA8C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C130", Offset="0x109C130")]
		public StoreItemSize PopupItemSize
		{
			[Address(RVA="0x1BDB52C", Offset="0x1BDB52C", VA="0x1BDB52C")]
			get
			{
				return new StoreItemSize();
			}
			[Address(RVA="0x1BDB534", Offset="0x1BDB534", VA="0x1BDB534")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BEE0", Offset="0x109BEE0")]
		public Serverproto.PurchaseLimits PurchaseLimits
		{
			[Address(RVA="0x1BDADE4", Offset="0x1BDADE4", VA="0x1BDADE4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDADEC", Offset="0x1BDADEC", VA="0x1BDADEC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C170", Offset="0x109C170")]
		public int RevSdkVideoAdType
		{
			[Address(RVA="0x1BDB634", Offset="0x1BDB634", VA="0x1BDB634")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1BDB63C", Offset="0x1BDB63C", VA="0x1BDB63C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BF00", Offset="0x109BF00")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x109BF00", Offset="0x109BF00")]
		public string ShelfKey
		{
			[Address(RVA="0x1BDB08C", Offset="0x1BDB08C", VA="0x1BDB08C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDB094", Offset="0x1BDB094", VA="0x1BDB094")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BE88", Offset="0x109BE88")]
		public string ShowcaseOverridePrefab
		{
			[Address(RVA="0x1BDAF8C", Offset="0x1BDAF8C", VA="0x1BDAF8C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDAF94", Offset="0x1BDAF94", VA="0x1BDAF94")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BFD8", Offset="0x109BFD8")]
		public ulong SpecialOfferEndTimestamp
		{
			[Address(RVA="0x1BDB28C", Offset="0x1BDB28C", VA="0x1BDB28C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1BDB294", Offset="0x1BDB294", VA="0x1BDB294")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C050", Offset="0x109C050")]
		public string SpecialOfferIcon
		{
			[Address(RVA="0x1BDB2D0", Offset="0x1BDB2D0", VA="0x1BDB2D0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDB2D8", Offset="0x1BDB2D8", VA="0x1BDB2D8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C120", Offset="0x109C120")]
		public uint SpecialOfferPopupBeforeExpireS
		{
			[Address(RVA="0x1BDB51C", Offset="0x1BDB51C", VA="0x1BDB51C")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1BDB524", Offset="0x1BDB524", VA="0x1BDB524")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C110", Offset="0x109C110")]
		public uint SpecialOfferPopupFrequencyS
		{
			[Address(RVA="0x1BDB50C", Offset="0x1BDB50C", VA="0x1BDB50C")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1BDB514", Offset="0x1BDB514", VA="0x1BDB514")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C060", Offset="0x109C060")]
		public RepeatedField<string> SpecialOfferVgpPlacementTriggers
		{
			[Address(RVA="0x1BDB348", Offset="0x1BDB348", VA="0x1BDB348")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BE68", Offset="0x109BE68")]
		public string StickerKey
		{
			[Address(RVA="0x1BDAE9C", Offset="0x1BDAE9C", VA="0x1BDAE9C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDAEA4", Offset="0x1BDAEA4", VA="0x1BDAEA4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C0B0", Offset="0x109C0B0")]
		public uint StorePackType
		{
			[Address(RVA="0x1BDB394", Offset="0x1BDB394", VA="0x1BDB394")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1BDB39C", Offset="0x1BDB39C", VA="0x1BDB39C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109BEF0", Offset="0x109BEF0")]
		public string SubtitleKey
		{
			[Address(RVA="0x1BDB014", Offset="0x1BDB014", VA="0x1BDB014")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDB01C", Offset="0x1BDB01C", VA="0x1BDB01C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C140", Offset="0x109C140")]
		public string SubtitleKeySpecialOfferOverride
		{
			[Address(RVA="0x1BDB53C", Offset="0x1BDB53C", VA="0x1BDB53C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDB544", Offset="0x1BDB544", VA="0x1BDB544")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C0F0", Offset="0x109C0F0")]
		public string VfxAsset
		{
			[Address(RVA="0x1BDB494", Offset="0x1BDB494", VA="0x1BDB494")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDB49C", Offset="0x1BDB49C", VA="0x1BDB49C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C160", Offset="0x109C160")]
		public string VfxAssetSpecialOfferOverride
		{
			[Address(RVA="0x1BDB5BC", Offset="0x1BDB5BC", VA="0x1BDB5BC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDB5C4", Offset="0x1BDB5C4", VA="0x1BDB5C4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C100", Offset="0x109C100")]
		public StoreItemVipData VipData
		{
			[Address(RVA="0x1BDAE04", Offset="0x1BDAE04", VA="0x1BDAE04")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDAE0C", Offset="0x1BDAE0C", VA="0x1BDAE0C")]
			set
			{
			}
		}

		[Address(RVA="0x1BDE5A0", Offset="0x1BDE5A0", VA="0x1BDE5A0")]
		static StoreItem()
		{
		}

		[Address(RVA="0x1BD45E8", Offset="0x1BD45E8", VA="0x1BD45E8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087FAC", Offset="0x1087FAC")]
		public StoreItem()
		{
		}

		[Address(RVA="0x1BDAAE8", Offset="0x1BDAAE8", VA="0x1BDAAE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087FBC", Offset="0x1087FBC")]
		public StoreItem(StoreItem other)
		{
		}

		[Address(RVA="0x1BDD200", Offset="0x1BDD200", VA="0x1BDD200", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108802C", Offset="0x108802C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BD37DC", Offset="0x1BD37DC", VA="0x1BD37DC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087FCC", Offset="0x1087FCC")]
		public StoreItem Clone()
		{
			return null;
		}

		[Address(RVA="0x1BDB644", Offset="0x1BDB644", VA="0x1BDB644", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087FDC", Offset="0x1087FDC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BDB6B8", Offset="0x1BDB6B8", VA="0x1BDB6B8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087FEC", Offset="0x1087FEC")]
		public bool Equals(StoreItem other)
		{
			return new bool();
		}

		[Address(RVA="0x1BDBAD8", Offset="0x1BDBAD8", VA="0x1BDBAD8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1087FFC", Offset="0x1087FFC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BD4734", Offset="0x1BD4734", VA="0x1BD4734", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108803C", Offset="0x108803C")]
		public void MergeFrom(StoreItem other)
		{
		}

		[Address(RVA="0x1BDDCBC", Offset="0x1BDDCBC", VA="0x1BDDCBC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108804C", Offset="0x108804C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BDC200", Offset="0x1BDC200", VA="0x1BDC200", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108800C", Offset="0x108800C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BDC268", Offset="0x1BDC268", VA="0x1BDC268", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108801C", Offset="0x108801C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050A38", Offset="0x1050A38")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static StoreItem.<>c <>9;

			[Address(RVA="0x1BDE758", Offset="0x1BDE758", VA="0x1BDE758")]
			static <>c()
			{
			}

			[Address(RVA="0x1BDE7BC", Offset="0x1BDE7BC", VA="0x1BDE7BC")]
			public <>c()
			{
			}

			[Address(RVA="0x1BDE7C4", Offset="0x1BDE7C4", VA="0x1BDE7C4")]
			internal StoreItem <.cctor>b__215_0()
			{
				return null;
			}
		}
	}
}