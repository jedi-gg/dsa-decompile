using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BattleUnit : IBattleUnitGameObject
{
	[FieldOffset(Offset="0x0")]
	public const float DAMAGED_HEALTH_THRESHOLD = 0.4f;

	[FieldOffset(Offset="0x0")]
	public const uint INVALID_HIDE_ID = 0;

	[FieldOffset(Offset="0x0")]
	public const int SINGLE_HIDE_PRIORITY = 10;

	[FieldOffset(Offset="0x0")]
	public const int TEAM_HIDE_PRIORITY = 20;

	[FieldOffset(Offset="0x0")]
	public const int CINEMATIC_HIDE_PRIORITY = 30;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053F50", Offset="0x1053F50")]
	[FieldOffset(Offset="0x10")]
	private BattleUnit.LivingState <LifeState>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053F60", Offset="0x1053F60")]
	[FieldOffset(Offset="0x18")]
	private BattleUnit <AutoAttackTarget>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1053F70", Offset="0x1053F70")]
	[FieldOffset(Offset="0x20")]
	private float <DeathTime>k__BackingField;

	[Attribute(Name="InjectAttribute", RVA="0x1053F80", Offset="0x1053F80")]
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1053F90", Offset="0x1053F90")]
	[FieldOffset(Offset="0x30")]
	private ABattle _battle;

	[FieldOffset(Offset="0x0")]
	private const float ROTATE_SPEED = 8f;

	[FieldOffset(Offset="0x38")]
	private BattleUnit.DProperties _properties;

	[FieldOffset(Offset="0x58")]
	private UnityEngine.GameObject _gameObject;

	[FieldOffset(Offset="0x60")]
	private UnityEngine.GameObject _originalGameObject;

	[FieldOffset(Offset="0x68")]
	private Transform _transform;

	[FieldOffset(Offset="0x70")]
	private Animator _animator;

	[FieldOffset(Offset="0x78")]
	private bool _positionInitialized;

	[FieldOffset(Offset="0x7C")]
	private Vector3 _position;

	[FieldOffset(Offset="0x88")]
	private UnitSubObjectRefComponent _unitReferences;

	[FieldOffset(Offset="0x90")]
	private float _dyingTimer;

	[FieldOffset(Offset="0x94")]
	private BattleUnit.DAbilityCastContext? _currentAbility;

	[FieldOffset(Offset="0xA0")]
	private BattleUnitMaterialController _materialController;

	[FieldOffset(Offset="0xA8")]
	private BattleUnitMaterialController _originalMaterialController;

	[FieldOffset(Offset="0xB0")]
	private UnitVisualSequencer _spawnSequencer;

	[FieldOffset(Offset="0xB8")]
	private UnitVisualSequencer _deathSequencer;

	[FieldOffset(Offset="0xC0")]
	private UnitVisualSequencer _victorySequencer;

	[FieldOffset(Offset="0xC8")]
	private List<BattleLib_UpdateResult.Types.Effect> _effects;

	[FieldOffset(Offset="0xD0")]
	private bool _isDamaged;

	[FieldOffset(Offset="0xD4")]
	private uint _nextHideId;

	[FieldOffset(Offset="0xD8")]
	private BattleUnit.DActiveHide _activeHide;

	[FieldOffset(Offset="0xE0")]
	private bool _culled;

	public BattleUnit AutoAttackTarget
	{
		[Address(RVA="0x1299894", Offset="0x1299894", VA="0x1299894")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E668", Offset="0x106E668")]
		get
		{
			return null;
		}
		[Address(RVA="0x129989C", Offset="0x129989C", VA="0x129989C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E678", Offset="0x106E678")]
		private set
		{
		}
	}

	public float DeathTime
	{
		[Address(RVA="0x12998C4", Offset="0x12998C4", VA="0x12998C4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E688", Offset="0x106E688")]
		get
		{
			return new float();
		}
		[Address(RVA="0x12998CC", Offset="0x12998CC", VA="0x12998CC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E698", Offset="0x106E698")]
		private set
		{
		}
	}

	public bool DeathTimePassed
	{
		[Address(RVA="0x12998D4", Offset="0x12998D4", VA="0x12998D4")]
		get
		{
			return new bool();
		}
	}

	public IReadOnlyList<BattleLib_UpdateResult.Types.Effect> Effects
	{
		[Address(RVA="0x12998B4", Offset="0x12998B4", VA="0x12998B4")]
		get
		{
			return null;
		}
	}

	private UnityEngine.GameObject IBattleUnitGameObject.GameObject
	{
		[Address(RVA="0x1299994", Offset="0x1299994", VA="0x1299994", Slot="4")]
		get
		{
			return null;
		}
	}

	public byte Id
	{
		[Address(RVA="0x12974B8", Offset="0x12974B8", VA="0x12974B8")]
		get
		{
			return new byte();
		}
	}

	public bool IsAlive
	{
		[Address(RVA="0x1299374", Offset="0x1299374", VA="0x1299374")]
		get
		{
			return new bool();
		}
	}

	public bool IsCelebrating
	{
		[Address(RVA="0x12998A4", Offset="0x12998A4", VA="0x12998A4")]
		get
		{
			return new bool();
		}
	}

	public BattleUnit.LivingState LifeState
	{
		[Address(RVA="0x1299884", Offset="0x1299884", VA="0x1299884")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E648", Offset="0x106E648")]
		get
		{
			return new BattleUnit.LivingState();
		}
		[Address(RVA="0x129988C", Offset="0x129988C", VA="0x129988C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E658", Offset="0x106E658")]
		private set
		{
		}
	}

	public BattleUnit.Ownership Owner
	{
		[Address(RVA="0x129987C", Offset="0x129987C", VA="0x129987C")]
		get
		{
			return new BattleUnit.Ownership();
		}
	}

	public byte PlayerId
	{
		[Address(RVA="0x1295744", Offset="0x1295744", VA="0x1295744")]
		get
		{
			return new byte();
		}
	}

	public Vector3 Position
	{
		[Address(RVA="0x1296CEC", Offset="0x1296CEC", VA="0x1296CEC")]
		get
		{
			return new Vector3();
		}
	}

	public byte SpawnIndex
	{
		[Address(RVA="0x12998BC", Offset="0x12998BC", VA="0x12998BC")]
		get
		{
			return new byte();
		}
	}

	public byte TeamId
	{
		[Address(RVA="0x1296F98", Offset="0x1296F98", VA="0x1296F98")]
		get
		{
			return new byte();
		}
	}

	public int TravelDirection
	{
		[Address(RVA="0x1299828", Offset="0x1299828", VA="0x1299828")]
		get
		{
			return new int();
		}
	}

	public BattleLib_Bootstrap.Types.Unit UnitData
	{
		[Address(RVA="0x1295A04", Offset="0x1295A04", VA="0x1295A04")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x129D4F8", Offset="0x129D4F8", VA="0x129D4F8")]
	public BattleUnit()
	{
	}

	[Address(RVA="0x129CEE4", Offset="0x129CEE4", VA="0x129CEE4")]
	public void AddEffect(BattleLib_UpdateResult.Types.Effect effect)
	{
	}

	[Address(RVA="0x129B3E8", Offset="0x129B3E8", VA="0x129B3E8")]
	public void CastEnded(ushort castId)
	{
	}

	[Address(RVA="0x129B33C", Offset="0x129B33C", VA="0x129B33C")]
	public void CastStarted(byte abilityId, ushort castId)
	{
	}

	[Address(RVA="0x129D088", Offset="0x129D088", VA="0x129D088")]
	public void ClearEffects()
	{
	}

	[Address(RVA="0x129D488", Offset="0x129D488", VA="0x129D488")]
	public void Cull(bool cull)
	{
	}

	[Address(RVA="0x1299A80", Offset="0x1299A80", VA="0x1299A80")]
	public void DestroyProps()
	{
	}

	[Address(RVA="0x129AA90", Offset="0x129AA90", VA="0x129AA90")]
	public void Die(UnitVisualSequencer deathVisual)
	{
	}

	[Address(RVA="0x1299B68", Offset="0x1299B68", VA="0x1299B68")]
	public void FinishDeath(bool stopVisual)
	{
	}

	[Address(RVA="0x129574C", Offset="0x129574C", VA="0x129574C")]
	public BattleLib_Bootstrap.Types.Ability GetAbility(int abilityId)
	{
		return null;
	}

	[Address(RVA="0x129CBA8", Offset="0x129CBA8", VA="0x129CBA8")]
	public BattleLib_Bootstrap.Types.Ability GetAbilityOrHighestLevel(int abilityId, uint level)
	{
		return null;
	}

	[Address(RVA="0x129B088", Offset="0x129B088", VA="0x129B088")]
	public Transform GetHealthBarHorizontalRef()
	{
		return null;
	}

	[Address(RVA="0x129AD04", Offset="0x129AD04", VA="0x129AD04")]
	public Vector3 GetHealthBarPosition()
	{
		return new Vector3();
	}

	[Address(RVA="0x129B19C", Offset="0x129B19C", VA="0x129B19C")]
	public Vector3 GetHitPositionNoRaycast()
	{
		return new Vector3();
	}

	[Address(RVA="0x129B26C", Offset="0x129B26C", VA="0x129B26C")]
	public Vector3 GetLongPressPosition()
	{
		return new Vector3();
	}

	[Address(RVA="0x129A370", Offset="0x129A370", VA="0x129A370")]
	public Vector3 GetSpawnPos()
	{
		return new Vector3();
	}

	[Address(RVA="0x129D270", Offset="0x129D270", VA="0x129D270")]
	public bool HasEffectType(BattleEffectType effectType)
	{
		return new bool();
	}

	[Address(RVA="0x129CAB4", Offset="0x129CAB4", VA="0x129CAB4")]
	public bool HasGameObject(UnityEngine.GameObject go)
	{
		return new bool();
	}

	[Address(RVA="0x129D3B4", Offset="0x129D3B4", VA="0x129D3B4")]
	public DHiddenUnit Hide(int priority)
	{
		return new DHiddenUnit();
	}

	[Address(RVA="0x129D230", Offset="0x129D230", VA="0x129D230")]
	public bool IsStealthed()
	{
		return new bool();
	}

	[Address(RVA="0x129D1F4", Offset="0x129D1F4", VA="0x129D1F4")]
	public bool IsTaunting()
	{
		return new bool();
	}

	[Address(RVA="0x129AA88", Offset="0x129AA88", VA="0x129AA88")]
	public void MarkForDeath(float deathTIme)
	{
	}

	[Address(RVA="0x129AB9C", Offset="0x129AB9C", VA="0x129AB9C")]
	public void PlayVictory(UnitVisualSequencer victoryVisual)
	{
	}

	[Address(RVA="0x129B480", Offset="0x129B480", VA="0x129B480")]
	public void Polymorph(UnityEngine.GameObject newUnitPrefab)
	{
	}

	[Address(RVA="0x129B78C", Offset="0x129B78C", VA="0x129B78C")]
	public void PolymorphEnd()
	{
	}

	[Address(RVA="0x129A9A4", Offset="0x129A9A4", VA="0x129A9A4")]
	private void RemoveUnitVisual(ref UnitVisualSequencer sequencer)
	{
	}

	[Address(RVA="0x1299B38", Offset="0x1299B38", VA="0x1299B38")]
	private void RemoveUnitVisuals()
	{
	}

	[Address(RVA="0x129A7B0", Offset="0x129A7B0", VA="0x129A7B0")]
	private void ResetAnimator(bool resetTriggers = false, bool resetState = true)
	{
	}

	[Address(RVA="0x129C270", Offset="0x129C270", VA="0x129C270")]
	public void ResetColor()
	{
	}

	[Address(RVA="0x129C48C", Offset="0x129C48C", VA="0x129C48C")]
	public void ResetOutlineColor()
	{
	}

	[Address(RVA="0x129C6FC", Offset="0x129C6FC", VA="0x129C6FC")]
	public void ResetRimValues()
	{
	}

	[Address(RVA="0x129A3B8", Offset="0x129A3B8", VA="0x129A3B8")]
	public void SetAnimatorWalkSpeed(float speed)
	{
	}

	[Address(RVA="0x129B478", Offset="0x129B478", VA="0x129B478")]
	public void SetAutoAttackTarget(BattleUnit targetUnit)
	{
	}

	[Address(RVA="0x129C158", Offset="0x129C158", VA="0x129C158")]
	public void SetColor(UnityEngine.Color color)
	{
	}

	[Address(RVA="0x129C990", Offset="0x129C990", VA="0x129C990")]
	public void SetHealthPercent(float healthPercent)
	{
	}

	[Address(RVA="0x129C850", Offset="0x129C850", VA="0x129C850")]
	public void SetLocalScale(Vector3 scale)
	{
	}

	[Address(RVA="0x129C374", Offset="0x129C374", VA="0x129C374")]
	public void SetOutlineColor(UnityEngine.Color color)
	{
	}

	[Address(RVA="0x129A4F4", Offset="0x129A4F4", VA="0x129A4F4")]
	public void SetPosition(Vector3 pos)
	{
	}

	[Address(RVA="0x129C590", Offset="0x129C590", VA="0x129C590")]
	public void SetRimValues(float rimMin, float rimMax, UnityEngine.Color rimColor)
	{
	}

	[Address(RVA="0x129D438", Offset="0x129D438", VA="0x129D438")]
	public void Show(uint hideId)
	{
	}

	[Address(RVA="0x129999C", Offset="0x129999C", VA="0x129999C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x129A698", Offset="0x129A698", VA="0x129A698")]
	public void Spawn(UnitVisualSequencer spawnVisual)
	{
	}

	[Address(RVA="0x129A5D0", Offset="0x129A5D0", VA="0x129A5D0")]
	public void TeleportToSimPos()
	{
	}

	[Address(RVA="0x1299C50", Offset="0x1299C50", VA="0x1299C50")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x129A00C", Offset="0x129A00C", VA="0x129A00C")]
	public void UnitVisualTickUpdate()
	{
	}

	[Address(RVA="0x129BAFC", Offset="0x129BAFC", VA="0x129BAFC")]
	private void UpdateCachedComponents()
	{
	}

	public struct DAbilityCastContext
	{
		[FieldOffset(Offset="0x0")]
		public readonly byte AbilityId;

		[FieldOffset(Offset="0x2")]
		public readonly ushort CastId;

		[Address(RVA="0xEFD2B0", Offset="0xEFD2B0", VA="0xEFD2B0")]
		public DAbilityCastContext(byte abilityId, ushort castId)
		{
		}
	}

	public struct DActiveHide
	{
		[FieldOffset(Offset="0x0")]
		public uint Id;

		[FieldOffset(Offset="0x4")]
		public int Priority;
	}

	public struct DPolymorphedAction
	{
		[FieldOffset(Offset="0x0")]
		public BattleUnit Unit;

		[FieldOffset(Offset="0x8")]
		public UnityEngine.GameObject OriginalGameObject;

		[FieldOffset(Offset="0x10")]
		public UnityEngine.GameObject NewGameObject;

		[Address(RVA="0xEFD308", Offset="0xEFD308", VA="0xEFD308")]
		public DPolymorphedAction(BattleUnit unit, UnityEngine.GameObject originalGameObject, UnityEngine.GameObject newGameObject)
		{
		}
	}

	public struct DProperties
	{
		[FieldOffset(Offset="0x0")]
		public UnityEngine.GameObject GameObject;

		[FieldOffset(Offset="0x8")]
		public byte Id;

		[FieldOffset(Offset="0x9")]
		public byte PlayerId;

		[FieldOffset(Offset="0xA")]
		public byte TeamId;

		[FieldOffset(Offset="0xC")]
		public BattleUnit.Ownership Owner;

		[FieldOffset(Offset="0x10")]
		public BattleLib_Bootstrap.Types.Unit UnitData;

		[FieldOffset(Offset="0x18")]
		public byte SpawnIndex;
	}

	public enum LivingState
	{
		[FieldOffset(Offset="0x0")]
		Alive,
		[FieldOffset(Offset="0x0")]
		Dying,
		[FieldOffset(Offset="0x0")]
		Dead,
		[FieldOffset(Offset="0x0")]
		Celebrating
	}

	public enum Ownership
	{
		[FieldOffset(Offset="0x0")]
		Self,
		[FieldOffset(Offset="0x0")]
		Ally,
		[FieldOffset(Offset="0x0")]
		Enemy
	}

	public class Pool : MemoryPool<BattleUnit.DProperties, BattleUnit>
	{
		[Address(RVA="0x129D85C", Offset="0x129D85C", VA="0x129D85C")]
		public Pool()
		{
		}

		[Address(RVA="0x129D5A0", Offset="0x129D5A0", VA="0x129D5A0", Slot="15")]
		protected override void Reinitialize(BattleUnit.DProperties properties, BattleUnit unit)
		{
		}
	}
}