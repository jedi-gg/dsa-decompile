using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

[Attribute(Name="ExecuteInEditMode", RVA="0x1048F6C", Offset="0x1048F6C")]
public class UiParticleStream : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	public Action ParticleCollided;

	[FieldOffset(Offset="0x0")]
	private const float ATTRACTOR_REFERENCE_MAGNITUDE = 3000f;

	[FieldOffset(Offset="0x20")]
	private List<ParticleSystem.Particle> _triggerParticles;

	[FieldOffset(Offset="0x28")]
	private RectTransform _attractorTarget;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ParticleSystem _particleSystem;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UiParticleStreamAttractor _uiParticleStreamAttractor;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private float _attractorRadiusScale;

	[Address(RVA="0x158AC38", Offset="0x158AC38", VA="0x158AC38")]
	public UiParticleStream()
	{
	}

	[Address(RVA="0x158A32C", Offset="0x158A32C", VA="0x158A32C")]
	public void ConfigureParticles(long count, float duration, float delay = 0f)
	{
	}

	[Address(RVA="0x158A77C", Offset="0x158A77C", VA="0x158A77C")]
	public bool IsPlaying()
	{
		return new bool();
	}

	[Address(RVA="0x158A8DC", Offset="0x158A8DC", VA="0x158A8DC")]
	private void OnParticleTrigger()
	{
	}

	[Address(RVA="0x158A620", Offset="0x158A620", VA="0x158A620")]
	public void Play()
	{
	}

	[Address(RVA="0x158A694", Offset="0x158A694", VA="0x158A694")]
	public void Play(float overrideDuration)
	{
	}

	[Address(RVA="0x158A1C8", Offset="0x158A1C8", VA="0x158A1C8")]
	private void ResizeAttractor()
	{
	}

	[Address(RVA="0x158A324", Offset="0x158A324", VA="0x158A324")]
	public void SetAttractorTarget(RectTransform rect)
	{
	}

	[Address(RVA="0x158A160", Offset="0x158A160", VA="0x158A160")]
	public void SetEmitterPosition(Vector3 screenPos)
	{
	}

	[Address(RVA="0x158A0C0", Offset="0x158A0C0", VA="0x158A0C0")]
	public void SetTexture(Texture particleTexture)
	{
	}

	[Address(RVA="0x158A744", Offset="0x158A744", VA="0x158A744")]
	public void Stop()
	{
	}

	[Address(RVA="0x158A7AC", Offset="0x158A7AC", VA="0x158A7AC")]
	private void Update()
	{
	}
}