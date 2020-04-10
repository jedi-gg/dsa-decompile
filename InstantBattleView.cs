using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantBattleView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x10594B8", Offset="0x10594B8")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x70")]
	private uint _entryCostAmount;

	private InstantBattleView.SerializedFields Fields
	{
		[Address(RVA="0x136B3C4", Offset="0x136B3C4", VA="0x136B3C4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x136B998", Offset="0x136B998", VA="0x136B998")]
	public InstantBattleView()
	{
	}

	[Address(RVA="0x136B8E4", Offset="0x136B8E4", VA="0x136B8E4")]
	private void InstantBattleButtonClicked()
	{
	}

	[Address(RVA="0x136B840", Offset="0x136B840", VA="0x136B840")]
	private void NumBattlesSliderChanged(float value)
	{
	}

	[Address(RVA="0x1368448", Offset="0x1368448", VA="0x1368448")]
	public void SetData(InventoryItem? battleEntryCostItem, uint entryCostAmount, uint maxBattles)
	{
	}

	[Address(RVA="0x13686E0", Offset="0x13686E0", VA="0x13686E0")]
	public void SetData(uint maxBattles)
	{
	}

	[Address(RVA="0x136B4A4", Offset="0x136B4A4", VA="0x136B4A4")]
	private void SetMaxBattles(uint maxBattles)
	{
	}

	[Address(RVA="0x136B5EC", Offset="0x136B5EC", VA="0x136B5EC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x136B79C", Offset="0x136B79C", VA="0x136B79C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C1AC", Offset="0x104C1AC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static InstantBattleView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<UnityEngine.GameObject> <>9__0_0;

		[FieldOffset(Offset="0x10")]
		public static Action<UnityEngine.GameObject> <>9__1_0;

		[Address(RVA="0x136B9A0", Offset="0x136B9A0", VA="0x136B9A0")]
		static <>c()
		{
		}

		[Address(RVA="0x136BA04", Offset="0x136BA04", VA="0x136BA04")]
		public <>c()
		{
		}

		[Address(RVA="0x136BA0C", Offset="0x136BA0C", VA="0x136BA0C")]
		internal void <SetData>b__0_0(UnityEngine.GameObject o)
		{
		}

		[Address(RVA="0x136BA40", Offset="0x136BA40", VA="0x136BA40")]
		internal void <SetData>b__1_0(UnityEngine.GameObject o)
		{
		}
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106AB4C", Offset="0x106AB4C")]
		[FieldOffset(Offset="0x30")]
		public Button InstantBattleButton;

		[FieldOffset(Offset="0x38")]
		public UiSuperSlider NumBattlesSlider;

		[FieldOffset(Offset="0x40")]
		public UiLabel EntryCostOwnedLabel;

		[FieldOffset(Offset="0x48")]
		public UiLabel EntryCostLabel;

		[FieldOffset(Offset="0x50")]
		public RawImage[] EntryCostIcons;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject SliderContainer;

		[FieldOffset(Offset="0x60")]
		public UnityEngine.GameObject OneAvailableContainer;

		[FieldOffset(Offset="0x68")]
		public List<UnityEngine.GameObject> CostItemRootObjects;

		[Address(RVA="0x136BA74", Offset="0x136BA74", VA="0x136BA74")]
		public SerializedFields()
		{
		}
	}
}