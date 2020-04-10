using Glunies;
using Il2CppDummyDll;
using System;

public class DeepLinkHandler : ILoggable<LogCategory>, IDispatchHandler<DDeepLinkAction>, IDispatchHandler, IDispatchHandler<DDeepLinkUriAction>, IDispatchHandler<DApplicationFocusAction>
{
	[FieldOffset(Offset="0x0")]
	public const string DEEP_LINK_URI_SCHEME = "gluprojectcastle";

	[FieldOffset(Offset="0x0")]
	public const string DEEP_LINK_URI_HOST = "deeplink";

	[FieldOffset(Offset="0x0")]
	private const string CAMPAIGN_NEXT_NODE_SENTINAL = "next";

	[Attribute(Name="InjectAttribute", RVA="0x1057AB4", Offset="0x1057AB4")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1057AC4", Offset="0x1057AC4")]
	[FieldOffset(Offset="0x18")]
	private GameStateMachine _gameStateMachine;

	[Attribute(Name="InjectAttribute", RVA="0x1057AD4", Offset="0x1057AD4")]
	[FieldOffset(Offset="0x20")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1057AE4", Offset="0x1057AE4")]
	[FieldOffset(Offset="0x28")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1057AF4", Offset="0x1057AF4")]
	[FieldOffset(Offset="0x30")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1057B04", Offset="0x1057B04")]
	[FieldOffset(Offset="0x38")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1057B14", Offset="0x1057B14")]
	[FieldOffset(Offset="0x40")]
	private CampaignUtility _campaignUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1057B24", Offset="0x1057B24")]
	[FieldOffset(Offset="0x48")]
	private ContextualMessageController _contextualMessageController;

	[FieldOffset(Offset="0x50")]
	private bool _processLinksOnFocus;

	public LogCategory LogCategory
	{
		[Address(RVA="0x11FFF0C", Offset="0x11FFF0C", VA="0x11FFF0C", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x1202600", Offset="0x1202600", VA="0x1202600")]
	public DeepLinkHandler()
	{
	}

	[Address(RVA="0x11FFF84", Offset="0x11FFF84", VA="0x11FFF84")]
	public void EnableAppFocusLinkProcessing(bool enable)
	{
	}

	[Address(RVA="0x19A0D64", Offset="0x19A0D64", VA="0x19A0D64")]
	private void EnterState<TState>(GameStateTransitionContext context = // 
	// Current member / type: System.Void DeepLinkHandler::EnterState(Glunies.GameStateTransitionContext)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void EnterState(Glunies.GameStateTransitionContext)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1201114", Offset="0x1201114", VA="0x1201114")]
	private bool GoToAchievements(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1200A8C", Offset="0x1200A8C", VA="0x1200A8C")]
	private bool GoToCampaign(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1201B08", Offset="0x1201B08", VA="0x1201B08")]
	private bool GoToClubDonations(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1202078", Offset="0x1202078", VA="0x1202078")]
	private bool GoToClubDungeon(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x12019EC", Offset="0x12019EC", VA="0x12019EC")]
	private bool GoToClubHub(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1201974", Offset="0x1201974", VA="0x1201974")]
	private bool GoToClubList(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1202418", Offset="0x1202418", VA="0x1202418")]
	private bool GoToClubWar(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1200F18", Offset="0x1200F18", VA="0x1200F18")]
	private bool GoToDailyActivities(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x12011EC", Offset="0x12011EC", VA="0x12011EC")]
	private bool GoToDailyEvents(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x12018F8", Offset="0x12018F8", VA="0x12018F8")]
	private bool GoToDailyLogin(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1200FF0", Offset="0x1200FF0", VA="0x1200FF0")]
	private bool GoToFriends(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x120189C", Offset="0x120189C", VA="0x120189C")]
	private bool GoToHome(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x120212C", Offset="0x120212C", VA="0x120212C")]
	private bool GoToInbox(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x12008C0", Offset="0x12008C0", VA="0x12008C0")]
	private bool GoToInventory(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x120229C", Offset="0x120229C", VA="0x120229C")]
	private bool GoToKothLobby(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1202188", Offset="0x1202188", VA="0x1202188")]
	private bool GoToPassportSeason(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1201658", Offset="0x1201658", VA="0x1201658")]
	private bool GoToPvp(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x12012B4", Offset="0x12012B4", VA="0x12012B4")]
	private bool GoToScheduledEvents(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1201470", Offset="0x1201470", VA="0x1201470")]
	private bool GoToShipments(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x12022F8", Offset="0x12022F8", VA="0x12022F8")]
	private bool GoToSorcererStone(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1201BB0", Offset="0x1201BB0", VA="0x1201BB0")]
	private bool GoToSpellInventory(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1201F40", Offset="0x1201F40", VA="0x1201F40")]
	private bool GoToSpellUpgrade(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1201538", Offset="0x1201538", VA="0x1201538")]
	private bool GoToStore(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1202474", Offset="0x1202474", VA="0x1202474")]
	private bool GoToStoreTab(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x12016D0", Offset="0x12016D0", VA="0x12016D0")]
	private bool GoToTower(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x1201C34", Offset="0x1201C34", VA="0x1201C34")]
	private bool GoToUnitAbilityUpgrade(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x120091C", Offset="0x120091C", VA="0x120091C")]
	private bool GoToUnitDetails(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x12000E0", Offset="0x12000E0", VA="0x12000E0", Slot="7")]
	public void HandleDispatchAction(DApplicationFocusAction action)
	{
	}

	[Address(RVA="0x12000F8", Offset="0x12000F8", VA="0x12000F8", Slot="5")]
	public void HandleDispatchAction(DDeepLinkAction action)
	{
	}

	[Address(RVA="0x12005AC", Offset="0x12005AC", VA="0x12005AC", Slot="6")]
	public void HandleDispatchAction(DDeepLinkUriAction action)
	{
	}

	[Address(RVA="0x11FFF14", Offset="0x11FFF14", VA="0x11FFF14")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1200128", Offset="0x1200128", VA="0x1200128")]
	private bool ProcessDeepLinkAction(DDeepLinkAction action)
	{
		return new bool();
	}

	[Address(RVA="0x120007C", Offset="0x120007C", VA="0x120007C")]
	private bool ProcessDeepLinkFromExternalSource(string deepLinkKey)
	{
		return new bool();
	}

	[Address(RVA="0x11FFF90", Offset="0x11FFF90", VA="0x11FFF90")]
	public bool ProcessDeepLinkUri()
	{
		return new bool();
	}

	[Address(RVA="0x12005B0", Offset="0x12005B0", VA="0x12005B0")]
	private bool ProcessDeepLinkUriString(string deepLinkKey)
	{
		return new bool();
	}

	[Address(RVA="0x11FFF4C", Offset="0x11FFF4C", VA="0x11FFF4C")]
	public void Shutdown()
	{
	}
}