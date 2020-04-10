using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleView : AView, IDispatchHandler<DTextLinkInputAction>, IDispatchHandler, IDispatchHandler<DConsoleCachedCommandAction>, IDispatchHandler<DConsoleCommandHelpAction>
{
	[FieldOffset(Offset="0x0")]
	private const int MAX_CONSOLE_STRINGS = 40;

	[FieldOffset(Offset="0x0")]
	private const float MIN_FONT_SIZE = 8f;

	[FieldOffset(Offset="0x0")]
	private const float MAX_FONT_SIZE = 18f;

	[FieldOffset(Offset="0x0")]
	private const float FONT_SIZE_DELTA = 2f;

	[FieldOffset(Offset="0x0")]
	private const int MAX_CACHED_COMMANDS = 8;

	[Attribute(Name="InjectAttribute", RVA="0x1057578", Offset="0x1057578")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x70")]
	private List<ConsoleView.DConsoleText> _consoleOutput;

	[FieldOffset(Offset="0x78")]
	private List<Button> _createdCommandButtons;

	[FieldOffset(Offset="0x80")]
	private List<ConsoleView.DCommandToggle> _createdCommandToggles;

	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x1544D8C", Offset="0x1544D8C", VA="0x1544D8C", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public override ViewDepth Depth
	{
		[Address(RVA="0x1544D84", Offset="0x1544D84", VA="0x1544D84", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private ConsoleView.SerializedFields Fields
	{
		[Address(RVA="0x15453D0", Offset="0x15453D0", VA="0x15453D0")]
		get
		{
			return null;
		}
	}

	public override bool OverridesContextualMessageInput
	{
		[Address(RVA="0x1544D94", Offset="0x1544D94", VA="0x1544D94", Slot="9")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1547444", Offset="0x1547444", VA="0x1547444")]
	public ConsoleView()
	{
	}

	[Address(RVA="0x1544D9C", Offset="0x1544D9C", VA="0x1544D9C")]
	public void AddCommandButtons(List<ConsoleCommandButtonData> buttons)
	{
	}

	[Address(RVA="0x1547180", Offset="0x1547180", VA="0x1547180")]
	private void BindCachedCommandListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1545714", Offset="0x1545714", VA="0x1545714")]
	public void ClearConsole()
	{
	}

	[Address(RVA="0x1546CCC", Offset="0x1546CCC", VA="0x1546CCC")]
	private void CloseClicked()
	{
	}

	[Address(RVA="0x1546C00", Offset="0x1546C00", VA="0x1546C00")]
	private void CloseStackTraceContainer()
	{
	}

	[Address(RVA="0x1546D3C", Offset="0x1546D3C", VA="0x1546D3C")]
	private void CommandEntered(string command)
	{
	}

	[Address(RVA="0x1546E70", Offset="0x1546E70", VA="0x1546E70")]
	private void DecreaseFontSize()
	{
	}

	[Address(RVA="0x15457BC", Offset="0x15457BC", VA="0x15457BC", Slot="21")]
	public void HandleDispatchAction(DTextLinkInputAction action)
	{
	}

	[Address(RVA="0x15459FC", Offset="0x15459FC", VA="0x15459FC", Slot="22")]
	public void HandleDispatchAction(DConsoleCachedCommandAction action)
	{
	}

	[Address(RVA="0x1545A88", Offset="0x1545A88", VA="0x1545A88", Slot="23")]
	public void HandleDispatchAction(DConsoleCommandHelpAction action)
	{
	}

	[Address(RVA="0x1546F3C", Offset="0x1546F3C", VA="0x1546F3C")]
	private void IncreaseFontSize()
	{
	}

	[Address(RVA="0x15470A0", Offset="0x15470A0", VA="0x15470A0")]
	private void InitializeCachedCommandListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1546E20", Offset="0x1546E20", VA="0x1546E20")]
	private void InputFieldEnterButtonClicked()
	{
	}

	[Address(RVA="0x1547240", Offset="0x1547240", VA="0x1547240")]
	private char InputFieldValidator(string text, int charIndex, char addedChar)
	{
		return new char();
	}

	[Address(RVA="0x15454B0", Offset="0x15454B0", VA="0x15454B0")]
	public void LogToConsole(ConsoleView.DConsoleText log)
	{
	}

	[Address(RVA="0x1547008", Offset="0x1547008", VA="0x1547008")]
	private void ScreenshotButtonClicked()
	{
	}

	[Address(RVA="0x154577C", Offset="0x154577C", VA="0x154577C")]
	public void SelectInputField()
	{
	}

	[Address(RVA="0x1546AD8", Offset="0x1546AD8", VA="0x1546AD8")]
	private void SnapScrollToEnd()
	{
	}

	[Address(RVA="0x1545A08", Offset="0x1545A08", VA="0x1545A08")]
	private void ToggleCachedCommandsPanel()
	{
	}

	[Address(RVA="0x1547250", Offset="0x1547250", VA="0x1547250")]
	private void ToggleCommandsRoot()
	{
	}

	[Address(RVA="0x15455C8", Offset="0x15455C8", VA="0x15455C8")]
	private void UpdateOutputLabel()
	{
	}

	[Address(RVA="0x1545B14", Offset="0x1545B14", VA="0x1545B14", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1546C44", Offset="0x1546C44", VA="0x1546C44", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Address(RVA="0x15469B8", Offset="0x15469B8", VA="0x15469B8", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x15462E8", Offset="0x15462E8", VA="0x15462E8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BBCC", Offset="0x104BBCC")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset="0x10")]
		public DTextLinkInputAction action;

		[Address(RVA="0x15459F4", Offset="0x15459F4", VA="0x15459F4")]
		public <>c__DisplayClass10_0()
		{
		}

		[Address(RVA="0x1547508", Offset="0x1547508", VA="0x1547508")]
		internal bool <HandleDispatchAction>b__0(ConsoleView.DConsoleText t)
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BBDC", Offset="0x104BBDC")]
	private sealed class <>c__DisplayClass18_0
	{
		[FieldOffset(Offset="0x10")]
		public StringBuilder sb;

		[Address(RVA="0x1546D34", Offset="0x1546D34", VA="0x1546D34")]
		public <>c__DisplayClass18_0()
		{
		}

		[Address(RVA="0x154751C", Offset="0x154751C", VA="0x154751C")]
		internal void <UpdateOutputLabel>b__0(ConsoleView.DConsoleText s)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BBAC", Offset="0x104BBAC")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public ConsoleCommandButtonData buttonData;

		[Address(RVA="0x15453C0", Offset="0x15453C0", VA="0x15453C0")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x1547554", Offset="0x1547554", VA="0x1547554")]
		internal void <AddCommandButtons>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BBBC", Offset="0x104BBBC")]
	private sealed class <>c__DisplayClass6_1
	{
		[FieldOffset(Offset="0x10")]
		public ConsoleCommandToggleData toggleData;

		[FieldOffset(Offset="0x18")]
		public ConsoleView.<>c__DisplayClass6_0 CS$<>8__locals1;

		[Address(RVA="0x15453C8", Offset="0x15453C8", VA="0x15453C8")]
		public <>c__DisplayClass6_1()
		{
		}

		[Address(RVA="0x1547580", Offset="0x1547580", VA="0x1547580")]
		internal void <AddCommandButtons>b__0(bool on)
		{
		}
	}

	private struct DCommandToggle
	{
		[FieldOffset(Offset="0x0")]
		public Toggle Toggle;

		[FieldOffset(Offset="0x8")]
		public ConsoleCommandToggleData Data;
	}

	public struct DConsoleText
	{
		[FieldOffset(Offset="0x0")]
		public readonly string FormattedLogLine;

		[FieldOffset(Offset="0x8")]
		public readonly string LogLine;

		[FieldOffset(Offset="0x10")]
		public readonly string StackTrace;

		[FieldOffset(Offset="0x18")]
		public readonly int LinkId;

		[Address(RVA="0xF056A8", Offset="0xF056A8", VA="0xF056A8")]
		public DConsoleText(string formattedLogLine, string logLine, string stackTrace, int linkId)
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public Button CloseButton;

		[FieldOffset(Offset="0x30")]
		public UiInputField InputField;

		[FieldOffset(Offset="0x38")]
		public Button InputFieldEnterButton;

		[FieldOffset(Offset="0x40")]
		public UiLabel ConsoleOutputLabel;

		[FieldOffset(Offset="0x48")]
		public ContentSizeFitter ConsoleOutputLabelContentSizeFitter;

		[FieldOffset(Offset="0x50")]
		public ScrollRect ConsoleOutputScrollView;

		[FieldOffset(Offset="0x58")]
		public Toggle ScrollLockToggle;

		[FieldOffset(Offset="0x60")]
		public Button ClearButton;

		[FieldOffset(Offset="0x68")]
		public Button DecreaseFontSizeButton;

		[FieldOffset(Offset="0x70")]
		public Button IncreaseFontSizeButton;

		[FieldOffset(Offset="0x78")]
		public Button ScreenshotButton;

		[FieldOffset(Offset="0x80")]
		public Button CachedCommandsOpenButton;

		[FieldOffset(Offset="0x88")]
		public Button CachedCommandsCloseButton;

		[FieldOffset(Offset="0x90")]
		public UnityEngine.GameObject CachedCommandsPanel;

		[FieldOffset(Offset="0x98")]
		public WrappedScrollRect CachedCommandButtonsScrollRect;

		[FieldOffset(Offset="0xA0")]
		public TextLinkInputHandler TextLinkInputHandler;

		[FieldOffset(Offset="0xA8")]
		public UnityEngine.GameObject StackTraceContainer;

		[FieldOffset(Offset="0xB0")]
		public Button StackTraceContainerCloseHandler;

		[FieldOffset(Offset="0xB8")]
		public UiLabel StackTraceLabel;

		[FieldOffset(Offset="0xC0")]
		public UiLabel PlayerIdLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106A2BC", Offset="0x106A2BC")]
		[FieldOffset(Offset="0xC8")]
		public UnityEngine.GameObject CommandsRoot;

		[FieldOffset(Offset="0xD0")]
		public Button ToggleCommandsButton;

		[FieldOffset(Offset="0xD8")]
		public LabelButton CommandButton;

		[FieldOffset(Offset="0xE0")]
		public LabelToggle CommandToggle;

		[Address(RVA="0x154764C", Offset="0x154764C", VA="0x154764C")]
		public SerializedFields()
		{
		}
	}
}