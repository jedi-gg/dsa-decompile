using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct StoreItemDef : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public string BoxBackAsset
		{
			[Address(RVA="0xF3AE4C", Offset="0xF3AE4C", VA="0xF3AE4C")]
			get
			{
				return null;
			}
		}

		public string BoxBackDescriptionKey
		{
			[Address(RVA="0xF3AE7C", Offset="0xF3AE7C", VA="0xF3AE7C")]
			get
			{
				return null;
			}
		}

		public string BoxBackNameKey
		{
			[Address(RVA="0xF3AE64", Offset="0xF3AE64", VA="0xF3AE64")]
			get
			{
				return null;
			}
		}

		public string BoxBackShortDescKey
		{
			[Address(RVA="0xF3AFD4", Offset="0xF3AFD4", VA="0xF3AFD4")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3AD78", Offset="0xF3AD78", VA="0xF3AD78", Slot="5")]
			get
			{
				return null;
			}
		}

		public int ClubGiftsLength
		{
			[Address(RVA="0xF3AF4C", Offset="0xF3AF4C", VA="0xF3AF4C")]
			get
			{
				return new int();
			}
		}

		public ItemCount? Cost
		{
			[Address(RVA="0xF3ADF4", Offset="0xF3ADF4", VA="0xF3ADF4")]
			get
			{
				return null;
			}
		}

		public Color? FrameColor
		{
			[Address(RVA="0xF3AF6C", Offset="0xF3AF6C", VA="0xF3AF6C")]
			get
			{
				return null;
			}
		}

		public ulong FriendGiftMsg
		{
			[Address(RVA="0xF3AF5C", Offset="0xF3AF5C", VA="0xF3AF5C")]
			get
			{
				return new ulong();
			}
		}

		public int GrantsLength
		{
			[Address(RVA="0xF3AE04", Offset="0xF3AE04", VA="0xF3AE04")]
			get
			{
				return new int();
			}
		}

		public int HighlightedItemsLength
		{
			[Address(RVA="0xF3AF2C", Offset="0xF3AF2C", VA="0xF3AF2C")]
			get
			{
				return new int();
			}
		}

		public float IapPriceUsd
		{
			[Address(RVA="0xF3AEC4", Offset="0xF3AEC4", VA="0xF3AEC4")]
			get
			{
				return new float();
			}
		}

		public string IapProductIdAndroid
		{
			[Address(RVA="0xF3AEAC", Offset="0xF3AEAC", VA="0xF3AEAC")]
			get
			{
				return null;
			}
		}

		public string IapProductIdIos
		{
			[Address(RVA="0xF3AE94", Offset="0xF3AE94", VA="0xF3AE94")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF3ADA4", Offset="0xF3ADA4", VA="0xF3ADA4")]
			get
			{
				return new ulong();
			}
		}

		public bool IsPurchaseLimitsHidden
		{
			[Address(RVA="0xF3AF54", Offset="0xF3AF54", VA="0xF3AF54")]
			get
			{
				return new bool();
			}
		}

		public uint LimitedTimeOfferDurationSeconds
		{
			[Address(RVA="0xF3AEEC", Offset="0xF3AEEC", VA="0xF3AEEC")]
			get
			{
				return new uint();
			}
		}

		public string MainImage
		{
			[Address(RVA="0xF3ADDC", Offset="0xF3ADDC", VA="0xF3ADDC")]
			get
			{
				return null;
			}
		}

		public string MainImageSpecialOfferOverride
		{
			[Address(RVA="0xF3AF8C", Offset="0xF3AF8C", VA="0xF3AF8C")]
			get
			{
				return null;
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF3ADAC", Offset="0xF3ADAC", VA="0xF3ADAC")]
			get
			{
				return null;
			}
		}

		public string NameKeySpecialOfferTabOverride
		{
			[Address(RVA="0xF3AFA4", Offset="0xF3AFA4", VA="0xF3AFA4")]
			get
			{
				return null;
			}
		}

		public int OccasionsLength
		{
			[Address(RVA="0xF3AEE4", Offset="0xF3AEE4", VA="0xF3AEE4")]
			get
			{
				return new int();
			}
		}

		public int OverrideCostsLength
		{
			[Address(RVA="0xF3B01C", Offset="0xF3B01C", VA="0xF3B01C")]
			get
			{
				return new int();
			}
		}

		public StorePackType PackType
		{
			[Address(RVA="0xF3AE24", Offset="0xF3AE24", VA="0xF3AE24")]
			get
			{
				return new StorePackType();
			}
		}

		public uint PurchaseCooldownSeconds
		{
			[Address(RVA="0xF3AE2C", Offset="0xF3AE2C", VA="0xF3AE2C")]
			get
			{
				return new uint();
			}
		}

		public int PurchaseLimitsLength
		{
			[Address(RVA="0xF3AED4", Offset="0xF3AED4", VA="0xF3AED4")]
			get
			{
				return new int();
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF3AE0C", Offset="0xF3AE0C", VA="0xF3AE0C")]
			get
			{
				return null;
			}
		}

		public RevSdkRewardType RevsdkRewardtype
		{
			[Address(RVA="0xF3B024", Offset="0xF3B024", VA="0xF3B024")]
			get
			{
				return new RevSdkRewardType();
			}
		}

		public string ShowcaseOverridePrefab
		{
			[Address(RVA="0xF3AF74", Offset="0xF3AF74", VA="0xF3AF74")]
			get
			{
				return null;
			}
		}

		public string SpecialOfferIcon
		{
			[Address(RVA="0xF3AEFC", Offset="0xF3AEFC", VA="0xF3AEFC")]
			get
			{
				return null;
			}
		}

		public uint SpecialOfferPopupBeforeExpireS
		{
			[Address(RVA="0xF3AFF4", Offset="0xF3AFF4", VA="0xF3AFF4")]
			get
			{
				return new uint();
			}
		}

		public uint SpecialOfferPopupFrequencyS
		{
			[Address(RVA="0xF3AFEC", Offset="0xF3AFEC", VA="0xF3AFEC")]
			get
			{
				return new uint();
			}
		}

		public int SpecialOfferSort
		{
			[Address(RVA="0xF3AEF4", Offset="0xF3AEF4", VA="0xF3AEF4")]
			get
			{
				return new int();
			}
		}

		public int SpecialOfferVgpPlacementTriggersLength
		{
			[Address(RVA="0xF3AF1C", Offset="0xF3AF1C", VA="0xF3AF1C")]
			get
			{
				return new int();
			}
		}

		public string StickerKey
		{
			[Address(RVA="0xF3ADC4", Offset="0xF3ADC4", VA="0xF3ADC4")]
			get
			{
				return null;
			}
		}

		public string SubtitleKey
		{
			[Address(RVA="0xF3AE34", Offset="0xF3AE34", VA="0xF3AE34")]
			get
			{
				return null;
			}
		}

		public string SubtitleKeySpecialOfferOverride
		{
			[Address(RVA="0xF3AFFC", Offset="0xF3AFFC", VA="0xF3AFFC")]
			get
			{
				return null;
			}
		}

		public string VfxAsset
		{
			[Address(RVA="0xF3AFBC", Offset="0xF3AFBC", VA="0xF3AFBC")]
			get
			{
				return null;
			}
		}

		public string VfxAssetSpecialOfferOverride
		{
			[Address(RVA="0xF3B02C", Offset="0xF3B02C", VA="0xF3B02C")]
			get
			{
				return null;
			}
		}

		public ulong VipSubscription
		{
			[Address(RVA="0xF3AF64", Offset="0xF3AF64", VA="0xF3AF64")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF3AD8C", Offset="0xF3AD8C", VA="0xF3AD8C")]
		public StoreItemDef __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new StoreItemDef();
		}

		[Address(RVA="0xF3AD80", Offset="0xF3AD80", VA="0xF3AD80", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22E9510", Offset="0x22E9510", VA="0x22E9510")]
		public static void AddBoxBackAsset(FlatBufferBuilder builder, StringOffset boxBackAssetOffset)
		{
		}

		[Address(RVA="0x22E9498", Offset="0x22E9498", VA="0x22E9498")]
		public static void AddBoxBackDescriptionKey(FlatBufferBuilder builder, StringOffset boxBackDescriptionKeyOffset)
		{
		}

		[Address(RVA="0x22E94D4", Offset="0x22E94D4", VA="0x22E94D4")]
		public static void AddBoxBackNameKey(FlatBufferBuilder builder, StringOffset boxBackNameKeyOffset)
		{
		}

		[Address(RVA="0x22E9094", Offset="0x22E9094", VA="0x22E9094")]
		public static void AddBoxBackShortDescKey(FlatBufferBuilder builder, StringOffset boxBackShortDescKeyOffset)
		{
		}

		[Address(RVA="0x22E91FC", Offset="0x22E91FC", VA="0x22E91FC")]
		public static void AddClubGifts(FlatBufferBuilder builder, VectorOffset clubGiftsOffset)
		{
		}

		[Address(RVA="0x22E963C", Offset="0x22E963C", VA="0x22E963C")]
		public static void AddCost(FlatBufferBuilder builder, Offset<ItemCount> costOffset)
		{
		}

		[Address(RVA="0x22E91C0", Offset="0x22E91C0", VA="0x22E91C0")]
		public static void AddFrameColor(FlatBufferBuilder builder, Offset<Color> frameColorOffset)
		{
		}

		[Address(RVA="0x22E8EB4", Offset="0x22E8EB4", VA="0x22E8EB4")]
		public static void AddFriendGiftMsg(FlatBufferBuilder builder, ulong friendGiftMsg)
		{
		}

		[Address(RVA="0x22E9600", Offset="0x22E9600", VA="0x22E9600")]
		public static void AddGrants(FlatBufferBuilder builder, VectorOffset grantsOffset)
		{
		}

		[Address(RVA="0x22E9238", Offset="0x22E9238", VA="0x22E9238")]
		public static void AddHighlightedItems(FlatBufferBuilder builder, VectorOffset highlightedItemsOffset)
		{
		}

		[Address(RVA="0x22E93DC", Offset="0x22E93DC", VA="0x22E93DC")]
		public static void AddIapPriceUsd(FlatBufferBuilder builder, float iapPriceUsd)
		{
		}

		[Address(RVA="0x22E9420", Offset="0x22E9420", VA="0x22E9420")]
		public static void AddIapProductIdAndroid(FlatBufferBuilder builder, StringOffset iapProductIdAndroidOffset)
		{
		}

		[Address(RVA="0x22E945C", Offset="0x22E945C", VA="0x22E945C")]
		public static void AddIapProductIdIos(FlatBufferBuilder builder, StringOffset iapProductIdIosOffset)
		{
		}

		[Address(RVA="0x22E8EF0", Offset="0x22E8EF0", VA="0x22E8EF0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x22E972C", Offset="0x22E972C", VA="0x22E972C")]
		public static void AddIsPurchaseLimitsHidden(FlatBufferBuilder builder, bool isPurchaseLimitsHidden)
		{
		}

		[Address(RVA="0x22E9328", Offset="0x22E9328", VA="0x22E9328")]
		public static void AddLimitedTimeOfferDurationSeconds(FlatBufferBuilder builder, uint limitedTimeOfferDurationSeconds)
		{
		}

		[Address(RVA="0x22E9678", Offset="0x22E9678", VA="0x22E9678")]
		public static void AddMainImage(FlatBufferBuilder builder, StringOffset mainImageOffset)
		{
		}

		[Address(RVA="0x22E9148", Offset="0x22E9148", VA="0x22E9148")]
		public static void AddMainImageSpecialOfferOverride(FlatBufferBuilder builder, StringOffset mainImageSpecialOfferOverrideOffset)
		{
		}

		[Address(RVA="0x22E96F0", Offset="0x22E96F0", VA="0x22E96F0")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x22E910C", Offset="0x22E910C", VA="0x22E910C")]
		public static void AddNameKeySpecialOfferTabOverride(FlatBufferBuilder builder, StringOffset nameKeySpecialOfferTabOverrideOffset)
		{
		}

		[Address(RVA="0x22E9364", Offset="0x22E9364", VA="0x22E9364")]
		public static void AddOccasions(FlatBufferBuilder builder, VectorOffset occasionsOffset)
		{
		}

		[Address(RVA="0x22E8FA4", Offset="0x22E8FA4", VA="0x22E8FA4")]
		public static void AddOverrideCosts(FlatBufferBuilder builder, VectorOffset overrideCostsOffset)
		{
		}

		[Address(RVA="0x22E9768", Offset="0x22E9768", VA="0x22E9768")]
		public static void AddPackType(FlatBufferBuilder builder, StorePackType packType)
		{
		}

		[Address(RVA="0x22E9588", Offset="0x22E9588", VA="0x22E9588")]
		public static void AddPurchaseCooldownSeconds(FlatBufferBuilder builder, uint purchaseCooldownSeconds)
		{
		}

		[Address(RVA="0x22E93A0", Offset="0x22E93A0", VA="0x22E93A0")]
		public static void AddPurchaseLimits(FlatBufferBuilder builder, VectorOffset purchaseLimitsOffset)
		{
		}

		[Address(RVA="0x22E95C4", Offset="0x22E95C4", VA="0x22E95C4")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x22E8F68", Offset="0x22E8F68", VA="0x22E8F68")]
		public static void AddRevsdkRewardtype(FlatBufferBuilder builder, RevSdkRewardType revsdkRewardtype)
		{
		}

		[Address(RVA="0x22E9184", Offset="0x22E9184", VA="0x22E9184")]
		public static void AddShowcaseOverridePrefab(FlatBufferBuilder builder, StringOffset showcaseOverridePrefabOffset)
		{
		}

		[Address(RVA="0x22E92B0", Offset="0x22E92B0", VA="0x22E92B0")]
		public static void AddSpecialOfferIcon(FlatBufferBuilder builder, StringOffset specialOfferIconOffset)
		{
		}

		[Address(RVA="0x22E901C", Offset="0x22E901C", VA="0x22E901C")]
		public static void AddSpecialOfferPopupBeforeExpireS(FlatBufferBuilder builder, uint specialOfferPopupBeforeExpireS)
		{
		}

		[Address(RVA="0x22E9058", Offset="0x22E9058", VA="0x22E9058")]
		public static void AddSpecialOfferPopupFrequencyS(FlatBufferBuilder builder, uint specialOfferPopupFrequencyS)
		{
		}

		[Address(RVA="0x22E92EC", Offset="0x22E92EC", VA="0x22E92EC")]
		public static void AddSpecialOfferSort(FlatBufferBuilder builder, int specialOfferSort)
		{
		}

		[Address(RVA="0x22E9274", Offset="0x22E9274", VA="0x22E9274")]
		public static void AddSpecialOfferVgpPlacementTriggers(FlatBufferBuilder builder, VectorOffset specialOfferVgpPlacementTriggersOffset)
		{
		}

		[Address(RVA="0x22E96B4", Offset="0x22E96B4", VA="0x22E96B4")]
		public static void AddStickerKey(FlatBufferBuilder builder, StringOffset stickerKeyOffset)
		{
		}

		[Address(RVA="0x22E954C", Offset="0x22E954C", VA="0x22E954C")]
		public static void AddSubtitleKey(FlatBufferBuilder builder, StringOffset subtitleKeyOffset)
		{
		}

		[Address(RVA="0x22E8FE0", Offset="0x22E8FE0", VA="0x22E8FE0")]
		public static void AddSubtitleKeySpecialOfferOverride(FlatBufferBuilder builder, StringOffset subtitleKeySpecialOfferOverrideOffset)
		{
		}

		[Address(RVA="0x22E90D0", Offset="0x22E90D0", VA="0x22E90D0")]
		public static void AddVfxAsset(FlatBufferBuilder builder, StringOffset vfxAssetOffset)
		{
		}

		[Address(RVA="0x22E8F2C", Offset="0x22E8F2C", VA="0x22E8F2C")]
		public static void AddVfxAssetSpecialOfferOverride(FlatBufferBuilder builder, StringOffset vfxAssetSpecialOfferOverrideOffset)
		{
		}

		[Address(RVA="0x22E8E78", Offset="0x22E8E78", VA="0x22E8E78")]
		public static void AddVipSubscription(FlatBufferBuilder builder, ulong vipSubscription)
		{
		}

		[Address(RVA="0xF3AF44", Offset="0xF3AF44", VA="0xF3AF44")]
		public ItemCount? ClubGifts(int j)
		{
			return null;
		}

		[Address(RVA="0x22E9E58", Offset="0x22E9E58", VA="0x22E9E58")]
		public static VectorOffset CreateClubGiftsVector(FlatBufferBuilder builder, Offset<ItemCount>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22E9854", Offset="0x22E9854", VA="0x22E9854")]
		public static VectorOffset CreateGrantsVector(FlatBufferBuilder builder, Offset<StoreGrantChance>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22E9D24", Offset="0x22E9D24", VA="0x22E9D24")]
		public static VectorOffset CreateHighlightedItemsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22E9ABC", Offset="0x22E9ABC", VA="0x22E9ABC")]
		public static VectorOffset CreateOccasionsVector(FlatBufferBuilder builder, Offset<OccasionRef>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22E9F8C", Offset="0x22E9F8C", VA="0x22E9F8C")]
		public static VectorOffset CreateOverrideCostsVector(FlatBufferBuilder builder, Offset<ItemCount>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22E9988", Offset="0x22E9988", VA="0x22E9988")]
		public static VectorOffset CreatePurchaseLimitsVector(FlatBufferBuilder builder, Offset<PurchaseLimit>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22E9BF0", Offset="0x22E9BF0", VA="0x22E9BF0")]
		public static VectorOffset CreateSpecialOfferVgpPlacementTriggersVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22E8AE8", Offset="0x22E8AE8", VA="0x22E8AE8")]
		public static Offset<StoreItemDef> CreateStoreItemDef(FlatBufferBuilder builder, ulong id = 0L, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.StoreItemDef> Gamedata.StoreItemDef::CreateStoreItemDef(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.Offset`1<Gamedata.ItemCount>,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,Gamedata.StorePackType,System.UInt32,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Single,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.UInt32,System.Int32,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.Boolean,System.UInt64,System.UInt64,FlatBuffers.Offset`1<Gamedata.Color>,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt32,System.UInt32,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,Gamedata.RevSdkRewardType,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.StoreItemDef> CreateStoreItemDef(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.Offset<Gamedata.ItemCount>,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,Gamedata.StorePackType,System.UInt32,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Single,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.UInt32,System.Int32,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.Boolean,System.UInt64,System.UInt64,FlatBuffers.Offset<Gamedata.Color>,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt32,System.UInt32,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,Gamedata.RevSdkRewardType,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22E97A4", Offset="0x22E97A4", VA="0x22E97A4")]
		public static Offset<StoreItemDef> EndStoreItemDef(FlatBufferBuilder builder)
		{
			return new Offset<StoreItemDef>();
		}

		[Address(RVA="0x22EA0C0", Offset="0x22EA0C0", VA="0x22EA0C0")]
		public static void FinishStoreItemDefBuffer(FlatBufferBuilder builder, Offset<StoreItemDef> offset)
		{
		}

		[Address(RVA="0xF3AE54", Offset="0xF3AE54", VA="0xF3AE54")]
		public ArraySegment<byte>? GetBoxBackAssetBytes()
		{
			return null;
		}

		[Address(RVA="0xF3AE84", Offset="0xF3AE84", VA="0xF3AE84")]
		public ArraySegment<byte>? GetBoxBackDescriptionKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF3AE6C", Offset="0xF3AE6C", VA="0xF3AE6C")]
		public ArraySegment<byte>? GetBoxBackNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF3AFDC", Offset="0xF3AFDC", VA="0xF3AFDC")]
		public ArraySegment<byte>? GetBoxBackShortDescKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF3AF34", Offset="0xF3AF34", VA="0xF3AF34")]
		public ArraySegment<byte>? GetHighlightedItemsBytes()
		{
			return null;
		}

		[Address(RVA="0xF3AEB4", Offset="0xF3AEB4", VA="0xF3AEB4")]
		public ArraySegment<byte>? GetIapProductIdAndroidBytes()
		{
			return null;
		}

		[Address(RVA="0xF3AE9C", Offset="0xF3AE9C", VA="0xF3AE9C")]
		public ArraySegment<byte>? GetIapProductIdIosBytes()
		{
			return null;
		}

		[Address(RVA="0xF3ADE4", Offset="0xF3ADE4", VA="0xF3ADE4")]
		public ArraySegment<byte>? GetMainImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF3AF94", Offset="0xF3AF94", VA="0xF3AF94")]
		public ArraySegment<byte>? GetMainImageSpecialOfferOverrideBytes()
		{
			return null;
		}

		[Address(RVA="0xF3ADB4", Offset="0xF3ADB4", VA="0xF3ADB4")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF3AFAC", Offset="0xF3AFAC", VA="0xF3AFAC")]
		public ArraySegment<byte>? GetNameKeySpecialOfferTabOverrideBytes()
		{
			return null;
		}

		[Address(RVA="0xF3AE14", Offset="0xF3AE14", VA="0xF3AE14")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x22E7624", Offset="0x22E7624", VA="0x22E7624")]
		public static StoreItemDef GetRootAsStoreItemDef(FlatBuffers.ByteBuffer _bb)
		{
			return new StoreItemDef();
		}

		[Address(RVA="0x22E7630", Offset="0x22E7630", VA="0x22E7630")]
		public static StoreItemDef GetRootAsStoreItemDef(FlatBuffers.ByteBuffer _bb, StoreItemDef obj)
		{
			return new StoreItemDef();
		}

		[Address(RVA="0xF3AF7C", Offset="0xF3AF7C", VA="0xF3AF7C")]
		public ArraySegment<byte>? GetShowcaseOverridePrefabBytes()
		{
			return null;
		}

		[Address(RVA="0xF3AF04", Offset="0xF3AF04", VA="0xF3AF04")]
		public ArraySegment<byte>? GetSpecialOfferIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF3ADCC", Offset="0xF3ADCC", VA="0xF3ADCC")]
		public ArraySegment<byte>? GetStickerKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF3AE3C", Offset="0xF3AE3C", VA="0xF3AE3C")]
		public ArraySegment<byte>? GetSubtitleKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF3B004", Offset="0xF3B004", VA="0xF3B004")]
		public ArraySegment<byte>? GetSubtitleKeySpecialOfferOverrideBytes()
		{
			return null;
		}

		[Address(RVA="0xF3AFC4", Offset="0xF3AFC4", VA="0xF3AFC4")]
		public ArraySegment<byte>? GetVfxAssetBytes()
		{
			return null;
		}

		[Address(RVA="0xF3B034", Offset="0xF3B034", VA="0xF3B034")]
		public ArraySegment<byte>? GetVfxAssetSpecialOfferOverrideBytes()
		{
			return null;
		}

		[Address(RVA="0xF3ADFC", Offset="0xF3ADFC", VA="0xF3ADFC")]
		public StoreGrantChance? Grants(int j)
		{
			return null;
		}

		[Address(RVA="0xF3AF24", Offset="0xF3AF24", VA="0xF3AF24")]
		public ulong HighlightedItems(int j)
		{
			return new ulong();
		}

		[Address(RVA="0xF3AEDC", Offset="0xF3AEDC", VA="0xF3AEDC")]
		public OccasionRef? Occasions(int j)
		{
			return null;
		}

		[Address(RVA="0xF3B014", Offset="0xF3B014", VA="0xF3B014")]
		public ItemCount? OverrideCosts(int j)
		{
			return null;
		}

		[Address(RVA="0xF3AECC", Offset="0xF3AECC", VA="0xF3AECC")]
		public PurchaseLimit? PurchaseLimits(int j)
		{
			return null;
		}

		[Address(RVA="0xF3AF14", Offset="0xF3AF14", VA="0xF3AF14")]
		public string SpecialOfferVgpPlacementTriggers(int j)
		{
			return null;
		}

		[Address(RVA="0x22E9F50", Offset="0x22E9F50", VA="0x22E9F50")]
		public static void StartClubGiftsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22E994C", Offset="0x22E994C", VA="0x22E994C")]
		public static void StartGrantsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22E9E1C", Offset="0x22E9E1C", VA="0x22E9E1C")]
		public static void StartHighlightedItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22E9BB4", Offset="0x22E9BB4", VA="0x22E9BB4")]
		public static void StartOccasionsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22EA084", Offset="0x22EA084", VA="0x22EA084")]
		public static void StartOverrideCostsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22E9A80", Offset="0x22E9A80", VA="0x22E9A80")]
		public static void StartPurchaseLimitsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22E9CE8", Offset="0x22E9CE8", VA="0x22E9CE8")]
		public static void StartSpecialOfferVgpPlacementTriggersVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22E9824", Offset="0x22E9824", VA="0x22E9824")]
		public static void StartStoreItemDef(FlatBufferBuilder builder)
		{
		}
	}
}