using GooglePlayGames.BasicApi.Nearby;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace GooglePlayGames.Android
{
	public class AndroidNearbyConnectionClient : INearbyConnectionClient
	{
		[FieldOffset(Offset="0x10")]
		private AndroidJavaObject mClient;

		[FieldOffset(Offset="0x0")]
		private readonly static long NearbyClientId;

		[FieldOffset(Offset="0x8")]
		private readonly static int ApplicationInfoFlags;

		[FieldOffset(Offset="0x10")]
		private readonly static string ServiceId;

		[FieldOffset(Offset="0x18")]
		protected IMessageListener mAdvertisingMessageListener;

		[Address(RVA="0x162F848", Offset="0x162F848", VA="0x162F848")]
		static AndroidNearbyConnectionClient()
		{
		}

		[Address(RVA="0x162C3D8", Offset="0x162C3D8", VA="0x162C3D8")]
		public AndroidNearbyConnectionClient()
		{
		}

		[Address(RVA="0x162DCCC", Offset="0x162DCCC", VA="0x162DCCC", Slot="11")]
		public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener)
		{
		}

		[Address(RVA="0x162D264", Offset="0x162D264", VA="0x162D264")]
		private AndroidJavaObject CreateAdvertisingOptions()
		{
			return null;
		}

		[Address(RVA="0x162E7FC", Offset="0x162E7FC", VA="0x162E7FC")]
		private AndroidJavaObject CreateDiscoveryOptions()
		{
			return null;
		}

		[Address(RVA="0x162EE8C", Offset="0x162EE8C", VA="0x162EE8C", Slot="15")]
		public void DisconnectFromEndpoint(string remoteEndpointId)
		{
		}

		[Address(RVA="0x162F000", Offset="0x162F000", VA="0x162F000", Slot="17")]
		public string GetAppBundleId()
		{
			return null;
		}

		[Address(RVA="0x162D6E8", Offset="0x162D6E8", VA="0x162D6E8", Slot="18")]
		public string GetServiceId()
		{
			return null;
		}

		[Address(RVA="0x162C640", Offset="0x162C640", VA="0x162C640")]
		private void InternalSend(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Address(RVA="0x162C634", Offset="0x162C634", VA="0x162C634", Slot="5")]
		public int MaxReliableMessagePayloadLength()
		{
			return new int();
		}

		[Address(RVA="0x162C62C", Offset="0x162C62C", VA="0x162C62C", Slot="4")]
		public int MaxUnreliableMessagePayloadLength()
		{
			return new int();
		}

		[Address(RVA="0x162F158", Offset="0x162F158", VA="0x162F158")]
		private static string ReadServiceId()
		{
			return null;
		}

		[Address(RVA="0x162ED00", Offset="0x162ED00", VA="0x162ED00", Slot="14")]
		public void RejectConnectionRequest(string requestingEndpointId)
		{
		}

		[Address(RVA="0x162D7E0", Offset="0x162D7E0", VA="0x162D7E0", Slot="10")]
		public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener)
		{
		}

		[Address(RVA="0x162C63C", Offset="0x162C63C", VA="0x162C63C", Slot="6")]
		public void SendReliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Address(RVA="0x162CAB4", Offset="0x162CAB4", VA="0x162CAB4", Slot="7")]
		public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload)
		{
		}

		[Address(RVA="0x162CAB8", Offset="0x162CAB8", VA="0x162CAB8", Slot="8")]
		public void StartAdvertising(string name, List<string> appIdentifiers, TimeSpan? advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback)
		{
		}

		[Address(RVA="0x162E0D0", Offset="0x162E0D0", VA="0x162E0D0", Slot="12")]
		public void StartDiscovery(string serviceId, TimeSpan? advertisingDuration, IDiscoveryListener listener)
		{
		}

		[Address(RVA="0x162D750", Offset="0x162D750", VA="0x162D750", Slot="9")]
		public void StopAdvertising()
		{
		}

		[Address(RVA="0x162EF70", Offset="0x162EF70", VA="0x162EF70", Slot="16")]
		public void StopAllConnections()
		{
		}

		[Address(RVA="0x162EC80", Offset="0x162EC80", VA="0x162EC80", Slot="13")]
		public void StopDiscovery(string serviceId)
		{
		}

		[Address(RVA="0x1F5C0B0", Offset="0x1F5C0B0", VA="0x1F5C0B0")]
		private static Action<T> ToOnGameThread<T>(Action<T> toConvert)
		{
			return null;
		}

		[Address(RVA="0x1F5CBB0", Offset="0x1F5CBB0", VA="0x1F5CBB0")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E918", Offset="0x104E918")]
		private sealed class <>c__DisplayClass11_0
		{
			[FieldOffset(Offset="0x10")]
			public TimeSpan? advertisingDuration;

			[Address(RVA="0x162D1C0", Offset="0x162D1C0", VA="0x162D1C0")]
			public <>c__DisplayClass11_0()
			{
			}

			[Address(RVA="0x162F8B8", Offset="0x162F8B8", VA="0x162F8B8")]
			internal void <StartAdvertising>b__0(AndroidJavaObject v)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E928", Offset="0x104E928")]
		private sealed class <>c__DisplayClass18_0
		{
			[FieldOffset(Offset="0x10")]
			public TimeSpan? advertisingDuration;

			[Address(RVA="0x162E740", Offset="0x162E740", VA="0x162E740")]
			public <>c__DisplayClass18_0()
			{
			}

			[Address(RVA="0x162F928", Offset="0x162F928", VA="0x162F928")]
			internal void <StartDiscovery>b__0(AndroidJavaObject v)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E938", Offset="0x104E938")]
		private sealed class <>c__DisplayClass31_0<T>
		{
			[FieldOffset(Offset="0x0")]
			public Action<T> toConvert;

			[Address(RVA="0x1D8C900", Offset="0x1D8C900", VA="0x1D8C900")]
			public <>c__DisplayClass31_0()
			{
			}

			[Address(RVA="0x1D8C92C", Offset="0x1D8C92C", VA="0x1D8C92C")]
			internal void <ToOnGameThread>b__0(T val)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E948", Offset="0x104E948")]
		private sealed class <>c__DisplayClass31_1<T>
		{
			[FieldOffset(Offset="0x0")]
			public T val;

			[FieldOffset(Offset="0x0")]
			public AndroidNearbyConnectionClient.<>c__DisplayClass31_0<T> CS$<>8__locals1;

			[Address(RVA="0x1D8CCE8", Offset="0x1D8CCE8", VA="0x1D8CCE8")]
			public <>c__DisplayClass31_1()
			{
			}

			[Address(RVA="0x1D8CD14", Offset="0x1D8CD14", VA="0x1D8CD14")]
			internal void <ToOnGameThread>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E958", Offset="0x104E958")]
		private sealed class <>c__DisplayClass32_0<T1, T2>
		{
			[FieldOffset(Offset="0x0")]
			public Action<T1, T2> toConvert;

			[Address(RVA="0x1D8CEC0", Offset="0x1D8CEC0", VA="0x1D8CEC0")]
			public <>c__DisplayClass32_0()
			{
			}

			[Address(RVA="0x1D8CEEC", Offset="0x1D8CEEC", VA="0x1D8CEEC")]
			internal void <ToOnGameThread>b__0(T1 val1, T2 val2)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E968", Offset="0x104E968")]
		private sealed class <>c__DisplayClass32_1<T1, T2>
		{
			[FieldOffset(Offset="0x0")]
			public T1 val1;

			[FieldOffset(Offset="0x0")]
			public T2 val2;

			[FieldOffset(Offset="0x0")]
			public AndroidNearbyConnectionClient.<>c__DisplayClass32_0<T1, T2> CS$<>8__locals1;

			[Address(RVA="0x1D8D014", Offset="0x1D8D014", VA="0x1D8D014")]
			public <>c__DisplayClass32_1()
			{
			}

			[Address(RVA="0x1D8D040", Offset="0x1D8D040", VA="0x1D8D040")]
			internal void <ToOnGameThread>b__1()
			{
			}
		}

		private class AdvertisingConnectionLifecycleCallbackProxy : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x20")]
			private Action<AdvertisingResult> mResultCallback;

			[FieldOffset(Offset="0x28")]
			private Action<ConnectionRequest> mConnectionRequestCallback;

			[FieldOffset(Offset="0x30")]
			private AndroidNearbyConnectionClient mClient;

			[FieldOffset(Offset="0x38")]
			private string mLocalEndpointName;

			[Address(RVA="0x162D1C8", Offset="0x162D1C8", VA="0x162D1C8")]
			public AdvertisingConnectionLifecycleCallbackProxy(Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback, AndroidNearbyConnectionClient client)
			{
			}

			[Address(RVA="0x162F998", Offset="0x162F998", VA="0x162F998")]
			public void onConnectionInitiated(string endpointId, AndroidJavaObject connectionInfo)
			{
			}

			[Address(RVA="0x162FABC", Offset="0x162FABC", VA="0x162FABC")]
			public void onConnectionResult(string endpointId, AndroidJavaObject connectionResolution)
			{
			}

			[Address(RVA="0x162FCE0", Offset="0x162FCE0", VA="0x162FCE0")]
			public void onDisconnected(string endpointId)
			{
			}
		}

		private class DiscoveringConnectionLifecycleCallback : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x20")]
			private Action<ConnectionResponse> mResponseCallback;

			[FieldOffset(Offset="0x28")]
			private IMessageListener mListener;

			[FieldOffset(Offset="0x30")]
			private AndroidJavaObject mClient;

			[FieldOffset(Offset="0x38")]
			private string mLocalEndpointName;

			[Address(RVA="0x162DC30", Offset="0x162DC30", VA="0x162DC30")]
			public DiscoveringConnectionLifecycleCallback(Action<ConnectionResponse> responseCallback, IMessageListener listener, AndroidJavaObject client)
			{
			}

			[Address(RVA="0x162FDE0", Offset="0x162FDE0", VA="0x162FDE0")]
			public void onConnectionInitiated(string endpointId, AndroidJavaObject connectionInfo)
			{
			}

			[Address(RVA="0x1630118", Offset="0x1630118", VA="0x1630118")]
			public void onConnectionResult(string endpointId, AndroidJavaObject connectionResolution)
			{
			}

			[Address(RVA="0x1630460", Offset="0x1630460", VA="0x1630460")]
			public void onDisconnected(string endpointId)
			{
			}
		}

		private class EndpointDiscoveryCallback : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x20")]
			private IDiscoveryListener mListener;

			[Address(RVA="0x162E774", Offset="0x162E774", VA="0x162E774")]
			public EndpointDiscoveryCallback(IDiscoveryListener listener)
			{
			}

			[Address(RVA="0x1630630", Offset="0x1630630", VA="0x1630630")]
			private EndpointDetails CreateEndPointDetails(string endpointId, AndroidJavaObject endpointInfo)
			{
				return new EndpointDetails();
			}

			[Address(RVA="0x1630528", Offset="0x1630528", VA="0x1630528")]
			public void onEndpointFound(string endpointId, AndroidJavaObject endpointInfo)
			{
			}

			[Address(RVA="0x1630724", Offset="0x1630724", VA="0x1630724")]
			public void onEndpointLost(string endpointId)
			{
			}
		}

		private class OnGameThreadDiscoveryListener : IDiscoveryListener
		{
			[FieldOffset(Offset="0x10")]
			private readonly IDiscoveryListener mListener;

			[Address(RVA="0x162E748", Offset="0x162E748", VA="0x162E748")]
			public OnGameThreadDiscoveryListener(IDiscoveryListener listener)
			{
			}

			[Address(RVA="0x16307EC", Offset="0x16307EC", VA="0x16307EC", Slot="4")]
			public void OnEndpointFound(EndpointDetails discoveredEndpoint)
			{
			}

			[Address(RVA="0x1630918", Offset="0x1630918", VA="0x1630918", Slot="5")]
			public void OnEndpointLost(string lostEndpointId)
			{
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10515C8", Offset="0x10515C8")]
			private sealed class <>c__DisplayClass2_0
			{
				[FieldOffset(Offset="0x10")]
				public AndroidNearbyConnectionClient.OnGameThreadDiscoveryListener <>4__this;

				[FieldOffset(Offset="0x18")]
				public EndpointDetails discoveredEndpoint;

				[Address(RVA="0x1630910", Offset="0x1630910", VA="0x1630910")]
				public <>c__DisplayClass2_0()
				{
				}

				[Address(RVA="0x1630A04", Offset="0x1630A04", VA="0x1630A04")]
				internal void <OnEndpointFound>b__0()
				{
				}
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10515D8", Offset="0x10515D8")]
			private sealed class <>c__DisplayClass3_0
			{
				[FieldOffset(Offset="0x10")]
				public AndroidNearbyConnectionClient.OnGameThreadDiscoveryListener <>4__this;

				[FieldOffset(Offset="0x18")]
				public string lostEndpointId;

				[Address(RVA="0x16309FC", Offset="0x16309FC", VA="0x16309FC")]
				public <>c__DisplayClass3_0()
				{
				}

				[Address(RVA="0x1630B0C", Offset="0x1630B0C", VA="0x1630B0C")]
				internal void <OnEndpointLost>b__0()
				{
				}
			}
		}

		private class OnGameThreadMessageListener : IMessageListener
		{
			[FieldOffset(Offset="0x10")]
			private readonly IMessageListener mListener;

			[Address(RVA="0x162DBC0", Offset="0x162DBC0", VA="0x162DBC0")]
			public OnGameThreadMessageListener(IMessageListener listener)
			{
			}

			[Address(RVA="0x1630BDC", Offset="0x1630BDC", VA="0x1630BDC", Slot="4")]
			public void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage)
			{
			}

			[Address(RVA="0x1630D00", Offset="0x1630D00", VA="0x1630D00", Slot="5")]
			public void OnRemoteEndpointDisconnected(string remoteEndpointId)
			{
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10515A8", Offset="0x10515A8")]
			private sealed class <>c__DisplayClass2_0
			{
				[FieldOffset(Offset="0x10")]
				public AndroidNearbyConnectionClient.OnGameThreadMessageListener <>4__this;

				[FieldOffset(Offset="0x18")]
				public string remoteEndpointId;

				[FieldOffset(Offset="0x20")]
				public byte[] data;

				[FieldOffset(Offset="0x28")]
				public bool isReliableMessage;

				[Address(RVA="0x1630CF8", Offset="0x1630CF8", VA="0x1630CF8")]
				public <>c__DisplayClass2_0()
				{
				}

				[Address(RVA="0x1630DEC", Offset="0x1630DEC", VA="0x1630DEC")]
				internal void <OnMessageReceived>b__0()
				{
				}
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10515B8", Offset="0x10515B8")]
			private sealed class <>c__DisplayClass3_0
			{
				[FieldOffset(Offset="0x10")]
				public AndroidNearbyConnectionClient.OnGameThreadMessageListener <>4__this;

				[FieldOffset(Offset="0x18")]
				public string remoteEndpointId;

				[Address(RVA="0x1630DE4", Offset="0x1630DE4", VA="0x1630DE4")]
				public <>c__DisplayClass3_0()
				{
				}

				[Address(RVA="0x1630ED0", Offset="0x1630ED0", VA="0x1630ED0")]
				internal void <OnRemoteEndpointDisconnected>b__0()
				{
				}
			}
		}

		private class PayloadCallback : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x20")]
			private IMessageListener mListener;

			[Address(RVA="0x162E048", Offset="0x162E048", VA="0x162E048")]
			public PayloadCallback(IMessageListener listener)
			{
			}

			[Address(RVA="0x1630FA0", Offset="0x1630FA0", VA="0x1630FA0")]
			public void onPayloadReceived(string endpointId, AndroidJavaObject payload)
			{
			}
		}
	}
}