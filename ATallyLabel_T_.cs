using Glunies;
using Il2CppDummyDll;
using System;

public abstract class ATallyLabel<T> : UiLabel
where T : struct
{
	[FieldOffset(Offset="0x0")]
	protected T _startValue;

	[FieldOffset(Offset="0x0")]
	protected T _endValue;

	[FieldOffset(Offset="0x0")]
	protected float _timer;

	[FieldOffset(Offset="0x0")]
	protected float _duration;

	[FieldOffset(Offset="0x0")]
	protected Nullable<T> _denominator;

	[FieldOffset(Offset="0x0")]
	protected bool _abbreviated;

	[FieldOffset(Offset="0x0")]
	private EaseUtil.EaseFunction _easeFunction;

	public bool IsTallying
	{
		[Address(RVA="0x211EF64", Offset="0x211EF64", VA="0x211EF64")]
		get
		{
			return new bool();
		}
	}

	public float TallyDurationRemaining
	{
		[Address(RVA="0x211EF78", Offset="0x211EF78", VA="0x211EF78")]
		get
		{
			return new float();
		}
	}

	[Address(RVA="0x211F238", Offset="0x211F238", VA="0x211F238")]
	protected ATallyLabel()
	{
	}

	[Address(RVA="0x211F094", Offset="0x211F094", VA="0x211F094")]
	public void FastForward()
	{
	}

	public abstract T GetCurrentValue();

	[Address(RVA="0x211F014", Offset="0x211F014", VA="0x211F014")]
	public T GetEndValue()
	{
		return null;
	}

	[Address(RVA="0x211F1CC", Offset="0x211F1CC", VA="0x211F1CC")]
	protected float GetNormalizedTime()
	{
		return new float();
	}

	public abstract T GetValueAtTime(float t);

	[Address(RVA="0x211F01C", Offset="0x211F01C", VA="0x211F01C")]
	public void Sample(float seconds)
	{
	}

	[Address(RVA="0x211EFFC", Offset="0x211EFFC", VA="0x211EFFC")]
	public void SetAbbreviated(bool abbreviated)
	{
	}

	[Address(RVA="0x211EFF0", Offset="0x211EFF0", VA="0x211EFF0")]
	public void SetDenominator(Nullable<T> denominator)
	{
	}

	[Address(RVA="0x211EFCC", Offset="0x211EFCC", VA="0x211EFCC")]
	public void SetDuration(float duration)
	{
	}

	[Address(RVA="0x211F00C", Offset="0x211F00C", VA="0x211F00C")]
	public void SetEaseFunction(EaseUtil.EaseFunction easeFunction)
	{
	}

	protected abstract void SetLabelValue(T currentValue);

	[Address(RVA="0x211EF88", Offset="0x211EF88", VA="0x211EF88")]
	public void SetTallyValues(T startValue, T endValue)
	{
	}

	[Address(RVA="0x211EFDC", Offset="0x211EFDC", VA="0x211EFDC")]
	public void Tally()
	{
	}

	[Address(RVA="0x211EFE4", Offset="0x211EFE4", VA="0x211EFE4")]
	public void Tally(float delay)
	{
	}

	[Address(RVA="0x211F0D8", Offset="0x211F0D8", VA="0x211F0D8")]
	protected void Update()
	{
	}
}