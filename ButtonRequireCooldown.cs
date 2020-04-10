using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="RequireComponent", RVA="0x1048B94", Offset="0x1048B94")]
public class ButtonRequireCooldown : MonoBehaviour, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x18")]
	public Action ClickedOnCooldown;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private InteractableOverrideButton _button;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UiLabel _timerLabel;

	[FieldOffset(Offset="0x30")]
	private UiTimerLabel _uiTimerLabel;

	public bool HasExpired
	{
		[Address(RVA="0x11231E0", Offset="0x11231E0", VA="0x11231E0")]
		get
		{
			return new bool();
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x11231D8", Offset="0x11231D8", VA="0x11231D8", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	public TimeSpan TimeRemaining
	{
		[Address(RVA="0x11231F8", Offset="0x11231F8", VA="0x11231F8")]
		get
		{
			return new TimeSpan();
		}
	}

	[Address(RVA="0x1123678", Offset="0x1123678", VA="0x1123678")]
	public ButtonRequireCooldown()
	{
	}

	[Address(RVA="0x1123228", Offset="0x1123228", VA="0x1123228")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11235F8", Offset="0x11235F8", VA="0x11235F8")]
	public void ResetState()
	{
	}

	[Address(RVA="0x1123600", Offset="0x1123600", VA="0x1123600")]
	public void SetCooldownElapsedTime(DateTime elapsed)
	{
	}

	[Address(RVA="0x112333C", Offset="0x112333C", VA="0x112333C")]
	private void ShowButtonTimer(bool showing)
	{
	}

	[Address(RVA="0x11235EC", Offset="0x11235EC", VA="0x11235EC")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x11232AC", Offset="0x11232AC", VA="0x11232AC")]
	public void TickUpdate()
	{
	}
}