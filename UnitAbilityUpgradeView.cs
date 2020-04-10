using Gamedata;
using Il2CppDummyDll;
using System;

public class UnitAbilityUpgradeView : AAbilityUpgradeView
{
	protected override bool ShowLevel1
	{
		[Address(RVA="0x11DEB98", Offset="0x11DEB98", VA="0x11DEB98", Slot="30")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11DEBA0", Offset="0x11DEBA0", VA="0x11DEBA0")]
	public UnitAbilityUpgradeView()
	{
	}

	[Address(RVA="0x11DE9D0", Offset="0x11DE9D0", VA="0x11DE9D0", Slot="29")]
	protected override void CelebrateUpgrade()
	{
	}

	[Address(RVA="0x11DE1DC", Offset="0x11DE1DC", VA="0x11DE1DC", Slot="27")]
	protected override void EvaluateSelectedAbilityLevelRequirements(int selectedLevelIndex, ref AAbilityUpgradeView.UpgradePreventReason upgradePreventReason)
	{
	}

	[Address(RVA="0x11DD6A4", Offset="0x11DD6A4", VA="0x11DD6A4", Slot="23")]
	public override void Initialize(Action finished)
	{
	}

	[Address(RVA="0x11DD914", Offset="0x11DD914", VA="0x11DD914", Slot="24")]
	protected override void LoadWorldModel()
	{
	}

	[Address(RVA="0x11DDC50", Offset="0x11DDC50", VA="0x11DDC50", Slot="25")]
	protected override void SetAbilityCard()
	{
	}

	[Address(RVA="0x11DE128", Offset="0x11DE128", VA="0x11DE128", Slot="26")]
	protected override void SetIngredientContainer()
	{
	}

	[Address(RVA="0x11DE47C", Offset="0x11DE47C", VA="0x11DE47C", Slot="28")]
	protected override void UpdateSelectedRequirementsLabels(UnitRequirements? requirements)
	{
	}
}