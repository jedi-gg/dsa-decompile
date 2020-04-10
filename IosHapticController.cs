using Il2CppDummyDll;
using System;

public class IosHapticController : IHapticController
{
	[Attribute(Name="InjectAttribute", RVA="0x105D4C8", Offset="0x105D4C8")]
	[FieldOffset(Offset="0x10")]
	private SharedPrefs _sharedPrefs;

	[FieldOffset(Offset="0x18")]
	private bool _initialized;

	[FieldOffset(Offset="0x19")]
	private bool _enabled;

	[Address(RVA="0x137C508", Offset="0x137C508", VA="0x137C508")]
	public IosHapticController()
	{
	}

	[Address(RVA="0x137C4E8", Offset="0x137C4E8", VA="0x137C4E8")]
	private void _instantiateFeedbackGenerator(int id)
	{
	}

	[Address(RVA="0x137C500", Offset="0x137C500", VA="0x137C500")]
	private void _prepareFeedbackGenerator(int id)
	{
	}

	[Address(RVA="0x137C4F8", Offset="0x137C4F8", VA="0x137C4F8")]
	private void _releaseFeedbackGenerator(int id)
	{
	}

	[Address(RVA="0x137C504", Offset="0x137C504", VA="0x137C504")]
	private void _triggerFeedbackGenerator(int id, bool advanced)
	{
	}

	[Address(RVA="0x137C484", Offset="0x137C484", VA="0x137C484", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x137C4E0", Offset="0x137C4E0", VA="0x137C4E0", Slot="8")]
	public bool IsSupported()
	{
		return new bool();
	}

	[Address(RVA="0x137C4EC", Offset="0x137C4EC", VA="0x137C4EC", Slot="7")]
	public void SetEnabled(bool enabled)
	{
	}

	[Address(RVA="0x137C4D0", Offset="0x137C4D0", VA="0x137C4D0", Slot="5")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x137C4FC", Offset="0x137C4FC", VA="0x137C4FC", Slot="6")]
	public void Vibrate()
	{
	}

	public enum HapticType
	{
		[FieldOffset(Offset="0x0")]
		SelectionChange,
		[FieldOffset(Offset="0x0")]
		ImpactLight,
		[FieldOffset(Offset="0x0")]
		ImpactMedium,
		[FieldOffset(Offset="0x0")]
		ImpactHeavy,
		[FieldOffset(Offset="0x0")]
		Success,
		[FieldOffset(Offset="0x0")]
		Warning,
		[FieldOffset(Offset="0x0")]
		Failure,
		[FieldOffset(Offset="0x0")]
		None
	}
}