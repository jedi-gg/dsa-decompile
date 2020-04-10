using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class UiInputReactController
{
	[Attribute(Name="InjectAttribute", RVA="0x105EF78", Offset="0x105EF78")]
	[FieldOffset(Offset="0x10")]
	private InputSystem _inputSystem;

	[FieldOffset(Offset="0x18")]
	private List<UiInputSquish> _activeSquishes;

	[Address(RVA="0x158619C", Offset="0x158619C", VA="0x158619C")]
	public UiInputReactController()
	{
	}

	[Address(RVA="0x158606C", Offset="0x158606C", VA="0x158606C")]
	public void AddActiveSquish(UiInputSquish squish)
	{
	}

	[Address(RVA="0x15860DC", Offset="0x15860DC", VA="0x15860DC")]
	private void ButtonPressed(GameObject gameObject)
	{
	}

	[Address(RVA="0x1585C3C", Offset="0x1585C3C", VA="0x1585C3C")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1585D58", Offset="0x1585D58", VA="0x1585D58")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1585E10", Offset="0x1585E10", VA="0x1585E10")]
	public void TickUpdate()
	{
	}
}