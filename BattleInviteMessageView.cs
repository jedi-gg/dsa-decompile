using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BattleInviteMessageView : AView
{
	[Attribute(Name="InjectAttribute", RVA="0x1054A4C", Offset="0x1054A4C")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1054A5C", Offset="0x1054A5C")]
	[FieldOffset(Offset="0x70")]
	private SingleAssetRegistry _avatarIconRegistry;

	public override ViewDepth Depth
	{
		[Address(RVA="0x1101660", Offset="0x1101660", VA="0x1101660", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private BattleInviteMessageView.SerializedFields Fields
	{
		[Address(RVA="0x1101668", Offset="0x1101668", VA="0x1101668")]
		get
		{
			return null;
		}
	}

	protected override bool WillHandleBackButton
	{
		[Address(RVA="0x1101A74", Offset="0x1101A74", VA="0x1101A74", Slot="19")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1101A7C", Offset="0x1101A7C", VA="0x1101A7C")]
	public BattleInviteMessageView()
	{
	}

	[Address(RVA="0x110196C", Offset="0x110196C", VA="0x110196C")]
	private void AcceptClicked()
	{
	}

	[Address(RVA="0x11019F0", Offset="0x11019F0", VA="0x11019F0")]
	private void DeclineClicked()
	{
	}

	[Address(RVA="0x10FF83C", Offset="0x10FF83C", VA="0x10FF83C")]
	public void Show(BattleInviteMsg invite)
	{
	}

	[Address(RVA="0x1101748", Offset="0x1101748", VA="0x1101748", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1101890", Offset="0x1101890", VA="0x1101890", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public RectTransform RootRect;

		[FieldOffset(Offset="0x30")]
		public UiLabel SenderNameLabel;

		[FieldOffset(Offset="0x38")]
		public RawImage SenderAvatar;

		[FieldOffset(Offset="0x40")]
		public UiLabel MessageLabel;

		[FieldOffset(Offset="0x48")]
		public Button AcceptButton;

		[FieldOffset(Offset="0x50")]
		public Button DeclineButton;

		[Address(RVA="0x1101A84", Offset="0x1101A84", VA="0x1101A84")]
		public SerializedFields()
		{
		}
	}
}