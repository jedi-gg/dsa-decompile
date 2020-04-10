using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105D618", Offset="0x105D618")]
	[FieldOffset(Offset="0x0")]
	private static SplashScreen <Instance>k__BackingField;

	[FieldOffset(Offset="0x0")]
	private const float LOGO_DURATION = 1.75f;

	[FieldOffset(Offset="0x0")]
	private const float FADE_DURATION = 0.5f;

	[FieldOffset(Offset="0x18")]
	private float _timer;

	[FieldOffset(Offset="0x1C")]
	private bool _allowSelfDestruct;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private CanvasGroup _splashRoot;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private CanvasGroup _disneyGroup;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private CanvasGroup _gameGroup;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private List<SplashScreen.LocalizedLogo> _localizedLogos;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private GameObject _defaultLogo;

	public static SplashScreen Instance
	{
		[Address(RVA="0x12479C4", Offset="0x12479C4", VA="0x12479C4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070D84", Offset="0x1070D84")]
		get
		{
			return null;
		}
		[Address(RVA="0x1247A14", Offset="0x1247A14", VA="0x1247A14")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070D94", Offset="0x1070D94")]
		private set
		{
		}
	}

	[Address(RVA="0x1247F8C", Offset="0x1247F8C", VA="0x1247F8C")]
	public SplashScreen()
	{
	}

	[Address(RVA="0x1247A74", Offset="0x1247A74", VA="0x1247A74")]
	private void Awake()
	{
	}

	[Address(RVA="0x1247A68", Offset="0x1247A68", VA="0x1247A68")]
	public void DestroyIfTimeElapsed()
	{
	}

	[Address(RVA="0x1247D84", Offset="0x1247D84", VA="0x1247D84")]
	private void Update()
	{
	}

	[Serializable]
	private class LocalizedLogo
	{
		[FieldOffset(Offset="0x10")]
		public GameLanguage Lang;

		[FieldOffset(Offset="0x18")]
		public GameObject Logo;

		[Address(RVA="0x1247F94", Offset="0x1247F94", VA="0x1247F94")]
		public LocalizedLogo()
		{
		}
	}
}