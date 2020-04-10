using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ChatMessageListItem : MonoBehaviour, ILayoutGroup, ILayoutController, IMonoArchetypePooledItem, IDispatchHandler<DEmoteWidgetAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x0")]
	private const string CHAT_MESSAGE_FORMAT = "<noparse>{0}</noparse>";

	[FieldOffset(Offset="0x0")]
	private const float TIME_LABEL_UPDATE_INTERVAL_S = 60f;

	[Attribute(Name="InjectAttribute", RVA="0x1055B78", Offset="0x1055B78")]
	[FieldOffset(Offset="0x18")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1055B88", Offset="0x1055B88")]
	[FieldOffset(Offset="0x20")]
	private SingleAssetRegistry _assetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x1055B98", Offset="0x1055B98")]
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1055BA8", Offset="0x1055BA8")]
	[FieldOffset(Offset="0x30")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055BB8", Offset="0x1055BB8")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055BC8", Offset="0x1055BC8")]
	[FieldOffset(Offset="0x40")]
	private DiContainer _diContainer;

	[FieldOffset(Offset="0x48")]
	private ChatMessage _message;

	[FieldOffset(Offset="0x50")]
	private Sequence _emotePlaySeq;

	[FieldOffset(Offset="0x58")]
	private float _lastTimeLabelUpdateS;

	[FieldOffset(Offset="0x5C")]
	private ChatMessageListItem.LayoutStyle _layoutStyle;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UnityEngine.RectTransform _bubbleTransform;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UnityEngine.RectTransform _contentTransform;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UiColorPalette _colorPalette;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _senderLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UiLabel _messageLabel;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private UiLabel _timestampLabel;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private UnityEngine.RectTransform _avatarTransform;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private Button _avatarButton;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private RawImage _avatarImage;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private Image _bubbleBgImage;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private EmoteWidget _emote;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private Button _bubbleButton;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private UiInputSquish _bubbleSquish;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private float _minDisplayTimeS;

	private bool IsEmoteMessage
	{
		[Address(RVA="0x119EA24", Offset="0x119EA24", VA="0x119EA24")]
		get
		{
			return new bool();
		}
	}

	public UnityEngine.RectTransform PopupTransform
	{
		[Address(RVA="0x1197D7C", Offset="0x1197D7C", VA="0x1197D7C")]
		get
		{
			return null;
		}
	}

	private UnityEngine.RectTransform RectTransform
	{
		[Address(RVA="0x119F4CC", Offset="0x119F4CC", VA="0x119F4CC")]
		get
		{
			return null;
		}
	}

	public ChatMessageListItem.LayoutStyle Style
	{
		[Address(RVA="0x119D7CC", Offset="0x119D7CC", VA="0x119D7CC")]
		get
		{
			return new ChatMessageListItem.LayoutStyle();
		}
	}

	public DateTime TimeSent
	{
		[Address(RVA="0x119D938", Offset="0x119D938", VA="0x119D938")]
		get
		{
			return new DateTime();
		}
	}

	[Address(RVA="0x119F82C", Offset="0x119F82C", VA="0x119F82C")]
	public ChatMessageListItem()
	{
	}

	[Address(RVA="0x119F668", Offset="0x119F668", VA="0x119F668")]
	private void AvatarClicked()
	{
	}

	[Address(RVA="0x119F76C", Offset="0x119F76C", VA="0x119F76C")]
	private void BubbleClicked()
	{
	}

	[Address(RVA="0x119EEE8", Offset="0x119EEE8", VA="0x119EEE8")]
	private void ClearEmote()
	{
	}

	[Address(RVA="0x119F708", Offset="0x119F708", VA="0x119F708")]
	private void EmoteClicked()
	{
	}

	[Address(RVA="0x119F538", Offset="0x119F538", VA="0x119F538", Slot="9")]
	public void HandleDispatchAction(DEmoteWidgetAction action)
	{
	}

	[Address(RVA="0x119D9E4", Offset="0x119D9E4", VA="0x119D9E4", Slot="6")]
	public void Initialize()
	{
	}

	[Address(RVA="0x119F24C", Offset="0x119F24C", VA="0x119F24C")]
	private bool LoadEmote()
	{
		return new bool();
	}

	[Address(RVA="0x11977F4", Offset="0x11977F4", VA="0x11977F4")]
	public void QueuePlayEmote()
	{
	}

	[Address(RVA="0x119DD18", Offset="0x119DD18", VA="0x119DD18", Slot="8")]
	public void Reinitialize()
	{
	}

	[Address(RVA="0x119EAA0", Offset="0x119EAA0", VA="0x119EAA0")]
	public void SetData(ChatMessage message)
	{
	}

	[Address(RVA="0x119DFA4", Offset="0x119DFA4", VA="0x119DFA4", Slot="4")]
	public void SetLayoutHorizontal()
	{
	}

	[Address(RVA="0x119EF18", Offset="0x119EF18", VA="0x119EF18")]
	private void SetLayoutStyle(ChatMessageListItem.LayoutStyle style)
	{
	}

	[Address(RVA="0x119F534", Offset="0x119F534", VA="0x119F534", Slot="5")]
	public void SetLayoutVertical()
	{
	}

	[Address(RVA="0x119DC40", Offset="0x119DC40", VA="0x119DC40", Slot="7")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x119DD1C", Offset="0x119DD1C", VA="0x119DD1C")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x119DDE0", Offset="0x119DDE0", VA="0x119DDE0")]
	private void UpdateTimeLabel()
	{
	}

	public enum LayoutStyle
	{
		[FieldOffset(Offset="0x0")]
		Outgoing,
		[FieldOffset(Offset="0x0")]
		Incoming,
		[FieldOffset(Offset="0x0")]
		Admin
	}
}