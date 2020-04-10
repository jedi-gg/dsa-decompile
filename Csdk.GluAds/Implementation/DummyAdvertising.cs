using Csdk.GluAds;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluAds.Implementation
{
	public class DummyAdvertising : IAdvertising, IDisposable
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1060DA4", Offset="0x1060DA4")]
		[FieldOffset(Offset="0x10")]
		private Action<PlacementEvent> PlacementEventReceived;

		[Address(RVA="0x154EC88", Offset="0x154EC88", VA="0x154EC88")]
		public DummyAdvertising()
		{
		}

		[Address(RVA="0x1551464", Offset="0x1551464", VA="0x1551464")]
		private void CheckAdvertisementTypeAndIdentifier(string advertisementType, string identifier)
		{
		}

		[Address(RVA="0x15510C0", Offset="0x15510C0", VA="0x15510C0")]
		private void CheckAdvertisementTypeAndPlacement(string advertisementType, string placement)
		{
		}

		[Address(RVA="0x1551520", Offset="0x1551520", VA="0x1551520", Slot="16")]
		public void Discard(string advertisementType, string identifier, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x15510A0", Offset="0x15510A0", VA="0x15510A0", Slot="19")]
		public void Dispose()
		{
		}

		[Address(RVA="0x15515AC", Offset="0x15515AC", VA="0x15515AC", Slot="18")]
		public Reward GetReward(string advertisementType, string placement)
		{
			return null;
		}

		[Address(RVA="0x15510A8", Offset="0x15510A8", VA="0x15510A8", Slot="10")]
		public bool IsLoaded(string advertisementType, string placement, IDictionary<string, object> extra)
		{
			return new bool();
		}

		[Address(RVA="0x1551174", Offset="0x1551174", VA="0x1551174", Slot="11")]
		public void Load(string advertisementType, string placement, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x1551518", Offset="0x1551518", VA="0x1551518", Slot="14")]
		public void OnAdvertisementClick(string advertisementType, string identifier, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x1551460", Offset="0x1551460", VA="0x1551460", Slot="13")]
		public void OnAdvertisementImpression(string advertisementType, string identifier, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x15515A8", Offset="0x15515A8", VA="0x15515A8", Slot="17")]
		public void SetCustomProperties(IDictionary<string, object> properties)
		{
		}

		[Address(RVA="0x155151C", Offset="0x155151C", VA="0x155151C", Slot="15")]
		public void SetUserIdentifier(string userIdentifier, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x1551370", Offset="0x1551370", VA="0x1551370", Slot="12")]
		public void Show(string advertisementType, string placement, IDictionary<string, object> extra)
		{
		}

		public event Action<CustomAction> CustomActionReceived
		{
			[Address(RVA="0x1550EB8", Offset="0x1550EB8", VA="0x1550EB8", Slot="4")]
			add
			{
			}
			[Address(RVA="0x1550EBC", Offset="0x1550EBC", VA="0x1550EBC", Slot="5")]
			remove
			{
			}
		}

		public event Action<PlacementEvent> PlacementEventReceived
		{
			[Address(RVA="0x1550EC0", Offset="0x1550EC0", VA="0x1550EC0", Slot="6")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074D6C", Offset="0x1074D6C")]
			add
			{
			}
			[Address(RVA="0x1550FAC", Offset="0x1550FAC", VA="0x1550FAC", Slot="7")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1074D7C", Offset="0x1074D7C")]
			remove
			{
			}
		}

		public event Action<Reward> RewardReceived
		{
			[Address(RVA="0x1551098", Offset="0x1551098", VA="0x1551098", Slot="8")]
			add
			{
			}
			[Address(RVA="0x155109C", Offset="0x155109C", VA="0x155109C", Slot="9")]
			remove
			{
			}
		}
	}
}