using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace GooglePlayGames.BasicApi.Nearby
{
	public class DummyNearbyConnectionClient : INearbyConnectionClient
	{
		[Address(RVA="0x1EC69BC", Offset="0x1EC69BC", VA="0x1EC69BC")]
		public DummyNearbyConnectionClient()
		{
		}

		[Address(RVA="0x1EC660C", Offset="0x1EC660C", VA="0x1EC660C", Slot="11")]
		public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener)
		{
		}

		[Address(RVA="0x1EC67BC", Offset="0x1EC67BC", VA="0x1EC67BC", Slot="15")]
		public void DisconnectFromEndpoint(string remoteEndpointId)
		{
		}

		[Address(RVA="0x1EC692C", Offset="0x1EC692C", VA="0x1EC692C", Slot="17")]
		public string GetAppBundleId()
		{
			return null;
		}

		[Address(RVA="0x1EC6974", Offset="0x1EC6974", VA="0x1EC6974", Slot="18")]
		public string GetServiceId()
		{
			return null;
		}

		[Address(RVA="0x1EC68E4", Offset="0x1EC68E4", VA="0x1EC68E4")]
		public string LocalDeviceId()
		{
			return null;
		}

		[Address(RVA="0x1EC6894", Offset="0x1EC6894", VA="0x1EC6894")]
		public string LocalEndpointId()
		{
			return null;
		}

		[Address(RVA="0x1EC6334", Offset="0x1EC6334", VA="0x1EC6334", Slot="5")]
		public int MaxReliableMessagePayloadLength()
		{
			return new int();
		}

		[Address(RVA="0x1EC632C", Offset="0x1EC632C", VA="0x1EC632C", Slot="4")]
		public int MaxUnreliableMessagePayloadLength()
		{
			return new int();
		}

		[Address(RVA="0x1EC6750", Offset="0x1EC6750", VA="0x1EC6750", Slot="14")]
		public void RejectConnectionRequest(string requestingEndpointId)
		{
		}

		[Address(RVA="0x1EC6520", Offset="0x1EC6520", VA="0x1EC6520", Slot="10")]
		public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener)
		{
		}

		[Address(RVA="0x1EC633C", Offset="0x1EC633C", VA="0x1EC633C", Slot="6")]
		public void SendReliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Address(RVA="0x1EC63A8", Offset="0x1EC63A8", VA="0x1EC63A8", Slot="7")]
		public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Address(RVA="0x1EC6414", Offset="0x1EC6414", VA="0x1EC6414", Slot="8")]
		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback)
		{
		}

		[Address(RVA="0x1EC6678", Offset="0x1EC6678", VA="0x1EC6678", Slot="12")]
		public void StartDiscovery(string serviceId, TimeSpan? advertisingTimeout, IDiscoveryListener listener)
		{
		}

		[Address(RVA="0x1EC64B4", Offset="0x1EC64B4", VA="0x1EC64B4", Slot="9")]
		public void StopAdvertising()
		{
		}

		[Address(RVA="0x1EC6828", Offset="0x1EC6828", VA="0x1EC6828", Slot="16")]
		public void StopAllConnections()
		{
		}

		[Address(RVA="0x1EC66E4", Offset="0x1EC66E4", VA="0x1EC66E4", Slot="13")]
		public void StopDiscovery(string serviceId)
		{
		}
	}
}