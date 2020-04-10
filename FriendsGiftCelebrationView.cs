using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class FriendsGiftCelebrationView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x1058660", Offset="0x1058660")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1058670", Offset="0x1058670")]
	[FieldOffset(Offset="0x70")]
	private SingleAssetRegistry _singleAssetRegistry;

	private FriendsGiftCelebrationView.SerializedFields Fields
	{
		[Address(RVA="0x12CF090", Offset="0x12CF090", VA="0x12CF090")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12CF2B4", Offset="0x12CF2B4", VA="0x12CF2B4")]
	public FriendsGiftCelebrationView()
	{
	}

	[Address(RVA="0x12CF2BC", Offset="0x12CF2BC", VA="0x12CF2BC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FA54", Offset="0x106FA54")]
	private void <ViewAssetLoaded>b__1_0()
	{
	}

	[Address(RVA="0x12CEF78", Offset="0x12CEF78", VA="0x12CEF78")]
	private void SetClub(string clubName, ClubRole clubRole)
	{
	}

	[Address(RVA="0x12CEAB4", Offset="0x12CEAB4", VA="0x12CEAB4")]
	public void SetData(Player player)
	{
	}

	[Address(RVA="0x12CEDD8", Offset="0x12CEDD8", VA="0x12CEDD8")]
	private void SetIcon(ulong avatarId)
	{
	}

	[Address(RVA="0x12CF170", Offset="0x12CF170", VA="0x12CF170", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x12CF240", Offset="0x12CF240", VA="0x12CF240", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106A59C", Offset="0x106A59C")]
		[FieldOffset(Offset="0x30")]
		public UiLabel SendingToLabel;

		[FieldOffset(Offset="0x38")]
		public RawImage Avatar;

		[FieldOffset(Offset="0x40")]
		public RectTransform AvatarContainer;

		[FieldOffset(Offset="0x48")]
		public UiLabel LevelLabel;

		[FieldOffset(Offset="0x50")]
		public UiLabel NameLabel;

		[FieldOffset(Offset="0x58")]
		public UiLabel ClubNameLabel;

		[FieldOffset(Offset="0x60")]
		public UnityEngine.GameObject ClubLeaderIcon;

		[FieldOffset(Offset="0x68")]
		public UiLabel WhereToClaimLabel;

		[FieldOffset(Offset="0x70")]
		public Button ContinueButton;

		[Address(RVA="0x12CF340", Offset="0x12CF340", VA="0x12CF340")]
		public SerializedFields()
		{
		}
	}
}