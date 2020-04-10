using DG.Tweening;
using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class AlertTextView : AView
{
	[FieldOffset(Offset="0x68")]
	private Sequence _alertTween;

	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x1159C6C", Offset="0x1159C6C", VA="0x1159C6C", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public sealed override ViewDepth Depth
	{
		[Address(RVA="0x1159C64", Offset="0x1159C64", VA="0x1159C64", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private AlertTextView.SerializedFields Fields
	{
		[Address(RVA="0x1159C74", Offset="0x1159C74", VA="0x1159C74")]
		get
		{
			return null;
		}
	}

	protected override bool WillHandleBackButton
	{
		[Address(RVA="0x115A014", Offset="0x115A014", VA="0x115A014", Slot="19")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x115A01C", Offset="0x115A01C", VA="0x115A01C")]
	public AlertTextView()
	{
	}

	[Address(RVA="0x115936C", Offset="0x115936C", VA="0x115936C")]
	public void SetText(string text, float? arg0, DAlertTextViewConfig config)
	{
	}

	[Address(RVA="0x1159FB0", Offset="0x1159FB0", VA="0x1159FB0")]
	private void TweenFinished()
	{
	}

	[Address(RVA="0x1159D54", Offset="0x1159D54", VA="0x1159D54", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1159F6C", Offset="0x1159F6C", VA="0x1159F6C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	public enum AudioType
	{
		[FieldOffset(Offset="0x0")]
		Default,
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		BattleFinalEncounter,
		[FieldOffset(Offset="0x0")]
		Negative
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public CanvasGroup CanvasGroup;

		[FieldOffset(Offset="0x30")]
		public UiLabel AlertLabelDefault;

		[FieldOffset(Offset="0x38")]
		public UiLabel AlertLabelBattleCinematic;

		[FieldOffset(Offset="0x40")]
		public RectTransform AlertRootRect;

		[FieldOffset(Offset="0x48")]
		public List<UnityEngine.GameObject> Backgrounds;

		[Attribute(Name="HeaderAttribute", RVA="0x106985C", Offset="0x106985C")]
		[FieldOffset(Offset="0x50")]
		public float FadeOutDelay;

		[FieldOffset(Offset="0x54")]
		public float FadeOutDuration;

		[FieldOffset(Offset="0x58")]
		public float MoveSpeed;

		[Attribute(Name="HeaderAttribute", RVA="0x1069894", Offset="0x1069894")]
		[FieldOffset(Offset="0x60")]
		public AudioClipGroup DefaultAudio;

		[FieldOffset(Offset="0x68")]
		public AudioClipGroup BattleFinalEncounterAudio;

		[FieldOffset(Offset="0x70")]
		public AudioClipGroup NegativeAudio;

		[Address(RVA="0x115A024", Offset="0x115A024", VA="0x115A024")]
		public SerializedFields()
		{
		}
	}

	public enum Style
	{
		[FieldOffset(Offset="0x0")]
		Default,
		[FieldOffset(Offset="0x0")]
		BattleCinematic
	}
}