using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public class BattleEnvironment : MonoBehaviour, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private BattleCamera _battleCamPrefab;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Animator _environmentFSM;

	[Attribute(Name="HeaderAttribute", RVA="0x1053244", Offset="0x1053244")]
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private BattleIntroCinematic _introCinematic;

	[Attribute(Name="HeaderAttribute", RVA="0x1053290", Offset="0x1053290")]
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private AudioClipGroup _mainAudio;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private AudioClipGroup _ambience;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private AudioClipGroup _ambientLayer;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private AudioClipGroup _ambientWeather;

	public AudioClipGroup Ambience
	{
		[Address(RVA="0x114366C", Offset="0x114366C", VA="0x114366C")]
		get
		{
			return null;
		}
	}

	public AudioClipGroup AmbientLayer
	{
		[Address(RVA="0x1143674", Offset="0x1143674", VA="0x1143674")]
		get
		{
			return null;
		}
	}

	public AudioClipGroup AmbientWeather
	{
		[Address(RVA="0x114367C", Offset="0x114367C", VA="0x114367C")]
		get
		{
			return null;
		}
	}

	public BattleCamera BattleCamPrefab
	{
		[Address(RVA="0x114365C", Offset="0x114365C", VA="0x114365C")]
		get
		{
			return null;
		}
	}

	public BattleIntroCinematic IntroCinematic
	{
		[Address(RVA="0x1143684", Offset="0x1143684", VA="0x1143684")]
		get
		{
			return null;
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x1143654", Offset="0x1143654", VA="0x1143654", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	public AudioClipGroup MainAudio
	{
		[Address(RVA="0x1143664", Offset="0x1143664", VA="0x1143664")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x114391C", Offset="0x114391C", VA="0x114391C")]
	public BattleEnvironment()
	{
	}

	[Address(RVA="0x1143850", Offset="0x1143850", VA="0x1143850")]
	public void EndEncounter(string encounterId)
	{
	}

	[Address(RVA="0x114368C", Offset="0x114368C", VA="0x114368C")]
	public void Initialize()
	{
	}

	[Address(RVA="0x114372C", Offset="0x114372C", VA="0x114372C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1143730", Offset="0x1143730", VA="0x1143730")]
	public void StartEncounter(string encounterId, BattleLib_Bootstrap.Types.Encounter encounter)
	{
	}
}