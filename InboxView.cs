using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InboxView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x1059218", Offset="0x1059218")]
	[FieldOffset(Offset="0x68")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x1059228", Offset="0x1059228")]
	[FieldOffset(Offset="0x70")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1059238", Offset="0x1059238")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x80")]
	private IReadOnlyList<InboxViewController.Message> _messages;

	private InboxView.SerializedFields Fields
	{
		[Address(RVA="0x11825D0", Offset="0x11825D0", VA="0x11825D0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x118315C", Offset="0x118315C", VA="0x118315C")]
	public InboxView()
	{
	}

	[Address(RVA="0x1183164", Offset="0x1183164", VA="0x1183164")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FED4", Offset="0x106FED4")]
	private void <ViewAssetLoaded>b__4_0(UiLockableFeature l)
	{
	}

	[Address(RVA="0x1182D94", Offset="0x1182D94", VA="0x1182D94")]
	private void BindMessageListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1182EE4", Offset="0x1182EE4", VA="0x1182EE4")]
	private void DailyLoginClicked()
	{
	}

	[Address(RVA="0x118307C", Offset="0x118307C", VA="0x118307C")]
	private void DailyRewardClicked()
	{
	}

	[Address(RVA="0x11826B0", Offset="0x11826B0", VA="0x11826B0")]
	public void HideDailyRewardButton()
	{
	}

	[Address(RVA="0x1182CB8", Offset="0x1182CB8", VA="0x1182CB8")]
	private void InitializeMessageListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1182FE4", Offset="0x1182FE4", VA="0x1182FE4")]
	private void NewsletterClicked()
	{
	}

	[Address(RVA="0x1182410", Offset="0x1182410", VA="0x1182410")]
	public void RefreshMessageList()
	{
	}

	[Address(RVA="0x1182408", Offset="0x1182408", VA="0x1182408")]
	public void SetMessages(IReadOnlyList<InboxViewController.Message> messages)
	{
	}

	[Address(RVA="0x11826B8", Offset="0x11826B8", VA="0x11826B8")]
	private void ShowDailyReward(bool show)
	{
	}

	[Address(RVA="0x11827A0", Offset="0x11827A0", VA="0x11827A0")]
	public void ShowNewsletter(bool show)
	{
	}

	[Address(RVA="0x1182800", Offset="0x1182800", VA="0x1182800", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1182B44", Offset="0x1182B44", VA="0x1182B44", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C11C", Offset="0x104C11C")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset="0x10")]
		public bool show;

		[Address(RVA="0x1183154", Offset="0x1183154", VA="0x1183154")]
		public <>c__DisplayClass11_0()
		{
		}

		[Address(RVA="0x11831E4", Offset="0x11831E4", VA="0x11831E4")]
		internal void <ShowDailyReward>b__0(UnityEngine.GameObject o)
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0x30")]
		public List<UiLockableFeature> UiLockableFeatures;

		[FieldOffset(Offset="0x38")]
		public WrappedScrollRect MessageScrollRect;

		[FieldOffset(Offset="0x40")]
		public UiLabel EmptyLabel;

		[FieldOffset(Offset="0x48")]
		public Button DailyLoginButton;

		[FieldOffset(Offset="0x50")]
		public Button NewsletterButton;

		[FieldOffset(Offset="0x58")]
		public Button DailyRewardButton;

		[FieldOffset(Offset="0x60")]
		public List<UnityEngine.GameObject> DailyRewardObjects;

		[Address(RVA="0x118323C", Offset="0x118323C", VA="0x118323C")]
		public SerializedFields()
		{
		}
	}
}