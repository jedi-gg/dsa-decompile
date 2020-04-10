using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleHealthBarsView : AStandardView, IDispatchHandler<DBattleUnitsControllerAction>, IDispatchHandler, IDispatchHandler<DBattleHealthAction>, IDispatchHandler<DBattleHpDecayAction>, IDispatchHandler<DShowHealthBarAction>, IDispatchHandler<DBattleUnitEffectStatusesChangedAction>, IDispatchHandler<DEmphasizeUnitAbilityStrength>, IDispatchHandler<DBattleCinematicAction>
{
	[FieldOffset(Offset="0x0")]
	private const int INITIAL_HEALTH_BAR_POOL_SIZE = 20;

	[FieldOffset(Offset="0x0")]
	private const int INITIAL_BUFF_ICON_POOL_SIZE = 10;

	[Attribute(Name="InjectAttribute", RVA="0x10539F0", Offset="0x10539F0")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x70")]
	private MonoArchetypePool<BattleHealthBar> _healthBarPool;

	[FieldOffset(Offset="0x78")]
	private Dictionary<byte, BattleHealthBar> _activeHealthBars;

	[FieldOffset(Offset="0x80")]
	private List<BattleHealthBar> _sortedActiveHealthBars;

	[FieldOffset(Offset="0x88")]
	private MonoArchetypePool<BattleBuffIconComponent> _buffIconPool;

	[FieldOffset(Offset="0x90")]
	private Transform _mainCameraTransform;

	[FieldOffset(Offset="0x98")]
	private HashSet<uint> _activeBuffTypes;

	private BattleHealthBarsView.SerializedFields Fields
	{
		[Address(RVA="0x10FB750", Offset="0x10FB750", VA="0x10FB750")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x10FC07C", Offset="0x10FC07C", VA="0x10FC07C")]
	public BattleHealthBarsView()
	{
	}

	[Address(RVA="0x10FBCF8", Offset="0x10FBCF8", VA="0x10FBCF8")]
	private void DespawnBuffIconComponent(BattleBuffIconComponent buffIcon)
	{
	}

	[Address(RVA="0x10FB084", Offset="0x10FB084", VA="0x10FB084")]
	private void DespawnHealthBar(BattleUnit battleUnit)
	{
	}

	[Address(RVA="0x10FAC6C", Offset="0x10FAC6C", VA="0x10FAC6C")]
	public HashSet<uint> GetAllCurrentBuffTypes()
	{
		return null;
	}

	[Address(RVA="0x10FBE00", Offset="0x10FBE00", VA="0x10FBE00", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x10FADC4", Offset="0x10FADC4", VA="0x10FADC4", Slot="21")]
	public void HandleDispatchAction(DBattleUnitsControllerAction action)
	{
	}

	[Address(RVA="0x10FB198", Offset="0x10FB198", VA="0x10FB198", Slot="22")]
	public void HandleDispatchAction(DBattleHealthAction action)
	{
	}

	[Address(RVA="0x10FB298", Offset="0x10FB298", VA="0x10FB298", Slot="23")]
	public void HandleDispatchAction(DBattleHpDecayAction action)
	{
	}

	[Address(RVA="0x10FB33C", Offset="0x10FB33C", VA="0x10FB33C", Slot="27")]
	public void HandleDispatchAction(DBattleCinematicAction action)
	{
	}

	[Address(RVA="0x10FB490", Offset="0x10FB490", VA="0x10FB490", Slot="24")]
	public void HandleDispatchAction(DShowHealthBarAction action)
	{
	}

	[Address(RVA="0x10FB64C", Offset="0x10FB64C", VA="0x10FB64C", Slot="25")]
	public void HandleDispatchAction(DBattleUnitEffectStatusesChangedAction action)
	{
	}

	[Address(RVA="0x10FB830", Offset="0x10FB830", VA="0x10FB830", Slot="26")]
	public void HandleDispatchAction(DEmphasizeUnitAbilityStrength action)
	{
	}

	[Address(RVA="0x10FBC18", Offset="0x10FBC18", VA="0x10FBC18")]
	private BattleBuffIconComponent SpawnBuffIconComponent(Transform parent)
	{
		return null;
	}

	[Address(RVA="0x10FADF0", Offset="0x10FADF0", VA="0x10FADF0")]
	private void SpawnHealthBar(BattleUnit battleUnit, BattleLib_Bootstrap.Types.Unit unitData, uint maxHp)
	{
	}

	[Address(RVA="0x10FA80C", Offset="0x10FA80C", VA="0x10FA80C")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x10FB8D4", Offset="0x10FB8D4", VA="0x10FB8D4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x10FBB04", Offset="0x10FBB04", VA="0x10FBB04", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	public delegate void DespawnBattleBuffIcon(BattleBuffIconComponent iconComponent);

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public BattleHealthBar HealthBarArchetype;

		[FieldOffset(Offset="0x30")]
		public BattleBuffIconComponent BuffIconPrefab;

		[FieldOffset(Offset="0x38")]
		public BattleBuffIconUiData BuffIconUiData;

		[FieldOffset(Offset="0x40")]
		public SpriteSheetNameLookup AffinitySpriteLookup;

		[Address(RVA="0x10FC8A8", Offset="0x10FC8A8", VA="0x10FC8A8")]
		public SerializedFields()
		{
		}
	}

	public delegate BattleBuffIconComponent SpawnBattleBuffIcon(Transform parent);
}