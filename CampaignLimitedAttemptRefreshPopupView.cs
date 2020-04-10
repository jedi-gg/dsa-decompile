using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CampaignLimitedAttemptRefreshPopupView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x10558C8", Offset="0x10558C8")]
	[FieldOffset(Offset="0x68")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x10558D8", Offset="0x10558D8")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x10558E8", Offset="0x10558E8")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x10558F8", Offset="0x10558F8")]
	[FieldOffset(Offset="0x80")]
	private SingleAssetRegistry _refreshCostIconRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x1055908", Offset="0x1055908")]
	[FieldOffset(Offset="0x88")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x90")]
	private UiTimerLabel _resetTimer;

	private CampaignLimitedAttemptRefreshPopupView.SerializedFields Fields
	{
		[Address(RVA="0x112E80C", Offset="0x112E80C", VA="0x112E80C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x112EDFC", Offset="0x112EDFC", VA="0x112EDFC")]
	public CampaignLimitedAttemptRefreshPopupView()
	{
	}

	[Address(RVA="0x112EC28", Offset="0x112EC28", VA="0x112EC28")]
	private void RefreshButtonClicked()
	{
	}

	[Address(RVA="0x112E39C", Offset="0x112E39C", VA="0x112E39C")]
	public void SetInfo(CampaignUtility.DLimitedAttemptInfo info)
	{
	}

	[Address(RVA="0x112E028", Offset="0x112E028", VA="0x112E028")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x112E8EC", Offset="0x112E8EC", VA="0x112E8EC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x112EB54", Offset="0x112EB54", VA="0x112EB54", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Address(RVA="0x112ECAC", Offset="0x112ECAC", VA="0x112ECAC")]
	private void VipClicked()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public CostButton RefreshButton;

		[FieldOffset(Offset="0x38")]
		public UiLabel TimerLabel;

		[FieldOffset(Offset="0x40")]
		public Graphic VipHeart;

		[FieldOffset(Offset="0x48")]
		public Button VipButton;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject VipBonusLockIcon;

		[Address(RVA="0x112EE04", Offset="0x112EE04", VA="0x112EE04")]
		public SerializedFields()
		{
		}
	}
}