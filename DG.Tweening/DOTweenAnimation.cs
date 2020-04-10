using DG.Tweening.Core;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace DG.Tweening
{
	[Attribute(Name="AddComponentMenu", RVA="0x104992C", Offset="0x104992C")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[FieldOffset(Offset="0x68")]
		public float delay;

		[FieldOffset(Offset="0x6C")]
		public float duration;

		[FieldOffset(Offset="0x70")]
		public Ease easeType;

		[FieldOffset(Offset="0x78")]
		public AnimationCurve easeCurve;

		[FieldOffset(Offset="0x80")]
		public LoopType loopType;

		[FieldOffset(Offset="0x84")]
		public int loops;

		[FieldOffset(Offset="0x88")]
		public string id;

		[FieldOffset(Offset="0x90")]
		public bool isRelative;

		[FieldOffset(Offset="0x91")]
		public bool isFrom;

		[FieldOffset(Offset="0x92")]
		public bool isIndependentUpdate;

		[FieldOffset(Offset="0x93")]
		public bool autoKill;

		[FieldOffset(Offset="0x94")]
		public bool isActive;

		[FieldOffset(Offset="0x95")]
		public bool isValid;

		[FieldOffset(Offset="0x98")]
		public Component target;

		[FieldOffset(Offset="0xA0")]
		public DOTweenAnimationType animationType;

		[FieldOffset(Offset="0xA4")]
		public TargetType targetType;

		[FieldOffset(Offset="0xA8")]
		public TargetType forcedTargetType;

		[FieldOffset(Offset="0xAC")]
		public bool autoPlay;

		[FieldOffset(Offset="0xAD")]
		public bool useTargetAsV3;

		[FieldOffset(Offset="0xB0")]
		public float endValueFloat;

		[FieldOffset(Offset="0xB4")]
		public Vector3 endValueV3;

		[FieldOffset(Offset="0xC0")]
		public Vector2 endValueV2;

		[FieldOffset(Offset="0xC8")]
		public Color endValueColor;

		[FieldOffset(Offset="0xD8")]
		public string endValueString;

		[FieldOffset(Offset="0xE0")]
		public Rect endValueRect;

		[FieldOffset(Offset="0xF0")]
		public Transform endValueTransform;

		[FieldOffset(Offset="0xF8")]
		public bool optionalBool0;

		[FieldOffset(Offset="0xFC")]
		public float optionalFloat0;

		[FieldOffset(Offset="0x100")]
		public int optionalInt0;

		[FieldOffset(Offset="0x104")]
		public RotateMode optionalRotationMode;

		[FieldOffset(Offset="0x108")]
		public ScrambleMode optionalScrambleMode;

		[FieldOffset(Offset="0x110")]
		public string optionalString;

		[FieldOffset(Offset="0x118")]
		private bool _tweenCreated;

		[FieldOffset(Offset="0x11C")]
		private int _playCount;

		[Address(RVA="0x1541960", Offset="0x1541960", VA="0x1541960")]
		public DOTweenAnimation()
		{
		}

		[Address(RVA="0x1541B68", Offset="0x1541B68", VA="0x1541B68")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x107513C", Offset="0x107513C")]
		private void <CreateTween>b__37_0()
		{
		}

		[Address(RVA="0x153E720", Offset="0x153E720", VA="0x153E720")]
		private void Awake()
		{
		}

		[Address(RVA="0x153E770", Offset="0x153E770", VA="0x153E770")]
		public void CreateTween()
		{
		}

		[Address(RVA="0x1541120", Offset="0x1541120", VA="0x1541120", Slot="11")]
		public override void DOComplete()
		{
		}

		[Address(RVA="0x15411A0", Offset="0x15411A0", VA="0x15411A0", Slot="12")]
		public override void DOKill()
		{
		}

		[Address(RVA="0x1540A50", Offset="0x1540A50", VA="0x1540A50", Slot="7")]
		public override void DOPause()
		{
		}

		[Address(RVA="0x154131C", Offset="0x154131C", VA="0x154131C")]
		public void DOPauseAllById(string id)
		{
		}

		[Address(RVA="0x15408DC", Offset="0x15408DC", VA="0x15408DC", Slot="4")]
		public override void DOPlay()
		{
		}

		[Address(RVA="0x15412B4", Offset="0x15412B4", VA="0x15412B4")]
		public void DOPlayAllById(string id)
		{
		}

		[Address(RVA="0x1540958", Offset="0x1540958", VA="0x1540958", Slot="5")]
		public override void DOPlayBackwards()
		{
		}

		[Address(RVA="0x1541410", Offset="0x1541410", VA="0x1541410")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Address(RVA="0x1541384", Offset="0x1541384", VA="0x1541384")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Address(RVA="0x1541228", Offset="0x1541228", VA="0x1541228")]
		public void DOPlayById(string id)
		{
		}

		[Address(RVA="0x15409D4", Offset="0x15409D4", VA="0x15409D4", Slot="6")]
		public override void DOPlayForward()
		{
		}

		[Address(RVA="0x1541504", Offset="0x1541504", VA="0x1541504")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Address(RVA="0x1541478", Offset="0x1541478", VA="0x1541478")]
		public void DOPlayForwardById(string id)
		{
		}

		[Address(RVA="0x154156C", Offset="0x154156C", VA="0x154156C")]
		public void DOPlayNext()
		{
		}

		[Address(RVA="0x1540C80", Offset="0x1540C80", VA="0x1540C80", Slot="10")]
		public override void DORestart(bool fromHere = false)
		{
		}

		[Address(RVA="0x15417D0", Offset="0x15417D0", VA="0x15417D0")]
		public void DORestartAllById(string id)
		{
		}

		[Address(RVA="0x1541734", Offset="0x1541734", VA="0x1541734")]
		public void DORestartById(string id)
		{
		}

		[Address(RVA="0x1540B48", Offset="0x1540B48", VA="0x1540B48", Slot="9")]
		public override void DORewind()
		{
		}

		[Address(RVA="0x15416A4", Offset="0x15416A4", VA="0x15416A4")]
		public void DORewindAndPlayNext()
		{
		}

		[Address(RVA="0x1540ACC", Offset="0x1540ACC", VA="0x1540ACC", Slot="8")]
		public override void DOTogglePause()
		{
		}

		[Address(RVA="0x1541854", Offset="0x1541854", VA="0x1541854")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Address(RVA="0x1540718", Offset="0x1540718", VA="0x1540718")]
		private void OnDestroy()
		{
		}

		[Address(RVA="0x1540D78", Offset="0x1540D78", VA="0x1540D78")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Address(RVA="0x15406D4", Offset="0x15406D4", VA="0x15406D4")]
		private void Start()
		{
		}

		[Address(RVA="0x154075C", Offset="0x154075C", VA="0x154075C")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return new TargetType();
		}
	}
}