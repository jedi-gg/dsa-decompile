using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class Procrastinator
{
	[FieldOffset(Offset="0x10")]
	private List<Procrastinator.DelayedAction> _delayedActions;

	[Address(RVA="0x127E5E8", Offset="0x127E5E8", VA="0x127E5E8")]
	public Procrastinator()
	{
	}

	[Address(RVA="0x127E4B0", Offset="0x127E4B0", VA="0x127E4B0")]
	public void Delay(Action action, float delayS = 0f)
	{
	}

	[Address(RVA="0x127E1DC", Offset="0x127E1DC", VA="0x127E1DC")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x127E23C", Offset="0x127E23C", VA="0x127E23C")]
	public void TickUpdate()
	{
	}

	private class DelayedAction
	{
		[FieldOffset(Offset="0x10")]
		private readonly Action _action;

		[FieldOffset(Offset="0x18")]
		private readonly int _frameCount;

		[FieldOffset(Offset="0x1C")]
		private float _timer;

		[Address(RVA="0x127E54C", Offset="0x127E54C", VA="0x127E54C")]
		public DelayedAction(Action action, float delayS)
		{
		}

		[Address(RVA="0x127E49C", Offset="0x127E49C", VA="0x127E49C")]
		public void ExecuteAction()
		{
		}

		[Address(RVA="0x127E414", Offset="0x127E414", VA="0x127E414")]
		public bool IsExpired()
		{
			return new bool();
		}

		[Address(RVA="0x127E398", Offset="0x127E398", VA="0x127E398")]
		public void TickUpdate()
		{
		}
	}
}