using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Video;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidVideoClient : IVideoClient
	{
		[FieldOffset(Offset="0x10")]
		private AndroidJavaObject mVideosClient;

		[FieldOffset(Offset="0x18")]
		private bool mIsCaptureSupported;

		[FieldOffset(Offset="0x20")]
		private AndroidVideoClient.OnCaptureOverlayStateListenerProxy mOnCaptureOverlayStateListenerProxy;

		[Address(RVA="0x1EC1464", Offset="0x1EC1464", VA="0x1EC1464")]
		public AndroidVideoClient(bool isCaptureSupported, AndroidJavaObject account)
		{
		}

		[Address(RVA="0x1EC248C", Offset="0x1EC248C", VA="0x1EC248C")]
		private static VideoCapabilities CreateVideoCapabilities(AndroidJavaObject videoCapabilities)
		{
			return null;
		}

		[Address(RVA="0x1EC22A8", Offset="0x1EC22A8", VA="0x1EC22A8")]
		private static VideoCaptureState CreateVideoCaptureState(AndroidJavaObject videoCaptureState)
		{
			return null;
		}

		[Address(RVA="0x1EC2294", Offset="0x1EC2294", VA="0x1EC2294")]
		private static VideoCaptureMode FromVideoCaptureMode(int captureMode)
		{
			return new VideoCaptureMode();
		}

		[Address(RVA="0x1EC2288", Offset="0x1EC2288", VA="0x1EC2288")]
		private static VideoQualityLevel FromVideoQualityLevel(int captureQualityJava)
		{
			return new VideoQualityLevel();
		}

		[Address(RVA="0x1EC16C4", Offset="0x1EC16C4", VA="0x1EC16C4", Slot="4")]
		public void GetCaptureCapabilities(Action<ResponseStatus, VideoCapabilities> callback)
		{
		}

		[Address(RVA="0x1EC1950", Offset="0x1EC1950", VA="0x1EC1950", Slot="6")]
		public void GetCaptureState(Action<ResponseStatus, VideoCaptureState> callback)
		{
		}

		[Address(RVA="0x1EC1BD4", Offset="0x1EC1BD4", VA="0x1EC1BD4", Slot="7")]
		public void IsCaptureAvailable(VideoCaptureMode captureMode, Action<ResponseStatus, bool> callback)
		{
		}

		[Address(RVA="0x1EC1EF4", Offset="0x1EC1EF4", VA="0x1EC1EF4", Slot="8")]
		public bool IsCaptureSupported()
		{
			return new bool();
		}

		[Address(RVA="0x1EC1EFC", Offset="0x1EC1EFC", VA="0x1EC1EFC", Slot="9")]
		public void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListener listener)
		{
		}

		[Address(RVA="0x1EC1948", Offset="0x1EC1948", VA="0x1EC1948", Slot="5")]
		public void ShowCaptureOverlay()
		{
		}

		[Address(RVA="0x1F5D110", Offset="0x1F5D110", VA="0x1F5D110")]
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}

		[Address(RVA="0x1EC1EE0", Offset="0x1EC1EE0", VA="0x1EC1EE0")]
		private static int ToVideoCaptureMode(VideoCaptureMode captureMode)
		{
			return new int();
		}

		[Address(RVA="0x1EC209C", Offset="0x1EC209C", VA="0x1EC209C", Slot="10")]
		public void UnregisterCaptureOverlayStateChangedListener()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ECD8", Offset="0x104ECD8")]
		private sealed class <>c__DisplayClass12_0<T1, T2>
		{
			[FieldOffset(Offset="0x0")]
			public Action<T1, T2> toConvert;

			[Address(RVA="0x1D8E95C", Offset="0x1D8E95C", VA="0x1D8E95C")]
			public <>c__DisplayClass12_0()
			{
			}

			[Address(RVA="0x1D8E988", Offset="0x1D8E988", VA="0x1D8E988")]
			internal void <ToOnGameThread>b__0(T1 val1, T2 val2)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ECE8", Offset="0x104ECE8")]
		private sealed class <>c__DisplayClass12_1<T1, T2>
		{
			[FieldOffset(Offset="0x0")]
			public T1 val1;

			[FieldOffset(Offset="0x0")]
			public T2 val2;

			[FieldOffset(Offset="0x0")]
			public AndroidVideoClient.<>c__DisplayClass12_0<T1, T2> CS$<>8__locals1;

			[Address(RVA="0x1D8ED5C", Offset="0x1D8ED5C", VA="0x1D8ED5C")]
			public <>c__DisplayClass12_1()
			{
			}

			[Address(RVA="0x1D8ED88", Offset="0x1D8ED88", VA="0x1D8ED88")]
			internal void <ToOnGameThread>b__1()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ECA8", Offset="0x104ECA8")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<ResponseStatus, VideoCapabilities> callback;

			[Address(RVA="0x1EC1940", Offset="0x1EC1940", VA="0x1EC1940")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x1EC265C", Offset="0x1EC265C", VA="0x1EC265C")]
			internal void <GetCaptureCapabilities>b__0(AndroidJavaObject videoCapabilities)
			{
			}

			[Address(RVA="0x1EC26DC", Offset="0x1EC26DC", VA="0x1EC26DC")]
			internal void <GetCaptureCapabilities>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ECB8", Offset="0x104ECB8")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<ResponseStatus, VideoCaptureState> callback;

			[Address(RVA="0x1EC1BCC", Offset="0x1EC1BCC", VA="0x1EC1BCC")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x1EC2744", Offset="0x1EC2744", VA="0x1EC2744")]
			internal void <GetCaptureState>b__0(AndroidJavaObject captureState)
			{
			}

			[Address(RVA="0x1EC27C4", Offset="0x1EC27C4", VA="0x1EC27C4")]
			internal void <GetCaptureState>b__1(AndroidJavaObject exception)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ECC8", Offset="0x104ECC8")]
		private sealed class <>c__DisplayClass7_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<ResponseStatus, bool> callback;

			[Address(RVA="0x1EC1ED8", Offset="0x1EC1ED8", VA="0x1EC1ED8")]
			public <>c__DisplayClass7_0()
			{
			}

			[Address(RVA="0x1EC282C", Offset="0x1EC282C", VA="0x1EC282C")]
			internal void <IsCaptureAvailable>b__0(bool isCaptureAvailable)
			{
			}

			[Address(RVA="0x1EC28A0", Offset="0x1EC28A0", VA="0x1EC28A0")]
			internal void <IsCaptureAvailable>b__1(AndroidJavaObject exception)
			{
			}
		}

		private class OnCaptureOverlayStateListenerProxy : AndroidJavaProxy
		{
			[FieldOffset(Offset="0x20")]
			private CaptureOverlayStateListener mListener;

			[Address(RVA="0x1EC2200", Offset="0x1EC2200", VA="0x1EC2200")]
			public OnCaptureOverlayStateListenerProxy(CaptureOverlayStateListener listener)
			{
			}

			[Address(RVA="0x1EC29F4", Offset="0x1EC29F4", VA="0x1EC29F4")]
			private static VideoCaptureOverlayState FromVideoCaptureOverlayState(int overlayState)
			{
				return new VideoCaptureOverlayState();
			}

			[Address(RVA="0x1EC2908", Offset="0x1EC2908", VA="0x1EC2908")]
			public void onCaptureOverlayStateChanged(int overlayState)
			{
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051648", Offset="0x1051648")]
			private sealed class <>c__DisplayClass2_0
			{
				[FieldOffset(Offset="0x10")]
				public AndroidVideoClient.OnCaptureOverlayStateListenerProxy <>4__this;

				[FieldOffset(Offset="0x18")]
				public int overlayState;

				[Address(RVA="0x1EC29EC", Offset="0x1EC29EC", VA="0x1EC29EC")]
				public <>c__DisplayClass2_0()
				{
				}

				[Address(RVA="0x1EC2A04", Offset="0x1EC2A04", VA="0x1EC2A04")]
				internal void <onCaptureOverlayStateChanged>b__0()
				{
				}
			}
		}
	}
}