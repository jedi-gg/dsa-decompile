using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ChatChannelListGroupHeading : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private UiLabel _label;

	[Address(RVA="0x1196E2C", Offset="0x1196E2C", VA="0x1196E2C")]
	public ChatChannelListGroupHeading()
	{
	}

	[Address(RVA="0x1196D8C", Offset="0x1196D8C", VA="0x1196D8C")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1196DC8", Offset="0x1196DC8", VA="0x1196DC8")]
	public void SetLocKey(string locKey)
	{
	}

	[Address(RVA="0x1196DC0", Offset="0x1196DC0", VA="0x1196DC0")]
	public void Shutdown()
	{
	}
}