using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BattleFlyingAlertTextView : AStandardView, IDispatchHandler<DCastAttemptAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x0")]
	private const float ALERT_LABEL_SCREEN_FIT_BUFFER_WIDTH = 20f;

	[Attribute(Name="InjectAttribute", RVA="0x105499C", Offset="0x105499C")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x70")]
	private Sequence _alertTween;

	[FieldOffset(Offset="0x78")]
	private ContentSizeFitter _alertLabelContentFitter;

	[FieldOffset(Offset="0x80")]
	private bool _enabled;

	private BattleFlyingAlertTextView.SerializedFields Fields
	{
		[Address(RVA="0x11461E0", Offset="0x11461E0", VA="0x11461E0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1146364", Offset="0x1146364", VA="0x1146364")]
	public BattleFlyingAlertTextView()
	{
	}

	[Address(RVA="0x1145A8C", Offset="0x1145A8C", VA="0x1145A8C")]
	private void HandleCastAttemptFail(DCastAttemptAction action)
	{
	}

	[Address(RVA="0x1145A4C", Offset="0x1145A4C", VA="0x1145A4C", Slot="21")]
	public void HandleDispatchAction(DCastAttemptAction action)
	{
	}

	[Address(RVA="0x1145A40", Offset="0x1145A40", VA="0x1145A40")]
	public void SetEnabled(bool enabled)
	{
	}

	[Address(RVA="0x1145F80", Offset="0x1145F80", VA="0x1145F80", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1146324", Offset="0x1146324", VA="0x1146324", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Address(RVA="0x11462C0", Offset="0x11462C0", VA="0x11462C0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public UiLabel AlertLabel;

		[FieldOffset(Offset="0x30")]
		public RectTransform AlertRootRect;

		[FieldOffset(Offset="0x38")]
		public CanvasGroup AlertTweenCanvasGroup;

		[Address(RVA="0x1146374", Offset="0x1146374", VA="0x1146374")]
		public SerializedFields()
		{
		}
	}
}