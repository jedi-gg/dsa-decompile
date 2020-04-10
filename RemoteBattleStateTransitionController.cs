using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class RemoteBattleStateTransitionController : IDispatchHandler<DBattleStateTransitionViewAction>, IDispatchHandler, IDispatchHandler<DHideScrimsAction>
{
	[FieldOffset(Offset="0x0")]
	private const float ENTER_BATTLE_DELAY_S = 3f;

	[Attribute(Name="InjectAttribute", RVA="0x1053D30", Offset="0x1053D30")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1053D40", Offset="0x1053D40")]
	[FieldOffset(Offset="0x18")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x1053D50", Offset="0x1053D50")]
	[FieldOffset(Offset="0x20")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1053D60", Offset="0x1053D60")]
	[FieldOffset(Offset="0x28")]
	private GameStateMachine _gameStateMachine;

	[Attribute(Name="InjectAttribute", RVA="0x1053D70", Offset="0x1053D70")]
	[FieldOffset(Offset="0x30")]
	private Procrastinator _procrastinator;

	[Attribute(Name="InjectAttribute", RVA="0x1053D80", Offset="0x1053D80")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1053D90", Offset="0x1053D90")]
	[FieldOffset(Offset="0x40")]
	private Spell.Factory _spellFactory;

	[Attribute(Name="InjectAttribute", RVA="0x1053DA0", Offset="0x1053DA0")]
	[FieldOffset(Offset="0x48")]
	private Unit.Factory _unitFactory;

	[FieldOffset(Offset="0x50")]
	private BattleStateTransitionView _transitionView;

	[FieldOffset(Offset="0x58")]
	private RemoteBattleStateTransitionView _remoteTransitionView;

	[FieldOffset(Offset="0x60")]
	private Type _pendingGameState;

	[FieldOffset(Offset="0x68")]
	private ITransitionContext _pendingTransitionContext;

	[FieldOffset(Offset="0x70")]
	private RemoteBattleStateTransitionController.State _state;

	[Address(RVA="0x2C2E734", Offset="0x2C2E734", VA="0x2C2E734")]
	public RemoteBattleStateTransitionController()
	{
	}

	[Address(RVA="0x2C2E73C", Offset="0x2C2E73C", VA="0x2C2E73C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E5D8", Offset="0x106E5D8")]
	private void <HandleDispatchAction>g__CountdownCompleted|2_0()
	{
	}

	[Address(RVA="0x2C2D8E0", Offset="0x2C2D8E0", VA="0x2C2D8E0")]
	private RemoteBattlePlayerSquadWidget.Data BuildPlayerData(Player player, BattleLib_Bootstrap.Types.Player battlePlayer, ulong kothRank)
	{
		return null;
	}

	[Address(RVA="0x138EA0C", Offset="0x138EA0C", VA="0x138EA0C")]
	public void EnterState<TState>(RemoteBattleStateTransitionController.Context transitionContext, ITransitionContext enterStateContext = // 
	// Current member / type: System.Void RemoteBattleStateTransitionController::EnterState(RemoteBattleStateTransitionController/Context,Glunies.ITransitionContext)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void EnterState(RemoteBattleStateTransitionController/Context,Glunies.ITransitionContext)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x2C2E440", Offset="0x2C2E440", VA="0x2C2E440")]
	private List<Spell> GetPlayerSpellProtos(BattleLib_Bootstrap.Types.Player player)
	{
		return null;
	}

	[Address(RVA="0x2C2DEF0", Offset="0x2C2DEF0", VA="0x2C2DEF0")]
	private List<Unit> GetPlayerUnitProtos(BattleLib_Bootstrap.Types.Player player)
	{
		return null;
	}

	[Address(RVA="0x2C2D4B0", Offset="0x2C2D4B0", VA="0x2C2D4B0", Slot="4")]
	public void HandleDispatchAction(DBattleStateTransitionViewAction action)
	{
	}

	[Address(RVA="0x2C2D564", Offset="0x2C2D564", VA="0x2C2D564", Slot="5")]
	public void HandleDispatchAction(DHideScrimsAction action)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B07C", Offset="0x104B07C")]
	[Serializable]
	private sealed class <>c__0<TState>
	where TState : AGameState, new()
	{
		[FieldOffset(Offset="0x0")]
		public readonly static RemoteBattleStateTransitionController.<>c__0<TState> <>9;

		[FieldOffset(Offset="0x0")]
		public static Func<bool> <>9__0_4;

		[FieldOffset(Offset="0x0")]
		public static Func<bool> <>9__0_6;

		[Address(RVA="0x2193DD8", Offset="0x2193DD8", VA="0x2193DD8")]
		static <>c__0()
		{
		}

		[Address(RVA="0x2193EB0", Offset="0x2193EB0", VA="0x2193EB0")]
		public <>c__0()
		{
		}

		[Address(RVA="0x2193EDC", Offset="0x2193EDC", VA="0x2193EDC")]
		internal bool <EnterState>b__0_4()
		{
			return new bool();
		}

		[Address(RVA="0x2193EE4", Offset="0x2193EE4", VA="0x2193EE4")]
		internal bool <EnterState>b__0_6()
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B04C", Offset="0x104B04C")]
	private sealed class <>c__DisplayClass0_0<TState>
	where TState : AGameState, new()
	{
		[FieldOffset(Offset="0x0")]
		public RemoteBattleStateTransitionController <>4__this;

		[FieldOffset(Offset="0x0")]
		public RemoteBattleStateTransitionController.Context transitionContext;

		[FieldOffset(Offset="0x0")]
		public RemoteBattlePlayerSquadWidget.Data localPlayerData;

		[FieldOffset(Offset="0x0")]
		public RemoteBattlePlayerSquadWidget.Data remotePlayerData;

		[Address(RVA="0x2193EEC", Offset="0x2193EEC", VA="0x2193EEC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x2193F18", Offset="0x2193F18", VA="0x2193F18")]
		internal void <EnterState>b__0(Action taskDone)
		{
		}

		[Address(RVA="0x21941CC", Offset="0x21941CC", VA="0x21941CC")]
		internal void <EnterState>b__1(Action taskDone)
		{
		}

		[Address(RVA="0x2194480", Offset="0x2194480", VA="0x2194480")]
		internal void <EnterState>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B05C", Offset="0x104B05C")]
	private sealed class <>c__DisplayClass0_1<TState>
	where TState : AGameState, new()
	{
		[FieldOffset(Offset="0x0")]
		public Action taskDone;

		[FieldOffset(Offset="0x0")]
		public RemoteBattleStateTransitionController.<>c__DisplayClass0_0<TState> CS$<>8__locals1;

		[Address(RVA="0x21945E8", Offset="0x21945E8", VA="0x21945E8")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x2194614", Offset="0x2194614", VA="0x2194614")]
		internal void <EnterState>b__3(RemoteBattleStateTransitionView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B06C", Offset="0x104B06C")]
	private sealed class <>c__DisplayClass0_2<TState>
	where TState : AGameState, new()
	{
		[FieldOffset(Offset="0x0")]
		public Action taskDone;

		[FieldOffset(Offset="0x0")]
		public RemoteBattleStateTransitionController.<>c__DisplayClass0_0<TState> CS$<>8__locals2;

		[Address(RVA="0x2194720", Offset="0x2194720", VA="0x2194720")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x219474C", Offset="0x219474C", VA="0x219474C")]
		internal void <EnterState>b__5(BattleStateTransitionView view)
		{
		}
	}

	public class Context
	{
		[FieldOffset(Offset="0x10")]
		public readonly MatchType MatchType;

		[FieldOffset(Offset="0x18")]
		public readonly Player RemotePlayer;

		[FieldOffset(Offset="0x20")]
		public readonly BattleLib_Bootstrap BattleData;

		[FieldOffset(Offset="0x28")]
		public readonly byte LocalPlayerId;

		[FieldOffset(Offset="0x30")]
		public readonly ulong KothPlayerRank;

		[FieldOffset(Offset="0x38")]
		public readonly ulong KothOpponentRank;

		[Address(RVA="0x2C2E7CC", Offset="0x2C2E7CC", VA="0x2C2E7CC")]
		public Context(PvpFindMatchResponse response, BattleLib_Bootstrap battleData)
		{
		}

		[Address(RVA="0x2C2E84C", Offset="0x2C2E84C", VA="0x2C2E84C")]
		public Context(CoopFindMatchResponse response, BattleLib_Bootstrap battleData)
		{
		}

		[Address(RVA="0x2C2E8CC", Offset="0x2C2E8CC", VA="0x2C2E8CC")]
		public Context(KothBattleStartResponse response, BattleLib_Bootstrap battleData, ulong playerRank, ulong opponentRank)
		{
		}

		[Address(RVA="0x2C2E964", Offset="0x2C2E964", VA="0x2C2E964")]
		public Context(ClubWarBattleStartResponse response, BattleLib_Bootstrap battleData)
		{
		}
	}

	private enum State
	{
		[FieldOffset(Offset="0x0")]
		IntoLoadingScreen,
		[FieldOffset(Offset="0x0")]
		IntoBattle
	}
}