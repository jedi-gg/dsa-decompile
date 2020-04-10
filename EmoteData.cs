using Glunies.Audio;
using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="CreateAssetMenuAttribute", RVA="0x1048914", Offset="0x1048914")]
public class EmoteData : ScriptableObject
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private float _fps;

	[FieldOffset(Offset="0x1C")]
	[SerializeField]
	private float _durationS;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Texture[] _sprites;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private AudioClipGroup _audio;

	public AudioClipGroup Audio
	{
		[Address(RVA="0x1206B48", Offset="0x1206B48", VA="0x1206B48")]
		get
		{
			return null;
		}
	}

	public float DurationS
	{
		[Address(RVA="0x1206B40", Offset="0x1206B40", VA="0x1206B40")]
		get
		{
			return new float();
		}
	}

	public float FPS
	{
		[Address(RVA="0x1206B50", Offset="0x1206B50", VA="0x1206B50")]
		get
		{
			return new float();
		}
	}

	public Texture[] Sprites
	{
		[Address(RVA="0x1206B58", Offset="0x1206B58", VA="0x1206B58")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1206C64", Offset="0x1206C64", VA="0x1206C64")]
	public EmoteData()
	{
	}

	[Address(RVA="0x1206B60", Offset="0x1206B60", VA="0x1206B60")]
	public Texture GetTexture(float timeS)
	{
		return null;
	}
}