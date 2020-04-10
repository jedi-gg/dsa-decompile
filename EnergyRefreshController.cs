using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class EnergyRefreshController : APopupController, IDispatchHandler<DEnergyRefreshViewAction>, IDispatchHandler, IDispatchHandler<DEnergyGeneratedAction>, IDispatchHandler<DRevSdkPlacementShownAction>, IDispatchHandler<DClubSupportRequestButtonAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1057D24", Offset="0x1057D24")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1057D34", Offset="0x1057D34")]
	[FieldOffset(Offset="0x40")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x1057D44", Offset="0x1057D44")]
	[FieldOffset(Offset="0x48")]
	private EnergyGenerateController _energyGenerateController;

	[Attribute(Name="InjectAttribute", RVA="0x1057D54", Offset="0x1057D54")]
	[FieldOffset(Offset="0x50")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1057D64", Offset="0x1057D64")]
	[FieldOffset(Offset="0x58")]
	private ClubServiceUtility _clubServiceUtility;

	[FieldOffset(Offset="0x60")]
	private EnergyRefreshView _view;

	[FieldOffset(Offset="0x68")]
	private EnergyRefreshController.Context _context;

	[FieldOffset(Offset="0x70")]
	private EnergyConstants? _energyConstants;

	[FieldOffset(Offset="0x88")]
	private Gamedata.InventoryItem? _energyItem;

	[FieldOffset(Offset="0xA0")]
	private EnergyRefreshController.EnergyType _energyType;

	[Address(RVA="0x120F7C8", Offset="0x120F7C8", VA="0x120F7C8")]
	public EnergyRefreshController()
	{
	}

	[Address(RVA="0x120F7D0", Offset="0x120F7D0", VA="0x120F7D0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F5C4", Offset="0x106F5C4")]
	private void <RefreshEnergy>b__8_0(EnergyRefreshResponse response)
	{
	}

	[Address(RVA="0x120FC88", Offset="0x120FC88", VA="0x120FC88")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F5D4", Offset="0x106F5D4")]
	private void <RefreshEnergy>b__8_1(long responseCode)
	{
	}

	[Address(RVA="0x120FCEC", Offset="0x120FCEC", VA="0x120FCEC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F5E4", Offset="0x106F5E4")]
	private void <RequestBonusEnergy>b__9_0(AdRewardedEnergyResponse response)
	{
	}

	[Address(RVA="0x1210BF0", Offset="0x1210BF0", VA="0x1210BF0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F5F4", Offset="0x106F5F4")]
	private void <RequestBonusEnergy>b__9_1(long failureCode)
	{
	}

	[Address(RVA="0x1210CE8", Offset="0x1210CE8", VA="0x1210CE8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F604", Offset="0x106F604")]
	private void <RequestBonusEnergy>b__9_2()
	{
	}

	[Address(RVA="0x1210D4C", Offset="0x1210D4C", VA="0x1210D4C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F614", Offset="0x106F614")]
	private void <RequestBonusGenerateEnergy>b__10_1(long failureCode)
	{
	}

	[Address(RVA="0x1210E44", Offset="0x1210E44", VA="0x1210E44")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F624", Offset="0x106F624")]
	private void <RequestBonusGenerateEnergy>b__10_2()
	{
	}

	[Address(RVA="0x120ED14", Offset="0x120ED14", VA="0x120ED14", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x120ED1C", Offset="0x120ED1C", VA="0x120ED1C", Slot="14")]
	public void HandleDispatchAction(DEnergyRefreshViewAction action)
	{
	}

	[Address(RVA="0x120F068", Offset="0x120F068", VA="0x120F068", Slot="15")]
	public void HandleDispatchAction(DEnergyGeneratedAction action)
	{
	}

	[Address(RVA="0x120F184", Offset="0x120F184", VA="0x120F184", Slot="16")]
	public void HandleDispatchAction(DRevSdkPlacementShownAction action)
	{
	}

	[Address(RVA="0x120F5D0", Offset="0x120F5D0", VA="0x120F5D0", Slot="17")]
	public void HandleDispatchAction(DClubSupportRequestButtonAction action)
	{
	}

	[Address(RVA="0x120E71C", Offset="0x120E71C", VA="0x120E71C", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x120EEA0", Offset="0x120EEA0", VA="0x120EEA0")]
	private void RefreshEnergy()
	{
	}

	[Address(RVA="0x120F1A8", Offset="0x120F1A8", VA="0x120F1A8")]
	private void RequestBonusEnergy(DRevSdkPlacementShownAction action)
	{
	}

	[Address(RVA="0x120F388", Offset="0x120F388", VA="0x120F388")]
	private void RequestBonusGenerateEnergy(DRevSdkPlacementShownAction action)
	{
	}

	[Address(RVA="0x120F0C0", Offset="0x120F0C0", VA="0x120F0C0")]
	private void SetNextGenerateTime()
	{
	}

	[Address(RVA="0x120EC7C", Offset="0x120EC7C", VA="0x120EC7C", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BD8C", Offset="0x104BD8C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public EnergyRefreshController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Serverproto.ClubSupportRequestType clubSupportRequestType;

		[FieldOffset(Offset="0x20")]
		public Action completed;

		[Address(RVA="0x120EC74", Offset="0x120EC74", VA="0x120EC74")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1210EA8", Offset="0x1210EA8", VA="0x1210EA8")]
		internal void <Initialize>b__0(EnergyRefreshView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BD9C", Offset="0x104BD9C")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset="0x10")]
		public GenerateBonusEnergyRequest request;

		[FieldOffset(Offset="0x18")]
		public EnergyRefreshController <>4__this;

		[Address(RVA="0x120F7C0", Offset="0x120F7C0", VA="0x120F7C0")]
		public <>c__DisplayClass10_0()
		{
		}

		[Address(RVA="0x1211050", Offset="0x1211050", VA="0x1211050")]
		internal void <RequestBonusGenerateEnergy>b__0(GenerateBonusEnergyResponse response)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly ulong EnergyItemId;

		[Address(RVA="0x121149C", Offset="0x121149C", VA="0x121149C")]
		public Context(ulong energyItemId)
		{
		}
	}

	private enum EnergyType
	{
		[FieldOffset(Offset="0x0")]
		Invalid,
		[FieldOffset(Offset="0x0")]
		Pve,
		[FieldOffset(Offset="0x0")]
		GrandCampaign
	}
}