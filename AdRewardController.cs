using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class AdRewardController : APopupController
{
	public override bool ShouldBeRestoredFromHistory
	{
		[Address(RVA="0x1156808", Offset="0x1156808", VA="0x1156808", Slot="7")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1156A3C", Offset="0x1156A3C", VA="0x1156A3C")]
	public AdRewardController()
	{
	}

	[Address(RVA="0x1156810", Offset="0x1156810", VA="0x1156810", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AE1C", Offset="0x104AE1C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public AdRewardController.Context rewardContext;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x1156A34", Offset="0x1156A34", VA="0x1156A34")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1156A44", Offset="0x1156A44", VA="0x1156A44")]
		internal void <Initialize>b__0(AdRewardView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly InventoryDelta Rewards;

		[FieldOffset(Offset="0x18")]
		public readonly string RewardText;

		[Address(RVA="0x1156D98", Offset="0x1156D98", VA="0x1156D98")]
		public Context(InventoryDelta rewards)
		{
		}

		[Address(RVA="0x1156E0C", Offset="0x1156E0C", VA="0x1156E0C")]
		public Context(string rewardText)
		{
		}
	}
}