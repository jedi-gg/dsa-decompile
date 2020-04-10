using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public class InboxMessagePopupView : APopupView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1059198", Offset="0x1059198")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x70")]
	private InboxViewController.Message _message;

	[FieldOffset(Offset="0x78")]
	private bool _hasClaimableAttachments;

	[FieldOffset(Offset="0x80")]
	private UiTimerLabel _expireTimer;

	private InboxMessagePopupView.SerializedFields Fields
	{
		[Address(RVA="0x117FF60", Offset="0x117FF60", VA="0x117FF60")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1180D78", Offset="0x1180D78", VA="0x1180D78")]
	public InboxMessagePopupView()
	{
	}

	[Address(RVA="0x1180B6C", Offset="0x1180B6C", VA="0x1180B6C")]
	private void BindAttachmentListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x117F35C", Offset="0x117F35C", VA="0x117F35C")]
	public void CelebrateSuccess()
	{
	}

	[Address(RVA="0x1180900", Offset="0x1180900", VA="0x1180900")]
	private void ClaimAttachments()
	{
	}

	[Address(RVA="0x117FF58", Offset="0x117FF58", VA="0x117FF58")]
	public void ClearAttachments()
	{
	}

	[Address(RVA="0x11809B8", Offset="0x11809B8", VA="0x11809B8")]
	private void DeleteMessage()
	{
	}

	[Address(RVA="0x117F730", Offset="0x117F730", VA="0x117F730")]
	public void EnableClaimButton(bool enabled)
	{
	}

	[Address(RVA="0x117F9B8", Offset="0x117F9B8", VA="0x117F9B8")]
	public void EnableDeleteButton(bool enabled)
	{
	}

	[Address(RVA="0x1180CF4", Offset="0x1180CF4", VA="0x1180CF4")]
	private void FollowDeepLink()
	{
	}

	[Address(RVA="0x11803B8", Offset="0x11803B8", VA="0x11803B8", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x1180A70", Offset="0x1180A70", VA="0x1180A70")]
	private void InitializeAttachmentListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1180224", Offset="0x1180224", VA="0x1180224")]
	private bool IsExpired()
	{
		return new bool();
	}

	[Address(RVA="0x1180040", Offset="0x1180040", VA="0x1180040")]
	private void SetAttachmentCount(int numAttachments)
	{
	}

	[Address(RVA="0x11802DC", Offset="0x11802DC", VA="0x11802DC")]
	private void SetExpired(bool expired)
	{
	}

	[Address(RVA="0x117FC04", Offset="0x117FC04", VA="0x117FC04")]
	public void SetMessage(InboxViewController.Message message)
	{
	}

	[Address(RVA="0x117EC14", Offset="0x117EC14", VA="0x117EC14")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x11804D8", Offset="0x11804D8", VA="0x11804D8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11807A8", Offset="0x11807A8", VA="0x11807A8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public Button OkButton;

		[FieldOffset(Offset="0x38")]
		public Button GoButton;

		[FieldOffset(Offset="0x40")]
		public Button ClaimButton;

		[FieldOffset(Offset="0x48")]
		public Button DeleteButton;

		[FieldOffset(Offset="0x50")]
		public WrappedScrollRect AttachmentsScrollRect;

		[FieldOffset(Offset="0x58")]
		public UiLabel ZeroAttachmentsLabel;

		[FieldOffset(Offset="0x60")]
		public UiLabel NonzeroAttachmentsLabel;

		[FieldOffset(Offset="0x68")]
		public UiLabel BodyLabel;

		[FieldOffset(Offset="0x70")]
		public UiLabel SenderLabel;

		[FieldOffset(Offset="0x78")]
		public UiLabel SubjectLabel;

		[FieldOffset(Offset="0x80")]
		public UiLabel ExpireTimerLabel;

		[Address(RVA="0x1180D80", Offset="0x1180D80", VA="0x1180D80")]
		public SerializedFields()
		{
		}
	}
}