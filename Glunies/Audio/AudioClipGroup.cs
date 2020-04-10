using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Glunies.Audio
{
	[Attribute(Name="CreateAssetMenuAttribute", RVA="0x10499D4", Offset="0x10499D4")]
	[Attribute(Name="SequencerScriptableObjectAttribute", RVA="0x10499D4", Offset="0x10499D4")]
	public class AudioClipGroup : ScriptableObject, ILoggable<LogCategory>
	{
		[FieldOffset(Offset="0x18")]
		[NonSerialized]
		private Queue<int> _randomRepeatLimitedIndices;

		[FieldOffset(Offset="0x20")]
		[NonSerialized]
		private float _totalWeight;

		[FieldOffset(Offset="0x24")]
		[NonSerialized]
		private int _sequenceIndex;

		[FieldOffset(Offset="0x28")]
		[NonSerialized]
		private int _runtimeRandomRepeatLimit;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private List<AudioClipGroup.Clip> _clips;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private AudioClipGroup.GroupType _type;

		[FieldOffset(Offset="0x3C")]
		[SerializeField]
		private int _randomRepeatLimit;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private AudioClipGroup.StartTimeType _startTimeType;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private List<float> _startTimeSeconds;

		[Attribute(Name="TooltipAttribute", RVA="0x1064550", Offset="0x1064550")]
		[FieldOffset(Offset="0x50")]
		[SerializeField]
		private AudioClipGroup.GlobalPriority _priority;

		[Attribute(Name="TooltipAttribute", RVA="0x106459C", Offset="0x106459C")]
		[FieldOffset(Offset="0x54")]
		[SerializeField]
		private int _clipGroupLimitCount;

		[Attribute(Name="TooltipAttribute", RVA="0x10645E8", Offset="0x10645E8")]
		[FieldOffset(Offset="0x58")]
		[SerializeField]
		private AudioClipGroup.ClipGroupLimit _clipGroupLimitType;

		[FieldOffset(Offset="0x5C")]
		[SerializeField]
		private int _maxLoopCount;

		[FieldOffset(Offset="0x60")]
		[SerializeField]
		private AudioClipGroup _backupLoopClipGroup;

		[FieldOffset(Offset="0x68")]
		[SerializeField]
		private AnimationCurve _fadeInCurveFromBackupLoop;

		[FieldOffset(Offset="0x70")]
		[SerializeField]
		private AnimationCurve _fadeOutCurveToBackupLoop;

		[FieldOffset(Offset="0x78")]
		[SerializeField]
		private AudioClipGroup.Params _params;

		public bool AffectedByTimeScale
		{
			[Address(RVA="0x14FF6C0", Offset="0x14FF6C0", VA="0x14FF6C0")]
			get
			{
				return new bool();
			}
		}

		public AudioClipGroup BackupLoopClipGroup
		{
			[Address(RVA="0x14FF6F4", Offset="0x14FF6F4", VA="0x14FF6F4")]
			get
			{
				return null;
			}
		}

		public int ClipGroupLimitCount
		{
			[Address(RVA="0x14FF648", Offset="0x14FF648", VA="0x14FF648")]
			get
			{
				return new int();
			}
		}

		public AudioClipGroup.ClipGroupLimit ClipGroupLimitType
		{
			[Address(RVA="0x14FF650", Offset="0x14FF650", VA="0x14FF650")]
			get
			{
				return new AudioClipGroup.ClipGroupLimit();
			}
		}

		public AnimationCurve FadeInCurve
		{
			[Address(RVA="0x14FF658", Offset="0x14FF658", VA="0x14FF658")]
			get
			{
				return null;
			}
		}

		public AnimationCurve FadeInCurveFromBackupLoop
		{
			[Address(RVA="0x14FF6B0", Offset="0x14FF6B0", VA="0x14FF6B0")]
			get
			{
				return null;
			}
		}

		public AnimationCurve FadeOutCurve
		{
			[Address(RVA="0x14FF684", Offset="0x14FF684", VA="0x14FF684")]
			get
			{
				return null;
			}
		}

		public AnimationCurve FadeOutCurveToBackupLoop
		{
			[Address(RVA="0x14FF6B8", Offset="0x14FF6B8", VA="0x14FF6B8")]
			get
			{
				return null;
			}
		}

		public bool HasBackupLoop
		{
			[Address(RVA="0x14FF6FC", Offset="0x14FF6FC", VA="0x14FF6FC")]
			get
			{
				return new bool();
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x14FF638", Offset="0x14FF638", VA="0x14FF638", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		public bool Loops
		{
			[Address(RVA="0x14FF788", Offset="0x14FF788", VA="0x14FF788")]
			get
			{
				return new bool();
			}
		}

		public int MaxLoopCount
		{
			[Address(RVA="0x14FF6EC", Offset="0x14FF6EC", VA="0x14FF6EC")]
			get
			{
				return new int();
			}
		}

		public AudioClipGroup.GlobalPriority Priority
		{
			[Address(RVA="0x14FF640", Offset="0x14FF640", VA="0x14FF640")]
			get
			{
				return new AudioClipGroup.GlobalPriority();
			}
		}

		[Address(RVA="0x1500428", Offset="0x1500428", VA="0x1500428")]
		public AudioClipGroup()
		{
		}

		[Address(RVA="0x14FFF90", Offset="0x14FFF90", VA="0x14FFF90")]
		private AudioClip GetAudioClip()
		{
			return null;
		}

		[Address(RVA="0x14FFF44", Offset="0x14FFF44", VA="0x14FFF44")]
		public float GetDelay()
		{
			return new float();
		}

		[Address(RVA="0x1500330", Offset="0x1500330", VA="0x1500330")]
		private AudioClip GetNextSequenceAudioClip()
		{
			return null;
		}

		[Address(RVA="0x1500088", Offset="0x1500088", VA="0x1500088")]
		private AudioClip GetRandomAudioClip()
		{
			return null;
		}

		[Address(RVA="0x14FF7F0", Offset="0x14FF7F0", VA="0x14FF7F0")]
		private void Initialize()
		{
		}

		[Address(RVA="0x14FFA58", Offset="0x14FFA58", VA="0x14FFA58")]
		private void SetParamsOnAudioSource(AudioSource source, AudioMixerGroup fallbackMixerGroup)
		{
		}

		[Address(RVA="0x14FF7B4", Offset="0x14FF7B4", VA="0x14FF7B4")]
		public void SetupAudioSource(AudioSource audioSource, AudioMixerGroup fallbackMixerGroup)
		{
		}

		[Serializable]
		private class Clip
		{
			[FieldOffset(Offset="0x10")]
			public AudioClip AudioClip;

			[FieldOffset(Offset="0x18")]
			public float Weight;

			[Address(RVA="0x141609C", Offset="0x141609C", VA="0x141609C")]
			public Clip()
			{
			}
		}

		public enum ClipGroupLimit
		{
			[FieldOffset(Offset="0x0")]
			PreventNew,
			[FieldOffset(Offset="0x0")]
			StopOldest
		}

		public enum GlobalPriority
		{
			[FieldOffset(Offset="0x0")]
			Low,
			[FieldOffset(Offset="0x0")]
			Medium,
			[FieldOffset(Offset="0x0")]
			High
		}

		public enum GroupType
		{
			[FieldOffset(Offset="0x0")]
			Random,
			[FieldOffset(Offset="0x0")]
			Sequence
		}

		[Serializable]
		private class Params
		{
			[Attribute(Name="HeaderAttribute", RVA="0x106CAA4", Offset="0x106CAA4")]
			[FieldOffset(Offset="0x10")]
			public float DelayMin;

			[FieldOffset(Offset="0x14")]
			public float DelayMax;

			[FieldOffset(Offset="0x18")]
			public AnimationCurve FadeIn;

			[FieldOffset(Offset="0x20")]
			public AnimationCurve FadeOut;

			[Attribute(Name="HeaderAttribute", RVA="0x106CADC", Offset="0x106CADC")]
			[FieldOffset(Offset="0x28")]
			public AudioMixerGroup MixerGroup;

			[Attribute(Name="RangeAttribute", RVA="0x106CB14", Offset="0x106CB14")]
			[FieldOffset(Offset="0x30")]
			public int Priority;

			[Attribute(Name="RangeAttribute", RVA="0x106CB30", Offset="0x106CB30")]
			[Attribute(Name="TooltipAttribute", RVA="0x106CB30", Offset="0x106CB30")]
			[FieldOffset(Offset="0x34")]
			public float SpatialBlend;

			[FieldOffset(Offset="0x38")]
			public bool Loop;

			[Attribute(Name="HeaderAttribute", RVA="0x106CB84", Offset="0x106CB84")]
			[Attribute(Name="RangeAttribute", RVA="0x106CB84", Offset="0x106CB84")]
			[FieldOffset(Offset="0x3C")]
			public float VolumeMin;

			[Attribute(Name="RangeAttribute", RVA="0x106CBD8", Offset="0x106CBD8")]
			[FieldOffset(Offset="0x40")]
			public float VolumeMax;

			[Attribute(Name="RangeAttribute", RVA="0x106CBF0", Offset="0x106CBF0")]
			[FieldOffset(Offset="0x44")]
			public float PitchMin;

			[Attribute(Name="RangeAttribute", RVA="0x106CC08", Offset="0x106CC08")]
			[FieldOffset(Offset="0x48")]
			public float PitchMax;

			[Attribute(Name="RangeAttribute", RVA="0x106CC20", Offset="0x106CC20")]
			[FieldOffset(Offset="0x4C")]
			public float PanMin;

			[Attribute(Name="RangeAttribute", RVA="0x106CC38", Offset="0x106CC38")]
			[FieldOffset(Offset="0x50")]
			public float PanMax;

			[Attribute(Name="HeaderAttribute", RVA="0x106CC50", Offset="0x106CC50")]
			[Attribute(Name="RangeAttribute", RVA="0x106CC50", Offset="0x106CC50")]
			[FieldOffset(Offset="0x54")]
			public int Spread;

			[FieldOffset(Offset="0x58")]
			public AudioRolloffMode VolumeRolloff;

			[FieldOffset(Offset="0x5C")]
			public float MinDistance;

			[FieldOffset(Offset="0x60")]
			public float MaxDistance;

			[Attribute(Name="HeaderAttribute", RVA="0x106CCA8", Offset="0x106CCA8")]
			[FieldOffset(Offset="0x64")]
			public bool AffectedByTimeScale;

			[Address(RVA="0x14160A4", Offset="0x14160A4", VA="0x14160A4")]
			public Params()
			{
			}
		}

		public enum StartTimeType
		{
			[FieldOffset(Offset="0x0")]
			Beginning,
			[FieldOffset(Offset="0x0")]
			Random,
			[FieldOffset(Offset="0x0")]
			RandomSelection
		}
	}
}