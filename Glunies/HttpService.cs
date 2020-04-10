using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Glunies
{
	public sealed class HttpService : IDispatchHandler<DServiceNetworkRetryAction>, IDispatchHandler
	{
		[Attribute(Name="InjectAttribute", RVA="0x10642D0", Offset="0x10642D0")]
		[FieldOffset(Offset="0x10")]
		private DispatchSystem _dispatchSystem;

		[FieldOffset(Offset="0x18")]
		private List<Action> _pendingRetries;

		[Address(RVA="0x14295D4", Offset="0x14295D4", VA="0x14295D4")]
		public HttpService()
		{
		}

		[Address(RVA="0x141B52C", Offset="0x141B52C", VA="0x141B52C")]
		public void Get(string url, HttpService.RequestBodySuccess success, HttpService.RequestFail failure, bool retry = true)
		{
		}

		[Address(RVA="0x141C224", Offset="0x141C224", VA="0x141C224")]
		public IWebRequestHandle GetAssetBundle(string bundleUrl, Hash128 bundleHash, uint crc, HttpService.RequestAssetBundleSuccess success, HttpService.RequestFail failure)
		{
			return null;
		}

		[Address(RVA="0x1429068", Offset="0x1429068", VA="0x1429068")]
		private HttpService.RequestHandle GetAssetBundle(string bundleUrl, Hash128 bundleHash, uint crc, HttpService.RequestAssetBundleSuccess success, HttpService.RequestFail failure, HttpService.RequestHandle requestHandle)
		{
			return null;
		}

		[Address(RVA="0x14294A4", Offset="0x14294A4", VA="0x14294A4")]
		private byte[] GetData(UnityWebRequest request)
		{
			return null;
		}

		[Address(RVA="0x1429390", Offset="0x1429390", VA="0x1429390", Slot="4")]
		public void HandleDispatchAction(DServiceNetworkRetryAction action)
		{
		}

		[Address(RVA="0x1428D40", Offset="0x1428D40", VA="0x1428D40")]
		public void Head(string url, HttpService.RequestHeadersSuccess success, HttpService.RequestFail failure, bool retry = true)
		{
		}

		[Address(RVA="0x1428B1C", Offset="0x1428B1C", VA="0x1428B1C")]
		public void Initialize()
		{
		}

		[Address(RVA="0x1427C0C", Offset="0x1427C0C", VA="0x1427C0C")]
		public void Post(string url, byte[] uploadData, HttpService.RequestBodySuccess success, HttpService.RequestFail failure, bool retry = true)
		{
		}

		[Address(RVA="0x1429394", Offset="0x1429394", VA="0x1429394")]
		private void Retry()
		{
		}

		[Address(RVA="0x1428BC4", Offset="0x1428BC4", VA="0x1428BC4")]
		private void SendRequest(HttpService.RequestHandle requestHandle, HttpService.RequestBodySuccess success, HttpService.RequestFail failure, Action retry)
		{
		}

		[Address(RVA="0x1428F04", Offset="0x1428F04", VA="0x1428F04")]
		private void SendRequest(UnityWebRequest request, HttpService.RequestHeadersSuccess success, HttpService.RequestFail failure, Action retry)
		{
		}

		[Address(RVA="0x1428B50", Offset="0x1428B50", VA="0x1428B50")]
		public void Shutdown()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051048", Offset="0x1051048")]
		private sealed class <>c__DisplayClass12_0
		{
			[FieldOffset(Offset="0x10")]
			public HttpService.RequestAssetBundleSuccess success;

			[FieldOffset(Offset="0x18")]
			public UnityWebRequest request;

			[FieldOffset(Offset="0x20")]
			public HttpService.RequestFail failure;

			[FieldOffset(Offset="0x28")]
			public HttpService <>4__this;

			[FieldOffset(Offset="0x30")]
			public string bundleUrl;

			[FieldOffset(Offset="0x38")]
			public Hash128 bundleHash;

			[FieldOffset(Offset="0x48")]
			public uint crc;

			[FieldOffset(Offset="0x50")]
			public HttpService.RequestHandle requestHandle;

			[Address(RVA="0x1429484", Offset="0x1429484", VA="0x1429484")]
			public <>c__DisplayClass12_0()
			{
			}

			[Address(RVA="0x1429644", Offset="0x1429644", VA="0x1429644")]
			internal void <GetAssetBundle>b__0(byte[] data)
			{
			}

			[Address(RVA="0x142A340", Offset="0x142A340", VA="0x142A340")]
			internal void <GetAssetBundle>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051058", Offset="0x1051058")]
		private sealed class <>c__DisplayClass13_0
		{
			[FieldOffset(Offset="0x10")]
			public HttpService.RequestHandle requestHandle;

			[FieldOffset(Offset="0x18")]
			public Action retry;

			[FieldOffset(Offset="0x20")]
			public HttpService <>4__this;

			[FieldOffset(Offset="0x28")]
			public HttpService.RequestFail failure;

			[FieldOffset(Offset="0x30")]
			public HttpService.RequestBodySuccess success;

			[Address(RVA="0x1429494", Offset="0x1429494", VA="0x1429494")]
			public <>c__DisplayClass13_0()
			{
			}

			[Address(RVA="0x142A3C0", Offset="0x142A3C0", VA="0x142A3C0")]
			internal void <SendRequest>b__0(AsyncOperation asyncOp)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051068", Offset="0x1051068")]
		private sealed class <>c__DisplayClass15_0
		{
			[FieldOffset(Offset="0x10")]
			public UnityWebRequest request;

			[FieldOffset(Offset="0x18")]
			public Action retry;

			[FieldOffset(Offset="0x20")]
			public HttpService <>4__this;

			[FieldOffset(Offset="0x28")]
			public HttpService.RequestFail failure;

			[FieldOffset(Offset="0x30")]
			public HttpService.RequestHeadersSuccess success;

			[Address(RVA="0x14295CC", Offset="0x14295CC", VA="0x14295CC")]
			public <>c__DisplayClass15_0()
			{
			}

			[Address(RVA="0x142AF34", Offset="0x142AF34", VA="0x142AF34")]
			internal void <SendRequest>b__0(AsyncOperation asyncOp)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051018", Offset="0x1051018")]
		private sealed class <>c__DisplayClass7_0
		{
			[FieldOffset(Offset="0x10")]
			public HttpService <>4__this;

			[FieldOffset(Offset="0x18")]
			public string url;

			[FieldOffset(Offset="0x20")]
			public HttpService.RequestBodySuccess success;

			[FieldOffset(Offset="0x28")]
			public HttpService.RequestFail failure;

			[FieldOffset(Offset="0x30")]
			public bool retry;

			[Address(RVA="0x1428B84", Offset="0x1428B84", VA="0x1428B84")]
			public <>c__DisplayClass7_0()
			{
			}

			[Address(RVA="0x142B800", Offset="0x142B800", VA="0x142B800")]
			internal void <Get>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051028", Offset="0x1051028")]
		private sealed class <>c__DisplayClass8_0
		{
			[FieldOffset(Offset="0x10")]
			public HttpService <>4__this;

			[FieldOffset(Offset="0x18")]
			public string url;

			[FieldOffset(Offset="0x20")]
			public byte[] uploadData;

			[FieldOffset(Offset="0x28")]
			public HttpService.RequestBodySuccess success;

			[FieldOffset(Offset="0x30")]
			public HttpService.RequestFail failure;

			[FieldOffset(Offset="0x38")]
			public bool retry;

			[Address(RVA="0x1428D38", Offset="0x1428D38", VA="0x1428D38")]
			public <>c__DisplayClass8_0()
			{
			}

			[Address(RVA="0x142B858", Offset="0x142B858", VA="0x142B858")]
			internal void <Post>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051038", Offset="0x1051038")]
		private sealed class <>c__DisplayClass9_0
		{
			[FieldOffset(Offset="0x10")]
			public HttpService <>4__this;

			[FieldOffset(Offset="0x18")]
			public string url;

			[FieldOffset(Offset="0x20")]
			public HttpService.RequestHeadersSuccess success;

			[FieldOffset(Offset="0x28")]
			public HttpService.RequestFail failure;

			[FieldOffset(Offset="0x30")]
			public bool retry;

			[Address(RVA="0x1428EFC", Offset="0x1428EFC", VA="0x1428EFC")]
			public <>c__DisplayClass9_0()
			{
			}

			[Address(RVA="0x142B8B8", Offset="0x142B8B8", VA="0x142B8B8")]
			internal void <Head>b__0()
			{
			}
		}

		public delegate void RequestAssetBundleSuccess(AssetBundle bundle);

		public delegate void RequestBodySuccess(byte[] data);

		public delegate void RequestFail(long errorCode, byte[] data);

		private class RequestHandle : IWebRequestHandle
		{
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106CA84", Offset="0x106CA84")]
			[FieldOffset(Offset="0x10")]
			private UnityWebRequest <CurrentRequest>k__BackingField;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106CA94", Offset="0x106CA94")]
			[FieldOffset(Offset="0x18")]
			private bool <Silent>k__BackingField;

			public UnityWebRequest CurrentRequest
			{
				[Address(RVA="0x142949C", Offset="0x142949C", VA="0x142949C", Slot="4")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E3E0", Offset="0x108E3E0")]
				get
				{
					return get_CurrentRequest();
				}
				[Address(RVA="0x142948C", Offset="0x142948C", VA="0x142948C")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E3F0", Offset="0x108E3F0")]
				set
				{
					set_CurrentRequest(value);
				}
			}

			public UnityWebRequest get_CurrentRequest()
			{
				return null;
			}

			public void set_CurrentRequest(UnityWebRequest value)
			{
			}

			public bool Silent
			{
				[Address(RVA="0x142A7F8", Offset="0x142A7F8", VA="0x142A7F8", Slot="5")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E400", Offset="0x108E400")]
				get
				{
					return new bool();
				}
				[Address(RVA="0x1428BB8", Offset="0x1428BB8", VA="0x1428BB8", Slot="6")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108E410", Offset="0x108E410")]
				set
				{
				}
			}

			[Address(RVA="0x1428B8C", Offset="0x1428B8C", VA="0x1428B8C")]
			public RequestHandle(UnityWebRequest request)
			{
			}
		}

		public delegate void RequestHeadersSuccess(Dictionary<string, string> data);

		public delegate void RequestUpdated(UnityWebRequest request);
	}
}