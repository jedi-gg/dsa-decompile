using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public abstract class ASequenceAction : ScriptableObject
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065078", Offset="0x1065078")]
		[FieldOffset(Offset="0x18")]
		private float <TimeActive>k__BackingField;

		[FieldOffset(Offset="0x1C")]
		[SerializeField]
		private ASequenceAction.PlayMode _playMode;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private float _playTime;

		[FieldOffset(Offset="0x24")]
		private ASequenceAction.State _state;

		protected ASequenceAction.State CurrentState
		{
			[Address(RVA="0x152B0CC", Offset="0x152B0CC", VA="0x152B0CC")]
			get
			{
				return new ASequenceAction.State();
			}
		}

		public virtual float Duration
		{
			[Address(RVA="0x152B00C", Offset="0x152B00C", VA="0x152B00C", Slot="4")]
			get
			{
				return new float();
			}
		}

		public ASequenceAction.PlayMode Mode
		{
			[Address(RVA="0x152AFFC", Offset="0x152AFFC", VA="0x152AFFC")]
			get
			{
				return new ASequenceAction.PlayMode();
			}
		}

		public float PlayTime
		{
			[Address(RVA="0x152B004", Offset="0x152B004", VA="0x152B004")]
			get
			{
				return new float();
			}
		}

		protected float TimeActive
		{
			[Address(RVA="0x152B0AC", Offset="0x152B0AC", VA="0x152B0AC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A8B0", Offset="0x108A8B0")]
			get
			{
				return new float();
			}
			[Address(RVA="0x152B028", Offset="0x152B028", VA="0x152B028")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A8C0", Offset="0x108A8C0")]
			private set
			{
			}
		}

		[Address(RVA="0x152B118", Offset="0x152B118", VA="0x152B118")]
		protected ASequenceAction()
		{
		}

		[Address(RVA="0x152B0B4", Offset="0x152B0B4", VA="0x152B0B4")]
		public void BeginExiting()
		{
		}

		[Address(RVA="0x152B0D4", Offset="0x152B0D4", VA="0x152B0D4")]
		public void Exit()
		{
		}

		[Address(RVA="0x152B030", Offset="0x152B030", VA="0x152B030", Slot="6")]
		public virtual float? GetOverrideSequenceDuration()
		{
			return null;
		}

		public abstract void Initialize(List<Binding> bindings);

		[Address(RVA="0x152B10C", Offset="0x152B10C", VA="0x152B10C", Slot="10")]
		protected virtual void InternalExit()
		{
		}

		protected abstract void InternalPlay();

		[Address(RVA="0x152B108", Offset="0x152B108", VA="0x152B108", Slot="9")]
		protected virtual void InternalTickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x152B104", Offset="0x152B104", VA="0x152B104", Slot="7")]
		public virtual void InvalidateGameObject(GameObject go)
		{
		}

		[Address(RVA="0x152B014", Offset="0x152B014", VA="0x152B014")]
		public void Play()
		{
		}

		[Address(RVA="0x152B110", Offset="0x152B110", VA="0x152B110", Slot="11")]
		protected virtual bool ShouldTickUpdate()
		{
			return new bool();
		}

		[Address(RVA="0x152B038", Offset="0x152B038", VA="0x152B038")]
		public void TickUpdate(float deltaTime)
		{
		}

		public enum PlayMode
		{
			[FieldOffset(Offset="0x0")]
			Start,
			[FieldOffset(Offset="0x0")]
			Time,
			[FieldOffset(Offset="0x0")]
			End,
			[FieldOffset(Offset="0x0")]
			FromEnd
		}

		protected enum State
		{
			[FieldOffset(Offset="0x0")]
			Playing,
			[FieldOffset(Offset="0x0")]
			Exiting,
			[FieldOffset(Offset="0x0")]
			Exited
		}
	}
}