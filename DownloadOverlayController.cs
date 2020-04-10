using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class DownloadOverlayController : IDispatchHandler<DBundleDownloadStatus>, IDispatchHandler, IDispatchHandler<DTitleViewAction>
{
	[FieldOffset(Offset="0x0")]
	private const float RESET_DELAY_S = 0.5f;

	[FieldOffset(Offset="0x0")]
	private const float STATUS_UPDATE_THROTTLE_S = 0.1f;

	[Attribute(Name="InjectAttribute", RVA="0x1057BE4", Offset="0x1057BE4")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1057BF4", Offset="0x1057BF4")]
	[FieldOffset(Offset="0x18")]
	private ViewController _viewController;

	[FieldOffset(Offset="0x20")]
	private DownloadOverlayView _view;

	[FieldOffset(Offset="0x28")]
	private Dictionary<string, DownloadOverlayController.DownloadData> _downloadData;

	[FieldOffset(Offset="0x30")]
	private bool _isDirty;

	[FieldOffset(Offset="0x34")]
	private float _resetTimerS;

	[FieldOffset(Offset="0x38")]
	private float _nextStatusUpdateTimeS;

	[FieldOffset(Offset="0x3C")]
	private bool _isShutdown;

	[Address(RVA="0x1205620", Offset="0x1205620", VA="0x1205620")]
	public DownloadOverlayController()
	{
	}

	[Address(RVA="0x1204F48", Offset="0x1204F48", VA="0x1204F48")]
	private bool CalculateDownloadStatus(out ulong totalBytes, out ulong bytesDownloaded)
	{
		totalBytes = 0L;
		bytesDownloaded = 0L;
		return new bool();
	}

	[Address(RVA="0x12052B8", Offset="0x12052B8", VA="0x12052B8", Slot="4")]
	public void HandleDispatchAction(DBundleDownloadStatus status)
	{
	}

	[Address(RVA="0x12053F0", Offset="0x12053F0", VA="0x12053F0", Slot="5")]
	public void HandleDispatchAction(DTitleViewAction action)
	{
	}

	[Address(RVA="0x1204A70", Offset="0x1204A70", VA="0x1204A70")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x1205508", Offset="0x1205508", VA="0x1205508")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x1204CAC", Offset="0x1204CAC", VA="0x1204CAC")]
	private void Reset()
	{
	}

	[Address(RVA="0x1204C3C", Offset="0x1204C3C", VA="0x1204C3C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1204D28", Offset="0x1204D28", VA="0x1204D28")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BD2C", Offset="0x104BD2C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public DownloadOverlayController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1204C34", Offset="0x1204C34", VA="0x1204C34")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1205690", Offset="0x1205690", VA="0x1205690")]
		internal void <Initialize>b__0(DownloadOverlayView view)
		{
		}
	}

	private class DownloadData
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106A434", Offset="0x106A434")]
		[FieldOffset(Offset="0x10")]
		private bool <IsFinished>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106A444", Offset="0x106A444")]
		[FieldOffset(Offset="0x18")]
		private ulong <BytesDownloaded>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106A454", Offset="0x106A454")]
		[FieldOffset(Offset="0x20")]
		private ulong <TotalBytes>k__BackingField;

		public ulong BytesDownloaded
		{
			[Address(RVA="0x1205520", Offset="0x1205520", VA="0x1205520")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B258", Offset="0x108B258")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x12056F4", Offset="0x12056F4", VA="0x12056F4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B268", Offset="0x108B268")]
			private set
			{
			}
		}

		public bool IsFinished
		{
			[Address(RVA="0x1205510", Offset="0x1205510", VA="0x1205510")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B238", Offset="0x108B238")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x12056E8", Offset="0x12056E8", VA="0x12056E8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B248", Offset="0x108B248")]
			private set
			{
			}
		}

		public ulong TotalBytes
		{
			[Address(RVA="0x1205518", Offset="0x1205518", VA="0x1205518")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B278", Offset="0x108B278")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x12056FC", Offset="0x12056FC", VA="0x12056FC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108B288", Offset="0x108B288")]
			private set
			{
			}
		}

		[Address(RVA="0x12053C4", Offset="0x12053C4", VA="0x12053C4")]
		public DownloadData()
		{
		}

		[Address(RVA="0x12053CC", Offset="0x12053CC", VA="0x12053CC")]
		public void Update(DBundleDownloadStatus status)
		{
		}
	}
}