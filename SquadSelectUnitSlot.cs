using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SquadSelectUnitSlot : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private SingleAssetRegistry _unitPrefabAssetRegistry;

	[FieldOffset(Offset="0x28")]
	private UnitVisualSequencerFactory _unitVisualSequencerFactory;

	[FieldOffset(Offset="0x30")]
	private UnitVisualSequencer _idleSequencer;

	[FieldOffset(Offset="0x38")]
	private Camera _mainCamera;

	[FieldOffset(Offset="0x40")]
	private SquadSelectScene.WorldSlotMarker _worldSlotMarker;

	[FieldOffset(Offset="0x48")]
	private Serverproto.Unit _unit;

	[FieldOffset(Offset="0x50")]
	private ulong _unitId;

	[FieldOffset(Offset="0x58")]
	private bool _enabled;

	[FieldOffset(Offset="0x59")]
	private Gamedata.GameMode _gameMode;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UnityEngine.UI.Button _button;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UnityEngine.UI.Button _infoButton;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private RectTransform _sideInfoContainer;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Vector3 _sideInfoContainerOffset;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private GameObject _spinner;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private PressEventHandler _slotPressHandler;

	[Attribute(Name="HeaderAttribute", RVA="0x105CAFC", Offset="0x105CAFC")]
	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private GameObject _healthBarContainer;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private Image _healthBar;

	[Attribute(Name="HeaderAttribute", RVA="0x105CB58", Offset="0x105CB58")]
	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private GameObject _leaderContainer;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private UnityEngine.UI.Button _selectLeaderButton;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private GameObject _selectedLeaderContainer;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private Image _leaderAbilityDisabledIcon;

	public UnityEngine.UI.Button Button
	{
		[Address(RVA="0x1222C58", Offset="0x1222C58", VA="0x1222C58")]
		get
		{
			return null;
		}
	}

	public GameObject HealthBarContainer
	{
		[Address(RVA="0x1222C68", Offset="0x1222C68", VA="0x1222C68")]
		get
		{
			return null;
		}
	}

	public bool IsEmpty
	{
		[Address(RVA="0x1222C40", Offset="0x1222C40", VA="0x1222C40")]
		get
		{
			return new bool();
		}
	}

	public bool IsEnabled
	{
		[Address(RVA="0x1222C50", Offset="0x1222C50", VA="0x1222C50")]
		get
		{
			return new bool();
		}
	}

	public UnityEngine.UI.Button SelectLeaderButton
	{
		[Address(RVA="0x1222C60", Offset="0x1222C60", VA="0x1222C60")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1223C84", Offset="0x1223C84", VA="0x1223C84")]
	public SquadSelectUnitSlot()
	{
	}

	[Address(RVA="0x1223C8C", Offset="0x1223C8C", VA="0x1223C8C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070A4C", Offset="0x1070A4C")]
	private void <LoadUnitModel>b__17_0(AssetHandle assetHandle)
	{
	}

	[Address(RVA="0x1223574", Offset="0x1223574", VA="0x1223574")]
	public void HideHealth()
	{
	}

	[Address(RVA="0x1222C70", Offset="0x1222C70", VA="0x1222C70")]
	public void Initialize(WidgetDependencyContainer dependencies, SquadSelectScene.WorldSlotMarker worldSlotMarker, int index, bool enabled, Gamedata.GameMode gameMode, Action finished)
	{
	}

	[Address(RVA="0x1223614", Offset="0x1223614", VA="0x1223614")]
	public void InitializePosition()
	{
	}

	[Address(RVA="0x1223A88", Offset="0x1223A88", VA="0x1223A88")]
	private void LoadUnitModel()
	{
	}

	[Address(RVA="0x1223150", Offset="0x1223150", VA="0x1223150")]
	public void SetUnit(Serverproto.Unit unit, bool isLeader)
	{
	}

	[Address(RVA="0x1223B78", Offset="0x1223B78", VA="0x1223B78")]
	public void ShowHealth(float healthPercent)
	{
	}

	[Address(RVA="0x12237F8", Offset="0x12237F8", VA="0x12237F8")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x12239B0", Offset="0x12239B0", VA="0x12239B0")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CC3C", Offset="0x104CC3C")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset="0x10")]
		public SquadSelectUnitSlot <>4__this;

		[FieldOffset(Offset="0x18")]
		public int index;

		[Address(RVA="0x1223148", Offset="0x1223148", VA="0x1223148")]
		public <>c__DisplayClass10_0()
		{
		}

		[Address(RVA="0x1223FF8", Offset="0x1223FF8", VA="0x1223FF8")]
		internal void <Initialize>b__0()
		{
		}

		[Address(RVA="0x1224090", Offset="0x1224090", VA="0x1224090")]
		internal void <Initialize>b__1()
		{
		}

		[Address(RVA="0x1224128", Offset="0x1224128", VA="0x1224128")]
		internal void <Initialize>b__2()
		{
		}

		[Address(RVA="0x12241C0", Offset="0x12241C0", VA="0x12241C0")]
		internal void <Initialize>b__3()
		{
		}
	}
}