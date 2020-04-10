using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine.UI;

public class ClubCreateView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x1055E88", Offset="0x1055E88")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1055E98", Offset="0x1055E98")]
	[FieldOffset(Offset="0x70")]
	private CostController _costController;

	[FieldOffset(Offset="0x78")]
	private ClubSettings _clubSettings;

	private ClubCreateView.SerializedFields Fields
	{
		[Address(RVA="0x1469AAC", Offset="0x1469AAC", VA="0x1469AAC")]
		get
		{
			return null;
		}
	}

	public string Name
	{
		[Address(RVA="0x1468E84", Offset="0x1468E84", VA="0x1468E84")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x146A5E0", Offset="0x146A5E0", VA="0x146A5E0")]
	public ClubCreateView()
	{
	}

	[Address(RVA="0x146A5E8", Offset="0x146A5E8", VA="0x146A5E8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EB5C", Offset="0x106EB5C")]
	private void <ViewAssetLoaded>b__7_0()
	{
	}

	[Address(RVA="0x146A66C", Offset="0x146A66C", VA="0x146A66C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EB6C", Offset="0x106EB6C")]
	private void <ViewAssetLoaded>b__7_1()
	{
	}

	[Address(RVA="0x146A674", Offset="0x146A674", VA="0x146A674")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EB7C", Offset="0x106EB7C")]
	private void <ViewAssetLoaded>b__7_2()
	{
	}

	[Address(RVA="0x146A67C", Offset="0x146A67C", VA="0x146A67C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EB8C", Offset="0x106EB8C")]
	private void <ViewAssetLoaded>b__7_3()
	{
	}

	[Address(RVA="0x146A684", Offset="0x146A684", VA="0x146A684")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EB9C", Offset="0x106EB9C")]
	private char <ViewAssetLoaded>b__7_4(string text, int charIndex, char addedChar)
	{
		return new char();
	}

	[Address(RVA="0x146A74C", Offset="0x146A74C", VA="0x146A74C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EBAC", Offset="0x106EBAC")]
	private char <ViewAssetLoaded>b__7_5(string text, int charIndex, char addedChar)
	{
		return new char();
	}

	[Address(RVA="0x146A814", Offset="0x146A814", VA="0x146A814")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EBBC", Offset="0x106EBBC")]
	private void <ViewAssetLoaded>b__7_6()
	{
	}

	[Address(RVA="0x1469628", Offset="0x1469628", VA="0x1469628")]
	public void BindClubSettings(ClubSettings clubSettings)
	{
	}

	[Address(RVA="0x146A4C8", Offset="0x146A4C8", VA="0x146A4C8")]
	private void DescriptionChanged(string input)
	{
	}

	[Address(RVA="0x146A5A0", Offset="0x146A5A0", VA="0x146A5A0")]
	private void LevelRequirementChanged(float input)
	{
	}

	[Address(RVA="0x146A54C", Offset="0x146A54C", VA="0x146A54C")]
	private void NameChanged(string input)
	{
	}

	[Address(RVA="0x146A3A4", Offset="0x146A3A4", VA="0x146A3A4")]
	private void RefreshInvitePolicyButtonsInteractable()
	{
	}

	[Address(RVA="0x14698F8", Offset="0x14698F8", VA="0x14698F8")]
	public void SetCost(Tuple<Gamedata.InventoryItem, uint> itemAmount)
	{
	}

	[Address(RVA="0x14690D8", Offset="0x14690D8", VA="0x14690D8")]
	public void SetIcon(Gamedata.InventoryItem? icon)
	{
	}

	[Address(RVA="0x1469B8C", Offset="0x1469B8C", VA="0x1469B8C")]
	public void SetInvitePolicy(ClubInvitePolicy invitePolicy)
	{
	}

	[Address(RVA="0x1468FB8", Offset="0x1468FB8", VA="0x1468FB8")]
	public void ShowDescriptionError(bool showing)
	{
	}

	[Address(RVA="0x1468F58", Offset="0x1468F58", VA="0x1468F58")]
	public void ShowNameError(bool showing)
	{
	}

	[Address(RVA="0x1469BD8", Offset="0x1469BD8", VA="0x1469BD8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x146A158", Offset="0x146A158", VA="0x146A158", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public CostButton CreateButton;

		[FieldOffset(Offset="0x38")]
		public UiInputField NameInput;

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
		public UiLabel NameError;

		[FieldOffset(Offset="0x88")]
		public UiLabel DescriptionError;

		[Address(RVA="0x146A898", Offset="0x146A898", VA="0x146A898")]
		public SerializedFields()
		{
		}
	}
}