using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ClubInvitesListView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x1056C98", Offset="0x1056C98")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1056CA8", Offset="0x1056CA8")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x78")]
	private IReadOnlyList<ClubInvite> _invites;

	private ClubInvitesListView.SerializedFields Fields
	{
		[Address(RVA="0x11C0B44", Offset="0x11C0B44", VA="0x11C0B44")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11C10C8", Offset="0x11C10C8", VA="0x11C10C8")]
	public ClubInvitesListView()
	{
	}

	[Address(RVA="0x11C0E40", Offset="0x11C0E40", VA="0x11C0E40")]
	private void BindInvitesListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x11C0D64", Offset="0x11C0D64", VA="0x11C0D64")]
	private void InitializeInvitesListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11C00A8", Offset="0x11C00A8", VA="0x11C00A8")]
	public void SetData(IEnumerable<ClubInvite> invites)
	{
	}

	[Address(RVA="0x11C0C24", Offset="0x11C0C24", VA="0x11C0C24", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11C0D08", Offset="0x11C0D08", VA="0x11C0D08", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public WrappedScrollRect InvitesScrollRect;

		[FieldOffset(Offset="0x30")]
		public UiLabel NoInvitesLabel;

		[Address(RVA="0x1253200", Offset="0x1253200", VA="0x1253200")]
		public SerializedFields()
		{
		}
	}
}