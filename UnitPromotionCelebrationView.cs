using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitPromotionCelebrationView : APopupView
{
	private UnitPromotionCelebrationView.SerializedFields Fields
	{
		[Address(RVA="0x150C110", Offset="0x150C110", VA="0x150C110")]
		get
		{
			return null;
		}
	}

	public ViewSequencer Sequencer
	{
		[Address(RVA="0x150BF50", Offset="0x150BF50", VA="0x150BF50")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x150C3C8", Offset="0x150C3C8", VA="0x150C3C8")]
	public UnitPromotionCelebrationView()
	{
	}

	[Address(RVA="0x150B7E8", Offset="0x150B7E8", VA="0x150B7E8")]
	public void SetData(UnitPromotionCelebrationController.DStats oldStats, UnitPromotionCelebrationController.DStats newStats)
	{
	}

	[Address(RVA="0x150C1F8", Offset="0x150C1F8", VA="0x150C1F8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x150C3A0", Offset="0x150C3A0", VA="0x150C3A0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D17C", Offset="0x104D17C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public Transform newStarTransform;

		[Address(RVA="0x150C1F0", Offset="0x150C1F0", VA="0x150C1F0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x150C3D0", Offset="0x150C3D0", VA="0x150C3D0")]
		internal void <SetData>b__0()
		{
		}

		[Address(RVA="0x150C41C", Offset="0x150C41C", VA="0x150C41C")]
		internal void <SetData>b__1()
		{
		}
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106C654", Offset="0x106C654")]
		[FieldOffset(Offset="0x30")]
		public ViewSequencer Sequencer;

		[FieldOffset(Offset="0x38")]
		public List<UnityEngine.GameObject> Stars;

		[FieldOffset(Offset="0x40")]
		public UiLabel OldOffenseLabel;

		[FieldOffset(Offset="0x48")]
		public TallyLabelUnsigned NewOffenseLabel;

		[FieldOffset(Offset="0x50")]
		public UiLabel OldDefenseLabel;

		[FieldOffset(Offset="0x58")]
		public TallyLabelUnsigned NewDefenseLabel;

		[FieldOffset(Offset="0x60")]
		public UiLabel OldHealthLabel;

		[FieldOffset(Offset="0x68")]
		public TallyLabelUnsigned NewHealthLabel;

		[FieldOffset(Offset="0x70")]
		public UiLabel LevelLabel;

		[FieldOffset(Offset="0x78")]
		public UiLabel OldPowerLabel;

		[FieldOffset(Offset="0x80")]
		public TallyLabelUnsigned NewPowerLabel;

		[FieldOffset(Offset="0x88")]
		public UnityEngine.GameObject NoStatChangedContainer;

		[FieldOffset(Offset="0x90")]
		public Image OffenseCarat;

		[FieldOffset(Offset="0x98")]
		public Image DefenseCarat;

		[FieldOffset(Offset="0xA0")]
		public Image HealthCarat;

		[Attribute(Name="HeaderAttribute", RVA="0x106C68C", Offset="0x106C68C")]
		[FieldOffset(Offset="0xA8")]
		public float StarTweenDelay;

		[FieldOffset(Offset="0xAC")]
		public float StarTweenDuration;

		[FieldOffset(Offset="0xB0")]
		public float StarTweenStartScale;

		[FieldOffset(Offset="0xB4")]
		public float StarTweenEndScale;

		[FieldOffset(Offset="0xB8")]
		public Ease StarTweenEase;

		[Attribute(Name="HeaderAttribute", RVA="0x106C6C4", Offset="0x106C6C4")]
		[FieldOffset(Offset="0xC0")]
		public ParticleSystem CelebrationVfx;

		[FieldOffset(Offset="0xC8")]
		public Transform CelebrationVfxParent;

		[Address(RVA="0x150C468", Offset="0x150C468", VA="0x150C468")]
		public SerializedFields()
		{
		}
	}
}