using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine.UI;

public class ClubSettingsPopupView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x105666C", Offset="0x105666C")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x70")]
	private ClubSettings _clubSettings;

	private ClubSettingsPopupView.SerializedFields Fields
	{
		[Address(RVA="0x1266BF0", Offset="0x1266BF0", VA="0x1266BF0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12676BC", Offset="0x12676BC", VA="0x12676BC")]
	public ClubSettingsPopupView()
	{
	}

	[Address(RVA="0x12676C4", Offset="0x12676C4", VA="0x12676C4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EEC4", Offset="0x106EEC4")]
	private void <ViewAssetLoaded>b__4_0()
	{
	}

	[Address(RVA="0x1267748", Offset="0x1267748", VA="0x1267748")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EED4", Offset="0x106EED4")]
	private void <ViewAssetLoaded>b__4_1()
	{
	}

	[Address(RVA="0x12677CC", Offset="0x12677CC", VA="0x12677CC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EEE4", Offset="0x106EEE4")]
	private void <ViewAssetLoaded>b__4_2()
	{
	}

	[Address(RVA="0x12677D4", Offset="0x12677D4", VA="0x12677D4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EEF4", Offset="0x106EEF4")]
	private void <ViewAssetLoaded>b__4_3()
	{
	}

	[Address(RVA="0x12677DC", Offset="0x12677DC", VA="0x12677DC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EF04", Offset="0x106EF04")]
	private void <ViewAssetLoaded>b__4_4()
	{
	}

	[Address(RVA="0x12677E4", Offset="0x12677E4", VA="0x12677E4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EF14", Offset="0x106EF14")]
	private char <ViewAssetLoaded>b__4_5(string text, int charIndex, char addedChar)
	{
		return new char();
	}

	[Address(RVA="0x12678AC", Offset="0x12678AC", VA="0x12678AC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EF24", Offset="0x106EF24")]
	private void <ViewAssetLoaded>b__4_6()
	{
	}

	[Address(RVA="0x12668F4", Offset="0x12668F4", VA="0x12668F4")]
	public void BindClubSettings(ClubSettings clubSettings)
	{
	}

	[Address(RVA="0x12675C0", Offset="0x12675C0", VA="0x12675C0")]
	private void DescriptionChanged(string input)
	{
	}

	[Address(RVA="0x1267644", Offset="0x1267644", VA="0x1267644")]
	private void LevelRequirementChanged(float input)
	{
	}

	[Address(RVA="0x126749C", Offset="0x126749C", VA="0x126749C")]
	private void RefreshInvitePolicyButtonsInteractable()
	{
	}

	[Address(RVA="0x12665BC", Offset="0x12665BC", VA="0x12665BC")]
	public void SetIcon(Gamedata.InventoryItem? icon)
	{
	}

	[Address(RVA="0x1266CD0", Offset="0x1266CD0", VA="0x1266CD0")]
	public void SetInvitePolicy(ClubInvitePolicy invitePolicy)
	{
	}

	[Address(RVA="0x12666BC", Offset="0x12666BC", VA="0x12666BC")]
	public void SetOKButtonInteractable(bool interactable)
	{
	}

	[Address(RVA="0x126647C", Offset="0x126647C", VA="0x126647C")]
	public void ShowDescriptionError(bool showing)
	{
	}

	[Address(RVA="0x1266D50", Offset="0x1266D50", VA="0x1266D50", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1267248", Offset="0x1267248", VA="0x1267248", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public Button OKButton;

		[FieldOffset(Offset="0x38")]
		public Button CancelButton;

		[FieldOffset(Offset="0x40")]
		public UiInputField DescriptionInput;

		[FieldOffset(Offset="0x48")]
		public UiSuperSlider LevelRequirementInput;

		[FieldOffset(Offset="0x50")]
		public UiLabel LevelRequirementLabel;

		[FieldOffset(Offset="0x58")]
		public Button OpenInvitePolicyButton;

		[FieldOffset(Offset="0x60")]
		public Button RequestInvitePolicyButton;

		[FieldOffset(Offset="0x68")]
		public Button InviteOnlyInvitePolicyButton;

		[FieldOffset(Offset="0x70")]
		public Button EditAvatarButton;

		[FieldOffset(Offset="0x78")]
		public RawImage AvatarImage;

		[FieldOffset(Offset="0x80")]
		public UiLabel DescriptionError;

		[Address(RVA="0x1267930", Offset="0x1267930", VA="0x1267930")]
		public SerializedFields()
		{
		}
	}
}