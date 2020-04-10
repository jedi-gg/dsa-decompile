using BattleLib;
using Glunies;
using Il2CppDummyDll;
using System;
using Zenject;

public class BattleCinematicController : ILoggable<LogCategory>, IDispatchHandler<DBattleEncounterAction>, IDispatchHandler, IDispatchHandler<DBattleInitialSpawnAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105486C", Offset="0x105486C")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x105487C", Offset="0x105487C")]
	[FieldOffset(Offset="0x18")]
	private AssetRegistry _assetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105488C", Offset="0x105488C")]
	[FieldOffset(Offset="0x20")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x105489C", Offset="0x105489C")]
	[FieldOffset(Offset="0x28")]
	private BattleUnitsController _battleUnitsController;

	[Attribute(Name="InjectAttribute", RVA="0x10548AC", Offset="0x10548AC")]
	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x10548BC", Offset="0x10548BC")]
	[FieldOffset(Offset="0x38")]
	private BattleEnvironmentController _battleEnvironmentController;

	[Attribute(Name="InjectAttribute", RVA="0x10548CC", Offset="0x10548CC")]
	[FieldOffset(Offset="0x40")]
	private DiContainer _diContainer;

	[FieldOffset(Offset="0x48")]
	private AssetCollection _assets;

	[FieldOffset(Offset="0x50")]
	private ABattleCinematic _currentCinematic;

	[FieldOffset(Offset="0x58")]
	private int? _currentEncounterIndex;

	public LogCategory LogCategory
	{
		[Address(RVA="0x113D3D8", Offset="0x113D3D8", VA="0x113D3D8", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x113EA28", Offset="0x113EA28", VA="0x113EA28")]
	public BattleCinematicController()
	{
	}

	[Address(RVA="0x113E504", Offset="0x113E504", VA="0x113E504")]
	private BattleUnit GetFocusUnit(BattleCinematic.FocusType focusType)
	{
		return null;
	}

	[Address(RVA="0x113E83C", Offset="0x113E83C", VA="0x113E83C")]
	private ValueTuple<string, string> GetTitleAndSubtitle(BattleUnit focusUnit, BattleCinematic.FocusType focusType)
	{
		return new ValueTuple<string, string>();
	}

	[Address(RVA="0x113DA2C", Offset="0x113DA2C", VA="0x113DA2C", Slot="5")]
	public void HandleDispatchAction(DBattleEncounterAction action)
	{
	}

	[Address(RVA="0x113E4D0", Offset="0x113E4D0", VA="0x113E4D0", Slot="6")]
	public void HandleDispatchAction(DBattleInitialSpawnAction action)
	{
	}

	[Address(RVA="0x113D3E0", Offset="0x113D3E0", VA="0x113D3E0")]
	public void Initialize()
	{
	}

	[Address(RVA="0x113DDDC", Offset="0x113DDDC", VA="0x113DDDC")]
	private void KickOffCinematic(ABattleCinematic cinematic)
	{
	}

	[Address(RVA="0x113D4EC", Offset="0x113D4EC", VA="0x113D4EC")]
	public void LoadAssets(string[] cinematicAssets, Action finished)
	{
	}

	[Address(RVA="0x113DB04", Offset="0x113DB04", VA="0x113DB04")]
	private bool PlayCinematicForEncounter(int encounterIndex)
	{
		return new bool();
	}

	[Address(RVA="0x113DC5C", Offset="0x113DC5C", VA="0x113DC5C")]
	public bool PlayIntroCinematic()
	{
		return new bool();
	}

	[Address(RVA="0x113E1AC", Offset="0x113E1AC", VA="0x113E1AC")]
	private bool PlayLoadedCinematic(string assetName)
	{
		return new bool();
	}

	[Address(RVA="0x113D984", Offset="0x113D984", VA="0x113D984")]
	private void SendCinematicDone(byte encounterIndex)
	{
	}

	[Address(RVA="0x113D67C", Offset="0x113D67C", VA="0x113D67C")]
	public void SetCurrentEncounterIndex(int i)
	{
	}

	[Address(RVA="0x113D418", Offset="0x113D418", VA="0x113D418")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x113D6EC", Offset="0x113D6EC", VA="0x113D6EC")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x113D89C", Offset="0x113D89C", VA="0x113D89C")]
	private void TryPlayFirstEncounterCinematic()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B33C", Offset="0x104B33C")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleCinematicController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[FieldOffset(Offset="0x20")]
		public Action<AssetCollection> <>9__0;

		[Address(RVA="0x113D674", Offset="0x113D674", VA="0x113D674")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x113EA30", Offset="0x113EA30", VA="0x113EA30")]
		internal void <LoadAssets>b__0(AssetCollection collection)
		{
		}
	}
}