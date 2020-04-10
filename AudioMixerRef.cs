using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerRef : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	protected UnityEngine.Audio.AudioMixer _audioMixer;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	protected AudioMixerGroup _fallbackMixerGroup;

	public UnityEngine.Audio.AudioMixer AudioMixer
	{
		[Address(RVA="0x115D84C", Offset="0x115D84C", VA="0x115D84C")]
		get
		{
			return null;
		}
	}

	public AudioMixerGroup FallbackMixerGroup
	{
		[Address(RVA="0x115D854", Offset="0x115D854", VA="0x115D854")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x115D85C", Offset="0x115D85C", VA="0x115D85C")]
	public AudioMixerRef()
	{
	}
}