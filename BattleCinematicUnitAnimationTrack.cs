using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Timeline;

[Attribute(Name="TrackBindingTypeAttribute", RVA="0x1048700", Offset="0x1048700")]
[Attribute(Name="TrackClipTypeAttribute", RVA="0x1048700", Offset="0x1048700")]
[Attribute(Name="TrackColorAttribute", RVA="0x1048700", Offset="0x1048700")]
public class BattleCinematicUnitAnimationTrack : TrackAsset
{
	[FieldOffset(Offset="0x7C")]
	[SerializeField]
	private BattleCinematicUnitAnimationTrack.UnitType _unitType;

	public BattleCinematicUnitAnimationTrack.UnitType Type
	{
		[Address(RVA="0x113F294", Offset="0x113F294", VA="0x113F294")]
		get
		{
			return new BattleCinematicUnitAnimationTrack.UnitType();
		}
	}

	[Address(RVA="0x113F29C", Offset="0x113F29C", VA="0x113F29C")]
	public BattleCinematicUnitAnimationTrack()
	{
	}

	public enum UnitType
	{
		[FieldOffset(Offset="0x0")]
		Friendly,
		[FieldOffset(Offset="0x0")]
		Enemy
	}
}