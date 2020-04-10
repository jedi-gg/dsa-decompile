using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SquadSelectView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x105CBD4", Offset="0x105CBD4")]
	[FieldOffset(Offset="0x68")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x105CBE4", Offset="0x105CBE4")]
	[FieldOffset(Offset="0x70")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x78")]
	private List<SquadSelectUnitSlot> _unitSlots;

	[FieldOffset(Offset="0x80")]
	private IReadOnlyList<Serverproto.Unit> _units;

	[FieldOffset(Offset="0x88")]
	private IReadOnlyList<Serverproto.Spell> _spells;

	private SquadSelectView.SerializedFields Fields
	{
		[Address(RVA="0x12242C0", Offset="0x12242C0", VA="0x12242C0")]
		get
		{
			return null;
		}
	}

	public int NumVisualUnitSlots
	{
		[Address(RVA="0x1224258", Offset="0x1224258", VA="0x1224258")]
		get
		{
			return new int();
		}
	}

	[Address(RVA="0x1226EA4", Offset="0x1226EA4", VA="0x1226EA4")]
	public SquadSelectView()
	{
	}

	[Address(RVA="0x1226F14", Offset="0x1226F14", VA="0x1226F14")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070A5C", Offset="0x1070A5C")]
	private void <ViewAssetLoaded>b__12_0()
	{
	}

	[Address(RVA="0x1226F98", Offset="0x1226F98", VA="0x1226F98")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070A6C", Offset="0x1070A6C")]
	private void <ViewAssetLoaded>b__12_1()
	{
	}

	[Address(RVA="0x122701C", Offset="0x122701C", VA="0x122701C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070A7C", Offset="0x1070A7C")]
	private void <ViewAssetLoaded>b__12_2()
	{
	}

	[Address(RVA="0x12270A0", Offset="0x12270A0", VA="0x12270A0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070A8C", Offset="0x1070A8C")]
	private void <ViewAssetLoaded>b__12_3()
	{
	}

	[Address(RVA="0x1226644", Offset="0x1226644", VA="0x1226644", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x12208B4", Offset="0x12208B4", VA="0x12208B4")]
	public void Initialize(int maxUnitsInSquad, int maxSpellsInSquad, SquadSelectView.ActionMode actionMode, Gamedata.GameMode gameMode, List<SquadSelectScene.WorldSlotMarker> worldSlotMarkers, Action finished)
	{
	}

	[Address(RVA="0x12243A8", Offset="0x12243A8", VA="0x12243A8")]
	public void InitializeUnitPositions()
	{
	}

	[Address(RVA="0x1226D8C", Offset="0x1226D8C", VA="0x1226D8C", Slot="17")]
	protected override void PointAtObjectTriggered(RectTransform pointAtObject)
	{
	}

	[Address(RVA="0x122522C", Offset="0x122522C", VA="0x122522C")]
	public void SetCanBattle(bool canBattle)
	{
	}

	[Address(RVA="0x1224F94", Offset="0x1224F94", VA="0x1224F94")]
	public void SetSpells(IReadOnlyList<Serverproto.Spell> spells)
	{
	}

	[Address(RVA="0x1225CCC", Offset="0x1225CCC", VA="0x1225CCC")]
	public void SetSquadRequirementText(string text)
	{
	}

	[Address(RVA="0x12245F0", Offset="0x12245F0", VA="0x12245F0")]
	public void SetUnits(IReadOnlyList<Serverproto.Unit> units, ulong leaderUnitId, PersistedPlayerBattleUnits persistentUnitsInfo)
	{
	}

	[Address(RVA="0x1225274", Offset="0x1225274", VA="0x1225274")]
	public void ShowEntryCost(Gamedata.InventoryItem? entryCostItem, ulong entryCost)
	{
	}

	[Address(RVA="0x1225400", Offset="0x1225400", VA="0x1225400")]
	public void ShowOpponentPreview(string playerName, IList<Serverproto.Unit> units, IList<Serverproto.Spell> spells, ulong leaderId, ulong? opponentRank = // 
	// Current member / type: System.Void SquadSelectView::ShowOpponentPreview(System.String,System.Collections.Generic.IList`1<Serverproto.Unit>,System.Collections.Generic.IList`1<Serverproto.Spell>,System.UInt64,System.Nullable`1<System.UInt64>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void ShowOpponentPreview(System.String,System.Collections.Generic.IList<Serverproto.Unit>,System.Collections.Generic.IList<Serverproto.Spell>,System.UInt64,System.Nullable<System.UInt64>)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x122515C", Offset="0x122515C", VA="0x122515C")]
	public void ShowUnitCountRestriction(int currentUnitCount, int maxUnitCount)
	{
	}

	[Address(RVA="0x12244CC", Offset="0x12244CC", VA="0x12244CC")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x12248BC", Offset="0x12248BC", VA="0x12248BC")]
	private void UpdateUi()
	{
	}

	[Address(RVA="0x1225D90", Offset="0x1225D90", VA="0x1225D90", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x122609C", Offset="0x122609C", VA="0x122609C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CC4C", Offset="0x104CC4C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectView <>4__this;

		[FieldOffset(Offset="0x18")]
		public Gamedata.GameMode gameMode;

		[Address(RVA="0x12242B8", Offset="0x12242B8", VA="0x12242B8")]
		public <>c__DisplayClass2_0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CC5C", Offset="0x104CC5C")]
	private sealed class <>c__DisplayClass2_1
	{
		[FieldOffset(Offset="0x10")]
		public int indexClosure;

		[FieldOffset(Offset="0x18")]
		public SquadSelectScene.WorldSlotMarker worldSlotMarker;

		[FieldOffset(Offset="0x20")]
		public bool slotEnabled;

		[FieldOffset(Offset="0x28")]
		public SquadSelectView.<>c__DisplayClass2_0 CS$<>8__locals1;

		[Address(RVA="0x12243A0", Offset="0x12243A0", VA="0x12243A0")]
		public <>c__DisplayClass2_1()
		{
		}

		[Address(RVA="0x1227124", Offset="0x1227124", VA="0x1227124")]
		internal void <Initialize>b__0(Action jobDone)
		{
		}
	}

	public enum ActionMode
	{
		[FieldOffset(Offset="0x0")]
		Battle,
		[FieldOffset(Offset="0x0")]
		SetSquad
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106BD14", Offset="0x106BD14")]
		[FieldOffset(Offset="0x28")]
		public SquadSelectUnitSlot UnitSlotArchetype;

		[FieldOffset(Offset="0x30")]
		public List<SquadSelectSpellSlot> SpellSlots;

		[FieldOffset(Offset="0x38")]
		public CostButton BattleButton;

		[FieldOffset(Offset="0x40")]
		public Button SetSquadButton;

		[FieldOffset(Offset="0x48")]
		public Button ClearAllButton;

		[FieldOffset(Offset="0x50")]
		public LabelButton SavedSquadsButton;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject SquadPowerContainer;

		[FieldOffset(Offset="0x60")]
		public UiLabel SquadPowerLabel;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject UnitCountContainer;

		[FieldOffset(Offset="0x70")]
		public UiLabel UnitCountLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106BD4C", Offset="0x106BD4C")]
		[FieldOffset(Offset="0x78")]
		public UnityEngine.GameObject OpponentContainer;

		[FieldOffset(Offset="0x80")]
		public List<UnitListItem> OpponentUnits;

		[FieldOffset(Offset="0x88")]
		public List<SpellListItem> OpponentSpells;

		[FieldOffset(Offset="0x90")]
		public UiLabel OpponentNameLabel;

		[FieldOffset(Offset="0x98")]
		public UiLabel OpponentPowerLabel;

		[FieldOffset(Offset="0xA0")]
		public UiLabel OpponentRankLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106BD84", Offset="0x106BD84")]
		[FieldOffset(Offset="0xA8")]
		public UnityEngine.GameObject RequiredUnitsContainer;

		[FieldOffset(Offset="0xB0")]
		public UiLabel RequiredUnitsLabel;

		[Address(RVA="0x122724C", Offset="0x122724C", VA="0x122724C")]
		public SerializedFields()
		{
		}
	}
}