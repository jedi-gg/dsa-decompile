using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubInvitePopupView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private ClubInvite _invite;

	private ClubInvitePopupView.SerializedFields Fields
	{
		[Address(RVA="0x11BF530", Offset="0x11BF530", VA="0x11BF530")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11BFBE4", Offset="0x11BFBE4", VA="0x11BFBE4")]
	public ClubInvitePopupView()
	{
	}

	[Address(RVA="0x11BF994", Offset="0x11BF994", VA="0x11BF994")]
	private void AcceptInvite()
	{
	}

	[Address(RVA="0x11BFA18", Offset="0x11BFA18", VA="0x11BFA18")]
	private void DeclineInvite()
	{
	}

	[Address(RVA="0x11BF350", Offset="0x11BF350", VA="0x11BF350")]
	public void SetData(ClubInvite invite)
	{
	}

	[Address(RVA="0x11BF610", Offset="0x11BF610", VA="0x11BF610", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11BFB40", Offset="0x11BFB40", VA="0x11BFB40")]
	private void ViewClub()
	{
	}

	[Address(RVA="0x11BFA9C", Offset="0x11BFA9C", VA="0x11BFA9C")]
	private void ViewPlayer()
	{
	}

	[Address(RVA="0x11BF848", Offset="0x11BF848", VA="0x11BF848", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public LabelButton AcceptButton;

		[FieldOffset(Offset="0x38")]
		public LabelButton DeclineButton;

		[FieldOffset(Offset="0x40")]
		public LabelButton ViewClubButton;

		[FieldOffset(Offset="0x48")]
		public LabelButton ViewPlayerButton;

		[FieldOffset(Offset="0x50")]
		public UiLabel BodyLabel;

		[FieldOffset(Offset="0x58")]
		public UiLabel ReceivedDateLabel;

		[Address(RVA="0x11BFBEC", Offset="0x11BFBEC", VA="0x11BFBEC")]
		public SerializedFields()
		{
		}
	}
}