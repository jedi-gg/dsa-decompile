using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ClubInviteManagementPopupView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x10560A8", Offset="0x10560A8")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x70")]
	private IReadOnlyList<ClubInvite> _invites;

	private ClubInviteManagementPopupView.SerializedFields Fields
	{
		[Address(RVA="0x11BE94C", Offset="0x11BE94C", VA="0x11BE94C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11BEE1C", Offset="0x11BEE1C", VA="0x11BEE1C")]
	public ClubInviteManagementPopupView()
	{
	}

	[Address(RVA="0x11BEC5C", Offset="0x11BEC5C", VA="0x11BEC5C")]
	private void BindInviteListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x11BEB6C", Offset="0x11BEB6C", VA="0x11BEB6C")]
	private void InitializeInviteListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11BE6A8", Offset="0x11BE6A8", VA="0x11BE6A8")]
	public void SetInvites(IReadOnlyList<ClubInvite> invites)
	{
	}

	[Address(RVA="0x11BEA2C", Offset="0x11BEA2C", VA="0x11BEA2C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11BEB10", Offset="0x11BEB10", VA="0x11BEB10", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect InvitesScrollRect;

		[FieldOffset(Offset="0x38")]
		public UiLabel EmptyLabel;

		[Address(RVA="0x11BEE24", Offset="0x11BEE24", VA="0x11BEE24")]
		public SerializedFields()
		{
		}
	}
}