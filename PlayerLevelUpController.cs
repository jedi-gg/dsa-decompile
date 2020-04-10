using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class PlayerLevelUpController : APopupController
{
	[Attribute(Name="InjectAttribute", RVA="0x105B714", Offset="0x105B714")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B724", Offset="0x105B724")]
	[FieldOffset(Offset="0x40")]
	private FeatureLockController _featureLockController;

	public override bool ShouldBeRestoredFromHistory
	{
		[Address(RVA="0x133B4C8", Offset="0x133B4C8", VA="0x133B4C8", Slot="7")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x133B698", Offset="0x133B698", VA="0x133B698")]
	public PlayerLevelUpController()
	{
	}

	[Address(RVA="0x133B4D0", Offset="0x133B4D0", VA="0x133B4D0", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C72C", Offset="0x104C72C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public PlayerLevelUpController <>4__this;

		[FieldOffset(Offset="0x18")]
		public PlayerLevelUp levelUpData;

		[FieldOffset(Offset="0x20")]
		public Action completed;

		[Address(RVA="0x133B690", Offset="0x133B690", VA="0x133B690")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x133B6A0", Offset="0x133B6A0", VA="0x133B6A0")]
		internal void <Initialize>b__0(PlayerLevelUpView view)
		{
		}
	}
}