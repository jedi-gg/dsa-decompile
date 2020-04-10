using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class AppRatingController : IAssetDependentLifecycleObject, IDispatchHandler<DPlayerChangeAction>, IDispatchHandler, IDispatchHandler<DCampaignFirstTimeCompletedAction>, IDispatchHandler<DAppRatingViewAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1052590", Offset="0x1052590")]
	[FieldOffset(Offset="0x10")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x10525A0", Offset="0x10525A0")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x10525B0", Offset="0x10525B0")]
	[FieldOffset(Offset="0x20")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x10525C0", Offset="0x10525C0")]
	[FieldOffset(Offset="0x28")]
	private ContextualMessageController _contextualMessageController;

	[FieldOffset(Offset="0x30")]
	private AppRatingView _appRatingView;

	[FieldOffset(Offset="0x38")]
	private bool _readyToShowAppRatingPrompt;

	[FieldOffset(Offset="0x39")]
	private bool _isShutdown;

	[Address(RVA="0x115CB18", Offset="0x115CB18", VA="0x115CB18")]
	public AppRatingController()
	{
	}

	[Address(RVA="0x115CB20", Offset="0x115CB20", VA="0x115CB20")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DFD8", Offset="0x106DFD8")]
	private void <ShowAppRatingPrompt>b__5_0(AppRatingView view)
	{
	}

	[Address(RVA="0x115C7F0", Offset="0x115C7F0", VA="0x115C7F0")]
	private bool CampaignIdentifierTriggersAppRating(AppRatingData appRatingData, CampaignIdentifier campaignIdentifier)
	{
		return new bool();
	}

	[Address(RVA="0x115C488", Offset="0x115C488", VA="0x115C488", Slot="8")]
	public void HandleDispatchAction(DPlayerChangeAction action)
	{
	}

	[Address(RVA="0x115C8E0", Offset="0x115C8E0", VA="0x115C8E0", Slot="9")]
	public void HandleDispatchAction(DCampaignFirstTimeCompletedAction action)
	{
	}

	[Address(RVA="0x115C9E0", Offset="0x115C9E0", VA="0x115C9E0", Slot="10")]
	public void HandleDispatchAction(DAppRatingViewAction action)
	{
	}

	[Address(RVA="0x115C22C", Offset="0x115C22C", VA="0x115C22C", Slot="4")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x115C30C", Offset="0x115C30C", VA="0x115C30C")]
	public bool IsReadyToShowAppRatingPrompt()
	{
		return new bool();
	}

	[Address(RVA="0x115CB10", Offset="0x115CB10", VA="0x115CB10")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x115C230", Offset="0x115C230", VA="0x115C230", Slot="6")]
	public void LoadAssets(Action finished)
	{
	}

	[Address(RVA="0x115C2A0", Offset="0x115C2A0", VA="0x115C2A0", Slot="7")]
	public void ReleaseAssets()
	{
	}

	[Address(RVA="0x115C350", Offset="0x115C350", VA="0x115C350")]
	public void ShowAppRatingPrompt()
	{
	}

	[Address(RVA="0x115C294", Offset="0x115C294", VA="0x115C294", Slot="5")]
	public void Shutdown()
	{
	}
}