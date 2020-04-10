using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class AchievementsView : APlayerActivityView
{
	protected override BadgingSource BadgingSource
	{
		[Address(RVA="0x11567E0", Offset="0x11567E0", VA="0x11567E0", Slot="28")]
		get
		{
			return new BadgingSource();
		}
	}

	private AchievementsView.SerializedFields Fields
	{
		[Address(RVA="0x11566D0", Offset="0x11566D0", VA="0x11566D0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11567E8", Offset="0x11567E8", VA="0x11567E8")]
	public AchievementsView()
	{
	}

	[Address(RVA="0x11561C0", Offset="0x11561C0", VA="0x11561C0")]
	public void SetData(IEnumerable<PlayerActivity> activities)
	{
	}

	[Address(RVA="0x11567B0", Offset="0x11567B0", VA="0x11567B0", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11567B8", Offset="0x11567B8", VA="0x11567B8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : APlayerActivityView.PlayerActivitySerializedFields
	{
		[Address(RVA="0x11567F0", Offset="0x11567F0", VA="0x11567F0")]
		public SerializedFields()
		{
		}
	}
}