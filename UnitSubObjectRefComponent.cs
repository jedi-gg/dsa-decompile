using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitSubObjectRefComponent : SubObjectRefComponent
{
	[FieldOffset(Offset="0x0")]
	public static float STANDARD_SOURCE_HEIGHT;

	[Attribute(Name="HeaderAttribute", RVA="0x105EFD8", Offset="0x105EFD8")]
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UnitSubObjectRefComponent.DUiReference _healthBar;

	[Attribute(Name="HeaderAttribute", RVA="0x105F024", Offset="0x105F024")]
	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Vector3 _hitPosition;

	[FieldOffset(Offset="0x5C")]
	[SerializeField]
	private Bounds _hitVolume;

	[Attribute(Name="HeaderAttribute", RVA="0x105F080", Offset="0x105F080")]
	[FieldOffset(Offset="0x74")]
	[SerializeField]
	private Vector3 _cinematicOffset;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Vector3 _abilityCamOffset;

	[Attribute(Name="HeaderAttribute", RVA="0x105F0DC", Offset="0x105F0DC")]
	[FieldOffset(Offset="0x8C")]
	[SerializeField]
	private Vector3 _longPressOffset;

	public Vector3 CinematicPosition
	{
		[Address(RVA="0x1515030", Offset="0x1515030", VA="0x1515030")]
		get
		{
			return new Vector3();
		}
	}

	public GameObject HealthBarHorizontalReference
	{
		[Address(RVA="0x1514FF4", Offset="0x1514FF4", VA="0x1514FF4")]
		get
		{
			return null;
		}
		[Address(RVA="0x1514FFC", Offset="0x1514FFC", VA="0x1514FFC")]
		set
		{
		}
	}

	public Vector3 HealthBarLocalOffset
	{
		[Address(RVA="0x1515010", Offset="0x1515010", VA="0x1515010")]
		get
		{
			return new Vector3();
		}
	}

	public Vector3 HealthBarOffset
	{
		[Address(RVA="0x1515004", Offset="0x1515004", VA="0x1515004")]
		get
		{
			return new Vector3();
		}
	}

	public GameObject HealthBarReference
	{
		[Address(RVA="0x1514F5C", Offset="0x1514F5C", VA="0x1514F5C")]
		get
		{
			return null;
		}
		[Address(RVA="0x1514FEC", Offset="0x1514FEC", VA="0x1514FEC")]
		set
		{
		}
	}

	public Bounds LocalHitVolume
	{
		[Address(RVA="0x151501C", Offset="0x151501C", VA="0x151501C")]
		get
		{
			return new Bounds();
		}
	}

	[Address(RVA="0x15158C8", Offset="0x15158C8", VA="0x15158C8")]
	static UnitSubObjectRefComponent()
	{
	}

	[Address(RVA="0x15157BC", Offset="0x15157BC", VA="0x15157BC")]
	public UnitSubObjectRefComponent()
	{
	}

	[Address(RVA="0x15151D0", Offset="0x15151D0", VA="0x15151D0")]
	public Vector3 GetAbilityCameraPos()
	{
		return new Vector3();
	}

	[Address(RVA="0x15152C8", Offset="0x15152C8", VA="0x15152C8")]
	public Vector3 GetHitPosition(Vector3 sourcePosition)
	{
		return new Vector3();
	}

	[Address(RVA="0x151508C", Offset="0x151508C", VA="0x151508C")]
	public Vector3 GetHitPositionNoRaycast()
	{
		return new Vector3();
	}

	[Address(RVA="0x15150E8", Offset="0x15150E8", VA="0x15150E8")]
	public Vector3 GetLongPressPosition()
	{
		return new Vector3();
	}

	[Address(RVA="0x15154FC", Offset="0x15154FC", VA="0x15154FC", Slot="4")]
	protected virtual void OnDrawGizmosSelected()
	{
	}

	[Serializable]
	public struct DUiReference
	{
		[FieldOffset(Offset="0x0")]
		public GameObject Reference;

		[FieldOffset(Offset="0x8")]
		public GameObject HorizontalReference;

		[Attribute(Name="TooltipAttribute", RVA="0x106C0B4", Offset="0x106C0B4")]
		[FieldOffset(Offset="0x10")]
		public Vector3 Offset;

		[FieldOffset(Offset="0x1C")]
		public Vector3 LocalOffset;
	}
}