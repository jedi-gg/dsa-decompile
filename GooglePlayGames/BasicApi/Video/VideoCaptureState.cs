using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.Video
{
	public class VideoCaptureState
	{
		[FieldOffset(Offset="0x10")]
		private bool mIsCapturing;

		[FieldOffset(Offset="0x14")]
		private VideoCaptureMode mCaptureMode;

		[FieldOffset(Offset="0x18")]
		private VideoQualityLevel mQualityLevel;

		[FieldOffset(Offset="0x1C")]
		private bool mIsOverlayVisible;

		[FieldOffset(Offset="0x1D")]
		private bool mIsPaused;

		public VideoCaptureMode CaptureMode
		{
			[Address(RVA="0x12D3710", Offset="0x12D3710", VA="0x12D3710")]
			get
			{
				return new VideoCaptureMode();
			}
		}

		public bool IsCapturing
		{
			[Address(RVA="0x12D3708", Offset="0x12D3708", VA="0x12D3708")]
			get
			{
				return new bool();
			}
		}

		public bool IsOverlayVisible
		{
			[Address(RVA="0x12D3720", Offset="0x12D3720", VA="0x12D3720")]
			get
			{
				return new bool();
			}
		}

		public bool IsPaused
		{
			[Address(RVA="0x12D3728", Offset="0x12D3728", VA="0x12D3728")]
			get
			{
				return new bool();
			}
		}

		public VideoQualityLevel QualityLevel
		{
			[Address(RVA="0x12D3718", Offset="0x12D3718", VA="0x12D3718")]
			get
			{
				return new VideoQualityLevel();
			}
		}

		[Address(RVA="0x12D36A4", Offset="0x12D36A4", VA="0x12D36A4")]
		internal VideoCaptureState(bool isCapturing, VideoCaptureMode captureMode, VideoQualityLevel qualityLevel, bool isOverlayVisible, bool isPaused)
		{
		}

		[Address(RVA="0x12D3730", Offset="0x12D3730", VA="0x12D3730", Slot="3")]
		public override string ToString()
		{
			return null;
		}
	}
}