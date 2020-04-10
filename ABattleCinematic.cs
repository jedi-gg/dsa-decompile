using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;

public class ABattleCinematic : MonoBehaviour, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	protected PlayableDirector _director;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private TextMeshPro _text;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private TextMeshPro _subtitleText;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private AudioClipGroup _cinematicMusicClip;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private AudioClipGroup _cinematicStingerClip;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private AudioClipGroup _cinematicCharacterClip;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	protected bool _useEncounterPosition;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105482C", Offset="0x105482C")]
	[FieldOffset(Offset="0x4C")]
	private Vector3 <_encounterPosition>k__BackingField;

	[FieldOffset(Offset="0x58")]
	protected ABattleCinematic.PlayState _playState;

	[FieldOffset(Offset="0x60")]
	protected List<BattleUnit> _friendlyUnits;

	[FieldOffset(Offset="0x68")]
	protected List<BattleUnit> _enemyUnits;

	[FieldOffset(Offset="0x70")]
	private int _boundFriendlies;

	[FieldOffset(Offset="0x74")]
	private int _boundEnemies;

	protected Vector3 _encounterPosition
	{
		[Address(RVA="0x10DF44C", Offset="0x10DF44C", VA="0x10DF44C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E7A8", Offset="0x106E7A8")]
		get
		{
			return new Vector3();
		}
		[Address(RVA="0x10DF458", Offset="0x10DF458", VA="0x10DF458")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E7B8", Offset="0x106E7B8")]
		private set
		{
		}
	}

	public AudioClipGroup CinematicCharacterClip
	{
		[Address(RVA="0x10DE808", Offset="0x10DE808", VA="0x10DE808")]
		get
		{
			return null;
		}
	}

	public AudioClipGroup CinematicMusicClip
	{
		[Address(RVA="0x10DE7F8", Offset="0x10DE7F8", VA="0x10DE7F8")]
		get
		{
			return null;
		}
	}

	public AudioClipGroup CinematicStingerClip
	{
		[Address(RVA="0x10DE800", Offset="0x10DE800", VA="0x10DE800")]
		get
		{
			return null;
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x10DE7F0", Offset="0x10DE7F0", VA="0x10DE7F0", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x10DF464", Offset="0x10DF464", VA="0x10DF464")]
	public ABattleCinematic()
	{
	}

	[Address(RVA="0x10DEFB8", Offset="0x10DEFB8", VA="0x10DEFB8", Slot="9")]
	protected virtual void BindPlayableGraphOutput(PlayableBinding output)
	{
	}

	[Address(RVA="0x10DEE04", Offset="0x10DEE04", VA="0x10DEE04")]
	public void ClearUnits()
	{
	}

	[Address(RVA="0x10DEFB4", Offset="0x10DEFB4", VA="0x10DEFB4", Slot="8")]
	protected virtual void FinishedPlaying()
	{
	}

	[Address(RVA="0x10DEE0C", Offset="0x10DEE0C", VA="0x10DEE0C")]
	public bool IsFinished()
	{
		return new bool();
	}

	[Address(RVA="0x10DE9AC", Offset="0x10DE9AC", VA="0x10DE9AC", Slot="5")]
	public virtual void Play()
	{
	}

	[Address(RVA="0x10DE8F4", Offset="0x10DE8F4", VA="0x10DE8F4")]
	public void SetSubtitleText(string subtitle)
	{
	}

	[Address(RVA="0x10DE810", Offset="0x10DE810", VA="0x10DE810")]
	public void SetText(ValueTuple<string, string> titleSubtitle)
	{
	}

	[Address(RVA="0x10DE83C", Offset="0x10DE83C", VA="0x10DE83C")]
	public void SetTitleText(string title)
	{
	}

	[Address(RVA="0x10DEE1C", Offset="0x10DEE1C", VA="0x10DEE1C", Slot="6")]
	public virtual void SetUnits(List<BattleUnit> friendlies, List<BattleUnit> enemies)
	{
	}

	[Address(RVA="0x10DEE24", Offset="0x10DEE24", VA="0x10DEE24", Slot="7")]
	protected virtual void Update()
	{
	}

	protected enum PlayState
	{
		[FieldOffset(Offset="0x0")]
		Initial,
		[FieldOffset(Offset="0x0")]
		Playing,
		[FieldOffset(Offset="0x0")]
		Done
	}
}