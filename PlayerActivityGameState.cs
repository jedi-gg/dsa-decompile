using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using Zenject;

public class PlayerActivityGameState : AGameState, IDispatchHandler<DTabViewIndexSelectedAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x0")]
	private readonly static Dictionary<PlayerActivityGameState.Tab, LockableFeature> s_tabToLockableFeature;

	[Attribute(Name="InjectAttribute", RVA="0x105B5F4", Offset="0x105B5F4")]
	[FieldOffset(Offset="0x30")]
	private DiContainer _diContainer;

	[Attribute(Name="InjectAttribute", RVA="0x105B604", Offset="0x105B604")]
	[FieldOffset(Offset="0x38")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x105B614", Offset="0x105B614")]
	[FieldOffset(Offset="0x40")]
	private HudController _hudController;

	[Attribute(Name="InjectAttribute", RVA="0x105B624", Offset="0x105B624")]
	[FieldOffset(Offset="0x48")]
	private PassportSeasonUtility _passportSeasonUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105B634", Offset="0x105B634")]
	[FieldOffset(Offset="0x50")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x105B644", Offset="0x105B644")]
	[FieldOffset(Offset="0x58")]
	private GameStateMachine _gameStateMachine;

	[Attribute(Name="InjectAttribute", RVA="0x105B654", Offset="0x105B654")]
	[FieldOffset(Offset="0x60")]
	private DailyActivityEnergyUtil _energyUtil;

	[Attribute(Name="InjectAttribute", RVA="0x105B664", Offset="0x105B664")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x70")]
	private TabViewController<PlayerActivityTabView> _tabViewController;

	[FieldOffset(Offset="0x78")]
	private bool _allowBackNav;

	public override bool CanBeNavigatedBackInto
	{
		[Address(RVA="0x132C90C", Offset="0x132C90C", VA="0x132C90C", Slot="8")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x132D850", Offset="0x132D850", VA="0x132D850")]
	static PlayerActivityGameState()
	{
	}

	[Address(RVA="0x132D840", Offset="0x132D840", VA="0x132D840")]
	public PlayerActivityGameState()
	{
	}

	[Address(RVA="0x132C914", Offset="0x132C914", VA="0x132C914", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	[Address(RVA="0x132D2C8", Offset="0x132D2C8", VA="0x132D2C8", Slot="5")]
	public override void Exiting()
	{
	}

	[Address(RVA="0x132D35C", Offset="0x132D35C", VA="0x132D35C", Slot="12")]
	public void HandleDispatchAction(DTabViewIndexSelectedAction action)
	{
	}

	[Address(RVA="0x132D400", Offset="0x132D400", VA="0x132D400")]
	private void LoadTab(PlayerActivityGameState.Tab tab, PlayerActivityGameState.AContext context = // 
	// Current member / type: System.Void PlayerActivityGameState::LoadTab(PlayerActivityGameState/Tab,PlayerActivityGameState/AContext)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void LoadTab(PlayerActivityGameState/Tab,PlayerActivityGameState/AContext)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C69C", Offset="0x104C69C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public PlayerActivityGameState <>4__this;

		[FieldOffset(Offset="0x18")]
		public PlayerActivityGameState.AContext playerActivityContext;

		[Address(RVA="0x132D160", Offset="0x132D160", VA="0x132D160")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x132D930", Offset="0x132D930", VA="0x132D930")]
		internal void <Entering>b__0()
		{
		}
	}

	public class AchievementContext : PlayerActivityGameState.AContext
	{
		public override PlayerActivityGameState.Tab Tab
		{
			[Address(RVA="0x132D99C", Offset="0x132D99C", VA="0x132D99C", Slot="4")]
			get
			{
				return new PlayerActivityGameState.Tab();
			}
		}

		[Address(RVA="0x132D278", Offset="0x132D278", VA="0x132D278")]
		public AchievementContext()
		{
		}

		[Address(RVA="0x132D9A4", Offset="0x132D9A4", VA="0x132D9A4")]
		public AchievementContext(ulong selectedActivityId)
		{
		}
	}

	public abstract class AContext : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public ulong SelectedActivityId;

		[FieldOffset(Offset="0x28")]
		public ulong RewardIdHighlight;

		public abstract PlayerActivityGameState.Tab Tab
		{
			get;
		}

		[Address(RVA="0x132D994", Offset="0x132D994", VA="0x132D994")]
		protected AContext()
		{
		}
	}

	public class ClubContext : PlayerActivityGameState.AContext
	{
		public override PlayerActivityGameState.Tab Tab
		{
			[Address(RVA="0x132D9D0", Offset="0x132D9D0", VA="0x132D9D0", Slot="4")]
			get
			{
				return new PlayerActivityGameState.Tab();
			}
		}

		[Address(RVA="0x132D2C0", Offset="0x132D2C0", VA="0x132D2C0")]
		public ClubContext()
		{
		}
	}

	public class DailyContext : PlayerActivityGameState.AContext
	{
		public override PlayerActivityGameState.Tab Tab
		{
			[Address(RVA="0x132D9D8", Offset="0x132D9D8", VA="0x132D9D8", Slot="4")]
			get
			{
				return new PlayerActivityGameState.Tab();
			}
		}

		[Address(RVA="0x132D1EC", Offset="0x132D1EC", VA="0x132D1EC")]
		public DailyContext()
		{
		}

		[Address(RVA="0x132D9E0", Offset="0x132D9E0", VA="0x132D9E0")]
		public DailyContext(ulong selectedActivityId)
		{
		}
	}

	public class PassportSeasonContext : PlayerActivityGameState.AContext
	{
		[FieldOffset(Offset="0x30")]
		public PassportSeasonGameState.AContext PassportContext;

		public override PlayerActivityGameState.Tab Tab
		{
			[Address(RVA="0x132DA0C", Offset="0x132DA0C", VA="0x132DA0C", Slot="4")]
			get
			{
				return new PlayerActivityGameState.Tab();
			}
		}

		[Address(RVA="0x132DA14", Offset="0x132DA14", VA="0x132DA14")]
		public PassportSeasonContext()
		{
		}

		[Address(RVA="0x132DA1C", Offset="0x132DA1C", VA="0x132DA1C")]
		public PassportSeasonContext(PassportSeasonGameState.AContext passportContext)
		{
		}
	}

	public enum Tab
	{
		[FieldOffset(Offset="0x0")]
		PassportSeason,
		[FieldOffset(Offset="0x0")]
		Daily,
		[FieldOffset(Offset="0x0")]
		Club,
		[FieldOffset(Offset="0x0")]
		Achievements
	}
}