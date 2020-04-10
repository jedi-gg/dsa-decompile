using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using Zenject;

public class SocialGameState : AGameState, IDispatchHandler<DTabViewIndexSelectedAction>, IDispatchHandler, IDispatchHandler<DLoadSocialFeatureAction>, IDispatchHandler<DSocialControllerInitialized>
{
	[FieldOffset(Offset="0x0")]
	private readonly static Dictionary<SocialGameState.Tab, LockableFeature> s_tabToLockableFeature;

	[Attribute(Name="InjectAttribute", RVA="0x105C4F0", Offset="0x105C4F0")]
	[FieldOffset(Offset="0x30")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105C500", Offset="0x105C500")]
	[FieldOffset(Offset="0x38")]
	private DiContainer _diContainer;

	[Attribute(Name="InjectAttribute", RVA="0x105C510", Offset="0x105C510")]
	[FieldOffset(Offset="0x40")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x105C520", Offset="0x105C520")]
	[FieldOffset(Offset="0x48")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105C530", Offset="0x105C530")]
	[FieldOffset(Offset="0x50")]
	private HudController _hudController;

	[Attribute(Name="InjectAttribute", RVA="0x105C540", Offset="0x105C540")]
	[FieldOffset(Offset="0x58")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x60")]
	private LogCategory _logCategory;

	[FieldOffset(Offset="0x68")]
	private TabViewController<SocialTabView> _tabViewController;

	[FieldOffset(Offset="0x70")]
	private bool _dispatchedVgpAction;

	public override LogCategory LogCategory
	{
		[Address(RVA="0x14C7E78", Offset="0x14C7E78", VA="0x14C7E78", Slot="7")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x14C88C0", Offset="0x14C88C0", VA="0x14C88C0")]
	static SocialGameState()
	{
	}

	[Address(RVA="0x14C88B0", Offset="0x14C88B0", VA="0x14C88B0")]
	public SocialGameState()
	{
	}

	[Address(RVA="0x14C7E80", Offset="0x14C7E80", VA="0x14C7E80", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	[Address(RVA="0x14C8008", Offset="0x14C8008", VA="0x14C8008", Slot="5")]
	public override void Exiting()
	{
	}

	[Address(RVA="0x14C809C", Offset="0x14C809C", VA="0x14C809C", Slot="12")]
	public void HandleDispatchAction(DTabViewIndexSelectedAction action)
	{
	}

	[Address(RVA="0x14C84C4", Offset="0x14C84C4", VA="0x14C84C4", Slot="13")]
	public void HandleDispatchAction(DLoadSocialFeatureAction action)
	{
	}

	[Address(RVA="0x14C87CC", Offset="0x14C87CC", VA="0x14C87CC", Slot="14")]
	public void HandleDispatchAction(DSocialControllerInitialized action)
	{
	}

	[Address(RVA="0x14C8140", Offset="0x14C8140", VA="0x14C8140")]
	private void LoadDefaultFeatureForTab(SocialGameState.Tab state, SocialGameState.AContext context = // 
	// Current member / type: System.Void SocialGameState::LoadDefaultFeatureForTab(SocialGameState/Tab,SocialGameState/AContext)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void LoadDefaultFeatureForTab(SocialGameState/Tab,SocialGameState/AContext)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x14C856C", Offset="0x14C856C", VA="0x14C856C")]
	private void LoadFeature(SocialGameState.Feature feature, SocialGameState.AContext context = // 
	// Current member / type: System.Void SocialGameState::LoadFeature(SocialGameState/Feature,SocialGameState/AContext)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void LoadFeature(SocialGameState/Feature,SocialGameState/AContext)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C9CC", Offset="0x104C9CC")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public SocialGameState <>4__this;

		[FieldOffset(Offset="0x18")]
		public SocialGameState.AContext socialContext;

		[Address(RVA="0x14C8000", Offset="0x14C8000", VA="0x14C8000")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x14C8A00", Offset="0x14C8A00", VA="0x14C8A00")]
		internal void <Entering>b__0()
		{
		}
	}

	public abstract class AContext : GameStateTransitionContext
	{
		public abstract SocialGameState.Tab SocialTab
		{
			get;
		}

		[Address(RVA="0x14C8B44", Offset="0x14C8B44", VA="0x14C8B44")]
		protected AContext()
		{
		}
	}

	public class ChatContext : SocialGameState.AContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly ChatDomainController.Channel Channel;

		public override SocialGameState.Tab SocialTab
		{
			[Address(RVA="0x14C8B4C", Offset="0x14C8B4C", VA="0x14C8B4C", Slot="4")]
			get
			{
				return new SocialGameState.Tab();
			}
		}

		[Address(RVA="0x14C8B54", Offset="0x14C8B54", VA="0x14C8B54")]
		public ChatContext(ChatDomainController.Channel channel)
		{
		}
	}

	public class ClubContext : SocialGameState.AContext
	{
		public override SocialGameState.Tab SocialTab
		{
			[Address(RVA="0x14C8B80", Offset="0x14C8B80", VA="0x14C8B80", Slot="4")]
			get
			{
				return new SocialGameState.Tab();
			}
		}

		[Address(RVA="0x14C8B88", Offset="0x14C8B88", VA="0x14C8B88")]
		public ClubContext()
		{
		}
	}

	public class ClubHubContext : SocialGameState.ClubContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly Club Club;

		[FieldOffset(Offset="0x28")]
		public readonly string ClubId;

		[FieldOffset(Offset="0x30")]
		public readonly ClubHubRosterSortMode RosterSortMode;

		[Address(RVA="0x14C8874", Offset="0x14C8874", VA="0x14C8874")]
		public ClubHubContext(string clubId, ClubHubRosterSortMode rosterSortMode = -1)
		{
		}

		[Address(RVA="0x14C8B90", Offset="0x14C8B90", VA="0x14C8B90")]
		public ClubHubContext(Club club, ClubHubRosterSortMode rosterSortMode = -1)
		{
		}
	}

	public class ClubListContext : SocialGameState.ClubContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly string SearchText;

		[FieldOffset(Offset="0x28")]
		public readonly List<Club> Clubs;

		[FieldOffset(Offset="0x30")]
		public readonly FindClubsRequest NextPageRequest;

		[FieldOffset(Offset="0x38")]
		public readonly FindClubsRequest ThisPageRequest;

		[FieldOffset(Offset="0x40")]
		public readonly Stack<DClubPage> PrevPages;

		[FieldOffset(Offset="0x48")]
		public readonly DLoadSocialFeatureAction? BackFeature;

		[Address(RVA="0x14C8BE8", Offset="0x14C8BE8", VA="0x14C8BE8")]
		public ClubListContext()
		{
		}

		[Address(RVA="0x14C8BF0", Offset="0x14C8BF0", VA="0x14C8BF0")]
		public ClubListContext(DLoadSocialFeatureAction backFeature)
		{
		}

		[Address(RVA="0x14C8C88", Offset="0x14C8C88", VA="0x14C8C88")]
		public ClubListContext(string searchText, List<Club> clubs, FindClubsRequest nextPageRequest, FindClubsRequest thisPageRequest, Stack<DClubPage> prevPages)
		{
		}
	}

	public class ClubRequestsContext : SocialGameState.AContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly Club Club;

		public override SocialGameState.Tab SocialTab
		{
			[Address(RVA="0x14C8CDC", Offset="0x14C8CDC", VA="0x14C8CDC", Slot="4")]
			get
			{
				return new SocialGameState.Tab();
			}
		}

		[Address(RVA="0x14C8CE4", Offset="0x14C8CE4", VA="0x14C8CE4")]
		public ClubRequestsContext()
		{
		}

		[Address(RVA="0x14C8CEC", Offset="0x14C8CEC", VA="0x14C8CEC")]
		public ClubRequestsContext(Club club)
		{
		}
	}

	public enum Feature
	{
		[FieldOffset(Offset="0x0")]
		FriendsList,
		[FieldOffset(Offset="0x0")]
		ClubList,
		[FieldOffset(Offset="0x0")]
		ClubHub,
		[FieldOffset(Offset="0x0")]
		ClubRequests,
		[FieldOffset(Offset="0x0")]
		Chat,
		[FieldOffset(Offset="0x0")]
		Invites
	}

	public class FriendsContext : SocialGameState.AContext
	{
		public override SocialGameState.Tab SocialTab
		{
			[Address(RVA="0x14C8D18", Offset="0x14C8D18", VA="0x14C8D18", Slot="4")]
			get
			{
				return new SocialGameState.Tab();
			}
		}

		[Address(RVA="0x14C8D20", Offset="0x14C8D20", VA="0x14C8D20")]
		public FriendsContext()
		{
		}
	}

	public class FriendsDeepLinkContext : SocialGameState.FriendsContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly string InviteLinkFriendId;

		[FieldOffset(Offset="0x28")]
		public readonly string InviteLinkToken;

		[Address(RVA="0x14C8D28", Offset="0x14C8D28", VA="0x14C8D28")]
		public FriendsDeepLinkContext(string inviteLinkFriendId, string inviteLinkToken)
		{
		}
	}

	public class InvitesContext : SocialGameState.AContext
	{
		public override SocialGameState.Tab SocialTab
		{
			[Address(RVA="0x14C8D60", Offset="0x14C8D60", VA="0x14C8D60", Slot="4")]
			get
			{
				return new SocialGameState.Tab();
			}
		}

		[Address(RVA="0x14C8D68", Offset="0x14C8D68", VA="0x14C8D68")]
		public InvitesContext()
		{
		}
	}

	public enum Tab
	{
		[FieldOffset(Offset="0x0")]
		Club,
		[FieldOffset(Offset="0x0")]
		ClubRequests,
		[FieldOffset(Offset="0x0")]
		Friends,
		[FieldOffset(Offset="0x0")]
		Chat,
		[FieldOffset(Offset="0x0")]
		Invites
	}
}