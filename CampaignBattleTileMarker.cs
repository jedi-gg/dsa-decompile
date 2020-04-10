using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="ExecuteInEditMode", RVA="0x10487B8", Offset="0x10487B8")]
public class CampaignBattleTileMarker : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private const float TILE_WIDTH = 152f;

	[FieldOffset(Offset="0x18")]
	private Canvas _canvas;

	[FieldOffset(Offset="0x20")]
	private CampaignBattleTile _battleTile;

	[FieldOffset(Offset="0x28")]
	private DCampaignAddress _campaignAddress;

	[FieldOffset(Offset="0x40")]
	private CampaignBattleTile.DModel _model;

	[FieldOffset(Offset="0x88")]
	private bool _nextBattleTileSpawnShouldStartSelected;

	[FieldOffset(Offset="0x90")]
	private Func<CampaignBattleTile> _battleTilePoolSpawner;

	[FieldOffset(Offset="0x98")]
	private Action<CampaignBattleTile> _battleTilePoolDespawner;

	public DCampaignAddress CampaignAddress
	{
		[Address(RVA="0x1126294", Offset="0x1126294", VA="0x1126294")]
		get
		{
			return new DCampaignAddress();
		}
	}

	public bool IsBoss
	{
		[Address(RVA="0x11262A8", Offset="0x11262A8", VA="0x11262A8")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11269B8", Offset="0x11269B8", VA="0x11269B8")]
	public CampaignBattleTileMarker()
	{
	}

	[Address(RVA="0x11266A8", Offset="0x11266A8", VA="0x11266A8")]
	public float GetLocalPositionWithinContent()
	{
		return new float();
	}

	[Address(RVA="0x11262B0", Offset="0x11262B0", VA="0x11262B0")]
	public void Initialize(DCampaignAddress campaignAddress, CampaignBattleTile.DModel model, Func<CampaignBattleTile> battleTilePoolSpawner, Action<CampaignBattleTile> battleTilePoolDespawner)
	{
	}

	[Address(RVA="0x1126804", Offset="0x1126804", VA="0x1126804")]
	private void OnDrawGizmos()
	{
	}

	[Address(RVA="0x112674C", Offset="0x112674C", VA="0x112674C")]
	public void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x112634C", Offset="0x112634C", VA="0x112634C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1126354", Offset="0x1126354", VA="0x1126354")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x11267FC", Offset="0x11267FC", VA="0x11267FC")]
	public void UpdateLimitedAttemptsRemaining(uint limitedAttemptsRemaining)
	{
	}
}