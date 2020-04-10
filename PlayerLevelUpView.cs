using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class PlayerLevelUpView : APopupView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105B744", Offset="0x105B744")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B754", Offset="0x105B754")]
	[FieldOffset(Offset="0x70")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x78")]
	private List<Serverproto.InventoryItem> _rewardItems;

	[FieldOffset(Offset="0x80")]
	private List<string> _unlockedFeaturesText;

	private PlayerLevelUpView.SerializedFields Fields
	{
		[Address(RVA="0x133C3F0", Offset="0x133C3F0", VA="0x133C3F0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x133CB38", Offset="0x133CB38", VA="0x133CB38")]
	public PlayerLevelUpView()
	{
	}

	[Address(RVA="0x133C870", Offset="0x133C870", VA="0x133C870")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x133CA3C", Offset="0x133CA3C", VA="0x133CA3C")]
	private void BindUnlockedFeatureListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x133C4D0", Offset="0x133C4D0", VA="0x133C4D0", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x133C774", Offset="0x133C774", VA="0x133C774")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x133B7BC", Offset="0x133B7BC", VA="0x133B7BC")]
	public void SetData(PlayerLevelUp levelUpData, List<LockableFeature> unlockedFeatures)
	{
	}

	[Address(RVA="0x133C684", Offset="0x133C684", VA="0x133C684", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x133C6C4", Offset="0x133C6C4", VA="0x133C6C4", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C73C", Offset="0x104C73C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ulong xpItemId;

		[Address(RVA="0x133C3E8", Offset="0x133C3E8", VA="0x133C3E8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x133CB40", Offset="0x133CB40", VA="0x133CB40")]
		internal bool <SetData>b__0(Serverproto.InventoryItem i)
		{
			return new bool();
		}
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B4DC", Offset="0x106B4DC")]
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x38")]
		public WrappedScrollRect UnlockedFeaturesScrollRect;

		[FieldOffset(Offset="0x40")]
		public UiLabel LevelLabel;

		[Address(RVA="0x133CB84", Offset="0x133CB84", VA="0x133CB84")]
		public SerializedFields()
		{
		}
	}
}