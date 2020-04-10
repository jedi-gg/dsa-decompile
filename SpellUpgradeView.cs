using Gamedata;
using Il2CppDummyDll;
using System;

public class SpellUpgradeView : AAbilityUpgradeView
{
	protected override bool ShowLevel1
	{
		[Address(RVA="0x12479B4", Offset="0x12479B4", VA="0x12479B4", Slot="30")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x12479BC", Offset="0x12479BC", VA="0x12479BC")]
	public SpellUpgradeView()
	{
	}

	[Address(RVA="0x1247948", Offset="0x1247948", VA="0x1247948", Slot="29")]
	protected override void CelebrateUpgrade()
	{
	}

	[Address(RVA="0x1247800", Offset="0x1247800", VA="0x1247800", Slot="27")]
	protected override void EvaluateSelectedAbilityLevelRequirements(int selectedLevelIndex, ref AAbilityUpgradeView.UpgradePreventReason upgradePreventReason)
	{
	}

	[Address(RVA="0x1246E2C", Offset="0x1246E2C", VA="0x1246E2C", Slot="23")]
	public override void Initialize(Action finished)
	{
	}

	[Address(RVA="0x1246EF8", Offset="0x1246EF8", VA="0x1246EF8", Slot="24")]
	protected override void LoadWorldModel()
	{
	}

	[Address(RVA="0x1247030", Offset="0x1247030", VA="0x1247030", Slot="25")]
	protected override void SetAbilityCard()
	{
	}

	[Address(RVA="0x12471EC", Offset="0x12471EC", VA="0x12471EC", Slot="26")]
	protected override void SetIngredientContainer()
	{
	}

	[Address(RVA="0x1247900", Offset="0x1247900", VA="0x1247900", Slot="28")]
	protected override void UpdateSelectedRequirementsLabels(UnitRequirements? requirements)
	{
	}
}