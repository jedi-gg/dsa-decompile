using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="RequireComponent", RVA="0x1048994", Offset="0x1048994")]
public class HomeViewWorldIcon : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private Camera _mainCamera;

	[FieldOffset(Offset="0x20")]
	private Transform _worldTransform;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private HomeViewWorldIcon.WorldIconType _iconType;

	public HomeViewWorldIcon.WorldIconType IconType
	{
		[Address(RVA="0x1172E2C", Offset="0x1172E2C", VA="0x1172E2C")]
		get
		{
			return new HomeViewWorldIcon.WorldIconType();
		}
	}

	[Address(RVA="0x1176B1C", Offset="0x1176B1C", VA="0x1176B1C")]
	public HomeViewWorldIcon()
	{
	}

	[Address(RVA="0x1172E34", Offset="0x1172E34", VA="0x1172E34")]
	public void Initialize(Camera mainCamera, Transform worldTransform)
	{
	}

	[Address(RVA="0x11769C4", Offset="0x11769C4", VA="0x11769C4")]
	private void LateUpdate()
	{
	}

	[Address(RVA="0x1176258", Offset="0x1176258", VA="0x1176258")]
	public void Shutdown()
	{
	}

	public enum WorldIconType
	{
		[FieldOffset(Offset="0x0")]
		Invalid,
		[FieldOffset(Offset="0x0")]
		DailyEvents,
		[FieldOffset(Offset="0x0")]
		ScheduledEvents,
		[FieldOffset(Offset="0x0")]
		Clubs,
		[FieldOffset(Offset="0x0")]
		ClubDungeon,
		[FieldOffset(Offset="0x0")]
		Tower,
		[FieldOffset(Offset="0x0")]
		Koth,
		[FieldOffset(Offset="0x0")]
		ClubWar
	}
}