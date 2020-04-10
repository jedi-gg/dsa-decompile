using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PinPageItemDetailsView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x105B424", Offset="0x105B424")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	private PinPageItemDetailsView.SerializedFields Fields
	{
		[Address(RVA="0x141233C", Offset="0x141233C", VA="0x141233C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1412620", Offset="0x1412620", VA="0x1412620")]
	public PinPageItemDetailsView()
	{
	}

	[Address(RVA="0x1412628", Offset="0x1412628", VA="0x1412628")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070354", Offset="0x1070354")]
	private void <ViewAssetLoaded>b__2_0()
	{
	}

	[Address(RVA="0x14126AC", Offset="0x14126AC", VA="0x14126AC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070364", Offset="0x1070364")]
	private void <ViewAssetLoaded>b__2_1()
	{
	}

	[Address(RVA="0x141226C", Offset="0x141226C", VA="0x141226C")]
	public void HideAvatarButton()
	{
	}

	[Address(RVA="0x1411C64", Offset="0x1411C64", VA="0x1411C64")]
	public void SetData(PinPageItemData data)
	{
	}

	[Address(RVA="0x141241C", Offset="0x141241C", VA="0x141241C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1412564", Offset="0x1412564", VA="0x1412564", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B3FC", Offset="0x106B3FC")]
		[FieldOffset(Offset="0x30")]
		public Button AchievementButton;

		[FieldOffset(Offset="0x38")]
		public UiLabel NameLabel;

		[FieldOffset(Offset="0x40")]
		public UiLabel DescriptionLabel;

		[FieldOffset(Offset="0x48")]
		public RawImage PinImage;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject ObscuredIconObject;

		[FieldOffset(Offset="0x58")]
		public Color MysteryColor;

		[FieldOffset(Offset="0x68")]
		public Button ProfileAvatarButton;

		[Address(RVA="0x1412730", Offset="0x1412730", VA="0x1412730")]
		public SerializedFields()
		{
		}
	}
}