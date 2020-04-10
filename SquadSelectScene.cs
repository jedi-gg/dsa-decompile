using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class SquadSelectScene : AFeatureScene
{
	[FieldOffset(Offset="0x0")]
	public const float FADED_SLOT_INDICATOR_ALPHA = 0.25f;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private List<SquadSelectScene.WorldSlotMarker> _worldSlotMarkers;

	public List<SquadSelectScene.WorldSlotMarker> WorldSlotMarkers
	{
		[Address(RVA="0x12208AC", Offset="0x12208AC", VA="0x12208AC")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1222554", Offset="0x1222554", VA="0x1222554")]
	public SquadSelectScene()
	{
	}

	[Serializable]
	public class WorldSlotMarker
	{
		[FieldOffset(Offset="0x10")]
		public Transform UnitMarkerParent;

		[FieldOffset(Offset="0x18")]
		public GameObject EmptySlotIndicator;

		[FieldOffset(Offset="0x20")]
		public GameObject SlotEnabledRoot;

		[FieldOffset(Offset="0x28")]
		public Renderer EmptySlotRenderer;

		[Address(RVA="0x122255C", Offset="0x122255C", VA="0x122255C")]
		public WorldSlotMarker()
		{
		}
	}
}