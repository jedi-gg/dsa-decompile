using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ClubListController : AFeatureController, IDispatchHandler<DClubListViewAction>, IDispatchHandler, IDispatchHandler<DClubListClubAction>, IDispatchHandler<DClubListSearchAction>, IDispatchHandler<DClubListItemClickedAction>, IDispatchHandler<DPlayerClubChangedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105641C", Offset="0x105641C")]
	[FieldOffset(Offset="0x68")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105642C", Offset="0x105642C")]
	[FieldOffset(Offset="0x70")]
	private ClubService _clubService;

	[Attribute(Name="InjectAttribute", RVA="0x105643C", Offset="0x105643C")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105644C", Offset="0x105644C")]
	[FieldOffset(Offset="0x80")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105645C", Offset="0x105645C")]
	[FieldOffset(Offset="0x88")]
	private ClubDomainController _clubDc;

	[FieldOffset(Offset="0x90")]
	private ClubListView _view;

	[FieldOffset(Offset="0x98")]
	private List<Club> _clubs;

	[FieldOffset(Offset="0xA0")]
	private FindClubsRequest _thisPageRequest;

	[FieldOffset(Offset="0xA8")]
	private FindClubsRequest _nextPageRequest;

	[FieldOffset(Offset="0xB0")]
	private Stack<DClubPage> _prevPages;

	[FieldOffset(Offset="0xB8")]
	private DLoadSocialFeatureAction? _backFeature;

	[Address(RVA="0x125B6E4", Offset="0x125B6E4", VA="0x125B6E4")]
	public ClubListController()
	{
	}

	[Address(RVA="0x125B6EC", Offset="0x125B6EC", VA="0x125B6EC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EE34", Offset="0x106EE34")]
	private void <FindClubsByNextPage>b__10_0()
	{
	}

	[Address(RVA="0x125B71C", Offset="0x125B71C", VA="0x125B71C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EE44", Offset="0x106EE44")]
	private void <FindClubsByPrevPage>b__11_0()
	{
	}

	[Address(RVA="0x125B0A8", Offset="0x125B0A8", VA="0x125B0A8", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x125B260", Offset="0x125B260", VA="0x125B260")]
	private void FindClubsAsync(FindClubsRequest request, Action finished = // 
	// Current member / type: System.Void ClubListController::FindClubsAsync(Serverproto.FindClubsRequest,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void FindClubsAsync(Serverproto.FindClubsRequest,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x125A49C", Offset="0x125A49C", VA="0x125A49C")]
	private void FindClubsByName(string searchString)
	{
	}

	[Address(RVA="0x1259DA0", Offset="0x1259DA0", VA="0x1259DA0")]
	private void FindClubsByNextPage()
	{
	}

	[Address(RVA="0x1259E94", Offset="0x1259E94", VA="0x1259E94")]
	private void FindClubsByPrevPage()
	{
	}

	[Address(RVA="0x125B198", Offset="0x125B198", VA="0x125B198", Slot="9")]
	protected override void HandleBackButton(AView view)
	{
	}

	[Address(RVA="0x1259BC8", Offset="0x1259BC8", VA="0x1259BC8", Slot="13")]
	public void HandleDispatchAction(DClubListViewAction action)
	{
	}

	[Address(RVA="0x1259F40", Offset="0x1259F40", VA="0x1259F40", Slot="14")]
	public void HandleDispatchAction(DClubListClubAction action)
	{
	}

	[Address(RVA="0x125A498", Offset="0x125A498", VA="0x125A498", Slot="15")]
	public void HandleDispatchAction(DClubListSearchAction action)
	{
	}

	[Address(RVA="0x125A57C", Offset="0x125A57C", VA="0x125A57C", Slot="16")]
	public void HandleDispatchAction(DClubListItemClickedAction action)
	{
	}

	[Address(RVA="0x125AE68", Offset="0x125AE68", VA="0x125AE68", Slot="17")]
	public void HandleDispatchAction(DPlayerClubChangedAction action)
	{
	}

	[Address(RVA="0x1259908", Offset="0x1259908", VA="0x1259908", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x125A580", Offset="0x125A580", VA="0x125A580")]
	private void ShowActionPopup(Club clickedClub, ClubListItem clickedItem)
	{
	}

	[Address(RVA="0x1259BA0", Offset="0x1259BA0", VA="0x1259BA0", Slot="7")]
	public override void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B6FC", Offset="0x104B6FC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubListController <>4__this;

		[FieldOffset(Offset="0x18")]
		public SocialGameState.ClubListContext clubListContext;

		[FieldOffset(Offset="0x20")]
		public GameStateTransitionContext context;

		[Address(RVA="0x1259B98", Offset="0x1259B98", VA="0x1259B98")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x125B7A0", Offset="0x125B7A0", VA="0x125B7A0")]
		internal void <Initialize>b__0(ClubListView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B70C", Offset="0x104B70C")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubListController <>4__this;

		[FieldOffset(Offset="0x18")]
		public FindClubsRequest request;

		[FieldOffset(Offset="0x20")]
		public Action finished;

		[Address(RVA="0x125B4A8", Offset="0x125B4A8", VA="0x125B4A8")]
		public <>c__DisplayClass12_0()
		{
		}

		[Address(RVA="0x125BC9C", Offset="0x125BC9C", VA="0x125BC9C")]
		internal void <FindClubsAsync>b__0(FindClubsResponse response)
		{
		}

		[Address(RVA="0x125C190", Offset="0x125C190", VA="0x125C190")]
		internal void <FindClubsAsync>b__1(long errorCode)
		{
		}

		[Address(RVA="0x125C340", Offset="0x125C340", VA="0x125C340")]
		internal void <FindClubsAsync>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B71C", Offset="0x104B71C")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubListController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Club clickedClub;

		[Address(RVA="0x125B648", Offset="0x125B648", VA="0x125B648")]
		public <>c__DisplayClass13_0()
		{
		}

		[Address(RVA="0x125C498", Offset="0x125C498", VA="0x125C498")]
		internal void <ShowActionPopup>b__0()
		{
		}

		[Address(RVA="0x125C66C", Offset="0x125C66C", VA="0x125C66C")]
		internal void <ShowActionPopup>b__2()
		{
		}

		[Address(RVA="0x125C3B0", Offset="0x125C3B0", VA="0x125C3B0")]
		internal void <ShowActionPopup>b__3()
		{
		}

		[Address(RVA="0x125C584", Offset="0x125C584", VA="0x125C584")]
		internal void <ShowActionPopup>g__EnterClubHub|1()
		{
		}
	}
}