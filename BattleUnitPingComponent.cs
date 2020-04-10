using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleUnitPingComponent : MonoBehaviour, IMonoArchetypePooledItem
{
	[FieldOffset(Offset="0x18")]
	private BattleUnit _unit;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private ParticleSystem _pingVfx;

	public bool IsPlaying
	{
		[Address(RVA="0x129F2DC", Offset="0x129F2DC", VA="0x129F2DC")]
		get
		{
			return new bool();
		}
	}

	public byte UnitId
	{
		[Address(RVA="0x129F30C", Offset="0x129F30C", VA="0x129F30C")]
		get
		{
			return new byte();
		}
	}

	[Address(RVA="0x129F4D8", Offset="0x129F4D8", VA="0x129F4D8")]
	public BattleUnitPingComponent()
	{
	}

	[Address(RVA="0x129F324", Offset="0x129F324", VA="0x129F324", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x129F36C", Offset="0x129F36C", VA="0x129F36C")]
	public void Play(BattleUnit unit)
	{
	}

	[Address(RVA="0x129F368", Offset="0x129F368", VA="0x129F368", Slot="6")]
	public void Reinitialize()
	{
	}

	[Address(RVA="0x129F328", Offset="0x129F328", VA="0x129F328", Slot="5")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x129F32C", Offset="0x129F32C", VA="0x129F32C")]
	private void Stop()
	{
	}

	[Address(RVA="0x129F42C", Offset="0x129F42C", VA="0x129F42C")]
	public void TickUpdate()
	{
	}
}