using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleUnitHitReactionController : ILoggable<LogCategory>, IDispatchHandler<DBattleUnitsControllerAction>, IDispatchHandler, IDispatchHandler<DBattleDamageAction>
{
	[FieldOffset(Offset="0x0")]
	private const float HIT_REACTION_DURATION = 0.15f;

	[FieldOffset(Offset="0x0")]
	private const float HIT_REACTION_RIM_MIN = 0f;

	[FieldOffset(Offset="0x0")]
	private const float HIT_REACTION_RIM_MAX = 1f;

	[FieldOffset(Offset="0x0")]
	private readonly static Vector3 s_hitReactionScale;

	[FieldOffset(Offset="0xC")]
	private readonly static Color s_hitReactionColor;

	[Attribute(Name="InjectAttribute", RVA="0x1053FD0", Offset="0x1053FD0")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x18")]
	private Dictionary<byte, BattleUnitHitReactionController.HitReaction> _activeHitReactions;

	[FieldOffset(Offset="0x20")]
	private Stack<BattleUnitHitReactionController.HitReaction> _inactiveHitReactions;

	public LogCategory LogCategory
	{
		[Address(RVA="0x129E7B0", Offset="0x129E7B0", VA="0x129E7B0", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x129F064", Offset="0x129F064", VA="0x129F064")]
	static BattleUnitHitReactionController()
	{
	}

	[Address(RVA="0x129EFC4", Offset="0x129EFC4", VA="0x129EFC4")]
	public BattleUnitHitReactionController()
	{
	}

	[Address(RVA="0x129EB28", Offset="0x129EB28", VA="0x129EB28", Slot="5")]
	public void HandleDispatchAction(DBattleUnitsControllerAction action)
	{
	}

	[Address(RVA="0x129EDF4", Offset="0x129EDF4", VA="0x129EDF4", Slot="6")]
	public void HandleDispatchAction(DBattleDamageAction action)
	{
	}

	[Address(RVA="0x129E7B8", Offset="0x129E7B8", VA="0x129E7B8")]
	public void Initialize()
	{
	}

	[Address(RVA="0x129E8A0", Offset="0x129E8A0", VA="0x129E8A0")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x129E944", Offset="0x129E944", VA="0x129E944")]
	public void TickUpdate()
	{
	}

	private class HitReaction
	{
		[FieldOffset(Offset="0x10")]
		private BattleUnit _unit;

		[FieldOffset(Offset="0x18")]
		private float _timer;

		public bool IsActive
		{
			[Address(RVA="0x129EECC", Offset="0x129EECC", VA="0x129EECC")]
			get
			{
				return new bool();
			}
		}

		public BattleUnit Unit
		{
			[Address(RVA="0x129F104", Offset="0x129F104", VA="0x129F104")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x129E878", Offset="0x129E878", VA="0x129E878")]
		public HitReaction()
		{
		}

		[Address(RVA="0x129EEDC", Offset="0x129EEDC", VA="0x129EEDC")]
		public void Play()
		{
		}

		[Address(RVA="0x129EDD0", Offset="0x129EDD0", VA="0x129EDD0")]
		public void Reset()
		{
		}

		[Address(RVA="0x129F10C", Offset="0x129F10C", VA="0x129F10C")]
		private void ResetValues()
		{
		}

		[Address(RVA="0x129EDC8", Offset="0x129EDC8", VA="0x129EDC8")]
		public void SetUnit(BattleUnit unit)
		{
		}

		[Address(RVA="0x129EA88", Offset="0x129EA88", VA="0x129EA88")]
		public void TickUpdate()
		{
		}
	}
}