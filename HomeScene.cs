using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class HomeScene : AFeatureScene
{
	[FieldOffset(Offset="0x0")]
	private const string EVENT_SHADER_ALPHA_PROPERTY = "_Alpha";

	[FieldOffset(Offset="0x0")]
	private static int s_eventShaderAlphaHash;

	[FieldOffset(Offset="0x50")]
	private Vector3 _rotationRate;

	[FieldOffset(Offset="0x5C")]
	private Vector3 _camOffset;

	[FieldOffset(Offset="0x68")]
	private Vector3 _camLooktAt;

	[FieldOffset(Offset="0x74")]
	private Vector3 _initialCamLookAt;

	[FieldOffset(Offset="0x80")]
	private bool _camLookAtSet;

	[Attribute(Name="HeaderAttribute", RVA="0x1058CF4", Offset="0x1058CF4")]
	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private List<HomeScene.WorldIconMarker> _worldIconMarkers;

	[Attribute(Name="HeaderAttribute", RVA="0x1058D40", Offset="0x1058D40")]
	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private GameObject _noActiveEventContainer;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private GameObject _activeEventContainer;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private Renderer _activeEventRenderer;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private string _rendererShaderTextureName;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private Transform _camGyroPivot;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private float _gyroRateFactor;

	[FieldOffset(Offset="0xBC")]
	[SerializeField]
	private float _gyroLerpFactor;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private float _eventAlphaSwapDurationS;

	[Attribute(Name="HeaderAttribute", RVA="0x1058DFC", Offset="0x1058DFC")]
	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private GameObject _defaultTowerObject;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private List<HomeScene.CustomTowerObjects> _customTowerObjects;

	public float EventAlphaSwapDurationS
	{
		[Address(RVA="0x11703D0", Offset="0x11703D0", VA="0x11703D0")]
		get
		{
			return new float();
		}
	}

	public IEnumerable<HomeScene.WorldIconMarker> WorldIconMarkers
	{
		[Address(RVA="0x11703C8", Offset="0x11703C8", VA="0x11703C8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1170DC0", Offset="0x1170DC0", VA="0x1170DC0")]
	static HomeScene()
	{
	}

	[Address(RVA="0x1170D54", Offset="0x1170D54", VA="0x1170D54")]
	public HomeScene()
	{
	}

	[Address(RVA="0x1170A28", Offset="0x1170A28", VA="0x1170A28")]
	private void Awake()
	{
	}

	[Address(RVA="0x11703D8", Offset="0x11703D8", VA="0x11703D8", Slot="4")]
	public override void Initialize()
	{
	}

	[Address(RVA="0x1170A0C", Offset="0x1170A0C", VA="0x1170A0C")]
	public void ScrollCamera(Vector2 offset)
	{
	}

	[Address(RVA="0x1170778", Offset="0x1170778", VA="0x1170778")]
	public void SetActiveEventTexture(Texture tex)
	{
	}

	[Address(RVA="0x1170908", Offset="0x1170908", VA="0x1170908")]
	private void ShowActiveEvent(bool show)
	{
	}

	[Address(RVA="0x116CC98", Offset="0x116CC98", VA="0x116CC98")]
	public void ShowTower(TowerIdentifier towerId)
	{
	}

	[Address(RVA="0x1170730", Offset="0x1170730", VA="0x1170730", Slot="5")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1170A30", Offset="0x1170A30", VA="0x1170A30")]
	private void Update()
	{
	}

	[Serializable]
	public class CustomTowerObjects
	{
		[FieldOffset(Offset="0x10")]
		public ulong TowerId;

		[FieldOffset(Offset="0x18")]
		public ulong MapId;

		[FieldOffset(Offset="0x20")]
		public GameObject Object;

		[Address(RVA="0x1170E24", Offset="0x1170E24", VA="0x1170E24")]
		public CustomTowerObjects()
		{
		}
	}

	[Serializable]
	public class WorldIconMarker
	{
		[FieldOffset(Offset="0x10")]
		public HomeViewWorldIcon.WorldIconType IconType;

		[FieldOffset(Offset="0x18")]
		public Transform WorldTransform;

		[Address(RVA="0x1170E2C", Offset="0x1170E2C", VA="0x1170E2C")]
		public WorldIconMarker()
		{
		}
	}
}