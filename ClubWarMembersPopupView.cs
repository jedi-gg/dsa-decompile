using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ClubWarMembersPopupView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x10572C8", Offset="0x10572C8")]
	[FieldOffset(Offset="0x68")]
	private ClubWarDomainController _clubWarDc;

	[FieldOffset(Offset="0x70")]
	private IReadOnlyList<PlayerListItemData> _registeredMembers;

	[FieldOffset(Offset="0x78")]
	private Sequence _showSequence;

	private ClubWarMembersPopupView.SerializedFields Fields
	{
		[Address(RVA="0x14D083C", Offset="0x14D083C", VA="0x14D083C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14D0DB0", Offset="0x14D0DB0", VA="0x14D0DB0")]
	public ClubWarMembersPopupView()
	{
	}

	[Address(RVA="0x14D0BD0", Offset="0x14D0BD0", VA="0x14D0BD0")]
	private void BindMember(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x14D0AE0", Offset="0x14D0AE0", VA="0x14D0AE0")]
	private void InitializeMember(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x14D051C", Offset="0x14D051C", VA="0x14D051C")]
	public void SetRegisteredMembers(List<PlayerListItemData> members)
	{
	}

	[Address(RVA="0x14D091C", Offset="0x14D091C", VA="0x14D091C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14D0A9C", Offset="0x14D0A9C", VA="0x14D0A9C", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x14D0A24", Offset="0x14D0A24", VA="0x14D0A24", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect MembersScrollRect;

		[FieldOffset(Offset="0x38")]
		public UiColorPalette ColorPalette;

		[FieldOffset(Offset="0x40")]
		public UiLabel MembersNeededLabel;

		[FieldOffset(Offset="0x48")]
		public CanvasGroup WindowRoot;

		[Address(RVA="0x14D0DB8", Offset="0x14D0DB8", VA="0x14D0DB8")]
		public SerializedFields()
		{
		}
	}
}