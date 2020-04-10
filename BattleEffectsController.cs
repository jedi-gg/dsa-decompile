using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BattleEffectsController : ILoggable<LogCategory>, IDispatchHandler<DBattleUnitsControllerAction>, IDispatchHandler, IDispatchHandler<BattleUnit.DPolymorphedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10531A4", Offset="0x10531A4")]
	[FieldOffset(Offset="0x10")]
	private DiContainer _diContainer;

	[Attribute(Name="InjectAttribute", RVA="0x10531B4", Offset="0x10531B4")]
	[FieldOffset(Offset="0x18")]
	private AssetRegistry _assetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x10531C4", Offset="0x10531C4")]
	[FieldOffset(Offset="0x20")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x10531D4", Offset="0x10531D4")]
	[FieldOffset(Offset="0x28")]
	private BattleUnitsController _unitsController;

	[Attribute(Name="InjectAttribute", RVA="0x10531E4", Offset="0x10531E4")]
	[FieldOffset(Offset="0x30")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x38")]
	private Dictionary<ulong, EffectVisualSequencer> _visualEffectArchetypes;

	[FieldOffset(Offset="0x40")]
	private List<EffectVisualSequencer> _activeEffects;

	[FieldOffset(Offset="0x48")]
	private GameObject _groundPlaneGo;

	public LogCategory LogCategory
	{
		[Address(RVA="0x1140B38", Offset="0x1140B38", VA="0x1140B38", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x1142250", Offset="0x1142250", VA="0x1142250")]
	public BattleEffectsController()
	{
	}

	[Address(RVA="0x1141A3C", Offset="0x1141A3C", VA="0x1141A3C")]
	public void ApplyPositionVisual(ulong visualId, Vector3 originPos, Vector3 targetPos, float expireTime, ushort sourceId)
	{
	}

	[Address(RVA="0x1141324", Offset="0x1141324", VA="0x1141324")]
	public void ApplyUnitVisual(ulong visualId, byte casterId, byte targetId, float expireTime, ushort sourceId)
	{
	}

	[Address(RVA="0x114180C", Offset="0x114180C", VA="0x114180C")]
	public void ApplyWorldVisual(ulong visualId, byte casterId, Vector3 targetPos, float expireTime, ushort sourceId)
	{
	}

	[Address(RVA="0x11415D0", Offset="0x11415D0", VA="0x11415D0")]
	private EffectVisualSequencer GetEffectVisual(ulong visualId)
	{
		return null;
	}

	[Address(RVA="0x1142174", Offset="0x1142174", VA="0x1142174")]
	private void HandleActionPreInitialize(ASequenceAction sequenceAction)
	{
	}

	[Address(RVA="0x1141E50", Offset="0x1141E50", VA="0x1141E50", Slot="5")]
	public void HandleDispatchAction(DBattleUnitsControllerAction action)
	{
	}

	[Address(RVA="0x1142034", Offset="0x1142034", VA="0x1142034", Slot="6")]
	public void HandleDispatchAction(BattleUnit.DPolymorphedAction action)
	{
	}

	[Address(RVA="0x1140B40", Offset="0x1140B40", VA="0x1140B40")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1141B70", Offset="0x1141B70", VA="0x1141B70")]
	public void InterruptVisual(ushort sourceId)
	{
	}

	[Address(RVA="0x1140F40", Offset="0x1140F40", VA="0x1140F40")]
	public void LoadAssets(HashSet<ulong> effectIds, Action finished)
	{
	}

	[Address(RVA="0x1140CA8", Offset="0x1140CA8", VA="0x1140CA8")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1141CC4", Offset="0x1141CC4", VA="0x1141CC4")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1141794", Offset="0x1141794", VA="0x1141794")]
	private float ToDuration(float expireTime)
	{
		return new float();
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AF7C", Offset="0x104AF7C")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public Dictionary<ulong, string> effectToAssetIdMap;

		[FieldOffset(Offset="0x18")]
		public BattleEffectsController <>4__this;

		[FieldOffset(Offset="0x20")]
		public Action finished;

		[Address(RVA="0x114131C", Offset="0x114131C", VA="0x114131C")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x11422C0", Offset="0x11422C0", VA="0x11422C0")]
		internal void <LoadAssets>b__0(AssetCollection collection)
		{
		}
	}
}