using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsView : APopupView, IDispatchHandler<DUiTabGroupAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105C250", Offset="0x105C250")]
	[FieldOffset(Offset="0x68")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x105C260", Offset="0x105C260")]
	[FieldOffset(Offset="0x70")]
	private GameLanguageManager _gameLanguageManager;

	[Attribute(Name="InjectAttribute", RVA="0x105C270", Offset="0x105C270")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105C280", Offset="0x105C280")]
	[FieldOffset(Offset="0x80")]
	private RevSdkController _revSdk;

	[Attribute(Name="InjectAttribute", RVA="0x105C290", Offset="0x105C290")]
	[FieldOffset(Offset="0x88")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x105C2A0", Offset="0x105C2A0")]
	[FieldOffset(Offset="0x90")]
	private IHapticController _hapticController;

	[Attribute(Name="InjectAttribute", RVA="0x105C2B0", Offset="0x105C2B0")]
	[FieldOffset(Offset="0x98")]
	private GraphicsSettings _graphicsSettings;

	[Attribute(Name="InjectAttribute", RVA="0x105C2C0", Offset="0x105C2C0")]
	[FieldOffset(Offset="0xA0")]
	private ANotificationController _notificationController;

	private SettingsView.SerializedFields Fields
	{
		[Address(RVA="0x14B9270", Offset="0x14B9270", VA="0x14B9270")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14BA848", Offset="0x14BA848", VA="0x14BA848")]
	public SettingsView()
	{
	}

	[Address(RVA="0x14BA850", Offset="0x14BA850", VA="0x14BA850")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070854", Offset="0x1070854")]
	private void <ViewAssetLoaded>b__1_0()
	{
	}

	[Address(RVA="0x14BA8D4", Offset="0x14BA8D4", VA="0x14BA8D4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070864", Offset="0x1070864")]
	private void <ViewAssetLoaded>b__1_1()
	{
	}

	[Address(RVA="0x14BA958", Offset="0x14BA958", VA="0x14BA958")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070874", Offset="0x1070874")]
	private void <ViewAssetLoaded>b__1_2()
	{
	}

	[Address(RVA="0x14BA9DC", Offset="0x14BA9DC", VA="0x14BA9DC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070884", Offset="0x1070884")]
	private void <ViewAssetLoaded>b__1_3()
	{
	}

	[Address(RVA="0x14BAA60", Offset="0x14BAA60", VA="0x14BAA60")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070894", Offset="0x1070894")]
	private void <ViewAssetLoaded>b__1_4()
	{
	}

	[Address(RVA="0x14B912C", Offset="0x14B912C", VA="0x14B912C", Slot="22")]
	public void HandleDispatchAction(DUiTabGroupAction action)
	{
	}

	[Address(RVA="0x14BA38C", Offset="0x14BA38C", VA="0x14BA38C")]
	private void LanguageClicked()
	{
	}

	[Address(RVA="0x14B9350", Offset="0x14B9350", VA="0x14B9350")]
	private void SetGraphicsTabToCurrent()
	{
	}

	[Address(RVA="0x14BA5E0", Offset="0x14BA5E0", VA="0x14BA5E0")]
	private void ToggleGlobalChatChanged(bool on)
	{
	}

	[Address(RVA="0x14BA464", Offset="0x14BA464", VA="0x14BA464")]
	private void ToggleMusicChanged(bool on)
	{
	}

	[Address(RVA="0x14BA690", Offset="0x14BA690", VA="0x14BA690")]
	private void ToggleNotificationsChanged(bool on)
	{
	}

	[Address(RVA="0x14BA530", Offset="0x14BA530", VA="0x14BA530")]
	private void ToggleSfxChanged(bool on)
	{
	}

	[Address(RVA="0x14BA740", Offset="0x14BA740", VA="0x14BA740")]
	private void ToggleVibration(bool on)
	{
	}

	[Address(RVA="0x14B9410", Offset="0x14B9410", VA="0x14B9410", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14BA02C", Offset="0x14BA02C", VA="0x14BA02C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0x38")]
		public ToggleEx PushNotesToggle;

		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject NotificationsDisabledContainer;

		[FieldOffset(Offset="0x48")]
		public List<UnityEngine.GameObject> NotificationsDisabledSetInactiveObjects;

		[FieldOffset(Offset="0x50")]
		public LabelButton LanguageButton;

		[FieldOffset(Offset="0x58")]
		public LabelButton SupportButton;

		[FieldOffset(Offset="0x60")]
		public LabelButton CreditsButton;

		[FieldOffset(Offset="0x68")]
		public LabelButton PrivacyPolicyButton;

		[FieldOffset(Offset="0x70")]
		public ToggleEx MusicToggle;

		[FieldOffset(Offset="0x78")]
		public ToggleEx SfxToggle;

		[FieldOffset(Offset="0x80")]
		public ToggleEx GlobalChatPreviewsToggle;

		[FieldOffset(Offset="0x88")]
		public ToggleEx VibrationToggle;

		[FieldOffset(Offset="0x90")]
		public UiTabGroup GraphicsTabs;

		[FieldOffset(Offset="0x98")]
		public LabelButton GdprButton;

		[FieldOffset(Offset="0xA0")]
		public UiLabel VersionLabel;

		[FieldOffset(Offset="0xA8")]
		public Button WatchIntroCinematicButton;

		[Address(RVA="0x14BAAE4", Offset="0x14BAAE4", VA="0x14BAAE4")]
		public SerializedFields()
		{
		}
	}
}