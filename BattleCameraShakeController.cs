using DG.Tweening;
using DG.Tweening.Core;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleCameraShakeController : IDispatchHandler<DBattleDamageAction>, IDispatchHandler, IDispatchHandler<DBattleCameraShakeAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1053004", Offset="0x1053004")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x18")]
	private Tween[] _tweens;

	[FieldOffset(Offset="0x20")]
	private BattleCameraShakeIntensity _currentIntensity;

	[Address(RVA="0x1139E44", Offset="0x1139E44", VA="0x1139E44")]
	public BattleCameraShakeController()
	{
	}

	[Address(RVA="0x113995C", Offset="0x113995C", VA="0x113995C")]
	private void DefineShake(BattleCameraShakeIntensity intensity, float duration, float magnitude, int vibrato)
	{
	}

	[Address(RVA="0x1139D2C", Offset="0x1139D2C", VA="0x1139D2C")]
	private void DoShake(BattleCameraShakeIntensity intensity)
	{
	}

	[Address(RVA="0x1139D18", Offset="0x1139D18", VA="0x1139D18", Slot="4")]
	public void HandleDispatchAction(DBattleDamageAction action)
	{
	}

	[Address(RVA="0x1139E40", Offset="0x1139E40", VA="0x1139E40", Slot="5")]
	public void HandleDispatchAction(DBattleCameraShakeAction action)
	{
	}

	[Address(RVA="0x11398C8", Offset="0x11398C8", VA="0x11398C8")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1139C38", Offset="0x1139C38", VA="0x1139C38")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AF5C", Offset="0x104AF5C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static BattleCameraShakeController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static DOGetter<Vector3> <>9__4_0;

		[FieldOffset(Offset="0x10")]
		public static DOSetter<Vector3> <>9__4_1;

		[Address(RVA="0x1139EA4", Offset="0x1139EA4", VA="0x1139EA4")]
		static <>c()
		{
		}

		[Address(RVA="0x1139F08", Offset="0x1139F08", VA="0x1139F08")]
		public <>c()
		{
		}

		[Address(RVA="0x1139F10", Offset="0x1139F10", VA="0x1139F10")]
		internal Vector3 <DefineShake>b__4_0()
		{
			return new Vector3();
		}

		[Address(RVA="0x1139F7C", Offset="0x1139F7C", VA="0x1139F7C")]
		internal void <DefineShake>b__4_1(Vector3 x)
		{
		}
	}
}