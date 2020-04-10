using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public class ClubSupportRequestButton : MonoBehaviour, IDispatchHandler<DClubSupportRequestProcessedAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x28")]
	private ClubUtil _clubUtil;

	[FieldOffset(Offset="0x30")]
	private object _ownerIdentifier;

	[FieldOffset(Offset="0x38")]
	private ClubSupportRequestType _requestType;

	[FieldOffset(Offset="0x40")]
	private object _context;

	[FieldOffset(Offset="0x48")]
	private UiTimerLabel _timerLabel;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private LabelButton _requestButton;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private LabelButton _claimButton;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _timeLabelPrefix;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UiLabel _timeLabel;

	[Address(RVA="0x12682CC", Offset="0x12682CC", VA="0x12682CC")]
	public ClubSupportRequestButton()
	{
	}

	[Address(RVA="0x126822C", Offset="0x126822C", VA="0x126822C")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x12680DC", Offset="0x12680DC", VA="0x12680DC")]
	private string GetClubSupportRequestButtonText(ClubSupportRequestType type, ClubSupportRequest supportRequest)
	{
		return null;
	}

	[Address(RVA="0x126821C", Offset="0x126821C", VA="0x126821C", Slot="4")]
	public void HandleDispatchAction(DClubSupportRequestProcessedAction action)
	{
	}

	[Address(RVA="0x1267948", Offset="0x1267948", VA="0x1267948")]
	public void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x1268214", Offset="0x1268214", VA="0x1268214")]
	public void SetContext(object context)
	{
	}

	[Address(RVA="0x1267CC8", Offset="0x1267CC8", VA="0x1267CC8")]
	public void SetRequestType(ClubSupportRequestType requestType)
	{
	}

	[Address(RVA="0x1267B2C", Offset="0x1267B2C", VA="0x1267B2C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1267BE4", Offset="0x1267BE4", VA="0x1267BE4")]
	public void TickUpdate()
	{
	}
}