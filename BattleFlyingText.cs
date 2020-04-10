using DG.Tweening;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleFlyingText : MonoBehaviour, IMonoArchetypePooledItem
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private CanvasGroup _rootCanvasGroup;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private RectTransform _tweenRoot;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UiLabel _label;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UiLabel _headerLabel;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Material _defaultTextMaterial;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Material _critTextMaterial;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Material _healTextMaterial;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Material _manaTextMaterial;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Material _alertTextMaterial;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Material _strongDmgTextMaterial;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Material _weakDmgTextMaterial;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Material _procTextMaterial;

	[Attribute(Name="HeaderAttribute", RVA="0x105343C", Offset="0x105343C")]
	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Vector3 _globalOffset;

	[FieldOffset(Offset="0x84")]
	[SerializeField]
	private float _horizontalOffsetRange;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private float _minDistanceToTopOfScreen;

	[Attribute(Name="HeaderAttribute", RVA="0x10534A8", Offset="0x10534A8")]
	[FieldOffset(Offset="0x8C")]
	[SerializeField]
	private float _generalTextScale;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private float _damageScale;

	[FieldOffset(Offset="0x94")]
	[SerializeField]
	private float _critScale;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private float _critPunchScale;

	[FieldOffset(Offset="0x9C")]
	[SerializeField]
	private float _procScale;

	[FieldOffset(Offset="0xA0")]
	private Camera _camera;

	[FieldOffset(Offset="0xA8")]
	private Transform _transform;

	[FieldOffset(Offset="0xB0")]
	private Dictionary<BattleFlyingText.AnimType, Sequence> _sequences;

	[FieldOffset(Offset="0xB8")]
	private Dictionary<BattleFlyingText.AnimType, float> _verticalVelocities;

	[FieldOffset(Offset="0xC0")]
	private Sequence _currentSequence;

	[FieldOffset(Offset="0xC8")]
	private BattleUnit _targetUnit;

	[FieldOffset(Offset="0xD0")]
	private BattleFlyingText.PositioningMode _positioningMode;

	[FieldOffset(Offset="0xD4")]
	private Vector3 _worldPosition;

	[FieldOffset(Offset="0xE0")]
	private Vector3 _screenPosition;

	[FieldOffset(Offset="0xEC")]
	private Vector3 _offset;

	[FieldOffset(Offset="0xF8")]
	private Vector3 _velocity;

	public bool FinishedAnimating
	{
		[Address(RVA="0x114638C", Offset="0x114638C", VA="0x114638C")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11478DC", Offset="0x11478DC", VA="0x11478DC")]
	public BattleFlyingText()
	{
	}

	[Address(RVA="0x11463F8", Offset="0x11463F8", VA="0x11463F8")]
	private void CreateTweens()
	{
	}

	[Address(RVA="0x11463BC", Offset="0x11463BC", VA="0x11463BC", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x11470E8", Offset="0x11470E8", VA="0x11470E8")]
	public void InitWithDamage(int amount, string header, BattleUnit targetUnit, BattleFlyingText.AnimType animType)
	{
	}

	[Address(RVA="0x11473C0", Offset="0x11473C0", VA="0x11473C0")]
	public void InitWithText(string text, BattleUnit targetUnit, BattleFlyingText.AnimType animType, FlyingTextType textType)
	{
	}

	[Address(RVA="0x1147578", Offset="0x1147578", VA="0x1147578")]
	public void InitWithTextAndScreenPosition(string text, Vector3 screenPosition, BattleFlyingText.AnimType animType)
	{
	}

	[Address(RVA="0x114748C", Offset="0x114748C", VA="0x114748C")]
	public void InitWithTextAndWorldPosition(string text, Vector3 worldPosition, BattleFlyingText.AnimType animType, FlyingTextType textType)
	{
	}

	[Address(RVA="0x1146F58", Offset="0x1146F58", VA="0x1146F58", Slot="6")]
	public void Reinitialize()
	{
	}

	[Address(RVA="0x1147234", Offset="0x1147234", VA="0x1147234")]
	private void SetFontType(FlyingTextType textType)
	{
	}

	[Address(RVA="0x1146DFC", Offset="0x1146DFC", VA="0x1146DFC", Slot="5")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1147294", Offset="0x1147294", VA="0x1147294")]
	private void StartAnim(BattleFlyingText.AnimType animType)
	{
	}

	[Address(RVA="0x1147020", Offset="0x1147020", VA="0x1147020")]
	private void SwapLabelMaterials(Material newMaterialProperties)
	{
	}

	[Address(RVA="0x114764C", Offset="0x114764C", VA="0x114764C")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1147650", Offset="0x1147650", VA="0x1147650")]
	private void UpdatePosition()
	{
	}

	public enum AnimType
	{
		[FieldOffset(Offset="0x0")]
		Text,
		[FieldOffset(Offset="0x0")]
		Damage,
		[FieldOffset(Offset="0x0")]
		CritDamage,
		[FieldOffset(Offset="0x0")]
		StrongDamage,
		[FieldOffset(Offset="0x0")]
		WeakDamage,
		[FieldOffset(Offset="0x0")]
		Proc,
		[FieldOffset(Offset="0x0")]
		NUM_TYPES
	}

	private enum PositioningMode
	{
		[FieldOffset(Offset="0x0")]
		Unit,
		[FieldOffset(Offset="0x0")]
		WorldPosition,
		[FieldOffset(Offset="0x0")]
		ScreenPosition
	}
}