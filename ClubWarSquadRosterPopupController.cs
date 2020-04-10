using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ClubWarSquadRosterPopupController : APopupController, IDispatchHandler<DClubWarSquadRosterPopupViewAction>, IDispatchHandler, IDispatchHandler<DClubWarSquadListItemAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1057478", Offset="0x1057478")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1057488", Offset="0x1057488")]
	[FieldOffset(Offset="0x40")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x1057498", Offset="0x1057498")]
	[FieldOffset(Offset="0x48")]
	private ClubService _clubService;

	[Attribute(Name="InjectAttribute", RVA="0x10574A8", Offset="0x10574A8")]
	[FieldOffset(Offset="0x50")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x10574B8", Offset="0x10574B8")]
	[FieldOffset(Offset="0x58")]
	private Unit.Factory _unitFactory;

	[Attribute(Name="InjectAttribute", RVA="0x10574C8", Offset="0x10574C8")]
	[FieldOffset(Offset="0x60")]
	private Spell.Factory _spellFactory;

	[Attribute(Name="InjectAttribute", RVA="0x10574D8", Offset="0x10574D8")]
	[FieldOffset(Offset="0x68")]
	private ClubWarDomainController _clubWarDc;

	[Attribute(Name="InjectAttribute", RVA="0x10574E8", Offset="0x10574E8")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x78")]
	private ClubWarSquadRosterPopupView _view;

	[FieldOffset(Offset="0x80")]
	private ClubWarSquadRosterPopupController.Context _context;

	[FieldOffset(Offset="0x88")]
	private List<ClubWarSquad> _allSquads;

	[FieldOffset(Offset="0x90")]
	private List<ClubWarSquad> _localPlayerSquads;

	[FieldOffset(Offset="0x98")]
	private List<ClubWarSquad> _localPlayersRebuildingSquads;

	[Address(RVA="0x14E022C", Offset="0x14E022C", VA="0x14E022C")]
	public ClubWarSquadRosterPopupController()
	{
	}

	[Address(RVA="0x14E0234", Offset="0x14E0234", VA="0x14E0234")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F304", Offset="0x106F304")]
	private void <FetchSquadRoster>b__6_0(ClubWarClubDefensesResponse response)
	{
	}

	[Address(RVA="0x14E0670", Offset="0x14E0670", VA="0x14E0670")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F314", Offset="0x106F314")]
	private int <SetSquadLists>b__7_0(ClubWarSquad a, ClubWarSquad b)
	{
		return new int();
	}

	[Address(RVA="0x14DD970", Offset="0x14DD970", VA="0x14DD970")]
	private void AddSquad()
	{
	}

	[Address(RVA="0x14DE2C8", Offset="0x14DE2C8", VA="0x14DE2C8")]
	private void AssignSquadToNode(string squadId, string nodeId, bool closeWhenDone)
	{
	}

	[Address(RVA="0x14DF2D8", Offset="0x14DF2D8", VA="0x14DF2D8")]
	private bool CreateSquadAllowed(out string reasonKey)
	{
		reasonKey = null;
		return new bool();
	}

	[Address(RVA="0x14DD7B4", Offset="0x14DD7B4", VA="0x14DD7B4")]
	private void DeleteSquad(string squadId)
	{
	}

	[Address(RVA="0x14DDB50", Offset="0x14DDB50", VA="0x14DDB50")]
	private void EditSquad(string squadId)
	{
	}

	[Address(RVA="0x14DECD0", Offset="0x14DECD0", VA="0x14DECD0")]
	private void FetchSquadRoster(Action finished)
	{
	}

	[Address(RVA="0x14DD628", Offset="0x14DD628", VA="0x14DD628", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x14DF564", Offset="0x14DF564", VA="0x14DF564")]
	private string GetHeaderText()
	{
		return null;
	}

	[Address(RVA="0x14DF6F8", Offset="0x14DF6F8", VA="0x14DF6F8")]
	private ClubWarSquad GetSquad(string squadId)
	{
		return null;
	}

	[Address(RVA="0x14DEB14", Offset="0x14DEB14", VA="0x14DEB14")]
	private void GotoNode(string squadId)
	{
	}

	[Address(RVA="0x14DD630", Offset="0x14DD630", VA="0x14DD630", Slot="14")]
	public void HandleDispatchAction(DClubWarSquadRosterPopupViewAction action)
	{
	}

	[Address(RVA="0x14DD6B8", Offset="0x14DD6B8", VA="0x14DD6B8", Slot="15")]
	public void HandleDispatchAction(DClubWarSquadListItemAction action)
	{
	}

	[Address(RVA="0x14DD238", Offset="0x14DD238", VA="0x14DD238", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x14DF1D8", Offset="0x14DF1D8", VA="0x14DF1D8")]
	private void PopulateView()
	{
	}

	[Address(RVA="0x14DF8D4", Offset="0x14DF8D4", VA="0x14DF8D4")]
	private void SendSquadTelemetry(long referenceId, ClubWarSquad squad)
	{
	}

	[Address(RVA="0x14DEDDC", Offset="0x14DEDDC", VA="0x14DEDDC")]
	private void SetSquadLists(List<ClubWarSquad> allSquads)
	{
	}

	[Address(RVA="0x14DD540", Offset="0x14DD540", VA="0x14DD540", Slot="9")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x14DD5BC", Offset="0x14DD5BC", VA="0x14DD5BC", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x14DD63C", Offset="0x14DD63C", VA="0x14DD63C")]
	private void ToggleFilter()
	{
	}

	[Address(RVA="0x14DF84C", Offset="0x14DF84C", VA="0x14DF84C")]
	private bool UnderCommitMax()
	{
		return new bool();
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BB6C", Offset="0x104BB6C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarSquadRosterPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x14DD538", Offset="0x14DD538", VA="0x14DD538")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x14E0944", Offset="0x14E0944", VA="0x14E0944")]
		internal void <Initialize>b__0(Action jobFinished)
		{
		}

		[Address(RVA="0x14E0A38", Offset="0x14E0A38", VA="0x14E0A38")]
		internal void <Initialize>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BB7C", Offset="0x104BB7C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public ClubWarSquadRosterPopupController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x14E0A30", Offset="0x14E0A30", VA="0x14E0A30")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x14E0BDC", Offset="0x14E0BDC", VA="0x14E0BDC")]
		internal void <Initialize>b__2(ClubWarSquadRosterPopupView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BB8C", Offset="0x104BB8C")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarSquadRosterPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public string squadId;

		[FieldOffset(Offset="0x20")]
		public Predicate<ClubWarSquad> <>9__4;

		[Address(RVA="0x14DF6F0", Offset="0x14DF6F0", VA="0x14DF6F0")]
		public <>c__DisplayClass10_0()
		{
		}

		[Address(RVA="0x14E0E3C", Offset="0x14E0E3C", VA="0x14E0E3C")]
		internal void <DeleteSquad>b__1(ClubWarDeleteDefenseResponse response)
		{
		}

		[Address(RVA="0x14E11A8", Offset="0x14E11A8", VA="0x14E11A8")]
		internal void <DeleteSquad>b__2(long errorCode)
		{
		}

		[Address(RVA="0x14E126C", Offset="0x14E126C", VA="0x14E126C")]
		internal void <DeleteSquad>b__3()
		{
		}

		[Address(RVA="0x14E1168", Offset="0x14E1168", VA="0x14E1168")]
		internal bool <DeleteSquad>b__4(ClubWarSquad squad)
		{
			return new bool();
		}

		[Address(RVA="0x14E0C44", Offset="0x14E0C44", VA="0x14E0C44")]
		internal void <DeleteSquad>g__confirmedDeleteSquad|0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BB9C", Offset="0x104BB9C")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarSquadRosterPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ClubWarSquad squad;

		[FieldOffset(Offset="0x20")]
		public string nodeId;

		[FieldOffset(Offset="0x28")]
		public bool closeWhenDone;

		[Address(RVA="0x14DF844", Offset="0x14DF844", VA="0x14DF844")]
		public <>c__DisplayClass13_0()
		{
		}

		[Address(RVA="0x14E12E0", Offset="0x14E12E0", VA="0x14E12E0")]
		internal void <AssignSquadToNode>b__0(ClubWarSetDefenseResponse response)
		{
		}

		[Address(RVA="0x14E15B0", Offset="0x14E15B0", VA="0x14E15B0")]
		internal void <AssignSquadToNode>b__1(long errorCode)
		{
		}

		[Address(RVA="0x14E16DC", Offset="0x14E16DC", VA="0x14E16DC")]
		internal void <AssignSquadToNode>b__2()
		{
		}
	}

	public enum ActionMode
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		Assign,
		[FieldOffset(Offset="0x0")]
		Edit
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarSquadRosterPopupController.Filter Filter;

		[FieldOffset(Offset="0x14")]
		public ClubWarSquadRosterPopupController.ActionMode ActionMode;

		[FieldOffset(Offset="0x18")]
		public string OpenedFromNodeId;

		[FieldOffset(Offset="0x20")]
		public int NumDefensesOnNode;

		[Address(RVA="0x14D3E9C", Offset="0x14D3E9C", VA="0x14D3E9C")]
		public Context()
		{
		}
	}

	public enum Filter
	{
		[FieldOffset(Offset="0x0")]
		LocalPlayerOnly,
		[FieldOffset(Offset="0x0")]
		AllClubSquads
	}
}