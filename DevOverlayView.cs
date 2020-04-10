using Glunies;
using Il2CppDummyDll;
using System;

public class DevOverlayView : AView
{
	[FieldOffset(Offset="0x0")]
	private const float BYTES_IN_MB = 1048576f;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1057B34", Offset="0x1057B34")]
	[FieldOffset(Offset="0x68")]
	private readonly bool <WillHandleBackButton>k__BackingField;

	[FieldOffset(Offset="0x70")]
	private char[] _syncTimeCharBuffer;

	[FieldOffset(Offset="0x78")]
	private LocalizedNumberFormatters _defaultLocalizedNumberFormatters;

	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x1202610", Offset="0x1202610", VA="0x1202610", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public override ViewDepth Depth
	{
		[Address(RVA="0x1202608", Offset="0x1202608", VA="0x1202608", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private DevOverlayView.SerializedFields Fields
	{
		[Address(RVA="0x120285C", Offset="0x120285C", VA="0x120285C")]
		get
		{
			return null;
		}
	}

	protected override bool WillHandleBackButton
	{
		[Address(RVA="0x12031AC", Offset="0x12031AC", VA="0x12031AC", Slot="19")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F4D4", Offset="0x106F4D4")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x12031B4", Offset="0x12031B4", VA="0x12031B4")]
	public DevOverlayView()
	{
	}

	[Address(RVA="0x12029E4", Offset="0x12029E4", VA="0x12029E4")]
	public void SetAssetVersion(string assetVersion)
	{
	}

	[Address(RVA="0x1202FF4", Offset="0x1202FF4", VA="0x1202FF4")]
	public void SetAudioMetrics(int activeAudio, int activeMusic)
	{
	}

	[Address(RVA="0x1202B30", Offset="0x1202B30", VA="0x1202B30")]
	public void SetBattleMetrics(uint mem, float lastUpdateTimeMs, float avgUpdateTimeMs, float lastPayloadBytes, float totalPayloadKB)
	{
	}

	[Address(RVA="0x120293C", Offset="0x120293C", VA="0x120293C")]
	public void SetGamedataVersion(string gamedataVersion)
	{
	}

	[Address(RVA="0x1202A8C", Offset="0x1202A8C", VA="0x1202A8C")]
	public void SetPerfMetrics(long unityMem, float fps)
	{
	}

	[Address(RVA="0x1202F18", Offset="0x1202F18", VA="0x1202F18")]
	public void SetSyncTime(DateTime syncTime)
	{
	}

	[Address(RVA="0x1202618", Offset="0x1202618", VA="0x1202618")]
	public void SetVersion(string appVersion, string bootstrapVersion)
	{
	}

	[Address(RVA="0x1202ED0", Offset="0x1202ED0", VA="0x1202ED0")]
	public void ShowBattleMetrics(bool show)
	{
	}

	[Address(RVA="0x1202F74", Offset="0x1202F74", VA="0x1202F74")]
	public void ToggleAudioMetrics()
	{
	}

	[Address(RVA="0x12030C8", Offset="0x12030C8", VA="0x12030C8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1203184", Offset="0x1203184", VA="0x1203184", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public UiLabel VersionLabel;

		[FieldOffset(Offset="0x30")]
		public UiLabel BattleMetricsLabel;

		[FieldOffset(Offset="0x38")]
		public UiLabel PerfMetricsLabel;

		[FieldOffset(Offset="0x40")]
		public UiLabel AudioMetricsLabel;

		[FieldOffset(Offset="0x48")]
		public UiLabel SyncTimeLabel;

		[FieldOffset(Offset="0x50")]
		public UiLabel GamedataVersionLabel;

		[FieldOffset(Offset="0x58")]
		public UiLabel AssetVersionLabel;

		[Address(RVA="0x1203234", Offset="0x1203234", VA="0x1203234")]
		public SerializedFields()
		{
		}
	}
}