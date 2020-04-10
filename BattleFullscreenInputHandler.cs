using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="RequireComponent", RVA="0x1048610", Offset="0x1048610")]
[Attribute(Name="RequireComponent", RVA="0x1048610", Offset="0x1048610")]
public class BattleFullscreenInputHandler : PressEventHandler
{
	[FieldOffset(Offset="0x58")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x60")]
	private CanvasGroup _canvasGroup;

	[Address(RVA="0x1148670", Offset="0x1148670", VA="0x1148670")]
	public BattleFullscreenInputHandler()
	{
	}

	[Address(RVA="0x11485D8", Offset="0x11485D8", VA="0x11485D8")]
	private void HandleLongPress()
	{
	}

	[Address(RVA="0x1148540", Offset="0x1148540", VA="0x1148540")]
	private void HandleShortRelease()
	{
	}

	[Address(RVA="0x1148398", Offset="0x1148398", VA="0x1148398")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11484C8", Offset="0x11484C8", VA="0x11484C8")]
	public void SetBlocksRaycast(bool blocksRaycast)
	{
	}

	[Address(RVA="0x1148500", Offset="0x1148500", VA="0x1148500")]
	public void Shutdown()
	{
	}
}