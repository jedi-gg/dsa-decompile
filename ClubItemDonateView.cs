using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClubItemDonateView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x10563FC", Offset="0x10563FC")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x70")]
	private ulong _numDonationsRemaining;

	[FieldOffset(Offset="0x78")]
	private DateTime _donationResetTimeUtc;

	[FieldOffset(Offset="0x80")]
	private IReadOnlyList<ClubItemDonateController.AClubRequestModel> _clubRequests;

	[FieldOffset(Offset="0x88")]
	private List<ClubItemDonateController.ClubItemRequestModel> _itemRequests;

	[FieldOffset(Offset="0x90")]
	private List<ClubItemDonateController.ClubSupportRequestModel> _supportRequests;

	[FieldOffset(Offset="0x98")]
	private ClubItemDonateView.Filter _filter;

	private ClubItemDonateView.SerializedFields Fields
	{
		[Address(RVA="0x1258960", Offset="0x1258960", VA="0x1258960")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1259318", Offset="0x1259318", VA="0x1259318")]
	public ClubItemDonateView()
	{
	}

	[Address(RVA="0x125923C", Offset="0x125923C", VA="0x125923C")]
	private void AllToggled(bool isOn)
	{
	}

	[Address(RVA="0x1258F88", Offset="0x1258F88", VA="0x1258F88")]
	private void BindClubDonateListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1259294", Offset="0x1259294", VA="0x1259294")]
	private void FulfillAllSupportClicked()
	{
	}

	[Address(RVA="0x1258EAC", Offset="0x1258EAC", VA="0x1258EAC")]
	private void InitializeClubDonateListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1259254", Offset="0x1259254", VA="0x1259254")]
	private void ItemsToggled(bool isOn)
	{
	}

	[Address(RVA="0x125400C", Offset="0x125400C", VA="0x125400C")]
	public void PlayDonateAnimation(ClubItemRequest itemRequest)
	{
	}

	[Address(RVA="0x1253A80", Offset="0x1253A80", VA="0x1253A80")]
	public void SetData(IReadOnlyList<ClubItemDonateController.AClubRequestModel> itemRequests)
	{
	}

	[Address(RVA="0x1253FA8", Offset="0x1253FA8", VA="0x1253FA8")]
	public void SetDonationCountAndResetTime(ulong numDonationsRemaining, DateTime donationResetTime)
	{
	}

	[Address(RVA="0x125851C", Offset="0x125851C", VA="0x125851C")]
	private void SetFilteredData()
	{
	}

	[Address(RVA="0x1259274", Offset="0x1259274", VA="0x1259274")]
	private void SupportToggled(bool isOn)
	{
	}

	[Address(RVA="0x12534D0", Offset="0x12534D0", VA="0x12534D0")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1258A40", Offset="0x1258A40", VA="0x1258A40", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1258D48", Offset="0x1258D48", VA="0x1258D48", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	private enum Filter
	{
		[FieldOffset(Offset="0x0")]
		All,
		[FieldOffset(Offset="0x0")]
		Items,
		[FieldOffset(Offset="0x0")]
		Support
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public WrappedScrollRect ScrollRect;

		[FieldOffset(Offset="0x30")]
		public UiLabel NoRequestsLabel;

		[FieldOffset(Offset="0x38")]
		public UiLabel NoItemRequestsLabel;

		[FieldOffset(Offset="0x40")]
		public UiLabel NoSupportRequestsLabel;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.Color LocalPlayerColor;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.Color OtherPlayerColor;

		[FieldOffset(Offset="0x68")]
		public Toggle AllToggle;

		[FieldOffset(Offset="0x70")]
		public Toggle ItemsToggle;

		[FieldOffset(Offset="0x78")]
		public Toggle SupportToggle;

		[FieldOffset(Offset="0x80")]
		public Button FulfillAllSupportButton;

		[Address(RVA="0x12593B0", Offset="0x12593B0", VA="0x12593B0")]
		public SerializedFields()
		{
		}
	}
}