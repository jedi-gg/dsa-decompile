using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class UnitVisualSequencerFactory : ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x105F1A8", Offset="0x105F1A8")]
	[FieldOffset(Offset="0x10")]
	private AssetRegistry _assetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x105F1B8", Offset="0x105F1B8")]
	[FieldOffset(Offset="0x18")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x20")]
	private DiContainer _diContainer;

	[FieldOffset(Offset="0x28")]
	private Dictionary<UnitVisualSequencerType, UnitVisualSequencer> _fallbackSequencers;

	[FieldOffset(Offset="0x30")]
	private bool _initialized;

	public LogCategory LogCategory
	{
		[Address(RVA="0x15188EC", Offset="0x15188EC", VA="0x15188EC", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x1519290", Offset="0x1519290", VA="0x1519290")]
	public UnitVisualSequencerFactory()
	{
	}

	[Address(RVA="0x1518BB0", Offset="0x1518BB0", VA="0x1518BB0")]
	private string GetFallbackAssetId(UnitVisualSequencerType type)
	{
		return null;
	}

	[Address(RVA="0x15191B4", Offset="0x15191B4", VA="0x15191B4")]
	private void HandleVisualActionPreInitialize(ASequenceAction sequenceAction)
	{
	}

	[Address(RVA="0x15188F4", Offset="0x15188F4", VA="0x15188F4")]
	public void Initialize(Action finished, DiContainer diContainer, params UnitVisualSequencerType[] types)
	{
	}

	[Address(RVA="0x1518E34", Offset="0x1518E34", VA="0x1518E34")]
	public UnitVisualSequencer InstantiateVisualSequencer(UnitVisualSequencerType type, Transform unit)
	{
		return null;
	}

	[Address(RVA="0x1518DB4", Offset="0x1518DB4", VA="0x1518DB4")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CFBC", Offset="0x104CFBC")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public string[] visualFallbackAssetIds;

		[FieldOffset(Offset="0x18")]
		public UnitVisualSequencerFactory <>4__this;

		[FieldOffset(Offset="0x20")]
		public UnitVisualSequencerType[] types;

		[FieldOffset(Offset="0x28")]
		public Action finished;

		[Address(RVA="0x1518BA8", Offset="0x1518BA8", VA="0x1518BA8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1519298", Offset="0x1519298", VA="0x1519298")]
		internal void <Initialize>b__0(AssetCollection assets)
		{
		}
	}
}