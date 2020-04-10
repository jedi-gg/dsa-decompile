using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CampaignRewardTile : MonoBehaviour, IDispatchHandler<DPlayerActivityClaimedAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private CampaignRewardTile.DModel _model;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private GameObject _unclaimedRoot;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private GameObject _claimableRoot;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _claimedRoot;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _label;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private ParticleSystem _claimVfx;

	[Attribute(Name="HeaderAttribute", RVA="0x10555BC", Offset="0x10555BC")]
	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private AudioClipGroup _clickAudio;

	public bool Claimable
	{
		[Address(RVA="0x11355FC", Offset="0x11355FC", VA="0x11355FC")]
		get
		{
			return new bool();
		}
	}

	public bool Claimed
	{
		[Address(RVA="0x1135608", Offset="0x1135608", VA="0x1135608")]
		get
		{
			return new bool();
		}
	}

	public bool Locked
	{
		[Address(RVA="0x1135614", Offset="0x1135614", VA="0x1135614")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1135B8C", Offset="0x1135B8C", VA="0x1135B8C")]
	public CampaignRewardTile()
	{
	}

	[Address(RVA="0x1135AAC", Offset="0x1135AAC", VA="0x1135AAC")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x11358A4", Offset="0x11358A4", VA="0x11358A4")]
	public RectTransform GetTutorialPointAt()
	{
		return null;
	}

	[Address(RVA="0x113591C", Offset="0x113591C", VA="0x113591C", Slot="4")]
	public void HandleDispatchAction(DPlayerActivityClaimedAction action)
	{
	}

	[Address(RVA="0x1135620", Offset="0x1135620", VA="0x1135620")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11357CC", Offset="0x11357CC", VA="0x11357CC")]
	public void SetData(CampaignRewardTile.DModel model)
	{
	}

	[Address(RVA="0x1135758", Offset="0x1135758", VA="0x1135758")]
	public void Shutdown()
	{
	}

	public struct DModel
	{
		[FieldOffset(Offset="0x0")]
		public PlayerActivity PlayerActivity;

		[FieldOffset(Offset="0x8")]
		public readonly DCampaignAddress CampaignMapAddress;

		public bool Claimable
		{
			[Address(RVA="0xEFCF6C", Offset="0xEFCF6C", VA="0xEFCF6C")]
			get
			{
				return new bool();
			}
		}

		public bool Claimed
		{
			[Address(RVA="0xEFCF5C", Offset="0xEFCF5C", VA="0xEFCF5C")]
			get
			{
				return new bool();
			}
		}

		public bool Locked
		{
			[Address(RVA="0xEFCF54", Offset="0xEFCF54", VA="0xEFCF54")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0xEFCFA8", Offset="0xEFCFA8", VA="0xEFCFA8")]
		public DModel(PlayerActivity playerActivity, DCampaignAddress campaignMapAddress)
		{
		}
	}
}