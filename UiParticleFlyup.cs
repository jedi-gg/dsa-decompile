using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

[Attribute(Name="RequireComponent", RVA="0x1048F08", Offset="0x1048F08")]
public class UiParticleFlyup : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private const float PARTICLE_DURATION = 0.3f;

	[FieldOffset(Offset="0x0")]
	private const float PARTICLE_DLEAY = 0f;

	[FieldOffset(Offset="0x18")]
	private List<ParticleSystem.Particle> _triggerParticles;

	[FieldOffset(Offset="0x20")]
	private UiParticle _uiParticle;

	[FieldOffset(Offset="0x28")]
	private ParticleSystem _particleSystem;

	[FieldOffset(Offset="0x30")]
	private Material _particleSystemMaterial;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private RectTransform _forceFieldRectTransform;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private ParticleSystem _collisionParticles;

	public bool IsPlaying
	{
		[Address(RVA="0x1589840", Offset="0x1589840", VA="0x1589840")]
		get
		{
			return new bool();
		}
	}

	public Transform Root
	{
		[Address(RVA="0x158980C", Offset="0x158980C", VA="0x158980C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x158A050", Offset="0x158A050", VA="0x158A050")]
	public UiParticleFlyup()
	{
	}

	[Address(RVA="0x1589D58", Offset="0x1589D58", VA="0x1589D58")]
	private void Awake()
	{
	}

	[Address(RVA="0x15899F4", Offset="0x15899F4", VA="0x15899F4")]
	private void ConfigureParticles(int count)
	{
	}

	[Address(RVA="0x1589870", Offset="0x1589870", VA="0x1589870")]
	public void FlyTo(Vector3 targetScreenPos, Vector3 sourceScreenPos, int particleCount)
	{
	}

	[Address(RVA="0x1589E08", Offset="0x1589E08", VA="0x1589E08")]
	private void OnParticleTrigger()
	{
	}

	[Address(RVA="0x1589CC0", Offset="0x1589CC0", VA="0x1589CC0")]
	public void SetTexture(Texture tex)
	{
	}

	[Address(RVA="0x1589C68", Offset="0x1589C68", VA="0x1589C68")]
	public void Stop()
	{
	}

	[Address(RVA="0x1589EE8", Offset="0x1589EE8", VA="0x1589EE8")]
	private bool StopParticle(ParticleSystemTriggerEventType eventType)
	{
		return new bool();
	}
}