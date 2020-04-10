using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ChatPreviewController : IDispatchHandler<DChatPreviewViewAction>, IDispatchHandler, IDispatchHandler<DChatMessageAddedToChannelAction>, IDispatchHandler<DChatSettingsChangedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1055CC8", Offset="0x1055CC8")]
	[FieldOffset(Offset="0x10")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1055CD8", Offset="0x1055CD8")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1055CE8", Offset="0x1055CE8")]
	[FieldOffset(Offset="0x20")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x1055CF8", Offset="0x1055CF8")]
	[FieldOffset(Offset="0x28")]
	private GameStateMachine _gameStateMachine;

	[Attribute(Name="InjectAttribute", RVA="0x1055D08", Offset="0x1055D08")]
	[FieldOffset(Offset="0x30")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1055D18", Offset="0x1055D18")]
	[FieldOffset(Offset="0x38")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1055D28", Offset="0x1055D28")]
	[FieldOffset(Offset="0x40")]
	private GameLanguageManager _gameLanguageManager;

	[Attribute(Name="InjectAttribute", RVA="0x1055D38", Offset="0x1055D38")]
	[FieldOffset(Offset="0x48")]
	private ChatDomainController _chatDc;

	[FieldOffset(Offset="0x0")]
	private const string CHAT_MESSAGE_FORMAT = "<color=#00FFCE>[{0}] <color=#CFABFF><noparse>{1}</noparse>";

	[FieldOffset(Offset="0x50")]
	private ChatPreviewView _view;

	[FieldOffset(Offset="0x58")]
	private ChatMessage _mostRecentMsg;

	[FieldOffset(Offset="0x60")]
	private bool _isShutdown;

	[FieldOffset(Offset="0x64")]
	private ChatChannelType _previewMode;

	[Address(RVA="0x11A060C", Offset="0x11A060C", VA="0x11A060C")]
	public ChatPreviewController()
	{
	}

	[Address(RVA="0x119FDB0", Offset="0x119FDB0", VA="0x119FDB0")]
	private void AddMessageToPreview(ChatMessage msg)
	{
	}

	[Address(RVA="0x119FC1C", Offset="0x119FC1C", VA="0x119FC1C", Slot="4")]
	public void HandleDispatchAction(DChatPreviewViewAction action)
	{
	}

	[Address(RVA="0x119FD4C", Offset="0x119FD4C", VA="0x119FD4C", Slot="5")]
	public void HandleDispatchAction(DChatMessageAddedToChannelAction action)
	{
	}

	[Address(RVA="0x119FF44", Offset="0x119FF44", VA="0x119FF44", Slot="6")]
	public void HandleDispatchAction(DChatSettingsChangedAction action)
	{
	}

	[Address(RVA="0x119F83C", Offset="0x119F83C", VA="0x119F83C")]
	public void Initialize(Action completed, bool startActive, ChatChannelType previewMode = 0)
	{
	}

	[Address(RVA="0x11A0384", Offset="0x11A0384", VA="0x11A0384")]
	private bool IsEmote(string text)
	{
		return new bool();
	}

	[Address(RVA="0x11A037C", Offset="0x11A037C", VA="0x11A037C")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x11A0058", Offset="0x11A0058", VA="0x11A0058")]
	private void PopulatePreviewWithOldMessages()
	{
	}

	[Address(RVA="0x119F9BC", Offset="0x119F9BC", VA="0x119F9BC")]
	private bool ShouldShowChatPreview()
	{
		return new bool();
	}

	[Address(RVA="0x119FBD0", Offset="0x119FBD0", VA="0x119FBD0")]
	public void Show(bool show)
	{
	}

	[Address(RVA="0x119FA7C", Offset="0x119FA7C", VA="0x119FA7C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x119FAF0", Offset="0x119FAF0", VA="0x119FAF0")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B57C", Offset="0x104B57C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ChatPreviewController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x119F9B4", Offset="0x119F9B4", VA="0x119F9B4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11A061C", Offset="0x11A061C", VA="0x11A061C")]
		internal void <Initialize>b__0(ChatPreviewView view)
		{
		}
	}
}