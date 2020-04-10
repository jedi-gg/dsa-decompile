using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class InboxMessageListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Button _background;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UiLabel _previewLabel;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UiLabel _receivedLabel;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UiLabel _statusLabel;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _badge;

	[Address(RVA="0x117E9C0", Offset="0x117E9C0", VA="0x117E9C0")]
	public InboxMessageListItem()
	{
	}

	[Address(RVA="0x117E648", Offset="0x117E648", VA="0x117E648")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x117E69C", Offset="0x117E69C", VA="0x117E69C")]
	public void SetData(InboxViewController.Message message)
	{
	}

	[Address(RVA="0x117E96C", Offset="0x117E96C", VA="0x117E96C", Slot="4")]
	public override void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C0BC", Offset="0x104C0BC")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset="0x10")]
		public InboxMessageListItem <>4__this;

		[FieldOffset(Offset="0x18")]
		public InboxViewController.Message message;

		[Address(RVA="0x117E964", Offset="0x117E964", VA="0x117E964")]
		public <>c__DisplayClass1_0()
		{
		}

		[Address(RVA="0x117E9C8", Offset="0x117E9C8", VA="0x117E9C8")]
		internal void <SetData>b__0()
		{
		}
	}
}