using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class SocialTabView : ATabView, IDispatchHandler<DLoadedSocialFeatureAction>, IDispatchHandler, IDispatchHandler<DPlayerClubChangedAction>, IDispatchHandler<DLoadSocialTabAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105C550", Offset="0x105C550")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105C560", Offset="0x105C560")]
	[FieldOffset(Offset="0x70")]
	private FeatureLockController _featureLockController;

	private SocialTabView.SerializedFields Fields
	{
		[Address(RVA="0x14C8DD4", Offset="0x14C8DD4", VA="0x14C8DD4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14C93AC", Offset="0x14C93AC", VA="0x14C93AC")]
	public SocialTabView()
	{
	}

	[Address(RVA="0x14C8D70", Offset="0x14C8D70", VA="0x14C8D70", Slot="22")]
	public void HandleDispatchAction(DLoadedSocialFeatureAction action)
	{
	}

	[Address(RVA="0x14C8FEC", Offset="0x14C8FEC", VA="0x14C8FEC", Slot="23")]
	public void HandleDispatchAction(DPlayerClubChangedAction action)
	{
	}

	[Address(RVA="0x14C9180", Offset="0x14C9180", VA="0x14C9180", Slot="24")]
	public void HandleDispatchAction(DLoadSocialTabAction action)
	{
	}

	[Address(RVA="0x14C924C", Offset="0x14C924C", VA="0x14C924C", Slot="21")]
	protected override void InitializedTabs(int selectedTab)
	{
	}

	[Address(RVA="0x14C8EB4", Offset="0x14C8EB4", VA="0x14C8EB4")]
	private void SetTitleForTab(SocialGameState.Tab tab)
	{
	}

	[Address(RVA="0x14C9090", Offset="0x14C9090", VA="0x14C9090")]
	private bool ShouldShowTab(SocialGameState.Tab tab)
	{
		return new bool();
	}

	[Address(RVA="0x14C91C8", Offset="0x14C91C8", VA="0x14C91C8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14C9208", Offset="0x14C9208", VA="0x14C9208", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ATabView.SerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public UnityEngine.GameObject Background;

		[FieldOffset(Offset="0x38")]
		public UnityEngine.GameObject ChatTab;

		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject ClubRequestsTab;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.GameObject ClubInviteTab;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject ClubTab;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject FriendsTab;

		[Attribute(Name="HeaderAttribute", RVA="0x106BA04", Offset="0x106BA04")]
		[FieldOffset(Offset="0x60")]
		public UnityEngine.GameObject ClubsTitle;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject ClubRequestsTitle;

		[FieldOffset(Offset="0x70")]
		public UnityEngine.GameObject FriendsTitle;

		[FieldOffset(Offset="0x78")]
		public UnityEngine.GameObject ChatTitle;

		[FieldOffset(Offset="0x80")]
		public UnityEngine.GameObject InvitesTitle;

		[Address(RVA="0x14C93B4", Offset="0x14C93B4", VA="0x14C93B4")]
		public SerializedFields()
		{
		}
	}
}