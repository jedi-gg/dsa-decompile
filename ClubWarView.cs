using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClubWarView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x1057208", Offset="0x1057208")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1057218", Offset="0x1057218")]
	[FieldOffset(Offset="0x70")]
	private ClubWarDomainController _clubWarDc;

	[Attribute(Name="InjectAttribute", RVA="0x1057228", Offset="0x1057228")]
	[FieldOffset(Offset="0x78")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1057238", Offset="0x1057238")]
	[FieldOffset(Offset="0x80")]
	private BadgingController _badgingController;

	[FieldOffset(Offset="0x88")]
	private Camera _mainCamera;

	[FieldOffset(Offset="0x90")]
	private Vector3 _initialCameraPos;

	[FieldOffset(Offset="0xA0")]
	private Dictionary<string, ClubWarSceneNode> _sceneNodesById;

	[FieldOffset(Offset="0xA8")]
	private List<ClubWarSceneEdge> _edges;

	[FieldOffset(Offset="0xB0")]
	private Dictionary<string, List<ClubWarSceneEdge>> _edgesByNodeId;

	[FieldOffset(Offset="0xB8")]
	private List<ClubWarNodeOverlay> _nodeOverlays;

	[FieldOffset(Offset="0xC0")]
	private Bounds _nodeBounds;

	[FieldOffset(Offset="0xD8")]
	private bool _nodeBoundsInitialized;

	[FieldOffset(Offset="0xE0")]
	private UiTimerLabel _phaseTimer;

	private ClubWarView.SerializedFields Fields
	{
		[Address(RVA="0x14E3CB0", Offset="0x14E3CB0", VA="0x14E3CB0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14E577C", Offset="0x14E577C", VA="0x14E577C")]
	public ClubWarView()
	{
	}

	[Address(RVA="0x14E5864", Offset="0x14E5864", VA="0x14E5864")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F264", Offset="0x106F264")]
	private void <ViewAssetLoaded>b__3_0(UiLockableFeature l)
	{
	}

	[Address(RVA="0x14E58E4", Offset="0x14E58E4", VA="0x14E58E4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F274", Offset="0x106F274")]
	private void <ViewAssetLoaded>b__3_1(Button b)
	{
	}

	[Address(RVA="0x14E3F6C", Offset="0x14E3F6C", VA="0x14E3F6C")]
	private void AddEdgeToNode(string nodeId, ClubWarSceneEdge edge)
	{
	}

	[Address(RVA="0x14E3D90", Offset="0x14E3D90", VA="0x14E3D90")]
	private void DestroyEdges()
	{
	}

	[Address(RVA="0x14E4074", Offset="0x14E4074", VA="0x14E4074")]
	private void DestroyNodeOverlays()
	{
	}

	[Address(RVA="0x14E5464", Offset="0x14E5464", VA="0x14E5464")]
	private void MemberRegisterClicked()
	{
	}

	[Address(RVA="0x14E54E8", Offset="0x14E54E8", VA="0x14E54E8")]
	private void MemberUnregisterClicked()
	{
	}

	[Address(RVA="0x14E53D0", Offset="0x14E53D0", VA="0x14E53D0")]
	private void NodeClicked(string nodeId)
	{
	}

	[Address(RVA="0x14E510C", Offset="0x14E510C", VA="0x14E510C", Slot="18")]
	protected override void ProcessBackButton()
	{
	}

	[Address(RVA="0x14E556C", Offset="0x14E556C", VA="0x14E556C")]
	private void RegisteredMembersClicked()
	{
	}

	[Address(RVA="0x14E5674", Offset="0x14E5674", VA="0x14E5674")]
	private void RewardsClicked()
	{
	}

	[Address(RVA="0x14E425C", Offset="0x14E425C", VA="0x14E425C")]
	private void SetPhase(ClubWarPhase phase)
	{
	}

	[Address(RVA="0x14E2D60", Offset="0x14E2D60", VA="0x14E2D60")]
	public void SetupWorldScene(ClubWarScene scene, Club playerClub)
	{
	}

	[Address(RVA="0x14E56F8", Offset="0x14E56F8", VA="0x14E56F8")]
	private void ShipmentButtonClicked()
	{
	}

	[Address(RVA="0x14E55F0", Offset="0x14E55F0", VA="0x14E55F0")]
	private void SquadRosterClicked()
	{
	}

	[Address(RVA="0x14E2D4C", Offset="0x14E2D4C", VA="0x14E2D4C")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x14E517C", Offset="0x14E517C", VA="0x14E517C")]
	private void ToggleInfo()
	{
	}

	[Address(RVA="0x14CAB2C", Offset="0x14CAB2C", VA="0x14CAB2C")]
	public void UpdateWarData(ClubWarScene scene, Club playerClub)
	{
	}

	[Address(RVA="0x14E44F4", Offset="0x14E44F4", VA="0x14E44F4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14E4BD0", Offset="0x14E4BD0", VA="0x14E4BD0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Address(RVA="0x14E52A4", Offset="0x14E52A4", VA="0x14E52A4")]
	private void WorldScrollRectValueChanged(Vector2 normalizedPos)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BA2C", Offset="0x104BA2C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static ClubWarView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<UiLockableFeature> <>9__4_0;

		[FieldOffset(Offset="0x10")]
		public static Action<Button> <>9__4_1;

		[Address(RVA="0x14E5994", Offset="0x14E5994", VA="0x14E5994")]
		static <>c()
		{
		}

		[Address(RVA="0x14E59F8", Offset="0x14E59F8", VA="0x14E59F8")]
		public <>c()
		{
		}

		[Address(RVA="0x14E5A00", Offset="0x14E5A00", VA="0x14E5A00")]
		internal void <ViewShuttingDown>b__4_0(UiLockableFeature l)
		{
		}

		[Address(RVA="0x14E5A30", Offset="0x14E5A30", VA="0x14E5A30")]
		internal void <ViewShuttingDown>b__4_1(Button b)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BA1C", Offset="0x104BA1C")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset="0x10")]
		public string nodeId;

		[FieldOffset(Offset="0x18")]
		public ClubWarView <>4__this;

		[Address(RVA="0x14E4254", Offset="0x14E4254", VA="0x14E4254")]
		public <>c__DisplayClass1_0()
		{
		}

		[Address(RVA="0x14E5A78", Offset="0x14E5A78", VA="0x14E5A78")]
		internal void <SetupWorldScene>b__0()
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0x30")]
		public List<UiLockableFeature> UiLockableFeatures;

		[FieldOffset(Offset="0x38")]
		public Button RegisteredMembersButton;

		[FieldOffset(Offset="0x40")]
		public UiLabel RegisteredMembersLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106A054", Offset="0x106A054")]
		[FieldOffset(Offset="0x48")]
		public UiLabel PhaseHeaderLabel;

		[FieldOffset(Offset="0x50")]
		public UiLabel PhaseTimerLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106A08C", Offset="0x106A08C")]
		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject TeamsContainer;

		[FieldOffset(Offset="0x60")]
		public ClubWarTeamHudWidget TeamAWidget;

		[FieldOffset(Offset="0x68")]
		public ClubWarTeamHudWidget TeamBWidget;

		[FieldOffset(Offset="0x70")]
		public ClubWarTeamHudWidget TeamCWidget;

		[Attribute(Name="HeaderAttribute", RVA="0x106A0C4", Offset="0x106A0C4")]
		[FieldOffset(Offset="0x78")]
		public UnityEngine.GameObject RegistrationContainer;

		[FieldOffset(Offset="0x80")]
		public Button MemberRegisterButton;

		[FieldOffset(Offset="0x88")]
		public Button MemberUnregisterButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106A0FC", Offset="0x106A0FC")]
		[FieldOffset(Offset="0x90")]
		public ScrollRect WorldScrollRect;

		[Attribute(Name="HeaderAttribute", RVA="0x106A134", Offset="0x106A134")]
		[FieldOffset(Offset="0x98")]
		public ClubWarNodeOverlay NodeOverlayArchetype;

		[Attribute(Name="HeaderAttribute", RVA="0x106A16C", Offset="0x106A16C")]
		[FieldOffset(Offset="0xA0")]
		public UnityEngine.GameObject InfoRoot;

		[FieldOffset(Offset="0xA8")]
		public Button InfoOpenButton;

		[FieldOffset(Offset="0xB0")]
		public List<Button> InfoCloseButtons;

		[Attribute(Name="HeaderAttribute", RVA="0x106A1A4", Offset="0x106A1A4")]
		[FieldOffset(Offset="0xB8")]
		public Button SquadRosterButton;

		[FieldOffset(Offset="0xC0")]
		public Button RewardsButton;

		[FieldOffset(Offset="0xC8")]
		public Button ShipmentButton;

		[Address(RVA="0x14E5AA8", Offset="0x14E5AA8", VA="0x14E5AA8")]
		public SerializedFields()
		{
		}
	}
}