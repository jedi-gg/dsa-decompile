using Glunies;
using Il2CppDummyDll;
using System;

public class SystemDialogManager : ADialogManager<SystemDialogView>, IDispatchHandler<DServiceNetworkFailureAction>, IDispatchHandler, IDispatchHandler<DFatalAction>, IDispatchHandler<DTitleViewAction>, IDispatchHandler<DServerInMaintenanceModeAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1057BC4", Offset="0x1057BC4")]
	[FieldOffset(Offset="0x38")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1057BD4", Offset="0x1057BD4")]
	[FieldOffset(Offset="0x40")]
	private ServerMaintenanceUtil _serverMaintenanceUtil;

	[FieldOffset(Offset="0x0")]
	private const string CONNECTION_FAILURE_DIALOG_ID = "CONNECTION_FAILURE_DIALOG_ID";

	[FieldOffset(Offset="0x0")]
	private const string FATAL_ERROR_DIALOG_ID = "FATAL_ERROR_DIALOG_ID";

	[FieldOffset(Offset="0x0")]
	private const string UPDATE_REQUIRED_DIALOG_ID = "UPDATE_REQUIRED_DIALOG_ID";

	[FieldOffset(Offset="0x0")]
	private const string PLAYER_BANNED_DIALOG_ID = "PLAYER_BANNED_DIALOG_ID";

	[FieldOffset(Offset="0x0")]
	private const string INVALID_AUTH_TOKEN_DIALOG_ID = "INVALID_AUTH_TOKEN_DIALOG_ID";

	[FieldOffset(Offset="0x0")]
	private const string SERVER_MAINTENANCE_ID = "SERVER_MAINTENANCE_ID";

	[FieldOffset(Offset="0x0")]
	private const string DISK_FULL_DIALOG_ID = "DISK_FULL_DIALOG_ID";

	[FieldOffset(Offset="0x0")]
	private const string ASSET_BUNDLE_FAIL_DIALOG_ID = "ASSET_BUNDLE_FAIL_DIALOG_ID";

	[FieldOffset(Offset="0x0")]
	private const string AUTO_AUTH_TIMED_OUT_DIALOG_ID = "AUTO_AUTH_TIMED_OUT_DIALOG_ID";

	[FieldOffset(Offset="0x0")]
	private const string GOOGLE_PLAY_STORE_APP_URL = "http://play.google.com/store/apps/details?id=com.glu.disneygame";

	[FieldOffset(Offset="0x0")]
	private const string IOS_APP_STORE_APP_URL = "https://itunes.apple.com/app/id1445068497?mt=8";

	[Address(RVA="0x131B724", Offset="0x131B724", VA="0x131B724")]
	public SystemDialogManager()
	{
	}

	[Address(RVA="0x131B968", Offset="0x131B968", VA="0x131B968")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F574", Offset="0x106F574")]
	private void <ShowAssetBundleFailDialog>b__11_0()
	{
	}

	[Address(RVA="0x131B9CC", Offset="0x131B9CC", VA="0x131B9CC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F584", Offset="0x106F584")]
	private void <ShowAutoAuthenticateTimeOutDialog>b__12_0()
	{
	}

	[Address(RVA="0x131B904", Offset="0x131B904", VA="0x131B904")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F564", Offset="0x106F564")]
	private void <ShowDiskFullDialog>b__10_0()
	{
	}

	[Address(RVA="0x131B774", Offset="0x131B774", VA="0x131B774")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F524", Offset="0x106F524")]
	private void <ShowFatalRecoveryDialog>b__6_0()
	{
	}

	[Address(RVA="0x131B8A0", Offset="0x131B8A0", VA="0x131B8A0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F554", Offset="0x106F554")]
	private void <ShowInvalidAuthTokenDialog>b__9_0()
	{
	}

	[Address(RVA="0x131B83C", Offset="0x131B83C", VA="0x131B83C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F544", Offset="0x106F544")]
	private void <ShowPermBannedDialog>b__8_0()
	{
	}

	[Address(RVA="0x131B7D8", Offset="0x131B7D8", VA="0x131B7D8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F534", Offset="0x106F534")]
	private void <ShowTempBannedDialog>b__7_0()
	{
	}

	[Address(RVA="0x131A7FC", Offset="0x131A7FC", VA="0x131A7FC", Slot="10")]
	public void HandleDispatchAction(DServiceNetworkFailureAction action)
	{
	}

	[Address(RVA="0x131A934", Offset="0x131A934", VA="0x131A934", Slot="11")]
	public void HandleDispatchAction(DFatalAction action)
	{
	}

	[Address(RVA="0x131B404", Offset="0x131B404", VA="0x131B404", Slot="12")]
	public void HandleDispatchAction(DTitleViewAction action)
	{
	}

	[Address(RVA="0x131B43C", Offset="0x131B43C", VA="0x131B43C", Slot="13")]
	public void HandleDispatchAction(DServerInMaintenanceModeAction action)
	{
	}

	[Address(RVA="0x131B688", Offset="0x131B688", VA="0x131B688")]
	private void LaunchAppStore()
	{
	}

	[Address(RVA="0x131B45C", Offset="0x131B45C", VA="0x131B45C")]
	public void ServerUnderMaintenance(string rawMessageOverride, string messageOverride, string maintenanceDuration, bool fatal = false)
	{
	}

	[Address(RVA="0x131B008", Offset="0x131B008", VA="0x131B008")]
	private void ShowAssetBundleFailDialog()
	{
	}

	[Address(RVA="0x131B154", Offset="0x131B154", VA="0x131B154")]
	private void ShowAutoAuthenticateTimeOutDialog(DFatalAction.ReasonType reason)
	{
	}

	[Address(RVA="0x131AEBC", Offset="0x131AEBC", VA="0x131AEBC")]
	private void ShowDiskFullDialog()
	{
	}

	[Address(RVA="0x131B2B8", Offset="0x131B2B8", VA="0x131B2B8")]
	private void ShowFatalRecoveryDialog()
	{
	}

	[Address(RVA="0x131AD70", Offset="0x131AD70", VA="0x131AD70")]
	private void ShowInvalidAuthTokenDialog()
	{
	}

	[Address(RVA="0x131AC1C", Offset="0x131AC1C", VA="0x131AC1C")]
	private void ShowPermBannedDialog()
	{
	}

	[Address(RVA="0x131AAC8", Offset="0x131AAC8", VA="0x131AAC8")]
	private void ShowTempBannedDialog()
	{
	}

	[Address(RVA="0x131A974", Offset="0x131A974", VA="0x131A974")]
	private void ShowUpdateRequiredDialog()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BD0C", Offset="0x104BD0C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public SystemDialogManager <>4__this;

		[FieldOffset(Offset="0x18")]
		public DServiceNetworkFailureAction action;

		[FieldOffset(Offset="0x20")]
		public Action <>9__1;

		[FieldOffset(Offset="0x28")]
		public Action <>9__2;

		[Address(RVA="0x131A92C", Offset="0x131A92C", VA="0x131A92C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x131BA30", Offset="0x131BA30", VA="0x131BA30")]
		internal void <HandleDispatchAction>b__0(DServerMaintenance finished)
		{
		}

		[Address(RVA="0x131BE0C", Offset="0x131BE0C", VA="0x131BE0C")]
		internal void <HandleDispatchAction>b__1()
		{
		}

		[Address(RVA="0x131BE80", Offset="0x131BE80", VA="0x131BE80")]
		internal void <HandleDispatchAction>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BD1C", Offset="0x104BD1C")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public bool fatal;

		[FieldOffset(Offset="0x18")]
		public SystemDialogManager <>4__this;

		[Address(RVA="0x131B680", Offset="0x131B680", VA="0x131B680")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x131BEF4", Offset="0x131BEF4", VA="0x131BEF4")]
		internal void <ServerUnderMaintenance>b__0()
		{
		}
	}
}