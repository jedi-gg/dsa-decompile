using DG.Tweening;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="RequireComponent", RVA="0x104882C", Offset="0x104882C")]
public class CampaignMapSelectorComponent : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x20")]
	private MonoArchetypePool<CampaignMapButtonComponent> _mapButtonPool;

	[FieldOffset(Offset="0x28")]
	private CanvasGroup _canvasGroup;

	[FieldOffset(Offset="0x30")]
	private Sequence _showSequence;

	[FieldOffset(Offset="0x38")]
	private Sequence _hideSequence;

	[FieldOffset(Offset="0x40")]
	private bool _showing;

	[FieldOffset(Offset="0x44")]
	[SerializeField]
	private float _tweenDuration;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private float _tweenYOffset;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private CampaignMapButtonComponent _mapButtonArchetype;

	[Address(RVA="0x1130760", Offset="0x1130760", VA="0x1130760")]
	public CampaignMapSelectorComponent()
	{
	}

	[Address(RVA="0x112F764", Offset="0x112F764", VA="0x112F764")]
	public void Initialize(WidgetDependencyContainer depCon)
	{
	}

	[Address(RVA="0x112FB5C", Offset="0x112FB5C", VA="0x112FB5C")]
	public void SetCampaign(Campaign? normalCampaign, Campaign? hardCampaign)
	{
	}

	[Address(RVA="0x1130474", Offset="0x1130474", VA="0x1130474")]
	public void SetSelected(DCampaignAddress mapAddress)
	{
	}

	[Address(RVA="0x1130564", Offset="0x1130564", VA="0x1130564")]
	public void SetSelected(int mapButtonIndex)
	{
	}

	[Address(RVA="0x1130634", Offset="0x1130634", VA="0x1130634")]
	public void Show(bool show)
	{
	}

	[Address(RVA="0x112FACC", Offset="0x112FACC", VA="0x112FACC")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x112FD6C", Offset="0x112FD6C", VA="0x112FD6C")]
	public void UpdateMapComponents(Campaign? normalCampaign, Campaign? hardCampaign)
	{
	}
}