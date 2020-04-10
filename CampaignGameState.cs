using Glunies;
using Il2CppDummyDll;
using System;

public class CampaignGameState : AGameState
{
	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x112DD34", Offset="0x112DD34", VA="0x112DD34", Slot="10")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x112DD9C", Offset="0x112DD9C", VA="0x112DD9C")]
	public CampaignGameState()
	{
	}

	[Address(RVA="0x112DD3C", Offset="0x112DD3C", VA="0x112DD3C", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class Context : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly DCampaignAddress CampaignAddress;

		[FieldOffset(Offset="0x38")]
		public readonly CampaignGameState.Context.ViewMode Mode;

		[Address(RVA="0x112AA34", Offset="0x112AA34", VA="0x112AA34")]
		public Context(DCampaignAddress campaignAddress, CampaignGameState.Context.ViewMode viewMode = 0)
		{
		}

		public enum ViewMode
		{
			[FieldOffset(Offset="0x0")]
			Map,
			[FieldOffset(Offset="0x0")]
			BattleDetails
		}
	}
}