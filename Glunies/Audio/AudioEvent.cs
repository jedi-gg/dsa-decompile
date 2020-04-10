using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Audio;

namespace Glunies.Audio
{
	public class AudioEvent
	{
		[FieldOffset(Offset="0x10")]
		private readonly AudioSource _audioSource;

		[FieldOffset(Offset="0x18")]
		private readonly Transform _audioSourceTransform;

		[FieldOffset(Offset="0x20")]
		private Transform _eventSourceTransform;

		[FieldOffset(Offset="0x28")]
		private Glunies.Audio.AudioClipGroup _audioClipGroup;

		[FieldOffset(Offset="0x30")]
		private AnimationCurve _fadeInCurve;

		[FieldOffset(Offset="0x38")]
		private AnimationCurve _fadeOutCurve;

		[FieldOffset(Offset="0x40")]
		private float _fadeInDuration;

		[FieldOffset(Offset="0x44")]
		private float _fadeOutDuration;

		[FieldOffset(Offset="0x48")]
		private float _fadeOutToBackupLoopDuration;

		[FieldOffset(Offset="0x4C")]
		private AudioEvent.State _state;

		[FieldOffset(Offset="0x50")]
		private float _timer;

		[FieldOffset(Offset="0x54")]
		private float _initialVolume;

		[FieldOffset(Offset="0x58")]
		private float _initialPitch;

		[FieldOffset(Offset="0x5C")]
		private float _timeScale;

		public Glunies.Audio.AudioClipGroup AudioClipGroup
		{
			[Address(RVA="0x1416100", Offset="0x1416100", VA="0x1416100")]
			get
			{
				return null;
			}
		}

		public bool IsFadingOut
		{
			[Address(RVA="0x14160E0", Offset="0x14160E0", VA="0x14160E0")]
			get
			{
				return new bool();
			}
		}

		public bool IsFadingOutIntoBackupLoop
		{
			[Address(RVA="0x14160F0", Offset="0x14160F0", VA="0x14160F0")]
			get
			{
				return new bool();
			}
		}

		public bool IsPlaying
		{
			[Address(RVA="0x14160D0", Offset="0x14160D0", VA="0x14160D0")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x1416108", Offset="0x1416108", VA="0x1416108")]
		public AudioEvent(AudioSource audioSource)
		{
		}

		[Address(RVA="0x1416D6C", Offset="0x1416D6C", VA="0x1416D6C")]
		private void FadeInVolume(float time)
		{
		}

		[Address(RVA="0x1416E88", Offset="0x1416E88", VA="0x1416E88")]
		private void FadeOutVolume(float time)
		{
		}

		[Address(RVA="0x1416764", Offset="0x1416764", VA="0x1416764")]
		private float GetAnimationCurveDuration(AnimationCurve animCurve)
		{
			return new float();
		}

		[Address(RVA="0x1416194", Offset="0x1416194", VA="0x1416194")]
		public void Play(Glunies.Audio.AudioClipGroup audioClipGroup, Transform eventSourceTransform, AudioMixerGroup fallbackMixerGroup, bool useBackupLoopFadeIn = false)
		{
		}

		[Address(RVA="0x1416150", Offset="0x1416150", VA="0x1416150")]
		public void Reset()
		{
		}

		[Address(RVA="0x14164FC", Offset="0x14164FC", VA="0x14164FC")]
		private void SetFadeInCurve(AnimationCurve curve)
		{
		}

		[Address(RVA="0x1416524", Offset="0x1416524", VA="0x1416524")]
		private void SetFadeOutCurve(AnimationCurve curve)
		{
		}

		[Address(RVA="0x14166B4", Offset="0x14166B4", VA="0x14166B4")]
		private void StartFadeInAndPlay()
		{
		}

		[Address(RVA="0x1416DD4", Offset="0x1416DD4", VA="0x1416DD4")]
		public void StartFadeOut()
		{
		}

		[Address(RVA="0x1416E18", Offset="0x1416E18", VA="0x1416E18")]
		private void StartFadeOutIntoBackupLoop()
		{
		}

		[Address(RVA="0x141682C", Offset="0x141682C", VA="0x141682C")]
		public void TickUpdate()
		{
		}

		[Address(RVA="0x141654C", Offset="0x141654C", VA="0x141654C")]
		private void UpdateSpatialPosition()
		{
		}

		private enum State
		{
			[FieldOffset(Offset="0x0")]
			Stopped,
			[FieldOffset(Offset="0x0")]
			Delay,
			[FieldOffset(Offset="0x0")]
			FadeIn,
			[FieldOffset(Offset="0x0")]
			Playing,
			[FieldOffset(Offset="0x0")]
			FadeOut,
			[FieldOffset(Offset="0x0")]
			FadeOutIntoBackupLoop
		}
	}
}