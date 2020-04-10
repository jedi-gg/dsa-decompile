using Il2CppDummyDll;
using System;
using UnityEngine;

public class AndroidHapticController : IHapticController
{
	[FieldOffset(Offset="0x0")]
	private const int NEW_SDK_VERSION = 26;

	[FieldOffset(Offset="0x0")]
	private const long DEFAULT_VIBRATE_MS = 500L;

	[Attribute(Name="InjectAttribute", RVA="0x105D4B8", Offset="0x105D4B8")]
	[FieldOffset(Offset="0x10")]
	private SharedPrefs _sharedPrefs;

	[FieldOffset(Offset="0x18")]
	private AndroidJavaObject _vibrator;

	[FieldOffset(Offset="0x20")]
	private AndroidJavaClass _vibrationEffectClass;

	[FieldOffset(Offset="0x28")]
	private int _defaultAmplitude;

	[FieldOffset(Offset="0x2C")]
	private int _sdkVersion;

	[FieldOffset(Offset="0x30")]
	private bool _initialized;

	[FieldOffset(Offset="0x31")]
	private bool _enabled;

	[Address(RVA="0x115AF2C", Offset="0x115AF2C", VA="0x115AF2C")]
	public AndroidHapticController()
	{
	}

	[Address(RVA="0x115AE9C", Offset="0x115AE9C", VA="0x115AE9C")]
	private void Cancel()
	{
	}

	[Address(RVA="0x115A5B4", Offset="0x115A5B4", VA="0x115A5B4")]
	private void CreateOneShot(long milliseconds)
	{
	}

	[Address(RVA="0x115A5E0", Offset="0x115A5E0", VA="0x115A5E0")]
	private void CreateOneShot(long milliseconds, int amplitude)
	{
	}

	[Address(RVA="0x115A86C", Offset="0x115A86C", VA="0x115A86C")]
	private void CreateVibrationEffect(string function, params object[] args)
	{
	}

	[Address(RVA="0x115A984", Offset="0x115A984", VA="0x115A984")]
	private void CreateWaveform(long[] timings, int repeat)
	{
	}

	[Address(RVA="0x115AC44", Offset="0x115AC44", VA="0x115AC44")]
	private void CreateWaveform(long[] timings, int[] amplitudes, int repeat)
	{
	}

	[Address(RVA="0x115ADFC", Offset="0x115ADFC", VA="0x115ADFC")]
	private bool HasAmplitudeControl()
	{
		return new bool();
	}

	[Address(RVA="0x115A054", Offset="0x115A054", VA="0x115A054", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x115A5D8", Offset="0x115A5D8", VA="0x115A5D8", Slot="8")]
	public bool IsSupported()
	{
		return new bool();
	}

	[Address(RVA="0x115A768", Offset="0x115A768", VA="0x115A768")]
	private void OldSdkVibrate(long milliseconds)
	{
	}

	[Address(RVA="0x115AAF0", Offset="0x115AAF0", VA="0x115AAF0")]
	private void OldSdkVibrate(long[] pattern, int repeat)
	{
	}

	[Address(RVA="0x115A584", Offset="0x115A584", VA="0x115A584", Slot="7")]
	public void SetEnabled(bool enabled)
	{
	}

	[Address(RVA="0x115A578", Offset="0x115A578", VA="0x115A578", Slot="5")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x115A590", Offset="0x115A590", VA="0x115A590", Slot="6")]
	public void Vibrate()
	{
	}
}