using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="ExecuteInEditMode", RVA="0x1048EF8", Offset="0x1048EF8")]
public class UiParticleFitToLabel : MonoBehaviour, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x18")]
	private ParticleSystem _particleSystem;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private UiParticle _uiParticle;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UiLabel _label;

	public LogCategory LogCategory
	{
		[Address(RVA="0x1589384", Offset="0x1589384", VA="0x1589384", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	public ParticleSystem Particles
	{
		[Address(RVA="0x158938C", Offset="0x158938C", VA="0x158938C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1589804", Offset="0x1589804", VA="0x1589804")]
	public UiParticleFitToLabel()
	{
	}

	[Address(RVA="0x1589554", Offset="0x1589554", VA="0x1589554")]
	private void FitParticleSystemToLabel(ParticleSystem system, UiLabel label)
	{
	}

	[Address(RVA="0x1589394", Offset="0x1589394", VA="0x1589394")]
	private void OnEnable()
	{
	}

	[Address(RVA="0x1589428", Offset="0x1589428", VA="0x1589428")]
	private void Update()
	{
	}
}