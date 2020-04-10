using DG.Tweening;
using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleStateTransitionView : AView
{
	[FieldOffset(Offset="0x68")]
	private Sequence _showScrimTween;

	[FieldOffset(Offset="0x70")]
	private Sequence _hideScrimTween;

	[FieldOffset(Offset="0x78")]
	private Tweener _showSpinnerTween;

	[FieldOffset(Offset="0x80")]
	private Tweener _hideSpinnerTween;

	[FieldOffset(Offset="0x88")]
	private float _tweenXPos;

	[FieldOffset(Offset="0x8C")]
	private bool _readyToHide;

	public override ViewDepth Depth
	{
		[Address(RVA="0x1294024", Offset="0x1294024", VA="0x1294024", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private BattleStateTransitionView.SerializedFields Fields
	{
		[Address(RVA="0x129408C", Offset="0x129408C", VA="0x129408C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1294C08", Offset="0x1294C08", VA="0x1294C08")]
	public BattleStateTransitionView()
	{
	}

	[Address(RVA="0x1294C10", Offset="0x1294C10", VA="0x1294C10")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E5C8", Offset="0x106E5C8")]
	private void <ViewAssetLoaded>b__4_0()
	{
	}

	[Address(RVA="0x1293EFC", Offset="0x1293EFC", VA="0x1293EFC")]
	public void Hide()
	{
	}

	[Address(RVA="0x1294B74", Offset="0x1294B74", VA="0x1294B74")]
	private void HideTweenFinished()
	{
	}

	[Address(RVA="0x129402C", Offset="0x129402C", VA="0x129402C")]
	public void ShowLoadingSpinner(bool show)
	{
	}

	[Address(RVA="0x1294A90", Offset="0x1294A90", VA="0x1294A90")]
	private void ShowTweenFinished()
	{
	}

	[Address(RVA="0x129416C", Offset="0x129416C", VA="0x129416C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x12949AC", Offset="0x12949AC", VA="0x12949AC", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Address(RVA="0x1294870", Offset="0x1294870", VA="0x1294870", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x12947A0", Offset="0x12947A0", VA="0x12947A0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public RectTransform TweenRect;

		[FieldOffset(Offset="0x30")]
		public List<Image> TweenImages;

		[FieldOffset(Offset="0x38")]
		public Gradient ShowGradient;

		[FieldOffset(Offset="0x40")]
		public Gradient HideGradient;

		[FieldOffset(Offset="0x48")]
		public CanvasGroup LoadingSpinnerRoot;

		[Attribute(Name="HeaderAttribute", RVA="0x1069A8C", Offset="0x1069A8C")]
		[FieldOffset(Offset="0x50")]
		public AudioClipGroup HideAudio;

		[Address(RVA="0x1294C48", Offset="0x1294C48", VA="0x1294C48")]
		public SerializedFields()
		{
		}
	}
}