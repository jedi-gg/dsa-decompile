using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.Video
{
	public class VideoCapabilities
	{
		[FieldOffset(Offset="0x10")]
		private bool mIsCameraSupported;

		[FieldOffset(Offset="0x11")]
		private bool mIsMicSupported;

		[FieldOffset(Offset="0x12")]
		private bool mIsWriteStorageSupported;

		[FieldOffset(Offset="0x18")]
		private bool[] mCaptureModesSupported;

		[FieldOffset(Offset="0x20")]
		private bool[] mQualityLevelsSupported;

		public bool IsCameraSupported
		{
			[Address(RVA="0x12D2F44", Offset="0x12D2F44", VA="0x12D2F44")]
			get
			{
				return new bool();
			}
		}

		public bool IsMicSupported
		{
			[Address(RVA="0x12D2F4C", Offset="0x12D2F4C", VA="0x12D2F4C")]
			get
			{
				return new bool();
			}
		}

		public bool IsWriteStorageSupported
		{
			[Address(RVA="0x12D2F54", Offset="0x12D2F54", VA="0x12D2F54")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x12D2EE0", Offset="0x12D2EE0", VA="0x12D2EE0")]
		internal VideoCapabilities(bool isCameraSupported, bool isMicSupported, bool isWriteStorageSupported, bool[] captureModesSupported, bool[] qualityLevelsSupported)
		{
		}

		[Address(RVA="0x12D2F5C", Offset="0x12D2F5C", VA="0x12D2F5C")]
		public bool SupportsCaptureMode(VideoCaptureMode captureMode)
		{
			return new bool();
		}

		[Address(RVA="0x12D3120", Offset="0x12D3120", VA="0x12D3120")]
		public bool SupportsQualityLevel(VideoQualityLevel qualityLevel)
		{
			return new bool();
		}

		[Address(RVA="0x12D31EC", Offset="0x12D31EC", VA="0x12D31EC", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ED48", Offset="0x104ED48")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static VideoCapabilities.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<bool, string> <>9__14_0;

			[FieldOffset(Offset="0x10")]
			public static Func<bool, string> <>9__14_1;

			[Address(RVA="0x12D35E0", Offset="0x12D35E0", VA="0x12D35E0")]
			static <>c()
			{
			}

			[Address(RVA="0x12D3644", Offset="0x12D3644", VA="0x12D3644")]
			public <>c()
			{
			}

			[Address(RVA="0x12D364C", Offset="0x12D364C", VA="0x12D364C")]
			internal string <ToString>b__14_0(bool p)
			{
				return null;
			}

			[Address(RVA="0x12D3678", Offset="0x12D3678", VA="0x12D3678")]
			internal string <ToString>b__14_1(bool p)
			{
				return null;
			}
		}
	}
}