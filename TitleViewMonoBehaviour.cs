using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class TitleViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private TitleView.SerializedFields _serializedFields;

	[FieldOffset(Offset="0x38")]
	private AudioEvent _musicEvent;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1328ED8", Offset="0x1328ED8", VA="0x1328ED8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1329064", Offset="0x1329064", VA="0x1329064")]
	public TitleViewMonoBehaviour()
	{
	}

	[Address(RVA="0x1328FB4", Offset="0x1328FB4", VA="0x1328FB4")]
	private void Awake()
	{
	}

	[Address(RVA="0x1328F58", Offset="0x1328F58", VA="0x1328F58")]
	private bool MusicEnabled()
	{
		return new bool();
	}

	[Address(RVA="0x1328EE0", Offset="0x1328EE0", VA="0x1328EE0", Slot="6")]
	public override void PlayMusic(AudioClipGroup audio)
	{
	}

	[Address(RVA="0x1329034", Offset="0x1329034", VA="0x1329034")]
	private void Update()
	{
	}
}