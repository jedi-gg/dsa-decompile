using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Inferno
{
	public class AbilityPreview : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private List<AbilityPreview.DTargetUnit> _targetUnits;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private List<AbilityPreview.DTargetPos> _targetPositions;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private List<AbilityPreview.DVisualGroup> _visualGroups;

		[FieldOffset(Offset="0x30")]
		private EffectVisualPlayer _player;

		[FieldOffset(Offset="0x38")]
		private Dictionary<string, GameObject> _targetUnitsById;

		[FieldOffset(Offset="0x40")]
		private Dictionary<string, Vector3> _targetPositionsById;

		[FieldOffset(Offset="0x48")]
		private bool _isPlaying;

		[FieldOffset(Offset="0x4C")]
		private float _playTimeS;

		[FieldOffset(Offset="0x50")]
		private float? _interruptTimeS;

		[FieldOffset(Offset="0x58")]
		private GameObject _currentCaster;

		public bool IsPlaying
		{
			[Address(RVA="0x142C23C", Offset="0x142C23C", VA="0x142C23C")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x142D25C", Offset="0x142D25C", VA="0x142D25C")]
		public AbilityPreview()
		{
		}

		[Address(RVA="0x142D064", Offset="0x142D064", VA="0x142D064")]
		private EffectVisualPlayer.DPlayContext BuildPlayContext(AbilityPreview.DVisual visual)
		{
			return new EffectVisualPlayer.DPlayContext();
		}

		[Address(RVA="0x142CD6C", Offset="0x142CD6C", VA="0x142CD6C")]
		public float CalculateDurationS()
		{
			return new float();
		}

		[Address(RVA="0x142C244", Offset="0x142C244", VA="0x142C244")]
		public void Initialize(EffectVisualPlayer player)
		{
		}

		[Address(RVA="0x142C808", Offset="0x142C808", VA="0x142C808")]
		private void Interrupt()
		{
		}

		[Address(RVA="0x142CD20", Offset="0x142CD20", VA="0x142CD20")]
		public void Play(GameObject caster, float? interruptAtS)
		{
		}

		[Address(RVA="0x142CBF0", Offset="0x142CBF0", VA="0x142CBF0")]
		private void ResetForStop()
		{
		}

		[Address(RVA="0x142C508", Offset="0x142C508", VA="0x142C508")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x142C844", Offset="0x142C844", VA="0x142C844")]
		private void StartVisuals()
		{
		}

		[Address(RVA="0x142C5A0", Offset="0x142C5A0", VA="0x142C5A0")]
		public void Stop()
		{
		}

		[Address(RVA="0x142C5F0", Offset="0x142C5F0", VA="0x142C5F0")]
		public void TickUpdate()
		{
		}

		[Serializable]
		private class DTargetPos
		{
			[FieldOffset(Offset="0x10")]
			public string Id;

			[FieldOffset(Offset="0x18")]
			public Vector3 PosOffset;

			[Address(RVA="0x142D2F4", Offset="0x142D2F4", VA="0x142D2F4")]
			public DTargetPos()
			{
			}
		}

		[Serializable]
		private class DTargetUnit
		{
			[FieldOffset(Offset="0x10")]
			public string Id;

			[FieldOffset(Offset="0x18")]
			public GameObject Unit;

			[Address(RVA="0x142D2FC", Offset="0x142D2FC", VA="0x142D2FC")]
			public DTargetUnit()
			{
			}
		}

		[Serializable]
		private class DVisual
		{
			[FieldOffset(Offset="0x10")]
			public EffectVisualSequencer Sequencer;

			[FieldOffset(Offset="0x18")]
			public string CasterId;

			[FieldOffset(Offset="0x20")]
			public string TargetId;

			[FieldOffset(Offset="0x28")]
			public string OriginId;

			[FieldOffset(Offset="0x30")]
			public float DurationS;

			[FieldOffset(Offset="0x34")]
			public bool Interruptable;

			[Address(RVA="0x142D304", Offset="0x142D304", VA="0x142D304")]
			public DVisual()
			{
			}
		}

		[Serializable]
		private class DVisualGroup
		{
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106CCF0", Offset="0x106CCF0")]
			[FieldOffset(Offset="0x10")]
			private bool <HasStarted>k__BackingField;

			[FieldOffset(Offset="0x18")]
			public string GroupName;

			[FieldOffset(Offset="0x20")]
			public float StartDelayS;

			[FieldOffset(Offset="0x28")]
			public List<AbilityPreview.DVisual> Visuals;

			public bool HasStarted
			{
				[Address(RVA="0x142CBE8", Offset="0x142CBE8", VA="0x142CBE8")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E5B4", Offset="0x108E5B4")]
				get
				{
					return new bool();
				}
				[Address(RVA="0x142D250", Offset="0x142D250", VA="0x142D250")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E5C4", Offset="0x108E5C4")]
				set
				{
				}
			}

			[Address(RVA="0x142D314", Offset="0x142D314", VA="0x142D314")]
			public DVisualGroup()
			{
			}
		}
	}
}