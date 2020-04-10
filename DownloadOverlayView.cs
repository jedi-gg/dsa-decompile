using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class DownloadOverlayView : AView
{
	[FieldOffset(Offset="0x0")]
	private const float BYTES_IN_MB = 1048576f;

	[FieldOffset(Offset="0x68")]
	private Sequence _showSequence;

	[FieldOffset(Offset="0x70")]
	private Sequence _hideSequence;

	[FieldOffset(Offset="0x78")]
	private ulong _currentBytesDownloaded;

	[FieldOffset(Offset="0x80")]
	private ulong _currentTotalBytes;

	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x120570C", Offset="0x120570C", VA="0x120570C", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public override ViewDepth Depth
	{
		[Address(RVA="0x1205704", Offset="0x1205704", VA="0x1205704", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private DownloadOverlayView.SerializedFields Fields
	{
		[Address(RVA="0x12058D4", Offset="0x12058D4", VA="0x12058D4")]
		get
		{
			return null;
		}
	}

	protected override bool WillHandleBackButton
	{
		[Address(RVA="0x1205CC4", Offset="0x1205CC4", VA="0x1205CC4", Slot="19")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1205CCC", Offset="0x1205CCC", VA="0x1205CCC")]
	public DownloadOverlayView()
	{
	}

	[Address(RVA="0x1205CD4", Offset="0x1205CD4", VA="0x1205CD4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F594", Offset="0x106F594")]
	private void <ViewAssetLoaded>b__9_0()
	{
	}

	[Address(RVA="0x1205528", Offset="0x1205528", VA="0x1205528")]
	public void Hide()
	{
	}

	[Address(RVA="0x1205714", Offset="0x1205714", VA="0x1205714", Slot="10")]
	public override bool IsShowing()
	{
		return new bool();
	}

	[Address(RVA="0x120512C", Offset="0x120512C", VA="0x120512C")]
	public void SetDownloadProgress(ulong bytesDownloaded, ulong totalBytes)
	{
	}

	[Address(RVA="0x1205244", Offset="0x1205244", VA="0x1205244")]
	public void Show()
	{
	}

	[Address(RVA="0x1205420", Offset="0x1205420", VA="0x1205420")]
	public void Suppress(bool suppress)
	{
	}

	[Address(RVA="0x120576C", Offset="0x120576C", VA="0x120576C")]
	private void ValidateFonts()
	{
	}

	[Address(RVA="0x12059B4", Offset="0x12059B4", VA="0x12059B4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1205C70", Offset="0x1205C70", VA="0x1205C70", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public RectTransform Container;

		[FieldOffset(Offset="0x30")]
		public UiLabel ProgressLabel;

		[Address(RVA="0x1205CE0", Offset="0x1205CE0", VA="0x1205CE0")]
		public SerializedFields()
		{
		}
	}
}