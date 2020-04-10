using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TutorialPointAtView : AView
{
	[FieldOffset(Offset="0x0")]
	private const float ARROW_BOUNCE_DISTANCE = 150f;

	[FieldOffset(Offset="0x68")]
	private Sequence _pointerSequence;

	[FieldOffset(Offset="0x70")]
	private RectTransform _followTarget;

	[FieldOffset(Offset="0x78")]
	private Camera _followTargetWorldCamera;

	[FieldOffset(Offset="0x80")]
	private Vector2 _canvasSize;

	[FieldOffset(Offset="0x88")]
	private float _pointerDimension;

	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x143DFE0", Offset="0x143DFE0", VA="0x143DFE0", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public override ViewDepth Depth
	{
		[Address(RVA="0x143DFD8", Offset="0x143DFD8", VA="0x143DFD8", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private TutorialPointAtView.SerializedFields Fields
	{
		[Address(RVA="0x143E320", Offset="0x143E320", VA="0x143E320")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x143F000", Offset="0x143F000", VA="0x143F000")]
	public TutorialPointAtView()
	{
	}

	[Address(RVA="0x143EFBC", Offset="0x143EFBC", VA="0x143EFBC")]
	private float ConstrainMessageRootPivot(float normalizedScreenPos)
	{
		return new float();
	}

	[Address(RVA="0x143E1CC", Offset="0x143E1CC", VA="0x143E1CC")]
	public RectTransform GetFullScreenClickCatcher()
	{
		return null;
	}

	[Address(RVA="0x143E484", Offset="0x143E484", VA="0x143E484")]
	private void ResetState()
	{
	}

	[Address(RVA="0x143EAC0", Offset="0x143EAC0", VA="0x143EAC0")]
	public void SetFollowTarget(RectTransform followTarget, Camera worldCamera)
	{
	}

	[Address(RVA="0x143EAF8", Offset="0x143EAF8", VA="0x143EAF8")]
	public void SetMessageText(string text)
	{
	}

	[Address(RVA="0x143E400", Offset="0x143E400", VA="0x143E400")]
	public void SetPosition(Vector3 position, bool reset)
	{
	}

	[Address(RVA="0x143EBEC", Offset="0x143EBEC", VA="0x143EBEC")]
	public void ShowTapAnywhere(bool show)
	{
	}

	[Address(RVA="0x143DFE8", Offset="0x143DFE8", VA="0x143DFE8")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x143DFEC", Offset="0x143DFEC", VA="0x143DFEC")]
	private void UpdateFollowTargetPosition()
	{
	}

	[Address(RVA="0x143E4F4", Offset="0x143E4F4", VA="0x143E4F4")]
	private void UpdatePosition()
	{
	}

	[Address(RVA="0x143ECF4", Offset="0x143ECF4", VA="0x143ECF4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x143EFA4", Offset="0x143EFA4", VA="0x143EFA4", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Address(RVA="0x143EE84", Offset="0x143EE84", VA="0x143EE84", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x143EE40", Offset="0x143EE40", VA="0x143EE40", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public RectTransform PointerPosition;

		[FieldOffset(Offset="0x30")]
		public RectTransform Pointer;

		[FieldOffset(Offset="0x38")]
		public RectTransform TweenRoot;

		[FieldOffset(Offset="0x40")]
		public RectTransform MessageRoot;

		[FieldOffset(Offset="0x48")]
		public UiLabel MessageLabel;

		[FieldOffset(Offset="0x50")]
		public Button FullScreenClickCatcher;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject ArrowPointAt;

		[FieldOffset(Offset="0x60")]
		public UnityEngine.GameObject HandTapAt;

		[Address(RVA="0x143F008", Offset="0x143F008", VA="0x143F008")]
		public SerializedFields()
		{
		}
	}
}