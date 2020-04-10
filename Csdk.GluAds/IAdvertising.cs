using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluAds
{
	public interface IAdvertising : IDisposable
	{
		void Discard(string advertisementType, string identifier, IDictionary<string, object> extra);

		Reward GetReward(string advertisementType, string placement);

		bool IsLoaded(string advertisementType, string placement, IDictionary<string, object> extra);

		void Load(string advertisementType, string placement, IDictionary<string, object> extra);

		[Attribute(Name="ObsoleteAttribute", RVA="0x1074CD0", Offset="0x1074CD0")]
		void OnAdvertisementClick(string advertisementType, string identifier, IDictionary<string, object> extra);

		[Attribute(Name="ObsoleteAttribute", RVA="0x1074C94", Offset="0x1074C94")]
		void OnAdvertisementImpression(string advertisementType, string identifier, IDictionary<string, object> extra);

		void SetCustomProperties(IDictionary<string, object> properties);

		void SetUserIdentifier(string userIdentifier, IDictionary<string, object> extra);

		void Show(string advertisementType, string placement, IDictionary<string, object> extra);

		[Attribute(Name="ObsoleteAttribute", RVA="0x1091604", Offset="0x1091604")]
		event Action<CustomAction> CustomActionReceived;

		event Action<PlacementEvent> PlacementEventReceived;

		event Action<Reward> RewardReceived;
	}
}