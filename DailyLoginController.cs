using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using Zenject;

public class DailyLoginController : APopupController, IDispatchHandler<DDailyLoginViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1057864", Offset="0x1057864")]
	[FieldOffset(Offset="0x38")]
	private DiContainer _container;

	[Attribute(Name="InjectAttribute", RVA="0x1057874", Offset="0x1057874")]
	[FieldOffset(Offset="0x40")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x1057884", Offset="0x1057884")]
	[FieldOffset(Offset="0x48")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x50")]
	private DailyLoginView _view;

	[FieldOffset(Offset="0x58")]
	private DailyLogin _dailyLogin;

	[Address(RVA="0x12AF820", Offset="0x12AF820", VA="0x12AF820")]
	public DailyLoginController()
	{
	}

	[Address(RVA="0x12AFC8C", Offset="0x12AFC8C", VA="0x12AFC8C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F404", Offset="0x106F404")]
	private void <BuyExpiredDailyLogin>b__8_0(BuyExpiredDailyLoginResponse response)
	{
	}

	[Address(RVA="0x12AFE78", Offset="0x12AFE78", VA="0x12AFE78")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F414", Offset="0x106F414")]
	private void <BuyExpiredDailyLogin>b__8_1(long failureCode)
	{
	}

	[Address(RVA="0x12AFF1C", Offset="0x12AFF1C", VA="0x12AFF1C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F424", Offset="0x106F424")]
	private void <ClaimBonus>b__9_0(ClaimDailyLoginBonusResponse response)
	{
	}

	[Address(RVA="0x12AFFBC", Offset="0x12AFFBC", VA="0x12AFFBC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F434", Offset="0x106F434")]
	private void <ClaimBonus>b__9_1(long failureCode)
	{
	}

	[Address(RVA="0x12B0060", Offset="0x12B0060", VA="0x12B0060")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F444", Offset="0x106F444")]
	private void <ClaimBonus>b__9_2()
	{
	}

	[Address(RVA="0x12AF828", Offset="0x12AF828", VA="0x12AF828")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F3D4", Offset="0x106F3D4")]
	private void <ClaimDailyLogin>b__6_0(ClaimDailyLoginResponse response)
	{
	}

	[Address(RVA="0x12AFBA0", Offset="0x12AFBA0", VA="0x12AFBA0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F3E4", Offset="0x106F3E4")]
	private void <ClaimDailyLogin>b__6_1(long failureCode)
	{
	}

	[Address(RVA="0x12AFC1C", Offset="0x12AFC1C", VA="0x12AFC1C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F3F4", Offset="0x106F3F4")]
	private void <ClaimDailyLogin>b__6_2()
	{
	}

	[Address(RVA="0x12B00C4", Offset="0x12B00C4", VA="0x12B00C4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F454", Offset="0x106F454")]
	private void <RefreshView>b__15_0(Action finished)
	{
	}

	[Address(RVA="0x12B015C", Offset="0x12B015C", VA="0x12B015C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F464", Offset="0x106F464")]
	private void <RefreshView>b__15_1(Action finished)
	{
	}

	[Address(RVA="0x12B01C0", Offset="0x12B01C0", VA="0x12B01C0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F474", Offset="0x106F474")]
	private void <RefreshView>b__15_2(Action finished)
	{
	}

	[Address(RVA="0x12AEE0C", Offset="0x12AEE0C", VA="0x12AEE0C")]
	private void AutoSelectDay()
	{
	}

	[Address(RVA="0x12AE2A0", Offset="0x12AE2A0", VA="0x12AE2A0")]
	private void BuyExpiredDailyLogin()
	{
	}

	[Address(RVA="0x12AF0CC", Offset="0x12AF0CC", VA="0x12AF0CC")]
	private int CalculateCurrentDayIndex()
	{
		return new int();
	}

	[Address(RVA="0x12AF2EC", Offset="0x12AF2EC", VA="0x12AF2EC")]
	private int CalculateNextActionableDayIndex()
	{
		return new int();
	}

	[Address(RVA="0x12AE454", Offset="0x12AE454", VA="0x12AE454")]
	private void ClaimBonus()
	{
	}

	[Address(RVA="0x12AE0B4", Offset="0x12AE0B4", VA="0x12AE0B4")]
	private void ClaimDailyLogin()
	{
	}

	[Address(RVA="0x12AE794", Offset="0x12AE794", VA="0x12AE794")]
	private void GetDailyLoginData(Action finished)
	{
	}

	[Address(RVA="0x12AE080", Offset="0x12AE080", VA="0x12AE080", Slot="14")]
	public void HandleDispatchAction(DDailyLoginViewAction action)
	{
	}

	[Address(RVA="0x12AE9FC", Offset="0x12AE9FC", VA="0x12AE9FC")]
	private void InitComplete()
	{
	}

	[Address(RVA="0x12ADE74", Offset="0x12ADE74", VA="0x12ADE74", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x12AE918", Offset="0x12AE918", VA="0x12AE918")]
	private void LoadView(Action finished)
	{
	}

	[Address(RVA="0x12AF368", Offset="0x12AF368", VA="0x12AF368")]
	private bool PlayerHasClaimedAllLoginsUpToToday()
	{
		return new bool();
	}

	[Address(RVA="0x12AEE60", Offset="0x12AEE60", VA="0x12AEE60")]
	private void RefreshView(bool forcePlayerFetch)
	{
	}

	[Address(RVA="0x12AF2B4", Offset="0x12AF2B4", VA="0x12AF2B4")]
	private void SelectNextActionableDay()
	{
	}

	[Address(RVA="0x12AF624", Offset="0x12AF624", VA="0x12AF624")]
	private void SendBuyExpiredDailyLoginTelemetry(BuyExpiredDailyLoginResponse response)
	{
	}

	[Address(RVA="0x12AF428", Offset="0x12AF428", VA="0x12AF428")]
	private void SendClaimDailyLoginTelemetry(ClaimDailyLoginResponse response)
	{
	}

	[Address(RVA="0x12AE68C", Offset="0x12AE68C", VA="0x12AE68C")]
	private void ShowVip()
	{
	}

	[Address(RVA="0x12AE010", Offset="0x12AE010", VA="0x12AE010", Slot="9")]
	public override void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BCDC", Offset="0x104BCDC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static DailyLoginController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action <>9__15_3;

		[Address(RVA="0x12B0250", Offset="0x12B0250", VA="0x12B0250")]
		static <>c()
		{
		}

		[Address(RVA="0x12B02B4", Offset="0x12B02B4", VA="0x12B02B4")]
		public <>c()
		{
		}

		[Address(RVA="0x12B02BC", Offset="0x12B02BC", VA="0x12B02BC")]
		internal void <RefreshView>b__15_3()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BCBC", Offset="0x104BCBC")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public DailyLoginController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x12AE910", Offset="0x12AE910", VA="0x12AE910")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x12B02C0", Offset="0x12B02C0", VA="0x12B02C0")]
		internal void <GetDailyLoginData>b__0(GetDailyLoginResponse response)
		{
		}

		[Address(RVA="0x12B0334", Offset="0x12B0334", VA="0x12B0334")]
		internal void <GetDailyLoginData>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BCCC", Offset="0x104BCCC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public DailyLoginController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x12AE9F4", Offset="0x12AE9F4", VA="0x12AE9F4")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x12B0348", Offset="0x12B0348", VA="0x12B0348")]
		internal void <LoadView>b__0(DailyLoginView view)
		{
		}
	}
}