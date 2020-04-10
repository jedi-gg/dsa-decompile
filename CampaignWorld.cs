using DG.Tweening;
using Gamedata;
using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CampaignWorld : MonoBehaviour, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x18")]
	private WidgetDependencyContainer _dependencies;

	[FieldOffset(Offset="0x20")]
	private MonoArchetypePool<CampaignBattleTile> _campaignBattleTilePool;

	[FieldOffset(Offset="0x28")]
	private Vector3 _playerMarkerLocalPos;

	[FieldOffset(Offset="0x34")]
	private float? _autoScrollNormalizedPos;

	[FieldOffset(Offset="0x3C")]
	private float _scrollRectContentWidth;

	[FieldOffset(Offset="0x40")]
	private float _nodeSelectPositionOffset;

	[FieldOffset(Offset="0x48")]
	private Tweener _bounceTween;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private CampaignBackdropCameraDolly _backdropCameraDolly;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Canvas _canvas;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Button _worldInputCatcher;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private ScrollRect _scrollRect;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private float _maxNormalizedAutoScrollPerS;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private List<CampaignWorld.MapFields> _mapFields;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private CampaignBattleTile _campaignWorldBattleNodeArchetype;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private CampaignRewardTile _campaignWorldRewardNodeArchetype;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private GameObject _pathLockArchetype;

	[Attribute(Name="HeaderAttribute", RVA="0x10556E8", Offset="0x10556E8")]
	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private LineRenderer _normalLockedPathLine;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private LineRenderer _normalUnlockedPathLine;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private LineRenderer _hardLockedPathLine;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private LineRenderer _hardUnlockedPathLine;

	[Attribute(Name="HeaderAttribute", RVA="0x1055764", Offset="0x1055764")]
	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private RawImage _playerMarker;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private Vector3 _playerMarkerOffset;

	[FieldOffset(Offset="0xCC")]
	[SerializeField]
	private Vector3 _playerMarkerSelectedOffset;

	[Attribute(Name="HeaderAttribute", RVA="0x10557D0", Offset="0x10557D0")]
	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private GameObject _selectedTileEffect;

	[FieldOffset(Offset="0xE0")]
	[SerializeField]
	private GameObject _bossSelectedTileEffect;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private GameObject _unlockTileEffect;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private GameObject _bossUnlockTileEffect;

	[Attribute(Name="HeaderAttribute", RVA="0x105584C", Offset="0x105584C")]
	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private AudioClipGroup _markerBounceAudio;

	public LogCategory LogCategory
	{
		[Address(RVA="0x118AF10", Offset="0x118AF10", VA="0x118AF10", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	public Camera WorldCamera
	{
		[Address(RVA="0x118AF18", Offset="0x118AF18", VA="0x118AF18")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11902A8", Offset="0x11902A8", VA="0x11902A8")]
	public CampaignWorld()
	{
	}

	[Address(RVA="0x1190310", Offset="0x1190310", VA="0x1190310")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E9B8", Offset="0x106E9B8")]
	private void <Initialize>b__4_0()
	{
	}

	[Address(RVA="0x118D814", Offset="0x118D814", VA="0x118D814")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E9C8", Offset="0x106E9C8")]
	private void <SetFurthestUnlockedNode>g__SetLockState|9_0(CampaignWorld.MapFields.MapPath mapPath, string lockedTextKey, bool locked)
	{
	}

	[Address(RVA="0x1190018", Offset="0x1190018", VA="0x1190018")]
	private void AppendPathPosition(LineRenderer line, Vector3 pos)
	{
	}

	[Address(RVA="0x118DC30", Offset="0x118DC30", VA="0x118DC30")]
	public void ClearFocus()
	{
	}

	[Address(RVA="0x11900EC", Offset="0x11900EC", VA="0x11900EC")]
	private void CreateBattleNodePath(CampaignWorld.MapFields.MapPath mapPath, LineRenderer unlockedLine, LineRenderer lockedLine, CampaignWorld.DCampaignUnlockStatus unlockStatus, int mapIndex)
	{
	}

	[Address(RVA="0x118D534", Offset="0x118D534", VA="0x118D534")]
	private void CreateHardPathTrail(CampaignWorld.DCampaignUnlockStatus unlockStatus)
	{
	}

	[Address(RVA="0x118D0B4", Offset="0x118D0B4", VA="0x118D0B4")]
	private void CreateNormalPathTrail(CampaignWorld.DCampaignUnlockStatus unlockStatus)
	{
	}

	[Address(RVA="0x118CBC0", Offset="0x118CBC0", VA="0x118CBC0")]
	public void CreateRewardNodeTile(CampaignRewardTile.DModel model, CampaignType campaignType, int mapIndex)
	{
	}

	[Address(RVA="0x118D9B8", Offset="0x118D9B8", VA="0x118D9B8")]
	public void FocusOnBattleNode(DCampaignAddress campaignAddress)
	{
	}

	[Address(RVA="0x118DD24", Offset="0x118DD24", VA="0x118DD24")]
	private CampaignBattleTileMarker GetMarkerAtAddress(CampaignWorld.MapFields mapFields, DCampaignAddress campaignAddress)
	{
		return null;
	}

	[Address(RVA="0x118EA90", Offset="0x118EA90", VA="0x118EA90")]
	private Vector3? GetMarkerWorldPosition(CampaignWorld.MapFields mapFields, DCampaignAddress campaignAddress)
	{
		return null;
	}

	[Address(RVA="0x118F7A8", Offset="0x118F7A8", VA="0x118F7A8")]
	public RectTransform GetRewardTilePointAt(int mapIndex)
	{
		return null;
	}

	[Address(RVA="0x118EF20", Offset="0x118EF20", VA="0x118EF20")]
	private CampaignBattleTile GetTileAtAddress(DCampaignAddress campaignAddress)
	{
		return null;
	}

	[Address(RVA="0x118F460", Offset="0x118F460", VA="0x118F460")]
	public RectTransform GetTutorialPointAtLookup(DCampaignAddress campaignAddress, string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x118AF48", Offset="0x118AF48", VA="0x118AF48")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x118C9B8", Offset="0x118C9B8", VA="0x118C9B8")]
	public void InitializeBattleTileMarker(CampaignBattleTile.DModel model, CampaignType campaignType, DCampaignAddress campaignAddress)
	{
	}

	[Address(RVA="0x118EB94", Offset="0x118EB94", VA="0x118EB94")]
	public void PlayNodeUnlockAnimation(DCampaignAddress address, Action selectNodeCallback)
	{
	}

	[Address(RVA="0x118F92C", Offset="0x118F92C", VA="0x118F92C")]
	private void ScrollRectValueChanged(Vector2 normalizedPos)
	{
	}

	[Address(RVA="0x118E904", Offset="0x118E904", VA="0x118E904")]
	public void ScrollToAddress(DCampaignAddress campaignAddress, bool centerOnScreen)
	{
	}

	[Address(RVA="0x118E424", Offset="0x118E424", VA="0x118E424")]
	private void ScrollToMarker(CampaignBattleTileMarker marker, bool centerOnScreen)
	{
	}

	[Address(RVA="0x118CDB0", Offset="0x118CDB0", VA="0x118CDB0")]
	public void SetFurthestUnlockedNode(Campaign? campaign, CampaignWorld.DCampaignUnlockStatus unlockStatus)
	{
	}

	[Address(RVA="0x118E4FC", Offset="0x118E4FC", VA="0x118E4FC")]
	public void SetPlayerMarkerOnTile(DCampaignAddress campaignAddress)
	{
	}

	[Address(RVA="0x118B9C8", Offset="0x118B9C8", VA="0x118B9C8")]
	private void ShowPlayerMarker(bool show)
	{
	}

	[Address(RVA="0x118BA5C", Offset="0x118BA5C", VA="0x118BA5C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x118F6D8", Offset="0x118F6D8", VA="0x118F6D8")]
	private void SnapToTileMarker(CampaignBattleTileMarker marker)
	{
	}

	[Address(RVA="0x118C1A8", Offset="0x118C1A8", VA="0x118C1A8")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x118E7FC", Offset="0x118E7FC", VA="0x118E7FC")]
	private void UnselectAllTiles()
	{
	}

	[Address(RVA="0x118F204", Offset="0x118F204", VA="0x118F204")]
	public void UpdateBattleNodeLimitedAttempts(DCampaignAddress address, uint limitedAttemptsRemaining)
	{
	}

	[Address(RVA="0x118F0E8", Offset="0x118F0E8", VA="0x118F0E8")]
	public void UpdateBattleNodeLockState(DCampaignAddress address, bool isLocked, int starCount)
	{
	}

	[Address(RVA="0x118C3C4", Offset="0x118C3C4", VA="0x118C3C4")]
	private void UpdateBattleTileMarkers()
	{
	}

	[Address(RVA="0x118F384", Offset="0x118F384", VA="0x118F384")]
	public void UpdateBonusLootLabel(DCampaignAddress address, bool isActive)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B4DC", Offset="0x104B4DC")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset="0x10")]
		public CampaignWorld <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool isBoss;

		[FieldOffset(Offset="0x20")]
		public Action selectNodeCallback;

		[Address(RVA="0x118EF18", Offset="0x118EF18", VA="0x118EF18")]
		public <>c__DisplayClass14_0()
		{
		}

		[Address(RVA="0x11903FC", Offset="0x11903FC", VA="0x11903FC")]
		internal void <PlayNodeUnlockAnimation>b__0()
		{
		}

		[Address(RVA="0x11904A4", Offset="0x11904A4", VA="0x11904A4")]
		internal void <PlayNodeUnlockAnimation>b__1()
		{
		}
	}

	public struct DCampaignUnlockStatus
	{
		[FieldOffset(Offset="0x0")]
		public DCampaignAddress? NewUnlockedAddress;

		[FieldOffset(Offset="0x20")]
		public int FurthestUnlockedMapIndex;

		[FieldOffset(Offset="0x24")]
		public int FurthestUnlockedNodeIndex;

		[FieldOffset(Offset="0x28")]
		public bool FurthestUnlockedNodeCompleted;
	}

	[Serializable]
	public class MapFields
	{
		[FieldOffset(Offset="0x10")]
		public CampaignWorld.MapFields.MapPath NormalPath;

		[FieldOffset(Offset="0x18")]
		public CampaignWorld.MapFields.MapPath HardPath;

		[FieldOffset(Offset="0x20")]
		[NonSerialized]
		public CampaignRewardTile NormalCampaignRewardTile;

		[FieldOffset(Offset="0x28")]
		[NonSerialized]
		public CampaignRewardTile HardCampaignRewardTile;

		[FieldOffset(Offset="0x30")]
		[NonSerialized]
		public LineRenderer NormalLockedLine;

		[FieldOffset(Offset="0x38")]
		[NonSerialized]
		public LineRenderer NormalUnlockedLine;

		[FieldOffset(Offset="0x40")]
		[NonSerialized]
		public LineRenderer HardLockedLine;

		[FieldOffset(Offset="0x48")]
		[NonSerialized]
		public LineRenderer HardUnlockedLine;

		[Address(RVA="0x1190640", Offset="0x1190640", VA="0x1190640")]
		public MapFields()
		{
		}

		[Serializable]
		public class MapPath
		{
			[FieldOffset(Offset="0x10")]
			public RectTransform LockMarker;

			[FieldOffset(Offset="0x18")]
			public CampaignBattleTileMarker RewardMarker;

			[FieldOffset(Offset="0x20")]
			public List<CampaignWorld.MapFields.MapPath.NodeGroup> Nodes;

			[Address(RVA="0x1190648", Offset="0x1190648", VA="0x1190648")]
			public MapPath()
			{
			}

			[Serializable]
			public class NodeGroup
			{
				[FieldOffset(Offset="0x10")]
				public List<CampaignBattleTileMarker> BattleTileMarkers;

				[Address(RVA="0x1190650", Offset="0x1190650", VA="0x1190650")]
				public NodeGroup()
				{
				}
			}
		}
	}
}